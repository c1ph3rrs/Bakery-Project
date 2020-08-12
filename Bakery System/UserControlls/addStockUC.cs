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
    public partial class addStockUC : UserControl
    {
        public addStockUC()
        {
            InitializeComponent();
        }

        private void addstocksavebtn_Click(object sender, EventArgs e)
        {
            if (addstockBarcodetxt.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter The Barcode No of Item", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                addstockBarcodetxt.Focus();
            }
            else if (addstockQuantitytxt.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter The Total Quantity of Item", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                addstockQuantitytxt.Focus();
            }
            else if (addStockSalePricePerItemtxt.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter The Sale Price of Total Item", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                addStockSalePricePerItemtxt.Focus();
            }
            else if (addstockProductnametxt.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter The Product Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                addstockProductnametxt.Focus();
            }
            else if (addstockproductmanCompanytxt.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter The Product Company", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                addstockproductmanCompanytxt.Focus();
            }
            else if (addstockproductmanDatetxt.Text.Trim() == "")
            {
                MessageBox.Show("Please Select the Manufacturing Date of Product", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                addstockproductmanDatetxt.Focus();
            }
            else if (addstockproductexpiretxt.Text.Trim() == "")
            {
                MessageBox.Show("Please Select the Expire Date of Product", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                addstockproductexpiretxt.Focus();
            }
            else if (addStockBuyingPricePerItem.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter The Buying Price of Item", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                addstockproductexpiretxt.Focus();
            }
            else
            {
                
                string checkProduct = "SELECT product_barcode FROM [mart_product] WHERE product_barcode = @productBarcode";

                loginForm.conn.Open();

                SqlCommand chkCmd = new SqlCommand(checkProduct, loginForm.conn);
                chkCmd.Parameters.AddWithValue("@productBarcode", addstockBarcodetxt.Text);
                SqlDataReader reader = chkCmd.ExecuteReader();
                

                if (reader.HasRows)
                {
                    MessageBox.Show("Product with this Barcode has already exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    loginForm.conn.Close();
                }
                else
                {
                    loginForm.conn.Close();

                    string insertquery = "INSERT INTO mart_product(product_barcode, product_name, product_quantity, product_sale, product_manfCompany " +
                                     ", product_manfDate, product_expiree, product_price_per_item, buying_price_per_item) VALUES(@product_barcode, @product_name, @product_quantity, @product_sale,  @product_manfCompany," +
                                     "@product_manfDate, @product_expiree, @product_price_per_item, @buying_price_per_item" +
                                     ")";
                    loginForm.conn.Open();
                    SqlCommand mycommand = new SqlCommand(insertquery, loginForm.conn);
                    mycommand.Parameters.AddWithValue("@product_barcode", addstockBarcodetxt.Text);
                    mycommand.Parameters.AddWithValue("@product_name", addstockProductnametxt.Text);
                    mycommand.Parameters.AddWithValue("@product_quantity", addstockQuantitytxt.Text);
                    mycommand.Parameters.AddWithValue("@product_sale", addstockQuantitytxt.Text);
                    mycommand.Parameters.AddWithValue("@product_manfCompany", addstockproductmanCompanytxt.Text);
                    mycommand.Parameters.AddWithValue("@product_manfDate", addstockproductmanDatetxt.Text);
                    mycommand.Parameters.AddWithValue("@product_expiree", addstockproductexpiretxt.Text);
                    mycommand.Parameters.AddWithValue("@product_price_per_item", addStockSalePricePerItemtxt.Text);
                    mycommand.Parameters.AddWithValue("@buying_price_per_item", addStockBuyingPricePerItem.Text);

                    mycommand.ExecuteNonQuery();
                    loginForm.conn.Close();
                    MessageBox.Show("Record Entered to Stock Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    addstockBarcodetxt.Text = "";
                    addstockProductnametxt.Text = "";
                    addstockQuantitytxt.Text = "";
                    addstockQuantitytxt.Text = "";
                    addstockproductmanCompanytxt.Text = "";
                    addstockproductmanDatetxt.Text = "";
                    addstockproductexpiretxt.Text = "";
                    addStockSalePricePerItemtxt.Text = "";
                    addStockBuyingPricePerItem.Text = "";
                    addstockBarcodetxt.Focus();
                }
            }
        }

        private void addstockclearbtn_Click(object sender, EventArgs e)
        {
            addstockBarcodetxt.Text = "";
            addstockProductnametxt.Text = "";
            addstockQuantitytxt.Text = "";
            addstockQuantitytxt.Text = "";
            addstockproductmanCompanytxt.Text = "";
            addstockproductmanDatetxt.Text = "";
            addstockproductexpiretxt.Text = "";
            addStockSalePricePerItemtxt.Text = "";
            addStockBuyingPricePerItem.Text = "";
            addstockBarcodetxt.Focus();
        }

        private void addStockUC_Load(object sender, EventArgs e)
        {
            addstockBarcodetxt.Focus();
        }

        private void addStockUC_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Alt && e.KeyCode.ToString() == "S")
            {

            }else if(e.Alt && e.KeyCode.ToString() == "C")
            {

            }
        }
    }
}
