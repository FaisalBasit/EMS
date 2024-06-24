using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils.Gesture;

namespace Employee_Management_System
{
    public class ticketlist
    {
        // Properties representing the ticket details
        public int ticket_id { get; set; }
        public int Project_id { get; set; }
        public string ticket_status { get; set; }

        // Database connection using connection string from configuration file
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["EMS"].ConnectionString);

        // Method to fetch and return all ticket details for a specific employee
        public List<ticketlist> projectdetails_complete(int empid)
        {
            List<ticketlist> listData = new List<ticketlist>();

            if (con.State != ConnectionState.Open)
            {
                try
                {
                    con.Open();
                    string selectData = "SELECT TICKET_ID, PROJ_ID, ticket_status FROM ticket WHERE EMP_ID = @EMP_ID;";
                    using (SqlCommand cmd = new SqlCommand(selectData, con))
                    {
                        cmd.Parameters.AddWithValue("@EMP_ID", empid);
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            // Create a new ticketlist object and populate its properties
                            ticketlist list = new ticketlist();
                            list.ticket_id = (int)reader["TICKET_ID"];
                            list.Project_id = (int)reader["PROJ_ID"];
                            list.ticket_status = reader["ticket_status"].ToString();

                            listData.Add(list); // Add the ticket details to the list
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return listData;
        }

        // Method to fetch and return 'hold' ticket details for a specific employee
        public List<ticketlist> projectdetails(int empid)
        {
            List<ticketlist> listData = new List<ticketlist>();

            if (con.State != ConnectionState.Open)
            {
                try
                {
                    con.Open();
                    string selectData = "SELECT TICKET_ID, PROJ_ID, ticket_status FROM ticket WHERE EMP_ID = @EMP_ID AND ticket_status = 'hold';";
                    using (SqlCommand cmd = new SqlCommand(selectData, con))
                    {
                        cmd.Parameters.AddWithValue("@EMP_ID", empid);
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            // Create a new ticketlist object and populate its properties
                            ticketlist list = new ticketlist();
                            list.ticket_id = (int)reader["TICKET_ID"];
                            list.Project_id = (int)reader["PROJ_ID"];
                            list.ticket_status = reader["ticket_status"].ToString();

                            listData.Add(list); // Add the ticket details to the list
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return listData;
        }

        // Method to update the status of a specific ticket
        public void update_ticket_status(int ticket_id)
        {
            if (con.State != ConnectionState.Open)
            {
                try
                {
                    con.Open();
                    string updateData = "UPDATE ticket SET ticket.ticket_status = 'complete' WHERE TICKET_ID = @TICKET_ID;";
                    using (SqlCommand updateCmd = new SqlCommand(updateData, con))
                    {
                        updateCmd.Parameters.AddWithValue("@TICKET_ID", ticket_id);

                        int rowsAffected = updateCmd.ExecuteNonQuery();
                        // Uncomment the following block for a success/failure message
                        /*
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Ticket status updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Failed to update ticket status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        */
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }
                }
            }
        }

        // Method to update the completed and in-progress ticket counts for projects
        public void update_complete_count()
        {
            if (con.State != ConnectionState.Open)
            {
                try
                {
                    con.Open();
                    string updateData = "UPDATE proj SET proj.completed_ticket = proj.completed_ticket + 1, proj.tickets_in_progress = proj.tickets_in_progress - 1 FROM proj INNER JOIN ticket t ON proj.PROJ_ID = t.PROJ_ID WHERE t.ticket_status = 'complete' AND proj.tickets_in_progress > 0";
                    using (SqlCommand updateCmd = new SqlCommand(updateData, con))
                    {
                        int rowsAffected = updateCmd.ExecuteNonQuery();
                        // Uncomment the following block for a success/failure message
                        /*
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Project counts updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Failed to update project counts.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        */
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }
                }
            }
        }
    }
}
