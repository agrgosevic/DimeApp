using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dime.Forme.Aktivnosti
{
    public partial class FrmDodajClanarinu : Form
    {
        private Clanarina Clanarina;

        public FrmDodajClanarinu()
        {
            InitializeComponent();
        }

        public FrmDodajClanarinu(Clanarina clanarina)
        {
            Clanarina = clanarina;
            InitializeComponent();
        }

        private void FrmDodajClanarinu_Load(object sender, EventArgs e)
        {
            if (Clanarina != null)
            {
                using (var db = new DimeEntities())
                {
                    cmbMjeseci.SelectedIndex = cmbMjeseci.Items.IndexOf(Clanarina.mjesec);
                    txtGodina.Text = Clanarina.godina.ToString();
                    dtpRok.Value = Clanarina.rok_uplate;

                    cmbMjeseci.Enabled = false;
                    txtGodina.Enabled = false;
                }
            }
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            using (var db = new DimeEntities())
            {
                if (Clanarina == null)
                {
                    Clanarina novaClanarina = new Clanarina();
                    novaClanarina.mjesec = cmbMjeseci.SelectedItem.ToString();
                    novaClanarina.godina = int.Parse(txtGodina.Text);
                    novaClanarina.rok_uplate = dtpRok.Value;

                    db.Clanarine.Add(novaClanarina);
                    db.SaveChanges();
                }
                else
                {
                    db.Clanarine.Attach(Clanarina);
                    Clanarina.rok_uplate = dtpRok.Value;

                    db.SaveChanges();
                }
            }
            Close();
        }
    }
}
