using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DHT.App.WinForm
{
    // Bu projedeki bütün formlar bu CustomForm nesnesinden türemektedir.
    // Bütün formlarda ortak olan bazı işler bu form aracılığıla halledilmiştir
    public class CustomForm : Form
    {
        // windows form nesnesinden extend ettik
        public CustomForm() : base()
        {
            // form yüklendiğinde olayını manual olarak atadık
            Load += new EventHandler(this.CustomForm_Load);
        }

        // form yüklendiğinde
        private void CustomForm_Load(object sender, EventArgs e)
        {
            // mdiclient kontrollerini bul
            foreach (var item in GetControlsOfType<MdiClient>(this))
            {
                // arkaplan rengini ayarla
                item.BackColor = Color.Beige;
            }

            // formdaki datagridviewleri bul
            foreach (var item in GetControlsOfType<DataGridView>(this))
            {
                // arkaplan rengini ayarla
                item.BackgroundColor = Color.Beige;
            }
        }

        // bir tışa basıldığında tetiklenir
        // Esc tuşuna basıldığında fomrları kapatma özelliği bu şekilde eklendi
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // eğer tuş esc key ise
            if (keyData == Keys.Escape)
            {
                Close(); // formu kapat
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        // bir kontrol içerisindeki alt kontrolleri bulmaya yarayan fonksiyon
        public IEnumerable<T> GetControlsOfType<T>(Control root) where T : Control
        {
            var t = root as T;
            if (t != null)
                yield return t;

            foreach (Control c in root.Controls)
                foreach (var i in GetControlsOfType<T>(c))
                    yield return i;
        }
    }
}
