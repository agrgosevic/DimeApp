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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUpravljanjeTreninzima));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnNoviTrening = new System.Windows.Forms.Button();
            this.btnIzmijeniTrening = new System.Windows.Forms.Button();
            this.btnObrisiTrening = new System.Windows.Forms.Button();
            this.btnPomoć = new System.Windows.Forms.Button();
            this.idtreningDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrijemeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.napomenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiptreningaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korisnikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korisnikDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipTreningaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.treningBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treningBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idtreningDataGridViewTextBoxColumn,
            this.datumDataGridViewTextBoxColumn,
            this.vrijemeDataGridViewTextBoxColumn,
            this.napomenaDataGridViewTextBoxColumn,
            this.tiptreningaDataGridViewTextBoxColumn,
            this.korisnikDataGridViewTextBoxColumn,
            this.korisnikDataGridViewTextBoxColumn1,
            this.tipTreningaDataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.treningBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(656, 219);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnNoviTrening
            // 
            this.btnNoviTrening.Location = new System.Drawing.Point(12, 253);
            this.btnNoviTrening.Name = "btnNoviTrening";
            this.btnNoviTrening.Size = new System.Drawing.Size(113, 40);
            this.btnNoviTrening.TabIndex = 1;
            this.btnNoviTrening.Text = "Dodaj trening";
            this.btnNoviTrening.UseVisualStyleBackColor = true;
            this.btnNoviTrening.Click += new System.EventHandler(this.btnNoviTrening_Click);
            // 
            // btnIzmijeniTrening
            // 
            this.btnIzmijeniTrening.Location = new System.Drawing.Point(168, 253);
            this.btnIzmijeniTrening.Name = "btnIzmijeniTrening";
            this.btnIzmijeniTrening.Size = new System.Drawing.Size(107, 40);
            this.btnIzmijeniTrening.TabIndex = 2;
            this.btnIzmijeniTrening.Text = "Izmijeni";
            this.btnIzmijeniTrening.UseVisualStyleBackColor = true;
            this.btnIzmijeniTrening.Click += new System.EventHandler(this.btnIzmijeniTrening_Click);
            // 
            // btnObrisiTrening
            // 
            this.btnObrisiTrening.Location = new System.Drawing.Point(324, 253);
            this.btnObrisiTrening.Name = "btnObrisiTrening";
            this.btnObrisiTrening.Size = new System.Drawing.Size(101, 40);
            this.btnObrisiTrening.TabIndex = 3;
            this.btnObrisiTrening.Text = "Obriši";
            this.btnObrisiTrening.UseVisualStyleBackColor = true;
            this.btnObrisiTrening.Click += new System.EventHandler(this.btnObrisiTrening_Click);
            // 
            // btnPomoć
            // 
            this.btnPomoć.Location = new System.Drawing.Point(618, 255);
            this.btnPomoć.Name = "btnPomoć";
            this.btnPomoć.Size = new System.Drawing.Size(48, 36);
            this.btnPomoć.TabIndex = 4;
            this.btnPomoć.Text = "Pomoć (F1)";
            this.btnPomoć.UseVisualStyleBackColor = true;
            this.btnPomoć.Click += new System.EventHandler(this.btnPomoć_Click);
            // 
            // idtreningDataGridViewTextBoxColumn
            // 
            this.idtreningDataGridViewTextBoxColumn.DataPropertyName = "id_trening";
            this.idtreningDataGridViewTextBoxColumn.HeaderText = "id_trening";
            this.idtreningDataGridViewTextBoxColumn.Name = "idtreningDataGridViewTextBoxColumn";
            this.idtreningDataGridViewTextBoxColumn.Visible = false;
            // 
            // datumDataGridViewTextBoxColumn
            // 
            this.datumDataGridViewTextBoxColumn.DataPropertyName = "datum";
            this.datumDataGridViewTextBoxColumn.HeaderText = "Datum";
            this.datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
            // 
            // vrijemeDataGridViewTextBoxColumn
            // 
            this.vrijemeDataGridViewTextBoxColumn.DataPropertyName = "vrijeme";
            this.vrijemeDataGridViewTextBoxColumn.HeaderText = "Vrijeme";
            this.vrijemeDataGridViewTextBoxColumn.Name = "vrijemeDataGridViewTextBoxColumn";
            // 
            // napomenaDataGridViewTextBoxColumn
            // 
            this.napomenaDataGridViewTextBoxColumn.DataPropertyName = "napomena";
            this.napomenaDataGridViewTextBoxColumn.HeaderText = "Napomena";
            this.napomenaDataGridViewTextBoxColumn.Name = "napomenaDataGridViewTextBoxColumn";
            // 
            // tiptreningaDataGridViewTextBoxColumn
            // 
            this.tiptreningaDataGridViewTextBoxColumn.DataPropertyName = "tip_treninga";
            this.tiptreningaDataGridViewTextBoxColumn.HeaderText = "Tip treninga";
            this.tiptreningaDataGridViewTextBoxColumn.Name = "tiptreningaDataGridViewTextBoxColumn";
            // 
            // korisnikDataGridViewTextBoxColumn
            // 
            this.korisnikDataGridViewTextBoxColumn.DataPropertyName = "korisnik";
            this.korisnikDataGridViewTextBoxColumn.HeaderText = "Trener";
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
            // treningBindingSource
            // 
            this.treningBindingSource.DataSource = typeof(Dime.Trening);
            // 
            // FrmUpravljanjeTreninzima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 309);
            this.Controls.Add(this.btnPomoć);
            this.Controls.Add(this.btnObrisiTrening);
            this.Controls.Add(this.btnIzmijeniTrening);
            this.Controls.Add(this.btnNoviTrening);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmUpravljanjeTreninzima";
            this.Text = "Treninzi";
            this.Load += new System.EventHandler(this.FrmUpravljanjeTreninzima_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.FrmUpravljanjeTreninzima_HelpRequested);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmUpravljanjeTreninzima_KeyDown);
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
        private System.Windows.Forms.Button btnIzmijeniTrening;
        private System.Windows.Forms.Button btnObrisiTrening;
        private System.Windows.Forms.Button btnPomoć;
    }
}