using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Runtime.Remoting.Contexts;


namespace Employee_Management_System
{

    internal class SalaryData
    {
        public int Emp_ID { get; set; }
        public string Emp_Name { get; set; }

        public string Position { get; set; }
        public int Salary { get; set; }

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["EMS"].ConnectionString);

        public List<SalaryData> Salarylistdata()
        {

            List<SalaryData> listData = new List<SalaryData>();

            if (con.State != ConnectionState.Open)
            {
                try
                {
                    con.Open();
                    string selectData = "SELECT * FROM emp WHERE delete_date IS NULL AND EMP_ID!=1000";
                    using (SqlCommand cmd = new SqlCommand(selectData, con))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {

                            SalaryData sd = new SalaryData();
                            sd.Emp_ID = (int)reader["EMP_ID"];
                            sd.Emp_Name = reader["emp_name"].ToString();
                            sd.Position = reader["position"].ToString();
                            sd.Salary = (int)reader["salary"];

                            listData.Add(sd);
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
