namespace Bakery_System.UserControlls
{
    partial class saledataUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(saledataUC));
            this.newBillbtn = new System.Windows.Forms.Button();
            this.generateBillbtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cartgrandTotaltxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cartreturnmoneytxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cartpaidtxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.saledataremovebtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.forSaleDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.printCustomerData = new System.Windows.Forms.PrintPreviewDialog();
            this.printCustomerDocument = new System.Drawing.Printing.PrintDocument();
            this.cartproductBarcodetxt = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cartProductShow = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cartProductBillNo = new System.Windows.Forms.Label();
            this.productgridviewcolumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantitygridviewcolumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricegridviewcolumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalpricegridviewcolumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIdDataGridView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cartProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cartProductPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cartProductQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cartProductCodeGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.forSaleDataGridView)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cartProductShow)).BeginInit();
            this.SuspendLayout();
            // 
            // newBillbtn
            // 
            this.newBillbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.newBillbtn.Location = new System.Drawing.Point(53, 158);
            this.newBillbtn.Name = "newBillbtn";
            this.newBillbtn.Size = new System.Drawing.Size(91, 23);
            this.newBillbtn.TabIndex = 3;
            this.newBillbtn.Text = "&New";
            this.newBillbtn.UseVisualStyleBackColor = true;
            this.newBillbtn.Click += new System.EventHandler(this.newBillbtn_Click);
            // 
            // generateBillbtn
            // 
            this.generateBillbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.generateBillbtn.Location = new System.Drawing.Point(151, 158);
            this.generateBillbtn.Name = "generateBillbtn";
            this.generateBillbtn.Size = new System.Drawing.Size(90, 23);
            this.generateBillbtn.TabIndex = 2;
            this.generateBillbtn.Text = "&Genrate Bill";
            this.generateBillbtn.UseVisualStyleBackColor = true;
            this.generateBillbtn.Click += new System.EventHandler(this.generateBillbtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.newBillbtn);
            this.groupBox2.Controls.Add(this.cartgrandTotaltxt);
            this.groupBox2.Controls.Add(this.generateBillbtn);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cartreturnmoneytxt);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cartpaidtxt);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(993, 241);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(252, 192);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bill Detail";
            // 
            // cartgrandTotaltxt
            // 
            this.cartgrandTotaltxt.ForeColor = System.Drawing.Color.Black;
            this.cartgrandTotaltxt.Location = new System.Drawing.Point(96, 26);
            this.cartgrandTotaltxt.Name = "cartgrandTotaltxt";
            this.cartgrandTotaltxt.ReadOnly = true;
            this.cartgrandTotaltxt.Size = new System.Drawing.Size(145, 23);
            this.cartgrandTotaltxt.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(8, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 18);
            this.label10.TabIndex = 19;
            this.label10.Text = "Grand Total";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(50, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(171, 15);
            this.label9.TabIndex = 16;
            this.label9.Text = "Thanks You For Shopping Here";
            // 
            // cartreturnmoneytxt
            // 
            this.cartreturnmoneytxt.ForeColor = System.Drawing.Color.Black;
            this.cartreturnmoneytxt.Location = new System.Drawing.Point(96, 84);
            this.cartreturnmoneytxt.Name = "cartreturnmoneytxt";
            this.cartreturnmoneytxt.ReadOnly = true;
            this.cartreturnmoneytxt.Size = new System.Drawing.Size(145, 23);
            this.cartreturnmoneytxt.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(8, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Return";
            // 
            // cartpaidtxt
            // 
            this.cartpaidtxt.ForeColor = System.Drawing.Color.Black;
            this.cartpaidtxt.Location = new System.Drawing.Point(96, 55);
            this.cartpaidtxt.Name = "cartpaidtxt";
            this.cartpaidtxt.Size = new System.Drawing.Size(145, 23);
            this.cartpaidtxt.TabIndex = 1;
            this.cartpaidtxt.TextChanged += new System.EventHandler(this.cartpaidtxt_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(8, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Paid";
            // 
            // saledataremovebtn
            // 
            this.saledataremovebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saledataremovebtn.Location = new System.Drawing.Point(993, 212);
            this.saledataremovebtn.Name = "saledataremovebtn";
            this.saledataremovebtn.Size = new System.Drawing.Size(252, 23);
            this.saledataremovebtn.TabIndex = 4;
            this.saledataremovebtn.Text = "Remove Product";
            this.saledataremovebtn.UseVisualStyleBackColor = true;
            this.saledataremovebtn.Click += new System.EventHandler(this.saledataremovebtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.forSaleDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(456, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(531, 308);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product\'s Detail";
            // 
            // forSaleDataGridView
            // 
            this.forSaleDataGridView.AllowUserToAddRows = false;
            this.forSaleDataGridView.AllowUserToDeleteRows = false;
            this.forSaleDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.forSaleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.forSaleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productgridviewcolumn,
            this.quantitygridviewcolumn,
            this.pricegridviewcolumn,
            this.totalpricegridviewcolumn,
            this.productIdDataGridView});
            this.forSaleDataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.forSaleDataGridView.Location = new System.Drawing.Point(6, 22);
            this.forSaleDataGridView.Name = "forSaleDataGridView";
            this.forSaleDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.forSaleDataGridView.Size = new System.Drawing.Size(516, 280);
            this.forSaleDataGridView.TabIndex = 0;
            this.forSaleDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.forSaleDataGridView_CellClick);
            this.forSaleDataGridView.KeyUp += new System.Windows.Forms.KeyEventHandler(this.forSaleDataGridView_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(302, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(660, 38);
            this.label1.TabIndex = 7;
            this.label1.Text = "Here All You can Scan Product for Sale";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(19, 58);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(1226, 13);
            this.bunifuSeparator1.TabIndex = 9;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // printCustomerData
            // 
            this.printCustomerData.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printCustomerData.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printCustomerData.ClientSize = new System.Drawing.Size(400, 300);
            this.printCustomerData.Enabled = true;
            this.printCustomerData.Icon = ((System.Drawing.Icon)(resources.GetObject("printCustomerData.Icon")));
            this.printCustomerData.Name = "printCustomerData";
            this.printCustomerData.Visible = false;
            // 
            // printCustomerDocument
            // 
            this.printCustomerDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printCustomerDocument_PrintPage);
            // 
            // cartproductBarcodetxt
            // 
            this.cartproductBarcodetxt.Location = new System.Drawing.Point(6, 19);
            this.cartproductBarcodetxt.Name = "cartproductBarcodetxt";
            this.cartproductBarcodetxt.Size = new System.Drawing.Size(1203, 23);
            this.cartproductBarcodetxt.TabIndex = 0;
            this.cartproductBarcodetxt.TextChanged += new System.EventHandler(this.cartproductBarcodetxt_TextChanged);
            this.cartproductBarcodetxt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cartproductBarcodetxt_KeyUp);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cartproductBarcodetxt);
            this.groupBox3.Location = new System.Drawing.Point(25, 74);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1220, 49);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Barcode";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cartProductShow);
            this.groupBox4.Location = new System.Drawing.Point(25, 138);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(425, 308);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Products";
            // 
            // cartProductShow
            // 
            this.cartProductShow.AllowUserToAddRows = false;
            this.cartProductShow.AllowUserToDeleteRows = false;
            this.cartProductShow.BackgroundColor = System.Drawing.SystemColors.Control;
            this.cartProductShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cartProductShow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cartProductName,
            this.cartProductPrice,
            this.cartProductQty,
            this.cartProductCodeGrid});
            this.cartProductShow.GridColor = System.Drawing.SystemColors.Control;
            this.cartProductShow.Location = new System.Drawing.Point(6, 16);
            this.cartProductShow.Name = "cartProductShow";
            this.cartProductShow.ReadOnly = true;
            this.cartProductShow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cartProductShow.Size = new System.Drawing.Size(413, 286);
            this.cartProductShow.TabIndex = 0;
            this.cartProductShow.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cartProductShow_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1014, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Bill No.";
            // 
            // cartProductBillNo
            // 
            this.cartProductBillNo.AutoSize = true;
            this.cartProductBillNo.Location = new System.Drawing.Point(1067, 155);
            this.cartProductBillNo.Name = "cartProductBillNo";
            this.cartProductBillNo.Size = new System.Drawing.Size(28, 15);
            this.cartProductBillNo.TabIndex = 12;
            this.cartProductBillNo.Text = "123";
            // 
            // productgridviewcolumn
            // 
            this.productgridviewcolumn.HeaderText = "Products";
            this.productgridviewcolumn.Name = "productgridviewcolumn";
            this.productgridviewcolumn.ReadOnly = true;
            this.productgridviewcolumn.Width = 200;
            // 
            // quantitygridviewcolumn
            // 
            this.quantitygridviewcolumn.HeaderText = "Quantity";
            this.quantitygridviewcolumn.Name = "quantitygridviewcolumn";
            this.quantitygridviewcolumn.Width = 70;
            // 
            // pricegridviewcolumn
            // 
            this.pricegridviewcolumn.HeaderText = "Price P. Item";
            this.pricegridviewcolumn.Name = "pricegridviewcolumn";
            this.pricegridviewcolumn.ReadOnly = true;
            // 
            // totalpricegridviewcolumn
            // 
            this.totalpricegridviewcolumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.totalpricegridviewcolumn.HeaderText = "Total Price";
            this.totalpricegridviewcolumn.Name = "totalpricegridviewcolumn";
            this.totalpricegridviewcolumn.ReadOnly = true;
            // 
            // productIdDataGridView
            // 
            this.productIdDataGridView.HeaderText = "Product Id";
            this.productIdDataGridView.Name = "productIdDataGridView";
            this.productIdDataGridView.Width = 5;
            // 
            // cartProductName
            // 
            this.cartProductName.HeaderText = "Product";
            this.cartProductName.Name = "cartProductName";
            this.cartProductName.ReadOnly = true;
            this.cartProductName.Width = 200;
            // 
            // cartProductPrice
            // 
            this.cartProductPrice.HeaderText = "Price";
            this.cartProductPrice.Name = "cartProductPrice";
            this.cartProductPrice.ReadOnly = true;
            // 
            // cartProductQty
            // 
            this.cartProductQty.HeaderText = "Qty";
            this.cartProductQty.Name = "cartProductQty";
            this.cartProductQty.ReadOnly = true;
            this.cartProductQty.Width = 70;
            // 
            // cartProductCodeGrid
            // 
            this.cartProductCodeGrid.HeaderText = "P Code";
            this.cartProductCodeGrid.Name = "cartProductCodeGrid";
            this.cartProductCodeGrid.ReadOnly = true;
            // 
            // saledataUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cartProductBillNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.saledataremovebtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.groupBox3);
            this.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.Name = "saledataUC";
            this.Size = new System.Drawing.Size(1264, 463);
            this.Load += new System.EventHandler(this.saledataUC_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.saledataUC_KeyDown);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.forSaleDataGridView)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cartProductShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newBillbtn;
        private System.Windows.Forms.Button generateBillbtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox cartgrandTotaltxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button saledataremovebtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox cartreturnmoneytxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cartpaidtxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView forSaleDataGridView;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.PrintPreviewDialog printCustomerData;
        private System.Drawing.Printing.PrintDocument printCustomerDocument;
        private System.Windows.Forms.TextBox cartproductBarcodetxt;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView cartProductShow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label cartProductBillNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn productgridviewcolumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantitygridviewcolumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pricegridviewcolumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalpricegridviewcolumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIdDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn cartProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cartProductPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn cartProductQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn cartProductCodeGrid;
    }
}
