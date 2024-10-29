using SalesAndInventoryProgram.Auth;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            var username = tbusername.Text;
            var password = tbpassword.Text;

            var user = AppHelper.db.Users.Where(u => u.Username == username).Select(u => new { u.Username, u.Password, u.Status }).SingleOrDefault();
            if(user != null)
            {
                if(user.Status == AppHelper.ActiveStatus)
                {
                    if (user.Password == password)
                    {
                        AppHelper.auth.username = username;
                        Inventory inventory = new Inventory();
                        inventory.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Login Failed: Wrong Password");
                    }
                }
                else
                {
                    MessageBox.Show("Login Failed: Your account has been disabled");
                }
            }
            else
            {
                MessageBox.Show("Login Failed: User not registered");
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
