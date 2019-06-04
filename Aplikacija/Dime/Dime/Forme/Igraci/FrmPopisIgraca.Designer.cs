namespace Dime.Forme
{
    partial class FrmPopisIgraca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPopisIgraca));
            this.btnUrediIgraca = new System.Windows.Forms.Button();
            this.btnObrisiIgraca = new System.Windows.Forms.Button();
            this.btnDodajIgraca = new System.Windows.Forms.Button();
            this.dgvPopisIgraca = new System.Windows.Forms.DataGridView();
            this.igracBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._19008_DBDataSetPrimary = new Dime._19008_DBDataSetPrimary();
            this.igracTableAdapter = new Dime._19008_DBDataSetPrimaryTableAdapters.IgracTableAdapter();
            this.idigracDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumrodenjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tezinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisIgraca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.igracBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._19008_DBDataSetPrimary)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUrediIgraca
            // 
            this.btnUrediIgraca.Location = new System.Drawing.Point(716, 79);
            this.btnUrediIgraca.Name = "btnUrediIgraca";
            this.btnUrediIgraca.Size = new System.Drawing.Size(75, 46);
            this.btnUrediIgraca.TabIndex = 8;
            this.btnUrediIgraca.Text = "Uredi igraca";
            this.btnUrediIgraca.UseVisualStyleBackColor = true;
            this.btnUrediIgraca.Click += new System.EventHandler(this.btnUrediIgraca_Click);
            // 
            // btnObrisiIgraca
            // 
            this.btnObrisiIgraca.Location = new System.Drawing.Point(716, 144);
            this.btnObrisiIgraca.Name = "btnObrisiIgraca";
            this.btnObrisiIgraca.Size = new System.Drawing.Size(75, 46);
            this.btnObrisiIgraca.TabIndex = 7;
            this.btnObrisiIgraca.Text = "Obriši igraca";
            this.btnObrisiIgraca.UseVisualStyleBackColor = true;
            this.btnObrisiIgraca.Click += new System.EventHandler(this.btnObrisiIgraca_Click);
            // 
            // btnDodajIgraca
            // 
            this.btnDodajIgraca.Location = new System.Drawing.Point(716, 12);
            this.btnDodajIgraca.Name = "btnDodajIgraca";
            this.btnDodajIgraca.Size = new System.Drawing.Size(75, 46);
            this.btnDodajIgraca.TabIndex = 6;
            this.btnDodajIgraca.Text = "Dodaj igraca";
            this.btnDodajIgraca.UseVisualStyleBackColor = true;
            this.btnDodajIgraca.Click += new System.EventHandler(this.btnDodajIgraca_Click);
            // 
            // dgvPopisIgraca
            // 
            this.dgvPopisIgraca.AutoGenerateColumns = false;
            this.dgvPopisIgraca.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPopisIgraca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPopisIgraca.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idigracDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.datumrodenjaDataGridViewTextBoxColumn,
            this.visinaDataGridViewTextBoxColumn,
            this.tezinaDataGridViewTextBoxColumn,
            this.brojDataGridViewTextBoxColumn});
            this.dgvPopisIgraca.DataSource = this.igracBindingSource;
            this.dgvPopisIgraca.Location = new System.Drawing.Point(9, 12);
            this.dgvPopisIgraca.Name = "dgvPopisIgraca";
            this.dgvPopisIgraca.Size = new System.Drawing.Size(701, 426);
            this.dgvPopisIgraca.TabIndex = 5;
            // 
            // igracBindingSource
            // 
            this.igracBindingSource.DataMember = "Igrac";
            this.igracBindingSource.DataSource = this._19008_DBDataSetPrimary;
            // 
            // _19008_DBDataSetPrimary
            // 
            this._19008_DBDataSetPrimary.DataSetName = "_19008_DBDataSetPrimary";
            this._19008_DBDataSetPrimary.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // igracTableAdapter
            // 
            this.igracTableAdapter.ClearBeforeFill = true;
            // 
            // idigracDataGridViewTextBoxColumn
            // 
            this.idigracDataGridViewTextBoxColumn.DataPropertyName = "id_igrac";
            this.idigracDataGridViewTextBoxColumn.HeaderText = "id_igrac";
            this.idigracDataGridViewTextBoxColumn.Name = "idigracDataGridViewTextBoxColumn";
            this.idigracDataGridViewTextBoxColumn.ReadOnly = true;
            this.idigracDataGridViewTextBoxColumn.Visible = false;
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "Ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "prezime";
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            // 
            // datumrodenjaDataGridViewTextBoxColumn
            // 
            this.datumrodenjaDataGridViewTextBoxColumn.DataPropertyName = "datum_rodenja";
            this.datumrodenjaDataGridViewTextBoxColumn.HeaderText = "Datum rođenja";
            this.datumrodenjaDataGridViewTextBoxColumn.Name = "datumrodenjaDataGridViewTextBoxColumn";
            // 
            // visinaDataGridViewTextBoxColumn
            // 
            this.visinaDataGridViewTextBoxColumn.DataPropertyName = "visina";
            this.visinaDataGridViewTextBoxColumn.HeaderText = "Visina (cm)";
            this.visinaDataGridViewTextBoxColumn.Name = "visinaDataGridViewTextBoxColumn";
            // 
            // tezinaDataGridViewTextBoxColumn
            // 
            this.tezinaDataGridViewTextBoxColumn.DataPropertyName = "tezina";
            this.tezinaDataGridViewTextBoxColumn.HeaderText = "Težina (kg)";
            this.tezinaDataGridViewTextBoxColumn.Name = "tezinaDataGridViewTextBoxColumn";
            // 
            // brojDataGridViewTextBoxColumn
            // 
            this.brojDataGridViewTextBoxColumn.DataPropertyName = "broj";
            this.brojDataGridViewTextBoxColumn.HeaderText = "Broj";
            this.brojDataGridViewTextBoxColumn.Name = "brojDataGridViewTextBoxColumn";
            // 
            // FrmPopisIgraca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUrediIgraca);
            this.Controls.Add(this.btnObrisiIgraca);
            this.Controls.Add(this.btnDodajIgraca);
            this.Controls.Add(this.dgvPopisIgraca);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPopisIgraca";
            this.Text = "Igrači";
            this.Load += new System.EventHandler(this.FrmPopisIgraca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisIgraca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.igracBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._19008_DBDataSetPrimary)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUrediIgraca;
        private System.Windows.Forms.Button btnObrisiIgraca;
        private System.Windows.Forms.Button btnDodajIgraca;
        private System.Windows.Forms.DataGridView dgvPopisIgraca;
        private _19008_DBDataSetPrimary _19008_DBDataSetPrimary;
        private System.Windows.Forms.BindingSource igracBindingSource;
        private _19008_DBDataSetPrimaryTableAdapters.IgracTableAdapter igracTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idigracDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumrodenjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn visinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tezinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojDataGridViewTextBoxColumn;
    }
}