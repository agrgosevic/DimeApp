using Dime.Forme.Statistika;
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
            PrikaziUtakmice();
        }

        private void PrikaziUtakmice()
        {
            BindingList<Utakmica> listaUtakmica;
            using (var db = new DimeEntities())
            {
                listaUtakmica = new BindingList<Utakmica>(db.Utakmice.ToList());
            }
            utakmicaBindingSource1.DataSource = listaUtakmica;
        }

        private void FrmStatistikeUtakmica_Load(object sender, EventArgs e)
        {
            // Punjenje stupca Tip Utakmice s podacima.
            this.tipUtakmiceTableAdapter.Fill(this._19008_DBDataSetPrimary.TipUtakmice);
            // Punjenje stupca Protivnik s podacima
            this.klubTableAdapter.Fill(this._19008_DBDataSetPrimary.Klub);
            // Punjenje ostalih stupaca iz tablice Utakmica u dgv
            //this.utakmicaTableAdapter.Fill(this._19008_DBDataSetPrimary.Utakmica);
        }

        private void btnOdaberi_Click(object sender, EventArgs e)
        {
            Utakmica odabranaUtakmica = dgvOdigraneUtakmice.CurrentRow.DataBoundItem as Utakmica;
            if(odabranaUtakmica != null)
            {
                FrmStatistikaOdabraneUtakmice formaStatistika = new FrmStatistikaOdabraneUtakmice(odabranaUtakmica);
                formaStatistika.ShowDialog();
                PrikaziUtakmice();
            }
            
        }
    }
}
