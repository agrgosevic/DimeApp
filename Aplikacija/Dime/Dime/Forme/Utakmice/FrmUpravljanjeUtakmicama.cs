using System;
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
            this.Hide();
            forma.ShowDialog();
            this.Show();
            PrikaziSveUtakmice();
        }

        private void FrmUpravljanjeUtakmicama_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_19008_DBDataSetUpdated.Korisnik' table. You can move, or remove it, as needed.
            this.korisnikTableAdapter.Fill(this._19008_DBDataSetUpdated.Korisnik);
            // TODO: This line of code loads data into the '_19008_DBDataSetUpdated.Klub' table. You can move, or remove it, as needed.
            this.klubTableAdapter.Fill(this._19008_DBDataSetUpdated.Klub);
            // TODO: This line of code loads data into the '_19008_DBDataSetUpdated.TipUtakmice' table. You can move, or remove it, as needed.
            this.tipUtakmiceTableAdapter.Fill(this._19008_DBDataSetUpdated.TipUtakmice);
            PrikaziSveUtakmice();
        }

        private void btnIzmijeniUtakmicu_Click(object sender, EventArgs e)
        {
            FrmDodajIzmijeniUtakmicu forma = new FrmDodajIzmijeniUtakmicu(utakmicaBindingSource.Current as Utakmica);
            this.Hide();
            forma.ShowDialog();
            this.Show();
            PrikaziSveUtakmice();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            Utakmica selektiranaUtakmica = utakmicaBindingSource.Current as Utakmica;
            if (selektiranaUtakmica != null)
            {
                using (var db = new DimeEntities())
                {
                    db.Utakmice.Attach(selektiranaUtakmica);
                    db.Utakmice.Remove(selektiranaUtakmica);
                    db.SaveChanges();
                }
                PrikaziSveUtakmice();
            }
        }

        private void btnPomoć_Click(object sender, EventArgs e)
        {
            Pomoc();
        }

        private void FrmUpravljanjeUtakmicama_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void Pomoc()
        {
            FrmUpravljanjeUtakmicamaPomoc formaPomoc = new FrmUpravljanjeUtakmicamaPomoc();
            this.Hide();
            formaPomoc.ShowDialog();
            this.Show();
        }

        private void FrmUpravljanjeUtakmicama_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Pomoc();
        }
    }
}
