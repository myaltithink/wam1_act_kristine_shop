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
    public partial class UpdatePrice : Form
    {
        public UpdatePrice()
        {
            InitializeComponent();
            if (AppHelper.SelectedProduct != null)
            {
                lblprodName.Text = AppHelper.SelectedProduct.ItemName;
                lblcurrentPrice.Text = AppHelper.SelectedProduct.Price.ToString();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Inventory inventory = new Inventory();
            inventory.Show();
            this.Hide();
        }

        private void UpdatePrice_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var newPrice = Convert.ToDouble(lblNewPrice.Value);
                if (newPrice <= 0)
                    throw new Exception("Price cannot be a 0 or lower");

                var updateProduct = AppHelper.SelectedProduct;
                updateProduct.Price = newPrice;
                AppHelper.db.SaveChanges();
                MessageBox.Show("Price has been updated\n\nNote: This does not affect previous sales of this product");
                this.Dispose();
                new Inventory().Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
