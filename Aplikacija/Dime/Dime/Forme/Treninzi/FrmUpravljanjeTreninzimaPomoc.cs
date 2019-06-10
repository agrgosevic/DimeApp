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
    public partial class FrmUpravljanjeTreninzimaPomoc : Form
    {
        public FrmUpravljanjeTreninzimaPomoc()
        {
            InitializeComponent();
        }

        private void FrmUpravljanjeTreninzimaPomoc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
    }
}
