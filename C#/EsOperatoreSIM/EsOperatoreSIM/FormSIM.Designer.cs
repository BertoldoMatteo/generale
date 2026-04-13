namespace EsOperatoreSIM
{
    partial class FormSIM
    {
        private System.ComponentModel.IContainer components = null;

        private void InitializeComponent()
        {
            this.grpCrea = new System.Windows.Forms.GroupBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblCredito = new System.Windows.Forms.Label();
            this.txtCredito = new System.Windows.Forms.TextBox();
            this.btnCreaSIM = new System.Windows.Forms.Button();
            this.grpTelefonata = new System.Windows.Forms.GroupBox();
            this.lblDest = new System.Windows.Forms.Label();
            this.txtDest = new System.Windows.Forms.TextBox();
            this.lblDurata = new System.Windows.Forms.Label();
            this.txtDurata = new System.Windows.Forms.TextBox();
            this.btnAggiungi = new System.Windows.Forms.Button();
            this.grpCerca = new System.Windows.Forms.GroupBox();
            this.lblCercaNumero = new System.Windows.Forms.Label();
            this.txtCercaNumero = new System.Windows.Forms.TextBox();
            this.btnCerca = new System.Windows.Forms.Button();
            this.btnStampa = new System.Windows.Forms.Button();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.grpCrea.SuspendLayout();
            this.grpTelefonata.SuspendLayout();
            this.grpCerca.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCrea
            // 
            this.grpCrea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(230)))), ((int)(((byte)(210)))));
            this.grpCrea.Controls.Add(this.lblNumero);
            this.grpCrea.Controls.Add(this.txtNumero);
            this.grpCrea.Controls.Add(this.lblCredito);
            this.grpCrea.Controls.Add(this.txtCredito);
            this.grpCrea.Controls.Add(this.btnCreaSIM);
            this.grpCrea.ForeColor = System.Drawing.Color.DarkGreen;
            this.grpCrea.Location = new System.Drawing.Point(12, 12);
            this.grpCrea.Name = "grpCrea";
            this.grpCrea.Size = new System.Drawing.Size(580, 90);
            this.grpCrea.TabIndex = 0;
            this.grpCrea.TabStop = false;
            this.grpCrea.Text = "1. Crea SIM";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(12, 35);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(58, 16);
            this.lblNumero.TabIndex = 0;
            this.lblNumero.Text = "Numero:";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(80, 32);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(140, 22);
            this.txtNumero.TabIndex = 1;
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
            // 
            // lblCredito
            // 
            this.lblCredito.AutoSize = true;
            this.lblCredito.Location = new System.Drawing.Point(240, 35);
            this.lblCredito.Name = "lblCredito";
            this.lblCredito.Size = new System.Drawing.Size(71, 16);
            this.lblCredito.TabIndex = 2;
            this.lblCredito.Text = "Credito (€):";
            // 
            // txtCredito
            // 
            this.txtCredito.Location = new System.Drawing.Point(325, 32);
            this.txtCredito.Name = "txtCredito";
            this.txtCredito.Size = new System.Drawing.Size(80, 22);
            this.txtCredito.TabIndex = 3;
            // 
            // btnCreaSIM
            // 
            this.btnCreaSIM.BackColor = System.Drawing.Color.ForestGreen;
            this.btnCreaSIM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreaSIM.ForeColor = System.Drawing.Color.White;
            this.btnCreaSIM.Location = new System.Drawing.Point(430, 28);
            this.btnCreaSIM.Name = "btnCreaSIM";
            this.btnCreaSIM.Size = new System.Drawing.Size(120, 35);
            this.btnCreaSIM.TabIndex = 4;
            this.btnCreaSIM.Text = "Crea SIM";
            this.btnCreaSIM.UseVisualStyleBackColor = false;
            this.btnCreaSIM.Click += new System.EventHandler(this.BtnCreaSIM_Click);
            // 
            // grpTelefonata
            // 
            this.grpTelefonata.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(230)))), ((int)(((byte)(210)))));
            this.grpTelefonata.Controls.Add(this.lblDest);
            this.grpTelefonata.Controls.Add(this.txtDest);
            this.grpTelefonata.Controls.Add(this.lblDurata);
            this.grpTelefonata.Controls.Add(this.txtDurata);
            this.grpTelefonata.Controls.Add(this.btnAggiungi);
            this.grpTelefonata.Enabled = false;
            this.grpTelefonata.ForeColor = System.Drawing.Color.DarkGreen;
            this.grpTelefonata.Location = new System.Drawing.Point(12, 115);
            this.grpTelefonata.Name = "grpTelefonata";
            this.grpTelefonata.Size = new System.Drawing.Size(580, 90);
            this.grpTelefonata.TabIndex = 1;
            this.grpTelefonata.TabStop = false;
            this.grpTelefonata.Text = "2. Registra Telefonata";
            // 
            // lblDest
            // 
            this.lblDest.AutoSize = true;
            this.lblDest.Location = new System.Drawing.Point(12, 35);
            this.lblDest.Name = "lblDest";
            this.lblDest.Size = new System.Drawing.Size(82, 16);
            this.lblDest.TabIndex = 0;
            this.lblDest.Text = "Destinatario:";
            // 
            // txtDest
            // 
            this.txtDest.Location = new System.Drawing.Point(100, 32);
            this.txtDest.Name = "txtDest";
            this.txtDest.Size = new System.Drawing.Size(140, 22);
            this.txtDest.TabIndex = 1;
            this.txtDest.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDest_KeyPress_1);
            // 
            // lblDurata
            // 
            this.lblDurata.AutoSize = true;
            this.lblDurata.Location = new System.Drawing.Point(260, 35);
            this.lblDurata.Name = "lblDurata";
            this.lblDurata.Size = new System.Drawing.Size(82, 16);
            this.lblDurata.TabIndex = 2;
            this.lblDurata.Text = "Durata (min):";
            // 
            // txtDurata
            // 
            this.txtDurata.Location = new System.Drawing.Point(355, 32);
            this.txtDurata.Name = "txtDurata";
            this.txtDurata.Size = new System.Drawing.Size(60, 22);
            this.txtDurata.TabIndex = 3;
            this.txtDurata.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDurata_KeyPress);
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAggiungi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAggiungi.ForeColor = System.Drawing.Color.White;
            this.btnAggiungi.Location = new System.Drawing.Point(440, 28);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(110, 35);
            this.btnAggiungi.TabIndex = 4;
            this.btnAggiungi.Text = "Aggiungi";
            this.btnAggiungi.UseVisualStyleBackColor = false;
            this.btnAggiungi.Click += new System.EventHandler(this.BtnAggiungi_Click);
            // 
            // grpCerca
            // 
            this.grpCerca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(230)))), ((int)(((byte)(210)))));
            this.grpCerca.Controls.Add(this.lblCercaNumero);
            this.grpCerca.Controls.Add(this.txtCercaNumero);
            this.grpCerca.Controls.Add(this.btnCerca);
            this.grpCerca.Enabled = false;
            this.grpCerca.ForeColor = System.Drawing.Color.DarkGreen;
            this.grpCerca.Location = new System.Drawing.Point(12, 218);
            this.grpCerca.Name = "grpCerca";
            this.grpCerca.Size = new System.Drawing.Size(580, 80);
            this.grpCerca.TabIndex = 2;
            this.grpCerca.TabStop = false;
            this.grpCerca.Text = "3. Ricerca Chiamate";
            // 
            // lblCercaNumero
            // 
            this.lblCercaNumero.AutoSize = true;
            this.lblCercaNumero.Location = new System.Drawing.Point(12, 35);
            this.lblCercaNumero.Name = "lblCercaNumero";
            this.lblCercaNumero.Size = new System.Drawing.Size(126, 16);
            this.lblCercaNumero.TabIndex = 0;
            this.lblCercaNumero.Text = "Numero da cercare:";
            // 
            // txtCercaNumero
            // 
            this.txtCercaNumero.Location = new System.Drawing.Point(135, 32);
            this.txtCercaNumero.Name = "txtCercaNumero";
            this.txtCercaNumero.Size = new System.Drawing.Size(140, 22);
            this.txtCercaNumero.TabIndex = 1;
            this.txtCercaNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCercaNumero_KeyPress);
            // 
            // btnCerca
            // 
            this.btnCerca.BackColor = System.Drawing.Color.ForestGreen;
            this.btnCerca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerca.ForeColor = System.Drawing.Color.White;
            this.btnCerca.Location = new System.Drawing.Point(290, 28);
            this.btnCerca.Name = "btnCerca";
            this.btnCerca.Size = new System.Drawing.Size(100, 35);
            this.btnCerca.TabIndex = 2;
            this.btnCerca.Text = "Cerca";
            this.btnCerca.UseVisualStyleBackColor = false;
            this.btnCerca.Click += new System.EventHandler(this.BtnCerca_Click);
            // 
            // btnStampa
            // 
            this.btnStampa.BackColor = System.Drawing.Color.DarkGreen;
            this.btnStampa.Enabled = false;
            this.btnStampa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStampa.ForeColor = System.Drawing.Color.White;
            this.btnStampa.Location = new System.Drawing.Point(12, 312);
            this.btnStampa.Name = "btnStampa";
            this.btnStampa.Size = new System.Drawing.Size(580, 40);
            this.btnStampa.TabIndex = 3;
            this.btnStampa.Text = "STAMPA RIEPILOGO COMPLETO";
            this.btnStampa.UseVisualStyleBackColor = false;
            this.btnStampa.Click += new System.EventHandler(this.BtnStampa_Click);
            // 
            // rtbOutput
            // 
            this.rtbOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(230)))), ((int)(((byte)(210)))));
            this.rtbOutput.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rtbOutput.Location = new System.Drawing.Point(12, 365);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.ReadOnly = true;
            this.rtbOutput.Size = new System.Drawing.Size(580, 270);
            this.rtbOutput.TabIndex = 4;
            this.rtbOutput.Text = "";
            // 
            // FormSIM
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(604, 651);
            this.Controls.Add(this.grpCrea);
            this.Controls.Add(this.grpTelefonata);
            this.Controls.Add(this.grpCerca);
            this.Controls.Add(this.btnStampa);
            this.Controls.Add(this.rtbOutput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormSIM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestione SIM - Operatore Telefonico";
            this.grpCrea.ResumeLayout(false);
            this.grpCrea.PerformLayout();
            this.grpTelefonata.ResumeLayout(false);
            this.grpTelefonata.PerformLayout();
            this.grpCerca.ResumeLayout(false);
            this.grpCerca.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.GroupBox grpCrea;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblCredito;
        private System.Windows.Forms.TextBox txtCredito;
        private System.Windows.Forms.Button btnCreaSIM;
        private System.Windows.Forms.GroupBox grpTelefonata;
        private System.Windows.Forms.Label lblDest;
        private System.Windows.Forms.TextBox txtDest;
        private System.Windows.Forms.Label lblDurata;
        private System.Windows.Forms.TextBox txtDurata;
        private System.Windows.Forms.Button btnAggiungi;
        private System.Windows.Forms.GroupBox grpCerca;
        private System.Windows.Forms.Label lblCercaNumero;
        private System.Windows.Forms.TextBox txtCercaNumero;
        private System.Windows.Forms.Button btnCerca;
        private System.Windows.Forms.Button btnStampa;
        private System.Windows.Forms.RichTextBox rtbOutput;
    }
}