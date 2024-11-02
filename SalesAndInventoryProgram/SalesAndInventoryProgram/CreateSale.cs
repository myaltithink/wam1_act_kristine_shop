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
    public partial class CreateSale : Form
    {

        private double total = 0;

        public CreateSale()
        {
            InitializeComponent();
            PopulateTable();
        }

        private void PopulateTable()
        {
            itemTable.Rows.Clear();
            foreach (var item in AppHelper.SalesItem)
            {
                itemTable.Rows.Add(item.ItemName, item.ItemPrice, item.Quantity, item.Total);
                total += item.Total;
            }
            displayTotal.Text = Math.Round(total, 2).ToString();
        }

        private void btnDeleteProd_Click(object sender, EventArgs e)
        {
            AppHelper.SalesItem.Clear();
            Sales sales = new Sales();
            sales.Show();
            this.Hide();
        }

        private void btnUpdatePrice_Click(object sender, EventArgs e)
        {
            AddSaleItem addSaleItem = new AddSaleItem();
            addSaleItem.Show();
            this.Hide();
        }

        private void CreateSale_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var index = itemTable.SelectedRows[0].Index;
            var sale = AppHelper.SalesItem[index];

            total = 0;

            AppHelper.SalesItem.Remove(sale);
            PopulateTable();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (AppHelper.SalesItem.Count == 0)
                    throw new Exception("Could not save, There is not a single item in the list");

                var sales = new List<Sale>();

                foreach (var sale in AppHelper.SalesItem)
                {
                    sales.Add(
                        new Sale()
                        {
                            ProductId = sale.Id,
                            ItemPrice = sale.ItemPrice,
                            Quantity = sale.Quantity,
                            Total = sale.Total
                        }
                    );

                    var product = AppHelper.db.Products.Select(u => u).Where(w => w.Id == sale.Id).Single();

                    product.Quantity = product.Quantity - sale.Quantity;

                }

                AppHelper.db.Sales.AddRange(sales);

                AppHelper.db.SaveChanges();

                MessageBox.Show("Sale has been recorded");
                AppHelper.SalesItem.Clear();
                this.Dispose();
                new Sales().Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
