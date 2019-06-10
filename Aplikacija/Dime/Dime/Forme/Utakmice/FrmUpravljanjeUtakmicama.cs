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
            forma.ShowDialog();
            PrikaziSveUtakmice();
        }

        private void FrmUpravljanjeUtakmicama_Load(object sender, EventArgs e)
        {
            PrikaziSveUtakmice();
        }

        private void btnIzmijeniUtakmicu_Click(object sender, EventArgs e)
        {
            FrmDodajIzmijeniUtakmicu forma = new FrmDodajIzmijeniUtakmicu(utakmicaBindingSource.Current as Utakmica);
            forma.ShowDialog();
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
            formaPomoc.ShowDialog();
        }

        private void FrmUpravljanjeUtakmicama_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Pomoc();
        }
    }
}
