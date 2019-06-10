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
    public partial class FrmDodajIzmijeniUtakmicuPomoc : Form
    {
        public FrmDodajIzmijeniUtakmicuPomoc()
        {
            InitializeComponent();
        }

        private void FrmDodajIzmijeniUtakmicuPomoc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
    }
}
