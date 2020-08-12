namespace Bakery_System.UserControlls
{
    partial class stockUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.resetstockbtn = new System.Windows.Forms.Button();
            this.stockInfoDeletebtn = new System.Windows.Forms.Button();
            this.stockInfoUpdatebtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.stockInfoSearchtxt = new System.Windows.Forms.TextBox();
            this.stockDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.stockInfoproductexpiretxt = new System.Windows.Forms.DateTimePicker();
            this.stockinfoLeftQuantitytxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.stockInfoproductmanDatetxt = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.stockInfoproductmanCompanytxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.stockInfoProductnametxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.stockInfoPricetxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.stockInfoNewQuantitytxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.stockInfoBarcodetxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.label11 = new System.Windows.Forms.Label();
            this.stockInfoBuyingPriceTxt = new System.Windows.Forms.TextBox();
            this.productNameStockinfogridview = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityStockinfogridview = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDetailBuyPriceGridView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricePerItemStockinfogridview = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soldStockinfogridview = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manCompanyStockinfogridview = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manfDateStockinfogridview = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expireStockinfogridview = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcodeStockinfogridview = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // resetstockbtn
            // 
            this.resetstockbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resetstockbtn.Location = new System.Drawing.Point(1109, 67);
            this.resetstockbtn.Name = "resetstockbtn";
            this.resetstockbtn.Size = new System.Drawing.Size(138, 23);
            this.resetstockbtn.TabIndex = 12;
            this.resetstockbtn.Text = "&Reset All";
            this.resetstockbtn.UseVisualStyleBackColor = true;
            this.resetstockbtn.Click += new System.EventHandler(this.resetstockbtn_Click);
            // 
            // stockInfoDeletebtn
            // 
            this.stockInfoDeletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.stockInfoDeletebtn.Location = new System.Drawing.Point(322, 398);
            this.stockInfoDeletebtn.Name = "stockInfoDeletebtn";
            this.stockInfoDeletebtn.Size = new System.Drawing.Size(102, 23);
            this.stockInfoDeletebtn.TabIndex = 10;
            this.stockInfoDeletebtn.Text = "&Delete";
            this.stockInfoDeletebtn.UseVisualStyleBackColor = true;
            this.stockInfoDeletebtn.Click += new System.EventHandler(this.stockInfoDeletebtn_Click);
            // 
            // stockInfoUpdatebtn
            // 
            this.stockInfoUpdatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.stockInfoUpdatebtn.Location = new System.Drawing.Point(430, 398);
            this.stockInfoUpdatebtn.Name = "stockInfoUpdatebtn";
            this.stockInfoUpdatebtn.Size = new System.Drawing.Size(102, 23);
            this.stockInfoUpdatebtn.TabIndex = 9;
            this.stockInfoUpdatebtn.Text = "&Update";
            this.stockInfoUpdatebtn.UseVisualStyleBackColor = true;
            this.stockInfoUpdatebtn.Click += new System.EventHandler(this.stockInfoUpdatebtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.stockInfoSearchtxt);
            this.groupBox2.Controls.Add(this.stockDataGridView);
            this.groupBox2.Location = new System.Drawing.Point(538, 107);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(709, 304);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Employees";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(441, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Search";
            // 
            // stockInfoSearchtxt
            // 
            this.stockInfoSearchtxt.Location = new System.Drawing.Point(502, 15);
            this.stockInfoSearchtxt.Name = "stockInfoSearchtxt";
            this.stockInfoSearchtxt.Size = new System.Drawing.Size(201, 23);
            this.stockInfoSearchtxt.TabIndex = 11;
            this.stockInfoSearchtxt.TextChanged += new System.EventHandler(this.stockInfoSearchtxt_TextChanged);
            // 
            // stockDataGridView
            // 
            this.stockDataGridView.AllowUserToAddRows = false;
            this.stockDataGridView.AllowUserToDeleteRows = false;
            this.stockDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.stockDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stockDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productNameStockinfogridview,
            this.QuantityStockinfogridview,
            this.stockDetailBuyPriceGridView,
            this.pricePerItemStockinfogridview,
            this.soldStockinfogridview,
            this.manCompanyStockinfogridview,
            this.manfDateStockinfogridview,
            this.expireStockinfogridview,
            this.barcodeStockinfogridview});
            this.stockDataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.stockDataGridView.Location = new System.Drawing.Point(6, 42);
            this.stockDataGridView.Name = "stockDataGridView";
            this.stockDataGridView.ReadOnly = true;
            this.stockDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.stockDataGridView.Size = new System.Drawing.Size(697, 256);
            this.stockDataGridView.TabIndex = 0;
            this.stockDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.stockDataGridView_CellClick);
            this.stockDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.stockDataGridView_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.stockInfoBuyingPriceTxt);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.stockInfoproductexpiretxt);
            this.groupBox1.Controls.Add(this.stockinfoLeftQuantitytxt);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.stockInfoproductmanDatetxt);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.stockInfoproductmanCompanytxt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.stockInfoProductnametxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.stockInfoPricetxt);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.stockInfoNewQuantitytxt);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.stockInfoBarcodetxt);
            this.groupBox1.Location = new System.Drawing.Point(20, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(512, 285);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stock Info";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(286, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 15);
            this.label10.TabIndex = 29;
            this.label10.Text = "Left";
            // 
            // stockInfoproductexpiretxt
            // 
            this.stockInfoproductexpiretxt.Location = new System.Drawing.Point(113, 246);
            this.stockInfoproductexpiretxt.Name = "stockInfoproductexpiretxt";
            this.stockInfoproductexpiretxt.Size = new System.Drawing.Size(362, 23);
            this.stockInfoproductexpiretxt.TabIndex = 8;
            // 
            // stockinfoLeftQuantitytxt
            // 
            this.stockinfoLeftQuantitytxt.Location = new System.Drawing.Point(325, 68);
            this.stockinfoLeftQuantitytxt.Name = "stockinfoLeftQuantitytxt";
            this.stockinfoLeftQuantitytxt.ReadOnly = true;
            this.stockinfoLeftQuantitytxt.Size = new System.Drawing.Size(150, 23);
            this.stockinfoLeftQuantitytxt.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 15);
            this.label7.TabIndex = 27;
            this.label7.Text = "Expire Date";
            // 
            // stockInfoproductmanDatetxt
            // 
            this.stockInfoproductmanDatetxt.Location = new System.Drawing.Point(113, 207);
            this.stockInfoproductmanDatetxt.Name = "stockInfoproductmanDatetxt";
            this.stockInfoproductmanDatetxt.Size = new System.Drawing.Size(362, 23);
            this.stockInfoproductmanDatetxt.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 15);
            this.label6.TabIndex = 26;
            this.label6.Text = "Manufact. Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 15);
            this.label5.TabIndex = 25;
            this.label5.Text = "Man. Company";
            // 
            // stockInfoproductmanCompanytxt
            // 
            this.stockInfoproductmanCompanytxt.Location = new System.Drawing.Point(113, 169);
            this.stockInfoproductmanCompanytxt.Name = "stockInfoproductmanCompanytxt";
            this.stockInfoproductmanCompanytxt.Size = new System.Drawing.Size(362, 23);
            this.stockInfoproductmanCompanytxt.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 15);
            this.label4.TabIndex = 24;
            this.label4.Text = "Product Name";
            // 
            // stockInfoProductnametxt
            // 
            this.stockInfoProductnametxt.Location = new System.Drawing.Point(113, 65);
            this.stockInfoProductnametxt.Name = "stockInfoProductnametxt";
            this.stockInfoProductnametxt.Size = new System.Drawing.Size(158, 23);
            this.stockInfoProductnametxt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "Sale Price";
            // 
            // stockInfoPricetxt
            // 
            this.stockInfoPricetxt.Location = new System.Drawing.Point(353, 100);
            this.stockInfoPricetxt.Name = "stockInfoPricetxt";
            this.stockInfoPricetxt.Size = new System.Drawing.Size(122, 23);
            this.stockInfoPricetxt.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "New Quantity";
            // 
            // stockInfoNewQuantitytxt
            // 
            this.stockInfoNewQuantitytxt.Location = new System.Drawing.Point(113, 133);
            this.stockInfoNewQuantitytxt.Name = "stockInfoNewQuantitytxt";
            this.stockInfoNewQuantitytxt.Size = new System.Drawing.Size(362, 23);
            this.stockInfoNewQuantitytxt.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 15);
            this.label9.TabIndex = 14;
            this.label9.Text = "Barcode No";
            // 
            // stockInfoBarcodetxt
            // 
            this.stockInfoBarcodetxt.Location = new System.Drawing.Point(113, 32);
            this.stockInfoBarcodetxt.Name = "stockInfoBarcodetxt";
            this.stockInfoBarcodetxt.ReadOnly = true;
            this.stockInfoBarcodetxt.Size = new System.Drawing.Size(362, 23);
            this.stockInfoBarcodetxt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(512, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 41);
            this.label1.TabIndex = 22;
            this.label1.Text = "Stock Detail";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(20, 83);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(1227, 31);
            this.bunifuSeparator1.TabIndex = 23;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 103);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 15);
            this.label11.TabIndex = 31;
            this.label11.Text = "Buy Price";
            // 
            // stockInfoBuyingPriceTxt
            // 
            this.stockInfoBuyingPriceTxt.Location = new System.Drawing.Point(113, 100);
            this.stockInfoBuyingPriceTxt.Name = "stockInfoBuyingPriceTxt";
            this.stockInfoBuyingPriceTxt.Size = new System.Drawing.Size(158, 23);
            this.stockInfoBuyingPriceTxt.TabIndex = 3;
            // 
            // productNameStockinfogridview
            // 
            this.productNameStockinfogridview.HeaderText = "Product Name";
            this.productNameStockinfogridview.Name = "productNameStockinfogridview";
            this.productNameStockinfogridview.ReadOnly = true;
            // 
            // QuantityStockinfogridview
            // 
            this.QuantityStockinfogridview.HeaderText = "Quantity";
            this.QuantityStockinfogridview.Name = "QuantityStockinfogridview";
            this.QuantityStockinfogridview.ReadOnly = true;
            // 
            // stockDetailBuyPriceGridView
            // 
            this.stockDetailBuyPriceGridView.HeaderText = "Buy Price";
            this.stockDetailBuyPriceGridView.Name = "stockDetailBuyPriceGridView";
            this.stockDetailBuyPriceGridView.ReadOnly = true;
            // 
            // pricePerItemStockinfogridview
            // 
            this.pricePerItemStockinfogridview.HeaderText = "Sale Price";
            this.pricePerItemStockinfogridview.Name = "pricePerItemStockinfogridview";
            this.pricePerItemStockinfogridview.ReadOnly = true;
            // 
            // soldStockinfogridview
            // 
            this.soldStockinfogridview.HeaderText = "Items Left";
            this.soldStockinfogridview.Name = "soldStockinfogridview";
            this.soldStockinfogridview.ReadOnly = true;
            // 
            // manCompanyStockinfogridview
            // 
            this.manCompanyStockinfogridview.HeaderText = "Manuf. Company";
            this.manCompanyStockinfogridview.Name = "manCompanyStockinfogridview";
            this.manCompanyStockinfogridview.ReadOnly = true;
            // 
            // manfDateStockinfogridview
            // 
            this.manfDateStockinfogridview.HeaderText = "Manf. Date";
            this.manfDateStockinfogridview.Name = "manfDateStockinfogridview";
            this.manfDateStockinfogridview.ReadOnly = true;
            // 
            // expireStockinfogridview
            // 
            this.expireStockinfogridview.HeaderText = "Expire";
            this.expireStockinfogridview.Name = "expireStockinfogridview";
            this.expireStockinfogridview.ReadOnly = true;
            // 
            // barcodeStockinfogridview
            // 
            this.barcodeStockinfogridview.HeaderText = "Barcode";
            this.barcodeStockinfogridview.Name = "barcodeStockinfogridview";
            this.barcodeStockinfogridview.ReadOnly = true;
            // 
            // stockUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.resetstockbtn);
            this.Controls.Add(this.stockInfoDeletebtn);
            this.Controls.Add(this.stockInfoUpdatebtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuSeparator1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.Name = "stockUC";
            this.Size = new System.Drawing.Size(1264, 463);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button resetstockbtn;
        private System.Windows.Forms.Button stockInfoDeletebtn;
        private System.Windows.Forms.Button stockInfoUpdatebtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox stockInfoSearchtxt;
        private System.Windows.Forms.DataGridView stockDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker stockInfoproductexpiretxt;
        private System.Windows.Forms.TextBox stockinfoLeftQuantitytxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker stockInfoproductmanDatetxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox stockInfoproductmanCompanytxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox stockInfoProductnametxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox stockInfoPricetxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox stockInfoNewQuantitytxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox stockInfoBarcodetxt;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox stockInfoBuyingPriceTxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameStockinfogridview;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityStockinfogridview;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDetailBuyPriceGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn pricePerItemStockinfogridview;
        private System.Windows.Forms.DataGridViewTextBoxColumn soldStockinfogridview;
        private System.Windows.Forms.DataGridViewTextBoxColumn manCompanyStockinfogridview;
        private System.Windows.Forms.DataGridViewTextBoxColumn manfDateStockinfogridview;
        private System.Windows.Forms.DataGridViewTextBoxColumn expireStockinfogridview;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeStockinfogridview;
    }
}
