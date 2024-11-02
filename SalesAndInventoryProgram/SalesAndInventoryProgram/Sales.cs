using Microsoft.EntityFrameworkCore;
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
    public partial class Sales : Form
    {

        private double OverallSale = 0;
        private List<Sale> soldItems = null;

        public Sales()
        {
            InitializeComponent();

            if (!AppHelper.auth.isOwner)
            {
                btnEmployees.Hide();
            }
            GetSales();
        }

        private void GetSales()
        {
            var saleData = AppHelper.db.Sales
                            .Select(s => s)
                            .Include(s => s.Product)
                            .ToList();

            soldItems = saleData;
            PopulateTable(saleData);
        }

        private void PopulateTable(List<Sale> sales)
        {
            saleList.Rows.Clear();
            OverallSale = 0;
            foreach (var sale in sales)
            {
                saleList.Rows.Add(sale.Id, sale.ProductId, sale.Product.ItemName, sale.Quantity, sale.ItemPrice, sale.Total);
                OverallSale += sale.Total;
            }
            TotalSales.Text = Math.Round(OverallSale, 2).ToString();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            Inventory inventory = new Inventory();
            inventory.Show();
            this.Dispose();
        }

        private void btnCreateSale_Click(object sender, EventArgs e)
        {
            CreateSale createSale = new CreateSale();
            createSale.Show();
            this.Dispose();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            Login form1 = new Login();
            form1.Show();
            this.Dispose();
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            Employees employees = new Employees();
            employees.Show();
            this.Dispose();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {

        }

        private void Sales_FormClosed(object sender, FormClosedEventArgs e)
        {
            AppHelper.CloseUpdatePassForm();
            Application.Exit();
        }

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            UpdatePassword updatePassword = new UpdatePassword();
            updatePassword.Show();
            AppHelper.UpdatePassForm = updatePassword;

        }

        private void btnDeleteSale_Click(object sender, EventArgs e)
        {
            try
            {
                var index = saleList.SelectedRows[0].Index;
                var item = soldItems[index];

                AppHelper.db.Remove(item);
                AppHelper.db.SaveChanges();
                GetSales();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void tbsearch_TextChanged(object sender, EventArgs e)
        {
            var value = tbsearch.Text.ToLower();
            var newDisplay = new List<Sale>();
            foreach (var item in soldItems)
            {
                if(item.Id.ToString().Contains(value) || item.Product.ItemName.ToLower().Contains(value))
                {
                    newDisplay.Add(item);
                    continue;
                }
            }
            PopulateTable(newDisplay);
        }
    }
}
