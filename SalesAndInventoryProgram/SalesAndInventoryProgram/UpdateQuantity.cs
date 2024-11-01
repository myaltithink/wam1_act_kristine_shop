using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesAndInventoryProgram
{
    public partial class UpdateQuantity : Form
    {

        public UpdateQuantity()
        {
            InitializeComponent();
            if (AppHelper.SelectedProduct != null)
            {
                lblprodName.Text = AppHelper.SelectedProduct.ItemName;
                lblcurrentQuantity.Text = AppHelper.SelectedProduct.Quantity.ToString();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Inventory inventory = new Inventory();
            inventory.Show();
            this.Hide();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var addedQuantity = Convert.ToInt16(newQuantity.Value);

                var updatedProduct = AppHelper.SelectedProduct;
                var computedQuantity = updatedProduct.Quantity + addedQuantity;

                if (computedQuantity < 0)
                    throw new Exception("Could not process request as the quantity of this prodouct would reach a negative number");

                updatedProduct.Quantity = computedQuantity;

                AppHelper.db.SaveChanges();

                MessageBox.Show("Quantity has been updated");
                this.Dispose();
                new Inventory().Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void tbAddQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void lblcurrentQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblprodName_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void UpdateQuantity_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
