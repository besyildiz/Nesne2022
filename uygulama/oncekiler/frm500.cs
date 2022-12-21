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
    public partial class frm500 : Form
    {
        public frm500()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int eyup = 500;
            MessageBox.Show(eyup.ToString());
        }
    }
}
