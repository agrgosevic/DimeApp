namespace Dime.Forme.Statistika
{
    partial class FrmDodajStatistikuIgraca
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDodajStatistikuIgraca));
            this.lblIgrac = new System.Windows.Forms.Label();
            this.lblMinute = new System.Windows.Forms.Label();
            this.lblPrekrsaji = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbIgraci = new System.Windows.Forms.ComboBox();
            this.igracBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._19008_DBDataSetPrimary = new Dime._19008_DBDataSetPrimary();
            this.txtMinute = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt3pP = new System.Windows.Forms.TextBox();
            this.txt3pZ = new System.Windows.Forms.TextBox();
            this.txt2pP = new System.Windows.Forms.TextBox();
            this.txt2pZ = new System.Windows.Forms.TextBox();
            this.txtSBP = new System.Windows.Forms.TextBox();
            this.txtSBZ = new System.Windows.Forms.TextBox();
            this.lbl3pP = new System.Windows.Forms.Label();
            this.lbl3pZ = new System.Windows.Forms.Label();
            this.lbl2pP = new System.Windows.Forms.Label();
            this.lbl2pZ = new System.Windows.Forms.Label();
            this.lblSBP = new System.Windows.Forms.Label();
            this.lblSBZ = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtSkokovi = new System.Windows.Forms.TextBox();
            this.txtAsistencije = new System.Windows.Forms.TextBox();
            this.txtPrekrsaji = new System.Windows.Forms.TextBox();
            this.lblAsistencije = new System.Windows.Forms.Label();
            this.lblSkokovi = new System.Windows.Forms.Label();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.igracTableAdapter = new Dime._19008_DBDataSetPrimaryTableAdapters.IgracTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.igracBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._19008_DBDataSetPrimary)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIgrac
            // 
            this.lblIgrac.AutoSize = true;
            this.lblIgrac.Location = new System.Drawing.Point(6, 18);
            this.lblIgrac.Name = "lblIgrac";
            this.lblIgrac.Size = new System.Drawing.Size(43, 17);
            this.lblIgrac.TabIndex = 0;
            this.lblIgrac.Text = "Igrač:";
            // 
            // lblMinute
            // 
            this.lblMinute.AutoSize = true;
            this.lblMinute.Location = new System.Drawing.Point(6, 59);
            this.lblMinute.Name = "lblMinute";
            this.lblMinute.Size = new System.Drawing.Size(117, 17);
            this.lblMinute.TabIndex = 1;
            this.lblMinute.Text = "Odigrano minuta:";
            // 
            // lblPrekrsaji
            // 
            this.lblPrekrsaji.AutoSize = true;
            this.lblPrekrsaji.Location = new System.Drawing.Point(6, 18);
            this.lblPrekrsaji.Name = "lblPrekrsaji";
            this.lblPrekrsaji.Size = new System.Drawing.Size(67, 17);
            this.lblPrekrsaji.TabIndex = 2;
            this.lblPrekrsaji.Text = "Prekršaji:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbIgraci);
            this.groupBox1.Controls.Add(this.txtMinute);
            this.groupBox1.Controls.Add(this.lblIgrac);
            this.groupBox1.Controls.Add(this.lblMinute);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(511, 90);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // cmbIgraci
            // 
            this.cmbIgraci.DataSource = this.igracBindingSource;
            this.cmbIgraci.DisplayMember = "prezime";
            this.cmbIgraci.FormattingEnabled = true;
            this.cmbIgraci.Location = new System.Drawing.Point(331, 15);
            this.cmbIgraci.Name = "cmbIgraci";
            this.cmbIgraci.Size = new System.Drawing.Size(174, 24);
            this.cmbIgraci.TabIndex = 3;
            this.cmbIgraci.ValueMember = "id_igrac";
            // 
            // igracBindingSource
            // 
            this.igracBindingSource.DataMember = "Igrac";
            this.igracBindingSource.DataSource = this._19008_DBDataSetPrimary;
            // 
            // _19008_DBDataSetPrimary
            // 
            this._19008_DBDataSetPrimary.DataSetName = "_19008_DBDataSetPrimary";
            this._19008_DBDataSetPrimary.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtMinute
            // 
            this.txtMinute.Location = new System.Drawing.Point(416, 56);
            this.txtMinute.Name = "txtMinute";
            this.txtMinute.Size = new System.Drawing.Size(89, 22);
            this.txtMinute.TabIndex = 2;
            this.txtMinute.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt3pP);
            this.groupBox2.Controls.Add(this.txt3pZ);
            this.groupBox2.Controls.Add(this.txt2pP);
            this.groupBox2.Controls.Add(this.txt2pZ);
            this.groupBox2.Controls.Add(this.txtSBP);
            this.groupBox2.Controls.Add(this.txtSBZ);
            this.groupBox2.Controls.Add(this.lbl3pP);
            this.groupBox2.Controls.Add(this.lbl3pZ);
            this.groupBox2.Controls.Add(this.lbl2pP);
            this.groupBox2.Controls.Add(this.lbl2pZ);
            this.groupBox2.Controls.Add(this.lblSBP);
            this.groupBox2.Controls.Add(this.lblSBZ);
            this.groupBox2.Location = new System.Drawing.Point(13, 129);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(511, 252);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // txt3pP
            // 
            this.txt3pP.Location = new System.Drawing.Point(416, 220);
            this.txt3pP.Name = "txt3pP";
            this.txt3pP.Size = new System.Drawing.Size(89, 22);
            this.txt3pP.TabIndex = 16;
            this.txt3pP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt3pZ
            // 
            this.txt3pZ.Location = new System.Drawing.Point(416, 182);
            this.txt3pZ.Name = "txt3pZ";
            this.txt3pZ.Size = new System.Drawing.Size(89, 22);
            this.txt3pZ.TabIndex = 15;
            this.txt3pZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt2pP
            // 
            this.txt2pP.Location = new System.Drawing.Point(416, 141);
            this.txt2pP.Name = "txt2pP";
            this.txt2pP.Size = new System.Drawing.Size(89, 22);
            this.txt2pP.TabIndex = 14;
            this.txt2pP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt2pZ
            // 
            this.txt2pZ.Location = new System.Drawing.Point(416, 99);
            this.txt2pZ.Name = "txt2pZ";
            this.txt2pZ.Size = new System.Drawing.Size(89, 22);
            this.txt2pZ.TabIndex = 13;
            this.txt2pZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSBP
            // 
            this.txtSBP.Location = new System.Drawing.Point(416, 58);
            this.txtSBP.Name = "txtSBP";
            this.txtSBP.Size = new System.Drawing.Size(89, 22);
            this.txtSBP.TabIndex = 12;
            this.txtSBP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSBZ
            // 
            this.txtSBZ.Location = new System.Drawing.Point(416, 15);
            this.txtSBZ.Name = "txtSBZ";
            this.txtSBZ.Size = new System.Drawing.Size(89, 22);
            this.txtSBZ.TabIndex = 11;
            this.txtSBZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl3pP
            // 
            this.lbl3pP.AutoSize = true;
            this.lbl3pP.Location = new System.Drawing.Point(6, 225);
            this.lbl3pP.Name = "lbl3pP";
            this.lbl3pP.Size = new System.Drawing.Size(140, 17);
            this.lbl3pP.TabIndex = 10;
            this.lbl3pP.Text = "Pokušaji poena za 3:";
            // 
            // lbl3pZ
            // 
            this.lbl3pZ.AutoSize = true;
            this.lbl3pZ.Location = new System.Drawing.Point(6, 187);
            this.lbl3pZ.Name = "lbl3pZ";
            this.lbl3pZ.Size = new System.Drawing.Size(132, 17);
            this.lbl3pZ.TabIndex = 9;
            this.lbl3pZ.Text = "Zabijeni poeni za 3:";
            // 
            // lbl2pP
            // 
            this.lbl2pP.AutoSize = true;
            this.lbl2pP.Location = new System.Drawing.Point(6, 146);
            this.lbl2pP.Name = "lbl2pP";
            this.lbl2pP.Size = new System.Drawing.Size(140, 17);
            this.lbl2pP.TabIndex = 8;
            this.lbl2pP.Text = "Pokušaji poena za 2:";
            // 
            // lbl2pZ
            // 
            this.lbl2pZ.AutoSize = true;
            this.lbl2pZ.Location = new System.Drawing.Point(6, 104);
            this.lbl2pZ.Name = "lbl2pZ";
            this.lbl2pZ.Size = new System.Drawing.Size(132, 17);
            this.lbl2pZ.TabIndex = 7;
            this.lbl2pZ.Text = "Zabijeni poeni za 2:";
            // 
            // lblSBP
            // 
            this.lblSBP.AutoSize = true;
            this.lblSBP.Location = new System.Drawing.Point(6, 63);
            this.lblSBP.Name = "lblSBP";
            this.lblSBP.Size = new System.Drawing.Size(184, 17);
            this.lblSBP.TabIndex = 6;
            this.lblSBP.Text = "Pokušaji slobodnih bacanja:";
            // 
            // lblSBZ
            // 
            this.lblSBZ.AutoSize = true;
            this.lblSBZ.Location = new System.Drawing.Point(6, 18);
            this.lblSBZ.Name = "lblSBZ";
            this.lblSBZ.Size = new System.Drawing.Size(183, 17);
            this.lblSBZ.TabIndex = 5;
            this.lblSBZ.Text = "Zabijena slobodna bacanja:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtSkokovi);
            this.groupBox3.Controls.Add(this.txtAsistencije);
            this.groupBox3.Controls.Add(this.txtPrekrsaji);
            this.groupBox3.Controls.Add(this.lblAsistencije);
            this.groupBox3.Controls.Add(this.lblSkokovi);
            this.groupBox3.Controls.Add(this.lblPrekrsaji);
            this.groupBox3.Location = new System.Drawing.Point(13, 406);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(511, 117);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            // 
            // txtSkokovi
            // 
            this.txtSkokovi.Location = new System.Drawing.Point(416, 87);
            this.txtSkokovi.Name = "txtSkokovi";
            this.txtSkokovi.Size = new System.Drawing.Size(89, 22);
            this.txtSkokovi.TabIndex = 8;
            this.txtSkokovi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtAsistencije
            // 
            this.txtAsistencije.Location = new System.Drawing.Point(416, 51);
            this.txtAsistencije.Name = "txtAsistencije";
            this.txtAsistencije.Size = new System.Drawing.Size(89, 22);
            this.txtAsistencije.TabIndex = 7;
            this.txtAsistencije.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPrekrsaji
            // 
            this.txtPrekrsaji.Location = new System.Drawing.Point(416, 15);
            this.txtPrekrsaji.Name = "txtPrekrsaji";
            this.txtPrekrsaji.Size = new System.Drawing.Size(89, 22);
            this.txtPrekrsaji.TabIndex = 6;
            this.txtPrekrsaji.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblAsistencije
            // 
            this.lblAsistencije.AutoSize = true;
            this.lblAsistencije.Location = new System.Drawing.Point(6, 56);
            this.lblAsistencije.Name = "lblAsistencije";
            this.lblAsistencije.Size = new System.Drawing.Size(79, 17);
            this.lblAsistencije.TabIndex = 4;
            this.lblAsistencije.Text = "Asistencije:";
            // 
            // lblSkokovi
            // 
            this.lblSkokovi.AutoSize = true;
            this.lblSkokovi.Location = new System.Drawing.Point(6, 92);
            this.lblSkokovi.Name = "lblSkokovi";
            this.lblSkokovi.Size = new System.Drawing.Size(61, 17);
            this.lblSkokovi.TabIndex = 3;
            this.lblSkokovi.Text = "Skokovi:";
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(13, 539);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(406, 46);
            this.btnSpremi.TabIndex = 6;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // igracTableAdapter
            // 
            this.igracTableAdapter.ClearBeforeFill = true;
            // 
            // FrmDodajStatistikuIgraca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 597);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDodajStatistikuIgraca";
            this.Text = "Dodaj ili izmjeni statistiku igrača sa utakmice";
            this.Load += new System.EventHandler(this.FrmDodajStatistikuIgraca_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.igracBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._19008_DBDataSetPrimary)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblIgrac;
        private System.Windows.Forms.Label lblMinute;
        private System.Windows.Forms.Label lblPrekrsaji;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMinute;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl3pP;
        private System.Windows.Forms.Label lbl3pZ;
        private System.Windows.Forms.Label lbl2pP;
        private System.Windows.Forms.Label lbl2pZ;
        private System.Windows.Forms.Label lblSBP;
        private System.Windows.Forms.Label lblSBZ;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblAsistencije;
        private System.Windows.Forms.Label lblSkokovi;
        private System.Windows.Forms.TextBox txt3pP;
        private System.Windows.Forms.TextBox txt3pZ;
        private System.Windows.Forms.TextBox txt2pP;
        private System.Windows.Forms.TextBox txt2pZ;
        private System.Windows.Forms.TextBox txtSBP;
        private System.Windows.Forms.TextBox txtSBZ;
        private System.Windows.Forms.TextBox txtSkokovi;
        private System.Windows.Forms.TextBox txtAsistencije;
        private System.Windows.Forms.TextBox txtPrekrsaji;
        private System.Windows.Forms.ComboBox cmbIgraci;
        private System.Windows.Forms.Button btnSpremi;
        private _19008_DBDataSetPrimary _19008_DBDataSetPrimary;
        private System.Windows.Forms.BindingSource igracBindingSource;
        private _19008_DBDataSetPrimaryTableAdapters.IgracTableAdapter igracTableAdapter;
    }
}