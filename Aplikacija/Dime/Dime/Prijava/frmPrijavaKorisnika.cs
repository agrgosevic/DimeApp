﻿using System;
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
    public partial class FrmPrijavaKorisnika : Form
    {
        public FrmPrijavaKorisnika()
        {
            InitializeComponent();
            txtLozinka.PasswordChar = '*';
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            DimeEntities db = new DimeEntities();
            int kontrolniBroj = 0;
            foreach (var item in db.Korisnici)
            {
                if (item.korisnicko_ime == txtKorisnickoIme.Text && item.lozinka == txtLozinka.Text)
                {
                    kontrolniBroj = 1;
                    FrmGlavniIzbornik formaGlavniIzbornik = new FrmGlavniIzbornik(item.ime, item.prezime);
                    txtKorisnickoIme.Clear();
                    txtLozinka.Clear();
                    this.Hide();
                    formaGlavniIzbornik.ShowDialog();
                    this.Show();
                    txtKorisnickoIme.Focus();

                }
            }
            if (kontrolniBroj == 0)
            {
                MessageBox.Show("Pogrešno korisničko ime ili lozinka.", "Greška!");
                txtLozinka.Clear();
            }
        }
    }
}