using DevExpress.Data.Filtering.Helpers;
using DevExpress.Utils.DPI;
using DevExpress.Utils.Gesture;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Employee_Management_System
{
    public class projectlist
    {
        // Properties representing the project details
        public int Proj_ID { get; set; }
        public string Proj_Name { get; set; }
        public int Proj_ticket { get; set; }
        public int completed_ticket { get; set; }
        public int ticket_in_progress { get; set; }
        public string Proj_status { get; set; }
        public int MGR_ID { get; set; }

     

        // Database connection using connection string from configuration file
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["EMS"].ConnectionString);

        public List<projectlist> project_mgr_front(int mgrid)
        {
            List<projectlist> listData = new List<projectlist>();

            if (con.State != ConnectionState.Open)
            {
                try
                {
                    con.Open();
                    string selectData = "SELECT * FROM proj WHERE EMP_ID = @emp_id";
                    using (SqlCommand cmd = new SqlCommand(selectData, con))
                    {
                        cmd.Parameters.AddWithValue("@emp_id", mgrid);
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            // Create a new projectlist object and populate its properties
                            projectlist emp = new projectlist();
                            emp.MGR_ID = (int)reader["EMP_ID"];
                            emp.Proj_ID = (int)reader["PROJ_ID"];
                            emp.Proj_Name = reader["proj_name"].ToString();
                            emp.Proj_ticket = (int)reader["total_ticket"];
                            emp.completed_ticket = (int)reader["completed_ticket"];
                            emp.ticket_in_progress = (int)reader["tickets_in_progress"];
                            emp.Proj_status = reader["proj_status"].ToString();
                            
                            

                            listData.Add(emp); 
                        }
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
            return listData;
        }

       

        // Method to fetch and return project details
        public List<projectlist> projectdetails()
        {
            List<projectlist> listData = new List<projectlist>();

            if (con.State != ConnectionState.Open)
            {
                try
                {
                    con.Open();
                    string selectData = "SELECT proj.PROJ_ID, proj.proj_name, proj.total_ticket, proj.completed_ticket, proj.tickets_in_progress, proj.proj_status, proj.EMP_ID FROM proj INNER JOIN emp ON emp.EMP_ID = proj.EMP_ID;";
                    using (SqlCommand cmd = new SqlCommand(selectData, con))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            // Create a new projectlist object and populate its properties
                            projectlist emp = new projectlist();
                            emp.MGR_ID = (int)reader["EMP_ID"];
                            emp.Proj_ID = (int)reader["PROJ_ID"];
                            emp.completed_ticket = (int)reader["completed_ticket"];
                            emp.ticket_in_progress = (int)reader["tickets_in_progress"];
                            emp.Proj_status = reader["proj_status"].ToString();
                            emp.Proj_Name = reader["proj_name"].ToString();
                            emp.Proj_ticket = (int)reader["total_ticket"];

                            listData.Add(emp); // Add the project details to the list
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

        // Method to fetch and return manager-specific project details
        public List<projectlist> mgr_projectlist(int mgrid)
        {
            List<projectlist> listData = new List<projectlist>();

            if (con.State != ConnectionState.Open)
            {
                try
                {
                    con.Open();
                    string selectData = @"
            SELECT 
                m.EMP_ID,
                m.emp_name,
                e.MGR_ID,
                p.PROJ_ID,
                p.proj_name,
                p.total_ticket,
                p.completed_ticket,
                p.tickets_in_progress,
                p.proj_status
            FROM 
                emp e
            JOIN 
                emp m ON e.MGR_ID = m.EMP_ID
            LEFT JOIN 
                proj p ON p.EMP_ID = m.EMP_ID
            WHERE 
                e.EMP_ID = @EMP_ID AND p.proj_status = 'Available';
        ";
                    using (SqlCommand cmd = new SqlCommand(selectData, con))
                    {
                        cmd.Parameters.AddWithValue("@EMP_ID", mgrid);

                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            // Create a new projectlist object and populate its properties
                            projectlist emp = new projectlist();
                            emp.MGR_ID = (int)reader["MGR_ID"];
                            emp.Proj_ID = (int)reader["PROJ_ID"];
                            emp.completed_ticket = (int)reader["completed_ticket"];
                            emp.Proj_status = reader["proj_status"].ToString();
                            emp.ticket_in_progress = (int)reader["tickets_in_progress"];
                            emp.Proj_Name = reader["proj_name"].ToString();
                            emp.Proj_ticket = (int)reader["total_ticket"];

                            listData.Add(emp); // Add the project details to the list
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

        // Method to insert tickets into the database
        public void ticket_insert(string proj_id, string total_ticket)
        {
            int tickets = Convert.ToInt32(total_ticket);
            if (con.State != ConnectionState.Open)
            {
                try
                {
                    con.Open();
                    for (int i = 1; i <= tickets; i++)
                    {
                        // Generate ticket ID
                        string ticket = proj_id + i.ToString();
                        string insertquerry = "Insert into ticket (TICKET_ID, PROJ_ID, EMP_ID, ticket_status) values (@ticket_id, @proj_id, @emp_id, @ticket_status)";

                        using (SqlCommand cmd = new SqlCommand(insertquerry, con))
                        {
                            cmd.Parameters.AddWithValue("@ticket_id", Convert.ToInt32(ticket));
                            cmd.Parameters.AddWithValue("@proj_id", Convert.ToInt32(proj_id));
                            cmd.Parameters.AddWithValue("@emp_id", DBNull.Value);
                            cmd.Parameters.AddWithValue("@ticket_status", "available");
                            cmd.ExecuteNonQuery(); // Execute the insert command
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally { con.Close(); }
            }
        }

        // Method to update the ticket count for a project
        public void Update_ticket_count(int projId)
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }

            try
            {
                string selectData = "SELECT total_ticket, tickets_in_progress FROM proj WHERE proj_status='Available' AND PROJ_ID=@projId";
                using (SqlCommand selectCmd = new SqlCommand(selectData, con))
                {
                    selectCmd.Parameters.AddWithValue("@projId", projId);

                    SqlDataReader reader = selectCmd.ExecuteReader();
                    if (reader.Read())
                    {
                        int totalTicket = (int)reader["total_ticket"];
                        int ticketInProgress = (int)reader["tickets_in_progress"];

                        reader.Close(); // Close the reader before executing another command

                        // Update the ticket counts
                        totalTicket -= 1;
                        ticketInProgress += 1;

                        string updateData = "UPDATE proj SET total_ticket=@totalTicket, tickets_in_progress=@ticketInProgress WHERE PROJ_ID=@projId AND total_ticket > 0";
                        using (SqlCommand updateCmd = new SqlCommand(updateData, con))
                        {
                            updateCmd.Parameters.AddWithValue("@totalTicket", totalTicket);
                            updateCmd.Parameters.AddWithValue("@ticketInProgress", ticketInProgress);
                            updateCmd.Parameters.AddWithValue("@projId", projId);

                            int rowsAffected = updateCmd.ExecuteNonQuery();
                            // Uncomment the following block for a success/failure message
                            /*
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Ticket count updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Failed to update ticket count.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            */
                        }
                    }
                    else
                    {
                        MessageBox.Show("Project not found or not available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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

        // Method to update the ticket status for a project
        public void Update_ticket_status(int projID, int empid)
        {
            int ticketID = 0;
            string projID_s = projID.ToString();
            if (con.State != ConnectionState.Open)
            {
                con.Open();

                string selectData = "SELECT completed_ticket, tickets_in_progress FROM proj WHERE proj_status='Available' AND PROJ_ID=@projId";
                using (SqlCommand selectCmd = new SqlCommand(selectData, con))
                {
                    selectCmd.Parameters.AddWithValue("@projId", projID);

                    SqlDataReader reader = selectCmd.ExecuteReader();
                    if (reader.Read())
                    {
                        int completed_ticket = (int)reader["completed_ticket"];
                        int ticketInProgress = (int)reader["tickets_in_progress"];

                        reader.Close();
                        if (completed_ticket != 0 || ticketInProgress != 0)
                        {
                            ticketID = ticketInProgress + completed_ticket + 1;
                            projID_s += ticketID.ToString();
                        }
                        else
                        {
                            projID_s += "1";
                        }
                    }
                }

                try
                {
                    MessageBox.Show(projID_s);
                    string updateData = "UPDATE ticket SET ticket_status=@Ticket_status, EMP_ID=@EMP_ID WHERE TICKET_ID=@ticket_id AND ticket_status='Available' ";
                    using (SqlCommand updateCmd = new SqlCommand(updateData, con))
                    {
                        updateCmd.Parameters.AddWithValue("@Ticket_status", "Hold");
                        updateCmd.Parameters.AddWithValue("@ticket_id", Convert.ToInt32(projID_s));
                        updateCmd.Parameters.AddWithValue("@EMP_ID", empid);

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

        // Method to update the project status
        public void Update_project_status()
        {
            if (con.State != ConnectionState.Open)
            {
                try
                {
                    con.Open();
                    string updateData = "UPDATE proj SET proj_status = 'complete' where proj_status = 'Available' AND (total_ticket + tickets_in_progress) = 1";
                    using (SqlCommand updateCmd = new SqlCommand(updateData, con))
                    {
                        int rowsAffected = updateCmd.ExecuteNonQuery();
                        // Uncomment the following block for a success/failure message
                        /*
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Project status updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Failed to update Project status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
