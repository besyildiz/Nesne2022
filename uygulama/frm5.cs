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
    public partial class frm5 : Form
    {
        public frm5()
        {
            InitializeComponent();
        }

        private void btSari_Click(object sender, EventArgs e)
        {
            btSari.ForeColor = Color.Yellow;
        }

        private void btYesil_Click(object sender, EventArgs e)
        {
            btYesil.ForeColor = Color.Green;
        }

        private void btMavi_Click(object sender, EventArgs e)
        {
            btMavi.ForeColor = Color.Blue;
        }

        private void btKirmizi_Click(object sender, EventArgs e)
        {
            btKirmizi.ForeColor = Color.Red;
        }

        private void btSifirla_Click(object sender, EventArgs e)
        {
            btSari.ForeColor = Color.White;
            btKirmizi.ForeColor = Color.White;
            btMavi.ForeColor = Color.White;
            btYesil.ForeColor = Color.White;
        }
    }
}
