namespace Bakery_System.UserControlls
{
    partial class addEmployee
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
            this.label12 = new System.Windows.Forms.Label();
            this.clearnewemployeebtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addnewemployeestatustxt = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.newemployeeJobtitletxt = new System.Windows.Forms.ComboBox();
            this.newemployeeMedicaltxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.newemployeeEducationtxt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.newemployeeaddresstxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.newemployeePhonenotxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.newemployeeDOBtxt = new System.Windows.Forms.DateTimePicker();
            this.newemployeeFemaleRadiobtn = new System.Windows.Forms.RadioButton();
            this.newemployeeMaleRadiobtn = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.newemployeeCnictxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.newemployeeFatherNametxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.newemployeeLastNametxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.newemployeeFirstNametxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.savenewemployeebtn = new System.Windows.Forms.Button();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Georgia", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(397, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(470, 41);
            this.label12.TabIndex = 28;
            this.label12.Text = "Add New Employee Data";
            // 
            // clearnewemployeebtn
            // 
            this.clearnewemployeebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearnewemployeebtn.Location = new System.Drawing.Point(918, 374);
            this.clearnewemployeebtn.Name = "clearnewemployeebtn";
            this.clearnewemployeebtn.Size = new System.Drawing.Size(106, 23);
            this.clearnewemployeebtn.TabIndex = 26;
            this.clearnewemployeebtn.Text = "Clear";
            this.clearnewemployeebtn.UseVisualStyleBackColor = true;
            this.clearnewemployeebtn.Click += new System.EventHandler(this.clearnewemployeebtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addnewemployeestatustxt);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.newemployeeJobtitletxt);
            this.groupBox1.Controls.Add(this.newemployeeMedicaltxt);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.newemployeeEducationtxt);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.newemployeeaddresstxt);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.newemployeePhonenotxt);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.newemployeeDOBtxt);
            this.groupBox1.Controls.Add(this.newemployeeFemaleRadiobtn);
            this.groupBox1.Controls.Add(this.newemployeeMaleRadiobtn);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.newemployeeCnictxt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.newemployeeFatherNametxt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.newemployeeLastNametxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.newemployeeFirstNametxt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(128, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1008, 266);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee Detail";
            // 
            // addnewemployeestatustxt
            // 
            this.addnewemployeestatustxt.FormattingEnabled = true;
            this.addnewemployeestatustxt.Items.AddRange(new object[] {
            "Active",
            "Leave"});
            this.addnewemployeestatustxt.Location = new System.Drawing.Point(746, 107);
            this.addnewemployeestatustxt.Name = "addnewemployeestatustxt";
            this.addnewemployeestatustxt.Size = new System.Drawing.Size(219, 23);
            this.addnewemployeestatustxt.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(664, 112);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 15);
            this.label13.TabIndex = 27;
            this.label13.Text = "Status";
            // 
            // newemployeeJobtitletxt
            // 
            this.newemployeeJobtitletxt.FormattingEnabled = true;
            this.newemployeeJobtitletxt.Location = new System.Drawing.Point(746, 78);
            this.newemployeeJobtitletxt.Name = "newemployeeJobtitletxt";
            this.newemployeeJobtitletxt.Size = new System.Drawing.Size(219, 23);
            this.newemployeeJobtitletxt.TabIndex = 10;
            this.newemployeeJobtitletxt.SelectedIndexChanged += new System.EventHandler(this.newemployeeJobtitletxt_SelectedIndexChanged);
            this.newemployeeJobtitletxt.Click += new System.EventHandler(this.newemployeeJobtitletxt_Click);
            // 
            // newemployeeMedicaltxt
            // 
            this.newemployeeMedicaltxt.Location = new System.Drawing.Point(746, 141);
            this.newemployeeMedicaltxt.Multiline = true;
            this.newemployeeMedicaltxt.Name = "newemployeeMedicaltxt";
            this.newemployeeMedicaltxt.Size = new System.Drawing.Size(219, 106);
            this.newemployeeMedicaltxt.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(664, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 24;
            this.label7.Text = "Medical";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(664, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 15);
            this.label8.TabIndex = 22;
            this.label8.Text = "Job";
            // 
            // newemployeeEducationtxt
            // 
            this.newemployeeEducationtxt.Location = new System.Drawing.Point(746, 39);
            this.newemployeeEducationtxt.Name = "newemployeeEducationtxt";
            this.newemployeeEducationtxt.Size = new System.Drawing.Size(219, 23);
            this.newemployeeEducationtxt.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(664, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 15);
            this.label11.TabIndex = 20;
            this.label11.Text = "Education";
            // 
            // newemployeeaddresstxt
            // 
            this.newemployeeaddresstxt.Location = new System.Drawing.Point(398, 78);
            this.newemployeeaddresstxt.Multiline = true;
            this.newemployeeaddresstxt.Name = "newemployeeaddresstxt";
            this.newemployeeaddresstxt.Size = new System.Drawing.Size(231, 169);
            this.newemployeeaddresstxt.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(333, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 15);
            this.label9.TabIndex = 15;
            this.label9.Text = "Address";
            // 
            // newemployeePhonenotxt
            // 
            this.newemployeePhonenotxt.Location = new System.Drawing.Point(398, 39);
            this.newemployeePhonenotxt.Name = "newemployeePhonenotxt";
            this.newemployeePhonenotxt.Size = new System.Drawing.Size(231, 23);
            this.newemployeePhonenotxt.TabIndex = 7;
            this.newemployeePhonenotxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.newemployeePhonenotxt_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(333, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 15);
            this.label10.TabIndex = 13;
            this.label10.Text = "Phone No";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "DOB";
            // 
            // newemployeeDOBtxt
            // 
            this.newemployeeDOBtxt.Location = new System.Drawing.Point(119, 229);
            this.newemployeeDOBtxt.Name = "newemployeeDOBtxt";
            this.newemployeeDOBtxt.Size = new System.Drawing.Size(193, 23);
            this.newemployeeDOBtxt.TabIndex = 6;
            // 
            // newemployeeFemaleRadiobtn
            // 
            this.newemployeeFemaleRadiobtn.AutoSize = true;
            this.newemployeeFemaleRadiobtn.Location = new System.Drawing.Point(213, 194);
            this.newemployeeFemaleRadiobtn.Name = "newemployeeFemaleRadiobtn";
            this.newemployeeFemaleRadiobtn.Size = new System.Drawing.Size(64, 19);
            this.newemployeeFemaleRadiobtn.TabIndex = 5;
            this.newemployeeFemaleRadiobtn.TabStop = true;
            this.newemployeeFemaleRadiobtn.Text = "Female";
            this.newemployeeFemaleRadiobtn.UseVisualStyleBackColor = true;
            // 
            // newemployeeMaleRadiobtn
            // 
            this.newemployeeMaleRadiobtn.AutoSize = true;
            this.newemployeeMaleRadiobtn.Location = new System.Drawing.Point(136, 194);
            this.newemployeeMaleRadiobtn.Name = "newemployeeMaleRadiobtn";
            this.newemployeeMaleRadiobtn.Size = new System.Drawing.Size(53, 19);
            this.newemployeeMaleRadiobtn.TabIndex = 4;
            this.newemployeeMaleRadiobtn.TabStop = true;
            this.newemployeeMaleRadiobtn.Text = "Male";
            this.newemployeeMaleRadiobtn.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Gender";
            // 
            // newemployeeCnictxt
            // 
            this.newemployeeCnictxt.Location = new System.Drawing.Point(119, 156);
            this.newemployeeCnictxt.Name = "newemployeeCnictxt";
            this.newemployeeCnictxt.Size = new System.Drawing.Size(193, 23);
            this.newemployeeCnictxt.TabIndex = 3;
            this.newemployeeCnictxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.newemployeeCnictxt_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "CNIC";
            // 
            // newemployeeFatherNametxt
            // 
            this.newemployeeFatherNametxt.Location = new System.Drawing.Point(119, 117);
            this.newemployeeFatherNametxt.Name = "newemployeeFatherNametxt";
            this.newemployeeFatherNametxt.Size = new System.Drawing.Size(193, 23);
            this.newemployeeFatherNametxt.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Father Name";
            // 
            // newemployeeLastNametxt
            // 
            this.newemployeeLastNametxt.Location = new System.Drawing.Point(119, 75);
            this.newemployeeLastNametxt.Name = "newemployeeLastNametxt";
            this.newemployeeLastNametxt.Size = new System.Drawing.Size(193, 23);
            this.newemployeeLastNametxt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name";
            // 
            // newemployeeFirstNametxt
            // 
            this.newemployeeFirstNametxt.Location = new System.Drawing.Point(119, 36);
            this.newemployeeFirstNametxt.Name = "newemployeeFirstNametxt";
            this.newemployeeFirstNametxt.Size = new System.Drawing.Size(193, 23);
            this.newemployeeFirstNametxt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // savenewemployeebtn
            // 
            this.savenewemployeebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.savenewemployeebtn.Location = new System.Drawing.Point(1030, 374);
            this.savenewemployeebtn.Name = "savenewemployeebtn";
            this.savenewemployeebtn.Size = new System.Drawing.Size(106, 23);
            this.savenewemployeebtn.TabIndex = 25;
            this.savenewemployeebtn.Text = "Save";
            this.savenewemployeebtn.UseVisualStyleBackColor = true;
            this.savenewemployeebtn.Click += new System.EventHandler(this.savenewemployeebtn_Click);
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(128, 352);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(1008, 25);
            this.bunifuSeparator2.TabIndex = 29;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(128, 71);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(1008, 22);
            this.bunifuSeparator1.TabIndex = 27;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // addEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label12);
            this.Controls.Add(this.clearnewemployeebtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.savenewemployeebtn);
            this.Controls.Add(this.bunifuSeparator2);
            this.Controls.Add(this.bunifuSeparator1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.Name = "addEmployee";
            this.Size = new System.Drawing.Size(1264, 463);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button clearnewemployeebtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox addnewemployeestatustxt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox newemployeeJobtitletxt;
        private System.Windows.Forms.TextBox newemployeeMedicaltxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox newemployeeEducationtxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox newemployeeaddresstxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox newemployeePhonenotxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker newemployeeDOBtxt;
        private System.Windows.Forms.RadioButton newemployeeFemaleRadiobtn;
        private System.Windows.Forms.RadioButton newemployeeMaleRadiobtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox newemployeeCnictxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox newemployeeFatherNametxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox newemployeeLastNametxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox newemployeeFirstNametxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button savenewemployeebtn;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
    }
}
