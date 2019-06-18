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
            // TODO: This line of code loads data into the '_19008_DBDataSetPrimary.Igrac' table. You can move, or remove it, as needed.
            this.igracTableAdapter.Fill(this._19008_DBDataSetPrimary.Igrac);
            // TODO: This line of code loads data into the '_19008_DBDataSetPrimary.StatistikaIgraca' table. You can move, or remove it, as needed.
            this.statistikaIgracaTableAdapter.Fill(this._19008_DBDataSetPrimary.StatistikaIgraca);
            BindingList<StatistikaIgraca> popisIgraca;
            using (var db = new DimeEntities())
            {
                lblProtivnik.Text = db.Klubovi.FirstOrDefault(p => p.id_klub == utakmica.protivnik).naziv;
                lblDatum.Text = utakmica.datum.ToShortDateString();
                lblVrijeme.Text = utakmica.vrijeme.ToString();
                lblTipUtakmice.Text = db.TipoviUtakmica.FirstOrDefault(t => t.id_tipa_utakmice == utakmica.tip_utakmice).naziv_tipa;
                lblPrimljeniPoeni.Text = utakmica.primljeni_poeni.ToString();
                lblZabijeniPoeni.Text = utakmica.zabijeni_poeni.ToString();

                popisIgraca = new BindingList<StatistikaIgraca>(db.StatistikeIgraca.Where(i => i.id_utakmice == utakmica.id_utakmica).ToList());
            }
            statistikaIgracaBindingSource.DataSource = popisIgraca;
        }

        private void dgvIgraciNaUtakmici_SelectionChanged(object sender, EventArgs e)
        {
            StatistikaIgraca odabranaStatistikaIgraca = dgvIgraciNaUtakmici.CurrentRow.DataBoundItem as StatistikaIgraca;
            if(odabranaStatistikaIgraca != null)
            {
                using (var db = new DimeEntities())
                {
                    string ime = db.Igraci.FirstOrDefault(i => i.id_igrac == odabranaStatistikaIgraca.id_igraca).ime;
                    string prezime = db.Igraci.FirstOrDefault(i => i.id_igrac == odabranaStatistikaIgraca.id_igraca).prezime;
                    string poeni = (odabranaStatistikaIgraca.sb_zabijeni + (odabranaStatistikaIgraca.p2_zabijeni * 2) + (odabranaStatistikaIgraca.p3_zabijeni * 3)).ToString();
                    lblImePrezime.Text = $"{ime} {prezime}";
                    txtMinute.Text = odabranaStatistikaIgraca.minutaza.ToString();
                    txtPoeni.Text = poeni;
                    txtAsistencije.Text = odabranaStatistikaIgraca.asistencije.ToString();
                    txtSkokovi.Text = odabranaStatistikaIgraca.skokovi.ToString();
                }
            }
        }
    }
}
