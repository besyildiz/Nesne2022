using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uygulama
{
    public partial class frmMiras : Form
    {
        public frmMiras()
        {
            InitializeComponent();
        }

        public class OkulPersoneli
        {
            public string Ad { get; set; }
            public string Soyad { get; set; }
        }
        public class Ogretmen :OkulPersoneli
        {
            public string Brans { get; set; }
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            Ogretmen o = new Ogretmen
            {
                Brans = tbBrans.Text,
                Ad = tbAd.Text,
                Soyad = tbSoyad.Text
            };


            lb1.Items.Add(o.Ad + " " + o.Soyad + " " + o.Brans);
        }
    }
}
