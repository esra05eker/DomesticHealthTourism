using DHT.Entity.Entities;
using DHT.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DHT.App.WinForm
{
    public partial class SysAdminDetailsForm : CustomForm
    {
        public SysAdmin sysAdmin;

        // varolan parola
        string existingPassword;

        public SysAdminDetailsForm()
        {
            InitializeComponent();
            btnSave.Image = new Bitmap(Properties.Resources.success, new Size(32, 32));
        }

        private void SysAdminDetailsForm_Load(object sender, EventArgs e)
        {
            sysAdminBindingSource.DataSource = sysAdmin;

            existingPassword = sysAdmin.Password;

            passwordTextBox.Text = "";
            sysAdmin.Password = "";
            txtRePassword.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!txtRePassword.Text.Equals(sysAdmin.Password))
            {
                MessageBox.Show("Passwords are not matching");
                return;
            }

            if (string.IsNullOrEmpty(sysAdmin.Firstname) ||
                string.IsNullOrEmpty(sysAdmin.Lastname) ||
                string.IsNullOrEmpty(sysAdmin.Email) ||
                (string.IsNullOrEmpty(sysAdmin.Password) && string.IsNullOrEmpty(existingPassword)))
            {
                MessageBox.Show("You must enter values");
                return;
            }

            if (passwordTextBox.Text.Equals(string.Empty))
            {
                sysAdmin.Password = existingPassword;
            }
            else
            {
                sysAdmin.Password = StringUtils.MD5(passwordTextBox.Text);
            }
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
