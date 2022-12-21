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
    public partial class frm_3_7_5 : Form
    {
        public frm_3_7_5()
        {
            InitializeComponent();
        }
        class ToplamaIslemi
        {
            public int Topla(int a, int b)
            {
                MessageBox.Show("int parametreli metot çağrılıyor." + (a + b).ToString());
                return a + b;
            }
            public int Topla(params int[] sayilar)
            {
              
                int toplam = 0;
                foreach (var s in sayilar)
                {
                    toplam += s;
                }
                MessageBox.Show("params parametreli metot çağrılıyor." + (toplam).ToString());
                return toplam;
            }
            public double Topla(double a, double b)
            {
                MessageBox.Show("double parametreli metot çağrılıyor."+(a + b).ToString());
                return a + b;
            }
            public string Topla(string a, string b)
            {
                MessageBox.Show("string parametreli metot çağrılıyor." + (a + b).ToString());
                return a + b;
            }
        }
        private void bt1_Click(object sender, EventArgs e)
        {
            ToplamaIslemi ti = new ToplamaIslemi();
            ti.Topla(2, 5);
            ti.Topla(3.3, 5.1);
            ti.Topla("Sağlıcakla", "kalınız.");
            ti.Topla(3, 8, 3, 7, 12, 33, 11, 4);

            MessageBox.Show("Selam");
            MessageBox.Show("Selam", "Başlık");



        }
    }
}
