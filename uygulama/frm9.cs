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
    public partial class frm9 : Form
    {
        public frm9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 1, j = 2;

            if (i > j)
            {
                MessageBox.Show("i>j");
            }
            else
            {
                MessageBox.Show("i<j");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = 1, j = 1;

            if (i > j)
            {
                MessageBox.Show("i>j");
            }
            else
            {
                if (i == j)
                {
                    MessageBox.Show("i ve j birbirine eşit");
                }
                else
                {
                    MessageBox.Show("i<j");
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i = 101;

            int j = i % 2;

            if (j==0)
            {
                MessageBox.Show("Çift");
            }
            if (j == 1)
            {
                MessageBox.Show("Tek");
            }
        }
    }
}
