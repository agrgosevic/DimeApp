using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dime.Forme.Utakmice
{
    public partial class FrmDodajIzmijeniUtakmicu : Form
    {
        public FrmDodajIzmijeniUtakmicu()
        {
            InitializeComponent();
        }

        private void FrmDodajIzmijeniUtakmicu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_19008_DBDataSetPrimary.Klub' table. You can move, or remove it, as needed.
            this.klubTableAdapter.Fill(this._19008_DBDataSetPrimary.Klub);
            // TODO: This line of code loads data into the '_19008_DBDataSetPrimary.Korisnik' table. You can move, or remove it, as needed.
            this.korisnikTableAdapter.Fill(this._19008_DBDataSetPrimary.Korisnik);
            // TODO: This line of code loads data into the '_19008_DBDataSetPrimary.TipUtakmice' table. You can move, or remove it, as needed.
            this.tipUtakmiceTableAdapter.Fill(this._19008_DBDataSetPrimary.TipUtakmice);

        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            string v = $"{dtpDatumVrijeme.Value.Hour}:{dtpDatumVrijeme.Value.Minute}:{dtpDatumVrijeme.Value.Second}";
            TimeSpan vrijeme = TimeSpan.Parse(v);
            string d = $"{dtpDatumVrijeme.Value.Year}-{dtpDatumVrijeme.Value.Month}-{dtpDatumVrijeme.Value.Day}";
            DateTime datum = DateTime.Parse(d);
            using (var db = new DimeEntities())
            {
                Utakmica novaTekma = new Utakmica();
                novaTekma.datum = datum;
                novaTekma.vrijeme = vrijeme;
                novaTekma.opis = txtOpis.Text;
                novaTekma.zabijeni_poeni = int.Parse(txtZabijeniPoeni.Text);
                novaTekma.primljeni_poeni = int.Parse(txtPrimljeniPoeni.Text);
                novaTekma.tip_utakmice = int.Parse(cmbTipUtakmice.SelectedValue.ToString());
                novaTekma.protivnik = int.Parse(cmbProtivnik.SelectedValue.ToString());
                novaTekma.korisnik = int.Parse(cmbKorisnik.SelectedValue.ToString());
                db.Utakmice.Add(novaTekma);
                db.SaveChanges();
            }
        }
    }
}
