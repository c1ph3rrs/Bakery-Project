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
    public partial class Revenue : UserControl
    {
        int checker = 0;
        public Revenue()
        {
            InitializeComponent();
            monthlyRevenueDetailPanel.Visible = false;
            todaySaleRevenueDetailPanel.Visible = false;
        }

        private void Revenue_Load(object sender, EventArgs e)
        {
            Revenue rev = sender as Revenue;
            monthlyRevenueDetailPanel.Parent = rev;
            monthlyRevenueDetailPanel.Left = 250;
            monthlyRevenueDetailPanel.Top = 0;

            todaySaleRevenueDetailPanel.Parent = rev;
            todaySaleRevenueDetailPanel.Left = 250;
            todaySaleRevenueDetailPanel.Top = 0;
        }

        private void CheckYearIncomebtn_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT sale_price FROM [sale_record] WHERE sale_year LIKE '%" + saleyeartxt.Text + "%'", loginForm.conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            int sale_price = 0;

            foreach (DataRow item in dt.Rows)
            {
                sale_price += Convert.ToInt32(item["sale_price"].ToString());
            }
            netIncomelbl.Text = sale_price.ToString();

            for (int i = 1; i <= 12; i++)
            {
                SqlDataAdapter sdamonth = new SqlDataAdapter("SELECT sale_price FROM [sale_record] WHERE sale_year LIKE '%" + saleyeartxt.Text + "%' AND sale_month = " + i, loginForm.conn);
                DataTable dtmonth = new DataTable();
                sdamonth.Fill(dtmonth);

                int sale_priceMonth = 0;

                foreach (DataRow items in dtmonth.Rows)
                {
                    sale_priceMonth += Convert.ToInt32(items["sale_price"].ToString());
                }

                if (i == 1)
                {
                    Januarylbl.Text = sale_priceMonth.ToString();
                }

                if (i == 2)
                {
                    Februarylbl.Text = sale_priceMonth.ToString();
                }

                if (i == 3)
                {
                    Marchlbl.Text = sale_priceMonth.ToString();
                }
                if (i == 4)
                {
                    Aprillbl.Text = sale_priceMonth.ToString();
                }

                if (i == 5)
                {
                    Maylbl.Text = sale_priceMonth.ToString();
                }
                if (i == 6)
                {
                    Junelbl.Text = sale_priceMonth.ToString();
                }

                if (i == 7)
                {
                    Julylbl.Text = sale_priceMonth.ToString();
                }
                if (i == 8)
                {
                    Augustlbl.Text = sale_priceMonth.ToString();
                }

                if (i == 9)
                {
                    Septemberlbl.Text = sale_priceMonth.ToString();
                }
                if (i == 10)
                {
                    Octoberlbl.Text = sale_priceMonth.ToString();
                }

                if (i == 11)
                {
                    novemberlbl.Text = sale_priceMonth.ToString();
                }
                if (i == 12)
                {
                    decemberlbl.Text = sale_priceMonth.ToString();
                }
            }
        }

        private void revenuetodaysalebtn_Click(object sender, EventArgs e)
        {
            todaysaleSHow();
        }

        void todaysaleSHow()
        {
            //revenuetodaysalelbl.Text = DateTime.Now.ToString("dddd , MMM dd yyyy ,  hh:mm:ss");
            int todaySale = 0, id = 1;

            string sDate = DateTime.Now.ToString();
            DateTime datevalue = (Convert.ToDateTime(sDate.ToString()));

            string todayDate = datevalue.Day.ToString();
            string todayMonth = datevalue.Month.ToString();
            string todayYear = datevalue.Year.ToString();
            /*
            string todayDate = DateTime.Now.ToString("dd");
            string todayMonth = DateTime.Now.ToString("MM");
            string todayYear = DateTime.Now.ToString("yyyy");*/
            //revenuetodaysalelbl.Text = todayMonth;

            SqlDataAdapter sda = new SqlDataAdapter("SELECT sale_products, sale_quantity, sale_price FROM [sale_record] WHERE sale_date ='" + todayDate + "' AND sale_month = '" + todayMonth + "' AND sale_year= '" + todayYear + "'", loginForm.conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            saletodayrecordDataGridView.Rows.Clear();
            foreach (DataRow rows in dt.Rows)
            {
                int n = saletodayrecordDataGridView.Rows.Add();
                saletodayrecordDataGridView.Rows[n].Cells["saletodayrecordiddatagridview"].Value = id.ToString();
                saletodayrecordDataGridView.Rows[n].Cells["saletodayrecordProductsdatagridview"].Value = rows["sale_products"].ToString();
                saletodayrecordDataGridView.Rows[n].Cells["saletodayrecordQuantitydatagridview"].Value = rows["sale_quantity"].ToString();
                saletodayrecordDataGridView.Rows[n].Cells["saletodayrecordPricedatagridview"].Value = rows["sale_price"].ToString();
                todaySale += Convert.ToInt32(rows["sale_price"].ToString());
                id += 1;
            }
            revenuetodaysalelbl.Text = todaySale.ToString();
        }

        private void todaysalerevenuebtn_Click(object sender, EventArgs e)
        {
            if (checker == 0)
            {
                revenuePanelSlider.ShowSync(todaySaleRevenueDetailPanel);
                checker = 1;
            }
            else if (checker == 2)
            {
                revenuePanelSlider.HideSync(monthlyRevenueDetailPanel);
                revenuePanelSlider.ShowSync(todaySaleRevenueDetailPanel);
                checker = 1;
            }
        }

        private void monthlyRevenueDetailBtn_Click(object sender, EventArgs e)
        {
            if (checker == 0)
            {
                revenuePanelSlider.ShowSync(monthlyRevenueDetailPanel);
                checker = 2;
            }
            else if (checker == 1)
            {
                revenuePanelSlider.HideSync(todaySaleRevenueDetailPanel);
                revenuePanelSlider.ShowSync(monthlyRevenueDetailPanel);
                checker = 2;
            }
        }

    }
}
