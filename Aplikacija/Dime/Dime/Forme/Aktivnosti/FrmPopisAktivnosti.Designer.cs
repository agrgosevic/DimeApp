namespace Dime.Forme
{
    partial class FrmPopisAktivnosti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPopisAktivnosti));
            this.dgvOdrzaniTreninzi = new System.Windows.Forms.DataGridView();
            this.lblPopisTreninga = new System.Windows.Forms.Label();
            this.lblPopisClanarina = new System.Windows.Forms.Label();
            this.dgvPopisClanarina = new System.Windows.Forms.DataGridView();
            this.btnOdaberiTrening = new System.Windows.Forms.Button();
            this.btnOdaberiClanarinu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdrzaniTreninzi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisClanarina)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOdrzaniTreninzi
            // 
            this.dgvOdrzaniTreninzi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOdrzaniTreninzi.Location = new System.Drawing.Point(12, 41);
            this.dgvOdrzaniTreninzi.Name = "dgvOdrzaniTreninzi";
            this.dgvOdrzaniTreninzi.RowTemplate.Height = 24;
            this.dgvOdrzaniTreninzi.Size = new System.Drawing.Size(450, 451);
            this.dgvOdrzaniTreninzi.TabIndex = 0;
            // 
            // lblPopisTreninga
            // 
            this.lblPopisTreninga.AutoSize = true;
            this.lblPopisTreninga.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPopisTreninga.Location = new System.Drawing.Point(8, 9);
            this.lblPopisTreninga.Name = "lblPopisTreninga";
            this.lblPopisTreninga.Size = new System.Drawing.Size(240, 23);
            this.lblPopisTreninga.TabIndex = 1;
            this.lblPopisTreninga.Text = "Popis održanih treninga:";
            // 
            // lblPopisClanarina
            // 
            this.lblPopisClanarina.AutoSize = true;
            this.lblPopisClanarina.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPopisClanarina.Location = new System.Drawing.Point(778, 9);
            this.lblPopisClanarina.Name = "lblPopisClanarina";
            this.lblPopisClanarina.Size = new System.Drawing.Size(164, 23);
            this.lblPopisClanarina.TabIndex = 2;
            this.lblPopisClanarina.Text = "Popis članarina:";
            // 
            // dgvPopisClanarina
            // 
            this.dgvPopisClanarina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPopisClanarina.Location = new System.Drawing.Point(492, 41);
            this.dgvPopisClanarina.Name = "dgvPopisClanarina";
            this.dgvPopisClanarina.RowTemplate.Height = 24;
            this.dgvPopisClanarina.Size = new System.Drawing.Size(450, 451);
            this.dgvPopisClanarina.TabIndex = 3;
            // 
            // btnOdaberiTrening
            // 
            this.btnOdaberiTrening.Location = new System.Drawing.Point(12, 518);
            this.btnOdaberiTrening.Name = "btnOdaberiTrening";
            this.btnOdaberiTrening.Size = new System.Drawing.Size(101, 38);
            this.btnOdaberiTrening.TabIndex = 4;
            this.btnOdaberiTrening.Text = "Odaberi";
            this.btnOdaberiTrening.UseVisualStyleBackColor = true;
            // 
            // btnOdaberiClanarinu
            // 
            this.btnOdaberiClanarinu.Location = new System.Drawing.Point(841, 518);
            this.btnOdaberiClanarinu.Name = "btnOdaberiClanarinu";
            this.btnOdaberiClanarinu.Size = new System.Drawing.Size(101, 38);
            this.btnOdaberiClanarinu.TabIndex = 5;
            this.btnOdaberiClanarinu.Text = "Odaberi";
            this.btnOdaberiClanarinu.UseVisualStyleBackColor = true;
            // 
            // FrmPopisAktivnosti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 568);
            this.Controls.Add(this.btnOdaberiClanarinu);
            this.Controls.Add(this.btnOdaberiTrening);
            this.Controls.Add(this.dgvPopisClanarina);
            this.Controls.Add(this.lblPopisClanarina);
            this.Controls.Add(this.lblPopisTreninga);
            this.Controls.Add(this.dgvOdrzaniTreninzi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPopisAktivnosti";
            this.Text = "Popis aktivnosti";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdrzaniTreninzi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisClanarina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOdrzaniTreninzi;
        private System.Windows.Forms.Label lblPopisTreninga;
        private System.Windows.Forms.Label lblPopisClanarina;
        private System.Windows.Forms.DataGridView dgvPopisClanarina;
        private System.Windows.Forms.Button btnOdaberiTrening;
        private System.Windows.Forms.Button btnOdaberiClanarinu;
    }
}