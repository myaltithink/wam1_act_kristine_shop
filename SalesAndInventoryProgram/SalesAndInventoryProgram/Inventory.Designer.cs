﻿
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
            productList = new System.Windows.Forms.DataGridView();
            ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            btnAddProduct = new System.Windows.Forms.Button();
            btnUpdatePrice = new System.Windows.Forms.Button();
            btnUpdateProd = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)productList).BeginInit();
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
            panel1.Location = new System.Drawing.Point(-5, -11);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1186, 811);
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
            panel5.Controls.Add(btnUpdateProd);
            panel5.Controls.Add(btnUpdateQuantity);
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
            panel3.Controls.Add(productList);
            panel3.Location = new System.Drawing.Point(41, 153);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(805, 349);
            panel3.TabIndex = 14;
            // 
            // productList
            // 
            productList.BackgroundColor = System.Drawing.Color.White;
            productList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { ProductID, ItemName, Category, Price, Quantity });
            productList.Dock = System.Windows.Forms.DockStyle.Fill;
            productList.Location = new System.Drawing.Point(0, 0);
            productList.MultiSelect = false;
            productList.Name = "productList";
            productList.ReadOnly = true;
            productList.RowHeadersWidth = 51;
            productList.RowTemplate.Height = 24;
            productList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            productList.Size = new System.Drawing.Size(805, 349);
            productList.TabIndex = 13;
            productList.CellClick += productList_CellClick;
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
            // Category
            // 
            Category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            Category.HeaderText = "Category";
            Category.MinimumWidth = 6;
            Category.Name = "Category";
            Category.ReadOnly = true;
            // 
            // Price
            // 
            Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            Price.HeaderText = "Price";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            Price.ReadOnly = true;
            // 
            // Quantity
            // 
            Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            Quantity.HeaderText = "Quantity";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            Quantity.ReadOnly = true;
            // 
            // btnAddProduct
            // 
            btnAddProduct.BackColor = System.Drawing.Color.FromArgb(79, 154, 255);
            btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnAddProduct.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnAddProduct.ForeColor = System.Drawing.Color.White;
            btnAddProduct.Location = new System.Drawing.Point(682, 544);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new System.Drawing.Size(164, 68);
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
            btnUpdatePrice.Location = new System.Drawing.Point(494, 544);
            btnUpdatePrice.Name = "btnUpdatePrice";
            btnUpdatePrice.Size = new System.Drawing.Size(171, 68);
            btnUpdatePrice.TabIndex = 18;
            btnUpdatePrice.Text = "Update Price";
            btnUpdatePrice.UseVisualStyleBackColor = false;
            btnUpdatePrice.Click += btnUpdatePrice_Click;
            // 
            // btnUpdateProd
            // 
            btnUpdateProd.BackColor = System.Drawing.Color.RoyalBlue;
            btnUpdateProd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnUpdateProd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnUpdateProd.ForeColor = System.Drawing.Color.White;
            btnUpdateProd.Location = new System.Drawing.Point(41, 544);
            btnUpdateProd.Name = "btnUpdateProd";
            btnUpdateProd.Size = new System.Drawing.Size(189, 68);
            btnUpdateProd.TabIndex = 16;
            btnUpdateProd.Text = "Update Information";
            btnUpdateProd.UseVisualStyleBackColor = false;
            btnUpdateProd.Click += btnUpdateProd_Click;
            // 
            // btnUpdateQuantity
            // 
            btnUpdateQuantity.BackColor = System.Drawing.Color.FromArgb(79, 154, 255);
            btnUpdateQuantity.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnUpdateQuantity.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnUpdateQuantity.ForeColor = System.Drawing.Color.White;
            btnUpdateQuantity.Location = new System.Drawing.Point(284, 544);
            btnUpdateQuantity.Name = "btnUpdateQuantity";
            btnUpdateQuantity.Size = new System.Drawing.Size(189, 68);
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
            btnUpdatePassword.Location = new System.Drawing.Point(31, 369);
            btnUpdatePassword.Name = "btnUpdatePassword";
            btnUpdatePassword.Size = new System.Drawing.Size(213, 68);
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
            btnSales.Location = new System.Drawing.Point(31, 286);
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
            btnEmployees.Location = new System.Drawing.Point(31, 452);
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
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.FromArgb(110, 172, 254);
            panel2.Location = new System.Drawing.Point(268, 16);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(9, 645);
            panel2.TabIndex = 11;
            // 
            // Inventory
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(1172, 657);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "Inventory";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Inventory";
            FormClosed += Inventory_FormClosed;
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)productList).EndInit();
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
        private System.Windows.Forms.DataGridView productList;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnUpdatePrice;
        private System.Windows.Forms.Button btnUpdateProd;
        private System.Windows.Forms.Button btnUpdateQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.Button btnUpdatePassword;
    }
}