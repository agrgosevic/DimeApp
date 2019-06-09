using Dime.Forme;
using Dime.Forme.Treninzi;
using Dime.Forme.Utakmice;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dime
{
    public partial class FrmGlavniIzbornik : Form
    {
        string ime = "";
        string prezime = "";
        public FrmGlavniIzbornik(string imeKorisnika, string prezimeKorisnika)
        {
            InitializeComponent();
            ime = imeKorisnika;
            prezime = prezimeKorisnika;
            lblImeKorisnika.Text = ime + " " + prezime;
        }
        private void btnStatistika_Click(object sender, EventArgs e)
        {
            FrmStatistikeUtakmica forma = new FrmStatistikeUtakmica();
            forma.ShowDialog();
        }
        private void btnAktivnosti_Click(object sender, EventArgs e)
        {
            FrmPopisAktivnosti forma = new FrmPopisAktivnosti();
            forma.ShowDialog();
        }
        private void btnIgraci_Click(object sender, EventArgs e)
        {
            FrmPopisIgraca forma = new FrmPopisIgraca();
            this.Hide();
            forma.ShowDialog();
            this.Show();
        }
        private void btnKorisnici_Click(object sender, EventArgs e)
        {
            FrmPopisKorisnika forma = new FrmPopisKorisnika();
            this.Hide();
            forma.ShowDialog();
            this.Show();
        }
        private void btnTreninzi_Click(object sender, EventArgs e)
        {
            FrmUpravljanjeTreninzima forma = new FrmUpravljanjeTreninzima();
            forma.ShowDialog();
        }
        private void btnPomoc_Click(object sender, EventArgs e)
        {
            Pomoc();
        }
        private void FrmGlavniIzbornik_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Pomoc();
        }
        private void Pomoc()
        {
            FrmGlavniIzbornikPomoc forma = new FrmGlavniIzbornikPomoc();
            this.Hide();
            forma.ShowDialog();
            this.Show();
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmGlavniIzbornik_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void btnUtakmice_Click(object sender, EventArgs e)
        {
            FrmUpravljanjeUtakmicama forma = new FrmUpravljanjeUtakmicama();
            forma.ShowDialog();
        }
    }
}
