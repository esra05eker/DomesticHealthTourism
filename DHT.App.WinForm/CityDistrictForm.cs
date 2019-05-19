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
    public partial class CityDistrictForm : CustomForm
    {
        City CurrentCity;
        District CurrentDistrict;

        public CityDistrictForm()
        {
            InitializeComponent();
            //image in piksel verilerine ulaşmak için bitmap sınıfını kullandık
            btnAddNewCity.Image = new Bitmap(Properties.Resources.plus, new Size(32, 32)); // (+) simgesi eklemek için
            btnAddNewDistrict.Image = new Bitmap(Properties.Resources.plus, new Size(32, 32)); 
            btnDeleteCity.Image = new Bitmap(Properties.Resources.error, new Size(32, 32)); // (-) simgesi eklemek için 
            btnDeleteDistrict.Image = new Bitmap(Properties.Resources.error, new Size(32, 32)); 
            btnSaveCity.Image = new Bitmap(Properties.Resources.success, new Size(32, 32)); // (✔) simgesi eklemek için
            btnSaveDistrict.Image = new Bitmap(Properties.Resources.success, new Size(32, 32));

            // seçili kayıt değiştiğinde
            cityBindingSource.CurrentItemChanged += (s, e) =>
            {
                CurrentCity = (City)cityBindingSource.Current;
                if (CurrentCity != null)
                {
                    // seçili ilin ilçelerini yükle
                    districtBindingSource.DataSource = CurrentCity.Districts.OrderBy(a => a.Name).ToList();
                }
                else
                {
                    // seçili il yoksa ilçeleri boşalt
                    districtBindingSource.DataSource = null;
                }
            };

            // seçili ilçe değiştiğinde
            districtBindingSource.CurrentChanged += (s, e) =>
            {
                CurrentDistrict = (District)districtBindingSource.Current;
            };

            // şehir kodu textalanındaki veri ile cityBindingSource daki city nesnesinin Code property'sini birbirine bağla
            txtCityCode.DataBindings.Add("Text", cityBindingSource, "Code");

            // şehir adı textalanındaki veri ile cityBindingSource daki city nesnesinin Name property'sini birbirine bağla
            txtCityName.DataBindings.Add("Text", cityBindingSource, "Name");

            // ilçe adı textalanındaki veri ile districtBindingSource daki city nesnesinin Name property'sini birbirine bağla
            txtDistrictName.DataBindings.Add("Text", districtBindingSource, "Name");

            // il adı text alanındaki veri ile districtBindingSource daki City nesnesinin toString() metodundan gelen veriyi birbirine bağla
            txtDistrictCityCode.DataBindings.Add("Text", districtBindingSource, "City");
        }

        // kayıtları yeniden getir
        void RefreshData()
        {
            // şehirleri getir
            cityBindingSource.DataSource = CityRepository.GetCities();
            if (CurrentCity != null) // eğer seçili il var ise
            {
                // ilçeleri getir
                districtBindingSource.DataSource = CurrentCity.Districts.OrderBy(a => a.Name).ToList();
            }

        }

        private void CityDistrictForm_Load(object sender, EventArgs ev)
        {
            RefreshData();


            dataGridView1.ReadOnly = true; // saltokunur
            dataGridView1.RowHeadersVisible = false; // sol taraftaki gereksiz görüntüyü gösterme
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // tablodaki satırara tıklandığında tüm satırı çek

            dataGridView2.ReadOnly = true; // saltokunur
            dataGridView2.RowHeadersVisible = false; // sol taraftaki gereksiz görüntüyü gösterme
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // tablodaki satırara tıklandığında tüm satırı çek


        }

        private void btnAddNewCity_Click(object sender, EventArgs e)
        {
            cityBindingSource.AddNew(); // yeni kayıt ekle
        }

        private void btnAddNewDistrict_Click(object sender, EventArgs e)
        {
            districtBindingSource.AddNew(); // yeni kayıt ekle
            CurrentDistrict.CityId = CurrentCity.Id;
        }

        private void btnDeleteCity_Click(object sender, EventArgs e)
        {
            if (CurrentCity == null) // seçili bir şehir yoksa silinecek bir şehir de yok :)
            {
                MessageBox.Show("Select city");
                return;
            }
            else
            {
                if (CurrentCity != null && CurrentCity.Id > 0)
                    CityRepository.Delete(CurrentCity);
                cityBindingSource.RemoveCurrent();
                RefreshData();
            }
        }

        private void btnDeleteDistrict_Click(object sender, EventArgs e)
        {
            if (CurrentDistrict == null) // seçili bir ilçe yoksa silinecek bir ilçe de yok :)
            {
                MessageBox.Show("Select city");
            }
            else
            {
                DistrictRepository.Delete(CurrentDistrict);
                RefreshData();
            }
        }

        private void btnSaveCity_Click(object sender, EventArgs e)
        {
            if (CityRepository.InsertOrUpdate(CurrentCity) > 0)
            {
                MessageBox.Show("Saved");
                RefreshData();
            }

        }

        private void btnSaveDistrict_Click(object sender, EventArgs e)
        {

            if (DistrictRepository.InsertOrUpdate(CurrentDistrict) > 0)
            {
                MessageBox.Show("Saved");
                RefreshData();
            }
        }
    }
}
