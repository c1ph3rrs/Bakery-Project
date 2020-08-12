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
    public partial class stockUC : UserControl
    {
        public stockUC()
        {
            InitializeComponent();
        }

        private void stockInfoUpdatebtn_Click(object sender, EventArgs e)
        {

            int totalQUantity = 0;
           

            if (stockInfoBarcodetxt.Text.Trim() == "")
            {
                MessageBox.Show("Please Choose the Item First to Update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("Are You Sure You Want to Update this Selected Item", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    totalQUantity = Convert.ToInt32(stockInfoNewQuantitytxt.Text) + Convert.ToInt32(stockinfoLeftQuantitytxt.Text);

                    loginForm.conn.Open();
                    string query = "UPDATE [mart_product] SET [product_quantity] = " + totalQUantity + ", [product_sale] = " + totalQUantity + ", [product_price_per_item] = @product_price_per_item, [product_name] = @product_name " +
                        ", [product_manfCompany] = @product_manfCompany, [product_manfDate] = @product_manfDate, [product_expiree] = @product_expiree, [buying_price_per_item] = @buying_price_per_item " +
                        "WHERE [product_barcode] = @product_barcode";
                    SqlCommand cmd = new SqlCommand(query, loginForm.conn);
                    cmd.Parameters.AddWithValue("@product_price_per_item", stockInfoPricetxt.Text);
                    cmd.Parameters.AddWithValue("@buying_price_per_item", stockInfoBuyingPriceTxt.Text);
                    cmd.Parameters.AddWithValue("@product_name", stockInfoProductnametxt.Text);
                    cmd.Parameters.AddWithValue("@product_manfCompany", stockInfoproductmanCompanytxt.Text);
                    cmd.Parameters.AddWithValue("@product_manfDate", stockInfoproductmanDatetxt.Text);
                    cmd.Parameters.AddWithValue("@product_expiree", stockInfoproductexpiretxt.Text);
                    cmd.Parameters.AddWithValue("@product_barcode", stockInfoBarcodetxt.Text);
                    cmd.ExecuteNonQuery();
                    loginForm.conn.Close();

                    stockInfoSearchtxt.Text = "";
                    stockInfoBarcodetxt.Text = "";
                    stockInfoNewQuantitytxt.Text = "";
                    stockinfoLeftQuantitytxt.Text = "";
                    stockInfoPricetxt.Text = "";
                    stockInfoProductnametxt.Text = "";
                    stockInfoproductmanCompanytxt.Text = "";
                    stockInfoBuyingPriceTxt.Text = "";
                    stockInfoproductmanDatetxt.Text = DateTime.Now.ToString();
                    stockInfoproductexpiretxt.Text = DateTime.Now.ToString();
                }
                else
                {
                    return;
                }
            }
        }

        private void stockInfoDeletebtn_Click(object sender, EventArgs e)
        {
            if (stockInfoBarcodetxt.Text.Trim() == "")
            {
                MessageBox.Show("Please Choose The Item First to Delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("Are You Sure You Want To Delete This Selected Item", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    loginForm.conn.Open();
                    string query = "DELETE FROM [mart_product] WHERE product_barcode = @product_barcode";
                    SqlCommand cmd = new SqlCommand(query, loginForm.conn);
                    cmd.Parameters.AddWithValue("@product_barcode", stockInfoBarcodetxt.Text);
                    cmd.ExecuteNonQuery();
                    loginForm.conn.Close();

                    stockInfoSearchtxt.Text = "";
                    stockInfoBarcodetxt.Text = "";
                    stockInfoNewQuantitytxt.Text = "";
                    stockinfoLeftQuantitytxt.Text = "";
                    stockInfoPricetxt.Text = "";
                    stockInfoProductnametxt.Text = "";
                    stockInfoBuyingPriceTxt.Text = "";
                    stockInfoproductmanCompanytxt.Text = "";
                    stockInfoproductmanDatetxt.Text = DateTime.Now.ToString();
                    stockInfoproductexpiretxt.Text = DateTime.Now.ToString();
                }
                else
                {

                }
            }
        }

        private void resetstockbtn_Click(object sender, EventArgs e)
        {
            stockInfoSearchtxt.Text = "";
            stockInfoBarcodetxt.Text = "";
            stockInfoNewQuantitytxt.Text = "";
            stockinfoLeftQuantitytxt.Text = "";
            stockInfoPricetxt.Text = "";
            stockInfoProductnametxt.Text = "";
            stockInfoproductmanCompanytxt.Text = "";
            stockInfoBuyingPriceTxt.Text = "";
            stockInfoproductmanDatetxt.Text = DateTime.Now.ToString();
            stockInfoproductexpiretxt.Text = DateTime.Now.ToString();
        }

        private void stockDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void stockInfoSearchtxt_TextChanged(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM mart_product WHERE (product_name like '%" + stockInfoSearchtxt.Text + "%')", loginForm.conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            stockDataGridView.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = stockDataGridView.Rows.Add();
                stockDataGridView.Rows[n].Cells["barcodeStockinfogridview"].Value = item["product_barcode"].ToString();
                stockDataGridView.Rows[n].Cells["QuantityStockinfogridview"].Value = item["product_quantity"].ToString();
                stockDataGridView.Rows[n].Cells["soldStockinfogridview"].Value = item["product_sale"].ToString();
                stockDataGridView.Rows[n].Cells["stockDetailBuyPriceGridView"].Value = item["buying_price_per_item"].ToString();
                stockDataGridView.Rows[n].Cells["pricePerItemStockinfogridview"].Value = item["product_price_per_item"].ToString();
                stockDataGridView.Rows[n].Cells["productNameStockinfogridview"].Value = item["product_name"].ToString();
                stockDataGridView.Rows[n].Cells["manCompanyStockinfogridview"].Value = item["product_manfCompany"].ToString();
                stockDataGridView.Rows[n].Cells["manfDateStockinfogridview"].Value = item["product_manfDate"].ToString();
                stockDataGridView.Rows[n].Cells["expireStockinfogridview"].Value = item["product_expiree"].ToString();
            }
        }

        public void displayinDataGrid()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM mart_product", loginForm.conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            stockDataGridView.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = stockDataGridView.Rows.Add();
                stockDataGridView.Rows[n].Cells["barcodeStockinfogridview"].Value = item["product_barcode"].ToString();
                stockDataGridView.Rows[n].Cells["QuantityStockinfogridview"].Value = item["product_quantity"].ToString();
                stockDataGridView.Rows[n].Cells["soldStockinfogridview"].Value = item["product_sale"].ToString();
                stockDataGridView.Rows[n].Cells["stockDetailBuyPriceGridView"].Value = item["buying_price_per_item"].ToString();
                stockDataGridView.Rows[n].Cells["pricePerItemStockinfogridview"].Value = item["product_price_per_item"].ToString();
                stockDataGridView.Rows[n].Cells["productNameStockinfogridview"].Value = item["product_name"].ToString();
                stockDataGridView.Rows[n].Cells["manCompanyStockinfogridview"].Value = item["product_manfCompany"].ToString();
                stockDataGridView.Rows[n].Cells["manfDateStockinfogridview"].Value = item["product_manfDate"].ToString();
                stockDataGridView.Rows[n].Cells["expireStockinfogridview"].Value = item["product_expiree"].ToString();
            }
        }

        private void stockDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = stockDataGridView.Rows[index];

            stockInfoBarcodetxt.Text = selectedRow.Cells["barcodeStockinfogridview"].Value.ToString();
            stockInfoNewQuantitytxt.Text = "0";
            stockinfoLeftQuantitytxt.Text = selectedRow.Cells["soldStockinfogridview"].Value.ToString();            
            stockInfoProductnametxt.Text = selectedRow.Cells["productNameStockinfogridview"].Value.ToString();
            stockInfoBuyingPriceTxt.Text = selectedRow.Cells["stockDetailBuyPriceGridView"].Value.ToString();
            stockInfoPricetxt.Text = selectedRow.Cells["pricePerItemStockinfogridview"].Value.ToString();
            stockInfoproductmanCompanytxt.Text = selectedRow.Cells["manCompanyStockinfogridview"].Value.ToString();
            stockInfoproductmanDatetxt.Text = selectedRow.Cells["manfDateStockinfogridview"].Value.ToString();
            stockInfoproductexpiretxt.Text = selectedRow.Cells["expireStockinfogridview"].Value.ToString();
        }
    }
}
