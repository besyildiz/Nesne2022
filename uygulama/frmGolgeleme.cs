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
    public partial class frmGolgeleme : Form
    {
        public frmGolgeleme()
        {
            InitializeComponent();
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            Ogretmen o = new Ogretmen
            {
                Ad = tbAd.Text,
                Soyad = tbSoyad.Text,
                Brans = tbBrans.Text,
               
            };
            o.goster();
        }

        public class OkulPersoneli
        {
            public string Ad { get; set; }
            public string Soyad { get; set; }
            public new void goster()
            {
                MessageBox.Show(Ad + " " + Soyad);
            }
        }

        public  class Ogretmen : OkulPersoneli
        {
            public string Brans { get; set; }
            public  void  goster()
            {
                MessageBox.Show(Ad + " " + Soyad + " " + Brans);
            }
        }


    }
}
