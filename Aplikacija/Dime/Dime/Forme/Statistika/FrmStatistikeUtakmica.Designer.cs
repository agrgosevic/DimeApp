namespace Dime.Forme
{
    partial class FrmStatistikeUtakmica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStatistikeUtakmica));
            this.dgvOdigraneUtakmice = new System.Windows.Forms.DataGridView();
            this.btnOdaberi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdigraneUtakmice)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOdigraneUtakmice
            // 
            this.dgvOdigraneUtakmice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOdigraneUtakmice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOdigraneUtakmice.Location = new System.Drawing.Point(13, 13);
            this.dgvOdigraneUtakmice.Name = "dgvOdigraneUtakmice";
            this.dgvOdigraneUtakmice.RowTemplate.Height = 24;
            this.dgvOdigraneUtakmice.Size = new System.Drawing.Size(935, 443);
            this.dgvOdigraneUtakmice.TabIndex = 0;
            // 
            // btnOdaberi
            // 
            this.btnOdaberi.Location = new System.Drawing.Point(860, 478);
            this.btnOdaberi.Name = "btnOdaberi";
            this.btnOdaberi.Size = new System.Drawing.Size(88, 33);
            this.btnOdaberi.TabIndex = 1;
            this.btnOdaberi.Text = "Odaberi";
            this.btnOdaberi.UseVisualStyleBackColor = true;
            // 
            // FrmStatistikeUtakmica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 523);
            this.Controls.Add(this.btnOdaberi);
            this.Controls.Add(this.dgvOdigraneUtakmice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmStatistikeUtakmica";
            this.Text = "Odigrane utakmice";
            this.Load += new System.EventHandler(this.FrmStatistikeUtakmica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdigraneUtakmice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOdigraneUtakmice;
        private System.Windows.Forms.Button btnOdaberi;
    }
}