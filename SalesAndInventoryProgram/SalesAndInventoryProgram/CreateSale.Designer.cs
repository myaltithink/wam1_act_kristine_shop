
namespace SalesAndInventoryProgram
{
    partial class CreateSale
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
            btnSave = new System.Windows.Forms.Button();
            btnAdd = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            btnRemove = new System.Windows.Forms.Button();
            panel3 = new System.Windows.Forms.Panel();
            itemTable = new System.Windows.Forms.DataGridView();
            Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            panel2 = new System.Windows.Forms.Panel();
            displayTotal = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)itemTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.White;
            panel1.Controls.Add(panel5);
            panel1.Location = new System.Drawing.Point(-6, -49);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(908, 811);
            panel1.TabIndex = 9;
            // 
            // panel5
            // 
            panel5.BackColor = System.Drawing.Color.Transparent;
            panel5.BackgroundImage = Properties.Resources.bg1;
            panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            panel5.Controls.Add(btnSave);
            panel5.Controls.Add(btnAdd);
            panel5.Controls.Add(btnCancel);
            panel5.Controls.Add(btnRemove);
            panel5.Controls.Add(panel3);
            panel5.Controls.Add(panel2);
            panel5.Controls.Add(displayTotal);
            panel5.Controls.Add(label1);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(pictureBox1);
            panel5.Location = new System.Drawing.Point(3, 45);
            panel5.Name = "panel5";
            panel5.Size = new System.Drawing.Size(890, 682);
            panel5.TabIndex = 21;
            // 
            // btnSave
            // 
            btnSave.BackColor = System.Drawing.Color.FromArgb(79, 154, 255);
            btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnSave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnSave.ForeColor = System.Drawing.Color.White;
            btnSave.Location = new System.Drawing.Point(502, 585);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(127, 57);
            btnSave.TabIndex = 27;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = System.Drawing.Color.FromArgb(79, 154, 255);
            btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnAdd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnAdd.ForeColor = System.Drawing.Color.White;
            btnAdd.Location = new System.Drawing.Point(366, 585);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(127, 57);
            btnAdd.TabIndex = 26;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnUpdatePrice_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = System.Drawing.Color.RoyalBlue;
            btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnCancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnCancel.ForeColor = System.Drawing.Color.White;
            btnCancel.Location = new System.Drawing.Point(49, 585);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(127, 57);
            btnCancel.TabIndex = 24;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnDeleteProd_Click;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = System.Drawing.Color.FromArgb(79, 154, 255);
            btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnRemove.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnRemove.ForeColor = System.Drawing.Color.White;
            btnRemove.Location = new System.Drawing.Point(229, 585);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new System.Drawing.Size(127, 57);
            btnRemove.TabIndex = 25;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // panel3
            // 
            panel3.BackColor = System.Drawing.Color.White;
            panel3.Controls.Add(itemTable);
            panel3.Location = new System.Drawing.Point(49, 173);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(580, 349);
            panel3.TabIndex = 15;
            // 
            // itemTable
            // 
            itemTable.BackgroundColor = System.Drawing.Color.White;
            itemTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            itemTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Item, Price, Quantity, Total });
            itemTable.Dock = System.Windows.Forms.DockStyle.Fill;
            itemTable.Location = new System.Drawing.Point(0, 0);
            itemTable.Name = "itemTable";
            itemTable.ReadOnly = true;
            itemTable.RowHeadersWidth = 51;
            itemTable.RowTemplate.Height = 24;
            itemTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            itemTable.Size = new System.Drawing.Size(580, 349);
            itemTable.TabIndex = 13;
            // 
            // Item
            // 
            Item.HeaderText = "Item";
            Item.Name = "Item";
            Item.ReadOnly = true;
            // 
            // Price
            // 
            Price.HeaderText = "Price";
            Price.Name = "Price";
            Price.ReadOnly = true;
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Quantity";
            Quantity.Name = "Quantity";
            Quantity.ReadOnly = true;
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.Name = "Total";
            Total.ReadOnly = true;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.FromArgb(110, 172, 254);
            panel2.Location = new System.Drawing.Point(-24, 145);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(742, 3);
            panel2.TabIndex = 23;
            // 
            // displayTotal
            // 
            displayTotal.AutoSize = true;
            displayTotal.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            displayTotal.ForeColor = System.Drawing.Color.White;
            displayTotal.Location = new System.Drawing.Point(466, 537);
            displayTotal.Name = "displayTotal";
            displayTotal.Size = new System.Drawing.Size(71, 28);
            displayTotal.TabIndex = 22;
            displayTotal.Text = "00.00";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(387, 537);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(73, 28);
            label1.TabIndex = 22;
            label1.Text = "Total:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(256, 99);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(148, 28);
            label3.TabIndex = 22;
            label3.Text = "Create Sale";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.klogodark;
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pictureBox1.Location = new System.Drawing.Point(21, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(179, 79);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // CreateSale
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(683, 678);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "CreateSale";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "CreateSale";
            FormClosed += CreateSale_FormClosed;
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)itemTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView itemTable;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label displayTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}