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
    public partial class frm_3_7_4 : Form
    {
        public frm_3_7_4()
        {
            InitializeComponent();
        }


        class EkranIslem
        {
            public void EkranaYaz(params int[] sayilar)
            {
                if (sayilar.Length == 0)
                {
                    MessageBox.Show("Parametre olmadığı için metottan çıkılıyor.");

                    return;
                }
                MessageBox.Show("Parametreden gelen değerler:");

                foreach (var s in sayilar)
                {
                    MessageBox.Show(s.ToString());
         
                }
            }

        }
        private void bt1_Click(object sender, EventArgs e)
        {
            {
                EkranIslem ei = new EkranIslem();
                ei.EkranaYaz(3, 4, 5);
                MessageBox.Show("=======================");

                ei.EkranaYaz();
            }
        }
    }
}
