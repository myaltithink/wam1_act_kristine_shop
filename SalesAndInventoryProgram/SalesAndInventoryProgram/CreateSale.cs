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
        public CreateSale()
        {
            InitializeComponent();
        }

        private void btnDeleteProd_Click(object sender, EventArgs e)
        {
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
    }
}
