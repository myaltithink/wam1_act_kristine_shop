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
    public partial class AddSaleItem : Form
    {

        private List<ProductData> ProductData = null;


        public AddSaleItem()
        {
            InitializeComponent();
            GetProductList();
        }

        private void GetProductList()
        {
            var products = AppHelper.db.Products
                            .Select(i => new ProductData() { Id = i.Id, ItemName = i.ItemName, Quantity = i.Quantity, Price = i.Price })
                            .Where(w => w.Quantity != 0)
                            .ToList();

            foreach(var item in products)
            {
                tbProducts.Items.Add(item.ItemName);
            }

            ProductData = products;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CreateSale createSale = new CreateSale();
            createSale.Show();
            this.Hide();
        }

        private void AddSaleItem_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbProducts.SelectedIndex == -1)
                    throw new Exception("No Product Selected");

                var product = ProductData[tbProducts.SelectedIndex];

                if (tbQuantity.Value > product.Quantity)
                    throw new Exception("The quantity you have given exceeds the current stock");

                var soldQuantity = Convert.ToInt16(tbQuantity.Value);

                var totalSale = product.Price * soldQuantity;

                AppHelper.SalesItem.Add(
                        new SaleItem()
                        {
                            Id = product.Id,
                            ItemName = product.ItemName,
                            ItemPrice = product.Price,
                            Quantity = soldQuantity,
                            Total = Math.Round(totalSale, 2)
                        }
                    );

                this.Dispose();
                new CreateSale().Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

    public partial class ProductData
    {
        public int Id { get; set; }
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
    }

    public partial class SaleItem
    {
        public int Id { get; set; }
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public double ItemPrice { get; set; }
        public double Total { get; set; }
    }
}
