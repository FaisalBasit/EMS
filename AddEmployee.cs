using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.Remoting.Contexts;
using System.IO;
using System.Text.RegularExpressions;
using System.Diagnostics.Eventing.Reader;

namespace Employee_Management_System
{
    public partial class AddEmployee : UserControl
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["EMS"].ConnectionString);

        //regular expression for password validation
        string Passpattern = @"(?=^.{8,}$)((?=.*\d)|(?=.*\W+))(?![.\n])(?=.*[A-Z])(?=.*[a-z]).*$";
        public AddEmployee()
        {
            InitializeComponent();
            displayemployeedata();
        }
        public void RefreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;
            }
            displayemployeedata();
        }

		private void AddEmployee_Load(object sender, EventArgs e)
		{
			displaymanager();
		}


		public void clearFields()
        {
            AddEmployee_EmployeeID.Text = "";
            AddEmployee_Fullname.Text = "";
            AddEmployee_PhoneNumber.Text = "";
            AddEmployee_Status.SelectedIndex = -1;
            AddEmployee_DepartmentID.SelectedIndex = -1;
            AddEmployee_Gender.SelectedIndex = -1;        
            AddEmployee_Position.SelectedIndex = -1;
            AddEmployee_MGR.SelectedIndex = -1;
            AddEmployee_Password.Text = "";
           
        }
        public void displayemployeedata()
        {
            employee ed = new employee();
            List<employee> listdata = ed.employeelistdata();
            emp_displaydata.DataSource = listdata;
        }


        private void AddEmployee_Password_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(AddEmployee_Password.Text, Passpattern) == false)
            {
                errorProvider1.SetError(this.AddEmployee_Password, "Password must be of alteast 8 characters, must contain at least one Number, one Uppercase Letter, one Lowercase Letter and one Special Character!");
            }

            else
            {
                errorProvider1.Clear();
            }
        }

		private bool IsDigitsOnly(string str)
		{
			foreach (char c in str)
			{
				if (c < '0' || c > '9')
				{
					return false;
				}
			}
			return true;
		}
        private bool IsValidName(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsLetter(c) && c != ' ')
                {
                    return false;
                }
            }
            return true;
        }
        private void displaymanager()
        {
			if (con.State != ConnectionState.Open)
			{
				try
				{
					con.Open();
					string selectData = "SELECT * FROM emp WHERE position = 'Project Manager' OR position ='HR Manager' or position='President'";
					using (SqlCommand cmd = new SqlCommand(selectData, con))
					{
						SqlDataReader reader = cmd.ExecuteReader();
						while (reader.Read())
						{
							AddEmployee_MGR.Items.Add((int)reader["EMP_ID"]);
						}
						reader.Close();
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				finally { con.Close(); }
			}
		}


		private void AddEmployeeButton_Click(object sender, EventArgs e)
		{
            string phonenum = AddEmployee_PhoneNumber.Text.Trim();
            string emp_id = AddEmployee_EmployeeID.Text.Trim();

            if (AddEmployee_EmployeeID.Text == "" || AddEmployee_Fullname.Text == "" || AddEmployee_MGR.Text == "" ||
                AddEmployee_PhoneNumber.Text == "" || AddEmployee_Position.Text == "" || AddEmployee_Status.Text == ""
                || AddEmployee_Password.Text == "" || AddEmployee_Gender.Text == "" || AddEmployee_DepartmentID.Text == "")
            {
                MessageBox.Show("Please fill all blank fields!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (emp_id.Length != 2 || !IsDigitsOnly(emp_id))
            {
                MessageBox.Show("Invalid Employee ID. Enter a two-digit number.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!IsValidName(AddEmployee_Fullname.Text.Trim()))
            {
                MessageBox.Show("Invalid Name. Name should not contain digits or special characters.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (phonenum.Length != 11 || !phonenum.StartsWith("03") || !IsDigitsOnly(phonenum))
			{
				MessageBox.Show("Invaild Phone Number. Number should be of 11 digits starting with 03", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else if (Regex.IsMatch(AddEmployee_Password.Text, Passpattern) == false)
			{
				errorProvider1.SetError(this.AddEmployee_Password, "Password must be of alteast 8 characters, must contain at least one Number, one Uppercase Letter, one Lowercase Letter and one Special Character!");
			}
			else
			{
			
                if (AddEmployee_Position.Text.Trim() == "HR Manager" || AddEmployee_Position.Text.Trim() == "Project Manager")
				{
                    emp_id = "10" + emp_id;
				}
				else
				{
                    emp_id = "11" + emp_id;
				}
				if (con.State == ConnectionState.Closed)
				{
					try
					{
						con.Open();
						string checkEmID = "SELECT COUNT(*) FROM emp WHERE EMP_ID = @EMP_ID";
						using (SqlCommand checkEm = new SqlCommand(checkEmID, con))
						{
							checkEm.Parameters.AddWithValue("@EMP_ID", AddEmployee_EmployeeID.Text.Trim());
							int count = (int)checkEm.ExecuteScalar();

							if (count >= 1)
							{
								MessageBox.Show(AddEmployee_EmployeeID.Text.Trim() + " is already taken", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
							}
							else
							{
								DateTime today = DateTime.Today;
								string insertData = "INSERT INTO emp" + "(EMP_ID, emp_name, contact_num, gender, position,salary, insert_date, status, pass, MGR_ID,DEPT_ID) " +

													"VALUES(@EMP_ID, @emp_name, @contact_num, @gender,@position,@salary, @insert_date, @status, @pass, @MGR_ID, @DEPT_ID)";

								using (SqlCommand cmd = new SqlCommand(insertData, con))
								{
                                    cmd.Parameters.AddWithValue("@EMP_ID", AddEmployee_EmployeeID.Text.Trim());
                                    cmd.Parameters.AddWithValue("@emp_name", AddEmployee_Fullname.Text.Trim());
                                    cmd.Parameters.AddWithValue("@contact_num", AddEmployee_PhoneNumber.Text.Trim());
                                    cmd.Parameters.AddWithValue("@gender", AddEmployee_Gender.Text.Trim());
                                    cmd.Parameters.AddWithValue("@position", AddEmployee_Position.Text.Trim());
                                    cmd.Parameters.AddWithValue("@salary", 0);
                                    cmd.Parameters.AddWithValue("@insert_date", today);
                                    cmd.Parameters.AddWithValue("@status", AddEmployee_Status.Text.Trim());
                                    cmd.Parameters.AddWithValue("@pass", AddEmployee_Password.Text.Trim());
                                    cmd.Parameters.AddWithValue("@MGR_ID", AddEmployee_MGR.Text.Trim());
                                    cmd.Parameters.AddWithValue("@DEPT_ID", AddEmployee_DepartmentID.Text.Trim());


                                    cmd.ExecuteNonQuery();

									displayemployeedata();

									MessageBox.Show("Added Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
									clearFields();
								}
							}
						}
					}

					catch (Exception ex)
					{
						MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}


					finally
					{
						con.Close();
					}

				}
			}
		}


        private void AddEmployee_Update_Click(object sender, EventArgs e)
        {
            string phonenum = AddEmployee_PhoneNumber.Text.Trim();
            string emp_id = AddEmployee_EmployeeID.Text.Trim();

            if (AddEmployee_EmployeeID.Text == "" || AddEmployee_Fullname.Text == "" || AddEmployee_MGR.Text == "" ||
                AddEmployee_PhoneNumber.Text == "" || AddEmployee_Position.Text == "" || AddEmployee_Status.Text == ""
                || AddEmployee_Password.Text == "" || AddEmployee_Gender.Text == "" || AddEmployee_DepartmentID.Text == "")
            {
                MessageBox.Show("Please fill all blank fields!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (emp_id.Length != 2 || !IsDigitsOnly(emp_id))
            {
                MessageBox.Show("Invalid Employee ID. Enter a two-digit number.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!IsValidName(AddEmployee_Fullname.Text.Trim()))
            {
                MessageBox.Show("Invalid Name. Name should not contain digits or special characters.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (phonenum.Length != 11 || !phonenum.StartsWith("03") || !IsDigitsOnly(phonenum))
            {
                MessageBox.Show("Invaild Phone Number. Number should be of 11 digits starting with 03", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Regex.IsMatch(AddEmployee_Password.Text, Passpattern) == false)
            {
                errorProvider1.SetError(this.AddEmployee_Password, "Password must be of alteast 8 characters, must contain at least one Number, one Uppercase Letter, one Lowercase Letter and one Special Character!");
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to UPDATE Employee ID: " + AddEmployee_EmployeeID.Text.Trim() + "?",
                    "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (check == DialogResult.Yes)
                {
                    // Validate and construct emp_id based on position
                    if (AddEmployee_Position.Text.Trim() == "HR Manager" || AddEmployee_Position.Text.Trim() == "Project Manager")
                    {
                        emp_id = "10" + emp_id;
                    }
                    else
                    {
                        emp_id = "11" + emp_id;
                    }

                    try
                    {
                        con.Open();
                        DateTime today = DateTime.Today;

                        string updateData = "UPDATE emp SET emp_name = @emp_name, contact_num = @contact_num, gender = @gender, " +
                            "position = @position, salary = @salary, insert_date = @insert_date, status = @status, pass = @pass, " +
                            "MGR_ID = @MGR_ID, DEPT_ID = @DEPT_ID WHERE EMP_ID = @EMP_ID";

                        using (SqlCommand cmd = new SqlCommand(updateData, con))
                        {
                            cmd.Parameters.AddWithValue("@EMP_ID", AddEmployee_EmployeeID.Text.Trim());
                            cmd.Parameters.AddWithValue("@emp_name", AddEmployee_Fullname.Text.Trim());
                            cmd.Parameters.AddWithValue("@contact_num", AddEmployee_PhoneNumber.Text.Trim());
                            cmd.Parameters.AddWithValue("@gender", AddEmployee_Gender.Text.Trim());
                            cmd.Parameters.AddWithValue("@position", AddEmployee_Position.Text.Trim());
                            cmd.Parameters.AddWithValue("@salary", 0); // Ensure the salary parameter is properly set
                            cmd.Parameters.AddWithValue("@insert_date", today);
                            cmd.Parameters.AddWithValue("@status", AddEmployee_Status.Text.Trim());
                            cmd.Parameters.AddWithValue("@pass", AddEmployee_Password.Text.Trim());
                            cmd.Parameters.AddWithValue("@MGR_ID", AddEmployee_MGR.Text.Trim());
                            cmd.Parameters.AddWithValue("@DEPT_ID", AddEmployee_DepartmentID.Text.Trim());


                            cmd.ExecuteNonQuery();

                            displayemployeedata();

                            MessageBox.Show("Update successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            clearFields();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        con.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Cancelled.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }


        private void AddEmployee_Clear_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void AddEmployee_Delete_Click(object sender, EventArgs e)
        {
            if (AddEmployee_EmployeeID.Text == "" )
            {
                MessageBox.Show("Please fill all blank fields"
                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to DELETE " +
                    "Employee ID: " + AddEmployee_EmployeeID.Text.Trim() + "?", "Confirmation Message"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (check == DialogResult.Yes)
                {
                    try
                    {
                        con.Open();
                        DateTime today = DateTime.Today;

                        string updateData = "UPDATE emp SET delete_date = @delete_date " +
                            "WHERE EMP_ID = @EMP_ID";

                        using (SqlCommand cmd = new SqlCommand(updateData, con))
                        {
                            cmd.Parameters.AddWithValue("@delete_date", today);
                            cmd.Parameters.AddWithValue("@EMP_ID", AddEmployee_EmployeeID.Text.Trim());

                            cmd.ExecuteNonQuery();

                            displayemployeedata();

                            MessageBox.Show("Update successfully!"
                                , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            clearFields();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex
                        , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        con.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Cancelled."
                        , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        
        }

    

        private void emp_displaydata_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = emp_displaydata.Rows[e.RowIndex];
                AddEmployee_EmployeeID.Text = row.Cells[0].Value.ToString();
                AddEmployee_Fullname.Text = row.Cells[1].Value.ToString();
                AddEmployee_PhoneNumber.Text = row.Cells[2].Value.ToString();
                AddEmployee_Status.Text = row.Cells[5].Value.ToString();
                AddEmployee_DepartmentID.Text = row.Cells[8].Value.ToString();
                AddEmployee_Gender.Text = row.Cells[3].Value.ToString();   
                AddEmployee_Position.Text = row.Cells[4].Value.ToString();
                AddEmployee_MGR.Text = row.Cells[7].Value.ToString();
                AddEmployee_Password.Text = row.Cells[6].Value.ToString();
               
                
            }
        }

        private void emp_displaydata_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}