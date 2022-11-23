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
    public partial class frm3 : Form
    {
        public frm3()
        {
            InitializeComponent();
        }

        private void lb1_MouseMove(object sender, MouseEventArgs e)
        {
            lbSonuc.Text = "Fare hareket etti";
        }

        private void lb1_MouseLeave(object sender, EventArgs e)
        {
            lbSonuc.Text = "Fare ayrıldı";
        }
    }
}
