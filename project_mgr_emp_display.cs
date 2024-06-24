using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Management_System
{
    internal class project_mgr_emp_display
    {
        public int TICKET_ID { get; set; }
        public int EMP_ID { get; set; }
        public string EMP_name { get; set; }
        public int Proj_ID { get; set; }
        public string Ticket_status { get; set; }

   

     

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["EMS"].ConnectionString);


        public List<project_mgr_emp_display> project_mgr_emp(int mgrid)
        {
            List<project_mgr_emp_display> listData = new List<project_mgr_emp_display>();
            if (con.State != ConnectionState.Open)
            {
                try
                {
                    con.Open();
                    string selectData = "SELECT t.TICKET_ID , e.emp_name ,t.PROJ_ID, t.EMP_ID,t.ticket_status from ticket t inner join emp e on t.EMP_ID=e.EMP_ID WHERE e.MGR_ID=@emp_id;";
                    using (SqlCommand cmd = new SqlCommand(selectData, con))
                    {
                        cmd.Parameters.AddWithValue("@emp_id", mgrid);
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            // Create a new projectlist object and populate its properties
                            project_mgr_emp_display emp = new project_mgr_emp_display();
                            emp.TICKET_ID = (int)reader["TICKET_ID"];
                            emp.EMP_name = reader["emp_name"].ToString();
							emp.Proj_ID = (int)reader["PROJ_ID"];
							emp.EMP_ID = (int)reader["EMP_ID"];

                          
                            emp.Ticket_status = reader["ticket_status"].ToString();



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
    }
}

