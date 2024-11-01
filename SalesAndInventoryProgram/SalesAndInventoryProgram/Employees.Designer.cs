﻿
namespace SalesAndInventoryProgram
{
    partial class Employees
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
            panel2 = new System.Windows.Forms.Panel();
            btnInventory = new System.Windows.Forms.Button();
            btnSales = new System.Windows.Forms.Button();
            btnEmployees = new System.Windows.Forms.Button();
            btnSignOut = new System.Windows.Forms.Button();
            panel4 = new System.Windows.Forms.Panel();
            btnUpdatePassword = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            panel1 = new System.Windows.Forms.Panel();
            panel5 = new System.Windows.Forms.Panel();
            groupBox1 = new System.Windows.Forms.GroupBox();
            tbsearch = new System.Windows.Forms.TextBox();
            panel3 = new System.Windows.Forms.Panel();
            employeeList = new System.Windows.Forms.DataGridView();
            EmployeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            btnAddEmployee = new System.Windows.Forms.Button();
            btnResetPass = new System.Windows.Forms.Button();
            btnDisableAcc = new System.Windows.Forms.Button();
            btnEnableAcc = new System.Windows.Forms.Button();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            groupBox1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)employeeList).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.FromArgb(110, 172, 254);
            panel2.Location = new System.Drawing.Point(268, 16);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(9, 645);
            panel2.TabIndex = 11;
            // 
            // btnInventory
            // 
            btnInventory.BackColor = System.Drawing.Color.FromArgb(79, 154, 255);
            btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnInventory.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnInventory.ForeColor = System.Drawing.Color.White;
            btnInventory.Location = new System.Drawing.Point(31, 207);
            btnInventory.Name = "btnInventory";
            btnInventory.Size = new System.Drawing.Size(213, 68);
            btnInventory.TabIndex = 7;
            btnInventory.Text = "Inventory";
            btnInventory.UseVisualStyleBackColor = false;
            btnInventory.Click += btnInventory_Click;
            // 
            // btnSales
            // 
            btnSales.BackColor = System.Drawing.Color.FromArgb(79, 154, 255);
            btnSales.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnSales.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnSales.ForeColor = System.Drawing.Color.White;
            btnSales.Location = new System.Drawing.Point(31, 291);
            btnSales.Name = "btnSales";
            btnSales.Size = new System.Drawing.Size(213, 68);
            btnSales.TabIndex = 8;
            btnSales.Text = "Sales";
            btnSales.UseVisualStyleBackColor = false;
            btnSales.Click += btnSales_Click;
            // 
            // btnEmployees
            // 
            btnEmployees.BackColor = System.Drawing.Color.FromArgb(79, 154, 255);
            btnEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnEmployees.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnEmployees.ForeColor = System.Drawing.Color.White;
            btnEmployees.Location = new System.Drawing.Point(31, 457);
            btnEmployees.Name = "btnEmployees";
            btnEmployees.Size = new System.Drawing.Size(213, 68);
            btnEmployees.TabIndex = 9;
            btnEmployees.Text = "Employees";
            btnEmployees.UseVisualStyleBackColor = false;
            // 
            // btnSignOut
            // 
            btnSignOut.BackColor = System.Drawing.Color.FromArgb(153, 108, 230);
            btnSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSignOut.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnSignOut.ForeColor = System.Drawing.Color.White;
            btnSignOut.Location = new System.Drawing.Point(31, 539);
            btnSignOut.Name = "btnSignOut";
            btnSignOut.Size = new System.Drawing.Size(213, 68);
            btnSignOut.TabIndex = 10;
            btnSignOut.Text = "Sign Out";
            btnSignOut.UseVisualStyleBackColor = false;
            btnSignOut.Click += btnSignOut_Click;
            // 
            // panel4
            // 
            panel4.BackColor = System.Drawing.Color.FromArgb(0, 74, 173);
            panel4.Controls.Add(btnUpdatePassword);
            panel4.Controls.Add(btnInventory);
            panel4.Controls.Add(btnSales);
            panel4.Controls.Add(btnEmployees);
            panel4.Controls.Add(btnSignOut);
            panel4.Controls.Add(pictureBox1);
            panel4.Location = new System.Drawing.Point(3, 16);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(274, 645);
            panel4.TabIndex = 20;
            // 
            // btnUpdatePassword
            // 
            btnUpdatePassword.BackColor = System.Drawing.Color.FromArgb(79, 154, 255);
            btnUpdatePassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnUpdatePassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnUpdatePassword.ForeColor = System.Drawing.Color.White;
            btnUpdatePassword.Location = new System.Drawing.Point(31, 374);
            btnUpdatePassword.Name = "btnUpdatePassword";
            btnUpdatePassword.Size = new System.Drawing.Size(213, 68);
            btnUpdatePassword.TabIndex = 17;
            btnUpdatePassword.Text = "Update Password";
            btnUpdatePassword.UseVisualStyleBackColor = false;
            btnUpdatePassword.Click += btnUpdatePassword_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.logo;
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pictureBox1.Location = new System.Drawing.Point(51, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(179, 192);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.White;
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel2);
            panel1.Location = new System.Drawing.Point(-5, -11);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1186, 811);
            panel1.TabIndex = 6;
            // 
            // panel5
            // 
            panel5.BackColor = System.Drawing.Color.Transparent;
            panel5.BackgroundImage = Properties.Resources.bg1;
            panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            panel5.Controls.Add(groupBox1);
            panel5.Controls.Add(panel3);
            panel5.Controls.Add(btnAddEmployee);
            panel5.Controls.Add(btnResetPass);
            panel5.Controls.Add(btnDisableAcc);
            panel5.Controls.Add(btnEnableAcc);
            panel5.Location = new System.Drawing.Point(282, 16);
            panel5.Name = "panel5";
            panel5.Size = new System.Drawing.Size(890, 645);
            panel5.TabIndex = 21;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbsearch);
            groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            groupBox1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            groupBox1.ForeColor = System.Drawing.Color.White;
            groupBox1.Location = new System.Drawing.Point(41, 32);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(805, 79);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search";
            // 
            // tbsearch
            // 
            tbsearch.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tbsearch.Location = new System.Drawing.Point(25, 33);
            tbsearch.Name = "tbsearch";
            tbsearch.Size = new System.Drawing.Size(756, 30);
            tbsearch.TabIndex = 0;
            tbsearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            tbsearch.TextChanged += tbsearch_TextChanged;
            // 
            // panel3
            // 
            panel3.BackColor = System.Drawing.Color.White;
            panel3.Controls.Add(employeeList);
            panel3.Location = new System.Drawing.Point(41, 153);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(805, 349);
            panel3.TabIndex = 14;
            // 
            // employeeList
            // 
            employeeList.BackgroundColor = System.Drawing.Color.White;
            employeeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            employeeList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { EmployeeID, FirstName, LastName, Username, Status });
            employeeList.Dock = System.Windows.Forms.DockStyle.Fill;
            employeeList.Location = new System.Drawing.Point(0, 0);
            employeeList.MultiSelect = false;
            employeeList.Name = "employeeList";
            employeeList.ReadOnly = true;
            employeeList.RowHeadersWidth = 51;
            employeeList.RowTemplate.Height = 24;
            employeeList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            employeeList.Size = new System.Drawing.Size(805, 349);
            employeeList.TabIndex = 13;
            // 
            // EmployeeID
            // 
            EmployeeID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            EmployeeID.HeaderText = "Employee ID";
            EmployeeID.MinimumWidth = 6;
            EmployeeID.Name = "EmployeeID";
            EmployeeID.ReadOnly = true;
            // 
            // FirstName
            // 
            FirstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            FirstName.HeaderText = "First Name";
            FirstName.MinimumWidth = 6;
            FirstName.Name = "FirstName";
            FirstName.ReadOnly = true;
            // 
            // LastName
            // 
            LastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            LastName.HeaderText = "Last Name";
            LastName.MinimumWidth = 6;
            LastName.Name = "LastName";
            LastName.ReadOnly = true;
            // 
            // Username
            // 
            Username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            Username.HeaderText = "Username";
            Username.MinimumWidth = 6;
            Username.Name = "Username";
            Username.ReadOnly = true;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.ReadOnly = true;
            Status.Width = 125;
            // 
            // btnAddEmployee
            // 
            btnAddEmployee.BackColor = System.Drawing.Color.FromArgb(79, 154, 255);
            btnAddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnAddEmployee.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnAddEmployee.ForeColor = System.Drawing.Color.White;
            btnAddEmployee.Location = new System.Drawing.Point(682, 544);
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.Size = new System.Drawing.Size(164, 68);
            btnAddEmployee.TabIndex = 19;
            btnAddEmployee.Text = "Add Employee";
            btnAddEmployee.UseVisualStyleBackColor = false;
            btnAddEmployee.Click += btnAddEmployee_Click;
            // 
            // btnResetPass
            // 
            btnResetPass.BackColor = System.Drawing.Color.FromArgb(79, 154, 255);
            btnResetPass.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnResetPass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnResetPass.ForeColor = System.Drawing.Color.White;
            btnResetPass.Location = new System.Drawing.Point(493, 544);
            btnResetPass.Name = "btnResetPass";
            btnResetPass.Size = new System.Drawing.Size(171, 68);
            btnResetPass.TabIndex = 18;
            btnResetPass.Text = "Reset Password";
            btnResetPass.UseVisualStyleBackColor = false;
            btnResetPass.Click += btnResetPass_Click;
            // 
            // btnDisableAcc
            // 
            btnDisableAcc.BackColor = System.Drawing.Color.RoyalBlue;
            btnDisableAcc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnDisableAcc.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnDisableAcc.ForeColor = System.Drawing.Color.White;
            btnDisableAcc.Location = new System.Drawing.Point(41, 544);
            btnDisableAcc.Name = "btnDisableAcc";
            btnDisableAcc.Size = new System.Drawing.Size(189, 68);
            btnDisableAcc.TabIndex = 16;
            btnDisableAcc.Text = "Disable Account";
            btnDisableAcc.UseVisualStyleBackColor = false;
            btnDisableAcc.Click += btnDisableAcc_Click;
            // 
            // btnEnableAcc
            // 
            btnEnableAcc.BackColor = System.Drawing.Color.FromArgb(79, 154, 255);
            btnEnableAcc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnEnableAcc.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnEnableAcc.ForeColor = System.Drawing.Color.White;
            btnEnableAcc.Location = new System.Drawing.Point(284, 544);
            btnEnableAcc.Name = "btnEnableAcc";
            btnEnableAcc.Size = new System.Drawing.Size(189, 68);
            btnEnableAcc.TabIndex = 17;
            btnEnableAcc.Text = "Enable Account";
            btnEnableAcc.UseVisualStyleBackColor = false;
            btnEnableAcc.Click += btnEnableAcc_Click;
            // 
            // Employees
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1172, 657);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "Employees";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Employees";
            FormClosed += Employees_FormClosed;
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)employeeList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView employeeList;
        private System.Windows.Forms.TextBox tbsearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnEnableAcc;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button btnResetPass;
        private System.Windows.Forms.Button btnDisableAcc;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Button btnUpdatePassword;
    }
}