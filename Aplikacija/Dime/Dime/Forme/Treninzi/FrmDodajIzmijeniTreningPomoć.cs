﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dime.Forme.Treninzi
{
    public partial class FrmDodajIzmijeniTreningPomoć : Form
    {
        public FrmDodajIzmijeniTreningPomoć()
        {
            InitializeComponent();
        }

        private void FrmDodajIzmijeniTreningPomoć_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
    }
}
