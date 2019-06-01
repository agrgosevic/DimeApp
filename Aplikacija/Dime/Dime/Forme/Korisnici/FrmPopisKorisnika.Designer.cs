﻿namespace Dime.Forme
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
            this.ulogaKorisnikaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.korisnikBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.idkorisnikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korisnickoimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lozinkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ulogaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ulogaKorisnikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.treninziDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.utakmiceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisKorisnika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ulogaKorisnikaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPopisKorisnika
            // 
            this.dgvPopisKorisnika.AutoGenerateColumns = false;
            this.dgvPopisKorisnika.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPopisKorisnika.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPopisKorisnika.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idkorisnikDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.korisnickoimeDataGridViewTextBoxColumn,
            this.lozinkaDataGridViewTextBoxColumn,
            this.ulogaDataGridViewTextBoxColumn,
            this.ulogaKorisnikaDataGridViewTextBoxColumn,
            this.treninziDataGridViewTextBoxColumn,
            this.utakmiceDataGridViewTextBoxColumn});
            this.dgvPopisKorisnika.DataSource = this.korisnikBindingSource2;
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
            // ulogaKorisnikaBindingSource
            // 
            this.ulogaKorisnikaBindingSource.DataSource = typeof(Dime.UlogaKorisnika);
            // 
            // korisnikBindingSource2
            // 
            this.korisnikBindingSource2.DataSource = typeof(Dime.Korisnik);
            // 
            // idkorisnikDataGridViewTextBoxColumn
            // 
            this.idkorisnikDataGridViewTextBoxColumn.DataPropertyName = "id_korisnik";
            this.idkorisnikDataGridViewTextBoxColumn.HeaderText = "id_korisnik";
            this.idkorisnikDataGridViewTextBoxColumn.Name = "idkorisnikDataGridViewTextBoxColumn";
            this.idkorisnikDataGridViewTextBoxColumn.Visible = false;
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "prezime";
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "prezime";
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // korisnickoimeDataGridViewTextBoxColumn
            // 
            this.korisnickoimeDataGridViewTextBoxColumn.DataPropertyName = "korisnicko_ime";
            this.korisnickoimeDataGridViewTextBoxColumn.HeaderText = "korisnicko_ime";
            this.korisnickoimeDataGridViewTextBoxColumn.Name = "korisnickoimeDataGridViewTextBoxColumn";
            // 
            // lozinkaDataGridViewTextBoxColumn
            // 
            this.lozinkaDataGridViewTextBoxColumn.DataPropertyName = "lozinka";
            this.lozinkaDataGridViewTextBoxColumn.HeaderText = "lozinka";
            this.lozinkaDataGridViewTextBoxColumn.Name = "lozinkaDataGridViewTextBoxColumn";
            // 
            // ulogaDataGridViewTextBoxColumn
            // 
            this.ulogaDataGridViewTextBoxColumn.DataPropertyName = "uloga";
            this.ulogaDataGridViewTextBoxColumn.DataSource = this.ulogaKorisnikaBindingSource;
            this.ulogaDataGridViewTextBoxColumn.DisplayMember = "naziv";
            this.ulogaDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.ulogaDataGridViewTextBoxColumn.HeaderText = "uloga";
            this.ulogaDataGridViewTextBoxColumn.Name = "ulogaDataGridViewTextBoxColumn";
            this.ulogaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ulogaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ulogaDataGridViewTextBoxColumn.ValueMember = "id_uloga";
            this.ulogaDataGridViewTextBoxColumn.Visible = false;
            // 
            // ulogaKorisnikaDataGridViewTextBoxColumn
            // 
            this.ulogaKorisnikaDataGridViewTextBoxColumn.DataPropertyName = "UlogaKorisnika";
            this.ulogaKorisnikaDataGridViewTextBoxColumn.DataSource = this.ulogaKorisnikaBindingSource;
            this.ulogaKorisnikaDataGridViewTextBoxColumn.DisplayMember = "naziv";
            this.ulogaKorisnikaDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.ulogaKorisnikaDataGridViewTextBoxColumn.HeaderText = "UlogaKorisnika";
            this.ulogaKorisnikaDataGridViewTextBoxColumn.Name = "ulogaKorisnikaDataGridViewTextBoxColumn";
            this.ulogaKorisnikaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ulogaKorisnikaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ulogaKorisnikaDataGridViewTextBoxColumn.ValueMember = "id_uloga";
            this.ulogaKorisnikaDataGridViewTextBoxColumn.Visible = false;
            // 
            // treninziDataGridViewTextBoxColumn
            // 
            this.treninziDataGridViewTextBoxColumn.DataPropertyName = "Treninzi";
            this.treninziDataGridViewTextBoxColumn.HeaderText = "Treninzi";
            this.treninziDataGridViewTextBoxColumn.Name = "treninziDataGridViewTextBoxColumn";
            this.treninziDataGridViewTextBoxColumn.Visible = false;
            // 
            // utakmiceDataGridViewTextBoxColumn
            // 
            this.utakmiceDataGridViewTextBoxColumn.DataPropertyName = "Utakmice";
            this.utakmiceDataGridViewTextBoxColumn.HeaderText = "Utakmice";
            this.utakmiceDataGridViewTextBoxColumn.Name = "utakmiceDataGridViewTextBoxColumn";
            this.utakmiceDataGridViewTextBoxColumn.Visible = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.ulogaKorisnikaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPopisKorisnika;
        private System.Windows.Forms.Button frmDodajZaposlenika;
        private System.Windows.Forms.Button btnObrisiKorisnika;
        private System.Windows.Forms.Button btnUrediKorisnika;
        private System.Windows.Forms.BindingSource korisnikBindingSource2;
        private System.Windows.Forms.BindingSource ulogaKorisnikaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idkorisnikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisnickoimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lozinkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn ulogaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn ulogaKorisnikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn treninziDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn utakmiceDataGridViewTextBoxColumn;
    }
}