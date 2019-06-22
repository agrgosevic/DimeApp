using Dime.Forme.Aktivnosti;
using Dime.Forme.Aktivnosti.HelpForme;
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
    public partial class FrmPopisAktivnosti : Form
    {
        public FrmPopisAktivnosti()
        {
            InitializeComponent();
            PrikaziTreninge();
            PrikaziClanarine();
        }

        private void PrikaziTreninge()
        {
            BindingList<Trening> listaTreninga;
            using (var db = new DimeEntities())
            {
                listaTreninga = new BindingList<Trening>(db.Treninzi.ToList());
            }
            treningBindingSource.DataSource = listaTreninga;
        }

        private void PrikaziClanarine()
        {
            BindingList<Clanarina> listaClanarina;
            using (var db = new DimeEntities())
            {
                listaClanarina = new BindingList<Clanarina>(db.Clanarine.ToList());
            }
            clanarinaBindingSource.DataSource = listaClanarina;
        }

        private void ObojiClanarine()
        {
            foreach (DataGridViewRow row in dgvPopisClanarina.Rows)
            {
                if (row != null)
                {
                    using (var db = new DimeEntities())
                    {
                        Clanarina clanarina = row.DataBoundItem as Clanarina;
                        var listaClanarinaIgraca = db.ClanarineIgraca.Where(c => c.id_clanarine == clanarina.id_clanarina);
                        if (listaClanarinaIgraca.Count() > 0)
                        {
                            int brojNeplacenih = listaClanarinaIgraca.Where(c => c.uplaceno == "Ne").Count();
                            if (brojNeplacenih == 0) row.DefaultCellStyle.BackColor = Color.LightGreen;
                            else if (brojNeplacenih > 0) row.DefaultCellStyle.BackColor = Color.OrangeRed;
                        }
                    }

                }
            }
        }

        private void FrmPopisAktivnosti_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_19008_DBDataSetUpdated.Clanarina' table. You can move, or remove it, as needed.
            this.clanarinaTableAdapter1.Fill(this._19008_DBDataSetUpdated.Clanarina);
            // TODO: This line of code loads data into the '_19008_DBDataSetPrimary.TipTreninga' table. You can move, or remove it, as needed.
            this.tipTreningaTableAdapter.Fill(this._19008_DBDataSetPrimary.TipTreninga);
            // TODO: This line of code loads data into the '_19008_DBDataSetPrimary.Trening' table. You can move, or remove it, as needed.
            //this.treningTableAdapter.Fill(this._19008_DBDataSetPrimary.Trening);
            ObojiClanarine();
        }

        private void btnOdaberiClanarinu_Click(object sender, EventArgs e)
        {
            Clanarina odabranaClanarina = dgvPopisClanarina.CurrentRow.DataBoundItem as Clanarina;
            if (odabranaClanarina != null)
            {
                FrmStanjeClanarina forma = new FrmStanjeClanarina(odabranaClanarina);
                forma.ShowDialog();
                PrikaziTreninge();
                PrikaziClanarine();
                ObojiClanarine();
            }
        }

        private void btnKreiraj_Click(object sender, EventArgs e)
        {
            FrmDodajClanarinu formaDodaj = new FrmDodajClanarinu();
            formaDodaj.ShowDialog();
            PrikaziTreninge();
            PrikaziClanarine();
            ObojiClanarine();
        }

        private void btnIzmjeni_Click(object sender, EventArgs e)
        {
            Clanarina odabranaClanarina = dgvPopisClanarina.CurrentRow.DataBoundItem as Clanarina;
            if (odabranaClanarina != null)
            {
                FrmDodajClanarinu formaIzmjeni = new FrmDodajClanarinu(odabranaClanarina);
                formaIzmjeni.ShowDialog();
                PrikaziTreninge();
                PrikaziClanarine();
                ObojiClanarine();
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (dgvPopisClanarina.CurrentRow != null)
            {
                Clanarina odabranaClanarina = dgvPopisClanarina.CurrentRow.DataBoundItem as Clanarina;
                if (odabranaClanarina != null)
                {
                    using (var db = new DimeEntities())
                    {
                        if (db.ClanarineIgraca.Where(c => c.id_clanarine == odabranaClanarina.id_clanarina).Count() == 0)
                        {
                            if (MessageBox.Show("Jeste li sigurni da želite obrisati članarinu s popisa članarina?", "Upozorenje!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                    db.Clanarine.Attach(odabranaClanarina);
                                    db.Clanarine.Remove(odabranaClanarina);
                                    db.SaveChanges();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Nije moguće obrisati članarinu dok nije obrisana evidencija članarina pojedinih igrača!", "Upozorenje!");
                        }
                    }
                    PrikaziTreninge();
                    PrikaziClanarine();
                    ObojiClanarine();
                }
            }
        }

        private void btnOdaberiTrening_Click(object sender, EventArgs e)
        {
            Trening odabraniTrening = dgvOdrzaniTreninzi.CurrentRow.DataBoundItem as Trening;
            if (odabraniTrening != null)
            {
                FrmPregledPrisustva forma = new FrmPregledPrisustva(odabraniTrening);
                forma.ShowDialog();
                PrikaziTreninge();
                PrikaziClanarine();
                ObojiClanarine();
            }
        }

        private void Pomoc()
        {
            if (this.ContainsFocus == true)
            {
                HelpFrmPopisAktivnosti helpForma = new HelpFrmPopisAktivnosti();
                helpForma.ShowDialog();
            }
        }

        private void btnPomoc_Click(object sender, EventArgs e)
        {
            Pomoc();
        }

        private void FrmPopisAktivnosti_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Pomoc();
        }
    }
}
