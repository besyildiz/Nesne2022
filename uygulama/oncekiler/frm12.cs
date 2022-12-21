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
    public partial class frm12 : Form
    {
        public frm12()
        {
            InitializeComponent();
        }

        private void frm12_Load(object sender, EventArgs e)
        {

        /*
            if (!(1<2))
            {
                MessageBox.Show("Doğru");
            }
            else
            {
                MessageBox.Show("Yanlış");
            }        
      */
            /*     if ((1<2)&& (2<3))
                {
                    MessageBox.Show("Doğru");
                }
                else
                {
                    MessageBox.Show("Yanlış");
                }
                 */

            /*
            if ((1 < 2) && (2 < 1))
               {
                   MessageBox.Show("Doğru");
               }
               else
               {
                   MessageBox.Show("Yanlış");
               }
                 */

            if ((1 < 2) || (2 < 1))
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
