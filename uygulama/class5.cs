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
    public partial class class5 : Form
    {
        public class5()
        {
            InitializeComponent();
        }
        class SayiIslemleri
        {
            public int Topla(int sayi1, int sayi2, int sayi3)
            {
                return sayi1 + sayi2 + sayi3;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SayiIslemleri si = new SayiIslemleri();
            // int toplam = si.Topla(5, 10, 15);
            int toplam = si.Topla(sayi2: 10, sayi3: 15, sayi1: 5);


             
            listBox1.Items.Add("Toplam: "+ toplam);
        }
    }
}
