namespace Dime.Forme.Treninzi
{
    partial class FrmUpravljanjeTreninzima
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnNoviTrening = new System.Windows.Forms.Button();
            this.treningBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idtreningDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrijemeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.napomenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiptreningaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korisnikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korisnikDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipTreningaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.treningPrisustvaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treningBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idtreningDataGridViewTextBoxColumn,
            this.datumDataGridViewTextBoxColumn,
            this.vrijemeDataGridViewTextBoxColumn,
            this.napomenaDataGridViewTextBoxColumn,
            this.tiptreningaDataGridViewTextBoxColumn,
            this.korisnikDataGridViewTextBoxColumn,
            this.korisnikDataGridViewTextBoxColumn1,
            this.tipTreningaDataGridViewTextBoxColumn1,
            this.treningPrisustvaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.treningBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(662, 219);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnNoviTrening
            // 
            this.btnNoviTrening.Location = new System.Drawing.Point(135, 270);
            this.btnNoviTrening.Name = "btnNoviTrening";
            this.btnNoviTrening.Size = new System.Drawing.Size(113, 40);
            this.btnNoviTrening.TabIndex = 1;
            this.btnNoviTrening.Text = "Dodaj trening";
            this.btnNoviTrening.UseVisualStyleBackColor = true;
            this.btnNoviTrening.Click += new System.EventHandler(this.btnNoviTrening_Click);
            // 
            // treningBindingSource
            // 
            this.treningBindingSource.DataSource = typeof(Dime.Trening);
            // 
            // idtreningDataGridViewTextBoxColumn
            // 
            this.idtreningDataGridViewTextBoxColumn.DataPropertyName = "id_trening";
            this.idtreningDataGridViewTextBoxColumn.HeaderText = "id_trening";
            this.idtreningDataGridViewTextBoxColumn.Name = "idtreningDataGridViewTextBoxColumn";
            // 
            // datumDataGridViewTextBoxColumn
            // 
            this.datumDataGridViewTextBoxColumn.DataPropertyName = "datum";
            this.datumDataGridViewTextBoxColumn.HeaderText = "datum";
            this.datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
            // 
            // vrijemeDataGridViewTextBoxColumn
            // 
            this.vrijemeDataGridViewTextBoxColumn.DataPropertyName = "vrijeme";
            this.vrijemeDataGridViewTextBoxColumn.HeaderText = "vrijeme";
            this.vrijemeDataGridViewTextBoxColumn.Name = "vrijemeDataGridViewTextBoxColumn";
            // 
            // napomenaDataGridViewTextBoxColumn
            // 
            this.napomenaDataGridViewTextBoxColumn.DataPropertyName = "napomena";
            this.napomenaDataGridViewTextBoxColumn.HeaderText = "napomena";
            this.napomenaDataGridViewTextBoxColumn.Name = "napomenaDataGridViewTextBoxColumn";
            // 
            // tiptreningaDataGridViewTextBoxColumn
            // 
            this.tiptreningaDataGridViewTextBoxColumn.DataPropertyName = "tip_treninga";
            this.tiptreningaDataGridViewTextBoxColumn.HeaderText = "tip_treninga";
            this.tiptreningaDataGridViewTextBoxColumn.Name = "tiptreningaDataGridViewTextBoxColumn";
            // 
            // korisnikDataGridViewTextBoxColumn
            // 
            this.korisnikDataGridViewTextBoxColumn.DataPropertyName = "korisnik";
            this.korisnikDataGridViewTextBoxColumn.HeaderText = "korisnik";
            this.korisnikDataGridViewTextBoxColumn.Name = "korisnikDataGridViewTextBoxColumn";
            // 
            // korisnikDataGridViewTextBoxColumn1
            // 
            this.korisnikDataGridViewTextBoxColumn1.DataPropertyName = "Korisnik";
            this.korisnikDataGridViewTextBoxColumn1.HeaderText = "Korisnik";
            this.korisnikDataGridViewTextBoxColumn1.Name = "korisnikDataGridViewTextBoxColumn1";
            this.korisnikDataGridViewTextBoxColumn1.Visible = false;
            // 
            // tipTreningaDataGridViewTextBoxColumn1
            // 
            this.tipTreningaDataGridViewTextBoxColumn1.DataPropertyName = "TipTreninga";
            this.tipTreningaDataGridViewTextBoxColumn1.HeaderText = "TipTreninga";
            this.tipTreningaDataGridViewTextBoxColumn1.Name = "tipTreningaDataGridViewTextBoxColumn1";
            this.tipTreningaDataGridViewTextBoxColumn1.Visible = false;
            // 
            // treningPrisustvaDataGridViewTextBoxColumn
            // 
            this.treningPrisustvaDataGridViewTextBoxColumn.DataPropertyName = "TreningPrisustva";
            this.treningPrisustvaDataGridViewTextBoxColumn.HeaderText = "TreningPrisustva";
            this.treningPrisustvaDataGridViewTextBoxColumn.Name = "treningPrisustvaDataGridViewTextBoxColumn";
            this.treningPrisustvaDataGridViewTextBoxColumn.Visible = false;
            // 
            // FrmUpravljanjeTreninzima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 433);
            this.Controls.Add(this.btnNoviTrening);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmUpravljanjeTreninzima";
            this.Text = "FrmUpravljanjeTreninzima";
            this.Load += new System.EventHandler(this.FrmUpravljanjeTreninzima_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treningBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource treningBindingSource;
        private System.Windows.Forms.Button btnNoviTrening;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtreningDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrijemeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn napomenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiptreningaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisnikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisnikDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipTreningaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn treningPrisustvaDataGridViewTextBoxColumn;
    }
}