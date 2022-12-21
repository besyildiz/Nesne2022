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
    public partial class ornek_3_7_1 : Form
    {
        public ornek_3_7_1()
        {
            InitializeComponent();
        }


        class Sinifim
        {
            public void Selamla(string ad = "Denizhan")
            {
                MessageBox.Show("Merhaba " +ad);

              
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Sinifim s = new Sinifim();
            s.Selamla();
            s.Selamla(tb1.Text);
        }


       

    }
}
