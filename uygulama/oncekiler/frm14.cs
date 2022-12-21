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
    public partial class frm14 : Form
    {
        public frm14()
        {
            InitializeComponent();
        }

        private void frm14_Load(object sender, EventArgs e)
        {
            if (!(1<2))
            {
                MessageBox.Show("Doğru");
            }
            else
            {
                MessageBox.Show("Yanlış");

            }
        }
    }
}
