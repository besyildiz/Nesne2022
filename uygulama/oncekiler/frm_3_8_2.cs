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
    public partial class frm_3_8_2 : Form
    {
        public frm_3_8_2()
        {
            InitializeComponent();
        }
        class Otomobil
        {
            string marka = ""; string renk = ""; public Otomobil()
            {
                marka = "TOGG"; renk = "kırmızı";
                MessageBox.Show("Yapıcı metot çalıştı.");
            }
            ~Otomobil()
            {
                MessageBox.Show("Nesne hafızadan atıldı.");

            }
        }
        private void bt1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Program başladı.");

Otomobil oto = new Otomobil();
            MessageBox.Show("Program bitti.");
      

        }




    }
}
