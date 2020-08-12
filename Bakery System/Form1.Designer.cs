namespace Bakery_System
{
    partial class loginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            this.loginformdragpanel = new System.Windows.Forms.Panel();
            this.exitBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.loginformexitbtn = new System.Windows.Forms.Button();
            this.loginformloginbtn = new System.Windows.Forms.Button();
            this.loginformpasswordtxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.loginformusernametxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.loginformdragpanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginformdragpanel
            // 
            this.loginformdragpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.loginformdragpanel.Controls.Add(this.exitBtn);
            this.loginformdragpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.loginformdragpanel.Location = new System.Drawing.Point(0, 0);
            this.loginformdragpanel.Name = "loginformdragpanel";
            this.loginformdragpanel.Size = new System.Drawing.Size(1064, 38);
            this.loginformdragpanel.TabIndex = 10;
            // 
            // exitBtn
            // 
            this.exitBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Georgia", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Image = ((System.Drawing.Image)(resources.GetObject("exitBtn.Image")));
            this.exitBtn.Location = new System.Drawing.Point(1000, 0);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(64, 38);
            this.exitBtn.TabIndex = 2;
            this.exitBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(618, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(361, 56);
            this.label3.TabIndex = 18;
            this.label3.Text = "LOGIN HERE";
            // 
            // loginformexitbtn
            // 
            this.loginformexitbtn.BackColor = System.Drawing.SystemColors.Control;
            this.loginformexitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loginformexitbtn.Font = new System.Drawing.Font("Corbel", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginformexitbtn.Location = new System.Drawing.Point(131, 117);
            this.loginformexitbtn.Name = "loginformexitbtn";
            this.loginformexitbtn.Size = new System.Drawing.Size(85, 27);
            this.loginformexitbtn.TabIndex = 16;
            this.loginformexitbtn.Text = "Exit";
            this.loginformexitbtn.UseVisualStyleBackColor = false;
            this.loginformexitbtn.Click += new System.EventHandler(this.loginformexitbtn_Click);
            // 
            // loginformloginbtn
            // 
            this.loginformloginbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loginformloginbtn.Font = new System.Drawing.Font("Corbel", 11F, System.Drawing.FontStyle.Bold);
            this.loginformloginbtn.Location = new System.Drawing.Point(220, 117);
            this.loginformloginbtn.Name = "loginformloginbtn";
            this.loginformloginbtn.Size = new System.Drawing.Size(85, 27);
            this.loginformloginbtn.TabIndex = 14;
            this.loginformloginbtn.Text = "Login";
            this.loginformloginbtn.UseVisualStyleBackColor = true;
            this.loginformloginbtn.Click += new System.EventHandler(this.loginformloginbtn_Click);
            // 
            // loginformpasswordtxt
            // 
            this.loginformpasswordtxt.Location = new System.Drawing.Point(131, 76);
            this.loginformpasswordtxt.Name = "loginformpasswordtxt";
            this.loginformpasswordtxt.Size = new System.Drawing.Size(174, 20);
            this.loginformpasswordtxt.TabIndex = 13;
            this.loginformpasswordtxt.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "Password";
            // 
            // loginformusernametxt
            // 
            this.loginformusernametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.loginformusernametxt.Location = new System.Drawing.Point(131, 41);
            this.loginformusernametxt.Name = "loginformusernametxt";
            this.loginformusernametxt.Size = new System.Drawing.Size(174, 20);
            this.loginformusernametxt.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "User Name";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 427);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1064, 38);
            this.panel2.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 17.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(286, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(299, 27);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ibrahim Akram Mughal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(277, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Design && Developed by :-  ";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 35;
            this.bunifuElipse1.TargetControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.loginformusernametxt);
            this.groupBox1.Controls.Add(this.loginformloginbtn);
            this.groupBox1.Controls.Add(this.loginformexitbtn);
            this.groupBox1.Controls.Add(this.loginformpasswordtxt);
            this.groupBox1.Location = new System.Drawing.Point(641, 178);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 163);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 56.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(39, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(273, 86);
            this.label6.TabIndex = 21;
            this.label6.Text = "Rabia";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 50F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(180, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(405, 77);
            this.label7.TabIndex = 22;
            this.label7.Text = "Enterprise";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Georgia", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(204, 352);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(201, 31);
            this.label8.TabIndex = 23;
            this.label8.Text = "03338405757";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Georgia", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(23, 352);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(175, 31);
            this.label9.TabIndex = 24;
            this.label9.Text = "Phone No :-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Georgia", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(425, 352);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(199, 31);
            this.label10.TabIndex = 25;
            this.label10.Text = "03454288157";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Georgia", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(396, 355);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 31);
            this.label11.TabIndex = 26;
            this.label11.Text = ",";
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 465);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.loginformdragpanel);
            this.Controls.Add(this.label9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "loginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.loginForm_Load);
            this.loginformdragpanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel loginformdragpanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button loginformexitbtn;
        private System.Windows.Forms.Button loginformloginbtn;
        private System.Windows.Forms.TextBox loginformpasswordtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox loginformusernametxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
    }
}

