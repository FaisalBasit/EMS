using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq.Expressions;
using System.Windows.Forms;
using System.Security.Cryptography;
using DevExpress.Data.Filtering.Helpers;

namespace Employee_Management_System
{
    class employee
    {
        public int Emp_ID { get; set; }
        public string Emp_Name { get; set; }
        public string Contact_Num { get; set; }
        public string Gender { get; set; }
        public string Position { get; set; }
        public string Status { get; set; }
        public string Pass { get; set; }
        public int MGR_ID { get; set; }
        public int DEPT_ID { get; set; }



        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["EMS"].ConnectionString);

       
        public List<employee> employeelistdata()
        {

            List<employee> listData = new List<employee>();
            

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
                          

                            employee emp = new employee();
                            emp.Emp_ID = (int)reader["EMP_ID"];
                            emp.Emp_Name = reader["emp_name"].ToString();
                            emp.Gender = reader["gender"].ToString();
                            emp.Contact_Num = reader["contact_num"].ToString();
                            emp.Position = reader["position"].ToString();
                            emp.MGR_ID = (int)reader["MGR_ID"];
                            emp.Status = reader["status"].ToString();
                            emp.DEPT_ID = (int)reader["DEPT_ID"];
                            //emp.Salary = (int)reader["salary"];
                            emp.Pass = reader["pass"].ToString();
                            listData.Add(emp);
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
    }


}

