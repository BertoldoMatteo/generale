namespace EsCreatMagBM
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbMagia = new System.Windows.Forms.ComboBox();
            this.lstCreature = new System.Windows.Forms.ListBox();
            this.btnEvoca = new System.Windows.Forms.Button();
            this.btnScaccia = new System.Windows.Forms.Button();
            this.btnMediaMagia = new System.Windows.Forms.Button();
            this.btnCreatureDeboli = new System.Windows.Forms.Button();
            this.btnFiltraRazza = new System.Windows.Forms.Button();
            this.btnCreaturaPotente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.cmbRazza = new System.Windows.Forms.ComboBox();
            this.pnlAvvia = new System.Windows.Forms.Panel();
            this.btnAvvia = new System.Windows.Forms.Button();
            this.pnlAvvia.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbMagia
            // 
            this.cmbMagia.FormattingEnabled = true;
            this.cmbMagia.Location = new System.Drawing.Point(416, 114);
            this.cmbMagia.Name = "cmbMagia";
            this.cmbMagia.Size = new System.Drawing.Size(106, 23);
            this.cmbMagia.TabIndex = 2;
            // 
            // lstCreature
            // 
            this.lstCreature.FormattingEnabled = true;
            this.lstCreature.HorizontalScrollbar = true;
            this.lstCreature.ItemHeight = 15;
            this.lstCreature.Location = new System.Drawing.Point(25, 226);
            this.lstCreature.Name = "lstCreature";
            this.lstCreature.ScrollAlwaysVisible = true;
            this.lstCreature.Size = new System.Drawing.Size(497, 184);
            this.lstCreature.TabIndex = 1;
            // 
            // btnEvoca
            // 
            this.btnEvoca.Location = new System.Drawing.Point(537, 163);
            this.btnEvoca.Name = "btnEvoca";
            this.btnEvoca.Size = new System.Drawing.Size(88, 47);
            this.btnEvoca.TabIndex = 4;
            this.btnEvoca.Text = "EVOCA";
            this.btnEvoca.UseVisualStyleBackColor = true;
            this.btnEvoca.Click += new System.EventHandler(this.btnEvoca_Click);
            // 
            // btnScaccia
            // 
            this.btnScaccia.Location = new System.Drawing.Point(646, 163);
            this.btnScaccia.Name = "btnScaccia";
            this.btnScaccia.Size = new System.Drawing.Size(88, 47);
            this.btnScaccia.TabIndex = 5;
            this.btnScaccia.Text = "SCACCIA";
            this.btnScaccia.UseVisualStyleBackColor = true;
            this.btnScaccia.Click += new System.EventHandler(this.btnScaccia_Click);
            // 
            // btnMediaMagia
            // 
            this.btnMediaMagia.Location = new System.Drawing.Point(537, 236);
            this.btnMediaMagia.Name = "btnMediaMagia";
            this.btnMediaMagia.Size = new System.Drawing.Size(88, 47);
            this.btnMediaMagia.TabIndex = 6;
            this.btnMediaMagia.Text = "MEDIA MAGIA";
            this.btnMediaMagia.UseVisualStyleBackColor = true;
            this.btnMediaMagia.Click += new System.EventHandler(this.btnMediaMagia_Click);
            // 
            // btnCreatureDeboli
            // 
            this.btnCreatureDeboli.Location = new System.Drawing.Point(646, 236);
            this.btnCreatureDeboli.Name = "btnCreatureDeboli";
            this.btnCreatureDeboli.Size = new System.Drawing.Size(88, 47);
            this.btnCreatureDeboli.TabIndex = 7;
            this.btnCreatureDeboli.Text = "CREATURE DEBOLI";
            this.btnCreatureDeboli.UseVisualStyleBackColor = true;
            this.btnCreatureDeboli.Click += new System.EventHandler(this.btnCreatureDeboli_Click);
            // 
            // btnFiltraRazza
            // 
            this.btnFiltraRazza.Location = new System.Drawing.Point(537, 299);
            this.btnFiltraRazza.Name = "btnFiltraRazza";
            this.btnFiltraRazza.Size = new System.Drawing.Size(88, 47);
            this.btnFiltraRazza.TabIndex = 8;
            this.btnFiltraRazza.Text = "FILTRA RAZZA";
            this.btnFiltraRazza.UseVisualStyleBackColor = true;
            this.btnFiltraRazza.Click += new System.EventHandler(this.btnFiltraRazza_Click);
            // 
            // btnCreaturaPotente
            // 
            this.btnCreaturaPotente.Location = new System.Drawing.Point(646, 299);
            this.btnCreaturaPotente.Name = "btnCreaturaPotente";
            this.btnCreaturaPotente.Size = new System.Drawing.Size(88, 47);
            this.btnCreaturaPotente.TabIndex = 9;
            this.btnCreaturaPotente.Text = "CREATURA POTENTE";
            this.btnCreaturaPotente.UseVisualStyleBackColor = true;
            this.btnCreaturaPotente.Click += new System.EventHandler(this.btnCreaturaPotente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "NOME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(450, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "MAGIA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(224, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "LISTA CREATURE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(597, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "COMANDI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(323, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "RAZZA";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(142, 116);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(88, 21);
            this.txtNome.TabIndex = 0;
            // 
            // cmbRazza
            // 
            this.cmbRazza.FormattingEnabled = true;
            this.cmbRazza.Location = new System.Drawing.Point(274, 114);
            this.cmbRazza.Name = "cmbRazza";
            this.cmbRazza.Size = new System.Drawing.Size(106, 23);
            this.cmbRazza.TabIndex = 1;
            // 
            // pnlAvvia
            // 
            this.pnlAvvia.Controls.Add(this.btnAvvia);
            this.pnlAvvia.Location = new System.Drawing.Point(12, 416);
            this.pnlAvvia.Name = "pnlAvvia";
            this.pnlAvvia.Size = new System.Drawing.Size(769, 46);
            this.pnlAvvia.TabIndex = 15;
            // 
            // btnAvvia
            // 
            this.btnAvvia.Location = new System.Drawing.Point(297, 185);
            this.btnAvvia.Name = "btnAvvia";
            this.btnAvvia.Size = new System.Drawing.Size(150, 100);
            this.btnAvvia.TabIndex = 0;
            this.btnAvvia.Text = "AVVIA";
            this.btnAvvia.UseVisualStyleBackColor = true;
            this.btnAvvia.Click += new System.EventHandler(this.btnAvvia_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 500);
            this.Controls.Add(this.pnlAvvia);
            this.Controls.Add(this.btnFiltraRazza);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lstCreature);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbRazza);
            this.Controls.Add(this.btnScaccia);
            this.Controls.Add(this.btnCreatureDeboli);
            this.Controls.Add(this.btnCreaturaPotente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbMagia);
            this.Controls.Add(this.btnEvoca);
            this.Controls.Add(this.btnMediaMagia);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.14F);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlAvvia.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbMagia;
        private System.Windows.Forms.ListBox lstCreature;
        private System.Windows.Forms.Button btnEvoca;
        private System.Windows.Forms.Button btnScaccia;
        private System.Windows.Forms.Button btnMediaMagia;
        private System.Windows.Forms.Button btnCreatureDeboli;
        private System.Windows.Forms.Button btnFiltraRazza;
        private System.Windows.Forms.Button btnCreaturaPotente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ComboBox cmbRazza;
        private System.Windows.Forms.Panel pnlAvvia;
        private System.Windows.Forms.Button btnAvvia;
    }
}

