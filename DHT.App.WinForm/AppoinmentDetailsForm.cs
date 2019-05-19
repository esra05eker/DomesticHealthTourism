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
    public partial class AppoinmentDetailsForm : CustomForm
    {
        public Appoinment appoinment;

        City city;
        District district;
        Hospital hospital;
        Clinic clinic;

        public AppoinmentDetailsForm()
        {
            InitializeComponent();
            btnSave.Image = new Bitmap(Properties.Resources.success, new Size(32, 32));
            appointmentTimeDateTimePicker.Value = DateTime.Now.Date;
            dateTimePickerTime.Value = DateTime.Now.Date + new TimeSpan(9, 0, 0);

            dateTimePickerTime.ShowUpDown = true;
            dateTimePickerTime.Format = DateTimePickerFormat.Custom;
            dateTimePickerTime.CustomFormat = "HH:mm";

        }

        private void AppoinmentDetailsForm_Load(object sender, EventArgs eargs)
        {
            appoinmentBindingSource.DataSource = appoinment;
            patientBindingSource.DataSource = PatientRepository.GetPatients();
            cityBindingSource.DataSource = CityRepository.GetCities();
            districtBindingSource.DataSource = DistrictRepository.GetDistricts();
            hospitalBindingSource.DataSource = HospitalRepository.GetHospitals();
            clinicBindingSource.DataSource = ClinicRepository.GetClinics();
            doctorBindingSource.DataSource = DoctorRepository.GetDoctors();


            cityBindingSource.CurrentItemChanged += (s, e) =>
            {
                city = cityBindingSource.Current as City;
                if (city != null)
                {
                    districtBindingSource.DataSource = DistrictRepository.GetCityDistricts(city.Id);
                }
                else
                {
                    districtBindingSource.DataSource = null;
                }

            };

            districtBindingSource.CurrentItemChanged += (s, e) =>
            {
                district = districtBindingSource.Current as District;
                if (district != null)
                {
                    hospitalBindingSource.DataSource = HospitalRepository.GetHospitalsInDistrict(district.Id);
                }
                else
                {
                    hospitalBindingSource.DataSource = null;
                }
            };

            hospitalBindingSource.CurrentItemChanged += (s, e) =>
            {
                hospital = hospitalBindingSource.Current as Hospital;
                if (hospital != null)
                {
                    clinicBindingSource.DataSource = HospitalClinicRepository.GetClinicsInHospital(hospital.Id);
                }
                else
                {
                    clinicBindingSource.DataSource = null;
                }
            };

            clinicBindingSource.CurrentItemChanged += (s, e) =>
            {
                clinic = clinicBindingSource.Current as Clinic;
                if (clinic != null)
                {
                    doctorBindingSource.DataSource = DoctorRepository.GetDoctorsInHospitalClinic(clinic.Id);
                }
                else
                {
                    doctorBindingSource.DataSource = null;
                }
            };

            patientComboBox.ValueMember = "Id";
            doctorComboBox.ValueMember = "Id";

            patientComboBox.DataBindings.Add("SelectedValue", appoinment, "PatientId");
            doctorComboBox.DataBindings.Add("SelectedValue", appoinment, "DoctorId");

            if (patientComboBox.SelectedValue != null)
                appoinment.PatientId = (int)patientComboBox.SelectedValue;
            if (doctorComboBox.SelectedValue != null)
                appoinment.DoctorId = (int)doctorComboBox.SelectedValue;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            appoinment.AppointmentTime = appointmentTimeDateTimePicker.Value.Date + dateTimePickerTime.Value.TimeOfDay;

            if (appoinment.AppointmentTime == null || appoinment.DoctorId <= 0 || appoinment.PatientId <= 0)
            {
                MessageBox.Show("You must enter values");
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }


    }
}
