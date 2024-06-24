using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Management_System
{


    internal class DashboardData
    {
        public int Dept_ID { get; set; }

        public string Dept_Name { get; set; }

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["EMS"].ConnectionString);


        public List<DashboardData> Dashboardlistdata()
        {

            List<DashboardData> listData = new List<DashboardData>();

            if (con.State != ConnectionState.Open)
            {
                try
                {
                    con.Open();
                    string selectdept = "SELECT * FROM dept";
                    using (SqlCommand cmd = new SqlCommand(selectdept, con))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {


                            DashboardData dd = new DashboardData();
                            dd.Dept_ID = (int)reader["DEPT_ID"];
                            dd.Dept_Name = reader["dept_name"].ToString();

                            listData.Add(dd);
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
            return listData;
        }

    }
}

