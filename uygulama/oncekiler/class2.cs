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
    public partial class class2 : Form
    {
        public class2()
        {
            InitializeComponent();
        }

        public class Ucgen
        {
            public int A { get; set; }
            public int B { get; set; }
            public int C { get; set; }
            // ...
            internal int Cevre
            {
                get
                {
                    return A+B+C;
                }
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {

            Ucgen ucgen = new Ucgen();
            ucgen.A = 3;
            ucgen.B = 4;
            ucgen.C = 5;

            listBox1.Items.Add("Üçgenin çevresi--> " + ucgen.Cevre.ToString());
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
