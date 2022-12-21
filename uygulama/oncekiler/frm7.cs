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
    public partial class frm7 : Form
    {
        public frm7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //    

            /*  
            çay bardağı var
            su bardağı var


                  bardak--->değişken

                                sayısal değişken---->1, 2, 3, 4, -4, 3.16
                  alfasayısal(metinsel) değişken---->a,b,c, eyüp,isa

      */
            int bardakSayisal = 5;  //  5---> su. bardakSayisal---> bardağın ismi
            int bardakSayisal2 = 5;  //  5---> değer. bardakSayisal-->değişken ismi
                                                         // int tipinde tam sayılar tutulur.

            double bardakReelSayi = 3.14; //double tipinde reel sayılar tutulur. 
            bardakReelSayi = 8.1;


            string ifade= "Zeynep"; // string--->metinsel ifadeler anlamına geliyor
            char harf = 'a'; // char içinsadece harf tanımlaması yapabilirsiniz.

            // int, double, string, char, bool
            ulong eyüp;
            ulong Eyüp;

            string metin = textBox1.Text;
            double sonuc = 1 +Convert.ToDouble(metin);

            MessageBox.Show(sonuc.ToString());
        }
    }
}
