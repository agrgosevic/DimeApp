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
        private Utakmica Utakmica;
        private string Protivnik;

        public FrmStatistikaOdabraneUtakmice()
        {
            InitializeComponent();
        }

        public FrmStatistikaOdabraneUtakmice(Utakmica utakmica)
        {
            Utakmica = utakmica;
            InitializeComponent();
        }

        private void PrikaziPodatke()
        {
            BindingList<StatistikaIgraca> popisIgraca;
            using (var db = new DimeEntities())
            {
                Protivnik = db.Klubovi.FirstOrDefault(p => p.id_klub == Utakmica.protivnik).naziv;
                lblProtivnik.Text = $"Protivnik: {Protivnik}";
                lblDatum.Text = Utakmica.datum.ToShortDateString();
                lblVrijeme.Text = Utakmica.vrijeme.ToString();
                lblTipUtakmice.Text = db.TipoviUtakmica.FirstOrDefault(t => t.id_tipa_utakmice == Utakmica.tip_utakmice).naziv_tipa;
                lblRezultat.Text = $"{Utakmica.zabijeni_poeni.ToString()} : {Utakmica.primljeni_poeni.ToString()}";
                popisIgraca = new BindingList<StatistikaIgraca>(db.StatistikeIgraca.Where(i => i.id_utakmice == Utakmica.id_utakmica).ToList());

                if (Utakmica.zabijeni_poeni > Utakmica.primljeni_poeni)
                {
                    lblIshod.Text = "Pobjeda";
                    lblIshod.ForeColor = Color.Green;
                }
                else
                {
                    lblIshod.Text = "Poraz";
                    lblIshod.ForeColor = Color.Red;
                }
            }
            statistikaIgracaBindingSource.DataSource = popisIgraca;
            this.Text = $"Utakmica protiv {Protivnik} {Utakmica.datum.ToShortDateString()} u {Utakmica.vrijeme.ToString()}";
        }

        private void FrmStatistikaOdabraneUtakmice_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_19008_DBDataSetPrimary.Igrac' table. You can move, or remove it, as needed.
            this.igracTableAdapter.Fill(this._19008_DBDataSetPrimary.Igrac);
            // TODO: This line of code loads data into the '_19008_DBDataSetPrimary.StatistikaIgraca' table. You can move, or remove it, as needed.
            this.statistikaIgracaTableAdapter.Fill(this._19008_DBDataSetPrimary.StatistikaIgraca);
            PrikaziPodatke();
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

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            FrmDodajStatistikuIgraca formaDodaj = new FrmDodajStatistikuIgraca(Utakmica);
            formaDodaj.ShowDialog();
            PrikaziPodatke();
        }

        private void btnIzmjeni_Click(object sender, EventArgs e)
        {
            StatistikaIgraca odabranaStatIgraca = dgvIgraciNaUtakmici.CurrentRow.DataBoundItem as StatistikaIgraca;
            if(odabranaStatIgraca != null)
            {
                FrmDodajStatistikuIgraca formaDodaj = new FrmDodajStatistikuIgraca(Utakmica, odabranaStatIgraca);
                formaDodaj.ShowDialog();
                PrikaziPodatke();
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (dgvIgraciNaUtakmici.CurrentRow != null)
            {
                StatistikaIgraca odabranaStatIgraca = dgvIgraciNaUtakmici.CurrentRow.DataBoundItem as StatistikaIgraca;
                if (odabranaStatIgraca != null)
                {
                    if (MessageBox.Show("Jeste li sigurni da želite obrisati igrača s popisa statistike?", "Upozorenje!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        using (var db = new DimeEntities())
                        {
                            db.StatistikeIgraca.Attach(odabranaStatIgraca);
                            db.StatistikeIgraca.Remove(odabranaStatIgraca);
                            db.SaveChanges();
                        }
                    }
                    PrikaziPodatke();
                }
            }
        }
    }
}
