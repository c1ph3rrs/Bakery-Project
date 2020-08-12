namespace Bakery_System.UserControlls
{
    partial class EmployeesInfo
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.searchEmployeetxt = new System.Windows.Forms.TextBox();
            this.employeeInfoDataGrid = new System.Windows.Forms.DataGridView();
            this.employeegridviewcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeegridviewfirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeegridviewlastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeegridviewfather = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeegridviewcnic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeegridviewgender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeegridviewdob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeegridviewaddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeegridviewphone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeegridvieweducation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeegridviewjob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeegridviewstatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeegridviewmedical = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.employeeinfolastNametxt = new System.Windows.Forms.TextBox();
            this.employeeSalarytxt = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.deleteEmployeeInfobtn = new System.Windows.Forms.Button();
            this.updateEmployeeInfobtn = new System.Windows.Forms.Button();
            this.employeeCodetxt = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.employeeJobStatustxt = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.employeeJobtitletxt = new System.Windows.Forms.ComboBox();
            this.employeeMedicaltxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.employeeEducationtxt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.employeeaddresstxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.employeePhonenotxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.employeeDOBtxt = new System.Windows.Forms.DateTimePicker();
            this.employeeFemaleRadiobtn = new System.Windows.Forms.RadioButton();
            this.employeeMaleRadiobtn = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.employeeCnictxt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.employeeFathertxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.employeefirstNametxt = new System.Windows.Forms.TextBox();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeInfoDataGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.searchEmployeetxt);
            this.groupBox2.Controls.Add(this.employeeInfoDataGrid);
            this.groupBox2.Location = new System.Drawing.Point(657, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(591, 304);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Employees";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Search Employee";
            // 
            // searchEmployeetxt
            // 
            this.searchEmployeetxt.Location = new System.Drawing.Point(384, 16);
            this.searchEmployeetxt.Name = "searchEmployeetxt";
            this.searchEmployeetxt.Size = new System.Drawing.Size(201, 23);
            this.searchEmployeetxt.TabIndex = 18;
            this.searchEmployeetxt.TextChanged += new System.EventHandler(this.searchEmployeetxt_TextChanged);
            // 
            // employeeInfoDataGrid
            // 
            this.employeeInfoDataGrid.AllowUserToAddRows = false;
            this.employeeInfoDataGrid.AllowUserToDeleteRows = false;
            this.employeeInfoDataGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.employeeInfoDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeInfoDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeegridviewcode,
            this.employeegridviewfirstName,
            this.employeegridviewlastName,
            this.employeegridviewfather,
            this.employeegridviewcnic,
            this.employeegridviewgender,
            this.employeegridviewdob,
            this.employeegridviewaddress,
            this.employeegridviewphone,
            this.employeegridvieweducation,
            this.employeegridviewjob,
            this.employeegridviewstatus,
            this.employeegridviewmedical});
            this.employeeInfoDataGrid.GridColor = System.Drawing.SystemColors.Control;
            this.employeeInfoDataGrid.Location = new System.Drawing.Point(6, 42);
            this.employeeInfoDataGrid.Name = "employeeInfoDataGrid";
            this.employeeInfoDataGrid.ReadOnly = true;
            this.employeeInfoDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.employeeInfoDataGrid.Size = new System.Drawing.Size(579, 256);
            this.employeeInfoDataGrid.TabIndex = 0;
            this.employeeInfoDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employeeInfoDataGrid_CellClick);
            // 
            // employeegridviewcode
            // 
            this.employeegridviewcode.HeaderText = "Code";
            this.employeegridviewcode.Name = "employeegridviewcode";
            this.employeegridviewcode.ReadOnly = true;
            // 
            // employeegridviewfirstName
            // 
            this.employeegridviewfirstName.HeaderText = "First";
            this.employeegridviewfirstName.Name = "employeegridviewfirstName";
            this.employeegridviewfirstName.ReadOnly = true;
            // 
            // employeegridviewlastName
            // 
            this.employeegridviewlastName.HeaderText = "Last";
            this.employeegridviewlastName.Name = "employeegridviewlastName";
            this.employeegridviewlastName.ReadOnly = true;
            // 
            // employeegridviewfather
            // 
            this.employeegridviewfather.HeaderText = "Father";
            this.employeegridviewfather.Name = "employeegridviewfather";
            this.employeegridviewfather.ReadOnly = true;
            // 
            // employeegridviewcnic
            // 
            this.employeegridviewcnic.HeaderText = "CNIC";
            this.employeegridviewcnic.Name = "employeegridviewcnic";
            this.employeegridviewcnic.ReadOnly = true;
            // 
            // employeegridviewgender
            // 
            this.employeegridviewgender.HeaderText = "Gender";
            this.employeegridviewgender.Name = "employeegridviewgender";
            this.employeegridviewgender.ReadOnly = true;
            // 
            // employeegridviewdob
            // 
            this.employeegridviewdob.HeaderText = "DOB";
            this.employeegridviewdob.Name = "employeegridviewdob";
            this.employeegridviewdob.ReadOnly = true;
            // 
            // employeegridviewaddress
            // 
            this.employeegridviewaddress.HeaderText = "Address";
            this.employeegridviewaddress.Name = "employeegridviewaddress";
            this.employeegridviewaddress.ReadOnly = true;
            // 
            // employeegridviewphone
            // 
            this.employeegridviewphone.HeaderText = "Phone";
            this.employeegridviewphone.Name = "employeegridviewphone";
            this.employeegridviewphone.ReadOnly = true;
            // 
            // employeegridvieweducation
            // 
            this.employeegridvieweducation.HeaderText = "Education";
            this.employeegridvieweducation.Name = "employeegridvieweducation";
            this.employeegridvieweducation.ReadOnly = true;
            // 
            // employeegridviewjob
            // 
            this.employeegridviewjob.HeaderText = "Job";
            this.employeegridviewjob.Name = "employeegridviewjob";
            this.employeegridviewjob.ReadOnly = true;
            // 
            // employeegridviewstatus
            // 
            this.employeegridviewstatus.HeaderText = "Status";
            this.employeegridviewstatus.Name = "employeegridviewstatus";
            this.employeegridviewstatus.ReadOnly = true;
            // 
            // employeegridviewmedical
            // 
            this.employeegridviewmedical.HeaderText = "Medical";
            this.employeegridviewmedical.Name = "employeegridviewmedical";
            this.employeegridviewmedical.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.employeeinfolastNametxt);
            this.groupBox1.Controls.Add(this.employeeSalarytxt);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.employeeCodetxt);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.employeeJobStatustxt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.employeeJobtitletxt);
            this.groupBox1.Controls.Add(this.employeeMedicaltxt);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.employeeEducationtxt);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.employeeaddresstxt);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.employeePhonenotxt);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.employeeDOBtxt);
            this.groupBox1.Controls.Add(this.employeeFemaleRadiobtn);
            this.groupBox1.Controls.Add(this.employeeMaleRadiobtn);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.employeeCnictxt);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.employeeFathertxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.employeefirstNametxt);
            this.groupBox1.Location = new System.Drawing.Point(28, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(623, 304);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee Info";
            // 
            // employeeinfolastNametxt
            // 
            this.employeeinfolastNametxt.Location = new System.Drawing.Point(162, 62);
            this.employeeinfolastNametxt.Name = "employeeinfolastNametxt";
            this.employeeinfolastNametxt.Size = new System.Drawing.Size(116, 23);
            this.employeeinfolastNametxt.TabIndex = 2;
            // 
            // employeeSalarytxt
            // 
            this.employeeSalarytxt.Location = new System.Drawing.Point(383, 155);
            this.employeeSalarytxt.Name = "employeeSalarytxt";
            this.employeeSalarytxt.ReadOnly = true;
            this.employeeSalarytxt.Size = new System.Drawing.Size(220, 23);
            this.employeeSalarytxt.TabIndex = 13;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(316, 158);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 15);
            this.label15.TabIndex = 54;
            this.label15.Text = "Salary";
            // 
            // deleteEmployeeInfobtn
            // 
            this.deleteEmployeeInfobtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteEmployeeInfobtn.Location = new System.Drawing.Point(411, 422);
            this.deleteEmployeeInfobtn.Name = "deleteEmployeeInfobtn";
            this.deleteEmployeeInfobtn.Size = new System.Drawing.Size(102, 23);
            this.deleteEmployeeInfobtn.TabIndex = 17;
            this.deleteEmployeeInfobtn.Text = "Delete";
            this.deleteEmployeeInfobtn.UseVisualStyleBackColor = true;
            this.deleteEmployeeInfobtn.Click += new System.EventHandler(this.deleteEmployeeInfobtn_Click);
            // 
            // updateEmployeeInfobtn
            // 
            this.updateEmployeeInfobtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updateEmployeeInfobtn.Location = new System.Drawing.Point(529, 422);
            this.updateEmployeeInfobtn.Name = "updateEmployeeInfobtn";
            this.updateEmployeeInfobtn.Size = new System.Drawing.Size(102, 23);
            this.updateEmployeeInfobtn.TabIndex = 16;
            this.updateEmployeeInfobtn.Text = "Update";
            this.updateEmployeeInfobtn.UseVisualStyleBackColor = true;
            this.updateEmployeeInfobtn.Click += new System.EventHandler(this.updateEmployeeInfobtn_Click);
            // 
            // employeeCodetxt
            // 
            this.employeeCodetxt.Location = new System.Drawing.Point(60, 30);
            this.employeeCodetxt.Name = "employeeCodetxt";
            this.employeeCodetxt.Size = new System.Drawing.Size(218, 23);
            this.employeeCodetxt.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 33);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 15);
            this.label14.TabIndex = 51;
            this.label14.Text = "Code";
            // 
            // employeeJobStatustxt
            // 
            this.employeeJobStatustxt.FormattingEnabled = true;
            this.employeeJobStatustxt.Items.AddRange(new object[] {
            "Active",
            "Left"});
            this.employeeJobStatustxt.Location = new System.Drawing.Point(383, 123);
            this.employeeJobStatustxt.Name = "employeeJobStatustxt";
            this.employeeJobStatustxt.Size = new System.Drawing.Size(220, 23);
            this.employeeJobStatustxt.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(316, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 49;
            this.label4.Text = "Status";
            // 
            // employeeJobtitletxt
            // 
            this.employeeJobtitletxt.FormattingEnabled = true;
            this.employeeJobtitletxt.Items.AddRange(new object[] {
            "Admin",
            "Cashier",
            "Employee"});
            this.employeeJobtitletxt.Location = new System.Drawing.Point(383, 93);
            this.employeeJobtitletxt.Name = "employeeJobtitletxt";
            this.employeeJobtitletxt.Size = new System.Drawing.Size(220, 23);
            this.employeeJobtitletxt.TabIndex = 11;
            // 
            // employeeMedicaltxt
            // 
            this.employeeMedicaltxt.Location = new System.Drawing.Point(383, 185);
            this.employeeMedicaltxt.Multiline = true;
            this.employeeMedicaltxt.Name = "employeeMedicaltxt";
            this.employeeMedicaltxt.Size = new System.Drawing.Size(220, 102);
            this.employeeMedicaltxt.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(316, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 47;
            this.label7.Text = "Medical";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(316, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 15);
            this.label8.TabIndex = 46;
            this.label8.Text = "Job";
            // 
            // employeeEducationtxt
            // 
            this.employeeEducationtxt.Location = new System.Drawing.Point(383, 57);
            this.employeeEducationtxt.Name = "employeeEducationtxt";
            this.employeeEducationtxt.Size = new System.Drawing.Size(220, 23);
            this.employeeEducationtxt.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(316, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 15);
            this.label11.TabIndex = 45;
            this.label11.Text = "Education";
            // 
            // employeeaddresstxt
            // 
            this.employeeaddresstxt.Location = new System.Drawing.Point(60, 216);
            this.employeeaddresstxt.Multiline = true;
            this.employeeaddresstxt.Name = "employeeaddresstxt";
            this.employeeaddresstxt.Size = new System.Drawing.Size(218, 76);
            this.employeeaddresstxt.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 219);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 15);
            this.label9.TabIndex = 44;
            this.label9.Text = "Address";
            // 
            // employeePhonenotxt
            // 
            this.employeePhonenotxt.Location = new System.Drawing.Point(383, 25);
            this.employeePhonenotxt.Name = "employeePhonenotxt";
            this.employeePhonenotxt.Size = new System.Drawing.Size(220, 23);
            this.employeePhonenotxt.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(316, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 15);
            this.label10.TabIndex = 43;
            this.label10.Text = "Phone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 15);
            this.label6.TabIndex = 42;
            this.label6.Text = "DOB";
            // 
            // employeeDOBtxt
            // 
            this.employeeDOBtxt.Location = new System.Drawing.Point(60, 187);
            this.employeeDOBtxt.Name = "employeeDOBtxt";
            this.employeeDOBtxt.Size = new System.Drawing.Size(218, 23);
            this.employeeDOBtxt.TabIndex = 7;
            // 
            // employeeFemaleRadiobtn
            // 
            this.employeeFemaleRadiobtn.AutoSize = true;
            this.employeeFemaleRadiobtn.Location = new System.Drawing.Point(159, 160);
            this.employeeFemaleRadiobtn.Name = "employeeFemaleRadiobtn";
            this.employeeFemaleRadiobtn.Size = new System.Drawing.Size(64, 19);
            this.employeeFemaleRadiobtn.TabIndex = 6;
            this.employeeFemaleRadiobtn.TabStop = true;
            this.employeeFemaleRadiobtn.Text = "Female";
            this.employeeFemaleRadiobtn.UseVisualStyleBackColor = true;
            // 
            // employeeMaleRadiobtn
            // 
            this.employeeMaleRadiobtn.AutoSize = true;
            this.employeeMaleRadiobtn.Location = new System.Drawing.Point(86, 160);
            this.employeeMaleRadiobtn.Name = "employeeMaleRadiobtn";
            this.employeeMaleRadiobtn.Size = new System.Drawing.Size(53, 19);
            this.employeeMaleRadiobtn.TabIndex = 5;
            this.employeeMaleRadiobtn.TabStop = true;
            this.employeeMaleRadiobtn.Text = "Male";
            this.employeeMaleRadiobtn.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 15);
            this.label5.TabIndex = 37;
            this.label5.Text = "Gender";
            // 
            // employeeCnictxt
            // 
            this.employeeCnictxt.Location = new System.Drawing.Point(60, 128);
            this.employeeCnictxt.Name = "employeeCnictxt";
            this.employeeCnictxt.Size = new System.Drawing.Size(218, 23);
            this.employeeCnictxt.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 132);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 15);
            this.label12.TabIndex = 34;
            this.label12.Text = "CNIC";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 101);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 15);
            this.label13.TabIndex = 31;
            this.label13.Text = "Father";
            // 
            // employeeFathertxt
            // 
            this.employeeFathertxt.Location = new System.Drawing.Point(60, 98);
            this.employeeFathertxt.Name = "employeeFathertxt";
            this.employeeFathertxt.Size = new System.Drawing.Size(218, 23);
            this.employeeFathertxt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // employeefirstNametxt
            // 
            this.employeefirstNametxt.Location = new System.Drawing.Point(60, 62);
            this.employeefirstNametxt.Name = "employeefirstNametxt";
            this.employeefirstNametxt.Size = new System.Drawing.Size(96, 23);
            this.employeefirstNametxt.TabIndex = 1;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(28, 90);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(1220, 27);
            this.bunifuSeparator1.TabIndex = 7;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(478, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 41);
            this.label1.TabIndex = 6;
            this.label1.Text = "Employee\'s Info";
            // 
            // EmployeesInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.updateEmployeeInfobtn);
            this.Controls.Add(this.deleteEmployeeInfobtn);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.Name = "EmployeesInfo";
            this.Size = new System.Drawing.Size(1264, 463);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeInfoDataGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox searchEmployeetxt;
        private System.Windows.Forms.DataGridView employeeInfoDataGrid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox employeeinfolastNametxt;
        private System.Windows.Forms.TextBox employeeSalarytxt;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button deleteEmployeeInfobtn;
        private System.Windows.Forms.Button updateEmployeeInfobtn;
        private System.Windows.Forms.TextBox employeeCodetxt;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox employeeJobStatustxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox employeeJobtitletxt;
        private System.Windows.Forms.TextBox employeeMedicaltxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox employeeEducationtxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox employeeaddresstxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox employeePhonenotxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker employeeDOBtxt;
        private System.Windows.Forms.RadioButton employeeFemaleRadiobtn;
        private System.Windows.Forms.RadioButton employeeMaleRadiobtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox employeeCnictxt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox employeeFathertxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox employeefirstNametxt;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeegridviewcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeegridviewfirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeegridviewlastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeegridviewfather;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeegridviewcnic;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeegridviewgender;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeegridviewdob;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeegridviewaddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeegridviewphone;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeegridvieweducation;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeegridviewjob;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeegridviewstatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeegridviewmedical;
    }
}
