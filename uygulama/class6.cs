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
    public partial class class6 : Form
    {
        public class6()
        {
            InitializeComponent();
        }
        class SayiIslemleri
        {
            public int Toplam(params int[] sayilar)
            {
                int toplam = 0;
                foreach (var s in sayilar)
                {
                    toplam += s;
                }
                return toplam;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SayiIslemleri si = new SayiIslemleri();
            listBox1.Items.Add("Toplam: "+ si.Toplam(3));
            listBox1.Items.Add("Toplam: "+ si.Toplam(3, 4, 5));
            listBox1.Items.Add("Toplam: "+ si.Toplam(5, 1, 7, 3, 4, 5));
        }
    }
}
