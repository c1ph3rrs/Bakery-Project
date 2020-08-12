using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Bakery_System
{
    public partial class searchProduct : Form
    {
        public searchProduct()
        {
            InitializeComponent();
            fillsearchDatagridView();
        }

        private void searchpageSearchProductbtn_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT product_name,  product_price_per_item FROM [mart_product] WHERE product_name LIKE '%" + searchpageSearchtxt.Text + "%'", loginForm.conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            int pricePerItem;

            foreach (DataRow item in dt.Rows)
            {

                searchProductNamelabel.Text = item["product_name"].ToString();
                pricePerItem = Convert.ToInt32(item["product_price_per_item"]);
                
                searchProductPricelabel.Text = pricePerItem.ToString();
            }
            searchpageSearchtxt.Text = "";
        }

        void fillsearchDatagridView()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT product_name, product_price_per_item FROM [mart_product]", loginForm.conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            int pricePerItem;

            searchItemDataGrid.Rows.Clear();

            foreach (DataRow item in dt.Rows)
            {
                int n = searchItemDataGrid.Rows.Add();

                searchProductNamelabel.Text = item["product_name"].ToString();
                pricePerItem = Convert.ToInt32(item["product_price_per_item"]);


                searchItemDataGrid.Rows[n].Cells["searchitemName"].Value = item["product_name"].ToString();
                searchItemDataGrid.Rows[n].Cells["searchitemPriceperUnit"].Value = pricePerItem.ToString();

                searchProductPricelabel.Text = pricePerItem.ToString();
            }
        }

        private void searchpageSearchtxt_TextChanged(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT product_name, product_price_per_item FROM [mart_product] WHERE product_name LIKE '%" + searchpageSearchtxt.Text + "%'", loginForm.conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            int pricePerItem;

            searchItemDataGrid.Rows.Clear();

            foreach (DataRow item in dt.Rows)
            {
                int n = searchItemDataGrid.Rows.Add();

                searchProductNamelabel.Text = item["product_name"].ToString();
                pricePerItem = Convert.ToInt32(item["product_price_per_item"]);

                searchItemDataGrid.Rows[n].Cells["searchitemName"].Value = item["product_name"].ToString();
                searchItemDataGrid.Rows[n].Cells["searchitemPriceperUnit"].Value = pricePerItem.ToString();

                searchProductPricelabel.Text = pricePerItem.ToString();
            }
        }

        private void searchpagecancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
