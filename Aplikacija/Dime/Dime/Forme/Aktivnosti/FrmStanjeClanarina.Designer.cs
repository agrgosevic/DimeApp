namespace Dime.Forme.Aktivnosti
{
    partial class FrmStanjeClanarina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStanjeClanarina));
            this.dgvStanjeClanarina = new System.Windows.Forms.DataGridView();
            this.idclanarineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idigracaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.igracBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._19008_DBDataSetUpdated = new Dime._19008_DBDataSetUpdated();
            this.uplacenoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clanarinaIgracaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblPopisTreninga = new System.Windows.Forms.Label();
            this.clanarinaIgracaTableAdapter = new Dime._19008_DBDataSetUpdatedTableAdapters.ClanarinaIgracaTableAdapter();
            this.igracTableAdapter = new Dime._19008_DBDataSetUpdatedTableAdapters.IgracTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbPlaceno = new System.Windows.Forms.RadioButton();
            this.rbNijePlaceno = new System.Windows.Forms.RadioButton();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnDodajIgraca = new System.Windows.Forms.Button();
            this.btnObrisiIgraca = new System.Windows.Forms.Button();
            this.cmbIgraci = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStanjeClanarina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.igracBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._19008_DBDataSetUpdated)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clanarinaIgracaBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvStanjeClanarina
            // 
            this.dgvStanjeClanarina.AllowUserToAddRows = false;
            this.dgvStanjeClanarina.AllowUserToDeleteRows = false;
            this.dgvStanjeClanarina.AutoGenerateColumns = false;
            this.dgvStanjeClanarina.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStanjeClanarina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStanjeClanarina.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idclanarineDataGridViewTextBoxColumn,
            this.idigracaDataGridViewTextBoxColumn,
            this.uplacenoDataGridViewTextBoxColumn});
            this.dgvStanjeClanarina.DataSource = this.clanarinaIgracaBindingSource;
            this.dgvStanjeClanarina.Location = new System.Drawing.Point(12, 44);
            this.dgvStanjeClanarina.Name = "dgvStanjeClanarina";
            this.dgvStanjeClanarina.ReadOnly = true;
            this.dgvStanjeClanarina.RowTemplate.Height = 24;
            this.dgvStanjeClanarina.Size = new System.Drawing.Size(567, 537);
            this.dgvStanjeClanarina.TabIndex = 0;
            this.dgvStanjeClanarina.SelectionChanged += new System.EventHandler(this.dgvStanjeClanarina_SelectionChanged);
            // 
            // idclanarineDataGridViewTextBoxColumn
            // 
            this.idclanarineDataGridViewTextBoxColumn.DataPropertyName = "id_clanarine";
            this.idclanarineDataGridViewTextBoxColumn.HeaderText = "id_clanarine";
            this.idclanarineDataGridViewTextBoxColumn.Name = "idclanarineDataGridViewTextBoxColumn";
            this.idclanarineDataGridViewTextBoxColumn.ReadOnly = true;
            this.idclanarineDataGridViewTextBoxColumn.Visible = false;
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
            // uplacenoDataGridViewTextBoxColumn
            // 
            this.uplacenoDataGridViewTextBoxColumn.DataPropertyName = "uplaceno";
            this.uplacenoDataGridViewTextBoxColumn.HeaderText = "Plaćeno?";
            this.uplacenoDataGridViewTextBoxColumn.Name = "uplacenoDataGridViewTextBoxColumn";
            this.uplacenoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clanarinaIgracaBindingSource
            // 
            this.clanarinaIgracaBindingSource.DataMember = "ClanarinaIgraca";
            this.clanarinaIgracaBindingSource.DataSource = this._19008_DBDataSetUpdated;
            // 
            // lblPopisTreninga
            // 
            this.lblPopisTreninga.AutoSize = true;
            this.lblPopisTreninga.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPopisTreninga.Location = new System.Drawing.Point(8, 9);
            this.lblPopisTreninga.Name = "lblPopisTreninga";
            this.lblPopisTreninga.Size = new System.Drawing.Size(341, 23);
            this.lblPopisTreninga.TabIndex = 2;
            this.lblPopisTreninga.Text = "Evidencija stanja članarina igrača";
            // 
            // clanarinaIgracaTableAdapter
            // 
            this.clanarinaIgracaTableAdapter.ClearBeforeFill = true;
            // 
            // igracTableAdapter
            // 
            this.igracTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbNijePlaceno);
            this.groupBox1.Controls.Add(this.rbPlaceno);
            this.groupBox1.Location = new System.Drawing.Point(585, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 155);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stanje članarine";
            // 
            // rbPlaceno
            // 
            this.rbPlaceno.AutoSize = true;
            this.rbPlaceno.Location = new System.Drawing.Point(7, 46);
            this.rbPlaceno.Name = "rbPlaceno";
            this.rbPlaceno.Size = new System.Drawing.Size(80, 21);
            this.rbPlaceno.TabIndex = 0;
            this.rbPlaceno.TabStop = true;
            this.rbPlaceno.Text = "Plaćeno";
            this.rbPlaceno.UseVisualStyleBackColor = true;
            // 
            // rbNijePlaceno
            // 
            this.rbNijePlaceno.AutoSize = true;
            this.rbNijePlaceno.Location = new System.Drawing.Point(7, 97);
            this.rbNijePlaceno.Name = "rbNijePlaceno";
            this.rbNijePlaceno.Size = new System.Drawing.Size(107, 21);
            this.rbNijePlaceno.TabIndex = 1;
            this.rbNijePlaceno.TabStop = true;
            this.rbNijePlaceno.Text = "Nije plaćeno";
            this.rbNijePlaceno.UseVisualStyleBackColor = true;
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(585, 205);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(200, 42);
            this.btnSpremi.TabIndex = 4;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // btnDodajIgraca
            // 
            this.btnDodajIgraca.Location = new System.Drawing.Point(585, 253);
            this.btnDodajIgraca.Name = "btnDodajIgraca";
            this.btnDodajIgraca.Size = new System.Drawing.Size(200, 42);
            this.btnDodajIgraca.TabIndex = 5;
            this.btnDodajIgraca.Text = "Dodaj igrača na popis";
            this.btnDodajIgraca.UseVisualStyleBackColor = true;
            this.btnDodajIgraca.Click += new System.EventHandler(this.btnDodajIgraca_Click);
            // 
            // btnObrisiIgraca
            // 
            this.btnObrisiIgraca.Location = new System.Drawing.Point(585, 538);
            this.btnObrisiIgraca.Name = "btnObrisiIgraca";
            this.btnObrisiIgraca.Size = new System.Drawing.Size(200, 42);
            this.btnObrisiIgraca.TabIndex = 6;
            this.btnObrisiIgraca.Text = "Obriši igrača s popisa";
            this.btnObrisiIgraca.UseVisualStyleBackColor = true;
            this.btnObrisiIgraca.Click += new System.EventHandler(this.btnObrisiIgraca_Click);
            // 
            // cmbIgraci
            // 
            this.cmbIgraci.DataSource = this.igracBindingSource;
            this.cmbIgraci.DisplayMember = "prezime";
            this.cmbIgraci.FormattingEnabled = true;
            this.cmbIgraci.Location = new System.Drawing.Point(585, 301);
            this.cmbIgraci.Name = "cmbIgraci";
            this.cmbIgraci.Size = new System.Drawing.Size(199, 24);
            this.cmbIgraci.TabIndex = 7;
            this.cmbIgraci.ValueMember = "id_igrac";
            // 
            // FrmStanjeClanarina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 593);
            this.Controls.Add(this.cmbIgraci);
            this.Controls.Add(this.btnObrisiIgraca);
            this.Controls.Add(this.btnDodajIgraca);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblPopisTreninga);
            this.Controls.Add(this.dgvStanjeClanarina);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmStanjeClanarina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stanje članarina za [] []";
            this.Load += new System.EventHandler(this.FrmStanjeClanarina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStanjeClanarina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.igracBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._19008_DBDataSetUpdated)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clanarinaIgracaBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStanjeClanarina;
        private System.Windows.Forms.Label lblPopisTreninga;
        private _19008_DBDataSetUpdated _19008_DBDataSetUpdated;
        private System.Windows.Forms.BindingSource clanarinaIgracaBindingSource;
        private _19008_DBDataSetUpdatedTableAdapters.ClanarinaIgracaTableAdapter clanarinaIgracaTableAdapter;
        private System.Windows.Forms.BindingSource igracBindingSource;
        private _19008_DBDataSetUpdatedTableAdapters.IgracTableAdapter igracTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idclanarineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idigracaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uplacenoDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbNijePlaceno;
        private System.Windows.Forms.RadioButton rbPlaceno;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnDodajIgraca;
        private System.Windows.Forms.Button btnObrisiIgraca;
        private System.Windows.Forms.ComboBox cmbIgraci;
    }
}