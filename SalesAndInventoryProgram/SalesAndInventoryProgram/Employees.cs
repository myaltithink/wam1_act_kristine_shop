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
    public partial class Employees : Form
    {

        private List<EmployeeDisplay> users = null;

        public Employees()
        {
            InitializeComponent();
            InitializeList();
        }

        private void InitializeList()
        {
            var employees = AppHelper.db.Users
                .Select(u => new EmployeeDisplay() { Id = u.Id, FirstName = u.FirstName, LastName = u.LastName, Username = u.Username, Status = u.Status })
                .ToList();

            users = employees;
            PopulateTable(employees);
        }

        private void PopulateTable(List<EmployeeDisplay> employees)
        {
            employeeList.Rows.Clear();
            foreach (var employee in employees)
            {
                if (employee.Username == "kristine") continue;
                employeeList.Rows.Add(employee.Id, employee.FirstName, employee.LastName, employee.Username, employee.Status);
            }
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            AddEmployee addEmployee = new AddEmployee();
            addEmployee.Show();
            this.Dispose();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            Inventory inventory = new Inventory();
            inventory.Show();
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

        private void Employees_FormClosed(object sender, FormClosedEventArgs e)
        {
            AppHelper.CloseUpdatePassForm();
            Application.Exit();
        }

        private void btnDisableAcc_Click(object sender, EventArgs e)
        {
            var selectedEmployee = GetUser();
            if (selectedEmployee.Status == AppHelper.ActiveStatus)
            {
                DialogResult result = MessageBox.Show($"Are you sure you want to disable the account of {selectedEmployee.Username}", "Notice!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        selectedEmployee.Status = AppHelper.DisableStatus;
                        AppHelper.db.SaveChanges();
                        InitializeList();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to Disable Account: " + ex.Message);
                    }
                }
            }
        }

        private User GetUser()
        {
            var username = employeeList.Rows[employeeList.CurrentCell.RowIndex].Cells["Username"].Value.ToString();
            return AppHelper.db.Users.Select(u => u).Where(u => u.Username == username).Single();
        }

        private void btnEnableAcc_Click(object sender, EventArgs e)
        {
            try
            {
                var user = GetUser();
                if (user.Status == AppHelper.DisableStatus)
                {
                    user.Status = AppHelper.ActiveStatus;
                    AppHelper.db.SaveChanges();
                    InitializeList();
                    MessageBox.Show($"Account for {user.Username} has been enabled");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to enable account: " + ex.Message);
            }
        }

        private void btnResetPass_Click(object sender, EventArgs e)
        {
            try
            {
                var user = GetUser();
                var dialogResult = MessageBox.Show($"Are you sure you want to reset the password for {user.Username}", "Notice!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    user.Password = "wasdwasd";
                    AppHelper.db.SaveChanges();
                    MessageBox.Show("Password has been reset to the default password \"wasdwasd\"");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Reset Failed: " + ex.Message);
            }
        }

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            UpdatePassword updatePassword = new UpdatePassword();
            updatePassword.Show();
            AppHelper.UpdatePassForm = updatePassword;
        }

        private void tbsearch_TextChanged(object sender, EventArgs e)
        {
            var value = tbsearch.Text.ToLower();
            var newDisplay = new List<EmployeeDisplay>();
            foreach (var employee in users)
            {
                if(employee.Username.ToLower().Contains(value) || 
                    employee.FirstName.ToLower().Contains(value) ||
                    employee.LastName.ToLower().Contains(value) ||
                    employee.Status.ToLower().Contains(value) ||
                    employee.Id.ToString().Contains(value))
                {
                    newDisplay.Add(employee);
                }
            }
            PopulateTable(newDisplay);
        }
    }

    public class EmployeeDisplay
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Status { get; set; }
    }
}
