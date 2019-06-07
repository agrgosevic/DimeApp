using System;
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
    public partial class FrmDodajIgraca : Form
    {
        private Igrac igracZaIzmjenu;
        public FrmDodajIgraca()
        {
            InitializeComponent();
        }
        public FrmDodajIgraca(Igrac igrac)
        {
            InitializeComponent();
            igracZaIzmjenu = igrac;
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            using (var db = new DimeEntities())
            {
                if (igracZaIzmjenu == null)
                {
                    Igrac igrac = new Igrac();
                    igrac.ime = txtIme.Text;
                    igrac.prezime = txtPrezime.Text;
                    igrac.datum_rodenja = dtpDatumRodenja.Value;
                    igrac.visina = int.Parse(txtVisina.Text);
                    igrac.tezina = int.Parse(txtTezina.Text);
                    igrac.broj = int.Parse(txtBroj.Text);
                    db.Igraci.Add(igrac);
                    db.SaveChanges();
                }
                else
                {
                    db.Igraci.Attach(igracZaIzmjenu);
                    igracZaIzmjenu.ime = txtIme.Text;
                    igracZaIzmjenu.prezime = txtPrezime.Text;
                    igracZaIzmjenu.datum_rodenja = dtpDatumRodenja.Value;
                    igracZaIzmjenu.visina = int.Parse(txtVisina.Text);
                    igracZaIzmjenu.tezina = int.Parse(txtTezina.Text);
                    igracZaIzmjenu.broj = int.Parse(txtBroj.Text);
                    db.SaveChanges();
                }
            }
            Close();
        }

        private void FrmDodajIgraca_Load(object sender, EventArgs e)
        {
            txtIme.Focus();
            if (igracZaIzmjenu != null)
            {
                txtIme.Text = igracZaIzmjenu.ime;
                txtPrezime.Text = igracZaIzmjenu.prezime;
                dtpDatumRodenja.Value = igracZaIzmjenu.datum_rodenja;
                txtVisina.Text = igracZaIzmjenu.visina.ToString();
                txtTezina.Text = igracZaIzmjenu.tezina.ToString();
                txtBroj.Text = igracZaIzmjenu.broj.ToString();
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmDodajIgraca_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void btnPomoc_Click(object sender, EventArgs e)
        {
            Pomoc();
        }

        private void btnPomoc_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Pomoc();
        }

        private void Pomoc()
        {
            FrmDodajIgracaPomoc forma = new FrmDodajIgracaPomoc();
            this.Hide();
            forma.ShowDialog();
            this.Show();
        }

    }
}
