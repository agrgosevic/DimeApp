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
            this.txtUlogiraniKorisnik = new System.Windows.Forms.TextBox();
            this.btnPomoc = new System.Windows.Forms.Button();
            this.btnIgraci = new System.Windows.Forms.Button();
            this.btnTreninzi = new System.Windows.Forms.Button();
            this.btnStatistika = new System.Windows.Forms.Button();
            this.btnKorisnici = new System.Windows.Forms.Button();
            this.btnUtakmice = new System.Windows.Forms.Button();
            this.btnAktivnosti = new System.Windows.Forms.Button();
            this.grpKorisnik.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Glavni izbornik";
            // 
            // grpKorisnik
            // 
            this.grpKorisnik.Controls.Add(this.txtUlogiraniKorisnik);
            this.grpKorisnik.Location = new System.Drawing.Point(561, 13);
            this.grpKorisnik.Name = "grpKorisnik";
            this.grpKorisnik.Size = new System.Drawing.Size(184, 50);
            this.grpKorisnik.TabIndex = 1;
            this.grpKorisnik.TabStop = false;
            this.grpKorisnik.Text = "Ulogiran kao:";
            // 
            // txtUlogiraniKorisnik
            // 
            this.txtUlogiraniKorisnik.Enabled = false;
            this.txtUlogiraniKorisnik.Location = new System.Drawing.Point(6, 22);
            this.txtUlogiraniKorisnik.Name = "txtUlogiraniKorisnik";
            this.txtUlogiraniKorisnik.Size = new System.Drawing.Size(172, 22);
            this.txtUlogiraniKorisnik.TabIndex = 0;
            // 
            // btnPomoc
            // 
            this.btnPomoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPomoc.Location = new System.Drawing.Point(751, 19);
            this.btnPomoc.Name = "btnPomoc";
            this.btnPomoc.Size = new System.Drawing.Size(44, 44);
            this.btnPomoc.TabIndex = 2;
            this.btnPomoc.Text = "? (F1)";
            this.btnPomoc.UseVisualStyleBackColor = true;
            // 
            // btnIgraci
            // 
            this.btnIgraci.BackgroundImage = global::Dime.Properties.Resources.Igraci;
            this.btnIgraci.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIgraci.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.btnIgraci.Location = new System.Drawing.Point(20, 100);
            this.btnIgraci.Name = "btnIgraci";
            this.btnIgraci.Size = new System.Drawing.Size(382, 100);
            this.btnIgraci.TabIndex = 3;
            this.btnIgraci.Text = "Igrači";
            this.btnIgraci.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnIgraci.UseVisualStyleBackColor = true;
            // 
            // btnTreninzi
            // 
            this.btnTreninzi.BackgroundImage = global::Dime.Properties.Resources.Treninzi;
            this.btnTreninzi.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTreninzi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.btnTreninzi.Location = new System.Drawing.Point(413, 100);
            this.btnTreninzi.Name = "btnTreninzi";
            this.btnTreninzi.Size = new System.Drawing.Size(382, 100);
            this.btnTreninzi.TabIndex = 4;
            this.btnTreninzi.Text = "Treninzi";
            this.btnTreninzi.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnTreninzi.UseVisualStyleBackColor = true;
            // 
            // btnStatistika
            // 
            this.btnStatistika.BackgroundImage = global::Dime.Properties.Resources.Statistika;
            this.btnStatistika.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatistika.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.btnStatistika.Location = new System.Drawing.Point(20, 312);
            this.btnStatistika.Name = "btnStatistika";
            this.btnStatistika.Size = new System.Drawing.Size(382, 100);
            this.btnStatistika.TabIndex = 5;
            this.btnStatistika.Text = "Statistika";
            this.btnStatistika.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnStatistika.UseVisualStyleBackColor = true;
            // 
            // btnKorisnici
            // 
            this.btnKorisnici.BackgroundImage = global::Dime.Properties.Resources.Korisnici;
            this.btnKorisnici.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKorisnici.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.btnKorisnici.Location = new System.Drawing.Point(20, 206);
            this.btnKorisnici.Name = "btnKorisnici";
            this.btnKorisnici.Size = new System.Drawing.Size(382, 100);
            this.btnKorisnici.TabIndex = 6;
            this.btnKorisnici.Text = "Korisnici";
            this.btnKorisnici.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnKorisnici.UseVisualStyleBackColor = true;
            // 
            // btnUtakmice
            // 
            this.btnUtakmice.BackgroundImage = global::Dime.Properties.Resources.Utakmice;
            this.btnUtakmice.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUtakmice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.btnUtakmice.Location = new System.Drawing.Point(413, 206);
            this.btnUtakmice.Name = "btnUtakmice";
            this.btnUtakmice.Size = new System.Drawing.Size(382, 100);
            this.btnUtakmice.TabIndex = 7;
            this.btnUtakmice.Text = "Utakmice";
            this.btnUtakmice.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnUtakmice.UseVisualStyleBackColor = true;
            // 
            // btnAktivnosti
            // 
            this.btnAktivnosti.BackgroundImage = global::Dime.Properties.Resources.Aktivnosti;
            this.btnAktivnosti.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAktivnosti.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.btnAktivnosti.Location = new System.Drawing.Point(413, 312);
            this.btnAktivnosti.Name = "btnAktivnosti";
            this.btnAktivnosti.Size = new System.Drawing.Size(382, 100);
            this.btnAktivnosti.TabIndex = 8;
            this.btnAktivnosti.Text = "Aktivnosti";
            this.btnAktivnosti.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnAktivnosti.UseVisualStyleBackColor = true;
            // 
            // FrmGlavniIzbornik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 433);
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
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.TextBox txtUlogiraniKorisnik;
        private System.Windows.Forms.Button btnPomoc;
        private System.Windows.Forms.Button btnIgraci;
        private System.Windows.Forms.Button btnTreninzi;
        private System.Windows.Forms.Button btnStatistika;
        private System.Windows.Forms.Button btnKorisnici;
        private System.Windows.Forms.Button btnUtakmice;
        private System.Windows.Forms.Button btnAktivnosti;
    }
}

