namespace EsRicettaDigBM
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
            this.lblTitolo = new System.Windows.Forms.Label();
            this.lstElenco = new System.Windows.Forms.ListBox();
            this.lblEtichetta = new System.Windows.Forms.Label();
            this.lblFrolla = new System.Windows.Forms.Label();
            this.lblMarmellata = new System.Windows.Forms.Label();
            this.lblCottura = new System.Windows.Forms.Label();
            this.lblDiametro = new System.Windows.Forms.Label();
            this.lblDecorazione = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.cmbFrolla = new System.Windows.Forms.ComboBox();
            this.cmbMarmellata = new System.Windows.Forms.ComboBox();
            this.txtTempoCottura = new System.Windows.Forms.TextBox();
            this.txtDiametro = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.rdbT = new System.Windows.Forms.RadioButton();
            this.rdbF = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRicerca = new System.Windows.Forms.Button();
            this.btnAggiungi = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitolo
            // 
            this.lblTitolo.AutoSize = true;
            this.lblTitolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitolo.Location = new System.Drawing.Point(322, 3);
            this.lblTitolo.Name = "lblTitolo";
            this.lblTitolo.Size = new System.Drawing.Size(135, 24);
            this.lblTitolo.TabIndex = 1;
            this.lblTitolo.Text = "1001 Crostata";
            // 
            // lstElenco
            // 
            this.lstElenco.FormattingEnabled = true;
            this.lstElenco.ItemHeight = 16;
            this.lstElenco.Location = new System.Drawing.Point(12, 30);
            this.lstElenco.Name = "lstElenco";
            this.lstElenco.Size = new System.Drawing.Size(600, 340);
            this.lstElenco.TabIndex = 2;
            // 
            // lblEtichetta
            // 
            this.lblEtichetta.AutoSize = true;
            this.lblEtichetta.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtichetta.Location = new System.Drawing.Point(778, 458);
            this.lblEtichetta.Name = "lblEtichetta";
            this.lblEtichetta.Size = new System.Drawing.Size(176, 24);
            this.lblEtichetta.TabIndex = 4;
            this.lblEtichetta.Text = "BERTOLDO MATTEO";
            // 
            // lblFrolla
            // 
            this.lblFrolla.AutoSize = true;
            this.lblFrolla.Location = new System.Drawing.Point(14, 10);
            this.lblFrolla.Name = "lblFrolla";
            this.lblFrolla.Size = new System.Drawing.Size(41, 16);
            this.lblFrolla.TabIndex = 5;
            this.lblFrolla.Text = "Frolla";
            // 
            // lblMarmellata
            // 
            this.lblMarmellata.AutoSize = true;
            this.lblMarmellata.Location = new System.Drawing.Point(177, 10);
            this.lblMarmellata.Name = "lblMarmellata";
            this.lblMarmellata.Size = new System.Drawing.Size(74, 16);
            this.lblMarmellata.TabIndex = 6;
            this.lblMarmellata.Text = "Marmellata";
            // 
            // lblCottura
            // 
            this.lblCottura.AutoSize = true;
            this.lblCottura.Location = new System.Drawing.Point(14, 75);
            this.lblCottura.Name = "lblCottura";
            this.lblCottura.Size = new System.Drawing.Size(140, 16);
            this.lblCottura.TabIndex = 7;
            this.lblCottura.Text = "Tempo di cottura (min)";
            // 
            // lblDiametro
            // 
            this.lblDiametro.AutoSize = true;
            this.lblDiametro.Location = new System.Drawing.Point(177, 75);
            this.lblDiametro.Name = "lblDiametro";
            this.lblDiametro.Size = new System.Drawing.Size(91, 16);
            this.lblDiametro.TabIndex = 8;
            this.lblDiametro.Text = "Diametro (cm)";
            // 
            // lblDecorazione
            // 
            this.lblDecorazione.AutoSize = true;
            this.lblDecorazione.Location = new System.Drawing.Point(14, 135);
            this.lblDecorazione.Name = "lblDecorazione";
            this.lblDecorazione.Size = new System.Drawing.Size(84, 16);
            this.lblDecorazione.TabIndex = 9;
            this.lblDecorazione.Text = "Decorazione";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(177, 135);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(44, 16);
            this.lblNome.TabIndex = 10;
            this.lblNome.Text = "Nome";
            // 
            // cmbFrolla
            // 
            this.cmbFrolla.FormattingEnabled = true;
            this.cmbFrolla.Location = new System.Drawing.Point(18, 37);
            this.cmbFrolla.Name = "cmbFrolla";
            this.cmbFrolla.Size = new System.Drawing.Size(121, 24);
            this.cmbFrolla.TabIndex = 11;
            // 
            // cmbMarmellata
            // 
            this.cmbMarmellata.FormattingEnabled = true;
            this.cmbMarmellata.Location = new System.Drawing.Point(180, 37);
            this.cmbMarmellata.Name = "cmbMarmellata";
            this.cmbMarmellata.Size = new System.Drawing.Size(121, 24);
            this.cmbMarmellata.TabIndex = 12;
            // 
            // txtTempoCottura
            // 
            this.txtTempoCottura.Location = new System.Drawing.Point(24, 106);
            this.txtTempoCottura.Name = "txtTempoCottura";
            this.txtTempoCottura.Size = new System.Drawing.Size(100, 22);
            this.txtTempoCottura.TabIndex = 13;
            this.txtTempoCottura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTempoCottura_KeyPress);
            // 
            // txtDiametro
            // 
            this.txtDiametro.Location = new System.Drawing.Point(180, 106);
            this.txtDiametro.Name = "txtDiametro";
            this.txtDiametro.Size = new System.Drawing.Size(100, 22);
            this.txtDiametro.TabIndex = 14;
            this.txtDiametro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiametro_KeyPress);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(180, 154);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 22);
            this.txtNome.TabIndex = 15;
            // 
            // rdbT
            // 
            this.rdbT.AutoSize = true;
            this.rdbT.Location = new System.Drawing.Point(18, 156);
            this.rdbT.Name = "rdbT";
            this.rdbT.Size = new System.Drawing.Size(40, 20);
            this.rdbT.TabIndex = 16;
            this.rdbT.TabStop = true;
            this.rdbT.Text = "SI";
            this.rdbT.UseVisualStyleBackColor = true;
            // 
            // rdbF
            // 
            this.rdbF.AutoSize = true;
            this.rdbF.Location = new System.Drawing.Point(18, 182);
            this.rdbF.Name = "rdbF";
            this.rdbF.Size = new System.Drawing.Size(48, 20);
            this.rdbF.TabIndex = 17;
            this.rdbF.TabStop = true;
            this.rdbF.Text = "NO";
            this.rdbF.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SandyBrown;
            this.panel2.Controls.Add(this.lblFrolla);
            this.panel2.Controls.Add(this.rdbF);
            this.panel2.Controls.Add(this.lblMarmellata);
            this.panel2.Controls.Add(this.rdbT);
            this.panel2.Controls.Add(this.lblCottura);
            this.panel2.Controls.Add(this.txtNome);
            this.panel2.Controls.Add(this.lblDiametro);
            this.panel2.Controls.Add(this.txtDiametro);
            this.panel2.Controls.Add(this.lblDecorazione);
            this.panel2.Controls.Add(this.txtTempoCottura);
            this.panel2.Controls.Add(this.lblNome);
            this.panel2.Controls.Add(this.cmbMarmellata);
            this.panel2.Controls.Add(this.cmbFrolla);
            this.panel2.Location = new System.Drawing.Point(618, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(315, 241);
            this.panel2.TabIndex = 18;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(312, 390);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 50);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSsave_Click);
            // 
            // btnRicerca
            // 
            this.btnRicerca.Location = new System.Drawing.Point(162, 390);
            this.btnRicerca.Name = "btnRicerca";
            this.btnRicerca.Size = new System.Drawing.Size(100, 50);
            this.btnRicerca.TabIndex = 19;
            this.btnRicerca.Text = "RICERCA";
            this.btnRicerca.UseVisualStyleBackColor = true;
            this.btnRicerca.Click += new System.EventHandler(this.btnRicerca_Click);
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.Location = new System.Drawing.Point(713, 288);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(100, 50);
            this.btnAggiungi.TabIndex = 21;
            this.btnAggiungi.Text = "AGGIUNGI";
            this.btnAggiungi.UseVisualStyleBackColor = true;
            this.btnAggiungi.Click += new System.EventHandler(this.btnAggiungi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(966, 491);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAggiungi);
            this.Controls.Add(this.btnRicerca);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblEtichetta);
            this.Controls.Add(this.lstElenco);
            this.Controls.Add(this.lblTitolo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitolo;
        private System.Windows.Forms.ListBox lstElenco;
        private System.Windows.Forms.Label lblEtichetta;
        private System.Windows.Forms.Label lblFrolla;
        private System.Windows.Forms.Label lblMarmellata;
        private System.Windows.Forms.Label lblCottura;
        private System.Windows.Forms.Label lblDiametro;
        private System.Windows.Forms.Label lblDecorazione;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.ComboBox cmbFrolla;
        private System.Windows.Forms.ComboBox cmbMarmellata;
        private System.Windows.Forms.TextBox txtTempoCottura;
        private System.Windows.Forms.TextBox txtDiametro;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.RadioButton rdbT;
        private System.Windows.Forms.RadioButton rdbF;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRicerca;
        private System.Windows.Forms.Button btnAggiungi;
    }
}

