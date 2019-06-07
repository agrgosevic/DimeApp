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
    public partial class FrmPopisIgraca : Form
    {
        public FrmPopisIgraca()
        {
            InitializeComponent();
            PrikaziIgrace();
        }

        private void FrmPopisIgraca_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_19008_DBDataSetPrimary.Igrac' table. You can move, or remove it, as needed.
            this.igracTableAdapter.Fill(this._19008_DBDataSetPrimary.Igrac);

        }

        private void btnDodajIgraca_Click(object sender, EventArgs e)
        {
            Igraci.FrmDodajIgraca fromaDodajIgraca = new Igraci.FrmDodajIgraca();
            this.Hide();
            fromaDodajIgraca.ShowDialog();
            this.Show();
            PrikaziIgrace();
        }

        public void PrikaziIgrace()
        {
            BindingList<Igrac> listaIgraca = null;
            using (var db = new DimeEntities())
            {
                listaIgraca = new BindingList<Igrac>(db.Igraci.ToList());
            }
            igracBindingSource.DataSource = listaIgraca;
        }

        private void btnUrediIgraca_Click(object sender, EventArgs e)
        {
            Igrac odabraniIgrac = dgvPopisIgraca.CurrentRow.DataBoundItem as Igrac;
            if (odabraniIgrac != null)
            {
                Igraci.FrmDodajIgraca formaDodajIgraca = new Igraci.FrmDodajIgraca(odabraniIgrac);
                this.Hide();
                formaDodajIgraca.ShowDialog();
                this.Show();
                PrikaziIgrace();
            }
        }

        private void btnObrisiIgraca_Click(object sender, EventArgs e)
        {
            Igrac odabraniIgrac = dgvPopisIgraca.CurrentRow.DataBoundItem as Igrac;
            if (odabraniIgrac != null)
            {
                if (MessageBox.Show("Jeste li sigurni?", "Upozorenje!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    using (var db = new DimeEntities())
                    {
                        db.Igraci.Attach(odabraniIgrac);

                        db.Igraci.Remove(odabraniIgrac);
                        db.SaveChanges();

                    }
                    PrikaziIgrace();
                }
            }
        }

        private void btnPomoc_Click(object sender, EventArgs e)
        {
            Pomoc();
        }

        private void FrmPopisIgraca_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void FrmPopisIgraca_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Pomoc();
        }
        private void Pomoc()
        {
            Igraci.FrmPopisIgracaPomoc forma = new Igraci.FrmPopisIgracaPomoc();
            this.Hide();
            forma.ShowDialog();
            this.Show();
        }
    }
}
