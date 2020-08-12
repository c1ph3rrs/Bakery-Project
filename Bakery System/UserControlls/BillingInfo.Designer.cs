namespace Bakery_System.UserControlls
{
    partial class BillingInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillingInfo));
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.billInfoBillDetailGridView = new System.Windows.Forms.DataGridView();
            this.billingInfoProductNameGridView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billingInfoProductQtyGridView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billingInfoProductPricePerItemGridView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billingInfoProductTotalPriceGridView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billingInfoProductSaleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billingInfoProductBillNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billInfoProductIdGridView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.billInfoBillCheckBtn = new System.Windows.Forms.Button();
            this.billInfoBillNoTxt = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.billInfoReturnPriceTxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.billInfoGenerateBillBtn = new System.Windows.Forms.Button();
            this.billInfoProductTotalQtytxt = new System.Windows.Forms.TextBox();
            this.billInfoClearBtn = new System.Windows.Forms.Button();
            this.billInfoProductReturnBtn = new System.Windows.Forms.Button();
            this.billInfoProductDeleteBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.billInfoTotalPriceTxt = new System.Windows.Forms.TextBox();
            this.billInfoPricePerItemTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.billInfoProductReturnQtytxt = new System.Windows.Forms.TextBox();
            this.billInfoProductNametxt = new System.Windows.Forms.TextBox();
            this.billInfoProductIdTxt = new System.Windows.Forms.TextBox();
            this.billInfoSaleIdTxt = new System.Windows.Forms.TextBox();
            this.billInfoBillCodeTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.printBillDialogData = new System.Windows.Forms.PrintPreviewDialog();
            this.printBillDocument = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.billInfoBillDetailGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(529, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Billing Info";
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(30, 54);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(1202, 18);
            this.bunifuSeparator2.TabIndex = 16;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // billInfoBillDetailGridView
            // 
            this.billInfoBillDetailGridView.AllowUserToAddRows = false;
            this.billInfoBillDetailGridView.AllowUserToDeleteRows = false;
            this.billInfoBillDetailGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.billInfoBillDetailGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.billInfoBillDetailGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.billingInfoProductNameGridView,
            this.billingInfoProductQtyGridView,
            this.billingInfoProductPricePerItemGridView,
            this.billingInfoProductTotalPriceGridView,
            this.billingInfoProductSaleID,
            this.billingInfoProductBillNo,
            this.billInfoProductIdGridView});
            this.billInfoBillDetailGridView.GridColor = System.Drawing.SystemColors.Control;
            this.billInfoBillDetailGridView.Location = new System.Drawing.Point(6, 22);
            this.billInfoBillDetailGridView.Name = "billInfoBillDetailGridView";
            this.billInfoBillDetailGridView.ReadOnly = true;
            this.billInfoBillDetailGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.billInfoBillDetailGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.billInfoBillDetailGridView.Size = new System.Drawing.Size(727, 250);
            this.billInfoBillDetailGridView.TabIndex = 17;
            this.billInfoBillDetailGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.billInfoBillDetailGridView_CellClick);
            // 
            // billingInfoProductNameGridView
            // 
            this.billingInfoProductNameGridView.HeaderText = "Product Name";
            this.billingInfoProductNameGridView.Name = "billingInfoProductNameGridView";
            this.billingInfoProductNameGridView.ReadOnly = true;
            this.billingInfoProductNameGridView.Width = 130;
            // 
            // billingInfoProductQtyGridView
            // 
            this.billingInfoProductQtyGridView.HeaderText = "Qty";
            this.billingInfoProductQtyGridView.Name = "billingInfoProductQtyGridView";
            this.billingInfoProductQtyGridView.ReadOnly = true;
            this.billingInfoProductQtyGridView.Width = 50;
            // 
            // billingInfoProductPricePerItemGridView
            // 
            this.billingInfoProductPricePerItemGridView.HeaderText = "Price Per Item";
            this.billingInfoProductPricePerItemGridView.Name = "billingInfoProductPricePerItemGridView";
            this.billingInfoProductPricePerItemGridView.ReadOnly = true;
            this.billingInfoProductPricePerItemGridView.Width = 120;
            // 
            // billingInfoProductTotalPriceGridView
            // 
            this.billingInfoProductTotalPriceGridView.HeaderText = "Total Price";
            this.billingInfoProductTotalPriceGridView.Name = "billingInfoProductTotalPriceGridView";
            this.billingInfoProductTotalPriceGridView.ReadOnly = true;
            // 
            // billingInfoProductSaleID
            // 
            this.billingInfoProductSaleID.HeaderText = "Sale Id";
            this.billingInfoProductSaleID.Name = "billingInfoProductSaleID";
            this.billingInfoProductSaleID.ReadOnly = true;
            // 
            // billingInfoProductBillNo
            // 
            this.billingInfoProductBillNo.HeaderText = "Bill No";
            this.billingInfoProductBillNo.Name = "billingInfoProductBillNo";
            this.billingInfoProductBillNo.ReadOnly = true;
            // 
            // billInfoProductIdGridView
            // 
            this.billInfoProductIdGridView.HeaderText = "P.id";
            this.billInfoProductIdGridView.Name = "billInfoProductIdGridView";
            this.billInfoProductIdGridView.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.billInfoBillDetailGridView);
            this.groupBox1.Location = new System.Drawing.Point(47, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(739, 278);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bill Info .";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.billInfoBillCheckBtn);
            this.groupBox2.Controls.Add(this.billInfoBillNoTxt);
            this.groupBox2.Location = new System.Drawing.Point(47, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(739, 50);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bill No .";
            // 
            // billInfoBillCheckBtn
            // 
            this.billInfoBillCheckBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.billInfoBillCheckBtn.Location = new System.Drawing.Point(556, 20);
            this.billInfoBillCheckBtn.Name = "billInfoBillCheckBtn";
            this.billInfoBillCheckBtn.Size = new System.Drawing.Size(177, 24);
            this.billInfoBillCheckBtn.TabIndex = 20;
            this.billInfoBillCheckBtn.Text = "Check";
            this.billInfoBillCheckBtn.UseVisualStyleBackColor = true;
            this.billInfoBillCheckBtn.Click += new System.EventHandler(this.billInfoBillCheckBtn_Click);
            // 
            // billInfoBillNoTxt
            // 
            this.billInfoBillNoTxt.Location = new System.Drawing.Point(6, 20);
            this.billInfoBillNoTxt.Name = "billInfoBillNoTxt";
            this.billInfoBillNoTxt.Size = new System.Drawing.Size(544, 23);
            this.billInfoBillNoTxt.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.billInfoReturnPriceTxt);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.billInfoGenerateBillBtn);
            this.groupBox3.Controls.Add(this.billInfoProductTotalQtytxt);
            this.groupBox3.Controls.Add(this.billInfoClearBtn);
            this.groupBox3.Controls.Add(this.billInfoProductReturnBtn);
            this.groupBox3.Controls.Add(this.billInfoProductDeleteBtn);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.billInfoTotalPriceTxt);
            this.groupBox3.Controls.Add(this.billInfoPricePerItemTxt);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.billInfoProductReturnQtytxt);
            this.groupBox3.Controls.Add(this.billInfoProductNametxt);
            this.groupBox3.Controls.Add(this.billInfoProductIdTxt);
            this.groupBox3.Controls.Add(this.billInfoSaleIdTxt);
            this.groupBox3.Controls.Add(this.billInfoBillCodeTxt);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(792, 69);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(440, 334);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Detail";
            // 
            // billInfoReturnPriceTxt
            // 
            this.billInfoReturnPriceTxt.Location = new System.Drawing.Point(122, 239);
            this.billInfoReturnPriceTxt.Name = "billInfoReturnPriceTxt";
            this.billInfoReturnPriceTxt.ReadOnly = true;
            this.billInfoReturnPriceTxt.Size = new System.Drawing.Size(144, 23);
            this.billInfoReturnPriceTxt.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 242);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 15);
            this.label10.TabIndex = 27;
            this.label10.Text = "Return Price";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 15);
            this.label9.TabIndex = 26;
            this.label9.Text = "Total Qty";
            // 
            // billInfoGenerateBillBtn
            // 
            this.billInfoGenerateBillBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.billInfoGenerateBillBtn.Location = new System.Drawing.Point(122, 302);
            this.billInfoGenerateBillBtn.Name = "billInfoGenerateBillBtn";
            this.billInfoGenerateBillBtn.Size = new System.Drawing.Size(307, 24);
            this.billInfoGenerateBillBtn.TabIndex = 23;
            this.billInfoGenerateBillBtn.Text = "Re- &Genrate Bill";
            this.billInfoGenerateBillBtn.UseVisualStyleBackColor = true;
            this.billInfoGenerateBillBtn.Click += new System.EventHandler(this.billInfoGenerateBillBtn_Click);
            // 
            // billInfoProductTotalQtytxt
            // 
            this.billInfoProductTotalQtytxt.Location = new System.Drawing.Point(122, 148);
            this.billInfoProductTotalQtytxt.Name = "billInfoProductTotalQtytxt";
            this.billInfoProductTotalQtytxt.ReadOnly = true;
            this.billInfoProductTotalQtytxt.Size = new System.Drawing.Size(110, 23);
            this.billInfoProductTotalQtytxt.TabIndex = 25;
            // 
            // billInfoClearBtn
            // 
            this.billInfoClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.billInfoClearBtn.Location = new System.Drawing.Point(285, 272);
            this.billInfoClearBtn.Name = "billInfoClearBtn";
            this.billInfoClearBtn.Size = new System.Drawing.Size(144, 24);
            this.billInfoClearBtn.TabIndex = 24;
            this.billInfoClearBtn.Text = "&Clear All";
            this.billInfoClearBtn.UseVisualStyleBackColor = true;
            this.billInfoClearBtn.Click += new System.EventHandler(this.billInfoClearBtn_Click);
            // 
            // billInfoProductReturnBtn
            // 
            this.billInfoProductReturnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.billInfoProductReturnBtn.Location = new System.Drawing.Point(285, 237);
            this.billInfoProductReturnBtn.Name = "billInfoProductReturnBtn";
            this.billInfoProductReturnBtn.Size = new System.Drawing.Size(144, 24);
            this.billInfoProductReturnBtn.TabIndex = 22;
            this.billInfoProductReturnBtn.Text = "&Return";
            this.billInfoProductReturnBtn.UseVisualStyleBackColor = true;
            this.billInfoProductReturnBtn.Click += new System.EventHandler(this.billInfoProductReturnBtn_Click);
            // 
            // billInfoProductDeleteBtn
            // 
            this.billInfoProductDeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.billInfoProductDeleteBtn.Location = new System.Drawing.Point(122, 272);
            this.billInfoProductDeleteBtn.Name = "billInfoProductDeleteBtn";
            this.billInfoProductDeleteBtn.Size = new System.Drawing.Size(144, 24);
            this.billInfoProductDeleteBtn.TabIndex = 21;
            this.billInfoProductDeleteBtn.Text = "&Delete";
            this.billInfoProductDeleteBtn.UseVisualStyleBackColor = true;
            this.billInfoProductDeleteBtn.Click += new System.EventHandler(this.billInfoProductDeleteBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Total Price";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "Price Per Item";
            // 
            // billInfoTotalPriceTxt
            // 
            this.billInfoTotalPriceTxt.Location = new System.Drawing.Point(122, 206);
            this.billInfoTotalPriceTxt.Name = "billInfoTotalPriceTxt";
            this.billInfoTotalPriceTxt.ReadOnly = true;
            this.billInfoTotalPriceTxt.Size = new System.Drawing.Size(307, 23);
            this.billInfoTotalPriceTxt.TabIndex = 11;
            // 
            // billInfoPricePerItemTxt
            // 
            this.billInfoPricePerItemTxt.Location = new System.Drawing.Point(122, 177);
            this.billInfoPricePerItemTxt.Name = "billInfoPricePerItemTxt";
            this.billInfoPricePerItemTxt.ReadOnly = true;
            this.billInfoPricePerItemTxt.Size = new System.Drawing.Size(307, 23);
            this.billInfoPricePerItemTxt.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(241, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "Return - Qty";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Product Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Product Id";
            // 
            // billInfoProductReturnQtytxt
            // 
            this.billInfoProductReturnQtytxt.Location = new System.Drawing.Point(319, 148);
            this.billInfoProductReturnQtytxt.Name = "billInfoProductReturnQtytxt";
            this.billInfoProductReturnQtytxt.Size = new System.Drawing.Size(110, 23);
            this.billInfoProductReturnQtytxt.TabIndex = 6;
            this.billInfoProductReturnQtytxt.TextChanged += new System.EventHandler(this.billInfoProductReturnQtytxt_TextChanged);
            // 
            // billInfoProductNametxt
            // 
            this.billInfoProductNametxt.Location = new System.Drawing.Point(122, 119);
            this.billInfoProductNametxt.Name = "billInfoProductNametxt";
            this.billInfoProductNametxt.ReadOnly = true;
            this.billInfoProductNametxt.Size = new System.Drawing.Size(307, 23);
            this.billInfoProductNametxt.TabIndex = 5;
            // 
            // billInfoProductIdTxt
            // 
            this.billInfoProductIdTxt.Location = new System.Drawing.Point(122, 90);
            this.billInfoProductIdTxt.Name = "billInfoProductIdTxt";
            this.billInfoProductIdTxt.ReadOnly = true;
            this.billInfoProductIdTxt.Size = new System.Drawing.Size(307, 23);
            this.billInfoProductIdTxt.TabIndex = 4;
            // 
            // billInfoSaleIdTxt
            // 
            this.billInfoSaleIdTxt.Location = new System.Drawing.Point(122, 61);
            this.billInfoSaleIdTxt.Name = "billInfoSaleIdTxt";
            this.billInfoSaleIdTxt.ReadOnly = true;
            this.billInfoSaleIdTxt.Size = new System.Drawing.Size(307, 23);
            this.billInfoSaleIdTxt.TabIndex = 3;
            // 
            // billInfoBillCodeTxt
            // 
            this.billInfoBillCodeTxt.Location = new System.Drawing.Point(122, 32);
            this.billInfoBillCodeTxt.Name = "billInfoBillCodeTxt";
            this.billInfoBillCodeTxt.ReadOnly = true;
            this.billInfoBillCodeTxt.Size = new System.Drawing.Size(307, 23);
            this.billInfoBillCodeTxt.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Sale Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Bill No";
            // 
            // printBillDialogData
            // 
            this.printBillDialogData.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printBillDialogData.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printBillDialogData.ClientSize = new System.Drawing.Size(400, 300);
            this.printBillDialogData.Enabled = true;
            this.printBillDialogData.Icon = ((System.Drawing.Icon)(resources.GetObject("printBillDialogData.Icon")));
            this.printBillDialogData.Name = "printBillDialogData";
            this.printBillDialogData.Visible = false;
            // 
            // printBillDocument
            // 
            this.printBillDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printBillDocument_PrintPage);
            // 
            // BillingInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuSeparator2);
            this.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.Name = "BillingInfo";
            this.Size = new System.Drawing.Size(1264, 463);
            ((System.ComponentModel.ISupportInitialize)(this.billInfoBillDetailGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private System.Windows.Forms.DataGridView billInfoBillDetailGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button billInfoBillCheckBtn;
        private System.Windows.Forms.TextBox billInfoBillNoTxt;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox billInfoProductReturnQtytxt;
        private System.Windows.Forms.TextBox billInfoProductNametxt;
        private System.Windows.Forms.TextBox billInfoProductIdTxt;
        private System.Windows.Forms.TextBox billInfoSaleIdTxt;
        private System.Windows.Forms.TextBox billInfoBillCodeTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox billInfoTotalPriceTxt;
        private System.Windows.Forms.TextBox billInfoPricePerItemTxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn billingInfoProductNameGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn billingInfoProductQtyGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn billingInfoProductPricePerItemGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn billingInfoProductTotalPriceGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn billingInfoProductSaleID;
        private System.Windows.Forms.DataGridViewTextBoxColumn billingInfoProductBillNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn billInfoProductIdGridView;
        private System.Windows.Forms.Button billInfoGenerateBillBtn;
        private System.Windows.Forms.Button billInfoProductReturnBtn;
        private System.Windows.Forms.Button billInfoProductDeleteBtn;
        private System.Windows.Forms.Button billInfoClearBtn;
        private System.Windows.Forms.TextBox billInfoReturnPriceTxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox billInfoProductTotalQtytxt;
        private System.Windows.Forms.PrintPreviewDialog printBillDialogData;
        private System.Drawing.Printing.PrintDocument printBillDocument;
    }
}
