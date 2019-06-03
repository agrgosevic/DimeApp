namespace Dime.Forme.Treninzi
{
    partial class FrmDodajIzmijeniTrening
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNapomena = new System.Windows.Forms.TextBox();
            this.txtKorisnik = new System.Windows.Forms.TextBox();
            this.cmbTipTreninga = new System.Windows.Forms.ComboBox();
            this.btnDodajTrening = new System.Windows.Forms.Button();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Datum i vrijeme";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Napomena";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tip treninga";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Korisnik";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(99, 37);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(121, 20);
            this.txtId.TabIndex = 6;
            // 
            // txtNapomena
            // 
            this.txtNapomena.Location = new System.Drawing.Point(99, 108);
            this.txtNapomena.Name = "txtNapomena";
            this.txtNapomena.Size = new System.Drawing.Size(121, 20);
            this.txtNapomena.TabIndex = 9;
            // 
            // txtKorisnik
            // 
            this.txtKorisnik.Location = new System.Drawing.Point(99, 179);
            this.txtKorisnik.Name = "txtKorisnik";
            this.txtKorisnik.Size = new System.Drawing.Size(121, 20);
            this.txtKorisnik.TabIndex = 11;
            // 
            // cmbTipTreninga
            // 
            this.cmbTipTreninga.FormattingEnabled = true;
            this.cmbTipTreninga.Location = new System.Drawing.Point(99, 142);
            this.cmbTipTreninga.Name = "cmbTipTreninga";
            this.cmbTipTreninga.Size = new System.Drawing.Size(121, 21);
            this.cmbTipTreninga.TabIndex = 12;
            // 
            // btnDodajTrening
            // 
            this.btnDodajTrening.Location = new System.Drawing.Point(99, 220);
            this.btnDodajTrening.Name = "btnDodajTrening";
            this.btnDodajTrening.Size = new System.Drawing.Size(121, 36);
            this.btnDodajTrening.TabIndex = 13;
            this.btnDodajTrening.Text = "Dodaj";
            this.btnDodajTrening.UseVisualStyleBackColor = true;
            this.btnDodajTrening.Click += new System.EventHandler(this.btnDodajTrening_Click);
            // 
            // dtpDatum
            // 
            this.dtpDatum.Location = new System.Drawing.Point(99, 73);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(200, 20);
            this.dtpDatum.TabIndex = 14;
            // 
            // FrmDodajIzmijeniTrening
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 368);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.btnDodajTrening);
            this.Controls.Add(this.cmbTipTreninga);
            this.Controls.Add(this.txtKorisnik);
            this.Controls.Add(this.txtNapomena);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmDodajIzmijeniTrening";
            this.Text = "FrmDodajIzmijeniTrening";
            this.Load += new System.EventHandler(this.FrmDodajIzmijeniTrening_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNapomena;
        private System.Windows.Forms.TextBox txtKorisnik;
        private System.Windows.Forms.ComboBox cmbTipTreninga;
        private System.Windows.Forms.Button btnDodajTrening;
        private System.Windows.Forms.DateTimePicker dtpDatum;
    }
}