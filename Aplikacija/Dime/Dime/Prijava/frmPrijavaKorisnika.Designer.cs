namespace Dime.Prijava
{
    partial class frmPrijavaKorisnika
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrijavaKorisnika));
            this.btnPrijava = new System.Windows.Forms.Button();
            this.txtKorisnickoIme = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPomoc = new System.Windows.Forms.Button();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnPrijava
            // 
            this.btnPrijava.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnPrijava.Location = new System.Drawing.Point(23, 241);
            this.btnPrijava.Name = "btnPrijava";
            this.btnPrijava.Size = new System.Drawing.Size(75, 23);
            this.btnPrijava.TabIndex = 0;
            this.btnPrijava.Text = "Prijavi se";
            this.btnPrijava.UseVisualStyleBackColor = false;
            // 
            // txtKorisnickoIme
            // 
            this.txtKorisnickoIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtKorisnickoIme.Location = new System.Drawing.Point(23, 125);
            this.txtKorisnickoIme.Multiline = true;
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            this.txtKorisnickoIme.Size = new System.Drawing.Size(150, 28);
            this.txtKorisnickoIme.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Korisničko ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Lozinka:";
            // 
            // btnPomoc
            // 
            this.btnPomoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPomoc.Location = new System.Drawing.Point(355, 279);
            this.btnPomoc.Margin = new System.Windows.Forms.Padding(2);
            this.btnPomoc.Name = "btnPomoc";
            this.btnPomoc.Size = new System.Drawing.Size(33, 36);
            this.btnPomoc.TabIndex = 6;
            this.btnPomoc.Text = "? (F1)";
            this.btnPomoc.UseVisualStyleBackColor = true;
            // 
            // txtLozinka
            // 
            this.txtLozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtLozinka.Location = new System.Drawing.Point(23, 201);
            this.txtLozinka.Multiline = true;
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.Size = new System.Drawing.Size(150, 28);
            this.txtLozinka.TabIndex = 7;
            // 
            // frmPrijavaKorisnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 326);
            this.Controls.Add(this.txtLozinka);
            this.Controls.Add(this.btnPomoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKorisnickoIme);
            this.Controls.Add(this.btnPrijava);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrijavaKorisnika";
            this.Text = "frmPrijavaKorisnika";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrijava;
        private System.Windows.Forms.TextBox txtKorisnickoIme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPomoc;
        private System.Windows.Forms.TextBox txtLozinka;
    }
}