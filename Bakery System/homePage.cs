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
using Bakery_System.UserControlls;

namespace Bakery_System
{
    public partial class homePage : Form
    {
        int checker = 0;
      
        public homePage()
        {
            InitializeComponent();
        }

        private void homePage_Load(object sender, EventArgs e)
        {
            

            mainpageTimerDisplay.Start();

            homepagemainPanel1.addTOCartButtonClick += new EventHandler(addtoCartFunction);
            homepagemainPanel1.addtoStockButtonClick += new EventHandler(addtoStockFunction);
            homepagemainPanel1.addnewEmployeeButtonClick += new EventHandler(addnewEmployee);
            homepagemainPanel1.attendanceButtonClick += new EventHandler(attendanceShow);
            homepagemainPanel1.stockInfoButtonClick += new EventHandler(stockShow);
            homepagemainPanel1.revenueInfoInfoButtonClick += new EventHandler(RevenueShow);
            homepagemainPanel1.employeeInfoButtonClick += new EventHandler(EmployeeInfoShow);
            homepagemainPanel1.detailBtnClick += new EventHandler(detailShow);
            homepagemainPanel1.settingsButtonClick += new EventHandler(settingsShow);
            homepagemainPanel1.logoutBtnClick += new EventHandler(logoutUserShow);
            homepagemainPanel1.aboutDeveloperButtonClick += new EventHandler(aboutDeveloperShow);
            homepagemainPanel1.billDetailBtnClick += new EventHandler(billDetailShow);

            activeuserlbl.Text = loginForm.username;
            activeuserlbl.Visible = true;
        }

        public void addtoCartFunction(object sender, EventArgs e)
        {
            checker = 1;
            homePagePanelSlider.HideSync(homepagemainPanel1);
            homePagePanelSlider.ShowSync(saledataUC1);
            backBtn.Visible = true;

            saledataUC1.displayproductinDataGrid();

            saledataUC1.loadBillNo();
        }

        public void addtoStockFunction(object sender, EventArgs e)
        {
            checker = 2;
            homePagePanelSlider.HideSync(homepagemainPanel1);
            homePagePanelSlider.ShowSync(addStockUC1);
            backBtn.Visible = true;
        }

        public void addnewEmployee(object sender, EventArgs e)
        {
            checker = 3;
            homePagePanelSlider.HideSync(homepagemainPanel1);
            homePagePanelSlider.ShowSync(addEmployee1);
            backBtn.Visible = true;
            
        }

        public void attendanceShow(object sender, EventArgs e)
        {
            checker = 4;
            homePagePanelSlider.HideSync(homepagemainPanel1);
            homePagePanelSlider.ShowSync(attendanceUC1);
            backBtn.Visible = true;
            
            attendanceUC1.displayinDataGrid();
        }

        public void stockShow(object sender, EventArgs e)
        {
            checker = 5;
            homePagePanelSlider.HideSync(homepagemainPanel1);
            homePagePanelSlider.ShowSync(stockUC1);
            backBtn.Visible = true;
            
            stockUC1.displayinDataGrid();
        }

        public void RevenueShow(object sender, EventArgs e)
        {
            checker = 6;
            homePagePanelSlider.HideSync(homepagemainPanel1);
            homePagePanelSlider.ShowSync(revenue1);
            backBtn.Visible = true;
            
        }

        public void EmployeeInfoShow(object sender, EventArgs e)
        {
            checker = 7;
            homePagePanelSlider.HideSync(homepagemainPanel1);
            homePagePanelSlider.ShowSync(employeesInfo1);
            backBtn.Visible = true;
            
            employeesInfo1.displaydataGrid();
        }

        public void detailShow(object sender, EventArgs e)
        {
            checker = 8;
            homePagePanelSlider.HideSync(homepagemainPanel1);
            homePagePanelSlider.ShowSync(detail1);
            backBtn.Visible = true;
            
        }

        public void settingsShow(object sender, EventArgs e)
        {
            checker = 9;
            homePagePanelSlider.HideSync(homepagemainPanel1);
            homePagePanelSlider.ShowSync(settings1);
            backBtn.Visible = true;
            
        }

        public void aboutDeveloperShow(object sender, EventArgs e)
        {
            checker = 10;
            homePagePanelSlider.HideSync(homepagemainPanel1);
            homePagePanelSlider.ShowSync(aboutDeveloper1);
            backBtn.Visible = true;
            
        }

