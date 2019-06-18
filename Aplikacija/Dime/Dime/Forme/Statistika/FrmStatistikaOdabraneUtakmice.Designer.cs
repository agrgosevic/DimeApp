﻿namespace Dime.Forme.Statistika
{
    partial class FrmStatistikaOdabraneUtakmice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStatistikaOdabraneUtakmice));
            this.lblNasKlub = new System.Windows.Forms.Label();
            this.lblProtivnik = new System.Windows.Forms.Label();
            this.lblDvotocka = new System.Windows.Forms.Label();
            this.lblZabijeniPoeni = new System.Windows.Forms.Label();
            this.lblPrimljeniPoeni = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblVrijeme = new System.Windows.Forms.Label();
            this.lblTipUtakmice = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvIgraciNaUtakmici = new System.Windows.Forms.DataGridView();
            this.lblPopisIgraca = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnIzmjeni = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt3pPostotak = new System.Windows.Forms.TextBox();
            this.txt2pPostotak = new System.Windows.Forms.TextBox();
            this.txtSBPostotak = new System.Windows.Forms.TextBox();
            this.txtSkokovi = new System.Windows.Forms.TextBox();
            this.txtAsistencije = new System.Windows.Forms.TextBox();
            this.txtPoeni = new System.Windows.Forms.TextBox();
            this.txtMinute = new System.Windows.Forms.TextBox();
            this.lbl3pPostotak = new System.Windows.Forms.Label();
            this.lbl2pPostotak = new System.Windows.Forms.Label();
            this.lblSlobodnaPostotak = new System.Windows.Forms.Label();
            this.lblSkokovi = new System.Windows.Forms.Label();
            this.lblAsistencije = new System.Windows.Forms.Label();
            this.lblPoeni = new System.Windows.Forms.Label();
            this.lblMinutaza = new System.Windows.Forms.Label();
            this.lblImePrezime = new System.Windows.Forms.Label();
            this._19008_DBDataSetPrimary = new Dime._19008_DBDataSetPrimary();
            this.statistikaIgracaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statistikaIgracaTableAdapter = new Dime._19008_DBDataSetPrimaryTableAdapters.StatistikaIgracaTableAdapter();
            this.igracBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.igracTableAdapter = new Dime._19008_DBDataSetPrimaryTableAdapters.IgracTableAdapter();
            this.idutakmiceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minutazaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idigracaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.sbzabijeniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sbpokusajiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p2zabijeniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p2pokusajiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p3zabijeniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p3pokusajiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asistencijeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skokoviDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prekrsajiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIgraciNaUtakmici)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._19008_DBDataSetPrimary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statistikaIgracaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.igracBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNasKlub
            // 
            this.lblNasKlub.AutoSize = true;
            this.lblNasKlub.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNasKlub.Location = new System.Drawing.Point(6, 11);
            this.lblNasKlub.Name = "lblNasKlub";
            this.lblNasKlub.Size = new System.Drawing.Size(166, 34);
            this.lblNasKlub.TabIndex = 0;
            this.lblNasKlub.Text = "[ Naš klub ]";
            // 
            // lblProtivnik
            // 
            this.lblProtivnik.AutoSize = true;
            this.lblProtivnik.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProtivnik.Location = new System.Drawing.Point(306, 11);
            this.lblProtivnik.Name = "lblProtivnik";
            this.lblProtivnik.Size = new System.Drawing.Size(163, 34);
            this.lblProtivnik.TabIndex = 1;
            this.lblProtivnik.Text = "[ Protivnik ]";
            // 
            // lblDvotocka
            // 
            this.lblDvotocka.AutoSize = true;
            this.lblDvotocka.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDvotocka.Location = new System.Drawing.Point(226, 11);
            this.lblDvotocka.Name = "lblDvotocka";
            this.lblDvotocka.Size = new System.Drawing.Size(23, 34);
            this.lblDvotocka.TabIndex = 2;
            this.lblDvotocka.Text = ":";
            // 
            // lblZabijeniPoeni
            // 
            this.lblZabijeniPoeni.AutoSize = true;
            this.lblZabijeniPoeni.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZabijeniPoeni.Location = new System.Drawing.Point(186, 11);
            this.lblZabijeniPoeni.Name = "lblZabijeniPoeni";
            this.lblZabijeniPoeni.Size = new System.Drawing.Size(34, 37);
            this.lblZabijeniPoeni.TabIndex = 3;
            this.lblZabijeniPoeni.Text = "0";
            // 
            // lblPrimljeniPoeni
            // 
            this.lblPrimljeniPoeni.AutoSize = true;
            this.lblPrimljeniPoeni.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimljeniPoeni.Location = new System.Drawing.Point(256, 11);
            this.lblPrimljeniPoeni.Name = "lblPrimljeniPoeni";
            this.lblPrimljeniPoeni.Size = new System.Drawing.Size(34, 37);
            this.lblPrimljeniPoeni.TabIndex = 4;
            this.lblPrimljeniPoeni.Text = "0";
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatum.Location = new System.Drawing.Point(189, 60);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(98, 23);
            this.lblDatum.TabIndex = 5;
            this.lblDatum.Text = "[ Datum ]";
            // 
            // lblVrijeme
            // 
            this.lblVrijeme.AutoSize = true;
            this.lblVrijeme.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVrijeme.Location = new System.Drawing.Point(183, 92);
            this.lblVrijeme.Name = "lblVrijeme";
            this.lblVrijeme.Size = new System.Drawing.Size(109, 23);
            this.lblVrijeme.TabIndex = 6;
            this.lblVrijeme.Text = "[ Vrijeme ]";
            // 
            // lblTipUtakmice
            // 
            this.lblTipUtakmice.AutoSize = true;
            this.lblTipUtakmice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipUtakmice.Location = new System.Drawing.Point(208, 124);
            this.lblTipUtakmice.Name = "lblTipUtakmice";
            this.lblTipUtakmice.Size = new System.Drawing.Size(60, 23);
            this.lblTipUtakmice.TabIndex = 7;
            this.lblTipUtakmice.Text = "[ Tip ]";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblVrijeme);
            this.groupBox1.Controls.Add(this.lblTipUtakmice);
            this.groupBox1.Controls.Add(this.lblDatum);
            this.groupBox1.Controls.Add(this.lblZabijeniPoeni);
            this.groupBox1.Controls.Add(this.lblDvotocka);
            this.groupBox1.Controls.Add(this.lblPrimljeniPoeni);
            this.groupBox1.Controls.Add(this.lblNasKlub);
            this.groupBox1.Controls.Add(this.lblProtivnik);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(473, 159);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // dgvIgraciNaUtakmici
            // 
            this.dgvIgraciNaUtakmici.AutoGenerateColumns = false;
            this.dgvIgraciNaUtakmici.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIgraciNaUtakmici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIgraciNaUtakmici.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idutakmiceDataGridViewTextBoxColumn,
            this.minutazaDataGridViewTextBoxColumn,
            this.idigracaDataGridViewTextBoxColumn,
            this.sbzabijeniDataGridViewTextBoxColumn,
            this.sbpokusajiDataGridViewTextBoxColumn,
            this.p2zabijeniDataGridViewTextBoxColumn,
            this.p2pokusajiDataGridViewTextBoxColumn,
            this.p3zabijeniDataGridViewTextBoxColumn,
            this.p3pokusajiDataGridViewTextBoxColumn,
            this.asistencijeDataGridViewTextBoxColumn,
            this.skokoviDataGridViewTextBoxColumn,
            this.prekrsajiDataGridViewTextBoxColumn});
            this.dgvIgraciNaUtakmici.DataSource = this.statistikaIgracaBindingSource;
            this.dgvIgraciNaUtakmici.Location = new System.Drawing.Point(12, 211);
            this.dgvIgraciNaUtakmici.Name = "dgvIgraciNaUtakmici";
            this.dgvIgraciNaUtakmici.RowTemplate.Height = 24;
            this.dgvIgraciNaUtakmici.Size = new System.Drawing.Size(472, 259);
            this.dgvIgraciNaUtakmici.TabIndex = 9;
            this.dgvIgraciNaUtakmici.SelectionChanged += new System.EventHandler(this.dgvIgraciNaUtakmici_SelectionChanged);
            // 
            // lblPopisIgraca
            // 
            this.lblPopisIgraca.AutoSize = true;
            this.lblPopisIgraca.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPopisIgraca.Location = new System.Drawing.Point(8, 187);
            this.lblPopisIgraca.Name = "lblPopisIgraca";
            this.lblPopisIgraca.Size = new System.Drawing.Size(117, 21);
            this.lblPopisIgraca.TabIndex = 10;
            this.lblPopisIgraca.Text = "Popis igrača:";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(12, 476);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(112, 35);
            this.btnDodaj.TabIndex = 11;
            this.btnDodaj.Text = "Dodaj igrača";
            this.btnDodaj.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(248, 476);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 12;
            this.button1.Text = "Obriši igrača";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnIzmjeni
            // 
            this.btnIzmjeni.Location = new System.Drawing.Point(130, 476);
            this.btnIzmjeni.Name = "btnIzmjeni";
            this.btnIzmjeni.Size = new System.Drawing.Size(112, 35);
            this.btnIzmjeni.TabIndex = 13;
            this.btnIzmjeni.Text = "Uredi statistiku";
            this.btnIzmjeni.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt3pPostotak);
            this.groupBox2.Controls.Add(this.txt2pPostotak);
            this.groupBox2.Controls.Add(this.txtSBPostotak);
            this.groupBox2.Controls.Add(this.txtSkokovi);
            this.groupBox2.Controls.Add(this.txtAsistencije);
            this.groupBox2.Controls.Add(this.txtPoeni);
            this.groupBox2.Controls.Add(this.txtMinute);
            this.groupBox2.Controls.Add(this.lbl3pPostotak);
            this.groupBox2.Controls.Add(this.lbl2pPostotak);
            this.groupBox2.Controls.Add(this.lblSlobodnaPostotak);
            this.groupBox2.Controls.Add(this.lblSkokovi);
            this.groupBox2.Controls.Add(this.lblAsistencije);
            this.groupBox2.Controls.Add(this.lblPoeni);
            this.groupBox2.Controls.Add(this.lblMinutaza);
            this.groupBox2.Controls.Add(this.lblImePrezime);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(510, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(438, 499);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Statistika igrača";
            // 
            // txt3pPostotak
            // 
            this.txt3pPostotak.Enabled = false;
            this.txt3pPostotak.Location = new System.Drawing.Point(325, 322);
            this.txt3pPostotak.Multiline = true;
            this.txt3pPostotak.Name = "txt3pPostotak";
            this.txt3pPostotak.Size = new System.Drawing.Size(70, 40);
            this.txt3pPostotak.TabIndex = 29;
            // 
            // txt2pPostotak
            // 
            this.txt2pPostotak.Enabled = false;
            this.txt2pPostotak.Location = new System.Drawing.Point(189, 322);
            this.txt2pPostotak.Multiline = true;
            this.txt2pPostotak.Name = "txt2pPostotak";
            this.txt2pPostotak.Size = new System.Drawing.Size(70, 40);
            this.txt2pPostotak.TabIndex = 28;
            // 
            // txtSBPostotak
            // 
            this.txtSBPostotak.Enabled = false;
            this.txtSBPostotak.Location = new System.Drawing.Point(55, 322);
            this.txtSBPostotak.Multiline = true;
            this.txtSBPostotak.Name = "txtSBPostotak";
            this.txtSBPostotak.Size = new System.Drawing.Size(70, 40);
            this.txtSBPostotak.TabIndex = 27;
            // 
            // txtSkokovi
            // 
            this.txtSkokovi.Enabled = false;
            this.txtSkokovi.Location = new System.Drawing.Point(250, 208);
            this.txtSkokovi.Multiline = true;
            this.txtSkokovi.Name = "txtSkokovi";
            this.txtSkokovi.Size = new System.Drawing.Size(100, 50);
            this.txtSkokovi.TabIndex = 26;
            // 
            // txtAsistencije
            // 
            this.txtAsistencije.Enabled = false;
            this.txtAsistencije.Location = new System.Drawing.Point(93, 208);
            this.txtAsistencije.Multiline = true;
            this.txtAsistencije.Name = "txtAsistencije";
            this.txtAsistencije.Size = new System.Drawing.Size(100, 50);
            this.txtAsistencije.TabIndex = 25;
            // 
            // txtPoeni
            // 
            this.txtPoeni.Enabled = false;
            this.txtPoeni.Location = new System.Drawing.Point(250, 109);
            this.txtPoeni.Multiline = true;
            this.txtPoeni.Name = "txtPoeni";
            this.txtPoeni.Size = new System.Drawing.Size(100, 50);
            this.txtPoeni.TabIndex = 24;
            // 
            // txtMinute
            // 
            this.txtMinute.Enabled = false;
            this.txtMinute.Location = new System.Drawing.Point(93, 109);
            this.txtMinute.Multiline = true;
            this.txtMinute.Name = "txtMinute";
            this.txtMinute.Size = new System.Drawing.Size(100, 50);
            this.txtMinute.TabIndex = 22;
            // 
            // lbl3pPostotak
            // 
            this.lbl3pPostotak.AutoSize = true;
            this.lbl3pPostotak.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3pPostotak.Location = new System.Drawing.Point(335, 365);
            this.lbl3pPostotak.Name = "lbl3pPostotak";
            this.lbl3pPostotak.Size = new System.Drawing.Size(49, 23);
            this.lbl3pPostotak.TabIndex = 21;
            this.lbl3pPostotak.Text = "3P%";
            // 
            // lbl2pPostotak
            // 
            this.lbl2pPostotak.AutoSize = true;
            this.lbl2pPostotak.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2pPostotak.Location = new System.Drawing.Point(200, 365);
            this.lbl2pPostotak.Name = "lbl2pPostotak";
            this.lbl2pPostotak.Size = new System.Drawing.Size(49, 23);
            this.lbl2pPostotak.TabIndex = 20;
            this.lbl2pPostotak.Text = "2P%";
            // 
            // lblSlobodnaPostotak
            // 
            this.lblSlobodnaPostotak.AutoSize = true;
            this.lblSlobodnaPostotak.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlobodnaPostotak.Location = new System.Drawing.Point(67, 365);
            this.lblSlobodnaPostotak.Name = "lblSlobodnaPostotak";
            this.lblSlobodnaPostotak.Size = new System.Drawing.Size(47, 23);
            this.lblSlobodnaPostotak.TabIndex = 19;
            this.lblSlobodnaPostotak.Text = "SB%";
            // 
            // lblSkokovi
            // 
            this.lblSkokovi.AutoSize = true;
            this.lblSkokovi.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSkokovi.Location = new System.Drawing.Point(234, 261);
            this.lblSkokovi.Name = "lblSkokovi";
            this.lblSkokovi.Size = new System.Drawing.Size(126, 34);
            this.lblSkokovi.TabIndex = 18;
            this.lblSkokovi.Text = "skokova";
            // 
            // lblAsistencije
            // 
            this.lblAsistencije.AutoSize = true;
            this.lblAsistencije.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsistencije.Location = new System.Drawing.Point(69, 261);
            this.lblAsistencije.Name = "lblAsistencije";
            this.lblAsistencije.Size = new System.Drawing.Size(159, 34);
            this.lblAsistencije.TabIndex = 17;
            this.lblAsistencije.Text = "asistencija";
            // 
            // lblPoeni
            // 
            this.lblPoeni.AutoSize = true;
            this.lblPoeni.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoeni.Location = new System.Drawing.Point(248, 162);
            this.lblPoeni.Name = "lblPoeni";
            this.lblPoeni.Size = new System.Drawing.Size(106, 34);
            this.lblPoeni.TabIndex = 16;
            this.lblPoeni.Text = "poena";
            // 
            // lblMinutaza
            // 
            this.lblMinutaza.AutoSize = true;
            this.lblMinutaza.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinutaza.Location = new System.Drawing.Point(110, 162);
            this.lblMinutaza.Name = "lblMinutaza";
            this.lblMinutaza.Size = new System.Drawing.Size(65, 34);
            this.lblMinutaza.TabIndex = 15;
            this.lblMinutaza.Text = "min";
            // 
            // lblImePrezime
            // 
            this.lblImePrezime.AutoSize = true;
            this.lblImePrezime.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImePrezime.Location = new System.Drawing.Point(96, 48);
            this.lblImePrezime.Name = "lblImePrezime";
            this.lblImePrezime.Size = new System.Drawing.Size(245, 37);
            this.lblImePrezime.TabIndex = 0;
            this.lblImePrezime.Text = "[ Ime i Prezime ]";
            // 
            // _19008_DBDataSetPrimary
            // 
            this._19008_DBDataSetPrimary.DataSetName = "_19008_DBDataSetPrimary";
            this._19008_DBDataSetPrimary.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // statistikaIgracaBindingSource
            // 
            this.statistikaIgracaBindingSource.DataMember = "StatistikaIgraca";
            this.statistikaIgracaBindingSource.DataSource = this._19008_DBDataSetPrimary;
            // 
            // statistikaIgracaTableAdapter
            // 
            this.statistikaIgracaTableAdapter.ClearBeforeFill = true;
            // 
            // igracBindingSource
            // 
            this.igracBindingSource.DataMember = "Igrac";
            this.igracBindingSource.DataSource = this._19008_DBDataSetPrimary;
            // 
            // igracTableAdapter
            // 
            this.igracTableAdapter.ClearBeforeFill = true;
            // 
            // idutakmiceDataGridViewTextBoxColumn
            // 
            this.idutakmiceDataGridViewTextBoxColumn.DataPropertyName = "id_utakmice";
            this.idutakmiceDataGridViewTextBoxColumn.HeaderText = "id_utakmice";
            this.idutakmiceDataGridViewTextBoxColumn.Name = "idutakmiceDataGridViewTextBoxColumn";
            this.idutakmiceDataGridViewTextBoxColumn.Visible = false;
            // 
            // minutazaDataGridViewTextBoxColumn
            // 
            this.minutazaDataGridViewTextBoxColumn.DataPropertyName = "minutaza";
            this.minutazaDataGridViewTextBoxColumn.HeaderText = "Minute";
            this.minutazaDataGridViewTextBoxColumn.Name = "minutazaDataGridViewTextBoxColumn";
            // 
            // idigracaDataGridViewTextBoxColumn
            // 
            this.idigracaDataGridViewTextBoxColumn.DataPropertyName = "id_igraca";
            this.idigracaDataGridViewTextBoxColumn.DataSource = this.igracBindingSource;
            this.idigracaDataGridViewTextBoxColumn.DisplayMember = "prezime";
            this.idigracaDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.idigracaDataGridViewTextBoxColumn.HeaderText = "Igrač";
            this.idigracaDataGridViewTextBoxColumn.Name = "idigracaDataGridViewTextBoxColumn";
            this.idigracaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idigracaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idigracaDataGridViewTextBoxColumn.ValueMember = "id_igrac";
            // 
            // sbzabijeniDataGridViewTextBoxColumn
            // 
            this.sbzabijeniDataGridViewTextBoxColumn.DataPropertyName = "sb_zabijeni";
            this.sbzabijeniDataGridViewTextBoxColumn.HeaderText = "sb_zabijeni";
            this.sbzabijeniDataGridViewTextBoxColumn.Name = "sbzabijeniDataGridViewTextBoxColumn";
            this.sbzabijeniDataGridViewTextBoxColumn.Visible = false;
            // 
            // sbpokusajiDataGridViewTextBoxColumn
            // 
            this.sbpokusajiDataGridViewTextBoxColumn.DataPropertyName = "sb_pokusaji";
            this.sbpokusajiDataGridViewTextBoxColumn.HeaderText = "sb_pokusaji";
            this.sbpokusajiDataGridViewTextBoxColumn.Name = "sbpokusajiDataGridViewTextBoxColumn";
            this.sbpokusajiDataGridViewTextBoxColumn.Visible = false;
            // 
            // p2zabijeniDataGridViewTextBoxColumn
            // 
            this.p2zabijeniDataGridViewTextBoxColumn.DataPropertyName = "p2_zabijeni";
            this.p2zabijeniDataGridViewTextBoxColumn.HeaderText = "p2_zabijeni";
            this.p2zabijeniDataGridViewTextBoxColumn.Name = "p2zabijeniDataGridViewTextBoxColumn";
            this.p2zabijeniDataGridViewTextBoxColumn.Visible = false;
            // 
            // p2pokusajiDataGridViewTextBoxColumn
            // 
            this.p2pokusajiDataGridViewTextBoxColumn.DataPropertyName = "p2_pokusaji";
            this.p2pokusajiDataGridViewTextBoxColumn.HeaderText = "p2_pokusaji";
            this.p2pokusajiDataGridViewTextBoxColumn.Name = "p2pokusajiDataGridViewTextBoxColumn";
            this.p2pokusajiDataGridViewTextBoxColumn.Visible = false;
            // 
            // p3zabijeniDataGridViewTextBoxColumn
            // 
            this.p3zabijeniDataGridViewTextBoxColumn.DataPropertyName = "p3_zabijeni";
            this.p3zabijeniDataGridViewTextBoxColumn.HeaderText = "p3_zabijeni";
            this.p3zabijeniDataGridViewTextBoxColumn.Name = "p3zabijeniDataGridViewTextBoxColumn";
            this.p3zabijeniDataGridViewTextBoxColumn.Visible = false;
            // 
            // p3pokusajiDataGridViewTextBoxColumn
            // 
            this.p3pokusajiDataGridViewTextBoxColumn.DataPropertyName = "p3_pokusaji";
            this.p3pokusajiDataGridViewTextBoxColumn.HeaderText = "p3_pokusaji";
            this.p3pokusajiDataGridViewTextBoxColumn.Name = "p3pokusajiDataGridViewTextBoxColumn";
            this.p3pokusajiDataGridViewTextBoxColumn.Visible = false;
            // 
            // asistencijeDataGridViewTextBoxColumn
            // 
            this.asistencijeDataGridViewTextBoxColumn.DataPropertyName = "asistencije";
            this.asistencijeDataGridViewTextBoxColumn.HeaderText = "asistencije";
            this.asistencijeDataGridViewTextBoxColumn.Name = "asistencijeDataGridViewTextBoxColumn";
            this.asistencijeDataGridViewTextBoxColumn.Visible = false;
            // 
            // skokoviDataGridViewTextBoxColumn
            // 
            this.skokoviDataGridViewTextBoxColumn.DataPropertyName = "skokovi";
            this.skokoviDataGridViewTextBoxColumn.HeaderText = "skokovi";
            this.skokoviDataGridViewTextBoxColumn.Name = "skokoviDataGridViewTextBoxColumn";
            this.skokoviDataGridViewTextBoxColumn.Visible = false;
            // 
            // prekrsajiDataGridViewTextBoxColumn
            // 
            this.prekrsajiDataGridViewTextBoxColumn.DataPropertyName = "prekrsaji";
            this.prekrsajiDataGridViewTextBoxColumn.HeaderText = "prekrsaji";
            this.prekrsajiDataGridViewTextBoxColumn.Name = "prekrsajiDataGridViewTextBoxColumn";
            this.prekrsajiDataGridViewTextBoxColumn.Visible = false;
            // 
            // FrmStatistikaOdabraneUtakmice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 523);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnIzmjeni);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.lblPopisIgraca);
            this.Controls.Add(this.dgvIgraciNaUtakmici);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmStatistikaOdabraneUtakmice";
            this.Text = "Utakmica protiv [] [] []";
            this.Load += new System.EventHandler(this.FrmStatistikaOdabraneUtakmice_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIgraciNaUtakmici)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._19008_DBDataSetPrimary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statistikaIgracaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.igracBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNasKlub;
        private System.Windows.Forms.Label lblProtivnik;
        private System.Windows.Forms.Label lblDvotocka;
        private System.Windows.Forms.Label lblZabijeniPoeni;
        private System.Windows.Forms.Label lblPrimljeniPoeni;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label lblVrijeme;
        private System.Windows.Forms.Label lblTipUtakmice;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvIgraciNaUtakmici;
        private System.Windows.Forms.Label lblPopisIgraca;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnIzmjeni;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt3pPostotak;
        private System.Windows.Forms.TextBox txt2pPostotak;
        private System.Windows.Forms.TextBox txtSBPostotak;
        private System.Windows.Forms.TextBox txtSkokovi;
        private System.Windows.Forms.TextBox txtAsistencije;
        private System.Windows.Forms.TextBox txtPoeni;
        private System.Windows.Forms.TextBox txtMinute;
        private System.Windows.Forms.Label lbl3pPostotak;
        private System.Windows.Forms.Label lbl2pPostotak;
        private System.Windows.Forms.Label lblSlobodnaPostotak;
        private System.Windows.Forms.Label lblSkokovi;
        private System.Windows.Forms.Label lblAsistencije;
        private System.Windows.Forms.Label lblPoeni;
        private System.Windows.Forms.Label lblMinutaza;
        private System.Windows.Forms.Label lblImePrezime;
        private _19008_DBDataSetPrimary _19008_DBDataSetPrimary;
        private System.Windows.Forms.BindingSource statistikaIgracaBindingSource;
        private _19008_DBDataSetPrimaryTableAdapters.StatistikaIgracaTableAdapter statistikaIgracaTableAdapter;
        private System.Windows.Forms.BindingSource igracBindingSource;
        private _19008_DBDataSetPrimaryTableAdapters.IgracTableAdapter igracTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idutakmiceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minutazaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idigracaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sbzabijeniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sbpokusajiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn p2zabijeniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn p2pokusajiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn p3zabijeniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn p3pokusajiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn asistencijeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn skokoviDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prekrsajiDataGridViewTextBoxColumn;
    }
}