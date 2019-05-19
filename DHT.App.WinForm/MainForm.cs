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
    public partial class MainForm : CustomForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // form açma fonksiyonu
        // Generic template 
        private void OpenForm<acilacakForm>() where acilacakForm : Form, new()
        {
            var form = new acilacakForm()
            {
                MdiParent = this,
                StartPosition = FormStartPosition.CenterScreen
            };

            // Açılacak bütün formların yüksekliğini kullanıcının ekranına göre %80 oranla
            form.Size = new Size(form.Size.Width, (int)(ClientRectangle.Height * 0.8));

            form.Show();
        }

        private void citiesDistrictsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm<CityDistrictForm>();
        }

        private void hospitalsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm<HospitalForm>();
        }

        private void clinicsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm<ClinicForm>();
        }

        private void patientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm<PatientForm>();
        }

        private void doctorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm<DoctorForm>();
        }

        private void appoinmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm<AppoinmentForm>();
        }

        private void systemAdministratorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm<SysAdminForm>();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            menuStrip1.ImageScalingSize = new Size(64, 64);
        }
    }
}
