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
    public partial class addEmployee : UserControl
    {
        string filename;
        public addEmployee()
        {
            InitializeComponent();
        }

        private void savenewemployeebtn_Click(object sender, EventArgs e)
        {
            if (newemployeeFirstNametxt.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter The First Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                newemployeeFirstNametxt.Focus();
            }
            else if (newemployeeLastNametxt.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter The Last Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                newemployeeLastNametxt.Focus();
            }
            else if (newemployeeFatherNametxt.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter The Father Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                newemployeeFatherNametxt.Focus();
            }
            else if (newemployeeCnictxt.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter The Cnic", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                newemployeeCnictxt.Focus();
            }
            else if (newemployeePhonenotxt.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter The Phone No", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                newemployeePhonenotxt.Focus();
            }
            else if (newemployeeaddresstxt.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter The House Address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                newemployeeaddresstxt.Focus();
            }
            else if (newemployeeEducationtxt.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter The Employee Education", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                newemployeeEducationtxt.Focus();
            }
            else if (newemployeeJobtitletxt.Text.Trim() == "")
            {
                MessageBox.Show("Please Choose the Job Title", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                newemployeeJobtitletxt.Focus();
            }
            else if (newemployeeMedicaltxt.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter the Medical Report Of Employee", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                newemployeeMedicaltxt.Focus();
            }
            else
            {
                string genderEmployee;

                if (newemployeeMaleRadiobtn.Checked)
                    genderEmployee = "Male";
                else if (newemployeeFemaleRadiobtn.Checked)
                    genderEmployee = "Female";
                else
                    genderEmployee = "Not Selected";



                string query = "INSERT INTO mart_employees(emp_firstName, emp_lastName, emp_father, emp_cnic, emp_Gender, emp_dob, emp_phone,emp_address, emp_education, " +
                    "emp_job, emp_status, emp_medical) " +
                    "VALUES(@emp_firstName, @emp_lastName, @emp_father, @emp_cnic, @emp_Gender, @emp_dob, @emp_phone, @emp_address, @emp_education, @emp_job, " +
                    "@emp_status, @emp_medical)";

                loginForm.conn.Open();
                SqlCommand cmd = new SqlCommand(query, loginForm.conn);
                cmd.Parameters.AddWithValue("@emp_firstName", newemployeeFirstNametxt.Text);
                cmd.Parameters.AddWithValue("@emp_lastName", newemployeeLastNametxt.Text);
                cmd.Parameters.AddWithValue("@emp_father", newemployeeFatherNametxt.Text);
                cmd.Parameters.AddWithValue("@emp_cnic", newemployeeCnictxt.Text);
                cmd.Parameters.AddWithValue("@emp_Gender", genderEmployee);
                cmd.Parameters.AddWithValue("@emp_dob", newemployeeDOBtxt.Text);
                cmd.Parameters.AddWithValue("@emp_phone", newemployeePhonenotxt.Text);
                cmd.Parameters.AddWithValue("@emp_address", newemployeeaddresstxt.Text);
                cmd.Parameters.AddWithValue("@emp_education", newemployeeEducationtxt.Text);
                cmd.Parameters.AddWithValue("@emp_job", newemployeeJobtitletxt.Text);
                cmd.Parameters.AddWithValue("@emp_status", addnewemployeestatustxt.Text);
                cmd.Parameters.AddWithValue("@emp_medical", newemployeeMedicaltxt.Text);

                cmd.ExecuteNonQuery();
                loginForm.conn.Close();

                MessageBox.Show("Data Inserted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                newemployeeFirstNametxt.Text = "";
                newemployeeLastNametxt.Text = "";
                newemployeeFatherNametxt.Text = "";
                newemployeeCnictxt.Text = "";
                newemployeePhonenotxt.Text = "";
                newemployeeaddresstxt.Text = "";
                newemployeeEducationtxt.Text = "";
                newemployeeJobtitletxt.Text = "";
                addnewemployeestatustxt.Text = "";
                newemployeeMedicaltxt.Text = "";
                newemployeeDOBtxt.Text = DateTime.Now.ToString();
            }
        }

        private void clearnewemployeebtn_Click(object sender, EventArgs e)
        {
            newemployeeFirstNametxt.Text = "";
            newemployeeLastNametxt.Text = "";
            newemployeeFatherNametxt.Text = "";
            newemployeeCnictxt.Text = "";
            newemployeePhonenotxt.Text = "";
            newemployeeaddresstxt.Text = "";
            newemployeeEducationtxt.Text = "";
            newemployeeJobtitletxt.Text = "";
            addnewemployeestatustxt.Text = "";
            newemployeeMedicaltxt.Text = "";
            newemployeeDOBtxt.Text = DateTime.Now.ToString();

        }

        private void newemployeeJobtitletxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void newemployeeJobtitletxt_Click(object sender, EventArgs e)
        {
            newemployeeJobtitletxt.Items.Clear();
            string query = "SELECT salary_status from [emp_salary]";
            SqlDataAdapter sda = new SqlDataAdapter(query, loginForm.conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            foreach (DataRow rows in dt.Rows)
            {
                newemployeeJobtitletxt.Items.Add(rows["salary_status"]);
            }
        }


        private void newemployeeCnictxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (newemployeeCnictxt.TextLength > 12)
            {
                MessageBox.Show("Wrong Cnic, Length Must be 13", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                newemployeeCnictxt.Clear();
                newemployeeCnictxt.Focus();
            }
            else
                return;
            
        }

        private void newemployeePhonenotxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (newemployeePhonenotxt.TextLength > 10)
            {
                MessageBox.Show("Wrong Phone No, Length Must be 11", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                newemployeePhonenotxt.Clear();
                newemployeePhonenotxt.Focus();
            }
            else
                return;
        }
    }
}
