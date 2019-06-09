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
    public partial class FrmUpravljanjeUtakmicama : Form
    {
        public FrmUpravljanjeUtakmicama()
        {
            InitializeComponent();
        }

        private void PrikaziSveUtakmice()
        {
            using (var db = new DimeEntities())
            {
                var upit = from u in db.Utakmice select u;
                utakmicaBindingSource.DataSource = upit.ToList();
            }
        }

        private void btnDodajUtakmicu_Click(object sender, EventArgs e)
        {
            FrmDodajIzmijeniUtakmicu forma = new FrmDodajIzmijeniUtakmicu();
            forma.ShowDialog();
            PrikaziSveUtakmice();
        }

        private void FrmUpravljanjeUtakmicama_Load(object sender, EventArgs e)
        {
            PrikaziSveUtakmice();
        }
    }
}