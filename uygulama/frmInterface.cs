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
    public partial class frmInterface : Form
    {
        public frmInterface()
        {
            InitializeComponent();
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            Kedi kedi = new Kedi();
            kedi.SesCikar();
            kedi.Beslen();

            Kopek kopek = new Kopek();
            kopek.SesCikar();
            kopek.Beslen();

            IHayvan hayvan1 = kedi;
            IHayvan hayvan2 = kopek;
            hayvan1.SesCikar();
            hayvan2.SesCikar();
            IBeslen beslen1 = kedi;
            IBeslen beslen2 = kopek;
            beslen1.Beslen();
            beslen2.Beslen();
        }

        interface IHayvan
        {
            void SesCikar();
        }
        interface IBeslen
        {
            void Beslen();
        }

        public class Kedi : IHayvan, IBeslen
        {
            public void SesCikar()
            {
                MessageBox.Show("Kedi: miyav");
                
            }
            public void Beslen()
            {
                MessageBox.Show("Kedi süt içti.");

               
            }
             
        }

        public class Kopek : IHayvan, IBeslen
        {
            public void SesCikar()
            {
                MessageBox.Show("Köpek: hav hav");

            }
            public void Beslen()
            {
                MessageBox.Show("Köpek et yedi.");

            }
        }
    }
}
