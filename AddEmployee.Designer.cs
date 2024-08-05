using System.Windows.Forms;

namespace Employee_Management_System
{
    partial class AddEmployee
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaElipsePanel2 = new Guna.UI.WinForms.GunaElipsePanel();
            this.emp_displaydata = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.AddEmployee_MGR = new Guna.UI.WinForms.GunaComboBox();
            this.AddEmployee_DepartmentID = new Guna.UI.WinForms.GunaComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AddEmployee_Password = new Guna.UI.WinForms.GunaTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AddEmployee_Position = new Guna.UI.WinForms.GunaComboBox();
            this.AddEmployee_Gender = new Guna.UI.WinForms.GunaComboBox();
            this.AddEmployee_Status = new Guna.UI.WinForms.GunaComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AddEmployee_Clear = new Guna.UI.WinForms.GunaAdvenceButton();
            this.AddEmployee_Delete = new Guna.UI.WinForms.GunaAdvenceButton();
            this.AddEmployee_Update = new Guna.UI.WinForms.GunaAdvenceButton();
            this.AddEmployeeButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.AddEmployee_PhoneNumber = new Guna.UI.WinForms.GunaTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.AddEmployee_Fullname = new Guna.UI.WinForms.GunaTextBox();
            this.AddEmployee_EmployeeID = new Guna.UI.WinForms.GunaTextBox();
            this.label = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gunaElipsePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emp_displaydata)).BeginInit();
            this.gunaElipsePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipsePanel2
            // 
            this.gunaElipsePanel2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(62)))));
            this.gunaElipsePanel2.Controls.Add(this.emp_displaydata);
            this.gunaElipsePanel2.Controls.Add(this.label1);
            this.gunaElipsePanel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(28)))), ((int)(((byte)(46)))));
            this.gunaElipsePanel2.Location = new System.Drawing.Point(15, 12);
            this.gunaElipsePanel2.Name = "gunaElipsePanel2";
            this.gunaElipsePanel2.Radius = 15;
            this.gunaElipsePanel2.Size = new System.Drawing.Size(745, 235);
            this.gunaElipsePanel2.TabIndex = 2;
            // 
            // emp_displaydata
            // 
            this.emp_displaydata.AllowUserToAddRows = false;
            this.emp_displaydata.AllowUserToDeleteRows = false;
            this.emp_displaydata.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.emp_displaydata.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(62)))));
            this.emp_displaydata.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.emp_displaydata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.emp_displaydata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(194)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(28)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.emp_displaydata.DefaultCellStyle = dataGridViewCellStyle2;
            this.emp_displaydata.EnableHeadersVisualStyles = false;
            this.emp_displaydata.GridColor = System.Drawing.Color.Black;
            this.emp_displaydata.Location = new System.Drawing.Point(29, 42);
            this.emp_displaydata.Name = "emp_displaydata";
            this.emp_displaydata.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.emp_displaydata.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.emp_displaydata.RowHeadersVisible = false;
            this.emp_displaydata.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.emp_displaydata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.emp_displaydata.Size = new System.Drawing.Size(688, 178);
            this.emp_displaydata.TabIndex = 1;
            this.emp_displaydata.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.emp_displaydata_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employees Data";
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(62)))));
            this.gunaElipsePanel1.Controls.Add(this.AddEmployee_MGR);
            this.gunaElipsePanel1.Controls.Add(this.AddEmployee_DepartmentID);
            this.gunaElipsePanel1.Controls.Add(this.label5);
            this.gunaElipsePanel1.Controls.Add(this.AddEmployee_Password);
            this.gunaElipsePanel1.Controls.Add(this.label3);
            this.gunaElipsePanel1.Controls.Add(this.AddEmployee_Position);
            this.gunaElipsePanel1.Controls.Add(this.AddEmployee_Gender);
            this.gunaElipsePanel1.Controls.Add(this.AddEmployee_Status);
            this.gunaElipsePanel1.Controls.Add(this.label2);
            this.gunaElipsePanel1.Controls.Add(this.AddEmployee_Clear);
            this.gunaElipsePanel1.Controls.Add(this.AddEmployee_Delete);
            this.gunaElipsePanel1.Controls.Add(this.AddEmployee_Update);
            this.gunaElipsePanel1.Controls.Add(this.AddEmployeeButton);
            this.gunaElipsePanel1.Controls.Add(this.label10);
            this.gunaElipsePanel1.Controls.Add(this.label4);
            this.gunaElipsePanel1.Controls.Add(this.label8);
            this.gunaElipsePanel1.Controls.Add(this.AddEmployee_PhoneNumber);
            this.gunaElipsePanel1.Controls.Add(this.label11);
            this.gunaElipsePanel1.Controls.Add(this.label9);
            this.gunaElipsePanel1.Controls.Add(this.AddEmployee_Fullname);
            this.gunaElipsePanel1.Controls.Add(this.AddEmployee_EmployeeID);
            this.gunaElipsePanel1.Controls.Add(this.label);
            this.gunaElipsePanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(28)))), ((int)(((byte)(46)))));
            this.gunaElipsePanel1.Location = new System.Drawing.Point(17, 264);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Radius = 15;
            this.gunaElipsePanel1.Size = new System.Drawing.Size(743, 280);
            this.gunaElipsePanel1.TabIndex = 3;
            // 
            // AddEmployee_MGR
            // 
            this.AddEmployee_MGR.BackColor = System.Drawing.Color.Transparent;
            this.AddEmployee_MGR.BaseColor = System.Drawing.Color.White;
            this.AddEmployee_MGR.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(194)))), ((int)(((byte)(239)))));
            this.AddEmployee_MGR.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.AddEmployee_MGR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AddEmployee_MGR.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.AddEmployee_MGR.ForeColor = System.Drawing.Color.Black;
            this.AddEmployee_MGR.FormattingEnabled = true;
            this.AddEmployee_MGR.Location = new System.Drawing.Point(291, 133);
            this.AddEmployee_MGR.Name = "AddEmployee_MGR";
            this.AddEmployee_MGR.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.AddEmployee_MGR.OnHoverItemForeColor = System.Drawing.Color.White;
            this.AddEmployee_MGR.Radius = 10;
            this.AddEmployee_MGR.Size = new System.Drawing.Size(233, 26);
            this.AddEmployee_MGR.TabIndex = 86;
            // 
            // AddEmployee_DepartmentID
            // 
            this.AddEmployee_DepartmentID.BackColor = System.Drawing.Color.Transparent;
            this.AddEmployee_DepartmentID.BaseColor = System.Drawing.Color.White;
            this.AddEmployee_DepartmentID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(194)))), ((int)(((byte)(239)))));
            this.AddEmployee_DepartmentID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.AddEmployee_DepartmentID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AddEmployee_DepartmentID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.AddEmployee_DepartmentID.ForeColor = System.Drawing.Color.Black;
            this.AddEmployee_DepartmentID.FormattingEnabled = true;
            this.AddEmployee_DepartmentID.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40"});
            this.AddEmployee_DepartmentID.Location = new System.Drawing.Point(291, 184);
            this.AddEmployee_DepartmentID.Name = "AddEmployee_DepartmentID";
            this.AddEmployee_DepartmentID.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.AddEmployee_DepartmentID.OnHoverItemForeColor = System.Drawing.Color.White;
            this.AddEmployee_DepartmentID.Radius = 10;
            this.AddEmployee_DepartmentID.Size = new System.Drawing.Size(233, 26);
            this.AddEmployee_DepartmentID.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(62)))));
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(291, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 16);
            this.label5.TabIndex = 85;
            this.label5.Text = "Department ID";
            // 
            // AddEmployee_Password
            // 
            this.AddEmployee_Password.BackColor = System.Drawing.Color.Transparent;
            this.AddEmployee_Password.BaseColor = System.Drawing.Color.White;
            this.AddEmployee_Password.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(194)))), ((int)(((byte)(239)))));
            this.AddEmployee_Password.BorderSize = 2;
            this.AddEmployee_Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AddEmployee_Password.FocusedBaseColor = System.Drawing.Color.White;
            this.AddEmployee_Password.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.AddEmployee_Password.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.AddEmployee_Password.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AddEmployee_Password.Location = new System.Drawing.Point(291, 79);
            this.AddEmployee_Password.Name = "AddEmployee_Password";
            this.AddEmployee_Password.PasswordChar = '\0';
            this.AddEmployee_Password.Radius = 10;
            this.AddEmployee_Password.Size = new System.Drawing.Size(233, 27);
            this.AddEmployee_Password.TabIndex = 8;
            this.AddEmployee_Password.Leave += new System.EventHandler(this.AddEmployee_Password_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(62)))));
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(288, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 83;
            this.label3.Text = "Password";
            // 
            // AddEmployee_Position
            // 
            this.AddEmployee_Position.BackColor = System.Drawing.Color.Transparent;
            this.AddEmployee_Position.BaseColor = System.Drawing.Color.White;
            this.AddEmployee_Position.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(194)))), ((int)(((byte)(239)))));
            this.AddEmployee_Position.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.AddEmployee_Position.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AddEmployee_Position.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.AddEmployee_Position.ForeColor = System.Drawing.Color.Black;
            this.AddEmployee_Position.FormattingEnabled = true;
            this.AddEmployee_Position.Items.AddRange(new object[] {
            "Developer",
            "Designer",
            "Consultant",
            "Salesperson",
            "Project Manager",
            "HR Manager",
            "Marketer",
            "Clerk"});
            this.AddEmployee_Position.Location = new System.Drawing.Point(25, 238);
            this.AddEmployee_Position.Name = "AddEmployee_Position";
            this.AddEmployee_Position.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.AddEmployee_Position.OnHoverItemForeColor = System.Drawing.Color.White;
            this.AddEmployee_Position.Radius = 10;
            this.AddEmployee_Position.Size = new System.Drawing.Size(233, 26);
            this.AddEmployee_Position.TabIndex = 6;
            // 
            // AddEmployee_Gender
            // 
            this.AddEmployee_Gender.BackColor = System.Drawing.Color.Transparent;
            this.AddEmployee_Gender.BaseColor = System.Drawing.Color.White;
            this.AddEmployee_Gender.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(194)))), ((int)(((byte)(239)))));
            this.AddEmployee_Gender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.AddEmployee_Gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AddEmployee_Gender.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.AddEmployee_Gender.ForeColor = System.Drawing.Color.Black;
            this.AddEmployee_Gender.FormattingEnabled = true;
            this.AddEmployee_Gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.AddEmployee_Gender.Location = new System.Drawing.Point(25, 184);
            this.AddEmployee_Gender.Name = "AddEmployee_Gender";
            this.AddEmployee_Gender.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.AddEmployee_Gender.OnHoverItemForeColor = System.Drawing.Color.White;
            this.AddEmployee_Gender.Radius = 10;
            this.AddEmployee_Gender.Size = new System.Drawing.Size(233, 26);
            this.AddEmployee_Gender.TabIndex = 5;
            // 
            // AddEmployee_Status
            // 
            this.AddEmployee_Status.BackColor = System.Drawing.Color.Transparent;
            this.AddEmployee_Status.BaseColor = System.Drawing.Color.White;
            this.AddEmployee_Status.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(194)))), ((int)(((byte)(239)))));
            this.AddEmployee_Status.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.AddEmployee_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AddEmployee_Status.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.AddEmployee_Status.ForeColor = System.Drawing.Color.Black;
            this.AddEmployee_Status.FormattingEnabled = true;
            this.AddEmployee_Status.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.AddEmployee_Status.Location = new System.Drawing.Point(291, 27);
            this.AddEmployee_Status.Name = "AddEmployee_Status";
            this.AddEmployee_Status.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.AddEmployee_Status.OnHoverItemForeColor = System.Drawing.Color.White;
            this.AddEmployee_Status.Radius = 10;
            this.AddEmployee_Status.Size = new System.Drawing.Size(233, 26);
            this.AddEmployee_Status.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(62)))));
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(291, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 78;
            this.label2.Text = "Status";
            // 
            // AddEmployee_Clear
            // 
            this.AddEmployee_Clear.AnimationHoverSpeed = 0.07F;
            this.AddEmployee_Clear.AnimationSpeed = 0.03F;
            this.AddEmployee_Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(62)))));
            this.AddEmployee_Clear.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(128)))));
            this.AddEmployee_Clear.BorderColor = System.Drawing.Color.Transparent;
            this.AddEmployee_Clear.BorderSize = 1;
            this.AddEmployee_Clear.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(128)))));
            this.AddEmployee_Clear.CheckedBorderColor = System.Drawing.Color.Black;
            this.AddEmployee_Clear.CheckedForeColor = System.Drawing.Color.Transparent;
            this.AddEmployee_Clear.CheckedImage = null;
            this.AddEmployee_Clear.CheckedLineColor = System.Drawing.Color.DimGray;
            this.AddEmployee_Clear.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.AddEmployee_Clear.ForeColor = System.Drawing.Color.White;
            this.AddEmployee_Clear.Image = null;
            this.AddEmployee_Clear.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AddEmployee_Clear.ImageSize = new System.Drawing.Size(20, 20);
            this.AddEmployee_Clear.LineColor = System.Drawing.Color.White;
            this.AddEmployee_Clear.Location = new System.Drawing.Point(623, 120);
            this.AddEmployee_Clear.Name = "AddEmployee_Clear";
            this.AddEmployee_Clear.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(128)))));
            this.AddEmployee_Clear.OnHoverBorderColor = System.Drawing.Color.Black;
            this.AddEmployee_Clear.OnHoverForeColor = System.Drawing.Color.White;
            this.AddEmployee_Clear.OnHoverImage = null;
            this.AddEmployee_Clear.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(128)))));
            this.AddEmployee_Clear.OnPressedColor = System.Drawing.Color.Black;
            this.AddEmployee_Clear.Radius = 8;
            this.AddEmployee_Clear.Size = new System.Drawing.Size(108, 37);
            this.AddEmployee_Clear.TabIndex = 76;
            this.AddEmployee_Clear.Text = "Clear";
            this.AddEmployee_Clear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AddEmployee_Clear.Click += new System.EventHandler(this.AddEmployee_Clear_Click);
            // 
            // AddEmployee_Delete
            // 
            this.AddEmployee_Delete.AnimationHoverSpeed = 0.07F;
            this.AddEmployee_Delete.AnimationSpeed = 0.03F;
            this.AddEmployee_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(62)))));
            this.AddEmployee_Delete.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(128)))));
            this.AddEmployee_Delete.BorderColor = System.Drawing.Color.Transparent;
            this.AddEmployee_Delete.BorderSize = 1;
            this.AddEmployee_Delete.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(128)))));
            this.AddEmployee_Delete.CheckedBorderColor = System.Drawing.Color.Black;
            this.AddEmployee_Delete.CheckedForeColor = System.Drawing.Color.Transparent;
            this.AddEmployee_Delete.CheckedImage = null;
            this.AddEmployee_Delete.CheckedLineColor = System.Drawing.Color.DimGray;
            this.AddEmployee_Delete.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.AddEmployee_Delete.ForeColor = System.Drawing.Color.White;
            this.AddEmployee_Delete.Image = null;
            this.AddEmployee_Delete.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AddEmployee_Delete.ImageSize = new System.Drawing.Size(20, 20);
            this.AddEmployee_Delete.LineColor = System.Drawing.Color.White;
            this.AddEmployee_Delete.Location = new System.Drawing.Point(623, 172);
            this.AddEmployee_Delete.Name = "AddEmployee_Delete";
            this.AddEmployee_Delete.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(128)))));
            this.AddEmployee_Delete.OnHoverBorderColor = System.Drawing.Color.Black;
            this.AddEmployee_Delete.OnHoverForeColor = System.Drawing.Color.White;
            this.AddEmployee_Delete.OnHoverImage = null;
            this.AddEmployee_Delete.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(128)))));
            this.AddEmployee_Delete.OnPressedColor = System.Drawing.Color.Black;
            this.AddEmployee_Delete.Radius = 8;
            this.AddEmployee_Delete.Size = new System.Drawing.Size(108, 37);
            this.AddEmployee_Delete.TabIndex = 75;
            this.AddEmployee_Delete.Text = "Delete";
            this.AddEmployee_Delete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AddEmployee_Delete.Click += new System.EventHandler(this.AddEmployee_Delete_Click);
            // 
            // AddEmployee_Update
            // 
            this.AddEmployee_Update.AnimationHoverSpeed = 0.07F;
            this.AddEmployee_Update.AnimationSpeed = 0.03F;
            this.AddEmployee_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(62)))));
            this.AddEmployee_Update.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(128)))));
            this.AddEmployee_Update.BorderColor = System.Drawing.Color.Transparent;
            this.AddEmployee_Update.BorderSize = 1;
            this.AddEmployee_Update.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(128)))));
            this.AddEmployee_Update.CheckedBorderColor = System.Drawing.Color.Black;
            this.AddEmployee_Update.CheckedForeColor = System.Drawing.Color.Transparent;
            this.AddEmployee_Update.CheckedImage = null;
            this.AddEmployee_Update.CheckedLineColor = System.Drawing.Color.DimGray;
            this.AddEmployee_Update.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.AddEmployee_Update.ForeColor = System.Drawing.Color.White;
            this.AddEmployee_Update.Image = null;
            this.AddEmployee_Update.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AddEmployee_Update.ImageSize = new System.Drawing.Size(20, 20);
            this.AddEmployee_Update.LineColor = System.Drawing.Color.White;
            this.AddEmployee_Update.Location = new System.Drawing.Point(623, 68);
            this.AddEmployee_Update.Name = "AddEmployee_Update";
            this.AddEmployee_Update.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(128)))));
            this.AddEmployee_Update.OnHoverBorderColor = System.Drawing.Color.Black;
            this.AddEmployee_Update.OnHoverForeColor = System.Drawing.Color.White;
            this.AddEmployee_Update.OnHoverImage = null;
            this.AddEmployee_Update.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(128)))));
            this.AddEmployee_Update.OnPressedColor = System.Drawing.Color.Black;
            this.AddEmployee_Update.Radius = 8;
            this.AddEmployee_Update.Size = new System.Drawing.Size(108, 37);
            this.AddEmployee_Update.TabIndex = 74;
            this.AddEmployee_Update.Text = "Update";
            this.AddEmployee_Update.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AddEmployee_Update.Click += new System.EventHandler(this.AddEmployee_Update_Click);
            // 
            // AddEmployeeButton
            // 
            this.AddEmployeeButton.AnimationHoverSpeed = 0.07F;
            this.AddEmployeeButton.AnimationSpeed = 0.03F;
            this.AddEmployeeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(62)))));
            this.AddEmployeeButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(128)))));
            this.AddEmployeeButton.BorderColor = System.Drawing.Color.Transparent;
            this.AddEmployeeButton.BorderSize = 1;
            this.AddEmployeeButton.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(128)))));
            this.AddEmployeeButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.AddEmployeeButton.CheckedForeColor = System.Drawing.Color.Transparent;
            this.AddEmployeeButton.CheckedImage = null;
            this.AddEmployeeButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.AddEmployeeButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.AddEmployeeButton.ForeColor = System.Drawing.Color.White;
            this.AddEmployeeButton.Image = null;
            this.AddEmployeeButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AddEmployeeButton.ImageSize = new System.Drawing.Size(20, 20);
            this.AddEmployeeButton.LineColor = System.Drawing.Color.White;
            this.AddEmployeeButton.Location = new System.Drawing.Point(623, 14);
            this.AddEmployeeButton.Name = "AddEmployeeButton";
            this.AddEmployeeButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(128)))));
            this.AddEmployeeButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.AddEmployeeButton.OnHoverForeColor = System.Drawing.Color.White;
            this.AddEmployeeButton.OnHoverImage = null;
            this.AddEmployeeButton.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(128)))));
            this.AddEmployeeButton.OnPressedColor = System.Drawing.Color.Black;
            this.AddEmployeeButton.Radius = 8;
            this.AddEmployeeButton.Size = new System.Drawing.Size(108, 37);
            this.AddEmployeeButton.TabIndex = 9;
            this.AddEmployeeButton.Text = "Add";
            this.AddEmployeeButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AddEmployeeButton.Click += new System.EventHandler(this.AddEmployeeButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(62)))));
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(24, 218);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 16);
            this.label10.TabIndex = 71;
            this.label10.Text = "Position";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(62)))));
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(22, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 70;
            this.label4.Text = "Gender";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(62)))));
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(23, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 16);
            this.label8.TabIndex = 69;
            this.label8.Text = "Phone Number";
            // 
            // AddEmployee_PhoneNumber
            // 
            this.AddEmployee_PhoneNumber.BackColor = System.Drawing.Color.Transparent;
            this.AddEmployee_PhoneNumber.BaseColor = System.Drawing.Color.White;
            this.AddEmployee_PhoneNumber.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(194)))), ((int)(((byte)(239)))));
            this.AddEmployee_PhoneNumber.BorderSize = 2;
            this.AddEmployee_PhoneNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AddEmployee_PhoneNumber.FocusedBaseColor = System.Drawing.Color.White;
            this.AddEmployee_PhoneNumber.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.AddEmployee_PhoneNumber.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.AddEmployee_PhoneNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AddEmployee_PhoneNumber.Location = new System.Drawing.Point(25, 132);
            this.AddEmployee_PhoneNumber.Name = "AddEmployee_PhoneNumber";
            this.AddEmployee_PhoneNumber.PasswordChar = '\0';
            this.AddEmployee_PhoneNumber.Radius = 10;
            this.AddEmployee_PhoneNumber.Size = new System.Drawing.Size(233, 27);
            this.AddEmployee_PhoneNumber.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(62)))));
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(22, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 16);
            this.label11.TabIndex = 68;
            this.label11.Text = "Full Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(62)))));
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(288, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 16);
            this.label9.TabIndex = 66;
            this.label9.Text = "MGR";
            // 
            // AddEmployee_Fullname
            // 
            this.AddEmployee_Fullname.BackColor = System.Drawing.Color.Transparent;
            this.AddEmployee_Fullname.BaseColor = System.Drawing.Color.White;
            this.AddEmployee_Fullname.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(194)))), ((int)(((byte)(239)))));
            this.AddEmployee_Fullname.BorderSize = 2;
            this.AddEmployee_Fullname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AddEmployee_Fullname.FocusedBaseColor = System.Drawing.Color.White;
            this.AddEmployee_Fullname.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.AddEmployee_Fullname.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.AddEmployee_Fullname.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AddEmployee_Fullname.Location = new System.Drawing.Point(25, 79);
            this.AddEmployee_Fullname.Name = "AddEmployee_Fullname";
            this.AddEmployee_Fullname.PasswordChar = '\0';
            this.AddEmployee_Fullname.Radius = 10;
            this.AddEmployee_Fullname.Size = new System.Drawing.Size(233, 27);
            this.AddEmployee_Fullname.TabIndex = 1;
            // 
            // AddEmployee_EmployeeID
            // 
            this.AddEmployee_EmployeeID.BackColor = System.Drawing.Color.Transparent;
            this.AddEmployee_EmployeeID.BaseColor = System.Drawing.Color.White;
            this.AddEmployee_EmployeeID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(194)))), ((int)(((byte)(239)))));
            this.AddEmployee_EmployeeID.BorderSize = 2;
            this.AddEmployee_EmployeeID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AddEmployee_EmployeeID.FocusedBaseColor = System.Drawing.Color.White;
            this.AddEmployee_EmployeeID.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.AddEmployee_EmployeeID.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.AddEmployee_EmployeeID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AddEmployee_EmployeeID.Location = new System.Drawing.Point(25, 27);
            this.AddEmployee_EmployeeID.Name = "AddEmployee_EmployeeID";
            this.AddEmployee_EmployeeID.PasswordChar = '\0';
            this.AddEmployee_EmployeeID.Radius = 10;
            this.AddEmployee_EmployeeID.Size = new System.Drawing.Size(233, 27);
            this.AddEmployee_EmployeeID.TabIndex = 0;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(62)))));
            this.label.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(22, 8);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(88, 16);
            this.label.TabIndex = 63;
            this.label.Text = "Employee ID";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(28)))), ((int)(((byte)(46)))));
            this.Controls.Add(this.gunaElipsePanel1);
            this.Controls.Add(this.gunaElipsePanel2);
            this.Name = "AddEmployee";
            this.Size = new System.Drawing.Size(779, 547);
            this.Load += new System.EventHandler(this.AddEmployee_Load);
            this.gunaElipsePanel2.ResumeLayout(false);
            this.gunaElipsePanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emp_displaydata)).EndInit();
            this.gunaElipsePanel1.ResumeLayout(false);
            this.gunaElipsePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView emp_displaydata;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private Guna.UI.WinForms.GunaTextBox AddEmployee_PhoneNumber;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private Guna.UI.WinForms.GunaTextBox AddEmployee_Fullname;
        private Guna.UI.WinForms.GunaTextBox AddEmployee_EmployeeID;
        private System.Windows.Forms.Label label;
        private Guna.UI.WinForms.GunaAdvenceButton AddEmployeeButton;
        private Guna.UI.WinForms.GunaAdvenceButton AddEmployee_Delete;
        private Guna.UI.WinForms.GunaAdvenceButton AddEmployee_Update;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaAdvenceButton AddEmployee_Clear;
        private Guna.UI.WinForms.GunaComboBox AddEmployee_Position;
        private Guna.UI.WinForms.GunaComboBox AddEmployee_Gender;
        private Guna.UI.WinForms.GunaComboBox AddEmployee_Status;
        private Guna.UI.WinForms.GunaTextBox AddEmployee_Password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaComboBox AddEmployee_DepartmentID;
        private ErrorProvider errorProvider1;
		private Guna.UI.WinForms.GunaComboBox AddEmployee_MGR;
	}
}
