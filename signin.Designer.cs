namespace Employee_Management_System
{
    partial class signin
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(signin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.exit = new System.Windows.Forms.PictureBox();
            this.login_button = new Guna.UI.WinForms.GunaAdvenceButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.password = new Guna.UI.WinForms.GunaTextBox();
            this.EmployeeID = new Guna.UI.WinForms.GunaTextBox();
            this.label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(28)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 423);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(194)))), ((int)(((byte)(239)))));
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(194)))), ((int)(((byte)(239)))));
            this.panel3.Location = new System.Drawing.Point(276, 11);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2, 400);
            this.panel3.TabIndex = 76;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::Employee_Management_System.Properties.Resources._221;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 423);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(28)))), ((int)(((byte)(46)))));
            this.panel2.Controls.Add(this.exit);
            this.panel2.Controls.Add(this.login_button);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.password);
            this.panel2.Controls.Add(this.EmployeeID);
            this.panel2.Controls.Add(this.label);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(279, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(305, 423);
            this.panel2.TabIndex = 1;
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.Image = global::Employee_Management_System.Properties.Resources.icons8_cross_30;
            this.exit.Location = new System.Drawing.Point(263, 12);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(30, 30);
            this.exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.exit.TabIndex = 75;
            this.exit.TabStop = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // login_button
            // 
            this.login_button.AnimationHoverSpeed = 0.07F;
            this.login_button.AnimationSpeed = 0.03F;
            this.login_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(28)))), ((int)(((byte)(46)))));
            this.login_button.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(128)))));
            this.login_button.BorderColor = System.Drawing.Color.Transparent;
            this.login_button.BorderSize = 1;
            this.login_button.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(128)))));
            this.login_button.CheckedBorderColor = System.Drawing.Color.Black;
            this.login_button.CheckedForeColor = System.Drawing.Color.Transparent;
            this.login_button.CheckedImage = null;
            this.login_button.CheckedLineColor = System.Drawing.Color.DimGray;
            this.login_button.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.login_button.ForeColor = System.Drawing.Color.White;
            this.login_button.Image = null;
            this.login_button.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.login_button.ImageSize = new System.Drawing.Size(20, 20);
            this.login_button.LineColor = System.Drawing.Color.White;
            this.login_button.Location = new System.Drawing.Point(31, 298);
            this.login_button.Name = "login_button";
            this.login_button.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(128)))));
            this.login_button.OnHoverBorderColor = System.Drawing.Color.Black;
            this.login_button.OnHoverForeColor = System.Drawing.Color.White;
            this.login_button.OnHoverImage = null;
            this.login_button.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(128)))));
            this.login_button.OnPressedColor = System.Drawing.Color.Black;
            this.login_button.Radius = 12;
            this.login_button.Size = new System.Drawing.Size(233, 28);
            this.login_button.TabIndex = 2;
            this.login_button.Text = "Login";
            this.login_button.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(28)))), ((int)(((byte)(46)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(29, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 30);
            this.label1.TabIndex = 73;
            this.label1.Text = "LOGIN";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(28)))), ((int)(((byte)(46)))));
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(31, 210);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 16);
            this.label11.TabIndex = 72;
            this.label11.Text = "Password";
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.Transparent;
            this.password.BaseColor = System.Drawing.Color.White;
            this.password.BorderColor = System.Drawing.Color.Silver;
            this.password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password.FocusedBaseColor = System.Drawing.Color.White;
            this.password.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.password.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.password.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.password.Location = new System.Drawing.Point(31, 234);
            this.password.Name = "password";
            this.password.PasswordChar = '\0';
            this.password.Radius = 10;
            this.password.Size = new System.Drawing.Size(233, 27);
            this.password.TabIndex = 1;
            this.password.Click += new System.EventHandler(this.password_Click);
            // 
            // EmployeeID
            // 
            this.EmployeeID.BackColor = System.Drawing.Color.Transparent;
            this.EmployeeID.BaseColor = System.Drawing.Color.White;
            this.EmployeeID.BorderColor = System.Drawing.Color.Silver;
            this.EmployeeID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmployeeID.FocusedBaseColor = System.Drawing.Color.White;
            this.EmployeeID.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.EmployeeID.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.EmployeeID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.EmployeeID.Location = new System.Drawing.Point(31, 170);
            this.EmployeeID.Name = "EmployeeID";
            this.EmployeeID.PasswordChar = '\0';
            this.EmployeeID.Radius = 10;
            this.EmployeeID.Size = new System.Drawing.Size(233, 27);
            this.EmployeeID.TabIndex = 0;
            this.EmployeeID.Click += new System.EventHandler(this.EmployeeID_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(28)))), ((int)(((byte)(46)))));
            this.label.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(31, 147);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(88, 16);
            this.label.TabIndex = 71;
            this.label.Text = "Employee ID";
            // 
            // signin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 423);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "signin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "signin";
            this.Load += new System.EventHandler(this.signin_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CustomControls.RJControls.RJButton rjButton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private Guna.UI.WinForms.GunaTextBox password;
        private Guna.UI.WinForms.GunaTextBox EmployeeID;
        private System.Windows.Forms.Label label;
        private Guna.UI.WinForms.GunaAdvenceButton login_button;
        private System.Windows.Forms.PictureBox exit;
        private System.Windows.Forms.Panel panel3;
    }
}