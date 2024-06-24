using DevExpress.Internal.WinApi.Windows.UI.Notifications;
using DevExpress.Utils.Gesture;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Management_System
{
    public partial class Project_emp : UserControl
    {
        public Project_emp()
        {
            InitializeComponent();
        }

        // Property to store employee ID
        public int empid { get; set; }

        // Method to disable the ticket ID text box
        public void disable_textbox()
        {
            tkt_id.Enabled = false;
        }
        public void Clear_textbox()
        {
            tkt_id.Text = "";
        }

        // Method to display the list of projects managed by the manager
        public void displaymgrprojectlist()
        {
            projectlist ed = new projectlist();
            List<projectlist> listdata = ed.mgr_projectlist(empid); // Fetching manager project list
            mgr_project_display.DataSource = listdata; // Binding the data to the grid

            ticketlist list = new ticketlist();
            List<ticketlist> T_listdata = list.projectdetails(empid); // Fetching project details
            myProject_displaydata.DataSource = T_listdata; // Binding the data to the grid
        }

        // Method to display the list of completed tickets
        public void displaycompletedtickets()
        {
            ticketlist list = new ticketlist();
            List<ticketlist> T_listdata = list.projectdetails_complete(empid); // Fetching completed project details
            myProject_displaydata.DataSource = T_listdata; // Binding the data to the grid
        }

        // Event handler for UserControl load event
        private void Project_emp_Load(object sender, EventArgs e)
        {
            displaymgrprojectlist(); // Display manager project list on load
            disable_textbox(); // Disable the ticket ID text box on load
        }

        // Event handler for double-clicking a cell in the manager project display grid
        private void mgr_project_display_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to accept this project?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                if (e.RowIndex != -1)
                {
                    DataGridViewRow row = mgr_project_display.Rows[e.RowIndex];
                    int proj_id = Convert.ToInt32(row.Cells[0].Value.ToString());

                    projectlist ed = new projectlist();
                    ed.Update_ticket_status(proj_id, empid); // Update ticket status for the project
                    ed.Update_ticket_count(proj_id); // Update ticket count for the project
                    displaymgrprojectlist(); // Refresh the manager project list display
                }
            }
        }

        // Event handler for clicking a cell in the project display data grid
        private void myProject_displaydata_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = myProject_displaydata.Rows[e.RowIndex];
                tkt_id.Text = row.Cells[0].Value.ToString(); // Set the ticket ID text box to the selected ticket ID
            }
        }

        // Event handler for completing a ticket
        private void ticket_comp_Click(object sender, EventArgs e)
        {
            int ticket_id = Convert.ToInt32(tkt_id.Text.Trim());
            ticketlist ticketlist = new ticketlist();
            ticketlist.update_ticket_status(ticket_id); // Update the status of the ticket to complete

            displaymgrprojectlist(); // Refresh the manager project list display
            projectlist projectlist = new projectlist();
            projectlist.Update_project_status(); // Update the project status
            ticketlist = new ticketlist();
            ticketlist.update_complete_count(); // Update the count of completed tickets
            displaymgrprojectlist(); // Refresh the manager project list display
            Clear_textbox();
        }

        // Event handler for checking or unchecking the display completed tickets checkbox
        private void display_comp_CheckedChanged(object sender, EventArgs e)
        {
            if (display_comp.Checked)
            {
                displaycompletedtickets(); // Display completed tickets if checked
            }
            else
            {
                displaymgrprojectlist(); // Display manager project list if unchecked
            }
        }

        // Placeholder event handler for clicking cell content in the manager project display grid
        private void mgr_project_display_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
