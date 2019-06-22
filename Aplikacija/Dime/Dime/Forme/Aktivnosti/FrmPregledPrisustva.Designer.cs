namespace Dime.Forme.Aktivnosti
{
    partial class FrmPregledPrisustva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPregledPrisustva));
            this.dgvPrisustvo = new System.Windows.Forms.DataGridView();
            this.idtreningaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idigracaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.igracBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._19008_DBDataSetUpdated = new Dime._19008_DBDataSetUpdated();
            this.prisustvoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.treningPrisustvoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblPopisTreninga = new System.Windows.Forms.Label();
            this.treningPrisustvoTableAdapter = new Dime._19008_DBDataSetUpdatedTableAdapters.TreningPrisustvoTableAdapter();
            this.igracTableAdapter = new Dime._19008_DBDataSetUpdatedTableAdapters.IgracTableAdapter();
            this.gbPrisustvo = new System.Windows.Forms.GroupBox();
            this.rbOdsutan = new System.Windows.Forms.RadioButton();
            this.rbPrisutan = new System.Windows.Forms.RadioButton();
            this.cmbIgraci = new System.Windows.Forms.ComboBox();
            this.btnObrisiIgraca = new System.Windows.Forms.Button();
            this.btnDodajIgraca = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnPomoc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrisustvo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.igracBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._19008_DBDataSetUpdated)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treningPrisustvoBindingSource)).BeginInit();
            this.gbPrisustvo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPrisustvo
            // 
            this.dgvPrisustvo.AllowUserToAddRows = false;
            this.dgvPrisustvo.AllowUserToDeleteRows = false;
            this.dgvPrisustvo.AllowUserToResizeColumns = false;
            this.dgvPrisustvo.AllowUserToResizeRows = false;
            this.dgvPrisustvo.AutoGenerateColumns = false;
            this.dgvPrisustvo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrisustvo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrisustvo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idtreningaDataGridViewTextBoxColumn,
            this.idigracaDataGridViewTextBoxColumn,
            this.prisustvoDataGridViewTextBoxColumn});
            this.dgvPrisustvo.DataSource = this.treningPrisustvoBindingSource;
            this.dgvPrisustvo.Location = new System.Drawing.Point(12, 45);
            this.dgvPrisustvo.Name = "dgvPrisustvo";
            this.dgvPrisustvo.ReadOnly = true;
            this.dgvPrisustvo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPrisustvo.RowTemplate.Height = 24;
            this.dgvPrisustvo.Size = new System.Drawing.Size(567, 537);
            this.dgvPrisustvo.TabIndex = 0;
            this.dgvPrisustvo.SelectionChanged += new System.EventHandler(this.dgvPrisustvo_SelectionChanged);
            // 
            // idtreningaDataGridViewTextBoxColumn
            // 
            this.idtreningaDataGridViewTextBoxColumn.DataPropertyName = "id_treninga";
            this.idtreningaDataGridViewTextBoxColumn.HeaderText = "id_treninga";
            this.idtreningaDataGridViewTextBoxColumn.Name = "idtreningaDataGridViewTextBoxColumn";
            this.idtreningaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idtreningaDataGridViewTextBoxColumn.Visible = false;
            // 
            // idigracaDataGridViewTextBoxColumn
            // 
            this.idigracaDataGridViewTextBoxColumn.DataPropertyName = "id_igraca";
            this.idigracaDataGridViewTextBoxColumn.DataSource = this.igracBindingSource;
            this.idigracaDataGridViewTextBoxColumn.DisplayMember = "prezime";
            this.idigracaDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.idigracaDataGridViewTextBoxColumn.HeaderText = "Igrač";
            this.idigracaDataGridViewTextBoxColumn.Name = "idigracaDataGridViewTextBoxColumn";
            this.idigracaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idigracaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idigracaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idigracaDataGridViewTextBoxColumn.ValueMember = "id_igrac";
            // 
            // igracBindingSource
            // 
            this.igracBindingSource.DataMember = "Igrac";
            this.igracBindingSource.DataSource = this._19008_DBDataSetUpdated;
            // 
            // _19008_DBDataSetUpdated
            // 
            this._19008_DBDataSetUpdated.DataSetName = "_19008_DBDataSetUpdated";
            this._19008_DBDataSetUpdated.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prisustvoDataGridViewTextBoxColumn
            // 
            this.prisustvoDataGridViewTextBoxColumn.DataPropertyName = "prisustvo";
            this.prisustvoDataGridViewTextBoxColumn.HeaderText = "Prisutan?";
            this.prisustvoDataGridViewTextBoxColumn.Name = "prisustvoDataGridViewTextBoxColumn";
            this.prisustvoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // treningPrisustvoBindingSource
            // 
            this.treningPrisustvoBindingSource.DataMember = "TreningPrisustvo";
            this.treningPrisustvoBindingSource.DataSource = this._19008_DBDataSetUpdated;
            // 
            // lblPopisTreninga
            // 
            this.lblPopisTreninga.AutoSize = true;
            this.lblPopisTreninga.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPopisTreninga.Location = new System.Drawing.Point(9, 9);
            this.lblPopisTreninga.Name = "lblPopisTreninga";
            this.lblPopisTreninga.Size = new System.Drawing.Size(316, 23);
            this.lblPopisTreninga.TabIndex = 3;
            this.lblPopisTreninga.Text = "Evidencija prisustva na treningu";
            // 
            // treningPrisustvoTableAdapter
            // 
            this.treningPrisustvoTableAdapter.ClearBeforeFill = true;
            // 
            // igracTableAdapter
            // 
            this.igracTableAdapter.ClearBeforeFill = true;
            // 
            // gbPrisustvo
            // 
            this.gbPrisustvo.Controls.Add(this.rbOdsutan);
            this.gbPrisustvo.Controls.Add(this.rbPrisutan);
            this.gbPrisustvo.Location = new System.Drawing.Point(585, 45);
            this.gbPrisustvo.Name = "gbPrisustvo";
            this.gbPrisustvo.Size = new System.Drawing.Size(200, 155);
            this.gbPrisustvo.TabIndex = 4;
            this.gbPrisustvo.TabStop = false;
            this.gbPrisustvo.Text = "Prisustvo igrača";
            // 
            // rbOdsutan
            // 
            this.rbOdsutan.AutoSize = true;
            this.rbOdsutan.Location = new System.Drawing.Point(7, 97);
            this.rbOdsutan.Name = "rbOdsutan";
            this.rbOdsutan.Size = new System.Drawing.Size(83, 21);
            this.rbOdsutan.TabIndex = 1;
            this.rbOdsutan.TabStop = true;
            this.rbOdsutan.Text = "Odsutan";
            this.rbOdsutan.UseVisualStyleBackColor = true;
            // 
            // rbPrisutan
            // 
            this.rbPrisutan.AutoSize = true;
            this.rbPrisutan.Location = new System.Drawing.Point(7, 46);
            this.rbPrisutan.Name = "rbPrisutan";
            this.rbPrisutan.Size = new System.Drawing.Size(81, 21);
            this.rbPrisutan.TabIndex = 0;
            this.rbPrisutan.TabStop = true;
            this.rbPrisutan.Text = "Prisutan";
            this.rbPrisutan.UseVisualStyleBackColor = true;
            // 
            // cmbIgraci
            // 
            this.cmbIgraci.DataSource = this.igracBindingSource;
            this.cmbIgraci.DisplayMember = "prezime";
            this.cmbIgraci.FormattingEnabled = true;
            this.cmbIgraci.Location = new System.Drawing.Point(585, 302);
            this.cmbIgraci.Name = "cmbIgraci";
            this.cmbIgraci.Size = new System.Drawing.Size(199, 24);
            this.cmbIgraci.TabIndex = 11;
            this.cmbIgraci.ValueMember = "id_igrac";
            // 
            // btnObrisiIgraca
            // 
            this.btnObrisiIgraca.Location = new System.Drawing.Point(585, 539);
            this.btnObrisiIgraca.Name = "btnObrisiIgraca";
            this.btnObrisiIgraca.Size = new System.Drawing.Size(200, 42);
            this.btnObrisiIgraca.TabIndex = 10;
            this.btnObrisiIgraca.Text = "Obriši igrača s popisa";
            this.btnObrisiIgraca.UseVisualStyleBackColor = true;
            this.btnObrisiIgraca.Click += new System.EventHandler(this.btnObrisiIgraca_Click);
            // 
            // btnDodajIgraca
            // 
            this.btnDodajIgraca.Location = new System.Drawing.Point(585, 254);
            this.btnDodajIgraca.Name = "btnDodajIgraca";
            this.btnDodajIgraca.Size = new System.Drawing.Size(200, 42);
            this.btnDodajIgraca.TabIndex = 9;
            this.btnDodajIgraca.Text = "Dodaj igrača na popis";
            this.btnDodajIgraca.UseVisualStyleBackColor = true;
            this.btnDodajIgraca.Click += new System.EventHandler(this.btnDodajIgraca_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(585, 206);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(200, 42);
            this.btnSpremi.TabIndex = 8;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // btnPomoc
            // 
            this.btnPomoc.Location = new System.Drawing.Point(743, 9);
            this.btnPomoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPomoc.Name = "btnPomoc";
            this.btnPomoc.Size = new System.Drawing.Size(42, 42);
            this.btnPomoc.TabIndex = 12;
            this.btnPomoc.Text = "? (F1)";
            this.btnPomoc.UseVisualStyleBackColor = true;
            this.btnPomoc.Click += new System.EventHandler(this.btnPomoc_Click);
            // 
            // FrmPregledPrisustva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 593);
            this.Controls.Add(this.btnPomoc);
            this.Controls.Add(this.cmbIgraci);
            this.Controls.Add(this.btnObrisiIgraca);
            this.Controls.Add(this.btnDodajIgraca);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.gbPrisustvo);
            this.Controls.Add(this.lblPopisTreninga);
            this.Controls.Add(this.dgvPrisustvo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPregledPrisustva";
            this.Text = "Pregled prisustva igrača na treningu održan [] u []";
            this.Load += new System.EventHandler(this.FrmPregledPrisustva_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.FrmPregledPrisustva_HelpRequested);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrisustvo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.igracBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._19008_DBDataSetUpdated)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treningPrisustvoBindingSource)).EndInit();
            this.gbPrisustvo.ResumeLayout(false);
            this.gbPrisustvo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPrisustvo;
        private System.Windows.Forms.Label lblPopisTreninga;
        private _19008_DBDataSetUpdated _19008_DBDataSetUpdated;
        private System.Windows.Forms.BindingSource treningPrisustvoBindingSource;
        private _19008_DBDataSetUpdatedTableAdapters.TreningPrisustvoTableAdapter treningPrisustvoTableAdapter;
        private System.Windows.Forms.BindingSource igracBindingSource;
        private _19008_DBDataSetUpdatedTableAdapters.IgracTableAdapter igracTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtreningaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idigracaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prisustvoDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox gbPrisustvo;
        private System.Windows.Forms.RadioButton rbOdsutan;
        private System.Windows.Forms.RadioButton rbPrisutan;
        private System.Windows.Forms.ComboBox cmbIgraci;
        private System.Windows.Forms.Button btnObrisiIgraca;
        private System.Windows.Forms.Button btnDodajIgraca;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnPomoc;
    }
}