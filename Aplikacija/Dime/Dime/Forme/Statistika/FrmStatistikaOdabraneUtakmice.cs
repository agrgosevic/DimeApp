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
        private string Protivnik;

        public FrmStatistikaOdabraneUtakmice()
        {
            InitializeComponent();
        }

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
                Protivnik = db.Klubovi.FirstOrDefault(p => p.id_klub == utakmica.protivnik).naziv;
                lblProtivnik.Text = Protivnik;
                lblDatum.Text = utakmica.datum.ToShortDateString();
                lblVrijeme.Text = utakmica.vrijeme.ToString();
                lblTipUtakmice.Text = db.TipoviUtakmica.FirstOrDefault(t => t.id_tipa_utakmice == utakmica.tip_utakmice).naziv_tipa;
                lblRezultat.Text = $"{utakmica.zabijeni_poeni.ToString()} : {utakmica.primljeni_poeni.ToString()}";
                popisIgraca = new BindingList<StatistikaIgraca>(db.StatistikeIgraca.Where(i => i.id_utakmice == utakmica.id_utakmica).ToList());
            }
            statistikaIgracaBindingSource.DataSource = popisIgraca;
            this.Text = $"Utakmica protiv {Protivnik} {utakmica.datum.ToShortDateString()} u {utakmica.vrijeme.ToString()}";
        }

        private void dgvIgraciNaUtakmici_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvIgraciNaUtakmici.Rows.Count > 0)
            {
                StatistikaIgraca odabranaStatistikaIgraca = dgvIgraciNaUtakmici.CurrentRow.DataBoundItem as StatistikaIgraca;
                if (odabranaStatistikaIgraca != null)
                {
                    using (var db = new DimeEntities())
                    {
                        string ime = db.Igraci.FirstOrDefault(i => i.id_igrac == odabranaStatistikaIgraca.id_igraca).ime;
                        string prezime = db.Igraci.FirstOrDefault(i => i.id_igrac == odabranaStatistikaIgraca.id_igraca).prezime;
                        string poeni = (odabranaStatistikaIgraca.sb_zabijeni + (odabranaStatistikaIgraca.p2_zabijeni * 2) + (odabranaStatistikaIgraca.p3_zabijeni * 3)).ToString();
                        decimal postotak_sb;
                        decimal postotak_2p;
                        decimal postotak_3p;

                        try
                        {
                            postotak_sb = 100M * odabranaStatistikaIgraca.sb_zabijeni / odabranaStatistikaIgraca.sb_pokusaji;
                        }
                        catch (DivideByZeroException)
                        {
                            postotak_sb = 0;
                        }

                        try
                        {
                            postotak_2p = 100M * odabranaStatistikaIgraca.p2_zabijeni / odabranaStatistikaIgraca.p2_pokusaji;
                        }
                        catch (DivideByZeroException)
                        {
                            postotak_2p = 0;
                        }

                        try
                        {
                            postotak_3p = 100M * odabranaStatistikaIgraca.p3_zabijeni / odabranaStatistikaIgraca.p3_pokusaji;
                        }
                        catch (DivideByZeroException)
                        {
                            postotak_3p = 0;
                        }

                        lblImePrezime.Text = $"{ime} {prezime}";
                        txtMinute.Text = odabranaStatistikaIgraca.minutaza.ToString();
                        txtPoeni.Text = poeni;
                        txtAsistencije.Text = odabranaStatistikaIgraca.asistencije.ToString();
                        txtSkokovi.Text = odabranaStatistikaIgraca.skokovi.ToString();
                        txtSBPostotak.Text = Math.Round(postotak_sb, 1).ToString();
                        txt2pPostotak.Text = Math.Round(postotak_2p, 1).ToString();
                        txt3pPostotak.Text = Math.Round(postotak_3p, 1).ToString();
                    }
                }
            }
        }
    }
}
