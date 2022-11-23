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
    public partial class frm6 : Form
    {
        public frm6()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            pb1.Visible = true;
            pb2.Visible = false;
            pb3.Visible = false;

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            pb1.Visible = false;
            pb2.Visible = true;
            pb3.Visible = false;

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pb1.Visible = false;
            pb2.Visible = false;
            pb3.Visible = true;

        }
    }
}
