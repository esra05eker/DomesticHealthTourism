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
    public partial class HospitalDetailsForm : CustomForm
    {
        // işlem yapılacak nesne
        public Hospital hospital;

        public HospitalDetailsForm()
        {
            InitializeComponent();
            btnSave.Image = new Bitmap(Properties.Resources.success, new Size(32, 32));
        }

        // form açıldığında 
        private void HospitalDetailsForm_Load(object sender, EventArgs e)
        {
            // combobox da seçili olan item'İn value'sinin ne olacağını belirtir.
            cityComboBox1.ValueMember = "Id";
            districtComboBox1.ValueMember = "Id";
            clinicComboBox.ValueMember = "Id";

            /*
             * Veritabanından çekilen ayıtlar binding source'Lara ekleniyor
             * */
            cityBindingSource.DataSource = CityRepository.GetCities();
            districtBindingSource.DataSource = DistrictRepository.GetDistricts();
            clinicBindingSource.DataSource = ClinicRepository.GetClinics();

            if (hospital.District != null)
                cityComboBox1.SelectedValue = hospital.District.CityId; // hastanenin bulunduğu ilçenin ilini il comboboxında seçiyoruz

            districtComboBox1.SelectedValue = hospital.DistrictId; // hastanein ilçesini comboxdan seçiyoruz

            districtComboBox1.DataBindings.Add("SelectedValue", hospital, "DistrictId");


            hospitalBindingSource.DataSource = hospital;
            hospitalClinicBindingSource.DataSource = hospital.Clinics;

            if (hospitalClinicBindingSource.Current != null)
                hospitalClinicExaminationsBindingSource.DataSource = (hospitalClinicBindingSource.Current as HospitalClinic).HospitalClinicExaminations;
        }

        // kaydet butonuna tıklandığında
        private void btnSave_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(hospital.Name) || string.IsNullOrEmpty(hospital.Address) || hospital.DistrictId <= 0)
            {
                MessageBox.Show("You must enter values");
                return;
            }
            DialogResult = DialogResult.OK; // dialog içerisinde yapılan işlem başarılı şekilde sonuçlandırıld anlamını taşıyore diyebilriz
            Close(); // dialogu kapat
        }

        private void cityComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            var districts = DistrictRepository.GetCityDistricts((int)cityComboBox1.SelectedValue);
            districtBindingSource.DataSource = districts;


            if (districts.Count == 0) // eğer ilçe yoksa veritabanında bulunamadıysa
            {
                hospital.DistrictId = 0; // hastanenin ilçe id'sinni ıfırla

                districtComboBox1.CausesValidation = false; // comboxbox boş iken doğrulamayı kapatıyoruz, yoksa formada başka şlemler yapılmıyor kilitleniyor.
            }
            else
            {
                districtComboBox1.CausesValidation = true;
            }

        }

        private void btnAddClinic_Click(object sender, EventArgs e)
        {
            var currentClinic = (clinicBindingSource.Current as Clinic);

            // eğer klinik daha önce ekliyse bir daha eklenemsine izin vermiyoruz
            if (hospitalClinicBindingSource.Cast<HospitalClinic>().Where(a => a.ClinicId == currentClinic.Id).Count() > 0)
            {
                MessageBox.Show("Already added");
                return;
            }

            hospitalClinicBindingSource.AddNew(); // yeni nesne ekle
            var currentHospitalClinic = hospitalClinicBindingSource.Current as HospitalClinic;
            //currentHospitalClinic.Clinic = currentClinic;
            currentHospitalClinic.ClinicId = currentClinic.Id;
            currentHospitalClinic.HospitalId = hospital.Id;
        }

        private void btnDeleteClinic_Click(object sender, EventArgs e)
        {
            var currentHospitalClinic = (hospitalClinicBindingSource.Current as HospitalClinic);
            if (currentHospitalClinic != null)
            {
                hospitalClinicBindingSource.RemoveCurrent(); // seçili kaydı sil görsel olarak
                if (currentHospitalClinic.Id > 0) // id 0 dan büyükse veritabanında kaytılı ise veritabanında da sil
                    HospitalClinicRepository.Delete(currentHospitalClinic);

            }
        }

        private void hospitalClinicBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            var currentHospitalClinic = (hospitalClinicBindingSource.Current as HospitalClinic);
            if (currentHospitalClinic != null) // seçili bir klinilk var ise
            {
                hospitalClinicExaminationsBindingSource.DataSource = currentHospitalClinic.HospitalClinicExaminations; // muayeneleri getiriyoruz

                btnAddExamination.Enabled = currentHospitalClinic.Id > 0 ? true : false; // eğer seçilen klinik henüz veritabanına eklenmmeişse
            }
            else
            {
                hospitalClinicExaminationsBindingSource.DataSource = null; // klinik yok ise
            }

        }

        private void btnAddExamination_Click(object sender, EventArgs e) // muayen ekle butonu
        {
            var currentHospitalClinic = (hospitalClinicBindingSource.Current as HospitalClinic);

            if (currentHospitalClinic.Id > 0)
            {
                var name = txtExaminationName.Text.Trim(); // muayene adı
                var fee = txtExaminationFee.Text.Trim(); // muayene ücreti
                decimal feeVal = 0;

                if (!decimal.TryParse(fee, out feeVal)) /// ücret geçerli mi bir rakam mı ?
                {
                    MessageBox.Show("You must enter the fee price with only numbers");
                    return;
                }

                if (name.Equals(string.Empty) || fee.Equals(string.Empty))
                {
                    MessageBox.Show("You must enter the values");
                    return;
                }

                //var current = hospitalClinicExaminationsBindingSource.Current as HospitalClinicExamination;
                var current = new HospitalClinicExamination();
                current.HospitalClinicId = currentHospitalClinic.Id;
                current.Name = name;
                current.Fee = feeVal;

                hospitalClinicExaminationsBindingSource.Add(current);
            }

        }

        private void btnDeleteExamination_Click(object sender, EventArgs e)
        {
            var currentHospitalClinicExaminiation = (hospitalClinicExaminationsBindingSource.Current as HospitalClinicExamination);
            if (currentHospitalClinicExaminiation != null)
            {
                hospitalClinicExaminationsBindingSource.RemoveCurrent(); // kaysı tablodan sil
                if (currentHospitalClinicExaminiation.Id > 0) // veritaanın kayıtlı ise ordan da sil
                    HospitalClinicExaminationRepository.Delete(currentHospitalClinicExaminiation);

            }
        }
    }
}
