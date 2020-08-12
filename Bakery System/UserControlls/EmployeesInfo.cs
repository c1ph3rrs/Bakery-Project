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
using System.IO;

namespace Bakery_System.UserControlls
{
    public partial class EmployeesInfo : UserControl
    {
        public EmployeesInfo()
        {
            InitializeComponent();
        }

        string fileName;
        public void displaydataGrid()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM mart_employees", loginForm.conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            employeeInfoDataGrid.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = employeeInfoDataGrid.Rows.Add();
                employeeInfoDataGrid.Rows[n].Cells["employeegridviewcode"].Value = item["emp_id"].ToString();
                employeeInfoDataGrid.Rows[n].Cells["employeegridviewfirstName"].Value = item["emp_firstName"].ToString();
                employeeInfoDataGrid.Rows[n].Cells["employeegridviewlastName"].Value = item["emp_lastName"].ToString();
                employeeInfoDataGrid.Rows[n].Cells["employeegridviewfather"].Value = item["emp_father"].ToString();
                employeeInfoDataGrid.Rows[n].Cells["employeegridviewcnic"].Value = item["emp_cnic"].ToString();
                employeeInfoDataGrid.Rows[n].Cells["employeegridviewgender"].Value = item["emp_Gender"].ToString();
                employeeInfoDataGrid.Rows[n].Cells["employeegridviewdob"].Value = item["emp_dob"].ToString();
                employeeInfoDataGrid.Rows[n].Cells["employeegridviewphone"].Value = item["emp_phone"].ToString();
                employeeInfoDataGrid.Rows[n].Cells["employeegridviewaddress"].Value = item["emp_address"].ToString();
                employeeInfoDataGrid.Rows[n].Cells["employeegridvieweducation"].Value = item["emp_education"].ToString();
                employeeInfoDataGrid.Rows[n].Cells["employeegridviewjob"].Value = item["emp_job"].ToString();
                employeeInfoDataGrid.Rows[n].Cells["employeegridviewstatus"].Value = item["emp_status"].ToString();
                employeeInfoDataGrid.Rows[n].Cells["employeegridviewmedical"].Value = item["emp_medical"].ToString();

            }
        }
        private void searchEmployeetxt_TextChanged(object sender, EventArgs e)
        {
            string query = "SELECT * FROM mart_employees WHERE (emp_id LIKE '%" + searchEmployeetxt.Text + "%') OR (emp_firstName LIKE '%" + searchEmployeetxt.Text + "%') OR (emp_lastName LIKE '%" + searchEmployeetxt.Text + "%')";
            SqlDataAdapter sda = new SqlDataAdapter(query, loginForm.conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            employeeInfoDataGrid.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = employeeInfoDataGrid.Rows.Add();
                employeeInfoDataGrid.Rows[n].Cells["employeegridviewcode"].Value = item["emp_id"].ToString();
                employeeInfoDataGrid.Rows[n].Cells["employeegridviewfirstName"].Value = item["emp_firstName"].ToString();
                employeeInfoDataGrid.Rows[n].Cells["employeegridviewlastName"].Value = item["emp_lastName"].ToString();
                employeeInfoDataGrid.Rows[n].Cells["employeegridviewfather"].Value = item["emp_father"].ToString();
                employeeInfoDataGrid.Rows[n].Cells["employeegridviewcnic"].Value = item["emp_cnic"].ToString();
                employeeInfoDataGrid.Rows[n].Cells["employeegridviewgender"].Value = item["emp_Gender"].ToString();
                employeeInfoDataGrid.Rows[n].Cells["employeegridviewdob"].Value = item["emp_dob"].ToString();
                employeeInfoDataGrid.Rows[n].Cells["employeegridviewphone"].Value = item["emp_phone"].ToString();
                employeeInfoDataGrid.Rows[n].Cells["employeegridviewaddress"].Value = item["emp_address"].ToString();
                employeeInfoDataGrid.Rows[n].Cells["employeegridvieweducation"].Value = item["emp_education"].ToString();
                employeeInfoDataGrid.Rows[n].Cells["employeegridviewjob"].Value = item["emp_job"].ToString();
                employeeInfoDataGrid.Rows[n].Cells["employeegridviewstatus"].Value = item["emp_status"].ToString();
                employeeInfoDataGrid.Rows[n].Cells["employeegridviewmedical"].Value = item["emp_medical"].ToString();
            }
        }

        private void employeeInfoDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = employeeInfoDataGrid.Rows[index];
            employeeCodetxt.Text = selectedRow.Cells["employeegridviewcode"].Value.ToString();
            employeefirstNametxt.Text = selectedRow.Cells["employeegridviewfirstName"].Value.ToString();
            employeeinfolastNametxt.Text = selectedRow.Cells["employeegridviewlastName"].Value.ToString();
            employeeFathertxt.Text = selectedRow.Cells["employeegridviewfather"].Value.ToString();
            employeeCnictxt.Text = selectedRow.Cells["employeegridviewcnic"].Value.ToString();
            employeeDOBtxt.Text = selectedRow.Cells["employeegridviewdob"].Value.ToString();
            employeePhonenotxt.Text = selectedRow.Cells["employeegridviewphone"].Value.ToString();
            employeeaddresstxt.Text = selectedRow.Cells["employeegridviewaddress"].Value.ToString();
            employeeEducationtxt.Text = selectedRow.Cells["employeegridvieweducation"].Value.ToString();
            employeeJobtitletxt.Text = selectedRow.Cells["employeegridviewjob"].Value.ToString();
            employeeJobStatustxt.Text = selectedRow.Cells["employeegridviewstatus"].Value.ToString();
            employeeMedicaltxt.Text = selectedRow.Cells["employeegridviewmedical"].Value.ToString();

            string gender = selectedRow.Cells["employeegridviewgender"].Value.ToString();
            if (gender == "Male")
            {
                employeeMaleRadiobtn.Checked = true;
            }
            else
            {
                employeeFemaleRadiobtn.Checked = true;
            }

            SqlDataAdapter sda = new SqlDataAdapter("SELECT salary_rupees FROM [emp_salary] WHERE salary_status LIKE '%" + employeeJobtitletxt.Text + "%'", loginForm.conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            foreach (DataRow item in dt.Rows)
            {
                employeeSalarytxt.Text = item["salary_rupees"].ToString();
            }
        }
        

        private void updateEmployeeInfobtn_Click(object sender, EventArgs e)
        {
            string genderRadioBtn;
            if (employeeMaleRadiobtn.Checked)
            {
                genderRadioBtn = "Male";
            }
            else
            {
                genderRadioBtn = "Female";
            }
            



            loginForm.conn.Open();
            string query = "UPDATE [mart_employees] SET emp_firstName = @emp_firstName, emp_lastName = @emp_lastName, emp_father = @emp_father, emp_cnic = @emp_cnic," +
                "emp_Gender = @emp_Gender, emp_dob = @emp_dob, emp_phone = @emp_phone, emp_address = @emp_address, emp_education = @emp_education, emp_job = @emp_job," +
                "emp_status = @emp_status, emp_medical = @emp_medical WHERE emp_id = @emp_id";
            SqlCommand cmd = new SqlCommand(query, loginForm.conn);

            cmd.Parameters.AddWithValue("@emp_firstName", employeefirstNametxt.Text);
            cmd.Parameters.AddWithValue("@emp_lastName", employeeinfolastNametxt.Text);
            cmd.Parameters.AddWithValue("@emp_father", employeeFathertxt.Text);
            cmd.Parameters.AddWithValue("@emp_cnic", employeeCnictxt.Text);
            cmd.Parameters.AddWithValue("@emp_Gender", genderRadioBtn);
            cmd.Parameters.AddWithValue("@emp_dob", employeeDOBtxt.Text);
            cmd.Parameters.AddWithValue("@emp_phone", employeePhonenotxt.Text);
            cmd.Parameters.AddWithValue("@emp_address", employeeaddresstxt.Text);
            cmd.Parameters.AddWithValue("@emp_education", employeeEducationtxt.Text);
            cmd.Parameters.AddWithValue("@emp_job", employeeJobtitletxt.Text);
            cmd.Parameters.AddWithValue("@emp_status", employeeJobStatustxt.Text);
            cmd.Parameters.AddWithValue("@emp_medical", employeeMedicaltxt.Text);
            cmd.Parameters.AddWithValue("@emp_id", employeeCodetxt.Text);
            cmd.ExecuteNonQuery();
            loginForm.conn.Close();
            MessageBox.Show("Record Updated Sucessfully", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);

            employeeCodetxt.Text = "";
            employeefirstNametxt.Text = "";
            employeeinfolastNametxt.Text = "";
            employeeFathertxt.Text = "";
            employeeCnictxt.Text = "";
            employeeDOBtxt.Text = "";
            employeePhonenotxt.Text = "";
            employeeaddresstxt.Text = "";
            employeeEducationtxt.Text = "";
            employeeJobtitletxt.Text = "";
            employeeJobStatustxt.Text = "";
            employeeMedicaltxt.Text = "";

        }

        private void deleteEmployeeInfobtn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are You Sure, you Want to Delete this Selected User", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                string query = "DELETE [mart_employees] WHERE emp_id = @emp_id";
                SqlCommand cmd = new SqlCommand(query, loginForm.conn);
                loginForm.conn.Open();
                cmd.Parameters.AddWithValue("@emp_id", employeeCodetxt.Text);
                cmd.ExecuteNonQuery();
                loginForm.conn.Close();
                MessageBox.Show("Record Deleted Sucessfully", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);

                employeeCodetxt.Text = "";
                employeefirstNametxt.Text = "";
                employeeinfolastNametxt.Text = "";
                employeeFathertxt.Text = "";
                employeeCnictxt.Text = "";
                employeeDOBtxt.Text = "";
                employeePhonenotxt.Text = "";
                employeeaddresstxt.Text = "";
                employeeEducationtxt.Text = "";
                employeeJobtitletxt.Text = "";
                employeeJobStatustxt.Text = "";
                employeeMedicaltxt.Text = "";
            }
            else
            {

            }
        }
    }
}
