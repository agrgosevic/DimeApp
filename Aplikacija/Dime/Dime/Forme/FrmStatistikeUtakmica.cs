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
    public partial class FrmStatistikeUtakmica : Form
    {
        public FrmStatistikeUtakmica()
        {
            InitializeComponent();
        }

        private void PrikaziOdigraneUtakmice()
        {
            using (var db = new DimeEntities())
            {
                var sqlUpit = from u in db.Utakmice
                              select new
                              {
                                  Datum = u.datum,
                                  Vrijeme = u.vrijeme,
                                  Zabijeni_poeni = u.zabijeni_poeni,
                                  Primljeni_poeni = u.primljeni_poeni,
                                  Tip_utakmice = u.TipUtakmice.naziv_tipa,
                                  Protivnik = u.Protivnik.naziv
                              };

                dgvOdigraneUtakmice.DataSource = sqlUpit.ToList();
            }

            // Preimenovanje stupaca dgv-a
            dgvOdigraneUtakmice.Columns[2].HeaderText = "Zabijeni poeni";
            dgvOdigraneUtakmice.Columns[3].HeaderText = "Primljeni poeni";
            dgvOdigraneUtakmice.Columns[4].HeaderText = "Tip utakmice";

        }

        private void FrmStatistikeUtakmica_Load(object sender, EventArgs e)
        {
            PrikaziOdigraneUtakmice();
        }
    }
}
