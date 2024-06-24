using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Employee_Management_System
{
    public partial class Main : Form
    {
        public int empid1 { get; set; }
        public string name1 { get; set; }

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            

			empid_dash.Text = Convert.ToString(empid1);
            if (name1.Length > 6)
            {
                name_dash.Text = name1.Substring(0, 6) + "..";
            }
            else
            {
                name_dash.Text = name1;
            }

            Dashboard uc = new Dashboard();
            addUserControl(uc);
			Dashboard emp = new Dashboard
			{
				empid = empid1
			};
			addUserControl(emp);


			Project_emp proj_emp = new Project_emp
            {
                empid = Convert.ToInt32(empid1),
            };

            if (empid1 == 1000)
            {
                this.empid_dash.ForeColor = System.Drawing.Color.Green;
                
            }
            else if (empid1 > 1000 && empid1 < 1100)
            {
                this.empid_dash.ForeColor = System.Drawing.Color.White;
            }
            else
            {
                this.empid_dash.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            controlpanel.Controls.Clear();
            controlpanel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to exit?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void logout_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to Logout?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                signin signin = new signin();
                signin.Show();
                this.Close();
            }
        }
   
                public void dashboard_show()
                {
                    Dashboard uc = new Dashboard();
                    addUserControl(uc);
                    Dashboard emp = new Dashboard
                    {
                        empid = empid1
                    };
                    addUserControl(emp);
                }
 

        private void Dashboard_Button_Click(object sender, EventArgs e)
        {
            dashboard_show();

		}

        private void AddEmployee_Button_Click(object sender, EventArgs e)
        {
            if (empid1 == 1000)
            {
                AddEmployee uc = new AddEmployee();
                addUserControl(uc);
            }
            else
            {
                MessageBox.Show("Access Denied: You do not have the necessary permissions to perform this action.", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Salary_Button_Click(object sender, EventArgs e)
        {
            if (empid1 == 1000)
            {
                Salary uc = new Salary();
                addUserControl(uc);
            }
            else
            {
                MessageBox.Show("Access Denied: You do not have the necessary permissions to perform this action.", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            if (empid1 == 1000)
            {
                this.empid_dash.ForeColor = System.Drawing.Color.Green;
                Project uc = new Project();
                addUserControl(uc);

               
            }
            else if(empid1 > 1000 && empid1 < 1100)
            {
               
				Project_mgr proj_emp = new Project_mgr
				{
					empid = empid1
				};
				addUserControl(proj_emp);

             
            }
            else
            {
                this.empid_dash.ForeColor = System.Drawing.Color.Red;
                Project_emp proj_emp = new Project_emp
                {
                    empid = empid1
                };
                addUserControl(proj_emp);


            }
        }

        private void name_dash_Click(object sender, EventArgs e)
        {

        }
    }
}
