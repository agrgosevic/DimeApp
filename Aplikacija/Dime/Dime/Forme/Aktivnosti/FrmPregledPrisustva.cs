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
    public partial class FrmPregledPrisustva : Form
    {
        private Trening Trening;

        public FrmPregledPrisustva(Trening trening)
        {
            Trening = trening;
            InitializeComponent();
            PrikaziPrisustvo();
        }

        private void PrikaziPrisustvo()
        {
            BindingList<TreningPrisustvo> listaPrisustva;
            using (var db = new DimeEntities())
            {
                listaPrisustva = new BindingList<TreningPrisustvo>(db.TreningPrisustva.Where(p => p.id_treninga == Trening.id_trening).ToList());
            }
            treningPrisustvoBindingSource.DataSource = listaPrisustva;
            this.Text = $"Pregled prisustva igrača na treningu održan {Trening.datum.ToShortDateString()} u {Trening.vrijeme}";
        }

        private void FrmPregledPrisustva_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_19008_DBDataSetUpdated.Igrac' table. You can move, or remove it, as needed.
            this.igracTableAdapter.Fill(this._19008_DBDataSetUpdated.Igrac);
            // TODO: This line of code loads data into the '_19008_DBDataSetUpdated.TreningPrisustvo' table. You can move, or remove it, as needed.
            //this.treningPrisustvoTableAdapter.Fill(this._19008_DBDataSetUpdated.TreningPrisustvo);
            dgvPrisustvo.Columns[0].Visible = false;

        }

        private void dgvPrisustvo_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPrisustvo.Rows.Count > 0)
            {
                TreningPrisustvo odabraniIgrac = dgvPrisustvo.CurrentRow.DataBoundItem as TreningPrisustvo;
                if (odabraniIgrac != null)
                {
                    using (var db = new DimeEntities())
                    {
                        if (odabraniIgrac.prisustvo == "Da") rbPrisutan.Checked = true;
                        else rbOdsutan.Checked = true;
                    }
                }
            }
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            if (dgvPrisustvo.Rows.Count > 0)
            {
                TreningPrisustvo odabraniIgrac = dgvPrisustvo.CurrentRow.DataBoundItem as TreningPrisustvo;
                if (odabraniIgrac != null)
                {
                    using (var db = new DimeEntities())
                    {
                        db.TreningPrisustva.Attach(odabraniIgrac);
                        if (rbPrisutan.Checked == true) odabraniIgrac.prisustvo = "Da";
                        else odabraniIgrac.prisustvo = "Ne";
                        db.SaveChanges();
                    }
                    PrikaziPrisustvo();
                }
            }
        }

        private void btnDodajIgraca_Click(object sender, EventArgs e)
        {
            using (var db = new DimeEntities())
            {
                TreningPrisustvo noviIgrac = new TreningPrisustvo();
                noviIgrac.id_treninga = Trening.id_trening;
                noviIgrac.id_igraca = int.Parse(cmbIgraci.SelectedValue.ToString());
                noviIgrac.prisustvo = "Ne";

                db.TreningPrisustva.Add(noviIgrac);
                db.SaveChanges();
            }
            PrikaziPrisustvo();
        }

        private void btnObrisiIgraca_Click(object sender, EventArgs e)
        {
            if (dgvPrisustvo.CurrentRow != null)
            {
                TreningPrisustvo odabraniIgrac = dgvPrisustvo.CurrentRow.DataBoundItem as TreningPrisustvo;
                if (odabraniIgrac != null)
                {
                    if (MessageBox.Show("Jeste li sigurni da želite obrisati igrača iz evidencije prisustva?", "Upozorenje!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        using (var db = new DimeEntities())
                        {
                            db.TreningPrisustva.Attach(odabraniIgrac);
                            db.TreningPrisustva.Remove(odabraniIgrac);
                            db.SaveChanges();
                        }
                    }
                    PrikaziPrisustvo();
                }
            }
        }
    }
}
