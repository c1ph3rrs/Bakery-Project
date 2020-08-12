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
    public partial class saledataUC : UserControl
    {
      
        
        int itemLeftInTable = 0, runTimeQUantityChecker = 1;
        int selectedRow = 0;

        public saledataUC()
        {
            InitializeComponent();
        }

        private void generateBillbtn_Click(object sender, EventArgs e)
        {
            string sDate = DateTime.Now.ToString();
            DateTime datevalue = (Convert.ToDateTime(sDate.ToString()));

            double billNo = 1;

            string dy = datevalue.Day.ToString();
            string mn = datevalue.Month.ToString();
            string yy = datevalue.Year.ToString();

            if (cartpaidtxt.Text.Trim() == "")
            {
                MessageBox.Show("Please First Enter The Paid Price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cartproductBarcodetxt.Focus();
            }
            else
            {

                foreach (DataGridViewRow rows in forSaleDataGridView.Rows)
                {
                    loginForm.conn.Open();
                    string query = "INSERT INTO [sale_record] (sale_products, sale_quantity, sale_price, sale_date, sale_month, sale_year, bill_id, product_code) " +
                    "VALUES(@sale_products, @sale_quantity, @sale_price, @sale_date, @sale_month, @sale_year, @bill_id, @product_code)";
                    SqlCommand cmd = new SqlCommand(query, loginForm.conn);
                    cmd.Parameters.AddWithValue("@sale_products", rows.Cells[0].Value.ToString());
                    cmd.Parameters.AddWithValue("@sale_quantity", rows.Cells[1].Value.ToString());
                    cmd.Parameters.AddWithValue("@sale_price", rows.Cells[3].Value.ToString());
                    cmd.Parameters.AddWithValue("@sale_date", dy);
                    cmd.Parameters.AddWithValue("@sale_month", mn);
                    cmd.Parameters.AddWithValue("@sale_year", yy);
                    cmd.Parameters.AddWithValue("@bill_id", cartProductBillNo.Text.ToString());
                    cmd.Parameters.AddWithValue("@product_code", rows.Cells[4].Value.ToString());
                    cmd.ExecuteNonQuery();
                    loginForm.conn.Close();
                }

                int quantity = 0;

                foreach (DataGridViewRow rows in forSaleDataGridView.Rows)
                {
                    loginForm.conn.Open();

                    quantity = Convert.ToInt16(rows.Cells[1].Value.ToString());

                    string query = "UPDATE [mart_product] SET product_sale = product_sale -" + quantity + "  WHERE [product_name] = @product_name";
                    SqlCommand cmd = new SqlCommand(query, loginForm.conn);
                    cmd.Parameters.AddWithValue("@product_name", rows.Cells[0].Value.ToString());
                    cmd.ExecuteNonQuery();
                    loginForm.conn.Close();
                }

                printCustomerData.Document = printCustomerDocument;
                printCustomerData.ShowDialog();

                forSaleDataGridView.Rows.Clear();

                cartproductBarcodetxt.Text = "";
                cartpaidtxt.Text = "";
                cartgrandTotaltxt.Text = "0";
                cartreturnmoneytxt.Text = "0";

                cartproductBarcodetxt.Focus();

            }


            SqlDataAdapter sda = new SqlDataAdapter("SELECT bill_id FROM bill_no", loginForm.conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cartProductShow.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                billNo = Convert.ToDouble(item["bill_id"].ToString());
            }

            billNo = Convert.ToDouble(Convert.ToInt32(billNo) + 1);

            loginForm.conn.Open();


            string queryy = "UPDATE [bill_no] SET bill_id = " + billNo + "";
            SqlCommand cmdd = new SqlCommand(queryy, loginForm.conn);
            cmdd.ExecuteNonQuery();
            loginForm.conn.Close();


            SqlDataAdapter sdas = new SqlDataAdapter("SELECT bill_id FROM bill_no", loginForm.conn);
            DataTable dtt = new DataTable();
            sdas.Fill(dtt);
            foreach (DataRow iteem in dtt.Rows)
            {
                cartProductBillNo.Text = iteem["bill_id"].ToString();
            }

            cartProductShow.Rows.Clear();

            displayproductinDataGrid();
            cartProductShow.ClearSelection();
        }

        private void printCustomerDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
            int id = 1, nextRowGo = 190;
            int grandTotal = 0;
            string sale_products = "";
            string sDate = DateTime.Now.ToString();
            DateTime datevalue = (Convert.ToDateTime(sDate.ToString()));
            bool printed = false;

            string dy = datevalue.Day.ToString();
            string mn = datevalue.Month.ToString();
            string yy = datevalue.Year.ToString();

            e.Graphics.DrawString("RABIA ENTERPRISES", new Font("Georgia", 16, FontStyle.Bold), Brushes.Black, new Point(5, 8));
            e.Graphics.DrawString("Zaib Plaza Bhimber Road Gujrat", new Font("Calibri", 10, FontStyle.Italic), Brushes.Black, new Point(40, 50));
            e.Graphics.DrawString("Contact Us. 03338405757, 03454288157", new Font("Calibri", 10, FontStyle.Italic), Brushes.Black, new Point(10, 70));
            e.Graphics.DrawString("Reg No.  " + cartProductBillNo.Text.ToString(), new Font("Calibri", 10, FontStyle.Bold), Brushes.Black, new Point(10, 100));
            e.Graphics.DrawLine(Pens.Black, 10, 120, 260, 120);
            e.Graphics.DrawString("Cashier Name : " + loginForm.username, new Font("Calibri", 10, FontStyle.Italic), Brushes.Black, new Point(10, 125));
            e.Graphics.DrawLine(Pens.Black, 10, 145, 260, 145);

            
            e.Graphics.DrawString("Sr. | Product                       | Qty | Price | Total ", new Font("Calibri", 10, FontStyle.Italic), Brushes.Black, 10, 155);
            e.Graphics.DrawLine(Pens.Black, 10, 175, 260, 175);

            foreach (DataGridViewRow row in forSaleDataGridView.Rows)
            {
                e.Graphics.DrawString(id.ToString(), new Font("Calibri", 9, FontStyle.Italic), Brushes.Black, new Point(10, nextRowGo));
                e.Graphics.DrawString(row.Cells[0].Value.ToString(), new Font("Calibri", 8, FontStyle.Italic), Brushes.Black, new Point(35, nextRowGo));
                e.Graphics.DrawString(row.Cells[1].Value.ToString(), new Font("Calibri", 9, FontStyle.Italic), Brushes.Black, new Point(160, nextRowGo));
                e.Graphics.DrawString(row.Cells[2].Value.ToString(), new Font("Calibri", 9, FontStyle.Italic), Brushes.Black, new Point(190, nextRowGo));
                e.Graphics.DrawString(row.Cells[3].Value.ToString(), new Font("Calibri", 9, FontStyle.Italic), Brushes.Black, new Point(225, nextRowGo));
                nextRowGo += 20;
                id += 1;
                grandTotal += Convert.ToInt32(row.Cells[3].Value);
                sale_products += row.Cells[0].Value.ToString();
            }

            nextRowGo += 20;
            e.Graphics.DrawLine(Pens.Black, 10, nextRowGo, 260, nextRowGo);
            nextRowGo += 20;
            e.Graphics.DrawString("Grand Total", new Font("Calibri", 9, FontStyle.Bold), Brushes.Black, new Point(35, nextRowGo));
            e.Graphics.DrawString(grandTotal.ToString(), new Font("Calibri", 9, FontStyle.Bold), Brushes.Black, new Point(220, nextRowGo));

            nextRowGo += 20;
            e.Graphics.DrawString("Paid", new Font("Calibri", 9, FontStyle.Bold), Brushes.Black, new Point(35, nextRowGo));
            e.Graphics.DrawString(cartpaidtxt.Text, new Font("Calibri", 9, FontStyle.Bold), Brushes.Black, new Point(220, nextRowGo));


            nextRowGo += 30;
            e.Graphics.DrawLine(Pens.Black, 10, nextRowGo, 260, nextRowGo);

            nextRowGo += 20;
            e.Graphics.DrawString("Return Price", new Font("Calibri", 9, FontStyle.Bold), Brushes.Black, new Point(35, nextRowGo));
            e.Graphics.DrawString(cartreturnmoneytxt.Text, new Font("Calibri", 9, FontStyle.Bold), Brushes.Black, new Point(220, nextRowGo));

            nextRowGo += 25;
            e.Graphics.DrawString(DateTime.Now.ToString(), new Font("Calibri", 8, FontStyle.Italic), Brushes.Black, new Point(20, nextRowGo));

            nextRowGo += 20;
            e.Graphics.DrawString("Return with in 1 Day with Bill", new Font("Calibri", 8, FontStyle.Italic), Brushes.Black, new Point(75, nextRowGo));

            nextRowGo += 25;
            e.Graphics.DrawString("Design & Developed By :- Ibrahim Akram Mughal", new Font("Calibri", 8, FontStyle.Italic), Brushes.Black, new Point(10, nextRowGo));
            nextRowGo += 20;
            e.Graphics.DrawString("For Any Kind of Software Contact Us:- 0317-1755276", new Font("Calibri", 8, FontStyle.Italic), Brushes.Black, new Point(10, nextRowGo));
            
        }

        private void saledataremovebtn_Click(object sender, EventArgs e)
        {
            int grandTotal = 0;

            forSaleDataGridView.Rows.RemoveAt(forSaleDataGridView.SelectedRows[0].Index);
            foreach (DataGridViewRow row in forSaleDataGridView.Rows)
            {
                grandTotal += Convert.ToInt32(row.Cells[3].Value);
            }

            cartgrandTotaltxt.Text = grandTotal.ToString();
        }

        private void cartpaidtxt_TextChanged(object sender, EventArgs e)
        {
            if (cartgrandTotaltxt.Text == "")
            {
                cartgrandTotaltxt.Text = "0";
            }
            if (cartpaidtxt.Text == "")
            {
                cartpaidtxt.Text = "0";
            }
            else
            {
                int returnPrice = -(Convert.ToInt32(cartgrandTotaltxt.Text.Trim()) - Convert.ToInt32(cartpaidtxt.Text.Trim()));
                cartreturnmoneytxt.Text = returnPrice.ToString();
            }
        }

        private void newBillbtn_Click(object sender, EventArgs e)
        {
            forSaleDataGridView.Rows.Clear();
            
            cartproductBarcodetxt.Text = "";
            cartpaidtxt.Text = "";
            cartgrandTotaltxt.Text = "0";
            cartreturnmoneytxt.Text = "0";

            cartproductBarcodetxt.Focus();
        }

        private void saledataUC_Load(object sender, EventArgs e)
        {
            forSaleDataGridView.Rows.Clear();
            cartproductBarcodetxt.Text = "";
           
            cartpaidtxt.Text = "";
            cartgrandTotaltxt.Text = "0";
            cartreturnmoneytxt.Text = "0";

            cartproductBarcodetxt.Focus();
        }

        private void cartproductBarcodetxt_KeyUp(object sender, KeyEventArgs e)
        {
            bool Found = false;
            int quantity = 1, totalQuantity = 0;
            int totalPrice;
            int grandTotal = 0;
            string product_name = "";
            int pricePerItem = 0;
            string productBarcode = "";
            

            if (e.KeyCode == Keys.Enter)
            {

                if (cartproductBarcodetxt.Text.Trim() == "")
                    return;

                SqlDataAdapter sda = new SqlDataAdapter("SELECT product_barcode, product_name, product_quantity, product_sale, product_price_per_item FROM [mart_product] WHERE ([product_sale] >= " + Convert.ToInt32(quantity) + ") AND (([product_barcode] = '" + cartproductBarcodetxt.Text + "') OR (product_name LIKE '%" + cartproductBarcodetxt.Text + "%'))", loginForm.conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if(dt.Rows.Count > 0)
                {
                    foreach (DataRow item in dt.Rows)
                    {
                        product_name = item["product_name"].ToString();
                        pricePerItem = Convert.ToInt32(item["product_price_per_item"]);
                        totalQuantity = Convert.ToInt32(item["product_quantity"]);
                        itemLeftInTable = Convert.ToInt16(item["product_sale"]);
                        productBarcode = item["product_barcode"].ToString();
                    }

                    totalPrice = quantity * Convert.ToInt32(pricePerItem);

                    if (forSaleDataGridView.Rows.Count > 0)
                    {

                        foreach (DataGridViewRow row in forSaleDataGridView.Rows)
                        {
                            if (Convert.ToString(row.Cells[0].Value) == product_name)
                            {
                                if(itemLeftInTable >= Convert.ToInt32(row.Cells[1].Value) + 1)
                                {

                                    row.Cells[1].Value = Convert.ToString(quantity + Convert.ToInt16(row.Cells[1].Value));
                                    row.Cells[3].Value = Convert.ToString(Convert.ToInt16(row.Cells[1].Value) * Convert.ToInt16(row.Cells[2].Value));
                                    row.Cells[4].Value = productBarcode;
                                        //productIdDataGridView
                                    Found = true;
                                    cartproductBarcodetxt.Text = "";

                                }
                                else
                                {
                                    MessageBox.Show("Stock is Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    cartproductBarcodetxt.Clear();
                                    return;
                                }
                                
                            }
                        }
                        if (!Found)
                        {
                            forSaleDataGridView.Rows.Add(product_name, quantity, pricePerItem, totalPrice.ToString(), productBarcode);
                            cartproductBarcodetxt.Text = "";
                            Found = true;
                            
                        }
                    }
                    else
                    {

                        forSaleDataGridView.Rows.Add(product_name, quantity, pricePerItem, totalPrice.ToString(), productBarcode);
                        cartproductBarcodetxt.Text = "";
                        Found = true;
                        runTimeQUantityChecker += 1;
                        
                    }

                    foreach (DataGridViewRow row in forSaleDataGridView.Rows)
                    {
                        grandTotal += Convert.ToInt32(row.Cells[3].Value);
                    }

                    cartgrandTotaltxt.Text = grandTotal.ToString();
                }
                else
                {
                    MessageBox.Show("Stock is Empty or Product Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cartproductBarcodetxt.Clear();
                    cartproductBarcodetxt.Focus();
                    cartpaidtxt.Text = "";
                }
                forSaleDataGridView.ClearSelection();
            }
        }

        private void forSaleDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
                selectedRow = e.RowIndex;
            
        }

        private void forSaleDataGridView_KeyUp(object sender, KeyEventArgs e)
        {
            int grandTotal =0;

            if (e.KeyCode == Keys.Enter)
            {
                DataGridViewRow rows = forSaleDataGridView.Rows[selectedRow];
                rows.Cells[3].Value = Convert.ToString(Convert.ToInt16(rows.Cells[1].Value) * Convert.ToInt16(rows.Cells[2].Value));

                foreach (DataGridViewRow row in forSaleDataGridView.Rows)
                {
                    grandTotal += Convert.ToInt32(row.Cells[3].Value);
                }

                cartgrandTotaltxt.Text = grandTotal.ToString();

                forSaleDataGridView.ClearSelection();
                
            }
        }

        private void cartproductBarcodetxt_TextChanged(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT product_barcode, product_name, product_sale, product_price_per_item FROM mart_product WHERE (product_name LIKE '%" + cartproductBarcodetxt.Text + "%') OR (product_barcode = '" + cartproductBarcodetxt.Text + "')", loginForm.conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cartProductShow.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = cartProductShow.Rows.Add();
                cartProductShow.Rows[n].Cells["cartProductName"].Value = item["product_name"].ToString();
                cartProductShow.Rows[n].Cells["cartProductQty"].Value = item["product_sale"].ToString();
                cartProductShow.Rows[n].Cells["cartProductPrice"].Value = item["product_price_per_item"].ToString();
                cartProductShow.Rows[n].Cells["cartProductCodeGrid"].Value = item["product_barcode"].ToString();
            }
        }

        public void displayproductinDataGrid()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT product_barcode, product_name, product_sale, product_price_per_item FROM mart_product", loginForm.conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cartProductShow.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = cartProductShow.Rows.Add();
                cartProductShow.Rows[n].Cells["cartProductName"].Value = item["product_name"].ToString();
                cartProductShow.Rows[n].Cells["cartProductQty"].Value = item["product_sale"].ToString();
                cartProductShow.Rows[n].Cells["cartProductPrice"].Value = item["product_price_per_item"].ToString();
                cartProductShow.Rows[n].Cells["cartProductCodeGrid"].Value = item["product_barcode"].ToString();
            }
        }

        private void cartProductShow_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            bool Found = false;
            int quantity = 1, totalQuantity = 0;
            int totalPrice;
            int grandTotal = 0;
            string product_name = "";
            int pricePerItem = 0;
            string productBarcode;

            int n = e.RowIndex;

            productBarcode = cartProductShow.Rows[n].Cells["cartProductCodeGrid"].Value.ToString();
            product_name = cartProductShow.Rows[n].Cells["cartProductName"].Value.ToString();
            pricePerItem = Convert.ToInt32(cartProductShow.Rows[n].Cells["cartProductPrice"].Value.ToString());
            itemLeftInTable = Convert.ToInt16(cartProductShow.Rows[n].Cells["cartProductQty"].Value.ToString());

            if (forSaleDataGridView.Rows.Count > 0)
            {

                foreach (DataGridViewRow row in forSaleDataGridView.Rows)
                {
                    if (Convert.ToString(row.Cells[0].Value) == product_name)
                    {
                        if (itemLeftInTable >= Convert.ToInt32(row.Cells[1].Value) + 1)
                        {

                            row.Cells[1].Value = Convert.ToString(quantity + Convert.ToInt16(row.Cells[1].Value));
                            row.Cells[3].Value = Convert.ToString(Convert.ToInt16(row.Cells[1].Value) * Convert.ToInt16(row.Cells[2].Value));
                            row.Cells[4].Value = productBarcode;
                            Found = true;
                            cartproductBarcodetxt.Text = "";

                        }
                        else
                        {
                            MessageBox.Show("Stock is Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            cartproductBarcodetxt.Clear();
                            return;
                        }

                    }
                }
                if (!Found)
                {
                    if (itemLeftInTable >= quantity)
                    {
                        totalPrice = quantity * pricePerItem;
                        forSaleDataGridView.Rows.Add(product_name, quantity, pricePerItem, totalPrice.ToString(), productBarcode);
                        cartproductBarcodetxt.Text = "";
                        Found = true;
                    }
                    else
                    {
                        MessageBox.Show("Stock is Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cartproductBarcodetxt.Clear();
                        return;
                    }
                }
            }
            else
            {
                if (itemLeftInTable >= quantity)
                {
                    totalPrice = quantity * pricePerItem;
                    forSaleDataGridView.Rows.Add(product_name, quantity, pricePerItem, totalPrice.ToString(), productBarcode);
                    cartproductBarcodetxt.Text = "";
                    Found = true;
                    runTimeQUantityChecker += 1;
                }
                else
                {
                    MessageBox.Show("Stock is Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cartproductBarcodetxt.Clear();
                    return;
                }
            }

            foreach (DataGridViewRow row in forSaleDataGridView.Rows)
            {
                grandTotal += Convert.ToInt32(row.Cells[3].Value);
            }

            cartgrandTotaltxt.Text = grandTotal.ToString();
            cartProductShow.ClearSelection();
        }

        private void saledataUC_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Alt && e.KeyCode.ToString() == "G")
            {
                
            }
            else if(e.Alt && e.KeyCode.ToString() == "N")
            {
                
            }
        }

        public void loadBillNo()
        {

            SqlDataAdapter sda = new SqlDataAdapter("SELECT bill_id FROM bill_no", loginForm.conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            foreach (DataRow item in dt.Rows)
            {
                cartProductBillNo.Text = item["bill_id"].ToString();
            }
        }
    }
}
