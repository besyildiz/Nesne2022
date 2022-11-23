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
    public partial class frm11 : Form
    {
        public frm11()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string gun = tb1.Text;



            switch (gun)
            {
                case "1":lbSonuc.Text = "Haftanın 1. günü pazartesidir"; break;
                case "2": lbSonuc.Text = "Haftanın 2. günü salıdır"; break;
                case "3": lbSonuc.Text = "Haftanın 3. günü çarşambadır"; break;
                case "4": lbSonuc.Text = "Haftanın 4. günü perşembedir"; break;
                case "5": lbSonuc.Text = "Haftanın 5. günü cumadır"; break;
                case "6": lbSonuc.Text = "Haftanın 6. günü cumartesidir"; break;
                case "7": lbSonuc.Text = "Haftanın 7. günü pazardır"; break;
                default:   lbSonuc.Text = "Geçersiz bir değer belirttiniz"; break;
            }

        }
    }
}
