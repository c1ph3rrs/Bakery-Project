using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Bakery_System.UserControlls
{
    public partial class BillingInfo : UserControl
    {
        public BillingInfo()
        {
            InitializeComponent();
        }

        private void billInfoBillCheckBtn_Click(object sender, EventArgs e)
        {
            int qty, pricePerItem, totalPrice;
            if (billInfoBillNoTxt.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter the Bill Code First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                billInfoBillCheckBtn.Focus();
            }
            else
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM [sale_record] WHERE  [bill_id] = '" + billInfoBillNoTxt.Text + "'", loginForm.conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                billInfoBillDetailGridView.Rows.Clear();

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow item in dt.Rows)
                    {
                        int n = billInfoBillDetailGridView.Rows.Add();
                        billInfoBillDetailGridView.Rows[n].Cells["billingInfoProductNameGridView"].Value = item["sale_products"].ToString();
                        billInfoBillDetailGridView.Rows[n].Cells["billingInfoProductQtyGridView"].Value = item["sale_quantity"].ToString();
                        billInfoBillDetailGridView.Rows[n].Cells["billingInfoProductTotalPriceGridView"].Value = item["sale_price"].ToString();

                        qty = Convert.ToInt32(item["sale_quantity"].ToString());
                        totalPrice = Convert.ToInt32(item["sale_price"].ToString());

                        pricePerItem = totalPrice / qty;

                        billInfoBillDetailGridView.Rows[n].Cells["billingInfoProductPricePerItemGridView"].Value = pricePerItem.ToString();
                        
                        billInfoBillDetailGridView.Rows[n].Cells["billingInfoProductSaleID"].Value = item["sale_id"].ToString();
                        billInfoBillDetailGridView.Rows[n].Cells["billingInfoProductBillNo"].Value = item["bill_id"].ToString();
                        billInfoBillDetailGridView.Rows[n].Cells["billInfoProductIdGridView"].Value = item["product_code"].ToString();

                    }
                }
                else
                {
                    MessageBox.Show("Bill Record Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    billInfoBillNoTxt.Clear();
                    billInfoBillNoTxt.Focus();
                }
            }
        }

        private void billInfoBillDetailGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int n = e.RowIndex;
            billInfoProductNametxt.Text = billInfoBillDetailGridView.Rows[n].Cells["billingInfoProductNameGridView"].Value.ToString();
            billInfoProductTotalQtytxt.Text = billInfoBillDetailGridView.Rows[n].Cells["billingInfoProductQtyGridView"].Value.ToString();
            billInfoPricePerItemTxt.Text = billInfoBillDetailGridView.Rows[n].Cells["billingInfoProductPricePerItemGridView"].Value.ToString();
            billInfoTotalPriceTxt.Text = billInfoBillDetailGridView.Rows[n].Cells["billingInfoProductTotalPriceGridView"].Value.ToString();

            billInfoSaleIdTxt.Text = billInfoBillDetailGridView.Rows[n].Cells["billingInfoProductSaleID"].Value.ToString();
            billInfoBillCodeTxt.Text = billInfoBillDetailGridView.Rows[n].Cells["billingInfoProductBillNo"].Value.ToString();
            billInfoProductIdTxt.Text = billInfoBillDetailGridView.Rows[n].Cells["billInfoProductIdGridView"].Value.ToString();

        }

        private void billInfoProductReturnBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure You Want to Return this Selected Item", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(result == DialogResult.Yes)
            {
                int qty, pricePerItem, totalPrice;
                int quantity = 0;

                quantity = Convert.ToInt32(billInfoProductReturnQtytxt.Text);

                loginForm.conn.Open();
                string updateMartquery = "UPDATE [mart_product] SET [product_sale] = product_sale +'" + quantity + "' WHERE [product_barcode] = @product_barcode";
                SqlCommand updateMartCmd = new SqlCommand(updateMartquery, loginForm.conn);
                updateMartCmd.Parameters.AddWithValue("@product_barcode", billInfoProductIdTxt.Text);
                updateMartCmd.ExecuteNonQuery();
                loginForm.conn.Close();

                qty = Convert.ToInt32(billInfoProductTotalQtytxt.Text.ToString()) - Convert.ToInt32(billInfoProductReturnQtytxt.Text.ToString());

                pricePerItem = Convert.ToInt32(billInfoPricePerItemTxt.Text.ToString());

                totalPrice = pricePerItem * qty;

                loginForm.conn.Open();
                string updateSaleQuery = "UPDATE [sale_record] SET sale_quantity = @sale_quantity, sale_price = @sale_price WHERE sale_id = @sale_id";
                SqlCommand updateSaleCmd = new SqlCommand(updateSaleQuery, loginForm.conn);
                updateSaleCmd.Parameters.AddWithValue("@sale_quantity", qty.ToString());
                updateSaleCmd.Parameters.AddWithValue("@sale_price", totalPrice.ToString());
                updateSaleCmd.Parameters.AddWithValue("@sale_id", billInfoSaleIdTxt.Text.ToString());
                updateSaleCmd.ExecuteNonQuery();
                loginForm.conn.Close();

                billInfoProductNametxt.Clear();
                billInfoProductTotalQtytxt.Clear();
                billInfoPricePerItemTxt.Clear();
                billInfoTotalPriceTxt.Clear();

                billInfoSaleIdTxt.Clear();
                billInfoBillCodeTxt.Clear();
                billInfoProductIdTxt.Clear();
                billInfoProductReturnQtytxt.Clear();
                billInfoReturnPriceTxt.Clear();
            }
            else
            {

            }
        }

        private void billInfoClearBtn_Click(object sender, EventArgs e)
        {
            billInfoBillDetailGridView.Rows.Clear();
            billInfoBillNoTxt.Clear();
            billInfoProductNametxt.Clear();
            billInfoProductTotalQtytxt.Clear();
            billInfoPricePerItemTxt.Clear();
            billInfoTotalPriceTxt.Clear();

            billInfoSaleIdTxt.Clear();
            billInfoBillCodeTxt.Clear();
            billInfoProductIdTxt.Clear();
            billInfoProductReturnQtytxt.Clear();
            billInfoReturnPriceTxt.Clear();

        }

        private void billInfoProductDeleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure You Want to Delete this Selected Item", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                loginForm.conn.Open();
                string updateMartquery = "UPDATE [mart_product] SET product_sale = product_sale +" + billInfoProductTotalQtytxt.Text + " WHERE product_barcode = @product_barcode";
                SqlCommand updateMartCmd = new SqlCommand(updateMartquery, loginForm.conn);
                updateMartCmd.Parameters.AddWithValue("@product_barcode", billInfoProductIdTxt.Text.ToString());
                updateMartCmd.ExecuteNonQuery();
                loginForm.conn.Close();

                loginForm.conn.Open();
                string query = "DELETE FROM [sale_record] WHERE sale_id = @sale_id";
                SqlCommand cmd = new SqlCommand(query, loginForm.conn);
                cmd.Parameters.AddWithValue("@sale_id", billInfoSaleIdTxt.Text);
                cmd.ExecuteNonQuery();
                loginForm.conn.Close();


                billInfoBillDetailGridView.Rows.RemoveAt(billInfoBillDetailGridView.SelectedRows[0].Index);

                billInfoProductNametxt.Clear();
                billInfoProductTotalQtytxt.Clear();
                billInfoPricePerItemTxt.Clear();
                billInfoTotalPriceTxt.Clear();

                billInfoSaleIdTxt.Clear();
                billInfoBillCodeTxt.Clear();
                billInfoProductIdTxt.Clear();
                billInfoProductReturnQtytxt.Clear();
                billInfoReturnPriceTxt.Clear();

            }
            else
            {

            }
        }

        private void billInfoGenerateBillBtn_Click(object sender, EventArgs e)
        {
            printBillDialogData.Document = printBillDocument;
            printBillDialogData.ShowDialog();
        }

        private void printBillDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int id = 1, nextRowGo = 190;
            int grandTotal = 0;
            string sale_products = "";
            string sDate = DateTime.Now.ToString();
            DateTime datevalue = (Convert.ToDateTime(sDate.ToString()));

            int qty, pricePerItem, Total;

            bool printed = false;

            string dy = datevalue.Day.ToString();
            string mn = datevalue.Month.ToString();
            string yy = datevalue.Year.ToString();

            e.Graphics.DrawString("RABIA ENTERPRISES", new Font("Georgia", 16, FontStyle.Bold), Brushes.Black, new Point(5, 8));
            e.Graphics.DrawString("Zaib Plaza Bhimber Road Gujrat", new Font("Calibri", 10, FontStyle.Italic), Brushes.Black, new Point(40, 50));
            e.Graphics.DrawString("Contact Us. 03338405757, 03454288157", new Font("Calibri", 10, FontStyle.Italic), Brushes.Black, new Point(10, 70));
            e.Graphics.DrawString("Reg No.  " + billInfoBillNoTxt.Text.ToString(), new Font("Calibri", 10, FontStyle.Bold), Brushes.Black, new Point(10, 100));
            e.Graphics.DrawLine(Pens.Black, 10, 120, 260, 120);
            e.Graphics.DrawString("Cashier Name : " + loginForm.username, new Font("Calibri", 10, FontStyle.Italic), Brushes.Black, new Point(10, 125));
            e.Graphics.DrawLine(Pens.Black, 10, 145, 260, 145);


            e.Graphics.DrawString("Sr. | Product                       | Qty | Price | Total ", new Font("Calibri", 10, FontStyle.Italic), Brushes.Black, 10, 155);
            e.Graphics.DrawLine(Pens.Black, 10, 175, 260, 175);

            foreach (DataGridViewRow row in billInfoBillDetailGridView.Rows)
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
            e.Graphics.DrawString("Total", new Font("Calibri", 9, FontStyle.Bold), Brushes.Black, new Point(35, nextRowGo));
            e.Graphics.DrawString(grandTotal.ToString(), new Font("Calibri", 9, FontStyle.Bold), Brushes.Black, new Point(220, nextRowGo));


            nextRowGo += 25;
            e.Graphics.DrawString("Bill Re Genrated at " + DateTime.Now.ToString(), new Font("Calibri", 8, FontStyle.Italic), Brushes.Black, new Point(15, nextRowGo));


            nextRowGo += 25;
            e.Graphics.DrawString("Design & Developed By :- Ibrahim Akram Mughal", new Font("Calibri", 8, FontStyle.Italic), Brushes.Black, new Point(10, nextRowGo));
            nextRowGo += 20;
            e.Graphics.DrawString("For Any Kind of Software Contact Us:- 0317-1755276", new Font("Calibri", 8, FontStyle.Italic), Brushes.Black, new Point(10, nextRowGo));

        }

        private void billInfoProductReturnQtytxt_TextChanged(object sender, EventArgs e)
        {
            if (billInfoProductReturnQtytxt.Text.Trim() == "")
            {
                billInfoReturnPriceTxt.Text = "0";
            }
            else
            {
                int price;
                price = Convert.ToInt32(billInfoProductReturnQtytxt.Text.ToString()) * Convert.ToInt32(billInfoPricePerItemTxt.Text.ToString());
                billInfoReturnPriceTxt.Text = price.ToString();
            }
            
        }
    }
}
