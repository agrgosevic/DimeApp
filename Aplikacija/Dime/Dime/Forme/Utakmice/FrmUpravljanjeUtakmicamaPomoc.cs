﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dime.Forme.Utakmice
{
    public partial class FrmUpravljanjeUtakmicamaPomoc : Form
    {
        public FrmUpravljanjeUtakmicamaPomoc()
        {
            InitializeComponent();
        }

        private void FrmUpravljanjeUtakmicamaPomoc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
    }
}