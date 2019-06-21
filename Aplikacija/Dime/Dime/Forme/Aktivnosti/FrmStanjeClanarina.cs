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

        }
    }
}
