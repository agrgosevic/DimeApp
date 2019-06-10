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
    public partial class FrmUpravljanjeTreninzima : Form
    {
        public FrmUpravljanjeTreninzima()
        {
            InitializeComponent();
        }

        public void PrikaziSveTreninge()
        {
            using (var db = new DimeEntities())
            {
                var upit = from t in db.Treninzi
                           select t;
                treningBindingSource.DataSource = upit.ToList();
            }
        }

        private void FrmUpravljanjeTreninzima_Load(object sender, EventArgs e)
        {
            PrikaziSveTreninge();
        }

        private void btnNoviTrening_Click(object sender, EventArgs e)
        {
            FrmDodajIzmijeniTrening forma = new FrmDodajIzmijeniTrening();
            forma.ShowDialog();
            PrikaziSveTreninge();
        }

        private void btnIzmijeniTrening_Click(object sender, EventArgs e)
        {
            FrmDodajIzmijeniTrening forma = new FrmDodajIzmijeniTrening(treningBindingSource.Current as Trening);
            forma.ShowDialog();
            PrikaziSveTreninge();
        }

        private void btnObrisiTrening_Click(object sender, EventArgs e)
        {
            Trening izabraniTrening = treningBindingSource.Current as Trening;
            if (izabraniTrening != null)
            {
                using (var db = new DimeEntities())
                {
                    db.Treninzi.Attach(izabraniTrening);
                    db.Treninzi.Remove(izabraniTrening);
                    db.SaveChanges();
                }
                PrikaziSveTreninge();
            }
        }

        private void btnPomoć_Click(object sender, EventArgs e)
        {
            Pomoc();
        }

        private void FrmUpravljanjeTreninzima_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void FrmUpravljanjeTreninzima_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Pomoc();
        }

        private void Pomoc()
        {
            FrmUpravljanjeTreninzimaPomoc formaPomoć = new FrmUpravljanjeTreninzimaPomoc();
            formaPomoć.ShowDialog();
        }
    }
}
