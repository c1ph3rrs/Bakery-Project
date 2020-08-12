using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Bakery_System
{
    public partial class loginForm : Form
    {
       public static SqlConnection conn;
       string connectionString = ConfigurationManager.ConnectionStrings["Bakery_System.Properties.Settings.Setting"].ToString();

        public static string username;
        public static string received_username
        {
            get { return username; }
            set { username = value; }
        }

        public loginForm()
        {
            InitializeComponent();
            try
            {
                conn = new SqlConnection(connectionString);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void loginformloginbtn_Click(object sender, EventArgs e)
        {
            if (loginformusernametxt.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter the Username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                loginformusernametxt.Focus();
            }
            else if (loginformpasswordtxt.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter the Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                loginformpasswordtxt.Focus();
            }
            else
            {
                conn.Open();
                string query = "SELECT user_name, user_password, user_frontname from user_login WHERE user_name = @user_name AND user_password = @user_password";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@user_name", loginformusernametxt.Text);
                    cmd.Parameters.AddWithValue("@user_password", loginformpasswordtxt.Text);
                    //cmd.ExecuteNonQuery();
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        received_username = loginformusernametxt.Text;
                        homePage hmpg = new homePage();
                        hmpg.Show();
                        hmpg.WindowState = FormWindowState.Maximized;
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Make Sure that You Enter a valid Username and Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        loginformusernametxt.Text = "";
                        loginformpasswordtxt.Text = "";
                        loginformpasswordtxt.Focus();
                        loginformusernametxt.Focus();
                    }
                }
                conn.Close();
            }
        }

        private void loginformexitbtn_Click(object sender, EventArgs e)
        {
            DialogResult dlgrst = MessageBox.Show("Are You Sure you want to Exit the Application", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dlgrst == DialogResult.Yes)
            {
                Application.Exit();
            }
            else { }
        }

       

        private void loginForm_Load(object sender, EventArgs e)
        {
            loginformusernametxt.Focus();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            DialogResult dlgrst = MessageBox.Show("Are You Sure you want to Exit the Application", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dlgrst == DialogResult.Yes)
            {
                Application.Exit();
            }
            else { }
        }
    }
}
