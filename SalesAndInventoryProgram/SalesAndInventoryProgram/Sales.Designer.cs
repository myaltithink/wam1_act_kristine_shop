
namespace SalesAndInventoryProgram
{
    partial class Sales
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
            pictureBox1 = new System.Windows.Forms.PictureBox();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            tbsearch = new System.Windows.Forms.TextBox();
            groupBox1 = new System.Windows.Forms.GroupBox();
            panel3 = new System.Windows.Forms.Panel();
            panel2 = new System.Windows.Forms.Panel();
            btnInventory = new System.Windows.Forms.Button();
            btnSales = new System.Windows.Forms.Button();
            btnEmployees = new System.Windows.Forms.Button();
            btnSignOut = new System.Windows.Forms.Button();
            panel4 = new System.Windows.Forms.Panel();
            btnCreateSale = new System.Windows.Forms.Button();
            btnDeleteSale = new System.Windows.Forms.Button();
            panel5 = new System.Windows.Forms.Panel();
            panel1 = new System.Windows.Forms.Panel();
            panel6 = new System.Windows.Forms.Panel();
            groupBox2 = new System.Windows.Forms.GroupBox();
            TotalSales = new System.Windows.Forms.Label();
            btnUpdatePassword = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.logo;
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pictureBox1.Location = new System.Drawing.Point(58, 9);
            pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(205, 256);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { ProductID, ItemName, Category, Price, Quantity });
            dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridView1.Location = new System.Drawing.Point(0, 0);
            dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.Size = new System.Drawing.Size(920, 373);
            dataGridView1.TabIndex = 13;
            // 
            // ProductID
            // 
            ProductID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            ProductID.HeaderText = "Product ID";
            ProductID.MinimumWidth = 6;
            ProductID.Name = "ProductID";
            // 
            // ItemName
            // 
            ItemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            ItemName.HeaderText = "Item Name";
            ItemName.MinimumWidth = 6;
            ItemName.Name = "ItemName";
            // 
            // Category
            // 
            Category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            Category.HeaderText = "Category";
            Category.MinimumWidth = 6;
            Category.Name = "Category";
            // 
            // Price
            // 
            Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            Price.HeaderText = "Price";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            // 
            // Quantity
            // 
            Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            Quantity.HeaderText = "Quantity";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            // 
            // tbsearch
            // 
            tbsearch.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tbsearch.Location = new System.Drawing.Point(29, 44);
            tbsearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tbsearch.Name = "tbsearch";
            tbsearch.Size = new System.Drawing.Size(863, 36);
            tbsearch.TabIndex = 0;
            tbsearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbsearch);
            groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            groupBox1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            groupBox1.ForeColor = System.Drawing.Color.White;
            groupBox1.Location = new System.Drawing.Point(47, 27);
            groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox1.Size = new System.Drawing.Size(920, 105);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search";
            // 
            // panel3
            // 
            panel3.BackColor = System.Drawing.Color.White;
            panel3.Controls.Add(dataGridView1);
            panel3.Location = new System.Drawing.Point(47, 152);
            panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(920, 373);
            panel3.TabIndex = 14;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.FromArgb(110, 172, 254);
            panel2.Location = new System.Drawing.Point(306, 21);
            panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(10, 860);
            panel2.TabIndex = 11;
            // 
            // btnInventory
            // 
            btnInventory.BackColor = System.Drawing.Color.FromArgb(79, 154, 255);
            btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnInventory.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnInventory.ForeColor = System.Drawing.Color.White;
            btnInventory.Location = new System.Drawing.Point(35, 276);
            btnInventory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnInventory.Name = "btnInventory";
            btnInventory.Size = new System.Drawing.Size(243, 91);
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
            btnSales.Location = new System.Drawing.Point(35, 385);
            btnSales.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnSales.Name = "btnSales";
            btnSales.Size = new System.Drawing.Size(243, 91);
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
            btnEmployees.Location = new System.Drawing.Point(35, 609);
            btnEmployees.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnEmployees.Name = "btnEmployees";
            btnEmployees.Size = new System.Drawing.Size(243, 91);
            btnEmployees.TabIndex = 9;
            btnEmployees.Text = "Employees";
            btnEmployees.UseVisualStyleBackColor = false;
            btnEmployees.Click += btnEmployees_Click;
            // 
            // btnSignOut
            // 
            btnSignOut.BackColor = System.Drawing.Color.FromArgb(153, 108, 230);
            btnSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSignOut.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnSignOut.ForeColor = System.Drawing.Color.White;
            btnSignOut.Location = new System.Drawing.Point(35, 719);
            btnSignOut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnSignOut.Name = "btnSignOut";
            btnSignOut.Size = new System.Drawing.Size(243, 91);
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
            panel4.Location = new System.Drawing.Point(3, 21);
            panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(313, 860);
            panel4.TabIndex = 20;
            // 
            // btnCreateSale
            // 
            btnCreateSale.BackColor = System.Drawing.Color.FromArgb(79, 154, 255);
            btnCreateSale.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnCreateSale.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnCreateSale.ForeColor = System.Drawing.Color.White;
            btnCreateSale.Location = new System.Drawing.Point(751, 563);
            btnCreateSale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnCreateSale.Name = "btnCreateSale";
            btnCreateSale.Size = new System.Drawing.Size(216, 91);
            btnCreateSale.TabIndex = 19;
            btnCreateSale.Text = "Create Sale";
            btnCreateSale.UseVisualStyleBackColor = false;
            btnCreateSale.Click += btnCreateSale_Click;
            // 
            // btnDeleteSale
            // 
            btnDeleteSale.BackColor = System.Drawing.Color.RoyalBlue;
            btnDeleteSale.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnDeleteSale.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnDeleteSale.ForeColor = System.Drawing.Color.White;
            btnDeleteSale.Location = new System.Drawing.Point(47, 563);
            btnDeleteSale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnDeleteSale.Name = "btnDeleteSale";
            btnDeleteSale.Size = new System.Drawing.Size(216, 91);
            btnDeleteSale.TabIndex = 16;
            btnDeleteSale.Text = "Delete Sale";
            btnDeleteSale.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            panel5.BackColor = System.Drawing.Color.Transparent;
            panel5.BackgroundImage = Properties.Resources.bg1;
            panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            panel5.Controls.Add(groupBox1);
            panel5.Controls.Add(panel3);
            panel5.Controls.Add(btnCreateSale);
            panel5.Controls.Add(btnDeleteSale);
            panel5.Location = new System.Drawing.Point(322, 193);
            panel5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new System.Drawing.Size(1017, 688);
            panel5.TabIndex = 21;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.White;
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel2);
            panel1.Location = new System.Drawing.Point(-6, -15);
            panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1355, 1081);
            panel1.TabIndex = 6;
            // 
            // panel6
            // 
            panel6.BackColor = System.Drawing.Color.Navy;
            panel6.Controls.Add(groupBox2);
            panel6.Location = new System.Drawing.Point(322, 21);
            panel6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel6.Name = "panel6";
            panel6.Size = new System.Drawing.Size(1017, 165);
            panel6.TabIndex = 25;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(TotalSales);
            groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            groupBox2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            groupBox2.ForeColor = System.Drawing.Color.White;
            groupBox2.Location = new System.Drawing.Point(47, 23);
            groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox2.Size = new System.Drawing.Size(920, 116);
            groupBox2.TabIndex = 25;
            groupBox2.TabStop = false;
            groupBox2.Text = "TOTAL SALES";
            // 
            // TotalSales
            // 
            TotalSales.AutoSize = true;
            TotalSales.BackColor = System.Drawing.Color.Transparent;
            TotalSales.Dock = System.Windows.Forms.DockStyle.Fill;
            TotalSales.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            TotalSales.Font = new System.Drawing.Font("Century Schoolbook", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            TotalSales.ForeColor = System.Drawing.Color.White;
            TotalSales.Location = new System.Drawing.Point(3, 33);
            TotalSales.Name = "TotalSales";
            TotalSales.Padding = new System.Windows.Forms.Padding(10, 12, 10, 12);
            TotalSales.Size = new System.Drawing.Size(91, 58);
            TotalSales.TabIndex = 24;
            TotalSales.Text = "0.00";
            TotalSales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnUpdatePassword
            // 
            btnUpdatePassword.BackColor = System.Drawing.Color.FromArgb(79, 154, 255);
            btnUpdatePassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnUpdatePassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnUpdatePassword.ForeColor = System.Drawing.Color.White;
            btnUpdatePassword.Location = new System.Drawing.Point(35, 496);
            btnUpdatePassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnUpdatePassword.Name = "btnUpdatePassword";
            btnUpdatePassword.Size = new System.Drawing.Size(243, 91);
            btnUpdatePassword.TabIndex = 17;
            btnUpdatePassword.Text = "Update Password";
            btnUpdatePassword.UseVisualStyleBackColor = false;
            btnUpdatePassword.Click += btnUpdatePassword_Click;
            // 
            // Sales
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1339, 876);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "Sales";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Sales";
            FormClosed += Sales_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbsearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnCreateSale;
        private System.Windows.Forms.Button btnDeleteSale;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label TotalSales;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.Button btnUpdatePassword;
    }
}