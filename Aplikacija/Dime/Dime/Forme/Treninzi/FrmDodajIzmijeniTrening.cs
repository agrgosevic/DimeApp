using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dime.Forme.Treninzi
{
    public partial class FrmDodajIzmijeniTrening : Form
    {
        public FrmDodajIzmijeniTrening()
        {
            InitializeComponent();
            
        }
        
        private void btnDodajTrening_Click(object sender, EventArgs e)
        {
            
            string v = $"{dtpDatum.Value.Hour}:{dtpDatum.Value.Minute}:{dtpDatum.Value.Second}";
            TimeSpan vrijeme = TimeSpan.Parse(v);
            string d = $"{dtpDatum.Value.Year}-{dtpDatum.Value.Month}-{dtpDatum.Value.Day}";
            DateTime dat = DateTime.Parse(d);
            using (var db = new DimeEntities())
            {
                Trening noviTrening = new Trening();
                noviTrening.datum = dat;
                noviTrening.vrijeme = vrijeme;
                noviTrening.napomena = txtNapomena.Text;
                noviTrening.korisnik = int.Parse(cmbKorisnik.SelectedValue.ToString());
                noviTrening.tip_treninga = int.Parse(cmbTipTreninga.SelectedValue.ToString());


                db.Treninzi.Add(noviTrening);
                db.SaveChanges();
            }
            Close();

        }

        private void FrmDodajIzmijeniTrening_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_19008_DBDataSetPrimary.TipTreninga' table. You can move, or remove it, as needed.
            this.tipTreningaTableAdapter.Fill(this._19008_DBDataSetPrimary.TipTreninga);
            // TODO: This line of code loads data into the '_19008_DBDataSetPrimary.Korisnik' table. You can move, or remove it, as needed.
            this.korisnikTableAdapter.Fill(this._19008_DBDataSetPrimary.Korisnik);

        }
    }
}
