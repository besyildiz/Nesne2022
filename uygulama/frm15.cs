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
    public partial class frm15 : Form
    {
        public frm15()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //    rt1.Text = "1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 21 22 23 24 25 26 27 28 29 30 31 32 33 34 35 36 37 38 39 40";

            for (int i = 0; i <= 1000; i=i+10)
                rt1.Text = rt1.Text + " " +i.ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 10; i < 111; i += 10) /// i=i+10 yerine i+=10
            {
                listBox1.Items.Add(i.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i = 100;
            while (i>=0)
            {
                listBox2.Items.Add(i);
                i -= 10;// i-=10;   i = i - 10;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int i = 100;
            do
            {
                listBox3.Items.Add(i);
                i -= 10; 
            } while (i >= 0);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
            {
                if (i==11)
                 break;
                  else listBox4.Items.Add(i.ToString());    
                 
              
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
            {
                if (i == 11)
                    continue;
                else listBox5.Items.Add(i.ToString());


            }
        }
    }
}
