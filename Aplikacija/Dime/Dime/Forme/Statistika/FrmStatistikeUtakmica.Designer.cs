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
            this._19008_DBDataSet1 = new Dime._19008_DBDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdigraneUtakmice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._19008_DBDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOdigraneUtakmice
            // 
            this.dgvOdigraneUtakmice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOdigraneUtakmice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOdigraneUtakmice.Location = new System.Drawing.Point(10, 11);
            this.dgvOdigraneUtakmice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvOdigraneUtakmice.Name = "dgvOdigraneUtakmice";
            this.dgvOdigraneUtakmice.RowTemplate.Height = 24;
            this.dgvOdigraneUtakmice.Size = new System.Drawing.Size(701, 360);
            this.dgvOdigraneUtakmice.TabIndex = 0;
            // 
            // btnOdaberi
            // 
            this.btnOdaberi.Location = new System.Drawing.Point(645, 388);
            this.btnOdaberi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOdaberi.Name = "btnOdaberi";
            this.btnOdaberi.Size = new System.Drawing.Size(66, 27);
            this.btnOdaberi.TabIndex = 1;
            this.btnOdaberi.Text = "Odaberi";
            this.btnOdaberi.UseVisualStyleBackColor = true;
            // 
            // _19008_DBDataSet1
            // 
            this._19008_DBDataSet1.DataSetName = "_19008_DBDataSet";
            this._19008_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FrmStatistikeUtakmica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 425);
            this.Controls.Add(this.btnOdaberi);
            this.Controls.Add(this.dgvOdigraneUtakmice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmStatistikeUtakmica";
            this.Text = "Odigrane utakmice";
            this.Load += new System.EventHandler(this.FrmStatistikeUtakmica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdigraneUtakmice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._19008_DBDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOdigraneUtakmice;
        private System.Windows.Forms.Button btnOdaberi;
        private _19008_DBDataSet _19008_DBDataSet1;
    }
}