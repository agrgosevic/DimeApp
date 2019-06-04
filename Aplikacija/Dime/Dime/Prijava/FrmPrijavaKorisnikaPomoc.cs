using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dime.Prijava
{
    public partial class FrmPrijavaKorisnikaPomoc : Form
    {
        public FrmPrijavaKorisnikaPomoc()
        {
            InitializeComponent();
        }

        private void FrmPrijavaKorisnikaPomoc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
    }
}
