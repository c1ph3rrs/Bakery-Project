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
    public partial class attendanceUC : UserControl
    {
        public attendanceUC()
        {
            InitializeComponent();
        }

        public void displayinDataGrid()
        {
            string sDate = DateTime.Now.ToString();
            DateTime datevalue = (Convert.ToDateTime(sDate.ToString()));
            string dy = datevalue.Day.ToString();
            string mn = datevalue.Month.ToString();
            string yy = datevalue.Year.ToString();

            SqlDataAdapter sda = new SqlDataAdapter("SELECT emp_id, emp_firstName, emp_lastName, emp_cnic FROM mart_employees", loginForm.conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            attendanceDataGrid.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = attendanceDataGrid.Rows.Add();
                attendanceDataGrid.Rows[n].Cells["attendanceemployeeCode"].Value = item["emp_id"].ToString();
                attendanceDataGrid.Rows[n].Cells["attendanceemployeefirstName"].Value = item["emp_firstName"].ToString();
                attendanceDataGrid.Rows[n].Cells["attendanceemployeelastName"].Value = item["emp_lastName"].ToString();
                attendanceDataGrid.Rows[n].Cells["attendanceemployeeCnic"].Value = item["emp_cnic"].ToString();
                attendanceDataGrid.Rows[n].Cells["attendanceemployeeData"].Value = dy + "-" + mn + "-" + yy;
            }
        }
        private void attendanceSavebtn_Click(object sender, EventArgs e)
        {
            int status = 0;
            string sDate = DateTime.Now.ToString();
            DateTime datevalue = (Convert.ToDateTime(sDate.ToString()));
            string dy = datevalue.Day.ToString();
            string mn = datevalue.Month.ToString();
            string yy = datevalue.Year.ToString();

            if (attendancePresentrdbtn.Checked)
            {
                status = 1;
            }
            else if (attendanceAbsentrdbtn.Checked)
            {
                status = 0;
            }

            if (attendanceemployeecodetxt.Text.Trim() == "")
            {
                MessageBox.Show("Please Select the Employee First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                loginForm.conn.Open();
                string query = "INSERT INTO [emp_attendance] (attend_empcode, attend_empname, attend_empcnic, attend_empStatus, attend_empDate, attend_empMonth, attend_empYear)" +
                    "VALUES (@attend_empcode, @attend_empname, @attend_empcnic, @attend_empStatus, @attend_empDate, @attend_empMonth, @attend_empYear)";
                SqlCommand cmd = new SqlCommand(query, loginForm.conn);
                cmd.Parameters.AddWithValue("@attend_empcode", attendanceemployeecodetxt.Text);
                cmd.Parameters.AddWithValue("@attend_empname", attendancefirstNametxt.Text + " " + attendancelastnametxt.Text);
                cmd.Parameters.AddWithValue("@attend_empcnic", attendancecnictxt.Text);
                cmd.Parameters.AddWithValue("@attend_empStatus", status.ToString());
                cmd.Parameters.AddWithValue("@attend_empDate", dy);
                cmd.Parameters.AddWithValue("@attend_empMonth", mn);
                cmd.Parameters.AddWithValue("@attend_empYear", yy);
                cmd.ExecuteNonQuery();
                loginForm.conn.Close();
                MessageBox.Show("Attendance Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void searchEmployeetxt_TextChanged(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT emp_id, emp_firstName, emp_lastName, emp_cnic FROM mart_employees WHERE emp_firstName LIKE '%" + searchEmployeetxt.Text + "%'", loginForm.conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            attendanceDataGrid.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = attendanceDataGrid.Rows.Add();
                attendanceDataGrid.Rows[n].Cells["attendanceemployeeCode"].Value = item["emp_id"].ToString();
                attendanceDataGrid.Rows[n].Cells["attendanceemployeefirstName"].Value = item["emp_firstName"].ToString();
                attendanceDataGrid.Rows[n].Cells["attendanceemployeelastName"].Value = item["emp_lastName"].ToString();
                attendanceDataGrid.Rows[n].Cells["attendanceemployeeCnic"].Value = item["emp_cnic"].ToString();
            }
        }

        private void attendanceDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = attendanceDataGrid.Rows[index];

            attendanceemployeecodetxt.Text = selectedRow.Cells["attendanceemployeeCode"].Value.ToString();
            attendancefirstNametxt.Text = selectedRow.Cells["attendanceemployeefirstName"].Value.ToString();
            attendancelastnametxt.Text = selectedRow.Cells["attendanceemployeelastName"].Value.ToString();
            attendancecnictxt.Text = selectedRow.Cells["attendanceemployeeCnic"].Value.ToString();
        }

        private void attendanceClearbtn_Click(object sender, EventArgs e)
        {
            attendanceemployeecodetxt.Text = "";
            attendancefirstNametxt.Text = "";
            attendancelastnametxt.Text = "";
            attendancecnictxt.Text = "";
            attendanceemployeecodetxt.Text = "";
            if (attendancePresentrdbtn.Checked)
            {
                attendancePresentrdbtn.Checked = false;
            }
            else if (attendanceAbsentrdbtn.Checked)
            {
                attendanceAbsentrdbtn.Checked = false;
            }
        }
    }
}
