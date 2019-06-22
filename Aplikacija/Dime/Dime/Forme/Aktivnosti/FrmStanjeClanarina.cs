using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dime.Forme.Aktivnosti
{
    public partial class FrmStanjeClanarina : Form
    {
        private Clanarina Clanarina;

        public FrmStanjeClanarina(Clanarina clanarina)
        {
            Clanarina = clanarina;
            InitializeComponent();
            PrikaziStanja();
        }

        private void PrikaziStanja()
        {
            BindingList<ClanarinaIgraca> listaStanja;
            using (var db = new DimeEntities())
            {
                listaStanja = new BindingList<ClanarinaIgraca>(db.ClanarineIgraca.Where(c => c.id_clanarine == Clanarina.id_clanarina).ToList());
            }
            clanarinaIgracaBindingSource.DataSource = listaStanja;
            this.Text = $"Stanje članarina za {Clanarina.mjesec} {Clanarina.godina}.";
            
        }

        private void FrmStanjeClanarina_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_19008_DBDataSetUpdated.Igrac' table. You can move, or remove it, as needed.
            this.igracTableAdapter.Fill(this._19008_DBDataSetUpdated.Igrac);
            // TODO: This line of code loads data into the '_19008_DBDataSetUpdated.ClanarinaIgraca' table. You can move, or remove it, as needed.
            //this.clanarinaIgracaTableAdapter.Fill(this._19008_DBDataSetUpdated.ClanarinaIgraca);
            dgvStanjeClanarina.Columns[0].Visible = false;
        }

        private void dgvStanjeClanarina_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvStanjeClanarina.Rows.Count > 0)
            {
                ClanarinaIgraca odabranaClanarinaIgraca = dgvStanjeClanarina.CurrentRow.DataBoundItem as ClanarinaIgraca;
                if (odabranaClanarinaIgraca != null)
                {
                    using (var db = new DimeEntities())
                    {
                        if (odabranaClanarinaIgraca.uplaceno == "Da") rbPlaceno.Checked = true;
                        else rbNijePlaceno.Checked = true;
                    }
                }
            }
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            if (dgvStanjeClanarina.Rows.Count > 0)
            {
                ClanarinaIgraca odabranaClanarinaIgraca = dgvStanjeClanarina.CurrentRow.DataBoundItem as ClanarinaIgraca;
                if (odabranaClanarinaIgraca != null)
                {
                    using (var db = new DimeEntities())
                    {
                        db.ClanarineIgraca.Attach(odabranaClanarinaIgraca);
                        if (rbPlaceno.Checked == true) odabranaClanarinaIgraca.uplaceno = "Da";
                        else odabranaClanarinaIgraca.uplaceno = "Ne";
                        db.SaveChanges();
                    }
                    PrikaziStanja();
                }
            }
        }

        private void btnDodajIgraca_Click(object sender, EventArgs e)
        {
            using (var db = new DimeEntities())
            {
                ClanarinaIgraca novaClanarinaIgraca = new ClanarinaIgraca();
                novaClanarinaIgraca.id_clanarine = Clanarina.id_clanarina;
                novaClanarinaIgraca.id_igraca = int.Parse(cmbIgraci.SelectedValue.ToString());
                novaClanarinaIgraca.uplaceno = "Ne";

                db.ClanarineIgraca.Add(novaClanarinaIgraca);
                db.SaveChanges();
            }
            PrikaziStanja();
        }

        private void btnObrisiIgraca_Click(object sender, EventArgs e)
        {
            if (dgvStanjeClanarina.CurrentRow != null)
            {
                ClanarinaIgraca odabranaClanarinaIgraca = dgvStanjeClanarina.CurrentRow.DataBoundItem as ClanarinaIgraca;
                if (odabranaClanarinaIgraca != null)
                {
                    if (MessageBox.Show("Jeste li sigurni da želite obrisati igrača iz evidencije članarina?", "Upozorenje!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        using (var db = new DimeEntities())
                        {
                            db.ClanarineIgraca.Attach(odabranaClanarinaIgraca);
                            db.ClanarineIgraca.Remove(odabranaClanarinaIgraca);
                            db.SaveChanges();
                        }
                    }
                    PrikaziStanja();
                }
            }
        }
    }
}
