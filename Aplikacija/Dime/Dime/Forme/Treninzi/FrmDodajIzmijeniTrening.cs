using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DimeDLL;

namespace Dime.Forme.Treninzi
{
    public partial class FrmDodajIzmijeniTrening : Form
    {
        ProvjeraUnosa provjeraUnosa = new ProvjeraUnosa();
        public FrmDodajIzmijeniTrening()
        {
            InitializeComponent();
        }
        private Trening odabranitrening;
        public FrmDodajIzmijeniTrening(Trening trening)
        {
            InitializeComponent();
            odabranitrening = trening;
            PopuniPodatkeOdabranimTreningom();
        }

        private void PopuniPodatkeOdabranimTreningom()
        {
            if (odabranitrening != null)
            {
                dtpDatum.Value = odabranitrening.datum;
                txtNapomena.Text = odabranitrening.napomena;
                cmbTipTreninga.Text = odabranitrening.tip_treninga.ToString();
                cmbKorisnik.Text = odabranitrening.korisnik.ToString();
            }
        }

        private void btnDodajTrening_Click(object sender, EventArgs e)
        {
            string v = $"{dtpDatum.Value.Hour}:{dtpDatum.Value.Minute}:{dtpDatum.Value.Second}";
            TimeSpan vrijeme = TimeSpan.Parse(v);
            string d = $"{dtpDatum.Value.Year}-{dtpDatum.Value.Month}-{dtpDatum.Value.Day}";
            DateTime dat = DateTime.Parse(d);
            if (provjeraUnosa.ProvjeraNapomena(txtNapomena.Text) == true)
            {
                MessageBox.Show("Polje 'Napomena' je obavezno unijeti!", "Upozorenje");
                return;
            }
            else
            {
                using (var db = new DimeEntities())
                {
                    if (odabranitrening == null)
                    {
                        Trening noviTrening = new Trening();
                        noviTrening.datum = dat;
                        noviTrening.vrijeme = vrijeme;
                        noviTrening.napomena = txtNapomena.Text;
                        noviTrening.korisnik = int.Parse(cmbKorisnik.SelectedValue.ToString());
                        noviTrening.tip_treninga = int.Parse(cmbTipTreninga.SelectedValue.ToString());

                        db.Treninzi.Add(noviTrening);
                        db.SaveChanges();
                    }
                    else
                    {
                        db.Treninzi.Attach(odabranitrening);
                        odabranitrening.datum = dat;
                        odabranitrening.vrijeme = vrijeme;
                        odabranitrening.napomena = txtNapomena.Text;
                        odabranitrening.korisnik = int.Parse(cmbKorisnik.SelectedValue.ToString());
                        odabranitrening.tip_treninga = int.Parse(cmbTipTreninga.SelectedValue.ToString());
                        db.SaveChanges();
                    }
                }
                Close();
            }
        }

        private void FrmDodajIzmijeniTrening_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_19008_DBDataSetPrimary.TipTreninga' table. You can move, or remove it, as needed.
            this.tipTreningaTableAdapter.Fill(this._19008_DBDataSetPrimary.TipTreninga);
            // TODO: This line of code loads data into the '_19008_DBDataSetPrimary.Korisnik' table. You can move, or remove it, as needed.
            this.korisnikTableAdapter.Fill(this._19008_DBDataSetPrimary.Korisnik);

        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPomoć_Click(object sender, EventArgs e)
        {
            Pomoc();
        }

        private void FrmDodajIzmijeniTrening_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void Pomoc()
        {
            FrmDodajIzmijeniTreningPomoć formaPomoc = new FrmDodajIzmijeniTreningPomoć();
            formaPomoc.ShowDialog();
        }

        private void FrmDodajIzmijeniTrening_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Pomoc();
        }
    }
}
