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
        public Sales()
        {
            InitializeComponent();

            if(!AppHelper.auth.isOwner)
            {
                btnEmployees.Hide();
            }
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
    }
}
