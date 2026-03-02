namespace EsPuffiBM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPunti = new System.Windows.Forms.TextBox();
            this.txtPunt = new System.Windows.Forms.TextBox();
            this.pnlCasa = new System.Windows.Forms.Panel();
            this.pnlPuffo = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblW = new System.Windows.Forms.Label();
            this.lblS = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblD = new System.Windows.Forms.Label();
            this.pnlLegenda = new System.Windows.Forms.Panel();
            this.btnLegenda = new System.Windows.Forms.Button();
            this.lblIstruzioni = new System.Windows.Forms.Label();
            this.btnIstruzioni = new System.Windows.Forms.Button();
            this.pnlAvvia = new System.Windows.Forms.Panel();
            this.btnAvvia = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnlLegenda.SuspendLayout();
            this.pnlAvvia.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtPunti);
            this.panel1.Controls.Add(this.txtPunt);
            this.panel1.Controls.Add(this.pnlCasa);
            this.panel1.Controls.Add(this.pnlPuffo);
            this.panel1.Location = new System.Drawing.Point(37, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(671, 302);
            this.panel1.TabIndex = 0;
            // 
            // txtPunti
            // 
            this.txtPunti.Location = new System.Drawing.Point(596, 268);
            this.txtPunti.Name = "txtPunti";
            this.txtPunti.ReadOnly = true;
            this.txtPunti.Size = new System.Drawing.Size(57, 22);
            this.txtPunti.TabIndex = 3;
            // 
            // txtPunt
            // 
            this.txtPunt.Location = new System.Drawing.Point(477, 268);
            this.txtPunt.Name = "txtPunt";
            this.txtPunt.ReadOnly = true;
            this.txtPunt.Size = new System.Drawing.Size(113, 22);
            this.txtPunt.TabIndex = 2;
            this.txtPunt.Text = "PUNTEGGIO : ";
            // 
            // pnlCasa
            // 
            this.pnlCasa.BackColor = System.Drawing.Color.Transparent;
            this.pnlCasa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlCasa.BackgroundImage")));
            this.pnlCasa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlCasa.Location = new System.Drawing.Point(434, 58);
            this.pnlCasa.Name = "pnlCasa";
            this.pnlCasa.Size = new System.Drawing.Size(106, 100);
            this.pnlCasa.TabIndex = 1;
            // 
            // pnlPuffo
            // 
            this.pnlPuffo.BackColor = System.Drawing.Color.Transparent;
            this.pnlPuffo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlPuffo.BackgroundImage")));
            this.pnlPuffo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlPuffo.Location = new System.Drawing.Point(299, 89);
            this.pnlPuffo.Name = "pnlPuffo";
            this.pnlPuffo.Size = new System.Drawing.Size(74, 112);
            this.pnlPuffo.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("SuperFrench", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblTitle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTitle.Location = new System.Drawing.Point(232, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(291, 24);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "ADDESTRAMENTO PUFFI";
            // 
            // lblW
            // 
            this.lblW.AutoSize = true;
            this.lblW.Location = new System.Drawing.Point(-3, 0);
            this.lblW.Name = "lblW";
            this.lblW.Size = new System.Drawing.Size(131, 16);
            this.lblW.TabIndex = 4;
            this.lblW.Text = " W = VERSO L\'ALTO";
            // 
            // lblS
            // 
            this.lblS.AutoSize = true;
            this.lblS.Location = new System.Drawing.Point(-3, 16);
            this.lblS.Name = "lblS";
            this.lblS.Size = new System.Drawing.Size(141, 16);
            this.lblS.TabIndex = 5;
            this.lblS.Text = " S = VERSO IL BASSO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-3, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = " A = VERSO SINISTRA";
            // 
            // lblD
            // 
            this.lblD.AutoSize = true;
            this.lblD.Location = new System.Drawing.Point(-3, 32);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(139, 16);
            this.lblD.TabIndex = 7;
            this.lblD.Text = " D = VERSO DESTRA";
            // 
            // pnlLegenda
            // 
            this.pnlLegenda.Controls.Add(this.lblD);
            this.pnlLegenda.Controls.Add(this.lblW);
            this.pnlLegenda.Controls.Add(this.label1);
            this.pnlLegenda.Controls.Add(this.lblS);
            this.pnlLegenda.Location = new System.Drawing.Point(56, 384);
            this.pnlLegenda.Name = "pnlLegenda";
            this.pnlLegenda.Size = new System.Drawing.Size(149, 66);
            this.pnlLegenda.TabIndex = 8;
            this.pnlLegenda.Visible = false;
            // 
            // btnLegenda
            // 
            this.btnLegenda.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLegenda.FlatAppearance.BorderSize = 0;
            this.btnLegenda.Location = new System.Drawing.Point(86, 355);
            this.btnLegenda.Name = "btnLegenda";
            this.btnLegenda.Size = new System.Drawing.Size(94, 23);
            this.btnLegenda.TabIndex = 9;
            this.btnLegenda.Text = "LEGENDA";
            this.btnLegenda.UseVisualStyleBackColor = false;
            this.btnLegenda.Click += new System.EventHandler(this.btnLegenda_Click);
            // 
            // lblIstruzioni
            // 
            this.lblIstruzioni.AutoSize = true;
            this.lblIstruzioni.Location = new System.Drawing.Point(277, 384);
            this.lblIstruzioni.Name = "lblIstruzioni";
            this.lblIstruzioni.Size = new System.Drawing.Size(125, 32);
            this.lblIstruzioni.TabIndex = 10;
            this.lblIstruzioni.Text = "Raggiungi la casa \r\nper ottenere 1 punto\r\n";
            this.lblIstruzioni.Visible = false;
            // 
            // btnIstruzioni
            // 
            this.btnIstruzioni.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnIstruzioni.FlatAppearance.BorderSize = 0;
            this.btnIstruzioni.Location = new System.Drawing.Point(280, 355);
            this.btnIstruzioni.Name = "btnIstruzioni";
            this.btnIstruzioni.Size = new System.Drawing.Size(108, 23);
            this.btnIstruzioni.TabIndex = 11;
            this.btnIstruzioni.Text = "ISTRUZIONI";
            this.btnIstruzioni.UseVisualStyleBackColor = false;
            this.btnIstruzioni.Click += new System.EventHandler(this.btnIstruzioni_Click);
            // 
            // pnlAvvia
            // 
            this.pnlAvvia.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlAvvia.BackgroundImage")));
            this.pnlAvvia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlAvvia.Controls.Add(this.btnAvvia);
            this.pnlAvvia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAvvia.Location = new System.Drawing.Point(0, 0);
            this.pnlAvvia.Name = "pnlAvvia";
            this.pnlAvvia.Size = new System.Drawing.Size(800, 450);
            this.pnlAvvia.TabIndex = 12;
            // 
            // btnAvvia
            // 
            this.btnAvvia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAvvia.AutoSize = true;
            this.btnAvvia.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAvvia.Location = new System.Drawing.Point(354, 175);
            this.btnAvvia.Name = "btnAvvia";
            this.btnAvvia.Size = new System.Drawing.Size(75, 26);
            this.btnAvvia.TabIndex = 0;
            this.btnAvvia.Text = "AVVIA";
            this.btnAvvia.UseVisualStyleBackColor = false;
            this.btnAvvia.Click += new System.EventHandler(this.btnAvvia_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlAvvia);
            this.Controls.Add(this.btnIstruzioni);
            this.Controls.Add(this.lblIstruzioni);
            this.Controls.Add(this.btnLegenda);
            this.Controls.Add(this.pnlLegenda);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlLegenda.ResumeLayout(false);
            this.pnlLegenda.PerformLayout();
            this.pnlAvvia.ResumeLayout(false);
            this.pnlAvvia.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel pnlPuffo;
        private System.Windows.Forms.Panel pnlCasa;
        private System.Windows.Forms.TextBox txtPunt;
        private System.Windows.Forms.TextBox txtPunti;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblW;
        private System.Windows.Forms.Label lblS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblD;
        private System.Windows.Forms.Panel pnlLegenda;
        private System.Windows.Forms.Button btnLegenda;
        private System.Windows.Forms.Label lblIstruzioni;
        private System.Windows.Forms.Button btnIstruzioni;
        private System.Windows.Forms.Panel pnlAvvia;
        private System.Windows.Forms.Button btnAvvia;
    }
}

