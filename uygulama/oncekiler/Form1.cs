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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btMesaj_Click(object sender, EventArgs e)
        {
            MessageBox.Show(tbMesaj.Text);
        }

        private void btDegistir_Click(object sender, EventArgs e)
        {
            tbMesaj.ForeColor = Color.Red; //Yazı rengini kırmızı yapar.
            tbMesaj.Enabled = false; //Nesneyi pasifleştirir. Artık metin girişi yapılamaz.
            tbMesaj.Visible = false; //Nesneyi görünmez hâle getirir.
            tbMesaj.Font = new Font("Broadway", 16); //Yazı tipi ve boyutu değişir.
        }

        private void btGoster_Click(object sender, EventArgs e)
        {
            tbMesaj.Visible = true;
        }
    }
}
