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
    public partial class frm_3_8_1 : Form
    {
        public frm_3_8_1()
        {
            InitializeComponent();
        }
        class Kisi
        {
            int yas;
            string ad;
            public Kisi()
            {
                yas = 19;
                ad = "Ahmet";
                MessageBox.Show("Yapıcı metot çalıştı.");

            }
            public int Yas
            {
                get
                {
                    return yas;
                }
            }
            public string Ad
            {
                get
                {
                    return ad;
                }
            }
        }
        private void bt1_Click(object sender, EventArgs e)
        {
       
            MessageBox.Show("Program başladı.");

            Kisi k = new Kisi();
            MessageBox.Show("Adı: "+k.Ad + " Yaşı: " + k.Yas);

            MessageBox.Show("Program bitti.");

        }
    }
}
