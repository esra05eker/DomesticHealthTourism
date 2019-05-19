using DHT.Entity.Entities;
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
    public partial class ClinicDetailsForm : CustomForm
    {
        public Clinic clinic;
        public ClinicDetailsForm()
        {
            InitializeComponent();
            btnSave.Image = new Bitmap(Properties.Resources.success, new Size(32, 32));
        }

        private void ClinicDetailsForm_Load(object sender, EventArgs e)
        {
            txtName.DataBindings.Add("Text", clinic, "Name");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(clinic.Name))
            {
                MessageBox.Show("You must enter a clinic name");
                return;
            }
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
