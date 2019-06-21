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

        private void FrmPopisAktivnosti_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_19008_DBDataSetUpdated.Clanarina' table. You can move, or remove it, as needed.
            this.clanarinaTableAdapter1.Fill(this._19008_DBDataSetUpdated.Clanarina);
            // TODO: This line of code loads data into the '_19008_DBDataSetPrimary.TipTreninga' table. You can move, or remove it, as needed.
            this.tipTreningaTableAdapter.Fill(this._19008_DBDataSetPrimary.TipTreninga);
            // TODO: This line of code loads data into the '_19008_DBDataSetPrimary.Trening' table. You can move, or remove it, as needed.
            //this.treningTableAdapter.Fill(this._19008_DBDataSetPrimary.Trening);

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
    }
}
