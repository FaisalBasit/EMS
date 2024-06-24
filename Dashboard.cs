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
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Employee_Management_System
{
    public partial class Dashboard : UserControl
    {
        public int empid { get; set; }
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["EMS"].ConnectionString);
        public Dashboard()
        {
            InitializeComponent();
            DisplayEmployeeDataInTable();

            DashboardDeptData();
            displayTE();
            displayAE();
            displayIE();




            /*
           chart1.Series["chart"].IsValueShownAsLabel = true;
           chart1.Series["chart"].Points.AddXY("React", 33);
           chart1.Series["chart"].Points.AddXY("Python", 55);
           chart1.Series["chart"].Points.AddXY("Typescript", 41);

           */


        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
            DisplayEmployeeDataInTable();
            PopulatePieChart();
            DashboardDeptData();
            displayTE();
            displayAE();
            displayIE();




        }
        public void DashboardDeptData()
        {
            DashboardData dd = new DashboardData();
            List<DashboardData> listdata = dd.Dashboardlistdata();
            Department_display.DataSource = listdata;
        }

        public void RefreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;
            }
            DisplayEmployeeDataInTable();
            PopulatePieChart();
            DashboardDeptData();
            displayTE();
            displayAE();
            displayIE();
        }


        private void PopulatePieChart()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();

                    // Query to fetch project names and their total tickets
                    string selectData = "SELECT proj_name, total_ticket FROM proj where total_ticket !=0";

                    // Clear existing data points
                    chart1.Series["chart"].Points.Clear();
                    chart1.Series["chart"].IsValueShownAsLabel = true;

                    // Use predefined palette custom colors
                    List<Color> customColors = new List<Color>(chart1.PaletteCustomColors);

                    int colorIndex = 0;

                    using (SqlCommand cmd = new SqlCommand(selectData, con))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            string projName = reader["proj_name"].ToString();
                            int totalTickets = Convert.ToInt32(reader["total_ticket"]);

                            // Create a new data point
                            DataPoint dp = new DataPoint();
                            dp.AxisLabel = projName;
                            dp.YValues = new double[] { totalTickets };

                            // Assign a color from the predefined list
                            dp.Color = customColors[colorIndex % customColors.Count];

                            // Add data point to the series
                            chart1.Series["chart"].Points.Add(dp);

                            // Increment the color index
                            colorIndex++;
                        }

                        reader.Close();
                    }

                    // Set the font of the chart title
                    chart1.Titles.Add("Available Tickets for Project").Font = new Font("Century Gothic", 12, FontStyle.Bold);
                    chart1.Titles[0].ForeColor = Color.White; // Set font color to white
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


       
        public void displayTE()
        {
            if (con.State != ConnectionState.Open)
            {
                try
                {
                    con.Open();

                    string selectData = "SELECT COUNT(EMP_ID) FROM emp WHERE delete_date IS NULL AND EMP_ID!=1000";

                    using (SqlCommand cmd = new SqlCommand(selectData, con))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            int count = Convert.ToInt32(reader[0]);
                            dashboard_TE.Text = count.ToString();
                        }
                        reader.Close();
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

        public void displayAE()
        {
            if (con.State != ConnectionState.Open)
            {
                try
                {
                    con.Open();

                    string selectData = "SELECT COUNT(EMP_ID) FROM emp WHERE status = @status " +
                    "AND delete_date IS NULL AND EMP_ID!=@EMP_ID";

                    using (SqlCommand cmd = new SqlCommand(selectData, con))
                    {
                        cmd.Parameters.AddWithValue("@status", "Active");
                        cmd.Parameters.AddWithValue("@EMP_ID", 1000);

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            int count = Convert.ToInt32(reader[0]);
                            dashboard_AE.Text = count.ToString();
                        }
                        reader.Close();
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

        public void displayIE()
        {
            if (con.State != ConnectionState.Open)
            {
                try
                {
                    con.Open();

                    string selectData = "SELECT COUNT(EMP_ID) FROM emp WHERE status = @status " +
                    "AND delete_date IS NULL AND EMP_ID!=1000 ";

                    using (SqlCommand cmd = new SqlCommand(selectData, con))
                    {
                        cmd.Parameters.AddWithValue("@status", "Inactive");
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            int count = Convert.ToInt32(reader[0]);
                            dashboard_IE.Text = count.ToString();
                        }
                        reader.Close();
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

        public void display_emp()
        {
            if (con.State != ConnectionState.Open)
            {
                try
                {
                    con.Open();

                    string selectData = "SELECT  FROM emp WHERE status = @status " +
                    "AND delete_date IS NULL AND EMP_ID!=1000 ";

                    using (SqlCommand cmd = new SqlCommand(selectData, con))
                    {
                        cmd.Parameters.AddWithValue("@status", "Inactive");
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            int count = Convert.ToInt32(reader[0]);
                            dashboard_IE.Text = count.ToString();
                        }
                        reader.Close();
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
        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }




        private void DisplayEmployeeDataInTable()
        {
            try
            {
                // Connect to the database
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["EMS"].ConnectionString))
                {
                    con.Open();

                    // SQL query to fetch employee data
                    string query = "SELECT EMP_ID, emp_name, CASE WHEN position LIKE '%Project Manager%' THEN 'Proj Manager' ELSE position END AS position, salary, MGR_ID, DEPT_ID FROM emp WHERE EMP_ID = @emp_id";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // Add parameter
                        cmd.Parameters.AddWithValue("@emp_id", empid);

                        SqlDataReader reader = cmd.ExecuteReader();

                        // Loop through the result set
                        while (reader.Read())
                        {
                            // Add controls for each attribute and its value
                            AddLabelWithValue("Emp ID", reader["EMP_ID"].ToString());
                            AddLabelWithValue("Name", reader["emp_name"].ToString());
                            AddLabelWithValue("Position", reader["position"].ToString());
                            AddLabelWithValue("Salary", reader["salary"].ToString());
                            AddLabelWithValue("Mgr ID", reader["MGR_ID"].ToString());
                            AddLabelWithValue("Dept ID", reader["DEPT_ID"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void AddLabelWithValue(string attributeName, string attributeValue)
        {
            // Create and configure the label for the attribute name
            Label attributeNameLabel = new Label()
            {
                Text = attributeName,
                AutoSize = true,
                ForeColor = Color.FromArgb(172, 194, 239) // Set font color to RGB(172, 194, 239) for attribute name
            };

            // Create and configure the label for the attribute value
            Label attributeValueLabel = new Label()
            {
                Text = attributeValue,
                AutoSize = true
            };

            // Add controls to the TableLayoutPanel
            tableLayoutPanel1.Controls.Add(attributeNameLabel);
            tableLayoutPanel1.Controls.Add(attributeValueLabel);
        }

        private void Department_display_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

