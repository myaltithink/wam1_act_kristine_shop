
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
            saleList = new System.Windows.Forms.DataGridView();
            Sale_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            tbsearch = new System.Windows.Forms.TextBox();
            groupBox1 = new System.Windows.Forms.GroupBox();
            panel3 = new System.Windows.Forms.Panel();
            panel2 = new System.Windows.Forms.Panel();
            btnInventory = new System.Windows.Forms.Button();
            btnSales = new System.Windows.Forms.Button();
            btnEmployees = new System.Windows.Forms.Button();
            btnSignOut = new System.Windows.Forms.Button();
            panel4 = new System.Windows.Forms.Panel();
            btnUpdatePassword = new System.Windows.Forms.Button();
            btnCreateSale = new System.Windows.Forms.Button();
            btnDeleteSale = new System.Windows.Forms.Button();
            panel5 = new System.Windows.Forms.Panel();
            panel1 = new System.Windows.Forms.Panel();
            panel6 = new System.Windows.Forms.Panel();
            groupBox2 = new System.Windows.Forms.GroupBox();
            TotalSales = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)saleList).BeginInit();
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
            pictureBox1.Location = new System.Drawing.Point(51, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(179, 192);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // saleList
            // 
            saleList.BackgroundColor = System.Drawing.Color.White;
            saleList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            saleList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Sale_ID, ProductID, ItemName, Quantity, Price, Total });
            saleList.Dock = System.Windows.Forms.DockStyle.Fill;
            saleList.Location = new System.Drawing.Point(0, 0);
            saleList.MultiSelect = false;
            saleList.Name = "saleList";
            saleList.ReadOnly = true;
            saleList.RowHeadersWidth = 51;
            saleList.RowTemplate.Height = 24;
            saleList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            saleList.Size = new System.Drawing.Size(805, 280);
            saleList.TabIndex = 13;
            // 
            // Sale_ID
            // 
            Sale_ID.HeaderText = "Sale ID";
            Sale_ID.Name = "Sale_ID";
            Sale_ID.ReadOnly = true;
            // 
            // ProductID
            // 
            ProductID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            ProductID.HeaderText = "Product ID";
            ProductID.MinimumWidth = 6;
            ProductID.Name = "ProductID";
            ProductID.ReadOnly = true;
            // 
            // ItemName
            // 
            ItemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            ItemName.HeaderText = "Item Name";
            ItemName.MinimumWidth = 6;
            ItemName.Name = "ItemName";
            ItemName.ReadOnly = true;
            // 
            // Quantity
            // 
            Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            Quantity.HeaderText = "Quantity";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            Quantity.ReadOnly = true;
            // 
            // Price
            // 
            Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            Price.HeaderText = "Price";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            Price.ReadOnly = true;
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.Name = "Total";
            Total.ReadOnly = true;
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
            // groupBox1
            // 
            groupBox1.Controls.Add(tbsearch);
            groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            groupBox1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            groupBox1.ForeColor = System.Drawing.Color.White;
            groupBox1.Location = new System.Drawing.Point(41, 20);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(805, 79);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search";
            // 
            // panel3
            // 
            panel3.BackColor = System.Drawing.Color.White;
            panel3.Controls.Add(saleList);
            panel3.Location = new System.Drawing.Point(41, 114);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(805, 280);
            panel3.TabIndex = 14;
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
            btnSales.Location = new System.Drawing.Point(31, 289);
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
            btnEmployees.Click += btnEmployees_Click;
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
            btnUpdatePassword.Location = new System.Drawing.Point(31, 372);
            btnUpdatePassword.Name = "btnUpdatePassword";
            btnUpdatePassword.Size = new System.Drawing.Size(213, 68);
            btnUpdatePassword.TabIndex = 17;
            btnUpdatePassword.Text = "Update Password";
            btnUpdatePassword.UseVisualStyleBackColor = false;
            btnUpdatePassword.Click += btnUpdatePassword_Click;
            // 
            // btnCreateSale
            // 
            btnCreateSale.BackColor = System.Drawing.Color.FromArgb(79, 154, 255);
            btnCreateSale.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnCreateSale.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnCreateSale.ForeColor = System.Drawing.Color.White;
            btnCreateSale.Location = new System.Drawing.Point(657, 422);
            btnCreateSale.Name = "btnCreateSale";
            btnCreateSale.Size = new System.Drawing.Size(189, 68);
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
            btnDeleteSale.Location = new System.Drawing.Point(41, 422);
            btnDeleteSale.Name = "btnDeleteSale";
            btnDeleteSale.Size = new System.Drawing.Size(189, 68);
            btnDeleteSale.TabIndex = 16;
            btnDeleteSale.Text = "Delete Sale";
            btnDeleteSale.UseVisualStyleBackColor = false;
            btnDeleteSale.Click += btnDeleteSale_Click;
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
            panel5.Location = new System.Drawing.Point(282, 145);
            panel5.Name = "panel5";
            panel5.Size = new System.Drawing.Size(890, 516);
            panel5.TabIndex = 21;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.White;
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel2);
            panel1.Location = new System.Drawing.Point(-5, -11);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1186, 811);
            panel1.TabIndex = 6;
            // 
            // panel6
            // 
            panel6.BackColor = System.Drawing.Color.Navy;
            panel6.Controls.Add(groupBox2);
            panel6.Location = new System.Drawing.Point(282, 16);
            panel6.Name = "panel6";
            panel6.Size = new System.Drawing.Size(890, 124);
            panel6.TabIndex = 25;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(TotalSales);
            groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            groupBox2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            groupBox2.ForeColor = System.Drawing.Color.White;
            groupBox2.Location = new System.Drawing.Point(41, 17);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(805, 87);
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
            TotalSales.Location = new System.Drawing.Point(3, 26);
            TotalSales.Name = "TotalSales";
            TotalSales.Padding = new System.Windows.Forms.Padding(9);
            TotalSales.Size = new System.Drawing.Size(75, 44);
            TotalSales.TabIndex = 24;
            TotalSales.Text = "0.00";
            TotalSales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Sales
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1172, 657);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "Sales";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Sales";
            FormClosed += Sales_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)saleList).EndInit();
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
        private System.Windows.Forms.DataGridView saleList;
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
        private System.Windows.Forms.Button btnUpdatePassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sale_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}