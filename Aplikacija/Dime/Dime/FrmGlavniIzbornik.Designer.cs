namespace Dime
{
    partial class FrmGlavniIzbornik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGlavniIzbornik));
            this.label1 = new System.Windows.Forms.Label();
            this.grpKorisnik = new System.Windows.Forms.GroupBox();
            this.lblImeKorisnika = new System.Windows.Forms.Label();
            this.btnPomoc = new System.Windows.Forms.Button();
            this.btnAktivnosti = new System.Windows.Forms.Button();
            this.btnUtakmice = new System.Windows.Forms.Button();
            this.btnKorisnici = new System.Windows.Forms.Button();
            this.btnStatistika = new System.Windows.Forms.Button();
            this.btnTreninzi = new System.Windows.Forms.Button();
            this.btnIgraci = new System.Windows.Forms.Button();
            this.grpKorisnik.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Glavni izbornik";
            // 
            // grpKorisnik
            // 
            this.grpKorisnik.Controls.Add(this.lblImeKorisnika);
            this.grpKorisnik.Location = new System.Drawing.Point(421, 11);
            this.grpKorisnik.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpKorisnik.Name = "grpKorisnik";
            this.grpKorisnik.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpKorisnik.Size = new System.Drawing.Size(138, 41);
            this.grpKorisnik.TabIndex = 1;
            this.grpKorisnik.TabStop = false;
            this.grpKorisnik.Text = "Ulogiran kao:";
            // 
            // lblImeKorisnika
            // 
            this.lblImeKorisnika.AutoSize = true;
            this.lblImeKorisnika.Location = new System.Drawing.Point(5, 19);
            this.lblImeKorisnika.Name = "lblImeKorisnika";
            this.lblImeKorisnika.Size = new System.Drawing.Size(68, 13);
            this.lblImeKorisnika.TabIndex = 0;
            this.lblImeKorisnika.Text = "Ime i prezmie";
            // 
            // btnPomoc
            // 
            this.btnPomoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPomoc.Location = new System.Drawing.Point(563, 15);
            this.btnPomoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPomoc.Name = "btnPomoc";
            this.btnPomoc.Size = new System.Drawing.Size(33, 36);
            this.btnPomoc.TabIndex = 2;
            this.btnPomoc.Text = "? (F1)";
            this.btnPomoc.UseVisualStyleBackColor = true;
            // 
            // btnAktivnosti
            // 
            this.btnAktivnosti.BackgroundImage = global::Dime.Properties.Resources.Aktivnosti;
            this.btnAktivnosti.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAktivnosti.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAktivnosti.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.btnAktivnosti.Location = new System.Drawing.Point(310, 254);
            this.btnAktivnosti.Margin = new System.Windows.Forms.Padding(2);
            this.btnAktivnosti.Name = "btnAktivnosti";
            this.btnAktivnosti.Size = new System.Drawing.Size(286, 81);
            this.btnAktivnosti.TabIndex = 8;
            this.btnAktivnosti.Text = "Aktivnosti";
            this.btnAktivnosti.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnAktivnosti.UseVisualStyleBackColor = true;
            this.btnAktivnosti.Click += new System.EventHandler(this.btnAktivnosti_Click);
            // 
            // btnUtakmice
            // 
            this.btnUtakmice.BackgroundImage = global::Dime.Properties.Resources.Utakmice;
            this.btnUtakmice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUtakmice.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUtakmice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.btnUtakmice.Location = new System.Drawing.Point(310, 167);
            this.btnUtakmice.Margin = new System.Windows.Forms.Padding(2);
            this.btnUtakmice.Name = "btnUtakmice";
            this.btnUtakmice.Size = new System.Drawing.Size(286, 81);
            this.btnUtakmice.TabIndex = 7;
            this.btnUtakmice.Text = "Utakmice";
            this.btnUtakmice.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnUtakmice.UseVisualStyleBackColor = true;
            // 
            // btnKorisnici
            // 
            this.btnKorisnici.BackgroundImage = global::Dime.Properties.Resources.Korisnici;
            this.btnKorisnici.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKorisnici.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKorisnici.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.btnKorisnici.Location = new System.Drawing.Point(15, 167);
            this.btnKorisnici.Margin = new System.Windows.Forms.Padding(2);
            this.btnKorisnici.Name = "btnKorisnici";
            this.btnKorisnici.Size = new System.Drawing.Size(286, 81);
            this.btnKorisnici.TabIndex = 6;
            this.btnKorisnici.Text = "Korisnici";
            this.btnKorisnici.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnKorisnici.UseVisualStyleBackColor = true;
            this.btnKorisnici.Click += new System.EventHandler(this.btnKorisnici_Click);
            // 
            // btnStatistika
            // 
            this.btnStatistika.BackgroundImage = global::Dime.Properties.Resources.Statistika;
            this.btnStatistika.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStatistika.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatistika.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.btnStatistika.Location = new System.Drawing.Point(15, 254);
            this.btnStatistika.Margin = new System.Windows.Forms.Padding(2);
            this.btnStatistika.Name = "btnStatistika";
            this.btnStatistika.Size = new System.Drawing.Size(286, 81);
            this.btnStatistika.TabIndex = 5;
            this.btnStatistika.Text = "Statistika";
            this.btnStatistika.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnStatistika.UseVisualStyleBackColor = true;
            this.btnStatistika.Click += new System.EventHandler(this.btnStatistika_Click);
            // 
            // btnTreninzi
            // 
            this.btnTreninzi.BackgroundImage = global::Dime.Properties.Resources.Treninzi;
            this.btnTreninzi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTreninzi.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTreninzi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.btnTreninzi.Location = new System.Drawing.Point(310, 81);
            this.btnTreninzi.Margin = new System.Windows.Forms.Padding(2);
            this.btnTreninzi.Name = "btnTreninzi";
            this.btnTreninzi.Size = new System.Drawing.Size(286, 81);
            this.btnTreninzi.TabIndex = 4;
            this.btnTreninzi.Text = "Treninzi";
            this.btnTreninzi.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnTreninzi.UseVisualStyleBackColor = true;
            // 
            // btnIgraci
            // 
            this.btnIgraci.BackgroundImage = global::Dime.Properties.Resources.Igraci;
            this.btnIgraci.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIgraci.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIgraci.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.btnIgraci.Location = new System.Drawing.Point(15, 81);
            this.btnIgraci.Margin = new System.Windows.Forms.Padding(2);
            this.btnIgraci.Name = "btnIgraci";
            this.btnIgraci.Size = new System.Drawing.Size(286, 81);
            this.btnIgraci.TabIndex = 3;
            this.btnIgraci.Text = "Igrači";
            this.btnIgraci.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnIgraci.UseVisualStyleBackColor = true;
            this.btnIgraci.Click += new System.EventHandler(this.btnIgraci_Click);
            // 
            // FrmGlavniIzbornik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 352);
            this.Controls.Add(this.btnAktivnosti);
            this.Controls.Add(this.btnUtakmice);
            this.Controls.Add(this.btnKorisnici);
            this.Controls.Add(this.btnStatistika);
            this.Controls.Add(this.btnTreninzi);
            this.Controls.Add(this.btnIgraci);
            this.Controls.Add(this.btnPomoc);
            this.Controls.Add(this.grpKorisnik);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGlavniIzbornik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dime";
            this.grpKorisnik.ResumeLayout(false);
            this.grpKorisnik.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpKorisnik;
        private System.Windows.Forms.Button btnPomoc;
        private System.Windows.Forms.Button btnIgraci;
        private System.Windows.Forms.Button btnTreninzi;
        private System.Windows.Forms.Button btnStatistika;
        private System.Windows.Forms.Button btnKorisnici;
        private System.Windows.Forms.Button btnUtakmice;
        private System.Windows.Forms.Button btnAktivnosti;
        private System.Windows.Forms.Label lblImeKorisnika;
    }
}

