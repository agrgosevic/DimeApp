using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dime.Forme.Statistika
{
    public partial class FrmStatistikaOdabraneUtakmice : Form
    {
        private Utakmica utakmica;
        public FrmStatistikaOdabraneUtakmice(Utakmica odabranaUtkamica)
        {
            utakmica = odabranaUtkamica;
            InitializeComponent();
        }

        private void FrmStatistikaOdabraneUtakmice_Load(object sender, EventArgs e)
        {
            using (var db = new DimeEntities())
            {
                lblProtivnik.Text = db.Klubovi.FirstOrDefault(p => p.id_klub == utakmica.protivnik).naziv;
                lblDatum.Text = utakmica.datum.ToShortDateString();
                lblVrijeme.Text = utakmica.vrijeme.ToString();
                lblTipUtakmice.Text = db.TipoviUtakmica.FirstOrDefault(t => t.id_tipa_utakmice == utakmica.tip_utakmice).naziv_tipa;
                lblPrimljeniPoeni.Text = utakmica.primljeni_poeni.ToString();
                lblZabijeniPoeni.Text = utakmica.zabijeni_poeni.ToString();
            }
        }
    }
}
