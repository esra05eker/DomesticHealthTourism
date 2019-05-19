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
    public partial class PatientDetailsForm : CustomForm
    {
        public Patient patient;

        // varolan parola
        string existingPassword;

        public PatientDetailsForm()
        {
            InitializeComponent();
            btnSave.Image = new Bitmap(Properties.Resources.success, new Size(32, 32));
        }

        private void PatientDetails_Load(object sender, EventArgs e)
        {
            patientBindingSource.DataSource = patient;
            existingPassword = patient.Password;

            passwordTextBox1.Text = "";
            patient.Password = "";
            txtRePassword.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!txtRePassword.Text.Equals(patient.Password))
            {
                MessageBox.Show("Passwords are not matching");
                return;
            }

            if (string.IsNullOrEmpty(patient.TcNo) ||
                string.IsNullOrEmpty(patient.Firstname) ||
                string.IsNullOrEmpty(patient.Lastname) ||
                string.IsNullOrEmpty(patient.Email) ||
                (string.IsNullOrEmpty(patient.Password) && string.IsNullOrEmpty(existingPassword)))
            {
                MessageBox.Show("You must enter values");
                return;
            }

            if (passwordTextBox1.Text.Equals(string.Empty))
            {
                patient.Password = existingPassword;
            }
            else
            {
                patient.Password = StringUtils.MD5(passwordTextBox1.Text);
            }
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
