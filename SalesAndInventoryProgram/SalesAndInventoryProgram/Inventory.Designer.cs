
namespace SalesAndInventoryProgram
{
    partial class Inventory
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
            panel1 = new System.Windows.Forms.Panel();
            panel5 = new System.Windows.Forms.Panel();
            groupBox1 = new System.Windows.Forms.GroupBox();
            tbsearch = new System.Windows.Forms.TextBox();
            panel3 = new System.Windows.Forms.Panel();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            btnAddProduct = new System.Windows.Forms.Button();
            btnUpdatePrice = new System.Windows.Forms.Button();
            btnDeleteProd = new System.Windows.Forms.Button();
            btnUpdateQuantity = new System.Windows.Forms.Button();
            panel4 = new System.Windows.Forms.Panel();
            btnUpdatePassword = new System.Windows.Forms.Button();
            btnInventory = new System.Windows.Forms.Button();
            btnSales = new System.Windows.Forms.Button();
            btnEmployees = new System.Windows.Forms.Button();
            btnSignOut = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            panel2 = new System.Windows.Forms.Panel();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            groupBox1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.White;
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel2);
            panel1.Location = new System.Drawing.Point(-6, -15);
            panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1355, 1081);
            panel1.TabIndex = 5;
            // 
            // panel5
            // 
            panel5.BackColor = System.Drawing.Color.Transparent;
            panel5.BackgroundImage = Properties.Resources.bg1;
            panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            panel5.Controls.Add(groupBox1);
            panel5.Controls.Add(panel3);
            panel5.Controls.Add(btnAddProduct);
            panel5.Controls.Add(btnUpdatePrice);
            panel5.Controls.Add(btnDeleteProd);
            panel5.Controls.Add(btnUpdateQuantity);
            panel5.Location = new System.Drawing.Point(322, 21);
            panel5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new System.Drawing.Size(1017, 860);
            panel5.TabIndex = 21;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbsearch);
            groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            groupBox1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            groupBox1.ForeColor = System.Drawing.Color.White;
            groupBox1.Location = new System.Drawing.Point(47, 43);
            groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox1.Size = new System.Drawing.Size(920, 105);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search";
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
            // panel3
            // 
            panel3.BackColor = System.Drawing.Color.White;
            panel3.Controls.Add(dataGridView1);
            panel3.Location = new System.Drawing.Point(47, 204);
            panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(920, 465);
            panel3.TabIndex = 14;
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
            dataGridView1.Size = new System.Drawing.Size(920, 465);
            dataGridView1.TabIndex = 13;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
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
            // btnAddProduct
            // 
            btnAddProduct.BackColor = System.Drawing.Color.FromArgb(79, 154, 255);
            btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnAddProduct.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnAddProduct.ForeColor = System.Drawing.Color.White;
            btnAddProduct.Location = new System.Drawing.Point(779, 725);
            btnAddProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new System.Drawing.Size(187, 91);
            btnAddProduct.TabIndex = 19;
            btnAddProduct.Text = "Add Product";
            btnAddProduct.UseVisualStyleBackColor = false;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // btnUpdatePrice
            // 
            btnUpdatePrice.BackColor = System.Drawing.Color.FromArgb(79, 154, 255);
            btnUpdatePrice.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnUpdatePrice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnUpdatePrice.ForeColor = System.Drawing.Color.White;
            btnUpdatePrice.Location = new System.Drawing.Point(565, 725);
            btnUpdatePrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnUpdatePrice.Name = "btnUpdatePrice";
            btnUpdatePrice.Size = new System.Drawing.Size(195, 91);
            btnUpdatePrice.TabIndex = 18;
            btnUpdatePrice.Text = "Update Price";
            btnUpdatePrice.UseVisualStyleBackColor = false;
            btnUpdatePrice.Click += btnUpdatePrice_Click;
            // 
            // btnDeleteProd
            // 
            btnDeleteProd.BackColor = System.Drawing.Color.RoyalBlue;
            btnDeleteProd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnDeleteProd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnDeleteProd.ForeColor = System.Drawing.Color.White;
            btnDeleteProd.Location = new System.Drawing.Point(47, 725);
            btnDeleteProd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnDeleteProd.Name = "btnDeleteProd";
            btnDeleteProd.Size = new System.Drawing.Size(216, 91);
            btnDeleteProd.TabIndex = 16;
            btnDeleteProd.Text = "Delete Product";
            btnDeleteProd.UseVisualStyleBackColor = false;
            // 
            // btnUpdateQuantity
            // 
            btnUpdateQuantity.BackColor = System.Drawing.Color.FromArgb(79, 154, 255);
            btnUpdateQuantity.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnUpdateQuantity.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnUpdateQuantity.ForeColor = System.Drawing.Color.White;
            btnUpdateQuantity.Location = new System.Drawing.Point(325, 725);
            btnUpdateQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnUpdateQuantity.Name = "btnUpdateQuantity";
            btnUpdateQuantity.Size = new System.Drawing.Size(216, 91);
            btnUpdateQuantity.TabIndex = 17;
            btnUpdateQuantity.Text = "Update Quantity";
            btnUpdateQuantity.UseVisualStyleBackColor = false;
            btnUpdateQuantity.Click += btnUpdateQuantity_Click;
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
            // btnUpdatePassword
            // 
            btnUpdatePassword.BackColor = System.Drawing.Color.FromArgb(79, 154, 255);
            btnUpdatePassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnUpdatePassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnUpdatePassword.ForeColor = System.Drawing.Color.White;
            btnUpdatePassword.Location = new System.Drawing.Point(35, 492);
            btnUpdatePassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnUpdatePassword.Name = "btnUpdatePassword";
            btnUpdatePassword.Size = new System.Drawing.Size(243, 91);
            btnUpdatePassword.TabIndex = 16;
            btnUpdatePassword.Text = "Update Password";
            btnUpdatePassword.UseVisualStyleBackColor = false;
            btnUpdatePassword.Click += button1_Click;
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
            btnSales.Location = new System.Drawing.Point(35, 382);
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
            btnEmployees.Location = new System.Drawing.Point(35, 603);
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
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.FromArgb(110, 172, 254);
            panel2.Location = new System.Drawing.Point(306, 21);
            panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(10, 860);
            panel2.TabIndex = 11;
            // 
            // Inventory
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(1339, 876);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "Inventory";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Inventory";
            FormClosed += Inventory_FormClosed;
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbsearch;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnUpdatePrice;
        private System.Windows.Forms.Button btnDeleteProd;
        private System.Windows.Forms.Button btnUpdateQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.Button btnUpdatePassword;
    }
}