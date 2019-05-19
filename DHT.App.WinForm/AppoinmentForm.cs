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
    public partial class AppoinmentForm : CustomForm
    {
        Appoinment Current;

        public AppoinmentForm()
        {
            InitializeComponent();
            appoinmentBindingSource.CurrentItemChanged += (s, e) =>
            {
                Current = (Appoinment)appoinmentBindingSource.Current;
            };

            RefreshData();
        }

        void RefreshData()
        {
            appoinmentBindingSource.DataSource = AppoinmentRepository.GetAppoinments();
        }

        private void AppoinmentForm_Load(object sender, EventArgs e)
        {
            menuStrip1.AllowMerge = false;
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new AppoinmentDetailsForm()
            {
                appoinment = new Appoinment(),
                StartPosition = FormStartPosition.CenterParent,
                Text = "Add New Appoinment"
            };
            form.ShowDialog(this);

            if (form.DialogResult == DialogResult.OK)
            {
                var appoinment = form.appoinment;
                var res = AppoinmentRepository.InsertOrUpdate(appoinment);
                if (res > 0)
                {
                    MessageBox.Show("Added");
                }
                RefreshData();
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new AppoinmentDetailsForm()
            {
                appoinment = Current,
                StartPosition = FormStartPosition.CenterParent,
                Text = "Update Appoinment"
            };
            form.ShowDialog(this);

            if (form.DialogResult == DialogResult.OK)
            {
                var appoinment = form.appoinment;
                var res = AppoinmentRepository.InsertOrUpdate(appoinment);
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
                AppoinmentRepository.Delete(Current);
                RefreshData();
            }
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

    }
}
