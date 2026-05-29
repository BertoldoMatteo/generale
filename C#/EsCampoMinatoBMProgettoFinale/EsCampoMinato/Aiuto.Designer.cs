namespace EsCampoMinato
{
    partial class Aiuto
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Aiuto));
            this.lblTitolo = new System.Windows.Forms.Label();
            this.grpRegole = new System.Windows.Forms.GroupBox();
            this.lblRegoleTesto = new System.Windows.Forms.Label();
            this.grpTasti = new System.Windows.Forms.GroupBox();
            this.lblTastiTesto = new System.Windows.Forms.Label();
            this.grpDiff = new System.Windows.Forms.GroupBox();
            this.lblDiffTesto = new System.Windows.Forms.Label();
            this.btnChiudi = new System.Windows.Forms.Button();
            this.grpRegole.SuspendLayout();
            this.grpTasti.SuspendLayout();
            this.grpDiff.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitolo
            // 
            this.lblTitolo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(158)))));
            this.lblTitolo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitolo.ForeColor = System.Drawing.Color.White;
            this.lblTitolo.Location = new System.Drawing.Point(0, 0);
            this.lblTitolo.Name = "lblTitolo";
            this.lblTitolo.Size = new System.Drawing.Size(700, 45);
            this.lblTitolo.TabIndex = 0;
            this.lblTitolo.Text = "  CAMPO MINATO";
            this.lblTitolo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpRegole
            // 
            this.grpRegole.Controls.Add(this.lblRegoleTesto);
            this.grpRegole.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpRegole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(158)))));
            this.grpRegole.Location = new System.Drawing.Point(15, 55);
            this.grpRegole.Name = "grpRegole";
            this.grpRegole.Size = new System.Drawing.Size(330, 190);
            this.grpRegole.TabIndex = 1;
            this.grpRegole.TabStop = false;
            this.grpRegole.Text = "REGOLE";
            // 
            // lblRegoleTesto
            // 
            this.lblRegoleTesto.AutoSize = true;
            this.lblRegoleTesto.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblRegoleTesto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblRegoleTesto.Location = new System.Drawing.Point(15, 28);
            this.lblRegoleTesto.MaximumSize = new System.Drawing.Size(290, 0);
            this.lblRegoleTesto.Name = "lblRegoleTesto";
            this.lblRegoleTesto.Size = new System.Drawing.Size(267, 161);
            this.lblRegoleTesto.TabIndex = 0;
            this.lblRegoleTesto.Text = resources.GetString("lblRegoleTesto.Text");
            // 
            // grpTasti
            // 
            this.grpTasti.Controls.Add(this.lblTastiTesto);
            this.grpTasti.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpTasti.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(158)))));
            this.grpTasti.Location = new System.Drawing.Point(360, 55);
            this.grpTasti.Name = "grpTasti";
            this.grpTasti.Size = new System.Drawing.Size(325, 375);
            this.grpTasti.TabIndex = 3;
            this.grpTasti.TabStop = false;
            this.grpTasti.Text = "TASTI";
            // 
            // lblTastiTesto
            // 
            this.lblTastiTesto.AutoSize = true;
            this.lblTastiTesto.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTastiTesto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblTastiTesto.Location = new System.Drawing.Point(15, 28);
            this.lblTastiTesto.MaximumSize = new System.Drawing.Size(290, 0);
            this.lblTastiTesto.Name = "lblTastiTesto";
            this.lblTastiTesto.Size = new System.Drawing.Size(251, 184);
            this.lblTastiTesto.TabIndex = 0;
            this.lblTastiTesto.Text = "• Click SINISTRO: apre la cella\r\n• Click DESTRO: mette bandiera\r\n• BANDIERA: modalità bandiera\r\n" +
                "• RESET TOTALE: Reset campo e statistiche\r\n• STATISTICHE: statistiche di gioco\r\n• MODALITA': scegli difficoltà\r\n• BANDIERA: piazzare bandiere\r\n" +
                "• RESET : Arrendersi";
            // 
            // grpDiff
            // 
            this.grpDiff.Controls.Add(this.lblDiffTesto);
            this.grpDiff.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpDiff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(158)))));
            this.grpDiff.Location = new System.Drawing.Point(15, 260);
            this.grpDiff.Name = "grpDiff";
            this.grpDiff.Size = new System.Drawing.Size(330, 170);
            this.grpDiff.TabIndex = 2;
            this.grpDiff.TabStop = false;
            this.grpDiff.Text = "DIFFICOLTÀ";
            // 
            // lblDiffTesto
            // 
            this.lblDiffTesto.AutoSize = true;
            this.lblDiffTesto.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDiffTesto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblDiffTesto.Location = new System.Drawing.Point(15, 28);
            this.lblDiffTesto.MaximumSize = new System.Drawing.Size(290, 0);
            this.lblDiffTesto.Name = "lblDiffTesto";
            this.lblDiffTesto.Size = new System.Drawing.Size(270, 138);
            this.lblDiffTesto.TabIndex = 0;
            this.lblDiffTesto.Text = "• PRINCIPIANTE: 9×9, 10 mine\r\n• INTERMEDIO: 16×16, 40 mine\r\n• AVANZATO: 30×30, 99" +
    " mine\r\n• SUPER UOMO: 50×50, 500 mine\r\n• EXTRATERRESTRE: 100×100, 999 mine";
            // 
            // btnChiudi
            // 
            this.btnChiudi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(158)))));
            this.btnChiudi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChiudi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnChiudi.ForeColor = System.Drawing.Color.White;
            this.btnChiudi.Location = new System.Drawing.Point(300, 450);
            this.btnChiudi.Name = "btnChiudi";
            this.btnChiudi.Size = new System.Drawing.Size(100, 35);
            this.btnChiudi.TabIndex = 4;
            this.btnChiudi.Text = "Chiudi";
            this.btnChiudi.UseVisualStyleBackColor = false;
            this.btnChiudi.Click += new System.EventHandler(this.btnChiudi_Click);
            // 
            // Aiuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(700, 505);
            this.Controls.Add(this.lblTitolo);
            this.Controls.Add(this.grpRegole);
            this.Controls.Add(this.grpDiff);
            this.Controls.Add(this.grpTasti);
            this.Controls.Add(this.btnChiudi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Aiuto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Aiuto - Campo Minato 95";
            this.grpRegole.ResumeLayout(false);
            this.grpRegole.PerformLayout();
            this.grpTasti.ResumeLayout(false);
            this.grpTasti.PerformLayout();
            this.grpDiff.ResumeLayout(false);
            this.grpDiff.PerformLayout();
            this.ResumeLayout(false);

        }

        private void btnChiudi_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private System.Windows.Forms.Label lblTitolo;
        private System.Windows.Forms.GroupBox grpRegole;
        private System.Windows.Forms.Label lblRegoleTesto;
        private System.Windows.Forms.GroupBox grpTasti;
        private System.Windows.Forms.Label lblTastiTesto;
        private System.Windows.Forms.GroupBox grpDiff;
        private System.Windows.Forms.Label lblDiffTesto;
        private System.Windows.Forms.Button btnChiudi;
    }
}
