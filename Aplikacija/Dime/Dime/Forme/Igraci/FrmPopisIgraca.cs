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

        }

        public void PrikaziIgrace()
        {
            this.igracTableAdapter.Fill(this._19008_DBDataSetPrimary.Igrac);
        }
    }
}
