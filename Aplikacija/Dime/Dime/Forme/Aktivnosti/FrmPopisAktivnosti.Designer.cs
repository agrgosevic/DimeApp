namespace Dime.Forme
{
    partial class FrmPopisAktivnosti
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPopisAktivnosti));
            this.dgvOdrzaniTreninzi = new System.Windows.Forms.DataGridView();
            this.idtreningDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrijemeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.napomenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiptreningaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tipTreningaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._19008_DBDataSetPrimary = new Dime._19008_DBDataSetPrimary();
            this.korisnikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.treningBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblPopisTreninga = new System.Windows.Forms.Label();
            this.lblPopisClanarina = new System.Windows.Forms.Label();
            this.dgvPopisClanarina = new System.Windows.Forms.DataGridView();
            this.idclanarinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mjesecDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.godinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rokuplateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clanarinaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._19008_DBDataSetUpdated = new Dime._19008_DBDataSetUpdated();
            this.btnOdaberiTrening = new System.Windows.Forms.Button();
            this.btnOdaberiClanarinu = new System.Windows.Forms.Button();
            this.btnKreiraj = new System.Windows.Forms.Button();
            this.btnIzmjeni = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.treningTableAdapter = new Dime._19008_DBDataSetPrimaryTableAdapters.TreningTableAdapter();
            this.tipTreningaTableAdapter = new Dime._19008_DBDataSetPrimaryTableAdapters.TipTreningaTableAdapter();
            this.clanarinaTableAdapter = new Dime._19008_DBDataSetPrimaryTableAdapters.ClanarinaTableAdapter();
            this.clanarinaTableAdapter1 = new Dime._19008_DBDataSetUpdatedTableAdapters.ClanarinaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdrzaniTreninzi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipTreningaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._19008_DBDataSetPrimary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treningBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisClanarina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clanarinaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._19008_DBDataSetUpdated)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOdrzaniTreninzi
            // 
            this.dgvOdrzaniTreninzi.AllowUserToAddRows = false;
            this.dgvOdrzaniTreninzi.AllowUserToDeleteRows = false;
            this.dgvOdrzaniTreninzi.AllowUserToResizeColumns = false;
            this.dgvOdrzaniTreninzi.AllowUserToResizeRows = false;
            this.dgvOdrzaniTreninzi.AutoGenerateColumns = false;
            this.dgvOdrzaniTreninzi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOdrzaniTreninzi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOdrzaniTreninzi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idtreningDataGridViewTextBoxColumn,
            this.datumDataGridViewTextBoxColumn,
            this.vrijemeDataGridViewTextBoxColumn,
            this.napomenaDataGridViewTextBoxColumn,
            this.tiptreningaDataGridViewTextBoxColumn,
            this.korisnikDataGridViewTextBoxColumn});
            this.dgvOdrzaniTreninzi.DataSource = this.treningBindingSource;
            this.dgvOdrzaniTreninzi.Location = new System.Drawing.Point(12, 41);
            this.dgvOdrzaniTreninzi.Name = "dgvOdrzaniTreninzi";
            this.dgvOdrzaniTreninzi.ReadOnly = true;
            this.dgvOdrzaniTreninzi.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvOdrzaniTreninzi.RowTemplate.Height = 24;
            this.dgvOdrzaniTreninzi.Size = new System.Drawing.Size(496, 463);
            this.dgvOdrzaniTreninzi.TabIndex = 0;
            // 
            // idtreningDataGridViewTextBoxColumn
            // 
            this.idtreningDataGridViewTextBoxColumn.DataPropertyName = "id_trening";
            this.idtreningDataGridViewTextBoxColumn.HeaderText = "id_trening";
            this.idtreningDataGridViewTextBoxColumn.Name = "idtreningDataGridViewTextBoxColumn";
            this.idtreningDataGridViewTextBoxColumn.ReadOnly = true;
            this.idtreningDataGridViewTextBoxColumn.Visible = false;
            // 
            // datumDataGridViewTextBoxColumn
            // 
            this.datumDataGridViewTextBoxColumn.DataPropertyName = "datum";
            this.datumDataGridViewTextBoxColumn.HeaderText = "Datum";
            this.datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
            this.datumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vrijemeDataGridViewTextBoxColumn
            // 
            this.vrijemeDataGridViewTextBoxColumn.DataPropertyName = "vrijeme";
            this.vrijemeDataGridViewTextBoxColumn.HeaderText = "Vrijeme";
            this.vrijemeDataGridViewTextBoxColumn.Name = "vrijemeDataGridViewTextBoxColumn";
            this.vrijemeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // napomenaDataGridViewTextBoxColumn
            // 
            this.napomenaDataGridViewTextBoxColumn.DataPropertyName = "napomena";
            this.napomenaDataGridViewTextBoxColumn.HeaderText = "napomena";
            this.napomenaDataGridViewTextBoxColumn.Name = "napomenaDataGridViewTextBoxColumn";
            this.napomenaDataGridViewTextBoxColumn.ReadOnly = true;
            this.napomenaDataGridViewTextBoxColumn.Visible = false;
            // 
            // tiptreningaDataGridViewTextBoxColumn
            // 
            this.tiptreningaDataGridViewTextBoxColumn.DataPropertyName = "tip_treninga";
            this.tiptreningaDataGridViewTextBoxColumn.DataSource = this.tipTreningaBindingSource;
            this.tiptreningaDataGridViewTextBoxColumn.DisplayMember = "naziv_tipa";
            this.tiptreningaDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.tiptreningaDataGridViewTextBoxColumn.HeaderText = "Tip treninga";
            this.tiptreningaDataGridViewTextBoxColumn.Name = "tiptreningaDataGridViewTextBoxColumn";
            this.tiptreningaDataGridViewTextBoxColumn.ReadOnly = true;
            this.tiptreningaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tiptreningaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.tiptreningaDataGridViewTextBoxColumn.ValueMember = "id_tipa_treninga";
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
            // korisnikDataGridViewTextBoxColumn
            // 
            this.korisnikDataGridViewTextBoxColumn.DataPropertyName = "korisnik";
            this.korisnikDataGridViewTextBoxColumn.HeaderText = "korisnik";
            this.korisnikDataGridViewTextBoxColumn.Name = "korisnikDataGridViewTextBoxColumn";
            this.korisnikDataGridViewTextBoxColumn.ReadOnly = true;
            this.korisnikDataGridViewTextBoxColumn.Visible = false;
            // 
            // treningBindingSource
            // 
            this.treningBindingSource.DataMember = "Trening";
            this.treningBindingSource.DataSource = this._19008_DBDataSetPrimary;
            // 
            // lblPopisTreninga
            // 
            this.lblPopisTreninga.AutoSize = true;
            this.lblPopisTreninga.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPopisTreninga.Location = new System.Drawing.Point(8, 9);
            this.lblPopisTreninga.Name = "lblPopisTreninga";
            this.lblPopisTreninga.Size = new System.Drawing.Size(235, 23);
            this.lblPopisTreninga.TabIndex = 1;
            this.lblPopisTreninga.Text = "Popis održanih treninga";
            // 
            // lblPopisClanarina
            // 
            this.lblPopisClanarina.AutoSize = true;
            this.lblPopisClanarina.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPopisClanarina.Location = new System.Drawing.Point(878, 9);
            this.lblPopisClanarina.Name = "lblPopisClanarina";
            this.lblPopisClanarina.Size = new System.Drawing.Size(159, 23);
            this.lblPopisClanarina.TabIndex = 2;
            this.lblPopisClanarina.Text = "Popis članarina";
            // 
            // dgvPopisClanarina
            // 
            this.dgvPopisClanarina.AllowUserToAddRows = false;
            this.dgvPopisClanarina.AllowUserToDeleteRows = false;
            this.dgvPopisClanarina.AllowUserToResizeColumns = false;
            this.dgvPopisClanarina.AllowUserToResizeRows = false;
            this.dgvPopisClanarina.AutoGenerateColumns = false;
            this.dgvPopisClanarina.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPopisClanarina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPopisClanarina.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idclanarinaDataGridViewTextBoxColumn,
            this.mjesecDataGridViewTextBoxColumn,
            this.godinaDataGridViewTextBoxColumn,
            this.rokuplateDataGridViewTextBoxColumn});
            this.dgvPopisClanarina.DataSource = this.clanarinaBindingSource;
            this.dgvPopisClanarina.Location = new System.Drawing.Point(538, 41);
            this.dgvPopisClanarina.Name = "dgvPopisClanarina";
            this.dgvPopisClanarina.ReadOnly = true;
            this.dgvPopisClanarina.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.MediumSlateBlue;
            this.dgvPopisClanarina.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPopisClanarina.RowTemplate.Height = 24;
            this.dgvPopisClanarina.Size = new System.Drawing.Size(496, 463);
            this.dgvPopisClanarina.TabIndex = 3;
            // 
            // idclanarinaDataGridViewTextBoxColumn
            // 
            this.idclanarinaDataGridViewTextBoxColumn.DataPropertyName = "id_clanarina";
            this.idclanarinaDataGridViewTextBoxColumn.HeaderText = "id_clanarina";
            this.idclanarinaDataGridViewTextBoxColumn.Name = "idclanarinaDataGridViewTextBoxColumn";
            this.idclanarinaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idclanarinaDataGridViewTextBoxColumn.Visible = false;
            // 
            // mjesecDataGridViewTextBoxColumn
            // 
            this.mjesecDataGridViewTextBoxColumn.DataPropertyName = "mjesec";
            this.mjesecDataGridViewTextBoxColumn.HeaderText = "Mjesec";
            this.mjesecDataGridViewTextBoxColumn.Name = "mjesecDataGridViewTextBoxColumn";
            this.mjesecDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // godinaDataGridViewTextBoxColumn
            // 
            this.godinaDataGridViewTextBoxColumn.DataPropertyName = "godina";
            this.godinaDataGridViewTextBoxColumn.HeaderText = "Godina";
            this.godinaDataGridViewTextBoxColumn.Name = "godinaDataGridViewTextBoxColumn";
            this.godinaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rokuplateDataGridViewTextBoxColumn
            // 
            this.rokuplateDataGridViewTextBoxColumn.DataPropertyName = "rok_uplate";
            this.rokuplateDataGridViewTextBoxColumn.HeaderText = "Rok uplate";
            this.rokuplateDataGridViewTextBoxColumn.Name = "rokuplateDataGridViewTextBoxColumn";
            this.rokuplateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clanarinaBindingSource
            // 
            this.clanarinaBindingSource.DataMember = "Clanarina";
            this.clanarinaBindingSource.DataSource = this._19008_DBDataSetUpdated;
            // 
            // _19008_DBDataSetUpdated
            // 
            this._19008_DBDataSetUpdated.DataSetName = "_19008_DBDataSetUpdated";
            this._19008_DBDataSetUpdated.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnOdaberiTrening
            // 
            this.btnOdaberiTrening.Location = new System.Drawing.Point(12, 518);
            this.btnOdaberiTrening.Name = "btnOdaberiTrening";
            this.btnOdaberiTrening.Size = new System.Drawing.Size(82, 38);
            this.btnOdaberiTrening.TabIndex = 4;
            this.btnOdaberiTrening.Text = "Odaberi";
            this.btnOdaberiTrening.UseVisualStyleBackColor = true;
            // 
            // btnOdaberiClanarinu
            // 
            this.btnOdaberiClanarinu.Location = new System.Drawing.Point(952, 518);
            this.btnOdaberiClanarinu.Name = "btnOdaberiClanarinu";
            this.btnOdaberiClanarinu.Size = new System.Drawing.Size(82, 38);
            this.btnOdaberiClanarinu.TabIndex = 5;
            this.btnOdaberiClanarinu.Text = "Odaberi";
            this.btnOdaberiClanarinu.UseVisualStyleBackColor = true;
            this.btnOdaberiClanarinu.Click += new System.EventHandler(this.btnOdaberiClanarinu_Click);
            // 
            // btnKreiraj
            // 
            this.btnKreiraj.Location = new System.Drawing.Point(538, 518);
            this.btnKreiraj.Name = "btnKreiraj";
            this.btnKreiraj.Size = new System.Drawing.Size(124, 38);
            this.btnKreiraj.TabIndex = 6;
            this.btnKreiraj.Text = "Kreiraj članarinu";
            this.btnKreiraj.UseVisualStyleBackColor = true;
            // 
            // btnIzmjeni
            // 
            this.btnIzmjeni.Location = new System.Drawing.Point(668, 518);
            this.btnIzmjeni.Name = "btnIzmjeni";
            this.btnIzmjeni.Size = new System.Drawing.Size(124, 38);
            this.btnIzmjeni.TabIndex = 7;
            this.btnIzmjeni.Text = "Izmjeni članarinu";
            this.btnIzmjeni.UseVisualStyleBackColor = true;
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(798, 518);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(124, 38);
            this.btnObrisi.TabIndex = 8;
            this.btnObrisi.Text = "Obriši članarinu";
            this.btnObrisi.UseVisualStyleBackColor = true;
            // 
            // treningTableAdapter
            // 
            this.treningTableAdapter.ClearBeforeFill = true;
            // 
            // tipTreningaTableAdapter
            // 
            this.tipTreningaTableAdapter.ClearBeforeFill = true;
            // 
            // clanarinaTableAdapter
            // 
            this.clanarinaTableAdapter.ClearBeforeFill = true;
            // 
            // clanarinaTableAdapter1
            // 
            this.clanarinaTableAdapter1.ClearBeforeFill = true;
            // 
            // FrmPopisAktivnosti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 568);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnIzmjeni);
            this.Controls.Add(this.btnKreiraj);
            this.Controls.Add(this.btnOdaberiClanarinu);
            this.Controls.Add(this.btnOdaberiTrening);
            this.Controls.Add(this.dgvPopisClanarina);
            this.Controls.Add(this.lblPopisClanarina);
            this.Controls.Add(this.lblPopisTreninga);
            this.Controls.Add(this.dgvOdrzaniTreninzi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPopisAktivnosti";
            this.Text = "Popis aktivnosti";
            this.Load += new System.EventHandler(this.FrmPopisAktivnosti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdrzaniTreninzi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipTreningaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._19008_DBDataSetPrimary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treningBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisClanarina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clanarinaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._19008_DBDataSetUpdated)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOdrzaniTreninzi;
        private System.Windows.Forms.Label lblPopisTreninga;
        private System.Windows.Forms.Label lblPopisClanarina;
        private System.Windows.Forms.DataGridView dgvPopisClanarina;
        private System.Windows.Forms.Button btnOdaberiTrening;
        private System.Windows.Forms.Button btnOdaberiClanarinu;
        private System.Windows.Forms.Button btnKreiraj;
        private System.Windows.Forms.Button btnIzmjeni;
        private System.Windows.Forms.Button btnObrisi;
        private _19008_DBDataSetPrimary _19008_DBDataSetPrimary;
        private System.Windows.Forms.BindingSource treningBindingSource;
        private _19008_DBDataSetPrimaryTableAdapters.TreningTableAdapter treningTableAdapter;
        private System.Windows.Forms.BindingSource tipTreningaBindingSource;
        private _19008_DBDataSetPrimaryTableAdapters.TipTreningaTableAdapter tipTreningaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtreningDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrijemeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn napomenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn tiptreningaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisnikDataGridViewTextBoxColumn;
        private _19008_DBDataSetPrimaryTableAdapters.ClanarinaTableAdapter clanarinaTableAdapter;
        private _19008_DBDataSetUpdated _19008_DBDataSetUpdated;
        private System.Windows.Forms.BindingSource clanarinaBindingSource;
        private _19008_DBDataSetUpdatedTableAdapters.ClanarinaTableAdapter clanarinaTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idclanarinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mjesecDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn godinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rokuplateDataGridViewTextBoxColumn;
    }
}