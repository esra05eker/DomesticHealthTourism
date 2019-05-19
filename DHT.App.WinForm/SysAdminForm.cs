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
    public partial class SysAdminForm : CustomForm
    {
        SysAdmin Current;
        public SysAdminForm()
        {
            InitializeComponent();
            sysAdminBindingSource.CurrentItemChanged += (s, e) =>
            {
                Current = (SysAdmin)sysAdminBindingSource.Current;
            };

            RefreshData();
        }

        void RefreshData()
        {
            sysAdminBindingSource.DataSource = SysAdminRepository.GetSysAdmins();
        }

        private void SysAdminForm_Load(object sender, EventArgs e)
        {
            menuStrip1.AllowMerge = false;
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new SysAdminDetailsForm()
            {
                sysAdmin = new SysAdmin(),
                StartPosition = FormStartPosition.CenterParent,
                Text = "Add New System Administrator"
            };
            form.ShowDialog(this);

            if (form.DialogResult == DialogResult.OK)
            {
                var sysAdmin = form.sysAdmin;
                var res = SysAdminRepository.InsertOrUpdate(sysAdmin);
                if (res > 0)
                {
                    MessageBox.Show("Added");
                }
                RefreshData();
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new SysAdminDetailsForm()
            {
                sysAdmin = Current,
                StartPosition = FormStartPosition.CenterParent,
                Text = "Edit System Administrator - " + Current.Firstname + " " + Current.Lastname
            };
            form.ShowDialog(this);

            if (form.DialogResult == DialogResult.OK)
            {
                var sysAdmin = Current;
                var res = SysAdminRepository.InsertOrUpdate(sysAdmin);
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
                SysAdminRepository.Delete(Current);
                RefreshData();
            }
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshData();
        }
    }
}
