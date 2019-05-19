using DHT.BLL.Repos;
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
    public partial class LoginForm : CustomForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        // bir tuşa basıldığında tetiklenen yer
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // eğer enter'a basılmış ise
            if (keyData == Keys.Enter)
            {
                login();
            }

            // varsayılan işleme devam et
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            login();
        }

        private void login()
        {
            var email = txtEmail.Text;
            var password = txtPassword.Text;
            
            if (string.IsNullOrEmpty(email.Trim()) || string.IsNullOrEmpty(password.Trim()))
            {
                MessageBox.Show("Email and password are required");
                return; // aşağı devam etme
            }

            if (SysAdminRepository.Login(email, password)) // bilgiler doğru mu?
            {
                Hide(); // login penceresini gizle
                var mainform = new MainForm();

                // mainform kapatıldığında
                mainform.FormClosing += (s, args) =>
                {
                    Show(); // login penceresini göster
                };

                // mainformu göster
                mainform.Show();
            }
            else
            {
                /// eğer bilgiler yanlış ise uyarı !!!
                MessageBox.Show("Wrong system admin credentials");
            }
        }
    }
}
