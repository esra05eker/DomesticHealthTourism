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
    public partial class HospitalForm : CustomForm
    {
        // tabloda o an ki seçili olan kayıt / nesne / hastane
        Hospital Current;

        public HospitalForm()
        {
            InitializeComponent();

            // dinamik olan seçili kayıt değiştikçe Current nesnesi de değiştiriliyor
            hospitalBindingSource.CurrentItemChanged += (s, e) =>
            {
                Current = (Hospital)hospitalBindingSource.Current;
            };

            // yenile
            RefreshData();
        }

        void RefreshData()
        {
            // veritabanında verileri çek ve bndingsoruce'un datasource'una ekle
            // gridview'in datasource'u da zaten bindingsource olduğu için veriler tabloda görünecek
            hospitalBindingSource.DataSource = HospitalRepository.GetHospitals();
        }

        private void HospitalForm_Load(object sender, EventArgs e)
        {
            // menüleri mdi parent formdaki menü ile birleştirme
            menuStrip1.AllowMerge = false;
        }

        // ekle menüsüne tıklandığında
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new HospitalDetailsForm()
            {
                hospital = new Hospital(), // yeni oluşturr
                StartPosition = FormStartPosition.CenterParent, // pencere ekranın ortasında açılsın
                Text = "Add New Hospital" // form penceresinin adı
            };
            form.ShowDialog(this);

            if (form.DialogResult == DialogResult.OK)
            {
                var hospital = form.hospital; // işlem yapılan nesneyi al
                var res = HospitalRepository.InsertOrUpdate(hospital); // veritabınında insert veya update yap

                if (res > 0) // result anlamında res, değişiklik sayısı (eğer değişiklik yapıldıysa)
                {
                    MessageBox.Show("Added");
                }
                RefreshData();
            }
        }

        // düzenle menüsüne tıklandığına
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new HospitalDetailsForm()
            {
                hospital = Current, // tabloda seçili olan nesneyi düzenleyeceğiz
                StartPosition = FormStartPosition.CenterParent,
                Text = "Edit Hospital - " + Current.Name
            };
            form.ShowDialog(this);

            if (form.DialogResult == DialogResult.OK)
            {
                var hospital = form.hospital;
                var res = HospitalRepository.InsertOrUpdate(hospital); // hastane ile ilgili blgileri kaydet
                var res2 = HospitalClinicRepository.InsertOrUpdateAll(hospital.Clinics); // hastanenin klinikleri ile ilgili bilgileri kaydet

                var res3 = 0;
                foreach (var clinic in hospital.Clinics)
                {
                    // Hastanenin kliniklerinin muayenelerini kaydet
                    res3 = res3 + HospitalClinicExaminationRepository.InsertOrUpdateAll(clinic.HospitalClinicExaminations);
                }

                if (res + res2 + res3 > 0)
                {
                    MessageBox.Show("Updated");
                }

                RefreshData(); // verileri yenile
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Current != null)
            {
                HospitalRepository.Delete(Current);
                RefreshData();
            }

        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshData();
        }
    }
}

