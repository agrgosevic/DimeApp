using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dime.Forme
{
    public partial class FrmDodajKorisnika : Form
    {
        private Korisnik korisnikZaIzmjenu;
        public FrmDodajKorisnika()
        {
            InitializeComponent();
        }
        public FrmDodajKorisnika(Korisnik korisnik)
        {
            korisnikZaIzmjenu = korisnik;
            InitializeComponent();
        }

        private void FrmDodajKorisnika_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_19008_DBDataSet.UlogaKorisnika' table. You can move, or remove it, as needed.
            this.ulogaKorisnikaTableAdapter.Fill(this._19008_DBDataSet.UlogaKorisnika);
            txtIme.Focus();
            if (korisnikZaIzmjenu != null)
            {
                txtIme.Text = korisnikZaIzmjenu.ime.ToString();
                txtPrezime.Text = korisnikZaIzmjenu.prezime.ToString();
                txtEmail.Text = korisnikZaIzmjenu.email.ToString();
                txtKorisnickoIme.Text = korisnikZaIzmjenu.korisnicko_ime.ToString();
                txtLozinka.Text = korisnikZaIzmjenu.lozinka.ToString();
                cmbUloga.SelectedValue = korisnikZaIzmjenu.uloga.ToString();
            }
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            using (var db = new DimeEntities())
            {
                if (korisnikZaIzmjenu == null)
                {
                    Korisnik korisnik = new Korisnik();
                    korisnik.ime = txtIme.Text;
                    korisnik.prezime = txtPrezime.Text;
                    korisnik.email = txtEmail.Text;
                    korisnik.korisnicko_ime = txtKorisnickoIme.Text;
                    korisnik.lozinka = txtLozinka.Text;
                    korisnik.uloga = int.Parse(cmbUloga.SelectedValue.ToString());
                    db.Korisnici.Add(korisnik);
                    db.SaveChanges();
                }
                else
                {
                    db.Korisnici.Attach(korisnikZaIzmjenu);
                    korisnikZaIzmjenu.ime = txtIme.Text;
                    korisnikZaIzmjenu.prezime = txtPrezime.Text;
                    korisnikZaIzmjenu.email = txtEmail.Text;
                    korisnikZaIzmjenu.korisnicko_ime = txtKorisnickoIme.Text;
                    korisnikZaIzmjenu.lozinka = txtLozinka.Text;
                    korisnikZaIzmjenu.uloga = int.Parse(cmbUloga.SelectedValue.ToString());
                    db.SaveChanges();
                }
            }
            Close();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void Pomoc()
        {
            Korisnici.FrmDodajKorisnikaPomoc forma = new Korisnici.FrmDodajKorisnikaPomoc();
            this.Hide();
            forma.ShowDialog();
            this.Show();
        }
        private void btnPomoc_Click(object sender, EventArgs e)
        {
            Pomoc();
        }
        private void FrmDodajKorisnika_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
        private void FrmDodajKorisnika_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Pomoc();
        }
    }
}
