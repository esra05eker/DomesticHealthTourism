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
    public partial class DoctorForm : CustomForm
    {
        Doctor Current;

        public DoctorForm()
        {
            InitializeComponent();
            doctorBindingSource.CurrentItemChanged += (s, e) =>
            {
                Current = (Doctor)doctorBindingSource.Current;
            };

            RefreshData();
        }

        void RefreshData()
        {
            doctorBindingSource.DataSource = DoctorRepository.GetDoctors();
        }

        private void DoctorForm_Load(object sender, EventArgs e)
        {
            menuStrip1.AllowMerge = false;
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new DoctorDetailsForm()
            {
                doctor = new Doctor(),
                StartPosition = FormStartPosition.CenterParent,
                Text = "Add New Doctor"
            };
            form.ShowDialog(this);

            if (form.DialogResult == DialogResult.OK)
            {
                var doctor = form.doctor;
                var res = DoctorRepository.InsertOrUpdate(doctor);
                if (res > 0)
                {
                    MessageBox.Show("Added");
                }
                RefreshData();
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new DoctorDetailsForm()
            {
                doctor = Current,
                StartPosition = FormStartPosition.CenterParent,
                Text = "Edit Doctor - " + Current.Firstname + " " + Current.Lastname
            };
            form.ShowDialog(this);

            if (form.DialogResult == DialogResult.OK)
            {
                var doctor = form.doctor;
                var res = DoctorRepository.InsertOrUpdate(doctor);
                if (res > 0)
                {
                    MessageBox.Show("Updated");
                }
                RefreshData();
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Current != null)
            {
                DoctorRepository.Delete(Current);
                RefreshData();
            }
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshData();
        }
    }
}
