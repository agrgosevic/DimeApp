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

        private void FrmPopisAktivnosti_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_19008_DBDataSetUpdated.Clanarina' table. You can move, or remove it, as needed.
            this.clanarinaTableAdapter1.Fill(this._19008_DBDataSetUpdated.Clanarina);
            // TODO: This line of code loads data into the '_19008_DBDataSetPrimary.TipTreninga' table. You can move, or remove it, as needed.
            this.tipTreningaTableAdapter.Fill(this._19008_DBDataSetPrimary.TipTreninga);
            // TODO: This line of code loads data into the '_19008_DBDataSetPrimary.Trening' table. You can move, or remove it, as needed.
            //this.treningTableAdapter.Fill(this._19008_DBDataSetPrimary.Trening);
        }
    }
}
