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
    public partial class ClinicForm : CustomForm
    {
        Clinic Current;
        public ClinicForm()
        {
            InitializeComponent();

            clinicBindingSource.CurrentItemChanged += (s, e) =>
            {
                Current = (Clinic)clinicBindingSource.Current;
            };

            RefreshData();
        }
        void RefreshData()
        {
            clinicBindingSource.DataSource = ClinicRepository.GetClinics();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            menuStrip1.AllowMerge = false;
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new ClinicDetailsForm()
            {
                clinic = new Clinic(),
                StartPosition = FormStartPosition.CenterParent,
                Text = "Add New Clinic"
            };
            form.ShowDialog(this);

            if (form.DialogResult == DialogResult.OK)
            {
                var clinic = form.clinic;
                var res = ClinicRepository.InsertOrUpdate(clinic);
                if (res > 0)
                {
                    MessageBox.Show("Added");
                }
                RefreshData();
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new ClinicDetailsForm()
            {
                clinic = Current,
                StartPosition = FormStartPosition.CenterParent,
                Text = "Edit Clinic - " + Current.Name
            };
            form.ShowDialog(this);

            if (form.DialogResult == DialogResult.OK)
            {
                var clinic = form.clinic;
                var res = ClinicRepository.InsertOrUpdate(clinic);
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
                ClinicRepository.Delete(Current);
                RefreshData();
            }
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshData();
        }
    }
}
