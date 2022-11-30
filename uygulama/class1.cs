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
    public partial class class1 : Form
    {
        public class1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dikdortgen d1 = new Dikdortgen(4,5);
            Daire daire = new Daire(6);
            listBox1.Items.Add("Dikdörtgenin çevresi-->"+d1.CevreHesaplama().ToString());
            listBox1.Items.Add("Dikdörtgenin alanı-->" + d1.AlanHesaplama().ToString());
            listBox1.Items.Add("Dairenin çevresi-->" + daire.CevreHesaplama().ToString());
            listBox1.Items.Add("Dairenin alanı-->" + daire.AlanHesaplama().ToString());
        }


        class Dikdortgen
        {

            private int a, b;

            public Dikdortgen(int a, int b)
            {
                this.a = a;
                this.b = b;

            }

            public int AlanHesaplama()
            {
                return a * b;
            }

            public int CevreHesaplama()
            {
                return 2 *( a+ b);
            }

        }




        class Daire
        {

            private int r;

            public Daire(int r)
            {
                this.r = r;


            }

            public int AlanHesaplama()
            {
                return 3 * r * r;
            }

            public int CevreHesaplama()
            { return 2 * 3 * r; }

        }





    }
}
