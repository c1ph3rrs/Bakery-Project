namespace Bakery_System
{
    partial class homePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(homePage));
            this.homePagedragpanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exitBtn = new System.Windows.Forms.Button();
            this.maximizebtn = new System.Windows.Forms.Button();
            this.minimizebtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.activeuserlbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mainpagetimeDisplaylabel = new System.Windows.Forms.Label();
            this.homePagePanelSlider = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.billingInfo1 = new Bakery_System.UserControlls.BillingInfo();
            this.aboutDeveloper1 = new Bakery_System.UserControlls.aboutDeveloper();
            this.settings1 = new Bakery_System.UserControlls.settings();
            this.detail1 = new Bakery_System.UserControlls.detail();
            this.employeesInfo1 = new Bakery_System.UserControlls.EmployeesInfo();
            this.revenue1 = new Bakery_System.UserControlls.Revenue();
            this.stockUC1 = new Bakery_System.UserControlls.stockUC();
            this.attendanceUC1 = new Bakery_System.UserControlls.attendanceUC();
            this.addEmployee1 = new Bakery_System.UserControlls.addEmployee();
            this.addStockUC1 = new Bakery_System.UserControlls.addStockUC();
            this.saledataUC1 = new Bakery_System.UserControlls.saledataUC();
            this.homepagemainPanel1 = new Bakery_System.UserControlls.homepagemainPanel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.mainpageTimerDisplay = new System.Windows.Forms.Timer(this.components);
            this.homepageDrag = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.homePagedragpanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // homePagedragpanel
            // 
            this.homePagedragpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.homePagedragpanel.Controls.Add(this.panel1);
            this.homePagedragpanel.Controls.Add(this.backBtn);
            this.homePagePanelSlider.SetDecoration(this.homePagedragpanel, BunifuAnimatorNS.DecorationType.None);
            this.homePagedragpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.homePagedragpanel.Location = new System.Drawing.Point(0, 0);
            this.homePagedragpanel.Name = "homePagedragpanel";
            this.homePagedragpanel.Size = new System.Drawing.Size(1270, 42);
            this.homePagedragpanel.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.exitBtn);
            this.panel1.Controls.Add(this.maximizebtn);
            this.panel1.Controls.Add(this.minimizebtn);
            this.homePagePanelSlider.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(1131, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(139, 40);
            this.panel1.TabIndex = 18;
            // 
            // exitBtn
            // 
            this.homePagePanelSlider.SetDecoration(this.exitBtn, BunifuAnimatorNS.DecorationType.None);
            this.exitBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Georgia", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Image = ((System.Drawing.Image)(resources.GetObject("exitBtn.Image")));
            this.exitBtn.Location = new System.Drawing.Point(92, 0);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(46, 40);
            this.exitBtn.TabIndex = 1;
            this.exitBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // maximizebtn
            // 
            this.homePagePanelSlider.SetDecoration(this.maximizebtn, BunifuAnimatorNS.DecorationType.None);
            this.maximizebtn.FlatAppearance.BorderSize = 0;
            this.maximizebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximizebtn.Image = ((System.Drawing.Image)(resources.GetObject("maximizebtn.Image")));
            this.maximizebtn.Location = new System.Drawing.Point(46, 0);
            this.maximizebtn.Name = "maximizebtn";
            this.maximizebtn.Size = new System.Drawing.Size(46, 40);
            this.maximizebtn.TabIndex = 2;
            this.maximizebtn.UseVisualStyleBackColor = true;
            this.maximizebtn.Click += new System.EventHandler(this.maximizebtn_Click);
            // 
            // minimizebtn
            // 
            this.homePagePanelSlider.SetDecoration(this.minimizebtn, BunifuAnimatorNS.DecorationType.None);
            this.minimizebtn.FlatAppearance.BorderSize = 0;
            this.minimizebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizebtn.Image = ((System.Drawing.Image)(resources.GetObject("minimizebtn.Image")));
            this.minimizebtn.Location = new System.Drawing.Point(0, 0);
            this.minimizebtn.Name = "minimizebtn";
            this.minimizebtn.Size = new System.Drawing.Size(46, 40);
            this.minimizebtn.TabIndex = 3;
            this.minimizebtn.UseVisualStyleBackColor = true;
            this.minimizebtn.Click += new System.EventHandler(this.minimizebtn_Click);
            // 
            // backBtn
            // 
            this.homePagePanelSlider.SetDecoration(this.backBtn, BunifuAnimatorNS.DecorationType.None);
            this.backBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Font = new System.Drawing.Font("Georgia", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Image = ((System.Drawing.Image)(resources.GetObject("backBtn.Image")));
            this.backBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backBtn.Location = new System.Drawing.Point(0, 0);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(99, 40);
            this.backBtn.TabIndex = 0;
            this.backBtn.Text = "Back";
            this.backBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Visible = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.activeuserlbl);
            this.panel2.Controls.Add(this.label4);
            this.homePagePanelSlider.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 512);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1270, 38);
            this.panel2.TabIndex = 6;
            // 
            // activeuserlbl
            // 
            this.activeuserlbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.activeuserlbl.AutoSize = true;
            this.homePagePanelSlider.SetDecoration(this.activeuserlbl, BunifuAnimatorNS.DecorationType.None);
            this.activeuserlbl.Font = new System.Drawing.Font("Georgia", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeuserlbl.ForeColor = System.Drawing.Color.White;
            this.activeuserlbl.Location = new System.Drawing.Point(127, 5);
            this.activeuserlbl.Name = "activeuserlbl";
            this.activeuserlbl.Size = new System.Drawing.Size(71, 29);
            this.activeuserlbl.TabIndex = 9;
            this.activeuserlbl.Text = "User";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.homePagePanelSlider.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Georgia", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "Active :- ";
            // 
            // mainpagetimeDisplaylabel
            // 
            this.mainpagetimeDisplaylabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mainpagetimeDisplaylabel.AutoSize = true;
            this.mainpagetimeDisplaylabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.homePagePanelSlider.SetDecoration(this.mainpagetimeDisplaylabel, BunifuAnimatorNS.DecorationType.None);
            this.mainpagetimeDisplaylabel.Font = new System.Drawing.Font("Georgia", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainpagetimeDisplaylabel.ForeColor = System.Drawing.Color.White;
            this.mainpagetimeDisplaylabel.Location = new System.Drawing.Point(939, 523);
            this.mainpagetimeDisplaylabel.Name = "mainpagetimeDisplaylabel";
            this.mainpagetimeDisplaylabel.Size = new System.Drawing.Size(46, 18);
            this.mainpagetimeDisplaylabel.TabIndex = 10;
            this.mainpagetimeDisplaylabel.Text = "Time";
            // 
            // homePagePanelSlider
            // 
            this.homePagePanelSlider.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndHorizSlide;
            this.homePagePanelSlider.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.homePagePanelSlider.DefaultAnimation = animation1;
            this.homePagePanelSlider.TimeStep = 0.08F;
            // 
            // billingInfo1
            // 
            this.billingInfo1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.homePagePanelSlider.SetDecoration(this.billingInfo1, BunifuAnimatorNS.DecorationType.None);
            this.billingInfo1.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.billingInfo1.Location = new System.Drawing.Point(3, 43);
            this.billingInfo1.Name = "billingInfo1";
            this.billingInfo1.Size = new System.Drawing.Size(1264, 463);
            this.billingInfo1.TabIndex = 18;
            this.billingInfo1.Visible = false;
            // 
            // aboutDeveloper1
            // 
            this.aboutDeveloper1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.homePagePanelSlider.SetDecoration(this.aboutDeveloper1, BunifuAnimatorNS.DecorationType.None);
            this.aboutDeveloper1.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.aboutDeveloper1.Location = new System.Drawing.Point(3, 43);
            this.aboutDeveloper1.Name = "aboutDeveloper1";
            this.aboutDeveloper1.Size = new System.Drawing.Size(1264, 463);
            this.aboutDeveloper1.TabIndex = 17;
            this.aboutDeveloper1.Visible = false;
            // 
            // settings1
            // 
            this.settings1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.homePagePanelSlider.SetDecoration(this.settings1, BunifuAnimatorNS.DecorationType.None);
            this.settings1.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.settings1.Location = new System.Drawing.Point(3, 46);
            this.settings1.Name = "settings1";
            this.settings1.Size = new System.Drawing.Size(1264, 463);
            this.settings1.TabIndex = 16;
            this.settings1.Visible = false;
            // 
            // detail1
            // 
            this.detail1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.homePagePanelSlider.SetDecoration(this.detail1, BunifuAnimatorNS.DecorationType.None);
            this.detail1.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.detail1.Location = new System.Drawing.Point(2, 46);
            this.detail1.Name = "detail1";
            this.detail1.Size = new System.Drawing.Size(1264, 463);
            this.detail1.TabIndex = 15;
            this.detail1.Visible = false;
            // 
            // employeesInfo1
            // 
            this.employeesInfo1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.homePagePanelSlider.SetDecoration(this.employeesInfo1, BunifuAnimatorNS.DecorationType.None);
            this.employeesInfo1.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.employeesInfo1.Location = new System.Drawing.Point(0, 43);
            this.employeesInfo1.Name = "employeesInfo1";
            this.employeesInfo1.Size = new System.Drawing.Size(1264, 463);
            this.employeesInfo1.TabIndex = 14;
            this.employeesInfo1.Visible = false;
            // 
            // revenue1
            // 
            this.revenue1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.homePagePanelSlider.SetDecoration(this.revenue1, BunifuAnimatorNS.DecorationType.None);
            this.revenue1.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.revenue1.Location = new System.Drawing.Point(3, 43);
            this.revenue1.Name = "revenue1";
            this.revenue1.Size = new System.Drawing.Size(1264, 463);
            this.revenue1.TabIndex = 13;
            this.revenue1.Visible = false;
            // 
            // stockUC1
            // 
            this.stockUC1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.homePagePanelSlider.SetDecoration(this.stockUC1, BunifuAnimatorNS.DecorationType.None);
            this.stockUC1.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.stockUC1.Location = new System.Drawing.Point(2, 43);
            this.stockUC1.Name = "stockUC1";
            this.stockUC1.Size = new System.Drawing.Size(1264, 463);
            this.stockUC1.TabIndex = 12;
            this.stockUC1.Visible = false;
            // 
            // attendanceUC1
            // 
            this.attendanceUC1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.homePagePanelSlider.SetDecoration(this.attendanceUC1, BunifuAnimatorNS.DecorationType.None);
            this.attendanceUC1.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.attendanceUC1.Location = new System.Drawing.Point(2, 43);
            this.attendanceUC1.Name = "attendanceUC1";
            this.attendanceUC1.Size = new System.Drawing.Size(1264, 463);
            this.attendanceUC1.TabIndex = 11;
            this.attendanceUC1.Visible = false;
            // 
            // addEmployee1
            // 
            this.addEmployee1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.homePagePanelSlider.SetDecoration(this.addEmployee1, BunifuAnimatorNS.DecorationType.None);
            this.addEmployee1.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.addEmployee1.Location = new System.Drawing.Point(2, 45);
            this.addEmployee1.Name = "addEmployee1";
            this.addEmployee1.Size = new System.Drawing.Size(1264, 463);
            this.addEmployee1.TabIndex = 10;
            this.addEmployee1.Visible = false;
            // 
            // addStockUC1
            // 
            this.addStockUC1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.homePagePanelSlider.SetDecoration(this.addStockUC1, BunifuAnimatorNS.DecorationType.None);
            this.addStockUC1.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.addStockUC1.Location = new System.Drawing.Point(3, 48);
            this.addStockUC1.Name = "addStockUC1";
            this.addStockUC1.Size = new System.Drawing.Size(1264, 463);
            this.addStockUC1.TabIndex = 9;
            this.addStockUC1.Visible = false;
            // 
            // saledataUC1
            // 
            this.saledataUC1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.homePagePanelSlider.SetDecoration(this.saledataUC1, BunifuAnimatorNS.DecorationType.None);
            this.saledataUC1.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.saledataUC1.Location = new System.Drawing.Point(3, 45);
            this.saledataUC1.Name = "saledataUC1";
            this.saledataUC1.Size = new System.Drawing.Size(1264, 463);
            this.saledataUC1.TabIndex = 8;
            this.saledataUC1.Visible = false;
            // 
            // homepagemainPanel1
            // 
            this.homepagemainPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.homePagePanelSlider.SetDecoration(this.homepagemainPanel1, BunifuAnimatorNS.DecorationType.None);
            this.homepagemainPanel1.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.homepagemainPanel1.Location = new System.Drawing.Point(3, 46);
            this.homepagemainPanel1.Name = "homepagemainPanel1";
            this.homepagemainPanel1.Size = new System.Drawing.Size(1264, 463);
            this.homepagemainPanel1.TabIndex = 7;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 35;
            this.bunifuElipse1.TargetControl = this;
            // 
            // mainpageTimerDisplay
            // 
            this.mainpageTimerDisplay.Tick += new System.EventHandler(this.mainpageTimerDisplay_Tick);
            // 
            // homepageDrag
            // 
            this.homepageDrag.Fixed = true;
            this.homepageDrag.Horizontal = true;
            this.homepageDrag.TargetControl = this.homePagedragpanel;
            this.homepageDrag.Vertical = true;
            // 
            // homePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 550);
            this.Controls.Add(this.billingInfo1);
            this.Controls.Add(this.aboutDeveloper1);
            this.Controls.Add(this.settings1);
            this.Controls.Add(this.detail1);
            this.Controls.Add(this.employeesInfo1);
            this.Controls.Add(this.revenue1);
            this.Controls.Add(this.stockUC1);
            this.Controls.Add(this.mainpagetimeDisplaylabel);
            this.Controls.Add(this.attendanceUC1);
            this.Controls.Add(this.addEmployee1);
            this.Controls.Add(this.addStockUC1);
            this.Controls.Add(this.saledataUC1);
            this.Controls.Add(this.homepagemainPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.homePagedragpanel);
            this.homePagePanelSlider.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "homePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "homePage";
            this.Load += new System.EventHandler(this.homePage_Load);
            this.homePagedragpanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel homePagedragpanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label mainpagetimeDisplaylabel;
        private System.Windows.Forms.Label activeuserlbl;
        private System.Windows.Forms.Label label4;
        private UserControlls.homepagemainPanel homepagemainPanel1;
        private UserControlls.saledataUC saledataUC1;
        private BunifuAnimatorNS.BunifuTransition homePagePanelSlider;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Timer mainpageTimerDisplay;
        private UserControlls.addStockUC addStockUC1;
        private UserControlls.addEmployee addEmployee1;
        private Bunifu.Framework.UI.BunifuDragControl homepageDrag;
        private UserControlls.attendanceUC attendanceUC1;
        private UserControlls.stockUC stockUC1;
        private UserControlls.Revenue revenue1;
        private UserControlls.EmployeesInfo employeesInfo1;
        private UserControlls.detail detail1;
        private UserControlls.settings settings1;
        private UserControlls.aboutDeveloper aboutDeveloper1;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button minimizebtn;
        private System.Windows.Forms.Button maximizebtn;
        private System.Windows.Forms.Panel panel1;
        private UserControlls.BillingInfo billingInfo1;
    }
}