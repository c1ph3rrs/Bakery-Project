namespace Bakery_System
{
    partial class searchProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(searchProduct));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.searchpageSearchProductbtn = new System.Windows.Forms.Button();
            this.searchpagecancelbtn = new System.Windows.Forms.Button();
            this.searchItemDataGrid = new System.Windows.Forms.DataGridView();
            this.searchitemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchitemPriceperUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchpageSearchtxt = new System.Windows.Forms.TextBox();
            this.searchProductPricelabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.searchProductNamelabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.searchPageDragController = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchItemDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(567, 39);
            this.panel1.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Search Any Thing";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.searchpageSearchProductbtn);
            this.panel2.Controls.Add(this.searchpagecancelbtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 206);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(567, 42);
            this.panel2.TabIndex = 21;
            // 
            // searchpageSearchProductbtn
            // 
            this.searchpageSearchProductbtn.BackColor = System.Drawing.Color.White;
            this.searchpageSearchProductbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchpageSearchProductbtn.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.searchpageSearchProductbtn.Location = new System.Drawing.Point(452, 9);
            this.searchpageSearchProductbtn.Name = "searchpageSearchProductbtn";
            this.searchpageSearchProductbtn.Size = new System.Drawing.Size(102, 23);
            this.searchpageSearchProductbtn.TabIndex = 10;
            this.searchpageSearchProductbtn.Text = "Search";
            this.searchpageSearchProductbtn.UseVisualStyleBackColor = false;
            this.searchpageSearchProductbtn.Click += new System.EventHandler(this.searchpageSearchProductbtn_Click);
            // 
            // searchpagecancelbtn
            // 
            this.searchpagecancelbtn.BackColor = System.Drawing.Color.White;
            this.searchpagecancelbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchpagecancelbtn.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.searchpagecancelbtn.Location = new System.Drawing.Point(351, 9);
            this.searchpagecancelbtn.Name = "searchpagecancelbtn";
            this.searchpagecancelbtn.Size = new System.Drawing.Size(95, 24);
            this.searchpagecancelbtn.TabIndex = 11;
            this.searchpagecancelbtn.Text = "Cancel";
            this.searchpagecancelbtn.UseVisualStyleBackColor = false;
            this.searchpagecancelbtn.Click += new System.EventHandler(this.searchpagecancelbtn_Click);
            // 
            // searchItemDataGrid
            // 
            this.searchItemDataGrid.AllowUserToAddRows = false;
            this.searchItemDataGrid.AllowUserToDeleteRows = false;
            this.searchItemDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchItemDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.searchitemName,
            this.searchitemPriceperUnit});
            this.searchItemDataGrid.Location = new System.Drawing.Point(31, 124);
            this.searchItemDataGrid.Name = "searchItemDataGrid";
            this.searchItemDataGrid.ReadOnly = true;
            this.searchItemDataGrid.Size = new System.Drawing.Size(523, 77);
            this.searchItemDataGrid.TabIndex = 31;
            // 
            // searchitemName
            // 
            this.searchitemName.HeaderText = "Item Name";
            this.searchitemName.Name = "searchitemName";
            this.searchitemName.ReadOnly = true;
            this.searchitemName.Width = 330;
            // 
            // searchitemPriceperUnit
            // 
            this.searchitemPriceperUnit.HeaderText = "Price Per Unit";
            this.searchitemPriceperUnit.Name = "searchitemPriceperUnit";
            this.searchitemPriceperUnit.ReadOnly = true;
            this.searchitemPriceperUnit.Width = 130;
            // 
            // searchpageSearchtxt
            // 
            this.searchpageSearchtxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.searchpageSearchtxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.searchpageSearchtxt.Location = new System.Drawing.Point(42, 69);
            this.searchpageSearchtxt.Name = "searchpageSearchtxt";
            this.searchpageSearchtxt.Size = new System.Drawing.Size(512, 23);
            this.searchpageSearchtxt.TabIndex = 30;
            this.searchpageSearchtxt.TextChanged += new System.EventHandler(this.searchpageSearchtxt_TextChanged);
            // 
            // searchProductPricelabel
            // 
            this.searchProductPricelabel.AutoSize = true;
            this.searchProductPricelabel.Font = new System.Drawing.Font("Calibri", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchProductPricelabel.Location = new System.Drawing.Point(498, 103);
            this.searchProductPricelabel.Name = "searchProductPricelabel";
            this.searchProductPricelabel.Size = new System.Drawing.Size(15, 18);
            this.searchProductPricelabel.TabIndex = 29;
            this.searchProductPricelabel.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(277, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 19);
            this.label5.TabIndex = 28;
            this.label5.Text = "Product Price Per Item :";
            // 
            // searchProductNamelabel
            // 
            this.searchProductNamelabel.AutoSize = true;
            this.searchProductNamelabel.Font = new System.Drawing.Font("Calibri", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchProductNamelabel.Location = new System.Drawing.Point(132, 102);
            this.searchProductNamelabel.Name = "searchProductNamelabel";
            this.searchProductNamelabel.Size = new System.Drawing.Size(36, 18);
            this.searchProductNamelabel.TabIndex = 27;
            this.searchProductNamelabel.Text = "NaN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 19);
            this.label3.TabIndex = 26;
            this.label3.Text = "Product Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 18);
            this.label1.TabIndex = 25;
            this.label1.Text = "Just type any Product Name and we will find it.";
            // 
            // searchPageDragController
            // 
            this.searchPageDragController.Fixed = true;
            this.searchPageDragController.Horizontal = true;
            this.searchPageDragController.TargetControl = this.panel1;
            this.searchPageDragController.Vertical = true;
            // 
            // searchProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 248);
            this.Controls.Add(this.searchItemDataGrid);
            this.Controls.Add(this.searchpageSearchtxt);
            this.Controls.Add(this.searchProductPricelabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.searchProductNamelabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "searchProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "searchProduct";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchItemDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button searchpageSearchProductbtn;
        private System.Windows.Forms.Button searchpagecancelbtn;
        private System.Windows.Forms.DataGridView searchItemDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn searchitemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn searchitemPriceperUnit;
        private System.Windows.Forms.TextBox searchpageSearchtxt;
        private System.Windows.Forms.Label searchProductPricelabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label searchProductNamelabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDragControl searchPageDragController;
    }
}