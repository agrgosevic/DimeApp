namespace Dime.Forme.Utakmice
{
    partial class FrmDodajIzmijeniUtakmicu
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpDatumVrijeme = new System.Windows.Forms.DateTimePicker();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.txtZabijeniPoeni = new System.Windows.Forms.TextBox();
            this.txtPrimljeniPoeni = new System.Windows.Forms.TextBox();
            this.cmbTipUtakmice = new System.Windows.Forms.ComboBox();
            this.tipUtakmiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._19008_DBDataSetPrimary = new Dime._19008_DBDataSetPrimary();
            this.cmbKorisnik = new System.Windows.Forms.ComboBox();
            this.korisnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipUtakmiceTableAdapter = new Dime._19008_DBDataSetPrimaryTableAdapters.TipUtakmiceTableAdapter();
            this.korisnikTableAdapter = new Dime._19008_DBDataSetPrimaryTableAdapters.KorisnikTableAdapter();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.cmbProtivnik = new System.Windows.Forms.ComboBox();
            this.klubBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.klubTableAdapter = new Dime._19008_DBDataSetPrimaryTableAdapters.KlubTableAdapter();
            this.btnPomoć = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tipUtakmiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._19008_DBDataSetPrimary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klubBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datum i vrijeme";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Opis";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Zabijeni poeni";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Primljeni poeni";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tip utakmice";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Protivnik";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Korisnik";
            // 
            // dtpDatumVrijeme
            // 
            this.dtpDatumVrijeme.CustomFormat = "yyyy-mm-dd HH:mm:ss";
            this.dtpDatumVrijeme.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatumVrijeme.Location = new System.Drawing.Point(120, 37);
            this.dtpDatumVrijeme.Name = "dtpDatumVrijeme";
            this.dtpDatumVrijeme.Size = new System.Drawing.Size(200, 20);
            this.dtpDatumVrijeme.TabIndex = 7;
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(120, 76);
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(121, 20);
            this.txtOpis.TabIndex = 8;
            // 
            // txtZabijeniPoeni
            // 
            this.txtZabijeniPoeni.Location = new System.Drawing.Point(120, 111);
            this.txtZabijeniPoeni.Name = "txtZabijeniPoeni";
            this.txtZabijeniPoeni.Size = new System.Drawing.Size(121, 20);
            this.txtZabijeniPoeni.TabIndex = 9;
            // 
            // txtPrimljeniPoeni
            // 
            this.txtPrimljeniPoeni.Location = new System.Drawing.Point(120, 148);
            this.txtPrimljeniPoeni.Name = "txtPrimljeniPoeni";
            this.txtPrimljeniPoeni.Size = new System.Drawing.Size(121, 20);
            this.txtPrimljeniPoeni.TabIndex = 10;
            // 
            // cmbTipUtakmice
            // 
            this.cmbTipUtakmice.DataSource = this.tipUtakmiceBindingSource;
            this.cmbTipUtakmice.DisplayMember = "naziv_tipa";
            this.cmbTipUtakmice.FormattingEnabled = true;
            this.cmbTipUtakmice.Location = new System.Drawing.Point(120, 186);
            this.cmbTipUtakmice.Name = "cmbTipUtakmice";
            this.cmbTipUtakmice.Size = new System.Drawing.Size(121, 21);
            this.cmbTipUtakmice.TabIndex = 12;
            this.cmbTipUtakmice.ValueMember = "id_tipa_utakmice";
            // 
            // tipUtakmiceBindingSource
            // 
            this.tipUtakmiceBindingSource.DataMember = "TipUtakmice";
            this.tipUtakmiceBindingSource.DataSource = this._19008_DBDataSetPrimary;
            // 
            // _19008_DBDataSetPrimary
            // 
            this._19008_DBDataSetPrimary.DataSetName = "_19008_DBDataSetPrimary";
            this._19008_DBDataSetPrimary.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbKorisnik
            // 
            this.cmbKorisnik.DataSource = this.korisnikBindingSource;
            this.cmbKorisnik.DisplayMember = "korisnicko_ime";
            this.cmbKorisnik.FormattingEnabled = true;
            this.cmbKorisnik.Location = new System.Drawing.Point(120, 260);
            this.cmbKorisnik.Name = "cmbKorisnik";
            this.cmbKorisnik.Size = new System.Drawing.Size(121, 21);
            this.cmbKorisnik.TabIndex = 13;
            this.cmbKorisnik.ValueMember = "id_korisnik";
            // 
            // korisnikBindingSource
            // 
            this.korisnikBindingSource.DataMember = "Korisnik";
            this.korisnikBindingSource.DataSource = this._19008_DBDataSetPrimary;
            // 
            // tipUtakmiceTableAdapter
            // 
            this.tipUtakmiceTableAdapter.ClearBeforeFill = true;
            // 
            // korisnikTableAdapter
            // 
            this.korisnikTableAdapter.ClearBeforeFill = true;
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(120, 309);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(121, 32);
            this.btnSpremi.TabIndex = 14;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // cmbProtivnik
            // 
            this.cmbProtivnik.DataSource = this.klubBindingSource;
            this.cmbProtivnik.DisplayMember = "naziv";
            this.cmbProtivnik.FormattingEnabled = true;
            this.cmbProtivnik.Location = new System.Drawing.Point(120, 224);
            this.cmbProtivnik.Name = "cmbProtivnik";
            this.cmbProtivnik.Size = new System.Drawing.Size(121, 21);
            this.cmbProtivnik.TabIndex = 15;
            this.cmbProtivnik.ValueMember = "id_klub";
            // 
            // klubBindingSource
            // 
            this.klubBindingSource.DataMember = "Klub";
            this.klubBindingSource.DataSource = this._19008_DBDataSetPrimary;
            // 
            // klubTableAdapter
            // 
            this.klubTableAdapter.ClearBeforeFill = true;
            // 
            // btnPomoć
            // 
            this.btnPomoć.Location = new System.Drawing.Point(295, 349);
            this.btnPomoć.Name = "btnPomoć";
            this.btnPomoć.Size = new System.Drawing.Size(48, 36);
            this.btnPomoć.TabIndex = 18;
            this.btnPomoć.Text = "Pomoć (F1)";
            this.btnPomoć.UseVisualStyleBackColor = true;
            this.btnPomoć.Click += new System.EventHandler(this.btnPomoć_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(120, 353);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(121, 32);
            this.btnOdustani.TabIndex = 19;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // FrmDodajIzmijeniUtakmicu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 397);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnPomoć);
            this.Controls.Add(this.cmbProtivnik);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.cmbKorisnik);
            this.Controls.Add(this.cmbTipUtakmice);
            this.Controls.Add(this.txtPrimljeniPoeni);
            this.Controls.Add(this.txtZabijeniPoeni);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.dtpDatumVrijeme);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmDodajIzmijeniUtakmicu";
            this.Text = "FrmDodajIzmijeniUtakmicu";
            this.Load += new System.EventHandler(this.FrmDodajIzmijeniUtakmicu_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.FrmDodajIzmijeniUtakmicu_HelpRequested);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmDodajIzmijeniUtakmicu_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.tipUtakmiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._19008_DBDataSetPrimary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klubBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpDatumVrijeme;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.TextBox txtZabijeniPoeni;
        private System.Windows.Forms.TextBox txtPrimljeniPoeni;
        private System.Windows.Forms.ComboBox cmbTipUtakmice;
        private System.Windows.Forms.ComboBox cmbKorisnik;
        private _19008_DBDataSetPrimary _19008_DBDataSetPrimary;
        private System.Windows.Forms.BindingSource tipUtakmiceBindingSource;
        private _19008_DBDataSetPrimaryTableAdapters.TipUtakmiceTableAdapter tipUtakmiceTableAdapter;
        private System.Windows.Forms.BindingSource korisnikBindingSource;
        private _19008_DBDataSetPrimaryTableAdapters.KorisnikTableAdapter korisnikTableAdapter;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.ComboBox cmbProtivnik;
        private System.Windows.Forms.BindingSource klubBindingSource;
        private _19008_DBDataSetPrimaryTableAdapters.KlubTableAdapter klubTableAdapter;
        private System.Windows.Forms.Button btnPomoć;
        private System.Windows.Forms.Button btnOdustani;
    }
}