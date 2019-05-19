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
    public partial class PatientForm : CustomForm
    {
        Patient Current;
        public PatientForm()
        {
            InitializeComponent();
            patientBindingSource.CurrentItemChanged += (s, e) =>
            {
                Current = (Patient)patientBindingSource.Current;
            };

            RefreshData();
        }

        void RefreshData()
        {
            patientBindingSource.DataSource = PatientRepository.GetPatients();
        }

        private void PatientForm_Load(object sender, EventArgs e)
        {
            menuStrip1.AllowMerge = false;
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new PatientDetailsForm()
            {
                patient = new Patient(),
                StartPosition = FormStartPosition.CenterParent,
                Text = "Add New Patient"
            };
            form.ShowDialog(this);

            if (form.DialogResult == DialogResult.OK)
            {
                var patient = form.patient;
                var res = PatientRepository.InsertOrUpdate(patient);
                if (res > 0)
                {
                    MessageBox.Show("Added");
                }
                RefreshData();
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new PatientDetailsForm()
            {
                patient = Current,
                StartPosition = FormStartPosition.CenterParent,
                Text = "Edit Patient - " + Current.Firstname + " " + Current.Lastname
            };
            form.ShowDialog(this);

            if (form.DialogResult == DialogResult.OK)
            {
                var patient = form.patient;
                var res = PatientRepository.InsertOrUpdate(patient);
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
                PatientRepository.Delete(Current);
                RefreshData();
            }
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshData();
        }
    }
}
