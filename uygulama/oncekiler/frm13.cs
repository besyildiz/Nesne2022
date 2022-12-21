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
    public partial class frm13 : Form
    {
        public frm13()
        {
            InitializeComponent();
        }

        private void frm13_Load(object sender, EventArgs e)
        {
            
            if ((1 < 0 || 0 < 1 || 2 < 1 || 3 < 2 || 4 <3)) 
            {
                MessageBox.Show("Karşılaştırma doğrudur");
            }
        }
    }
}
