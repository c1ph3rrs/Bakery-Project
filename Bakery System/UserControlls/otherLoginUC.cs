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
    public partial class otherLoginUC : UserControl
    {
        public event EventHandler addTOCartButtonClick;
        public event EventHandler addtoStockButtonClick;
        public event EventHandler stockInfoButtonClick;
        public event EventHandler logoutBtnClick;
        public event EventHandler aboutDeveloperButtonClick;

        public otherLoginUC()
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

        private void stockbtn_Click(object sender, EventArgs e)
        {
            if (this.stockInfoButtonClick != null)
                this.stockInfoButtonClick(this, e);
        }

        private void aboutDeveloperbtn_Click(object sender, EventArgs e)
        {
            if (this.aboutDeveloperButtonClick != null)
                this.aboutDeveloperButtonClick(this, e);
        }
    }
}
