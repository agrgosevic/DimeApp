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
            PrikaziTipoveTreninga();
        }

        public void PrikaziTipoveTreninga()
        {
            List<TipTreninga> tipoviTreninga;
            using (var db = new DimeEntities())
            {
                tipoviTreninga = db.TipoviTreninga.ToList();
            }
            cmbTipTreninga.DataSource = tipoviTreninga;
        }

        private void btnDodajTrening_Click(object sender, EventArgs e)
        {
            DateTime datum_vrijeme = dtpDatum.Value;
            using (var db = new DimeEntities())
            {
                Korisnik k = new Korisnik();
                Trening noviTrening = new Trening
                {
                    datum = datum_vrijeme.Date,
                    vrijeme = datum_vrijeme.TimeOfDay,
                    napomena = txtNapomena.Text,
                    tip_treninga = int.Parse(cmbTipTreninga.SelectedItem.ToString()),
                    korisnik = k.id_korisnik
                };
                db.Treninzi.Add(noviTrening);
                db.SaveChanges();
            }
            Close();
        }

        private void FrmDodajIzmijeniTrening_Load(object sender, EventArgs e)
        {
            dtpDatum.Format = DateTimePickerFormat.Custom;
            dtpDatum.CustomFormat = "dd/MM/yyyy hh:mm:ss";
        }
    }
}
