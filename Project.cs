using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Employee_Management_System
{
    public partial class Project : UserControl
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["EMS"].ConnectionString);

        public Project()
        {
            InitializeComponent();
            clearFields();
            displayprojectlist();
        }

        private void Project_Load(object sender, EventArgs e)
        {
            clearFields();
            Manager_list();
        }

        public int Emp_ID { get; set; }

        public void clearFields()
        {
            proj_id.Text = "";
            proj_name.Text = "";
            proj_tickets.Text = "";
            emp_id.SelectedIndex = -1;
        }

        public void Manager_list()
        {
            if (con.State != ConnectionState.Open)
            {
                try
                {
                    con.Open();
                    string selectData = "SELECT * FROM emp WHERE position = 'Project Manager'";
                    using (SqlCommand cmd = new SqlCommand(selectData, con))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            emp_id.Items.Add((int)reader["EMP_ID"]);
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

        public void displayprojectlist()
        {
            projectlist ed = new projectlist();
            List<projectlist> listdata = ed.projectdetails();
            Project_displaydata.DataSource = listdata;
        }

        private void Project_Add_Click_1(object sender, EventArgs e)
        {
            if (proj_id.Text == "" || proj_name.Text == "" || proj_tickets.Text == "" || emp_id.Text == "")
            {
                MessageBox.Show("Please fill all blank fields!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (con.State == ConnectionState.Closed)
                {
                    try
                    {
                        con.Open();
                        string checkEmID = "SELECT COUNT(*) FROM proj WHERE PROJ_ID = @PROJ_ID";
                        using (SqlCommand checkEm = new SqlCommand(checkEmID, con))
                        {
                            checkEm.Parameters.AddWithValue("@PROJ_ID", proj_id.Text.Trim());
                            int count = (int)checkEm.ExecuteScalar();

                            if (count >= 1)
                            {
                                MessageBox.Show(proj_id.Text.Trim() + " is already taken", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO proj (PROJ_ID, proj_name, total_ticket, proj_status, EMP_ID, completed_ticket, tickets_in_progress) " +
                                                    "VALUES (@PROJ_ID, @proj_name, @total_ticket, @proj_status, @EMP_ID, @completed_ticket, @tickets_in_progress)";
                                using (SqlCommand cmd = new SqlCommand(insertData, con))
                                {
                                    cmd.Parameters.AddWithValue("@PROJ_ID", proj_id.Text.Trim());
                                    cmd.Parameters.AddWithValue("@proj_name", proj_name.Text.Trim());
                                    cmd.Parameters.AddWithValue("@total_ticket", proj_tickets.Text.Trim());
                                    cmd.Parameters.AddWithValue("@EMP_ID", emp_id.Text.Trim());
                                    cmd.Parameters.AddWithValue("@proj_status", "Available");
                                    cmd.Parameters.AddWithValue("@completed_ticket", 0);
                                    cmd.Parameters.AddWithValue("@tickets_in_progress", 0);
                                    cmd.ExecuteNonQuery();

                                    projectlist ed = new projectlist();
                                    string project_id = proj_id.Text.Trim();
                                    string T_ticket_s = proj_tickets.Text.Trim();
                                    ed.ticket_insert(project_id, T_ticket_s);

                                    MessageBox.Show("Added Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    clearFields();
                                    displayprojectlist();
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

        private void Project_displaydata_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = Project_displaydata.Rows[e.RowIndex];
                proj_id.Text = row.Cells[0].Value.ToString();
                proj_name.Text = row.Cells[1].Value.ToString();
                proj_tickets.Text = row.Cells[2].Value.ToString();
                emp_id.Text = row.Cells[3].Value.ToString();
            }
        }

        private void proj_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsDigit(ch) || ch == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void proj_tickets_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsDigit(ch) || ch == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void proj_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsLetter(ch) || ch == (char)Keys.Back || ch == ' ')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void Project_Update_Click(object sender, EventArgs e)
        {
            if (proj_id.Text == "" || proj_name.Text == "" || proj_tickets.Text == "" || emp_id.Text == "")
            {
                MessageBox.Show("Please fill all blank fields!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    con.Open();
                    string updateData = "UPDATE proj SET proj_name = @proj_name, total_ticket = @total_ticket, EMP_ID = @EMP_ID WHERE PROJ_ID = @PROJ_ID";
                    using (SqlCommand cmd = new SqlCommand(updateData, con))
                    {
                        cmd.Parameters.AddWithValue("@PROJ_ID", proj_id.Text.Trim());
                        cmd.Parameters.AddWithValue("@proj_name", proj_name.Text.Trim());
                        cmd.Parameters.AddWithValue("@total_ticket", proj_tickets.Text.Trim());
                        cmd.Parameters.AddWithValue("@EMP_ID", emp_id.Text.Trim());
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Updated Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearFields();
                        displayprojectlist();
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
        private void Project_delete_Click(object sender, EventArgs e)
        {
            if (proj_id.Text == "")
            {
                MessageBox.Show("Please select a project to delete!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult result = MessageBox.Show("Deleting this project will also delete associated tickets. Are you sure you want to delete this project?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        con.Open();
                        // Delete associated tickets first
                        string deleteTicketsData = "DELETE FROM ticket WHERE PROJ_ID = @PROJ_ID";
                        using (SqlCommand cmdTickets = new SqlCommand(deleteTicketsData, con))
                        {
                            cmdTickets.Parameters.AddWithValue("@PROJ_ID", proj_id.Text.Trim());
                            cmdTickets.ExecuteNonQuery();
                        }

                        // Then delete the project
                        string deleteData = "DELETE FROM proj WHERE PROJ_ID = @PROJ_ID";
                        using (SqlCommand cmd = new SqlCommand(deleteData, con))
                        {
                            cmd.Parameters.AddWithValue("@PROJ_ID", proj_id.Text.Trim());
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Deleted Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            clearFields();
                            displayprojectlist();
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

		private void emp_id_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
