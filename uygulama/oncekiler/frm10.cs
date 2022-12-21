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
    public partial class frm10 : Form
    {
        public frm10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int puan = Convert.ToInt32(tb1.Text);

            if (puan<25)
            {
                lbSonuc.Text = "0";
            }
            else
            {
                if (puan<50)
                {

                    lbSonuc.Text = "1";
                }
                else
                {
                    if (puan<55)
                    {
                        lbSonuc.Text = "2";
                    }
                    else
                    {
                        if (puan<70)
                        {
                            lbSonuc.Text = "3";
                        }
                        else
                        {
                            if (puan<85)
                            {
                                lbSonuc.Text = "4";
                            }
                            else
                            {
                                lbSonuc.Text = "5";
                            }
                        }
                    }
                }
            }
        }
    }
}