        public void billDetailShow(object sender, EventArgs e)
        {
            checker = 11;
            homePagePanelSlider.HideSync(homepagemainPanel1);
            homePagePanelSlider.ShowSync(billingInfo1);
            backBtn.Visible = true;

        }
        public void logoutUserShow(object sender, EventArgs e)
        {
            loginForm lgform = new loginForm();
            this.Close();
            lgform.Show();
            
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            if (checker == 1)
            {
                checker = 0;
                backBtn.Visible = false;
                homePagePanelSlider.HideSync(saledataUC1);
                homePagePanelSlider.ShowSync(homepagemainPanel1);

            }
            else if (checker == 2)
            {
                checker = 0;
                backBtn.Visible = false;
                homePagePanelSlider.HideSync(addStockUC1);
                homePagePanelSlider.ShowSync(homepagemainPanel1);

            }else if(checker == 3)
            {
                checker = 0;
                backBtn.Visible = false;
                homePagePanelSlider.HideSync(addEmployee1);
                homePagePanelSlider.ShowSync(homepagemainPanel1);

            }else if (checker == 4)
            {
                checker = 0;
                backBtn.Visible = false;
                homePagePanelSlider.HideSync(attendanceUC1);
                homePagePanelSlider.ShowSync(homepagemainPanel1);

            }else if (checker == 5){
                checker = 0;
                backBtn.Visible = false;
                homePagePanelSlider.HideSync(stockUC1);
                homePagePanelSlider.ShowSync(homepagemainPanel1);

            }else if(checker == 6)
            {
                checker = 0;
                backBtn.Visible = false;
                homePagePanelSlider.HideSync(revenue1);
                homePagePanelSlider.ShowSync(homepagemainPanel1);
            }else if (checker == 7)
            {
                checker = 0;
                backBtn.Visible = false;
                homePagePanelSlider.HideSync(employeesInfo1);
                homePagePanelSlider.ShowSync(homepagemainPanel1);

            }else if (checker == 8)
            {
                checker = 0;
                backBtn.Visible = false;
                homePagePanelSlider.HideSync(detail1);
                homePagePanelSlider.ShowSync(homepagemainPanel1);

            }else if (checker == 9)
            {
                checker = 0;
                backBtn.Visible = false;
                homePagePanelSlider.HideSync(settings1);
                homePagePanelSlider.ShowSync(homepagemainPanel1);
            }else if (checker == 10)
            {
                checker = 0;
                backBtn.Visible = false;
                homePagePanelSlider.HideSync(aboutDeveloper1);
                homePagePanelSlider.ShowSync(homepagemainPanel1);
            }
            else if (checker == 11)
            {
                checker = 0;
                backBtn.Visible = false;
                homePagePanelSlider.HideSync(billingInfo1);
                homePagePanelSlider.ShowSync(homepagemainPanel1);
            }

        }

        private void mainpageTimerDisplay_Tick(object sender, EventArgs e)
        {
            mainpagetimeDisplaylabel.Text = DateTime.Now.ToString("dddd , MMM dd yyyy ,  hh:mm:ss");
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are You Sure You Want to Exit this Application", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(dr == DialogResult.Yes)
            {
                Application.Exit();
            }else { }
        }

        private void maximizebtn_Click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                this.homepagemainPanel1.Left = 0;
                this.saledataUC1.Left = 0;
                this.addStockUC1.Left = 0;
                this.addEmployee1.Left = 0;
                this.attendanceUC1.Left = 0;
                this.stockUC1.Left = 0;
                this.revenue1.Left = 0;
                this.employeesInfo1.Left = 0;
                this.detail1.Left = 0;
                this.settings1.Left = 0;
                this.aboutDeveloper1.Left = 0;
                this.billingInfo1.Left = 0;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                this.homepagemainPanel1.Left = this.Width / 22;
                this.saledataUC1.Left = this.Width / 22;
                this.addStockUC1.Left = this.Width / 22;
                this.addEmployee1.Left = this.Width / 22;
                this.attendanceUC1.Left = this.Width / 22;
                this.stockUC1.Left = this.Width / 22;
                this.revenue1.Left = this.Width / 22;
                this.employeesInfo1.Left = this.Width / 22;
                this.detail1.Left = this.Width / 22;
                this.settings1.Left = this.Width / 22;
                this.aboutDeveloper1.Left = this.Width / 22;
                this.billingInfo1.Left = this.Width / 22;
            }
        }

        private void minimizebtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
