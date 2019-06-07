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
    public partial class FrmPopisKorisnika : Form
    {
        public FrmPopisKorisnika()
        {
            InitializeComponent();
            PrikaziKorisnike();
        }

        private void PrikaziKorisnike()
        {
            BindingList<Korisnik> listaKorisnika = null;
            using (var db = new DimeEntities())
            {
                listaKorisnika = new BindingList<Korisnik>(db.Korisnici.ToList());
            }
            korisnikBindingSource2.DataSource = listaKorisnika;
        }
        private void btnUrediKorisnika_Click(object sender, EventArgs e)
        {
            Korisnik odabraniKorisnik = dgvPopisKorisnika.CurrentRow.DataBoundItem as Korisnik;
            if (odabraniKorisnik != null)
            {
                FrmDodajKorisnika formaDodajKorisnika = new FrmDodajKorisnika(odabraniKorisnik);
                this.Hide();
                formaDodajKorisnika.ShowDialog();
                this.Show();
                PrikaziKorisnike();
            }
        }
        private void btnObrisiKorisnika_Click(object sender, EventArgs e)
        {
            Korisnik odabraniKorisnik = dgvPopisKorisnika.CurrentRow.DataBoundItem as Korisnik;
            if (odabraniKorisnik != null)
            {
                if (MessageBox.Show("Jeste li sigurni?", "Upozorenje!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    using (var db = new DimeEntities())
                    {
                        List<Trening> listaTreninga = null;
                        listaTreninga = new List<Trening>(db.Treninzi.ToList());

                        db.Korisnici.Attach(odabraniKorisnik);
                        if (odabraniKorisnik.Utakmice.Count == 0 && !(listaTreninga.Exists(k => k.korisnik == odabraniKorisnik.id_korisnik)))
                        {
                            db.Korisnici.Remove(odabraniKorisnik);
                            db.SaveChanges();
                        }
                        else
                        {
                            MessageBox.Show("Nije moguće obrisati Korisnika koji ima kreirane utakmice ili treninge!", "Nedozvoljena radnja");
                        }
                    }
                    PrikaziKorisnike();
                }
            }
        }
        private void FrmPopisKorisnika_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_19008_DBDataSet.UlogaKorisnika' table. You can move, or remove it, as needed.
            this.ulogaKorisnikaTableAdapter.Fill(this._19008_DBDataSet.UlogaKorisnika);
            // TODO: This line of code loads data into the '_19008_DBDataSet.UlogaKorisnika' table. You can move, or remove it, as needed.
            this.ulogaKorisnikaTableAdapter.Fill(this._19008_DBDataSet.UlogaKorisnika);
        }
        private void btnDodajKorisnika_Click(object sender, EventArgs e)
        {
            FrmDodajKorisnika formaDodajKorisnika = new FrmDodajKorisnika();
            this.Hide();
            formaDodajKorisnika.ShowDialog();
            this.Show();
            PrikaziKorisnike();
        }
        private void dgvPopisKorisnika_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void btnPomoc_Click(object sender, EventArgs e)
        {
            Pomoc();
        }

        private void FrmPopisKorisnika_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void FrmPopisKorisnika_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Pomoc();
        }
        private void Pomoc()
        {
            Korisnici.FrmPopisKorisnikaPomoc forma = new Korisnici.FrmPopisKorisnikaPomoc();
            this.Hide();
            forma.ShowDialog();
            this.Show();
        }

    }
}
