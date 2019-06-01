namespace Dime.Forme
{
    partial class FrmPopisKorisnika
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPopisKorisnika));
            this.dgvPopisKorisnika = new System.Windows.Forms.DataGridView();
            this.frmDodajZaposlenika = new System.Windows.Forms.Button();
            this.btnObrisiKorisnika = new System.Windows.Forms.Button();
            this.btnUrediKorisnika = new System.Windows.Forms.Button();
            this.korisnikBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.korisnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisKorisnika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPopisKorisnika
            // 
            this.dgvPopisKorisnika.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPopisKorisnika.Location = new System.Drawing.Point(12, 12);
            this.dgvPopisKorisnika.Name = "dgvPopisKorisnika";
            this.dgvPopisKorisnika.Size = new System.Drawing.Size(701, 426);
            this.dgvPopisKorisnika.TabIndex = 0;
            // 
            // frmDodajZaposlenika
            // 
            this.frmDodajZaposlenika.Location = new System.Drawing.Point(719, 12);
            this.frmDodajZaposlenika.Name = "frmDodajZaposlenika";
            this.frmDodajZaposlenika.Size = new System.Drawing.Size(75, 46);
            this.frmDodajZaposlenika.TabIndex = 2;
            this.frmDodajZaposlenika.Text = "Dodaj korisnika";
            this.frmDodajZaposlenika.UseVisualStyleBackColor = true;
            this.frmDodajZaposlenika.Click += new System.EventHandler(this.frmDodajZaposlenika_Click);
            // 
            // btnObrisiKorisnika
            // 
            this.btnObrisiKorisnika.Location = new System.Drawing.Point(719, 144);
            this.btnObrisiKorisnika.Name = "btnObrisiKorisnika";
            this.btnObrisiKorisnika.Size = new System.Drawing.Size(75, 46);
            this.btnObrisiKorisnika.TabIndex = 3;
            this.btnObrisiKorisnika.Text = "Obriši korisnika";
            this.btnObrisiKorisnika.UseVisualStyleBackColor = true;
            this.btnObrisiKorisnika.Click += new System.EventHandler(this.btnObrisiKorisnika_Click);
            // 
            // btnUrediKorisnika
            // 
            this.btnUrediKorisnika.Location = new System.Drawing.Point(719, 79);
            this.btnUrediKorisnika.Name = "btnUrediKorisnika";
            this.btnUrediKorisnika.Size = new System.Drawing.Size(75, 46);
            this.btnUrediKorisnika.TabIndex = 4;
            this.btnUrediKorisnika.Text = "Uredi korisnika";
            this.btnUrediKorisnika.UseVisualStyleBackColor = true;
            this.btnUrediKorisnika.Click += new System.EventHandler(this.btnUrediKorisnika_Click);
            // 
            // korisnikBindingSource1
            // 
            this.korisnikBindingSource1.DataSource = typeof(Dime.Korisnik);
            // 
            // korisnikBindingSource
            // 
            this.korisnikBindingSource.DataSource = typeof(Dime.Korisnik);
            // 
            // FrmPopisKorisnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUrediKorisnika);
            this.Controls.Add(this.btnObrisiKorisnika);
            this.Controls.Add(this.frmDodajZaposlenika);
            this.Controls.Add(this.dgvPopisKorisnika);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPopisKorisnika";
            this.Text = "Korisnici";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisKorisnika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPopisKorisnika;
        private System.Windows.Forms.Button frmDodajZaposlenika;
        private System.Windows.Forms.Button btnObrisiKorisnika;
        private System.Windows.Forms.Button btnUrediKorisnika;
        private System.Windows.Forms.BindingSource korisnikBindingSource;
        private System.Windows.Forms.BindingSource korisnikBindingSource1;
    }
}