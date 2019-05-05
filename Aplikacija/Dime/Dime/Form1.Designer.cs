namespace Dime
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.uiKorisnickoImeUnos = new System.Windows.Forms.TextBox();
            this.uiLozinkaUnos = new System.Windows.Forms.TextBox();
            this.btnPrijava = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Korisničko ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lozinka:";
            // 
            // uiKorisnickoImeUnos
            // 
            this.uiKorisnickoImeUnos.Location = new System.Drawing.Point(34, 83);
            this.uiKorisnickoImeUnos.Name = "uiKorisnickoImeUnos";
            this.uiKorisnickoImeUnos.Size = new System.Drawing.Size(137, 22);
            this.uiKorisnickoImeUnos.TabIndex = 2;
            // 
            // uiLozinkaUnos
            // 
            this.uiLozinkaUnos.Location = new System.Drawing.Point(34, 187);
            this.uiLozinkaUnos.Name = "uiLozinkaUnos";
            this.uiLozinkaUnos.Size = new System.Drawing.Size(137, 22);
            this.uiLozinkaUnos.TabIndex = 3;
            // 
            // btnPrijava
            // 
            this.btnPrijava.Location = new System.Drawing.Point(193, 32);
            this.btnPrijava.Name = "btnPrijava";
            this.btnPrijava.Size = new System.Drawing.Size(172, 73);
            this.btnPrijava.TabIndex = 4;
            this.btnPrijava.Text = "Prijava";
            this.btnPrijava.UseVisualStyleBackColor = true;
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(193, 136);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(172, 73);
            this.btnOdustani.TabIndex = 5;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(371, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 177);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 224);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnPrijava);
            this.Controls.Add(this.uiLozinkaUnos);
            this.Controls.Add(this.uiKorisnickoImeUnos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Prijava";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox uiKorisnickoImeUnos;
        private System.Windows.Forms.TextBox uiLozinkaUnos;
        private System.Windows.Forms.Button btnPrijava;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

