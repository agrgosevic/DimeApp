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
            List<Korisnik> korisnici;
            using (var db = new DimeEntities())
            {
                korisnici = db.Korisnici.ToList();
            }
            dgvPopisKorisnika.DataSource = korisnici;
        }

        private void frmDodajZaposlenika_Click(object sender, EventArgs e)
        {
            FrmDodajKorisnika formaDodajKorisnika = new FrmDodajKorisnika();
            this.Hide();
            formaDodajKorisnika.ShowDialog();
            this.Show();
            PrikaziKorisnike();
        }

        private void btnUrediKorisnika_Click(object sender, EventArgs e)
        {
            Korisnik odabraniKorisnik = dgvPopisKorisnika.CurrentRow.DataBoundItem as Korisnik;
            if (odabraniKorisnik != null)
            {
                FrmDodajKorisnika formaDodajKorisnika = new FrmDodajKorisnika();
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
                        db.Korisnici.Attach(odabraniKorisnik);
                        db.Korisnici.Remove(odabraniKorisnik);
                        db.SaveChanges();
                    }
                    PrikaziKorisnike();
                }
            }

        }
    }
}
