using SalesAndInventoryProgram.Data.Models;
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
    public partial class AddProduct : Form
    {
        private bool IsEdit = false;

        public AddProduct(bool isEdit = false)
        {
            InitializeComponent();
            if(isEdit)
            {
                var product = AppHelper.SelectedProduct;
                tbItemName.Text = product.ItemName;
                tbCategory.Text = product.Category;
                tbPrice.Value = Convert.ToDecimal(product.Price);
                tbQuantity.Value = Convert.ToDecimal(product.Quantity);
            }
            IsEdit = isEdit;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Inventory inventory = new Inventory();
            inventory.Show();
            this.Hide();
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            Inventory inventory = new Inventory();
            inventory.Show();
            this.Hide();
        }

        private void AddProduct_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {
                var name = tbItemName.Text;
                var category = tbCategory.Text;
                var price = Convert.ToDouble(tbPrice.Value);
                var quantity = Convert.ToInt16(tbQuantity.Value);

                Console.WriteLine(price);
                Console.WriteLine(tbPrice.Value);

                if (AppHelper.IsEmpty(name) || AppHelper.IsEmpty(category))
                    throw new Exception("Empty Field Detected");

                if (price <= 0)
                    throw new Exception("Invalid Price");

                if (quantity <= 0)
                    throw new Exception("Quantity must not be 0");


                if(IsEdit)
                {
                    var product = AppHelper.SelectedProduct;
                    product.ItemName = name;
                    product.Category = category;
                    product.Price = price;
                    product.Quantity = quantity;
                }
                else
                {
                    AppHelper.db.Products.Add(
                        new Product()
                        {
                            ItemName = name,
                            Category = category,
                            Price = price,
                            Quantity = quantity
                        }
                    );
                }


                AppHelper.db.SaveChanges();
                MessageBox.Show($"Product {((IsEdit) ? "Modified" : "Created")}");
                this.Dispose();
                new Inventory().Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Could not {((IsEdit)? "modify" : "create")} product: " + ex.Message);
            }
        }
    }
}
