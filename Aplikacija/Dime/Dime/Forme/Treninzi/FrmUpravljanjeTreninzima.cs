using System;
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

        public void DohvatiSveTreninge()
        {
            using (var db = new DimeEntities())
            {
                var listaTreninga = from t in db.Treninzi
                           select t;
                treningBindingSource.DataSource = listaTreninga.ToList();
            }
        }

        private void FrmUpravljanjeTreninzima_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_19008_DBDataSetUpdated.Korisnik' table. You can move, or remove it, as needed.
            this.korisnikTableAdapter.Fill(this._19008_DBDataSetUpdated.Korisnik);
            // TODO: This line of code loads data into the '_19008_DBDataSetUpdated.TipTreninga' table. You can move, or remove it, as needed.
            this.tipTreningaTableAdapter.Fill(this._19008_DBDataSetUpdated.TipTreninga);
            DohvatiSveTreninge();
        }

        private void btnNoviTrening_Click(object sender, EventArgs e)
        {
            FrmDodajIzmijeniTrening forma = new FrmDodajIzmijeniTrening();
            this.Hide();
            forma.ShowDialog();
            this.Show();
            DohvatiSveTreninge();
        }

        private void btnIzmijeniTrening_Click(object sender, EventArgs e)
        {
            FrmDodajIzmijeniTrening forma = new FrmDodajIzmijeniTrening(treningBindingSource.Current as Trening);
            this.Hide();
            forma.ShowDialog();
            this.Show();
            DohvatiSveTreninge();
        }

        private void ObrisiTrening()
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
                DohvatiSveTreninge();
            }
        }

        private void btnObrisiTrening_Click(object sender, EventArgs e)
        {
            ObrisiTrening();
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
            this.Hide();
            formaPomoć.ShowDialog();
            this.Show();
        }
    }
}
