namespace Dime.Forme.Utakmice
{
    partial class FrmUpravljanjeUtakmicama
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
            this.idutakmicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrijemeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zabijenipoeniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.primljenipoeniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiputakmiceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.protivnikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korisnikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.protivnikDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korisniciDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statistikeIgracaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipUtakmiceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.utakmicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDodajUtakmicu = new System.Windows.Forms.Button();
            this.btnIzmijeniUtakmicu = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnPomoć = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utakmicaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idutakmicaDataGridViewTextBoxColumn,
            this.datumDataGridViewTextBoxColumn,
            this.vrijemeDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn,
            this.zabijenipoeniDataGridViewTextBoxColumn,
            this.primljenipoeniDataGridViewTextBoxColumn,
            this.tiputakmiceDataGridViewTextBoxColumn,
            this.protivnikDataGridViewTextBoxColumn,
            this.korisnikDataGridViewTextBoxColumn,
            this.protivnikDataGridViewTextBoxColumn1,
            this.korisniciDataGridViewTextBoxColumn,
            this.statistikeIgracaDataGridViewTextBoxColumn,
            this.tipUtakmiceDataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.utakmicaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(960, 241);
            this.dataGridView1.TabIndex = 0;
            // 
            // idutakmicaDataGridViewTextBoxColumn
            // 
            this.idutakmicaDataGridViewTextBoxColumn.DataPropertyName = "id_utakmica";
            this.idutakmicaDataGridViewTextBoxColumn.HeaderText = "id_utakmica";
            this.idutakmicaDataGridViewTextBoxColumn.Name = "idutakmicaDataGridViewTextBoxColumn";
            this.idutakmicaDataGridViewTextBoxColumn.Visible = false;
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
            // opisDataGridViewTextBoxColumn
            // 
            this.opisDataGridViewTextBoxColumn.DataPropertyName = "opis";
            this.opisDataGridViewTextBoxColumn.HeaderText = "opis";
            this.opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
            // 
            // zabijenipoeniDataGridViewTextBoxColumn
            // 
            this.zabijenipoeniDataGridViewTextBoxColumn.DataPropertyName = "zabijeni_poeni";
            this.zabijenipoeniDataGridViewTextBoxColumn.HeaderText = "zabijeni_poeni";
            this.zabijenipoeniDataGridViewTextBoxColumn.Name = "zabijenipoeniDataGridViewTextBoxColumn";
            // 
            // primljenipoeniDataGridViewTextBoxColumn
            // 
            this.primljenipoeniDataGridViewTextBoxColumn.DataPropertyName = "primljeni_poeni";
            this.primljenipoeniDataGridViewTextBoxColumn.HeaderText = "primljeni_poeni";
            this.primljenipoeniDataGridViewTextBoxColumn.Name = "primljenipoeniDataGridViewTextBoxColumn";
            // 
            // tiputakmiceDataGridViewTextBoxColumn
            // 
            this.tiputakmiceDataGridViewTextBoxColumn.DataPropertyName = "tip_utakmice";
            this.tiputakmiceDataGridViewTextBoxColumn.HeaderText = "tip_utakmice";
            this.tiputakmiceDataGridViewTextBoxColumn.Name = "tiputakmiceDataGridViewTextBoxColumn";
            // 
            // protivnikDataGridViewTextBoxColumn
            // 
            this.protivnikDataGridViewTextBoxColumn.DataPropertyName = "protivnik";
            this.protivnikDataGridViewTextBoxColumn.HeaderText = "protivnik";
            this.protivnikDataGridViewTextBoxColumn.Name = "protivnikDataGridViewTextBoxColumn";
            // 
            // korisnikDataGridViewTextBoxColumn
            // 
            this.korisnikDataGridViewTextBoxColumn.DataPropertyName = "korisnik";
            this.korisnikDataGridViewTextBoxColumn.HeaderText = "korisnik";
            this.korisnikDataGridViewTextBoxColumn.Name = "korisnikDataGridViewTextBoxColumn";
            // 
            // protivnikDataGridViewTextBoxColumn1
            // 
            this.protivnikDataGridViewTextBoxColumn1.DataPropertyName = "Protivnik";
            this.protivnikDataGridViewTextBoxColumn1.HeaderText = "Protivnik";
            this.protivnikDataGridViewTextBoxColumn1.Name = "protivnikDataGridViewTextBoxColumn1";
            this.protivnikDataGridViewTextBoxColumn1.Visible = false;
            // 
            // korisniciDataGridViewTextBoxColumn
            // 
            this.korisniciDataGridViewTextBoxColumn.DataPropertyName = "Korisnici";
            this.korisniciDataGridViewTextBoxColumn.HeaderText = "Korisnici";
            this.korisniciDataGridViewTextBoxColumn.Name = "korisniciDataGridViewTextBoxColumn";
            this.korisniciDataGridViewTextBoxColumn.Visible = false;
            // 
            // statistikeIgracaDataGridViewTextBoxColumn
            // 
            this.statistikeIgracaDataGridViewTextBoxColumn.DataPropertyName = "StatistikeIgraca";
            this.statistikeIgracaDataGridViewTextBoxColumn.HeaderText = "StatistikeIgraca";
            this.statistikeIgracaDataGridViewTextBoxColumn.Name = "statistikeIgracaDataGridViewTextBoxColumn";
            this.statistikeIgracaDataGridViewTextBoxColumn.Visible = false;
            // 
            // tipUtakmiceDataGridViewTextBoxColumn1
            // 
            this.tipUtakmiceDataGridViewTextBoxColumn1.DataPropertyName = "TipUtakmice";
            this.tipUtakmiceDataGridViewTextBoxColumn1.HeaderText = "TipUtakmice";
            this.tipUtakmiceDataGridViewTextBoxColumn1.Name = "tipUtakmiceDataGridViewTextBoxColumn1";
            this.tipUtakmiceDataGridViewTextBoxColumn1.Visible = false;
            // 
            // utakmicaBindingSource
            // 
            this.utakmicaBindingSource.DataSource = typeof(Dime.Utakmica);
            // 
            // btnDodajUtakmicu
            // 
            this.btnDodajUtakmicu.Location = new System.Drawing.Point(12, 279);
            this.btnDodajUtakmicu.Name = "btnDodajUtakmicu";
            this.btnDodajUtakmicu.Size = new System.Drawing.Size(142, 42);
            this.btnDodajUtakmicu.TabIndex = 1;
            this.btnDodajUtakmicu.Text = "Dodaj utakmicu";
            this.btnDodajUtakmicu.UseVisualStyleBackColor = true;
            this.btnDodajUtakmicu.Click += new System.EventHandler(this.btnDodajUtakmicu_Click);
            // 
            // btnIzmijeniUtakmicu
            // 
            this.btnIzmijeniUtakmicu.Location = new System.Drawing.Point(211, 279);
            this.btnIzmijeniUtakmicu.Name = "btnIzmijeniUtakmicu";
            this.btnIzmijeniUtakmicu.Size = new System.Drawing.Size(131, 42);
            this.btnIzmijeniUtakmicu.TabIndex = 2;
            this.btnIzmijeniUtakmicu.Text = "Izmijeni";
            this.btnIzmijeniUtakmicu.UseVisualStyleBackColor = true;
            this.btnIzmijeniUtakmicu.Click += new System.EventHandler(this.btnIzmijeniUtakmicu_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(405, 279);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(124, 42);
            this.btnObrisi.TabIndex = 3;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnPomoć
            // 
            this.btnPomoć.Location = new System.Drawing.Point(924, 279);
            this.btnPomoć.Name = "btnPomoć";
            this.btnPomoć.Size = new System.Drawing.Size(48, 36);
            this.btnPomoć.TabIndex = 5;
            this.btnPomoć.Text = "Pomoć (F1)";
            this.btnPomoć.UseVisualStyleBackColor = true;
            this.btnPomoć.Click += new System.EventHandler(this.btnPomoć_Click);
            // 
            // FrmUpravljanjeUtakmicama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 340);
            this.Controls.Add(this.btnPomoć);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnIzmijeniUtakmicu);
            this.Controls.Add(this.btnDodajUtakmicu);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmUpravljanjeUtakmicama";
            this.Text = "FrmDodajIzmijeniUtakmicu";
            this.Load += new System.EventHandler(this.FrmUpravljanjeUtakmicama_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.FrmUpravljanjeUtakmicama_HelpRequested);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmUpravljanjeUtakmicama_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utakmicaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource utakmicaBindingSource;
        private System.Windows.Forms.Button btnDodajUtakmicu;
        private System.Windows.Forms.DataGridViewTextBoxColumn idutakmicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrijemeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zabijenipoeniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn primljenipoeniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiputakmiceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn protivnikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisnikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn protivnikDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisniciDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statistikeIgracaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipUtakmiceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button btnIzmijeniUtakmicu;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnPomoć;
    }
}