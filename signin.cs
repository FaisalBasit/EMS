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
using System.Net;

namespace Employee_Management_System
{
    public partial class signin : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["EMS"].ConnectionString;
        public signin()
        {

            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
         public static bool IsUserLoggedIn { get; private set; } = false;
        private void login_button_Click(object sender, EventArgs e)
        {
            if (EmployeeID.Text != "" && password.Text != "")
            {
                SqlConnection con = new SqlConnection(cs);
                string query = "select * from emp where EMP_ID=@EMP_ID and pass=@pass";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@EMP_ID", EmployeeID.Text);
                cmd.Parameters.AddWithValue("@pass", password.Text);

                con.Open();

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    int EMP_IDIndex = dr.GetOrdinal("EMP_ID");
                    int nameIndex = dr.GetOrdinal("emp_name");
                    int statusIndex = dr.GetOrdinal("status");

                    while (dr.Read())
                    {
                        string status = dr.GetString(statusIndex);
                        if (status != "Active")
                        {
                            MessageBox.Show("You are no longer an active employee. You cannot login.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            con.Close();
                            return;
                        }

                        int EMP_ID = dr.GetInt32(EMP_IDIndex);
                        string name = dr.GetString(nameIndex);

                        MessageBox.Show("Login Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        IsUserLoggedIn = true;

                        Main main = new Main
                        {
                            empid1 = EMP_ID,
                            name1 = name
                        };
                        main.Show();
                    }
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Login Failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Please fill both fields!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to exit?", "Conformation Messaage", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                Application.Exit();
                this.Hide();
            }
        }

        private void password_Click(object sender, EventArgs e)
        {

        }

        private void EmployeeID_Click(object sender, EventArgs e)
        {

        }

        private void signin_Load(object sender, EventArgs e)
        {

        }
    }
}
