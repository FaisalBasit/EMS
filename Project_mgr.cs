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

namespace Employee_Management_System
{
    public partial class Project_mgr : UserControl
    {

        public int empid { get; set; }
        // Database connection using connection string from configuration file
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["EMS"].ConnectionString);
        public Project_mgr()
        {
            InitializeComponent();

        }

        public void displaymgrprojectfront()
        {
            projectlist pp = new projectlist();
            List<projectlist> listdata = pp.project_mgr_front(empid); // Fetching manager project list
            Project_displaydata.DataSource = listdata; // Binding the data to the grid


        }
        public void displaymgrprojectemp()
        {
            project_mgr_emp_display pp = new project_mgr_emp_display();
            List<project_mgr_emp_display> listdata = pp.project_mgr_emp(empid);
            emp_mgr_display.DataSource = listdata;
        }

        private void Project_displaydata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Project_mgr_Load(object sender, EventArgs e)
        {
            displaymgrprojectfront();
            displaymgrprojectemp();
        }



    }
    
}

