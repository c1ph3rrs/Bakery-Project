namespace Bakery_System.UserControlls
{
    partial class attendanceUC
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
            this.searchEmployeetxt = new System.Windows.Forms.TextBox();
            this.attendanceDataGrid = new System.Windows.Forms.DataGridView();
            this.attendanceemployeeCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attendanceemployeefirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attendanceemployeelastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attendanceemployeeCnic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attendanceemployeeData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.attendanceClearbtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.attendancecnictxt = new System.Windows.Forms.TextBox();
            this.attendanceemployeecodetxt = new System.Windows.Forms.TextBox();
            this.attendanceSavebtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.attendancelastnametxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.attendanceAbsentrdbtn = new System.Windows.Forms.RadioButton();
            this.attendancePresentrdbtn = new System.Windows.Forms.RadioButton();
            this.attendancedatetxt = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.attendancefirstNametxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceDataGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.searchEmployeetxt);
            this.groupBox2.Location = new System.Drawing.Point(986, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(233, 44);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Employee";
            // 
            // searchEmployeetxt
            // 
            this.searchEmployeetxt.Location = new System.Drawing.Point(6, 17);
            this.searchEmployeetxt.Name = "searchEmployeetxt";
            this.searchEmployeetxt.Size = new System.Drawing.Size(221, 23);
            this.searchEmployeetxt.TabIndex = 9;
            this.searchEmployeetxt.TextChanged += new System.EventHandler(this.searchEmployeetxt_TextChanged);
            // 
            // attendanceDataGrid
            // 
            this.attendanceDataGrid.AllowUserToAddRows = false;
            this.attendanceDataGrid.AllowUserToDeleteRows = false;
            this.attendanceDataGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.attendanceDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.attendanceDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.attendanceemployeeCode,
            this.attendanceemployeefirstName,
            this.attendanceemployeelastName,
            this.attendanceemployeeCnic,
            this.attendanceemployeeData});
            this.attendanceDataGrid.GridColor = System.Drawing.SystemColors.Control;
            this.attendanceDataGrid.Location = new System.Drawing.Point(427, 169);
            this.attendanceDataGrid.Name = "attendanceDataGrid";
            this.attendanceDataGrid.ReadOnly = true;
            this.attendanceDataGrid.Size = new System.Drawing.Size(791, 234);
            this.attendanceDataGrid.TabIndex = 12;
            this.attendanceDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.attendanceDataGrid_CellClick);
            // 
            // attendanceemployeeCode
            // 
            this.attendanceemployeeCode.HeaderText = "Code";
            this.attendanceemployeeCode.Name = "attendanceemployeeCode";
            this.attendanceemployeeCode.ReadOnly = true;
            // 
            // attendanceemployeefirstName
            // 
            this.attendanceemployeefirstName.HeaderText = "First Name";
            this.attendanceemployeefirstName.Name = "attendanceemployeefirstName";
            this.attendanceemployeefirstName.ReadOnly = true;
            this.attendanceemployeefirstName.Width = 140;
            // 
            // attendanceemployeelastName
            // 
            this.attendanceemployeelastName.HeaderText = "Last Name";
            this.attendanceemployeelastName.Name = "attendanceemployeelastName";
            this.attendanceemployeelastName.ReadOnly = true;
            this.attendanceemployeelastName.Width = 140;
            // 
            // attendanceemployeeCnic
            // 
            this.attendanceemployeeCnic.HeaderText = "Cnic";
            this.attendanceemployeeCnic.Name = "attendanceemployeeCnic";
            this.attendanceemployeeCnic.ReadOnly = true;
            this.attendanceemployeeCnic.Width = 130;
            // 
            // attendanceemployeeData
            // 
            this.attendanceemployeeData.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.attendanceemployeeData.HeaderText = "Date";
            this.attendanceemployeeData.Name = "attendanceemployeeData";
            this.attendanceemployeeData.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.attendanceClearbtn);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.attendancecnictxt);
            this.groupBox1.Controls.Add(this.attendanceemployeecodetxt);
            this.groupBox1.Controls.Add(this.attendanceSavebtn);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.attendancelastnametxt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.attendanceAbsentrdbtn);
            this.groupBox1.Controls.Add(this.attendancePresentrdbtn);
            this.groupBox1.Controls.Add(this.attendancedatetxt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.attendancefirstNametxt);
            this.groupBox1.Location = new System.Drawing.Point(46, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 279);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detail";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 15);
            this.label8.TabIndex = 13;
            this.label8.Text = "Attendance";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "CNIC";
            // 
            // attendanceClearbtn
            // 
            this.attendanceClearbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.attendanceClearbtn.Location = new System.Drawing.Point(159, 250);
            this.attendanceClearbtn.Name = "attendanceClearbtn";
            this.attendanceClearbtn.Size = new System.Drawing.Size(102, 23);
            this.attendanceClearbtn.TabIndex = 7;
            this.attendanceClearbtn.Text = "Clear";
            this.attendanceClearbtn.UseVisualStyleBackColor = true;
            this.attendanceClearbtn.Click += new System.EventHandler(this.attendanceClearbtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Employee Code";
            // 
            // attendancecnictxt
            // 
            this.attendancecnictxt.Location = new System.Drawing.Point(135, 135);
            this.attendancecnictxt.Name = "attendancecnictxt";
            this.attendancecnictxt.Size = new System.Drawing.Size(203, 23);
            this.attendancecnictxt.TabIndex = 3;
            // 
            // attendanceemployeecodetxt
            // 
            this.attendanceemployeecodetxt.Location = new System.Drawing.Point(135, 36);
            this.attendanceemployeecodetxt.Name = "attendanceemployeecodetxt";
            this.attendanceemployeecodetxt.Size = new System.Drawing.Size(203, 23);
            this.attendanceemployeecodetxt.TabIndex = 0;
            // 
            // attendanceSavebtn
            // 
            this.attendanceSavebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.attendanceSavebtn.Location = new System.Drawing.Point(267, 250);
            this.attendanceSavebtn.Name = "attendanceSavebtn";
            this.attendanceSavebtn.Size = new System.Drawing.Size(102, 23);
            this.attendanceSavebtn.TabIndex = 6;
            this.attendanceSavebtn.Text = "Save";
            this.attendanceSavebtn.UseVisualStyleBackColor = true;
            this.attendanceSavebtn.Click += new System.EventHandler(this.attendanceSavebtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Date";
            // 
            // attendancelastnametxt
            // 
            this.attendancelastnametxt.Location = new System.Drawing.Point(135, 101);
            this.attendancelastnametxt.Name = "attendancelastnametxt";
            this.attendancelastnametxt.Size = new System.Drawing.Size(203, 23);
            this.attendancelastnametxt.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "last Name";
            // 
            // attendanceAbsentrdbtn
            // 
            this.attendanceAbsentrdbtn.AutoSize = true;
            this.attendanceAbsentrdbtn.Location = new System.Drawing.Point(233, 210);
            this.attendanceAbsentrdbtn.Name = "attendanceAbsentrdbtn";
            this.attendanceAbsentrdbtn.Size = new System.Drawing.Size(62, 19);
            this.attendanceAbsentrdbtn.TabIndex = 6;
            this.attendanceAbsentrdbtn.TabStop = true;
            this.attendanceAbsentrdbtn.Text = "Absent";
            this.attendanceAbsentrdbtn.UseVisualStyleBackColor = true;
            // 
            // attendancePresentrdbtn
            // 
            this.attendancePresentrdbtn.AutoSize = true;
            this.attendancePresentrdbtn.Location = new System.Drawing.Point(150, 210);
            this.attendancePresentrdbtn.Name = "attendancePresentrdbtn";
            this.attendancePresentrdbtn.Size = new System.Drawing.Size(66, 19);
            this.attendancePresentrdbtn.TabIndex = 5;
            this.attendancePresentrdbtn.TabStop = true;
            this.attendancePresentrdbtn.Text = "Present";
            this.attendancePresentrdbtn.UseVisualStyleBackColor = true;
            // 
            // attendancedatetxt
            // 
            this.attendancedatetxt.Location = new System.Drawing.Point(135, 173);
            this.attendancedatetxt.Name = "attendancedatetxt";
            this.attendancedatetxt.Size = new System.Drawing.Size(203, 23);
            this.attendancedatetxt.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "First Name";
            // 
            // attendancefirstNametxt
            // 
            this.attendancefirstNametxt.Location = new System.Drawing.Point(135, 67);
            this.attendancefirstNametxt.Name = "attendancefirstNametxt";
            this.attendancefirstNametxt.Size = new System.Drawing.Size(203, 23);
            this.attendancefirstNametxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(369, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(526, 41);
            this.label1.TabIndex = 10;
            this.label1.Text = "Add Employees Attendance ";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(46, 95);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(1172, 40);
            this.bunifuSeparator1.TabIndex = 14;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // attendanceUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.attendanceDataGrid);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuSeparator1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.Name = "attendanceUC";
            this.Size = new System.Drawing.Size(1264, 463);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceDataGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox searchEmployeetxt;
        private System.Windows.Forms.DataGridView attendanceDataGrid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button attendanceClearbtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox attendancecnictxt;
        private System.Windows.Forms.TextBox attendanceemployeecodetxt;
        private System.Windows.Forms.Button attendanceSavebtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox attendancelastnametxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton attendanceAbsentrdbtn;
        private System.Windows.Forms.RadioButton attendancePresentrdbtn;
        private System.Windows.Forms.DateTimePicker attendancedatetxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox attendancefirstNametxt;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.DataGridViewTextBoxColumn attendanceemployeeCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn attendanceemployeefirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn attendanceemployeelastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn attendanceemployeeCnic;
        private System.Windows.Forms.DataGridViewTextBoxColumn attendanceemployeeData;
    }
}
