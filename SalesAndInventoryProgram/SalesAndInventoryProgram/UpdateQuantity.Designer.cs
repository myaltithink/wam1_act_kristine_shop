
namespace SalesAndInventoryProgram
{
    partial class UpdateQuantity
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
            btnCancel = new System.Windows.Forms.Button();
            groupBox3 = new System.Windows.Forms.GroupBox();
            tbAddQuantity = new System.Windows.Forms.TextBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            lblcurrentQuantity = new System.Windows.Forms.TextBox();
            panel2 = new System.Windows.Forms.Panel();
            label3 = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            lblprodName = new System.Windows.Forms.TextBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
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
            panel1.TabIndex = 7;
            panel1.Paint += panel1_Paint;
            // 
            // panel5
            // 
            panel5.BackColor = System.Drawing.Color.Transparent;
            panel5.BackgroundImage = Properties.Resources.bg1;
            panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            panel5.Controls.Add(btnSave);
            panel5.Controls.Add(btnCancel);
            panel5.Controls.Add(groupBox3);
            panel5.Controls.Add(groupBox2);
            panel5.Controls.Add(panel2);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(groupBox1);
            panel5.Controls.Add(pictureBox1);
            panel5.Location = new System.Drawing.Point(3, 45);
            panel5.Name = "panel5";
            panel5.Size = new System.Drawing.Size(890, 682);
            panel5.TabIndex = 21;
            panel5.Paint += panel5_Paint;
            // 
            // btnSave
            // 
            btnSave.BackColor = System.Drawing.Color.FromArgb(79, 154, 255);
            btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnSave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnSave.ForeColor = System.Drawing.Color.White;
            btnSave.Location = new System.Drawing.Point(381, 552);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(176, 68);
            btnSave.TabIndex = 28;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = System.Drawing.Color.RoyalBlue;
            btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnCancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnCancel.ForeColor = System.Drawing.Color.White;
            btnCancel.Location = new System.Drawing.Point(139, 552);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(176, 68);
            btnCancel.TabIndex = 27;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(tbAddQuantity);
            groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            groupBox3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            groupBox3.ForeColor = System.Drawing.Color.White;
            groupBox3.Location = new System.Drawing.Point(139, 427);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(417, 83);
            groupBox3.TabIndex = 26;
            groupBox3.TabStop = false;
            groupBox3.Text = "Add Quantity";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // tbAddQuantity
            // 
            tbAddQuantity.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tbAddQuantity.Location = new System.Drawing.Point(24, 32);
            tbAddQuantity.Name = "tbAddQuantity";
            tbAddQuantity.Size = new System.Drawing.Size(369, 30);
            tbAddQuantity.TabIndex = 0;
            tbAddQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            tbAddQuantity.TextChanged += tbAddQuantity_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblcurrentQuantity);
            groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            groupBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            groupBox2.ForeColor = System.Drawing.Color.White;
            groupBox2.Location = new System.Drawing.Point(139, 311);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(417, 83);
            groupBox2.TabIndex = 25;
            groupBox2.TabStop = false;
            groupBox2.Text = "Current Quantity";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // lblcurrentQuantity
            // 
            lblcurrentQuantity.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblcurrentQuantity.Location = new System.Drawing.Point(24, 33);
            lblcurrentQuantity.Name = "lblcurrentQuantity";
            lblcurrentQuantity.Size = new System.Drawing.Size(369, 30);
            lblcurrentQuantity.TabIndex = 0;
            lblcurrentQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            lblcurrentQuantity.TextChanged += lblcurrentQuantity_TextChanged;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.FromArgb(110, 172, 254);
            panel2.Location = new System.Drawing.Point(-24, 145);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(742, 3);
            panel2.TabIndex = 23;
            panel2.Paint += panel2_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(227, 99);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(217, 28);
            label3.TabIndex = 22;
            label3.Text = "UPDATE QUANTITY";
            label3.Click += label3_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblprodName);
            groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            groupBox1.ForeColor = System.Drawing.Color.White;
            groupBox1.Location = new System.Drawing.Point(139, 197);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(417, 83);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Product Name";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // lblprodName
            // 
            lblprodName.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblprodName.Location = new System.Drawing.Point(24, 33);
            lblprodName.Name = "lblprodName";
            lblprodName.Size = new System.Drawing.Size(369, 30);
            lblprodName.TabIndex = 0;
            lblprodName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            lblprodName.TextChanged += lblprodName_TextChanged;
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
            pictureBox1.Click += pictureBox1_Click;
            // 
            // UpdateQuantity
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(683, 678);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "UpdateQuantity";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "UpdateQuantity";
            FormClosed += UpdateQuantity_FormClosed;
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbAddQuantity;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox lblcurrentQuantity;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox lblprodName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}