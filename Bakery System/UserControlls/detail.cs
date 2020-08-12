using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Bakery_System.UserControlls
{
    public partial class detail : UserControl
    {
        int checker = 0;

        public detail()
        {
            InitializeComponent();
            stockProfitPaneldetail.Visible = false;
            salaryPanelDetail.Visible = false;
            attendancedetailPanel.Visible = false;
          //  attendanceFunction();
           // displaystockProfitDetail();
        }

        private void detail_Load(object sender, EventArgs e)
        {
            detail dt = sender as detail;
            stockProfitPaneldetail.Parent = dt;
            salaryPanelDetail.Parent = dt;
            stockProfitPaneldetail.Left = 212;
            stockProfitPaneldetail.Top = 52;
            salaryPanelDetail.Left = 212;
            salaryPanelDetail.Top = 52;

            attendancedetailPanel.Parent = dt;
            attendancedetailPanel.Left = 212;
            attendancedetailPanel.Top = 52;

            SetMyCustomFormat();
            
        }

        private void detailProductRevenuetxt_TextChanged(object sender, EventArgs e)
        {
            
            int salePrice, itemsLeft, totalProducts, earnProfit, saleItems, earnProfitPerItem, buyingPrice;
            loginForm.conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM [mart_product] WHERE product_name LIKE '%" + detailProductRevenuetxt.Text + "%'", loginForm.conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            stockProfitDetailDataGridView.Rows.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                int n = stockProfitDetailDataGridView.Rows.Add();

                stockProfitDetailDataGridView.Rows[n].Cells["detailstocknamegridview"].Value = dr["product_name"].ToString();

                totalProducts = Convert.ToInt32(dr["product_quantity"].ToString());
                stockProfitDetailDataGridView.Rows[n].Cells["detailstocktotalItemsgridview"].Value = totalProducts.ToString();

                itemsLeft = Convert.ToInt32(dr["product_sale"].ToString());
                stockProfitDetailDataGridView.Rows[n].Cells["detailstockitemsleftgridview"].Value = itemsLeft.ToString();

                saleItems = totalProducts - itemsLeft;

                stockProfitDetailDataGridView.Rows[n].Cells["detailStockItemSoldGridView"].Value = saleItems.ToString();

                buyingPrice = Convert.ToInt32(dr["buying_price_per_item"]);
                stockProfitDetailDataGridView.Rows[n].Cells["detailStockItemBuyingPricePerItem"].Value = buyingPrice.ToString();


                stockProfitDetailDataGridView.Rows[n].Cells["detailstockprofitperitemgridview"].Value = dr["product_price_per_item"].ToString();
                salePrice = Convert.ToInt32(dr["product_price_per_item"].ToString());

                earnProfitPerItem = saleItems * (salePrice - buyingPrice);
                
                stockProfitDetailDataGridView.Rows[n].Cells["detailStockProfitGridView"].Value = earnProfitPerItem.ToString();

                earnProfit = saleItems * salePrice;

                stockProfitDetailDataGridView.Rows[n].Cells["detailstockprofitearngridview"].Value = earnProfit.ToString();
            }
            loginForm.conn.Close();

        }
        
        public void displaystockProfitDetail()
        {
            int salePrice, itemsLeft, totalProducts, earnProfit, saleItems, earnProfitPerItem, buyingPrice;
            string query = "SELECT * FROM [mart_product]";
            loginForm.conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query, loginForm.conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            stockProfitDetailDataGridView.Rows.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                int n = stockProfitDetailDataGridView.Rows.Add();

                stockProfitDetailDataGridView.Rows[n].Cells["detailstocknamegridview"].Value = dr["product_name"].ToString();

                totalProducts = Convert.ToInt32(dr["product_quantity"].ToString());
                stockProfitDetailDataGridView.Rows[n].Cells["detailstocktotalItemsgridview"].Value = totalProducts.ToString();

                itemsLeft = Convert.ToInt32(dr["product_sale"].ToString());
                stockProfitDetailDataGridView.Rows[n].Cells["detailstockitemsleftgridview"].Value = itemsLeft.ToString();

                saleItems = totalProducts - itemsLeft;

                stockProfitDetailDataGridView.Rows[n].Cells["detailStockItemSoldGridView"].Value = saleItems.ToString();

                buyingPrice = Convert.ToInt32(dr["buying_price_per_item"]);
                stockProfitDetailDataGridView.Rows[n].Cells["detailStockItemBuyingPricePerItem"].Value = buyingPrice.ToString();


                stockProfitDetailDataGridView.Rows[n].Cells["detailstockprofitperitemgridview"].Value = dr["product_price_per_item"].ToString();
                salePrice = Convert.ToInt32(dr["product_price_per_item"].ToString());

                earnProfitPerItem = saleItems * (salePrice - buyingPrice);

                stockProfitDetailDataGridView.Rows[n].Cells["detailStockProfitGridView"].Value = earnProfitPerItem.ToString();

                earnProfit = saleItems * salePrice;

                stockProfitDetailDataGridView.Rows[n].Cells["detailstockprofitearngridview"].Value = earnProfit.ToString();
            }
            loginForm.conn.Close();
        }
        
        
        void attendanceFunction()
        {
            int index = 1;

            string sDate = DateTime.Now.ToString();
            DateTime datevalue = (Convert.ToDateTime(sDate.ToString()));
            string dy = datevalue.Day.ToString();
            string mn = datevalue.Month.ToString();
            string yy = datevalue.Year.ToString();

            string query = "SELECT * FROM emp_attendance WHERE attend_empYear LIKE '%" + yy + "%' AND attend_empMonth LIKE '%" + mn + "%'";
            loginForm.conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query, loginForm.conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            employeeattendencegridview.Rows.Clear();
            foreach (DataRow rows in dt.Rows)
            {
                int n = employeeattendencegridview.Rows.Add();
                employeeattendencegridview.Rows[n].Cells["attendanceemployeeiddatagridview"].Value = index.ToString();
                employeeattendencegridview.Rows[n].Cells["attendanceemployeecodedatagridview"].Value = rows["attend_empcode"].ToString();
                employeeattendencegridview.Rows[n].Cells["attendanceemployeeNamedatagridview"].Value = rows["attend_empname"].ToString();
                employeeattendencegridview.Rows[n].Cells["attendanceemployeeAttendancedatagridview"].Value = rows["attend_empStatus"].ToString();
                //employeeattendencegridview.Rows[n].Cells["attendanceemployeecodedatagridview"].Value = rows["attend_empcode"].ToString();
                employeeattendencegridview.Rows[n].Cells["attendanceemployeeDatedatagridview"].Value = rows["attend_empDate"].ToString() + "/" + rows["attend_empMonth"].ToString() + "/" + rows["attend_empYear"].ToString();
                index += 1;
            }
            loginForm.conn.Close();

        }
        
        public void SetMyCustomFormat()
        {
            // Set the Format type and the CustomFormat string.
            attendanceMonthpicker.Format = DateTimePickerFormat.Custom;
            attendanceMonthpicker.CustomFormat = "MM";
            attendanceYearpicker.Format = DateTimePickerFormat.Custom;
            attendanceYearpicker.CustomFormat = "yyyy";
        }

        private void saveSalarydatabtn_Click(object sender, EventArgs e)
        {
            loginForm.conn.Open();
            string query = "INSERT INTO [emp_salary](salary_status, salary_rupees) VALUES (@salary_status, @salary_rupees)";
            SqlCommand cmd = new SqlCommand(query, loginForm.conn);
            cmd.Parameters.AddWithValue("@salary_status", detailsalaryCategorytxt.Text);
            cmd.Parameters.AddWithValue("@salary_rupees", detailsalarypricetxt.Text);
            cmd.ExecuteNonQuery();
            loginForm.conn.Close();
            MessageBox.Show("Date Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void salarydetailUpdatebtn_Click(object sender, EventArgs e)
        {
            if (salarydetailUpdateCategorytxt.Text.Trim() == "")
            {
                MessageBox.Show("Please Choose the Category to Update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (salarydetailUpdatesalarytxt.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter the Salry to Update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                loginForm.conn.Open();
                string query = "UPDATE [emp_salary] SET salary_status = @salary_status, salary_rupees = @salary_rupees WHERE salary_id = @salary_id";
                SqlCommand cmd = new SqlCommand(query, loginForm.conn);
                cmd.Parameters.AddWithValue("@salary_id", salarydetailidlbl.Text);
                cmd.Parameters.AddWithValue("@salary_status", salarydetailUpdateCategorytxt.Text);
                cmd.Parameters.AddWithValue("@salary_rupees", salarydetailUpdatesalarytxt.Text);
                cmd.ExecuteNonQuery();
                loginForm.conn.Close();
                MessageBox.Show("Date Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void salarydetailDeletebtn_Click(object sender, EventArgs e)
        {
            if (salarydetailUpdateCategorytxt.Text.Trim() == "")
            {
                MessageBox.Show("Please Choose the Category to Delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                loginForm.conn.Open();
                string query = "DELETE [emp_salary] WHERE salary_id = @salary_id";
                SqlCommand cmd = new SqlCommand(query, loginForm.conn);
                cmd.Parameters.AddWithValue("@salary_id", salarydetailidlbl.Text);
                cmd.ExecuteNonQuery();
                loginForm.conn.Close();
                MessageBox.Show("Date has been Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void searchemployeeCategorytxt_TextChanged(object sender, EventArgs e)
        {
            loginForm.conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM [emp_salary] WHERE salary_status LIKE '%" + searchemployeeCategorytxt.Text + "%'", loginForm.conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            detailSalarydatagridview.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = detailSalarydatagridview.Rows.Add();
                detailSalarydatagridview.Rows[n].Cells["employeecategoryidgridview"].Value = item["salary_id"].ToString();
                detailSalarydatagridview.Rows[n].Cells["employeecategorygridview"].Value = item["salary_status"].ToString();
                detailSalarydatagridview.Rows[n].Cells["employeesalarydatagridview"].Value = item["salary_rupees"].ToString();
            }
            loginForm.conn.Close();
        }

        private void detailSalarydatagridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = detailSalarydatagridview.Rows[index];

            salarydetailidlbl.Text = selectedRow.Cells["employeecategoryidgridview"].Value.ToString();
            salarydetailUpdateCategorytxt.Text = selectedRow.Cells["employeecategorygridview"].Value.ToString();
            salarydetailUpdatesalarytxt.Text = selectedRow.Cells["employeesalarydatagridview"].Value.ToString();
        }

        private void viewattendancebtn_Click(object sender, EventArgs e)
        {
            int month = Convert.ToInt32(attendanceMonthpicker.Text);
            int year = Convert.ToInt32(attendanceYearpicker.Text);
            int attendanceCounter = 0;
            loginForm.conn.Open();
            string secQuery = "SELECT * FROM emp_attendance WHERE attend_empYear LIKE '%" + year + "%' AND attend_empMonth LIKE '%" + month + "%' AND (attend_empname LIKE '%" + searchattendanceemployeetxt.Text + "%') OR (attend_empcode LIKE '%" + searchattendanceemployeetxt.Text + "%') AND attend_empStatus LIKE '1'";
            SqlDataAdapter secsda = new SqlDataAdapter(secQuery, loginForm.conn);
            DataTable secdt = new DataTable();
            secsda.Fill(secdt);
            employeeattendencegridview.Rows.Clear();
            foreach (DataRow rows in secdt.Rows)
            {
                firstnameattendancelbl.Text = rows["attend_empname"].ToString();
                empCodeattendancelbl.Text = rows["attend_empcode"].ToString();
                attendanceCounter += Convert.ToInt32(rows["attend_empStatus"].ToString());
                totalattendancelbl.Text = attendanceCounter.ToString();
                monthattendancelbl.Text = rows["attend_empMonth"].ToString();
                yearattendancelbl.Text = rows["attend_empYear"].ToString();
            }
            loginForm.conn.Close();

            int index = 1;

            string query = "SELECT * FROM emp_attendance WHERE attend_empYear LIKE '%" + year + "%' AND attend_empMonth LIKE '%" + month + "%' AND (attend_empname LIKE '%" + searchattendanceemployeetxt.Text + "%') OR (attend_empcode LIKE '%" + searchattendanceemployeetxt.Text + "%')";
            loginForm.conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query, loginForm.conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            employeeattendencegridview.Rows.Clear();
            foreach (DataRow rows in dt.Rows)
            {
                int n = employeeattendencegridview.Rows.Add();
                employeeattendencegridview.Rows[n].Cells["attendanceemployeeiddatagridview"].Value = index.ToString();
                employeeattendencegridview.Rows[n].Cells["attendanceemployeecodedatagridview"].Value = rows["attend_empcode"].ToString();
                employeeattendencegridview.Rows[n].Cells["attendanceemployeeNamedatagridview"].Value = rows["attend_empname"].ToString();
                employeeattendencegridview.Rows[n].Cells["attendanceemployeeAttendancedatagridview"].Value = rows["attend_empStatus"].ToString();
                //employeeattendencegridview.Rows[n].Cells["attendanceemployeecodedatagridview"].Value = rows["attend_empcode"].ToString();
                employeeattendencegridview.Rows[n].Cells["attendanceemployeeDatedatagridview"].Value = rows["attend_empDate"].ToString() + "/" + rows["attend_empMonth"].ToString() + "/" + rows["attend_empYear"].ToString();
                index += 1;
            }

            loginForm.conn.Close();
        }

        private void searchattendanceemployeetxt_TextChanged(object sender, EventArgs e)
        {
            int index = 1;
            int month = Convert.ToInt32(attendanceMonthpicker.Text);
            int year = Convert.ToInt32(attendanceYearpicker.Text);
            //int attendanceCounter = 0;

            string query = "SELECT * FROM emp_attendance WHERE attend_empYear LIKE '%" + year + "%' AND attend_empMonth LIKE '%" + month + "%' AND (attend_empname LIKE '%" + searchattendanceemployeetxt.Text + "%') OR (attend_empcode LIKE '%" + searchattendanceemployeetxt.Text + "%')";
            loginForm.conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query, loginForm.conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            employeeattendencegridview.Rows.Clear();
            foreach (DataRow rows in dt.Rows)
            {

                int n = employeeattendencegridview.Rows.Add();
                employeeattendencegridview.Rows[n].Cells["attendanceemployeeiddatagridview"].Value = index.ToString();
                employeeattendencegridview.Rows[n].Cells["attendanceemployeecodedatagridview"].Value = rows["attend_empcode"].ToString();
                employeeattendencegridview.Rows[n].Cells["attendanceemployeeNamedatagridview"].Value = rows["attend_empname"].ToString();
                employeeattendencegridview.Rows[n].Cells["attendanceemployeeAttendancedatagridview"].Value = rows["attend_empStatus"].ToString();
                //employeeattendencegridview.Rows[n].Cells["attendanceemployeecodedatagridview"].Value = rows["attend_empcode"].ToString();
                employeeattendencegridview.Rows[n].Cells["attendanceemployeeDatedatagridview"].Value = rows["attend_empDate"].ToString() + "/" + rows["attend_empMonth"].ToString() + "/" + rows["attend_empYear"].ToString();
                index += 1;
            }
            
            loginForm.conn.Close();
        }

        private void applydateattendancebtn_Click(object sender, EventArgs e)
        {
            int index = 1;
            int month = Convert.ToInt32(attendanceMonthpicker.Text);
            int year = Convert.ToInt32(attendanceYearpicker.Text);

            string query = "SELECT * FROM emp_attendance WHERE attend_empYear LIKE '%" + year + "%' AND attend_empMonth LIKE '%" + month + "%'";
            loginForm.conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query, loginForm.conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            employeeattendencegridview.Rows.Clear();
            foreach (DataRow rows in dt.Rows)
            {
                int n = employeeattendencegridview.Rows.Add();
                employeeattendencegridview.Rows[n].Cells["attendanceemployeeiddatagridview"].Value = index.ToString();
                employeeattendencegridview.Rows[n].Cells["attendanceemployeecodedatagridview"].Value = rows["attend_empcode"].ToString();
                employeeattendencegridview.Rows[n].Cells["attendanceemployeeNamedatagridview"].Value = rows["attend_empname"].ToString();
                employeeattendencegridview.Rows[n].Cells["attendanceemployeeAttendancedatagridview"].Value = rows["attend_empStatus"].ToString();
                //employeeattendencegridview.Rows[n].Cells["attendanceemployeecodedatagridview"].Value = rows["attend_empcode"].ToString();
                employeeattendencegridview.Rows[n].Cells["attendanceemployeeDatedatagridview"].Value = rows["attend_empDate"].ToString() + "/" + rows["attend_empMonth"].ToString() + "/" + rows["attend_empYear"].ToString();
                index += 1;
            }
            loginForm.conn.Close();
        }

        private void stockprofitDetailbtn_Click(object sender, EventArgs e)
        {
            if (checker == 2)
            {
                detailPanelSlider.HideSync(salaryPanelDetail);
                detailPanelSlider.ShowSync(stockProfitPaneldetail);
                checker = 1;

            }
            else if (checker == 0)
            {
                detailPanelSlider.ShowSync(stockProfitPaneldetail);
                checker = 1;

            }
            else if (checker == 3)
            {
                detailPanelSlider.HideSync(attendancedetailPanel);
                detailPanelSlider.ShowSync(stockProfitPaneldetail);
                checker = 1;
            }
            displaystockProfitDetail();
        }

        private void detailSalarybtn_Click(object sender, EventArgs e)
        {
            if (checker == 1)
            {
                detailPanelSlider.HideSync(stockProfitPaneldetail);
                detailPanelSlider.ShowSync(salaryPanelDetail);
                checker = 2;
            }
            else if (checker == 0)
            {
                detailPanelSlider.ShowSync(salaryPanelDetail);
                checker = 2;
            }
            else if (checker == 3)
            {
                detailPanelSlider.HideSync(attendancedetailPanel);
                detailPanelSlider.ShowSync(salaryPanelDetail);
                checker = 2;
            }
            displaydetailSalary();
        }

        private void showAttendanceRecordbtn_Click(object sender, EventArgs e)
        {
            if (checker == 0)
            {
                detailPanelSlider.ShowSync(attendancedetailPanel);
                checker = 3;
            }
            else if (checker == 1)
            {
                detailPanelSlider.HideSync(stockProfitPaneldetail);
                detailPanelSlider.ShowSync(attendancedetailPanel);
                checker = 3;
            }
            else if (checker == 2)
            {
                detailPanelSlider.HideSync(salaryPanelDetail);
                detailPanelSlider.ShowSync(attendancedetailPanel);
                checker = 3;
            }
            attendanceFunction();
        }

        public void displaydetailSalary()
        {
            loginForm.conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM [emp_salary]", loginForm.conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            detailSalarydatagridview.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = detailSalarydatagridview.Rows.Add();
                detailSalarydatagridview.Rows[n].Cells["employeecategoryidgridview"].Value = item["salary_id"].ToString();
                detailSalarydatagridview.Rows[n].Cells["employeecategorygridview"].Value = item["salary_status"].ToString();
                detailSalarydatagridview.Rows[n].Cells["employeesalarydatagridview"].Value = item["salary_rupees"].ToString();
            }
            loginForm.conn.Close();
        }
    }
}
