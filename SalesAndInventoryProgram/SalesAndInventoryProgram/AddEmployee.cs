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
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Employees employees = new Employees();
            employees.Show();
            this.Hide();
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            Employees employees = new Employees();
            employees.Show();
            this.Hide();
        }

        private void AddEmployee_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {
                if (HasEmpty())
                    throw new Exception("Empty Field Detected");

                if (AppHelper.db.Users.Select(u => u).Where(w => w.Username == tbUsername.Text).SingleOrDefault() != null)
                    throw new Exception("Username already registered");

                var employee = new User()
                {
                    FirstName = tbFirstname.Text,
                    LastName = tbLastname.Text,
                    Username = tbUsername.Text,
                    Password = tbPass.Text
                };

                AppHelper.db.Users.Add(employee);

                var result = AppHelper.db.SaveChanges();

                if (result == 0)
                    throw new Exception("Insert Failed, Dont Know why");

                new Employees().Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message);
            }
            

        }

        private bool HasEmpty()
        {
            return AppHelper.IsEmpty(tbFirstname.Text) || AppHelper.IsEmpty(tbLastname.Text) || AppHelper.IsEmpty(tbUsername.Text) || AppHelper.IsEmpty(tbPass.Text);
        }
    }
}
