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
    public partial class UpdatePassword : Form
    {
        public UpdatePassword()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var currentPass = tbcurrentpass.Text;
            var newPass = tbnewpass.Text;
            var confirmPass = tbconfirmpass.Text;

            var user = AppHelper.db.Users
                        .Where(u => u.Username == AppHelper.auth.username)
                        .Select(u => u)
                        .Single();

            if (AppHelper.Encryption.PasswordMatch(user.Password, currentPass))
            {
                if (newPass == confirmPass)
                {
                    user.Password = AppHelper.Encryption.EncryptPassword(newPass);
                    AppHelper.db.SaveChanges();
                    MessageBox.Show("Password has been changed");
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("New Password does not match");
                }
            }
            else
            {
                MessageBox.Show("Wrong Current Password");
            }
        }

        private void UpdatePassword_Leave(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
