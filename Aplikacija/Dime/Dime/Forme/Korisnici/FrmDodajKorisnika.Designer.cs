namespace Dime.Forme
{
    partial class FrmDodajKorisnika
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDodajKorisnika));
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.txtKorisnickoIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbUloga = new System.Windows.Forms.ComboBox();
            this.ulogaKorisnikaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._19008_DBDataSet = new Dime._19008_DBDataSet();
            this.ulogaKorisnikaTableAdapter = new Dime._19008_DBDataSetTableAdapters.UlogaKorisnikaTableAdapter();
            this.btnPomoc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ulogaKorisnikaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._19008_DBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(204, 204);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 32;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(126, 204);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(72, 23);
            this.btnSpremi.TabIndex = 31;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "e-mail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Lozinka";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Korisničko ime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Prezime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Ime";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(126, 83);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(153, 20);
            this.txtEmail.TabIndex = 16;
            // 
            // txtLozinka
            // 
            this.txtLozinka.Location = new System.Drawing.Point(126, 135);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.Size = new System.Drawing.Size(153, 20);
            this.txtLozinka.TabIndex = 18;
            // 
            // txtKorisnickoIme
            // 
            this.txtKorisnickoIme.Location = new System.Drawing.Point(126, 109);
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            this.txtKorisnickoIme.Size = new System.Drawing.Size(153, 20);
            this.txtKorisnickoIme.TabIndex = 17;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(126, 57);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(153, 20);
            this.txtPrezime.TabIndex = 15;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(126, 31);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(153, 20);
            this.txtIme.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Uloga";
            // 
            // cmbUloga
            // 
            this.cmbUloga.DataSource = this.ulogaKorisnikaBindingSource;
            this.cmbUloga.DisplayMember = "naziv";
            this.cmbUloga.FormattingEnabled = true;
            this.cmbUloga.Location = new System.Drawing.Point(126, 161);
            this.cmbUloga.Name = "cmbUloga";
            this.cmbUloga.Size = new System.Drawing.Size(153, 21);
            this.cmbUloga.TabIndex = 19;
            this.cmbUloga.ValueMember = "id_uloga";
            // 
            // ulogaKorisnikaBindingSource
            // 
            this.ulogaKorisnikaBindingSource.DataMember = "UlogaKorisnika";
            this.ulogaKorisnikaBindingSource.DataSource = this._19008_DBDataSet;
            // 
            // _19008_DBDataSet
            // 
            this._19008_DBDataSet.DataSetName = "_19008_DBDataSet";
            this._19008_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ulogaKorisnikaTableAdapter
            // 
            this.ulogaKorisnikaTableAdapter.ClearBeforeFill = true;
            // 
            // btnPomoc
            // 
            this.btnPomoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPomoc.Location = new System.Drawing.Point(11, 238);
            this.btnPomoc.Margin = new System.Windows.Forms.Padding(2);
            this.btnPomoc.Name = "btnPomoc";
            this.btnPomoc.Size = new System.Drawing.Size(33, 36);
            this.btnPomoc.TabIndex = 33;
            this.btnPomoc.Text = "? (F1)";
            this.btnPomoc.UseVisualStyleBackColor = true;
            this.btnPomoc.Click += new System.EventHandler(this.btnPomoc_Click);
            // 
            // FrmDodajKorisnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 285);
            this.Controls.Add(this.btnPomoc);
            this.Controls.Add(this.cmbUloga);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtLozinka);
            this.Controls.Add(this.txtKorisnickoIme);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDodajKorisnika";
            this.Text = "Korisnik";
            this.Load += new System.EventHandler(this.FrmDodajKorisnika_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.FrmDodajKorisnika_HelpRequested);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmDodajKorisnika_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ulogaKorisnikaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._19008_DBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.TextBox txtKorisnickoIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbUloga;
        private _19008_DBDataSet _19008_DBDataSet;
        private System.Windows.Forms.BindingSource ulogaKorisnikaBindingSource;
        private _19008_DBDataSetTableAdapters.UlogaKorisnikaTableAdapter ulogaKorisnikaTableAdapter;
        private System.Windows.Forms.Button btnPomoc;
    }
}