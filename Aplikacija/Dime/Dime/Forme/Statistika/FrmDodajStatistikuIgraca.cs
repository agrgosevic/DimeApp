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
    public partial class FrmDodajStatistikuIgraca : Form
    {
        private StatistikaIgraca StatIgrac;
        private Utakmica Utakmica;
        public FrmDodajStatistikuIgraca(Utakmica utakmica)
        {
            InitializeComponent();
            Utakmica = utakmica;
        }

        public FrmDodajStatistikuIgraca(Utakmica utakmica, StatistikaIgraca statistikaIgraca)
        {
            InitializeComponent();
            Utakmica = utakmica;
            StatIgrac = statistikaIgraca;
        }

        private void FrmDodajStatistikuIgraca_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_19008_DBDataSetPrimary.Igrac' table. You can move, or remove it, as needed.
            this.igracTableAdapter.Fill(this._19008_DBDataSetPrimary.Igrac);
            if (StatIgrac != null)
            {
                using (var db = new DimeEntities())
                {
                    cmbIgraci.SelectedValue = db.Igraci.First(i => i.id_igrac == StatIgrac.id_igraca).id_igrac;
                    txtMinute.Text = StatIgrac.minutaza.ToString();
                    txtSBZ.Text = StatIgrac.sb_zabijeni.ToString();
                    txtSBP.Text = StatIgrac.sb_pokusaji.ToString();
                    txt2pZ.Text = StatIgrac.p2_zabijeni.ToString();
                    txt2pP.Text = StatIgrac.p2_pokusaji.ToString();
                    txt3pZ.Text = StatIgrac.p3_zabijeni.ToString();
                    txt3pP.Text = StatIgrac.p3_pokusaji.ToString();
                    txtAsistencije.Text = StatIgrac.asistencije.ToString();
                    txtSkokovi.Text = StatIgrac.skokovi.ToString();
                    txtPrekrsaji.Text = StatIgrac.prekrsaji.ToString();
                }
            }

        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            using (var db = new DimeEntities())
            {
                if (StatIgrac == null)
                {
                    StatistikaIgraca statistikaIgraca = new StatistikaIgraca();
                    statistikaIgraca.id_igraca = int.Parse(cmbIgraci.SelectedValue.ToString());
                    statistikaIgraca.id_utakmice = Utakmica.id_utakmica;
                    statistikaIgraca.minutaza = int.Parse(txtMinute.Text);
                    statistikaIgraca.sb_zabijeni = int.Parse(txtSBZ.Text);
                    statistikaIgraca.sb_pokusaji = int.Parse(txtSBP.Text);
                    statistikaIgraca.p2_zabijeni = int.Parse(txt2pZ.Text);
                    statistikaIgraca.p2_pokusaji = int.Parse(txt2pP.Text);
                    statistikaIgraca.p3_zabijeni = int.Parse(txt3pZ.Text);
                    statistikaIgraca.p3_pokusaji = int.Parse(txt3pP.Text);
                    statistikaIgraca.asistencije = int.Parse(txtAsistencije.Text);
                    statistikaIgraca.skokovi = int.Parse(txtSkokovi.Text);
                    statistikaIgraca.prekrsaji = int.Parse(txtPrekrsaji.Text);

                    db.StatistikeIgraca.Add(statistikaIgraca);
                    db.SaveChanges();
                }
                else
                {
                    db.StatistikeIgraca.Attach(StatIgrac);
                    StatIgrac.minutaza = int.Parse(txtMinute.Text);
                    StatIgrac.sb_zabijeni = int.Parse(txtSBZ.Text);
                    StatIgrac.sb_pokusaji = int.Parse(txtSBP.Text);
                    StatIgrac.p2_zabijeni = int.Parse(txt2pZ.Text);
                    StatIgrac.p2_pokusaji = int.Parse(txt2pP.Text);
                    StatIgrac.p3_zabijeni = int.Parse(txt3pZ.Text);
                    StatIgrac.p3_pokusaji = int.Parse(txt3pP.Text);
                    StatIgrac.asistencije = int.Parse(txtAsistencije.Text);
                    StatIgrac.skokovi = int.Parse(txtSkokovi.Text);
                    StatIgrac.prekrsaji = int.Parse(txtPrekrsaji.Text);

                    db.SaveChanges();
                }
            }
            Close();
        }
    }
}
