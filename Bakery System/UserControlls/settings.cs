using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Bakery_System.UserControlls
{
    public partial class settings : UserControl
    {
        int checker = 0;
        public settings()
        {
            InitializeComponent();
            usernametxt.Text = loginForm.received_username;
            addanotherUserpanel.Visible = false;
            ownSettingsPanel.Visible = false;
            usersloginPanels.Visible = false;
        }

        private void settings_Load(object sender, EventArgs e)
        {
            settings set = sender as settings;
            ownSettingsPanel.Parent = set;
            addanotherUserpanel.Parent = set;
            usersloginPanels.Parent = set;


            ownSettingsPanel.Left = 250;
            ownSettingsPanel.Top = 40;

            addanotherUserpanel.Left = 250;
            addanotherUserpanel.Top = 40;

            usersloginPanels.Left = 250;
            usersloginPanels.Top = 40;
        }

        private void settingOwnsettingsbtn_Click(object sender, EventArgs e)
        {
            if (checker == 0)
            {
                settingsSlider.ShowSync(ownSettingsPanel);
                checker = 1;
            }
            else if (checker == 2)
            {
                settingsSlider.HideSync(addanotherUserpanel);
                settingsSlider.ShowSync(ownSettingsPanel);
                checker = 1;
            }else if (checker == 3)
            {
                settingsSlider.HideSync(usersloginPanels);
                settingsSlider.ShowSync(ownSettingsPanel);
                checker = 1;
            }
        }

        private void settingsaddanotherUserbtn_Click(object sender, EventArgs e)
        {
            if (checker == 0)
            {
                settingsSlider.ShowSync(addanotherUserpanel);
                checker = 2;
            }
            else if (checker == 1)
            {
                settingsSlider.HideSync(ownSettingsPanel);
                settingsSlider.ShowSync(addanotherUserpanel);
                checker = 2;
            }else if (checker == 3)
            {
                settingsSlider.HideSync(usersloginPanels);
                settingsSlider.ShowSync(addanotherUserpanel);
                checker = 2;
            }
            displayForCreateUser();
        }

        private void saveChangesBtn_Click(object sender, EventArgs e)
        {
            if (passwordtxt.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter the Password First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else
            {
                if (passwordtxt.Text.Trim() != cnfrmpasswordtxt.Text.Trim())
                {
                    MessageBox.Show("Password Not Match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    passwordtxt.Text = "";
                    cnfrmpasswordtxt.Text = "";
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Are you Sure you want to change the Password", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if(dr == DialogResult.Yes)
                    {
                        string query = "UPDATE [user_login] SET[user_password] = '" + passwordtxt.Text + "' WHERE user_name = '" + usernametxt.Text + "'";
                        loginForm.conn.Open();
                        SqlCommand cmd = new SqlCommand(query, loginForm.conn);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Settings Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        passwordtxt.Text = "";
                        cnfrmpasswordtxt.Text = "";
                        loginForm.conn.Close();
                    }
                }
            }
        }

        void displayForCreateUser()
        {
            string query = "SELECT emp_id, emp_firstName, emp_lastName, emp_job FROM [mart_employees] WHERE (emp_job LIKE 'Cashier') OR (emp_job LIKE 'Admin')";
            loginForm.conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query, loginForm.conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            showUsersforCreategridview.Rows.Clear();
            foreach (DataRow rows in dt.Rows)
            {
                int n = showUsersforCreategridview.Rows.Add();
                showUsersforCreategridview.Rows[n].Cells["showUserCreateCodegridview"].Value = rows["emp_id"].ToString();
                showUsersforCreategridview.Rows[n].Cells["showUserCreateNamegridview"].Value = rows["emp_firstName"].ToString() + " " + rows["emp_lastName"].ToString();
                showUsersforCreategridview.Rows[n].Cells["showUserCreateCategorygridview"].Value = rows["emp_job"].ToString();
            }
            loginForm.conn.Close();
        }
        private void createUserforbtn_Click(object sender, EventArgs e)
        {
            if (createUseruserNametxt.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter the Unique Username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                createUseruserNametxt.Focus();
            }
            else if (createUserPasswordtxt.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter the Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                createUserPasswordtxt.Focus();
            }
            else if (createUserfrontNametxt.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter the Front Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                createUserfrontNametxt.Focus();
            }
            else if (createUsercategorytxt.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter the Category First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                createUsercategorytxt.Focus();
            }
            else
            {
                loginForm.conn.Open();
                string query = "INSERT INTO [user_login](user_name, user_password, user_frontname, user_category, user_enrollid) " +
                    "VALUES(@user_name, @user_password, @user_frontname, @user_category, @user_enrollid)";
                SqlCommand cmd = new SqlCommand(query, loginForm.conn);
                cmd.Parameters.AddWithValue("@user_name", createUseruserNametxt.Text);
                cmd.Parameters.AddWithValue("@user_password", createUserPasswordtxt.Text);
                cmd.Parameters.AddWithValue("@user_frontname", createUserfrontNametxt.Text);
                cmd.Parameters.AddWithValue("@user_category", createUsercategorytxt.Text);
                cmd.Parameters.AddWithValue("@user_enrollid", createUserCodetxt.Text);
                cmd.ExecuteNonQuery();
                loginForm.conn.Close();
                MessageBox.Show("User Added Sucessfully", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                createUseruserNametxt.Text = "";
                createUserPasswordtxt.Text = "";
                createUserfrontNametxt.Text = "";
                createUsercategorytxt.Text = "";
                createUserCodetxt.Text = "";
            }
        }

        private void searchUserforCreatetxt_TextChanged(object sender, EventArgs e)
        {
            string query = "SELECT emp_id, emp_firstName, emp_lastName, emp_job FROM [mart_employees] WHERE (emp_id LIKE '%" + searchUserforCreatetxt .Text + "%' OR emp_firstName LIKE '%" + searchUserforCreatetxt.Text + "%') AND ((emp_job LIKE 'Cashier') OR (emp_job LIKE 'Admin'))";
            loginForm.conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query, loginForm.conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            showUsersforCreategridview.Rows.Clear();
            foreach (DataRow rows in dt.Rows)
            {
                int n = showUsersforCreategridview.Rows.Add();
                showUsersforCreategridview.Rows[n].Cells["showUserCreateCodegridview"].Value = rows["emp_id"].ToString();
                showUsersforCreategridview.Rows[n].Cells["showUserCreateNamegridview"].Value = rows["emp_firstName"].ToString() + " " + rows["emp_lastName"].ToString();
                showUsersforCreategridview.Rows[n].Cells["showUserCreateCategorygridview"].Value = rows["emp_job"].ToString();
            }
            loginForm.conn.Close();
        }

        private void showUsersforCreategridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedrow = showUsersforCreategridview.Rows[index];
            createUserCodetxt.Text = selectedrow.Cells["showUserCreateCodegridview"].Value.ToString();
            createUserfrontNametxt.Text = selectedrow.Cells["showUserCreateNamegridview"].Value.ToString();
            createUsercategorytxt.Text = selectedrow.Cells["showUserCreateCategorygridview"].Value.ToString();
        }

        private void clearUserRecordbtn_Click(object sender, EventArgs e)
        {
            createUseruserNametxt.Text = "";
            createUserPasswordtxt.Text = "";
            createUserfrontNametxt.Text = "";
            createUsercategorytxt.Text = "";
            createUserCodetxt.Text = "";
        }

        void OurUsers()
        {
            string query = "SELECT user_enrollid, user_name, user_password, user_frontname, user_category FROM [user_login]";
            loginForm.conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query, loginForm.conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            UsersloginInfosdatagrid.Rows.Clear();
            foreach (DataRow rows in dt.Rows)
            {
                int n = UsersloginInfosdatagrid.Rows.Add();
                UsersloginInfosdatagrid.Rows[n].Cells["updateuseremployeeCodegridView"].Value = rows["user_enrollid"].ToString();
                UsersloginInfosdatagrid.Rows[n].Cells["updateUserFrontNamegridview"].Value = rows["user_frontname"].ToString();
                UsersloginInfosdatagrid.Rows[n].Cells["updateUserNamegridview"].Value = rows["user_name"].ToString();
                UsersloginInfosdatagrid.Rows[n].Cells["updateUserPasswordgridview"].Value = rows["user_password"].ToString();
                UsersloginInfosdatagrid.Rows[n].Cells["updateUserCategorygridview"].Value = rows["user_category"].ToString();
            }
            loginForm.conn.Close();
        }

        private void settingsShowAllUsersbtn_Click(object sender, EventArgs e)
        {
            if (checker == 1)
            {
                settingsSlider.HideSync(ownSettingsPanel);
                settingsSlider.ShowSync(usersloginPanels);
                checker = 3;
            }
            else if (checker == 2)
            {
                settingsSlider.HideSync(addanotherUserpanel);
                settingsSlider.ShowSync(usersloginPanels);
                checker = 3;
            }
            else
            {
                settingsSlider.ShowSync(usersloginPanels);
                checker = 3;
            }
            OurUsers();
        }

        private void UsersloginInfosdatagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedrow = UsersloginInfosdatagrid.Rows[index];
            updateuseremployeeCodetxt.Text = selectedrow.Cells["updateuseremployeeCodegridView"].Value.ToString();
            updateUserFrontNametxt.Text = selectedrow.Cells["updateUserFrontNamegridview"].Value.ToString();
            updateUserNametxt.Text = selectedrow.Cells["updateUserNamegridview"].Value.ToString();
            updateUserpasswordtxt.Text = selectedrow.Cells["updateUserPasswordgridview"].Value.ToString();
            updateuserCategorytxt.Text = selectedrow.Cells["updateUserCategorygridview"].Value.ToString();
        }

        private void updateuserloginBtn_Click(object sender, EventArgs e)
        {
            string query = "UPDATE [user_login] SET user_name = @user_name, user_password = @user_password WHERE user_enrollid = @user_enrollid";
            loginForm.conn.Open();
            SqlCommand cmd = new SqlCommand(query, loginForm.conn);
            cmd.Parameters.AddWithValue("@user_name", updateUserNametxt.Text);
            cmd.Parameters.AddWithValue("@user_password", updateUserpasswordtxt.Text);
            cmd.Parameters.AddWithValue("@user_enrollid", updateuseremployeeCodetxt.Text);
            cmd.ExecuteNonQuery();
            loginForm.conn.Close();
            MessageBox.Show("User Updated Sucessfully", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
            updateuseremployeeCodetxt.Text = "";
            updateUserFrontNametxt.Text = "";
            updateUserNametxt.Text = "";
            updateUserpasswordtxt.Text = "";
            updateuserCategorytxt.Text = "";
        }

        private void clearUserloginBtn_Click(object sender, EventArgs e)
        {
            updateuseremployeeCodetxt.Text = "";
            updateUserFrontNametxt.Text = "";
            updateUserNametxt.Text = "";
            updateUserpasswordtxt.Text = "";
            updateuserCategorytxt.Text = "";
        }

        private void removeUserloginbtn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are You Sure you want to delete this Selected User", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                string query = "DELETE [user_login] WHERE user_enrollid = @user_enrollid";
                loginForm.conn.Open();
                SqlCommand cmd = new SqlCommand(query, loginForm.conn);
                cmd.Parameters.AddWithValue("@user_enrollid", updateuseremployeeCodetxt.Text);
                cmd.ExecuteNonQuery();
                loginForm.conn.Close();
            }else { }
            
        }

        private void updatesearchUsertxt_TextChanged(object sender, EventArgs e)
        {
            string query = "SELECT user_enrollid, user_name, user_password, user_frontname, user_category FROM [user_login] WHERE user_frontname LIKE '%" + updatesearchUsertxt.Text + "%' OR user_enrollid LIKE '%" + updatesearchUsertxt.Text + "%'";
            loginForm.conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query, loginForm.conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            UsersloginInfosdatagrid.Rows.Clear();
            foreach (DataRow rows in dt.Rows)
            {
                int n = UsersloginInfosdatagrid.Rows.Add();
                UsersloginInfosdatagrid.Rows[n].Cells["updateuseremployeeCodegridView"].Value = rows["user_enrollid"].ToString();
                UsersloginInfosdatagrid.Rows[n].Cells["updateUserFrontNamegridview"].Value = rows["user_frontname"].ToString();
                UsersloginInfosdatagrid.Rows[n].Cells["updateUserNamegridview"].Value = rows["user_name"].ToString();
                UsersloginInfosdatagrid.Rows[n].Cells["updateUserPasswordgridview"].Value = rows["user_password"].ToString();
                UsersloginInfosdatagrid.Rows[n].Cells["updateUserCategorygridview"].Value = rows["user_category"].ToString();
            }
            loginForm.conn.Close();
        }
    }
}
