namespace Dime.Forme
{
    partial class FrmStatistikeUtakmica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStatistikeUtakmica));
            this.dgvOdigraneUtakmice = new System.Windows.Forms.DataGridView();
            this.idutakmicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrijemeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zabijenipoeniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.primljenipoeniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiputakmiceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tipUtakmiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBDataSetPrimaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._19008_DBDataSetPrimary = new Dime._19008_DBDataSetPrimary();
            this.protivnikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.klubBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.korisnikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.utakmicaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnOdaberi = new System.Windows.Forms.Button();
            this._19008_DBDataSet1 = new Dime._19008_DBDataSet();
            this.utakmicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.utakmicaTableAdapter = new Dime._19008_DBDataSetPrimaryTableAdapters.UtakmicaTableAdapter();
            this.klubTableAdapter = new Dime._19008_DBDataSetPrimaryTableAdapters.KlubTableAdapter();
            this.tipUtakmiceTableAdapter = new Dime._19008_DBDataSetPrimaryTableAdapters.TipUtakmiceTableAdapter();
            this.lblPopisUtakmica = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdigraneUtakmice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipUtakmiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSetPrimaryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._19008_DBDataSetPrimary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klubBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utakmicaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._19008_DBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utakmicaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOdigraneUtakmice
            // 
            this.dgvOdigraneUtakmice.AllowUserToAddRows = false;
            this.dgvOdigraneUtakmice.AllowUserToDeleteRows = false;
            this.dgvOdigraneUtakmice.AllowUserToResizeColumns = false;
            this.dgvOdigraneUtakmice.AllowUserToResizeRows = false;
            this.dgvOdigraneUtakmice.AutoGenerateColumns = false;
            this.dgvOdigraneUtakmice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOdigraneUtakmice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOdigraneUtakmice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idutakmicaDataGridViewTextBoxColumn,
            this.datumDataGridViewTextBoxColumn,
            this.vrijemeDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn,
            this.zabijenipoeniDataGridViewTextBoxColumn,
            this.primljenipoeniDataGridViewTextBoxColumn,
            this.tiputakmiceDataGridViewTextBoxColumn,
            this.protivnikDataGridViewTextBoxColumn,
            this.korisnikDataGridViewTextBoxColumn});
            this.dgvOdigraneUtakmice.DataSource = this.utakmicaBindingSource1;
            this.dgvOdigraneUtakmice.Location = new System.Drawing.Point(13, 41);
            this.dgvOdigraneUtakmice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvOdigraneUtakmice.Name = "dgvOdigraneUtakmice";
            this.dgvOdigraneUtakmice.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvOdigraneUtakmice.RowTemplate.Height = 24;
            this.dgvOdigraneUtakmice.Size = new System.Drawing.Size(935, 416);
            this.dgvOdigraneUtakmice.TabIndex = 0;
            // 
            // idutakmicaDataGridViewTextBoxColumn
            // 
            this.idutakmicaDataGridViewTextBoxColumn.DataPropertyName = "id_utakmica";
            this.idutakmicaDataGridViewTextBoxColumn.HeaderText = "id_utakmica";
            this.idutakmicaDataGridViewTextBoxColumn.Name = "idutakmicaDataGridViewTextBoxColumn";
            this.idutakmicaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idutakmicaDataGridViewTextBoxColumn.Visible = false;
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
            // opisDataGridViewTextBoxColumn
            // 
            this.opisDataGridViewTextBoxColumn.DataPropertyName = "opis";
            this.opisDataGridViewTextBoxColumn.HeaderText = "opis";
            this.opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
            this.opisDataGridViewTextBoxColumn.Visible = false;
            // 
            // zabijenipoeniDataGridViewTextBoxColumn
            // 
            this.zabijenipoeniDataGridViewTextBoxColumn.DataPropertyName = "zabijeni_poeni";
            this.zabijenipoeniDataGridViewTextBoxColumn.HeaderText = "Zabijeni poeni";
            this.zabijenipoeniDataGridViewTextBoxColumn.Name = "zabijenipoeniDataGridViewTextBoxColumn";
            this.zabijenipoeniDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // primljenipoeniDataGridViewTextBoxColumn
            // 
            this.primljenipoeniDataGridViewTextBoxColumn.DataPropertyName = "primljeni_poeni";
            this.primljenipoeniDataGridViewTextBoxColumn.HeaderText = "Primljeni poeni";
            this.primljenipoeniDataGridViewTextBoxColumn.Name = "primljenipoeniDataGridViewTextBoxColumn";
            this.primljenipoeniDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tiputakmiceDataGridViewTextBoxColumn
            // 
            this.tiputakmiceDataGridViewTextBoxColumn.DataPropertyName = "tip_utakmice";
            this.tiputakmiceDataGridViewTextBoxColumn.DataSource = this.tipUtakmiceBindingSource;
            this.tiputakmiceDataGridViewTextBoxColumn.DisplayMember = "naziv_tipa";
            this.tiputakmiceDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.tiputakmiceDataGridViewTextBoxColumn.HeaderText = "Tip utakmice";
            this.tiputakmiceDataGridViewTextBoxColumn.Name = "tiputakmiceDataGridViewTextBoxColumn";
            this.tiputakmiceDataGridViewTextBoxColumn.ReadOnly = true;
            this.tiputakmiceDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tiputakmiceDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.tiputakmiceDataGridViewTextBoxColumn.ValueMember = "id_tipa_utakmice";
            // 
            // tipUtakmiceBindingSource
            // 
            this.tipUtakmiceBindingSource.DataMember = "TipUtakmice";
            this.tipUtakmiceBindingSource.DataSource = this.dBDataSetPrimaryBindingSource;
            // 
            // dBDataSetPrimaryBindingSource
            // 
            this.dBDataSetPrimaryBindingSource.DataSource = this._19008_DBDataSetPrimary;
            this.dBDataSetPrimaryBindingSource.Position = 0;
            // 
            // _19008_DBDataSetPrimary
            // 
            this._19008_DBDataSetPrimary.DataSetName = "_19008_DBDataSetPrimary";
            this._19008_DBDataSetPrimary.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // protivnikDataGridViewTextBoxColumn
            // 
            this.protivnikDataGridViewTextBoxColumn.DataPropertyName = "protivnik";
            this.protivnikDataGridViewTextBoxColumn.DataSource = this.klubBindingSource;
            this.protivnikDataGridViewTextBoxColumn.DisplayMember = "naziv";
            this.protivnikDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.protivnikDataGridViewTextBoxColumn.HeaderText = "Protivnik";
            this.protivnikDataGridViewTextBoxColumn.Name = "protivnikDataGridViewTextBoxColumn";
            this.protivnikDataGridViewTextBoxColumn.ReadOnly = true;
            this.protivnikDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.protivnikDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.protivnikDataGridViewTextBoxColumn.ToolTipText = "Protivnicki klub protiv kojeg je odigrana utakmica";
            this.protivnikDataGridViewTextBoxColumn.ValueMember = "id_klub";
            // 
            // klubBindingSource
            // 
            this.klubBindingSource.DataMember = "Klub";
            this.klubBindingSource.DataSource = this.dBDataSetPrimaryBindingSource;
            // 
            // korisnikDataGridViewTextBoxColumn
            // 
            this.korisnikDataGridViewTextBoxColumn.DataPropertyName = "korisnik";
            this.korisnikDataGridViewTextBoxColumn.HeaderText = "korisnik";
            this.korisnikDataGridViewTextBoxColumn.Name = "korisnikDataGridViewTextBoxColumn";
            this.korisnikDataGridViewTextBoxColumn.Visible = false;
            // 
            // utakmicaBindingSource1
            // 
            this.utakmicaBindingSource1.DataMember = "Utakmica";
            this.utakmicaBindingSource1.DataSource = this._19008_DBDataSetPrimary;
            // 
            // btnOdaberi
            // 
            this.btnOdaberi.Location = new System.Drawing.Point(13, 470);
            this.btnOdaberi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOdaberi.Name = "btnOdaberi";
            this.btnOdaberi.Size = new System.Drawing.Size(159, 42);
            this.btnOdaberi.TabIndex = 1;
            this.btnOdaberi.Text = "Odaberi";
            this.btnOdaberi.UseVisualStyleBackColor = true;
            this.btnOdaberi.Click += new System.EventHandler(this.btnOdaberi_Click);
            // 
            // _19008_DBDataSet1
            // 
            this._19008_DBDataSet1.DataSetName = "_19008_DBDataSet";
            this._19008_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // utakmicaBindingSource
            // 
            this.utakmicaBindingSource.DataMember = "Utakmica";
            this.utakmicaBindingSource.DataSource = this.dBDataSetPrimaryBindingSource;
            // 
            // utakmicaTableAdapter
            // 
            this.utakmicaTableAdapter.ClearBeforeFill = true;
            // 
            // klubTableAdapter
            // 
            this.klubTableAdapter.ClearBeforeFill = true;
            // 
            // tipUtakmiceTableAdapter
            // 
            this.tipUtakmiceTableAdapter.ClearBeforeFill = true;
            // 
            // lblPopisUtakmica
            // 
            this.lblPopisUtakmica.AutoSize = true;
            this.lblPopisUtakmica.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPopisUtakmica.Location = new System.Drawing.Point(9, 9);
            this.lblPopisUtakmica.Name = "lblPopisUtakmica";
            this.lblPopisUtakmica.Size = new System.Drawing.Size(254, 23);
            this.lblPopisUtakmica.TabIndex = 2;
            this.lblPopisUtakmica.Text = "Popis odigranih utakmica";
            // 
            // FrmStatistikeUtakmica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 523);
            this.Controls.Add(this.lblPopisUtakmica);
            this.Controls.Add(this.btnOdaberi);
            this.Controls.Add(this.dgvOdigraneUtakmice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmStatistikeUtakmica";
            this.Text = "Odigrane utakmice";
            this.Load += new System.EventHandler(this.FrmStatistikeUtakmica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdigraneUtakmice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipUtakmiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSetPrimaryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._19008_DBDataSetPrimary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klubBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utakmicaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._19008_DBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utakmicaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOdigraneUtakmice;
        private System.Windows.Forms.Button btnOdaberi;
        private _19008_DBDataSet _19008_DBDataSet1;
        private System.Windows.Forms.BindingSource dBDataSetPrimaryBindingSource;
        private _19008_DBDataSetPrimary _19008_DBDataSetPrimary;
        private System.Windows.Forms.BindingSource utakmicaBindingSource;
        private _19008_DBDataSetPrimaryTableAdapters.UtakmicaTableAdapter utakmicaTableAdapter;
        private System.Windows.Forms.BindingSource klubBindingSource;
        private _19008_DBDataSetPrimaryTableAdapters.KlubTableAdapter klubTableAdapter;
        private System.Windows.Forms.BindingSource tipUtakmiceBindingSource;
        private _19008_DBDataSetPrimaryTableAdapters.TipUtakmiceTableAdapter tipUtakmiceTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idutakmicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrijemeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zabijenipoeniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn primljenipoeniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn tiputakmiceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn protivnikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisnikDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource utakmicaBindingSource1;
        private System.Windows.Forms.Label lblPopisUtakmica;
    }
}