using DHT.BLL.Repos;
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
    public partial class DoctorDetailsForm : CustomForm
    {
        public Doctor doctor;

        public DoctorDetailsForm()
        {
            InitializeComponent();
            btnSave.Image = new Bitmap(Properties.Resources.success, new Size(32, 32));
        }

        private void DoctorDetailsForm_Load(object sender, EventArgs evarg)
        {
            doctorBindingSource.DataSource = doctor;
            hospitalBindingSource.DataSource = HospitalRepository.GetHospitals();
            clinicBindingSource.DataSource = HospitalClinicRepository.GetHospitalsClinics();

            hospitalComboBox.ValueMember = "Id";
            clinicComboBox.ValueMember = "Id";

            clinicComboBox.DataBindings.Add("SelectedValue", doctor, "HospitalClinicId");

            hospitalBindingSource.CurrentItemChanged += (s, e) =>
            {
                var hospital = hospitalBindingSource.Current as Hospital;
                if (hospital != null)
                {
                    clinicBindingSource.DataSource = hospital.Clinics;
                }
                else
                {
                    clinicBindingSource.DataSource = ClinicRepository.GetClinics();
                }
            };
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(doctor.TcNo) ||
                string.IsNullOrEmpty(doctor.Firstname) ||
                string.IsNullOrEmpty(doctor.Lastname) ||
                string.IsNullOrEmpty(doctor.Email) || doctor.HospitalClinicId <= 0)
            {
                MessageBox.Show("You must enter values");
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
