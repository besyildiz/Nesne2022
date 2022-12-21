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
    public partial class frmAbstract : Form
    {
        public frmAbstract()
        {
            InitializeComponent();
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            Otomobil oto = new Otomobil
            {
                ModelYili = 2020,
                MotorHacmi = 1600,
                OtomatikVites = true
            };
            oto.Calis();
            oto.Dur();
        }

    }
    public abstract class MotorluArac
    {
        public int MotorHacmi { get; set; }
        public int ModelYili { get; set; }
        public abstract void Calis();
        public abstract void Dur();
    }

    public class Otomobil : MotorluArac
    {
        public bool OtomatikVites { get; set; }
        public override void Calis()
        {
            MessageBox.Show("Otomobil çalıştı.");

        }
        public override void Dur()
        {
            MessageBox.Show("Otomobil durdu.");

        }
    }

}


