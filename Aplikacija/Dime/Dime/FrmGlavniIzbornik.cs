using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dime
{
    public partial class FrmGlavniIzbornik : Form
    {
        string ime = "";
        string prezime = "";
        public FrmGlavniIzbornik(string imeKorisnika, string prezimeKorisnika)
        {
            InitializeComponent();
            ime = imeKorisnika;
            prezime = prezimeKorisnika;
            lblImeKorisnika.Text = ime + " " + prezime;
        }
    }
}
