﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dime.Forme.Igraci
{
    public partial class FrmDodajIgracaPomoc : Form
    {
        public FrmDodajIgracaPomoc()
        {
            InitializeComponent();
        }

        private void FrmDodajIgracaPomoc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
    }
}
