namespace Dime.Forme.Aktivnosti.HelpForme
{
    partial class HelpFrmStanjeClanarina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpFrmStanjeClanarina));
            this.lblNaslov = new System.Windows.Forms.Label();
            this.lblPomoc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNaslov
            // 
            this.lblNaslov.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaslov.Location = new System.Drawing.Point(12, 9);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(512, 64);
            this.lblNaslov.TabIndex = 5;
            this.lblNaslov.Text = "Pomoć";
            this.lblNaslov.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPomoc
            // 
            this.lblPomoc.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPomoc.Location = new System.Drawing.Point(12, 73);
            this.lblPomoc.Name = "lblPomoc";
            this.lblPomoc.Size = new System.Drawing.Size(512, 317);
            this.lblPomoc.TabIndex = 6;
            this.lblPomoc.Text = resources.GetString("lblPomoc.Text");
            this.lblPomoc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HelpFrmStanjeClanarina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(536, 399);
            this.Controls.Add(this.lblPomoc);
            this.Controls.Add(this.lblNaslov);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HelpFrmStanjeClanarina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pomoć";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.Label lblPomoc;
    }
}