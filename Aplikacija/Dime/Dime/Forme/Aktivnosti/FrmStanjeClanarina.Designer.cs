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
            this.lblPopisTreninga = new System.Windows.Forms.Label();
            this._19008_DBDataSetUpdated = new Dime._19008_DBDataSetUpdated();
            this.clanarinaIgracaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clanarinaIgracaTableAdapter = new Dime._19008_DBDataSetUpdatedTableAdapters.ClanarinaIgracaTableAdapter();
            this.igracBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.igracTableAdapter = new Dime._19008_DBDataSetUpdatedTableAdapters.IgracTableAdapter();
            this.idclanarineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idigracaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.uplacenoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStanjeClanarina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._19008_DBDataSetUpdated)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clanarinaIgracaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.igracBindingSource)).BeginInit();
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
            // 
            // lblPopisTreninga
            // 
            this.lblPopisTreninga.AutoSize = true;
            this.lblPopisTreninga.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPopisTreninga.Location = new System.Drawing.Point(12, 9);
            this.lblPopisTreninga.Name = "lblPopisTreninga";
            this.lblPopisTreninga.Size = new System.Drawing.Size(235, 23);
            this.lblPopisTreninga.TabIndex = 2;
            this.lblPopisTreninga.Text = "Popis održanih treninga";
            // 
            // _19008_DBDataSetUpdated
            // 
            this._19008_DBDataSetUpdated.DataSetName = "_19008_DBDataSetUpdated";
            this._19008_DBDataSetUpdated.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clanarinaIgracaBindingSource
            // 
            this.clanarinaIgracaBindingSource.DataMember = "ClanarinaIgraca";
            this.clanarinaIgracaBindingSource.DataSource = this._19008_DBDataSetUpdated;
            // 
            // clanarinaIgracaTableAdapter
            // 
            this.clanarinaIgracaTableAdapter.ClearBeforeFill = true;
            // 
            // igracBindingSource
            // 
            this.igracBindingSource.DataMember = "Igrac";
            this.igracBindingSource.DataSource = this._19008_DBDataSetUpdated;
            // 
            // igracTableAdapter
            // 
            this.igracTableAdapter.ClearBeforeFill = true;
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
            // uplacenoDataGridViewTextBoxColumn
            // 
            this.uplacenoDataGridViewTextBoxColumn.DataPropertyName = "uplaceno";
            this.uplacenoDataGridViewTextBoxColumn.HeaderText = "Plaćeno?";
            this.uplacenoDataGridViewTextBoxColumn.Name = "uplacenoDataGridViewTextBoxColumn";
            this.uplacenoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FrmStanjeClanarina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 593);
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
            ((System.ComponentModel.ISupportInitialize)(this._19008_DBDataSetUpdated)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clanarinaIgracaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.igracBindingSource)).EndInit();
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
    }
}