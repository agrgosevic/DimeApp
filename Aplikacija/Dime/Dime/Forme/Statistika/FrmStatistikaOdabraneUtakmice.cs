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
            lblProtivnik.Text = utakmica.Protivnik.naziv;
        }
    }
}
