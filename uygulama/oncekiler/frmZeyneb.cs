﻿using System;
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
    public partial class frmZeyneb : Form
    {
        public frmZeyneb()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show((Convert.ToInt32(tb1.Text)* Convert.ToInt32(tb2.Text)).ToString());
        }
    }
}
