namespace Dime.Forme.Treninzi
{
    partial class FrmDodajIzmijeniTrening
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
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNapomena = new System.Windows.Forms.TextBox();
            this.cmbTipTreninga = new System.Windows.Forms.ComboBox();
            this.tipTreningaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._19008_DBDataSetPrimary = new Dime._19008_DBDataSetPrimary();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.cmbKorisnik = new System.Windows.Forms.ComboBox();
            this.korisnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.korisnikTableAdapter = new Dime._19008_DBDataSetPrimaryTableAdapters.KorisnikTableAdapter();
            this.tipTreningaTableAdapter = new Dime._19008_DBDataSetPrimaryTableAdapters.TipTreningaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tipTreningaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._19008_DBDataSetPrimary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Datum i vrijeme";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Napomena";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tip treninga";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Korisnik";
            // 
            // txtNapomena
            // 
            this.txtNapomena.Location = new System.Drawing.Point(101, 66);
            this.txtNapomena.Name = "txtNapomena";
            this.txtNapomena.Size = new System.Drawing.Size(121, 20);
            this.txtNapomena.TabIndex = 9;
            // 
            // cmbTipTreninga
            // 
            this.cmbTipTreninga.DataSource = this.tipTreningaBindingSource;
            this.cmbTipTreninga.DisplayMember = "naziv_tipa";
            this.cmbTipTreninga.FormattingEnabled = true;
            this.cmbTipTreninga.Location = new System.Drawing.Point(101, 100);
            this.cmbTipTreninga.Name = "cmbTipTreninga";
            this.cmbTipTreninga.Size = new System.Drawing.Size(121, 21);
            this.cmbTipTreninga.TabIndex = 12;
            this.cmbTipTreninga.ValueMember = "id_tipa_treninga";
            // 
            // tipTreningaBindingSource
            // 
            this.tipTreningaBindingSource.DataMember = "TipTreninga";
            this.tipTreningaBindingSource.DataSource = this._19008_DBDataSetPrimary;
            // 
            // _19008_DBDataSetPrimary
            // 
            this._19008_DBDataSetPrimary.DataSetName = "_19008_DBDataSetPrimary";
            this._19008_DBDataSetPrimary.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(101, 175);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(121, 36);
            this.btnSpremi.TabIndex = 13;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnDodajTrening_Click);
            // 
            // dtpDatum
            // 
            this.dtpDatum.CustomFormat = "yyyy-mm-dd HH:mm:ss";
            this.dtpDatum.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatum.Location = new System.Drawing.Point(101, 31);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(200, 20);
            this.dtpDatum.TabIndex = 14;
            this.dtpDatum.Value = new System.DateTime(2019, 6, 14, 0, 0, 0, 0);
            // 
            // cmbKorisnik
            // 
            this.cmbKorisnik.DataSource = this.korisnikBindingSource;
            this.cmbKorisnik.DisplayMember = "korisnicko_ime";
            this.cmbKorisnik.FormattingEnabled = true;
            this.cmbKorisnik.Location = new System.Drawing.Point(101, 134);
            this.cmbKorisnik.Name = "cmbKorisnik";
            this.cmbKorisnik.Size = new System.Drawing.Size(121, 21);
            this.cmbKorisnik.TabIndex = 15;
            this.cmbKorisnik.ValueMember = "id_korisnik";
            // 
            // korisnikBindingSource
            // 
            this.korisnikBindingSource.DataMember = "Korisnik";
            this.korisnikBindingSource.DataSource = this._19008_DBDataSetPrimary;
            // 
            // korisnikTableAdapter
            // 
            this.korisnikTableAdapter.ClearBeforeFill = true;
            // 
            // tipTreningaTableAdapter
            // 
            this.tipTreningaTableAdapter.ClearBeforeFill = true;
            // 
            // FrmDodajIzmijeniTrening
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 297);
            this.Controls.Add(this.cmbKorisnik);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.cmbTipTreninga);
            this.Controls.Add(this.txtNapomena);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Name = "FrmDodajIzmijeniTrening";
            this.Text = "FrmDodajIzmijeniTrening";
            this.Load += new System.EventHandler(this.FrmDodajIzmijeniTrening_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tipTreningaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._19008_DBDataSetPrimary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNapomena;
        private System.Windows.Forms.ComboBox cmbTipTreninga;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.ComboBox cmbKorisnik;
        private _19008_DBDataSetPrimary _19008_DBDataSetPrimary;
        private System.Windows.Forms.BindingSource korisnikBindingSource;
        private _19008_DBDataSetPrimaryTableAdapters.KorisnikTableAdapter korisnikTableAdapter;
        private System.Windows.Forms.BindingSource tipTreningaBindingSource;
        private _19008_DBDataSetPrimaryTableAdapters.TipTreningaTableAdapter tipTreningaTableAdapter;
    }
}