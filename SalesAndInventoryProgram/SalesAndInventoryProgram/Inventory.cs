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
    public partial class Inventory : Form
    {
        private List<Product> InventoryItems = null;

        public Inventory()
        {
            InitializeComponent();
            InitializeTable();

            if (!AppHelper.auth.isOwner)
            {
                btnEmployees.Hide();
            }
        }

        private void InitializeTable()
        {
            var items = AppHelper.db.Products
                            .Select(i => i)
                            .ToList();
            InventoryItems = items;
            if (items.Count != 0)
            {
                AppHelper.SelectedProduct = items[0];
            }
            PopulateTable(items);
        }

        private void PopulateTable(List<Product> items)
        {
            productList.Rows.Clear();
            foreach (var item in items)
            {
                productList.Rows.Add(item.Id, item.ItemName, item.Category, item.Price, item.Quantity);
            }
        }


        private void btnUpdatePrice_Click(object sender, EventArgs e)
        {
            if (AppHelper.SelectedProduct != null)
            {
                UpdatePrice updatePrice = new UpdatePrice();
                updatePrice.Show();
                this.Dispose();
            }
        }

        private void btnUpdateQuantity_Click(object sender, EventArgs e)
        {
            if (AppHelper.SelectedProduct != null)
            {
                UpdateQuantity updateQuantity = new UpdateQuantity();
                updateQuantity.Show();
                this.Dispose();
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct();
            addProduct.Show();
            this.Dispose();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            Login form1 = new Login();
            form1.Show();
            this.Dispose();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            Sales sales = new Sales();
            sales.Show();
            this.Dispose();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {

        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            Employees employees = new Employees();
            employees.Show();
            this.Dispose();
        }

        private void Inventory_FormClosed(object sender, FormClosedEventArgs e)
        {
            AppHelper.CloseUpdatePassForm();
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdatePassword updatePassword = new UpdatePassword();
            updatePassword.Show();
            AppHelper.UpdatePassForm = updatePassword;
        }

        private void productList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var index = productList.SelectedRows[0].Index;
                AppHelper.SelectedProduct = InventoryItems[index];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnUpdateProd_Click(object sender, EventArgs e)
        {
            this.Dispose();
            new AddProduct(isEdit: true).Show();
        }

        private void tbsearch_TextChanged(object sender, EventArgs e)
        {
            var value = tbsearch.Text.ToLower();
            var newDisplay = new List<Product>();
            foreach(var item in InventoryItems)
            {
                if(item.Id.ToString().Contains(value) || item.ItemName.ToLower().Contains(value) || item.Category.ToLower().Contains(value) ||
                    item.Price.ToString().Contains(value) || item.Quantity.ToString().Contains(value))
                {
                    newDisplay.Add(item);
                }
            }
            PopulateTable(newDisplay);
        }
    }
}
