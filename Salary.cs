using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Management_System
{
    public partial class Salary : UserControl
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["EMS"].ConnectionString);
        public Salary()
        {
            InitializeComponent();
            displayEmployees();
            disableFields();
        }
        public void RefreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;
            }

            displayEmployees();
            disableFields();
        }

        public void disableFields()
        {
            salary_employeeID.Enabled = false;
            salary_name.Enabled = false;
            salary_position.Enabled = false;
        }

        public void displayEmployees()
        {
            SalaryData ed = new SalaryData();
            List<SalaryData> listData = ed.Salarylistdata();

            Salary_displaydata.DataSource = listData;
        }



        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        public void clearFields()
        {
            salary_employeeID.Text = "";
            salary_name.Text = "";
            salary_position.Text = "";
			salary_salary.Text = "";
        }

        private void Update_Salary_button_Click(object sender, EventArgs e)
        {
            if (salary_employeeID.Text == ""
                || salary_name.Text == ""
                || salary_position.Text == ""
                || salary_salary.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to UPDATE Salary of Employee ID: "
                    + salary_employeeID.Text.Trim() + "?", "Confirmation Message"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (check == DialogResult.Yes)
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        try
                        {
                            con.Open();
                            DateTime today = DateTime.Today;

                            string updateData = "UPDATE emp SET salary = @salary" +
                                ", update_date = @update_date WHERE EMP_ID = @EMP_ID";

                            using (SqlCommand cmd = new SqlCommand(updateData, con))
                            {
                                cmd.Parameters.AddWithValue("@salary", salary_salary.Text.Trim());
                                cmd.Parameters.AddWithValue("@update_date", today);
                                cmd.Parameters.AddWithValue("@EMP_ID", salary_employeeID.Text.Trim());

                                cmd.ExecuteNonQuery();

                                displayEmployees();

                                MessageBox.Show("Updated successfully!"
                                    , "Information Message", MessageBoxButtons.OK
                                    , MessageBoxIcon.Information);

                                clearFields();

                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex, "Error Message"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            con.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Cancelled", "Information Message"
                    , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void Clear_salary_button_Click(object sender, EventArgs e)
        {
            clearFields();
        }


        private void Salary_Load(object sender, EventArgs e)
        {

        }

		private void Salary_displaydata_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridViewRow row = Salary_displaydata.Rows[e.RowIndex];
			salary_employeeID.Text = row.Cells[0].Value.ToString();
			salary_name.Text = row.Cells[1].Value.ToString();
			salary_position.Text = row.Cells[2].Value.ToString();
			salary_salary.Text = row.Cells[3].Value.ToString();
		}

	}

}
