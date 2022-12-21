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
    public partial class frm8 : Form
    {
        public frm8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, c, d;
            a = 1;
            b = 2;
            c = 3;

            d = a + b;
            b = d + a;
            d = b + d;
            d = 0;
            int sil = 0;
        }
    }
}
