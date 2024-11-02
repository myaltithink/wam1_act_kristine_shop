
namespace SalesAndInventoryProgram
{
    partial class AddSaleItem
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
            btnAdd = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            panel2 = new System.Windows.Forms.Panel();
            groupBox2 = new System.Windows.Forms.GroupBox();
            label3 = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            tbProducts = new System.Windows.Forms.ComboBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            tbQuantity = new System.Windows.Forms.NumericUpDown();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbQuantity).BeginInit();
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
            panel5.Controls.Add(btnAdd);
            panel5.Controls.Add(btnCancel);
            panel5.Controls.Add(panel2);
            panel5.Controls.Add(groupBox2);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(groupBox1);
            panel5.Controls.Add(pictureBox1);
            panel5.Location = new System.Drawing.Point(3, 45);
            panel5.Name = "panel5";
            panel5.Size = new System.Drawing.Size(890, 682);
            panel5.TabIndex = 21;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = System.Drawing.Color.FromArgb(79, 154, 255);
            btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnAdd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnAdd.ForeColor = System.Drawing.Color.White;
            btnAdd.Location = new System.Drawing.Point(382, 473);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(224, 66);
            btnAdd.TabIndex = 36;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = System.Drawing.Color.RoyalBlue;
            btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnCancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnCancel.ForeColor = System.Drawing.Color.White;
            btnCancel.Location = new System.Drawing.Point(85, 473);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(224, 66);
            btnCancel.TabIndex = 35;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.FromArgb(110, 172, 254);
            panel2.Location = new System.Drawing.Point(-24, 145);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(742, 3);
            panel2.TabIndex = 23;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tbQuantity);
            groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            groupBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            groupBox2.ForeColor = System.Drawing.Color.White;
            groupBox2.Location = new System.Drawing.Point(85, 324);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(522, 83);
            groupBox2.TabIndex = 34;
            groupBox2.TabStop = false;
            groupBox2.Text = "Quantity";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(243, 99);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(182, 28);
            label3.TabIndex = 22;
            label3.Text = "ADD SALE ITEM";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbProducts);
            groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            groupBox1.ForeColor = System.Drawing.Color.White;
            groupBox1.Location = new System.Drawing.Point(85, 193);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(522, 83);
            groupBox1.TabIndex = 33;
            groupBox1.TabStop = false;
            groupBox1.Text = "Product";
            // 
            // tbProducts
            // 
            tbProducts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            tbProducts.FormattingEnabled = true;
            tbProducts.Location = new System.Drawing.Point(24, 30);
            tbProducts.Name = "tbProducts";
            tbProducts.Size = new System.Drawing.Size(477, 29);
            tbProducts.TabIndex = 2;
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
            // tbQuantity
            // 
            tbQuantity.Location = new System.Drawing.Point(24, 30);
            tbQuantity.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            tbQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            tbQuantity.Name = "tbQuantity";
            tbQuantity.Size = new System.Drawing.Size(477, 27);
            tbQuantity.TabIndex = 1;
            tbQuantity.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            tbQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // AddSaleItem
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(683, 592);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "AddSaleItem";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "AddSaleItem";
            FormClosed += AddSaleItem_FormClosed;
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbQuantity).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox tbProducts;
        private System.Windows.Forms.NumericUpDown tbQuantity;
    }
}