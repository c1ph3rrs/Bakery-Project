using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bakery_System.UserControlls
{
    public partial class homepagemainPanel : UserControl
    {
        public event EventHandler addTOCartButtonClick;
        public event EventHandler addtoStockButtonClick;
        public event EventHandler addnewEmployeeButtonClick;
        public event EventHandler attendanceButtonClick;
        public event EventHandler stockInfoButtonClick;
        public event EventHandler employeeInfoButtonClick;
        public event EventHandler revenueInfoInfoButtonClick;
        public event EventHandler settingsButtonClick;
        public event EventHandler detailBtnClick;
        public event EventHandler billDetailBtnClick;
        public event EventHandler logoutBtnClick;
        public event EventHandler aboutDeveloperButtonClick;

        public homepagemainPanel()
        {
            InitializeComponent();
        }

        private void addtoCartbtn_Click(object sender, EventArgs e)
        {
            if (this.addTOCartButtonClick != null)
                this.addTOCartButtonClick(this, e);
        }

        private void addStockbtn_Click(object sender, EventArgs e)
        {
            if (this.addtoStockButtonClick != null)
                this.addtoStockButtonClick(this, e);
        }

        private void addEmployeebtn_Click(object sender, EventArgs e)
        {
            if (this.addnewEmployeeButtonClick != null)
                this.addnewEmployeeButtonClick(this, e);
        }

        private void employeesbtn_Click(object sender, EventArgs e)
        {
            if (this.employeeInfoButtonClick != null)
                this.employeeInfoButtonClick(this, e);
        }

        private void attendancebtn_Click(object sender, EventArgs e)
        {
            if (this.attendanceButtonClick != null)
                this.attendanceButtonClick(this, e);
        }


        private void stockbtn_Click(object sender, EventArgs e)
        {
            if (this.stockInfoButtonClick != null)
                this.stockInfoButtonClick(this, e);
        }

        private void revenuebtn_Click(object sender, EventArgs e)
        {
            if (this.revenueInfoInfoButtonClick != null)
                this.revenueInfoInfoButtonClick(this, e);
        }

        private void mainPanelsearchbtn_Click(object sender, EventArgs e)
        {
            searchProduct searchP = new searchProduct();
            searchP.ShowDialog();
        }

        private void detailbtn_Click(object sender, EventArgs e)
        {
            if (this.detailBtnClick != null)
                this.detailBtnClick(this, e);
        }

        private void settingsbtn_Click(object sender, EventArgs e)
        {
            if (this.settingsButtonClick != null)
                this.settingsButtonClick(this, e);
        }

        private void aboutDeveloperbtn_Click(object sender, EventArgs e)
        {
            if (this.aboutDeveloperButtonClick != null)
                this.aboutDeveloperButtonClick(this, e);
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you Sure you want to Exit the Application", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else { }
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure You Want To LogOut", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (this.logoutBtnClick != null)
                    this.logoutBtnClick(this, e);
            }
            else { }
        }

        private void billDetailBtn_Click(object sender, EventArgs e)
        {
            if (this.billDetailBtnClick != null)
                this.billDetailBtnClick(this, e);
        }
    }
}
