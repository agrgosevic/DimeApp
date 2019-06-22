namespace Dime.Forme.Aktivnosti
{
    partial class FrmDodajClanarinu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDodajClanarinu));
            this.lblMjesec = new System.Windows.Forms.Label();
            this.lblGodina = new System.Windows.Forms.Label();
            this.lblRok = new System.Windows.Forms.Label();
            this.txtGodina = new System.Windows.Forms.TextBox();
            this.cmbMjeseci = new System.Windows.Forms.ComboBox();
            this.dtpRok = new System.Windows.Forms.DateTimePicker();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnPomoc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMjesec
            // 
            this.lblMjesec.AutoSize = true;
            this.lblMjesec.Location = new System.Drawing.Point(10, 9);
            this.lblMjesec.Name = "lblMjesec";
            this.lblMjesec.Size = new System.Drawing.Size(56, 17);
            this.lblMjesec.TabIndex = 0;
            this.lblMjesec.Text = "Mjesec:";
            // 
            // lblGodina
            // 
            this.lblGodina.AutoSize = true;
            this.lblGodina.Location = new System.Drawing.Point(11, 71);
            this.lblGodina.Name = "lblGodina";
            this.lblGodina.Size = new System.Drawing.Size(58, 17);
            this.lblGodina.TabIndex = 1;
            this.lblGodina.Text = "Godina:";
            // 
            // lblRok
            // 
            this.lblRok.AutoSize = true;
            this.lblRok.Location = new System.Drawing.Point(10, 133);
            this.lblRok.Name = "lblRok";
            this.lblRok.Size = new System.Drawing.Size(99, 17);
            this.lblRok.TabIndex = 2;
            this.lblRok.Text = "Rok za uplatu:";
            // 
            // txtGodina
            // 
            this.txtGodina.Location = new System.Drawing.Point(14, 91);
            this.txtGodina.Name = "txtGodina";
            this.txtGodina.Size = new System.Drawing.Size(81, 22);
            this.txtGodina.TabIndex = 3;
            // 
            // cmbMjeseci
            // 
            this.cmbMjeseci.FormattingEnabled = true;
            this.cmbMjeseci.Items.AddRange(new object[] {
            "Sijecanj",
            "Veljaca",
            "Ozujak",
            "Travanj",
            "Svibanj",
            "Lipanj",
            "Srpanj",
            "Kolovoz",
            "Rujan",
            "Listopad",
            "Studeni",
            "Prosinac"});
            this.cmbMjeseci.Location = new System.Drawing.Point(14, 29);
            this.cmbMjeseci.Name = "cmbMjeseci";
            this.cmbMjeseci.Size = new System.Drawing.Size(193, 24);
            this.cmbMjeseci.TabIndex = 4;
            // 
            // dtpRok
            // 
            this.dtpRok.Location = new System.Drawing.Point(13, 153);
            this.dtpRok.Name = "dtpRok";
            this.dtpRok.Size = new System.Drawing.Size(232, 22);
            this.dtpRok.TabIndex = 5;
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(12, 195);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(233, 48);
            this.btnSpremi.TabIndex = 6;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // btnPomoc
            // 
            this.btnPomoc.Location = new System.Drawing.Point(324, 195);
            this.btnPomoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPomoc.Name = "btnPomoc";
            this.btnPomoc.Size = new System.Drawing.Size(48, 48);
            this.btnPomoc.TabIndex = 7;
            this.btnPomoc.Text = "? (F1)";
            this.btnPomoc.UseVisualStyleBackColor = true;
            this.btnPomoc.Click += new System.EventHandler(this.btnPomoc_Click);
            // 
            // FrmDodajClanarinu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 258);
            this.Controls.Add(this.btnPomoc);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.dtpRok);
            this.Controls.Add(this.cmbMjeseci);
            this.Controls.Add(this.txtGodina);
            this.Controls.Add(this.lblRok);
            this.Controls.Add(this.lblGodina);
            this.Controls.Add(this.lblMjesec);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDodajClanarinu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj ili izmjeni članarinu";
            this.Load += new System.EventHandler(this.FrmDodajClanarinu_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.FrmDodajClanarinu_HelpRequested);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMjesec;
        private System.Windows.Forms.Label lblGodina;
        private System.Windows.Forms.Label lblRok;
        private System.Windows.Forms.TextBox txtGodina;
        private System.Windows.Forms.ComboBox cmbMjeseci;
        private System.Windows.Forms.DateTimePicker dtpRok;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnPomoc;
    }
}