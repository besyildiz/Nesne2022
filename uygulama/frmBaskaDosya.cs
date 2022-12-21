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
    public partial class frmBaskaDosya : Form
    {
        public frmBaskaDosya()
        {
            InitializeComponent();
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            BenimSinifim b = new BenimSinifim
            {
                Ad = tbAd.Text,
                Soyad = tbSoyad.Text,
                Brans = tbBrans.Text
            };
            lb1.Items.Add( b.Ad + " " + b.Soyad + "-->" + b.Brans);



        }
    }
}
