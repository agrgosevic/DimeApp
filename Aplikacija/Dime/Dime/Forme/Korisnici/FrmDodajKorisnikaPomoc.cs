﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dime.Forme.Korisnici
{
    public partial class FrmDodajKorisnikaPomoc : Form
    {
        public FrmDodajKorisnikaPomoc()
        {
            InitializeComponent();
        }

        private void FrmDodajKorisnikaPomoc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
    }
}
