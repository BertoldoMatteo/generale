namespace EsCampoMinato
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlReset = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.btnBandiera = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnResetTotale = new System.Windows.Forms.Button();
            this.btnStat = new System.Windows.Forms.Button();
            this.btnAiuto = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPunt = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCelleRim = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMod = new System.Windows.Forms.Label();
            this.dtG = new System.Windows.Forms.DataGridView();
            this.tmr1 = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.lblTempo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblMineRim = new System.Windows.Forms.Label();
            this.pnlReset.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtG)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(48, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "CAMPO MINATO";
            // 
            // pnlReset
            // 
            this.pnlReset.BackColor = System.Drawing.Color.LightGray;
            this.pnlReset.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlReset.Controls.Add(this.btnReset);
            this.pnlReset.Location = new System.Drawing.Point(48, 254);
            this.pnlReset.Margin = new System.Windows.Forms.Padding(4);
            this.pnlReset.Name = "pnlReset";
            this.pnlReset.Size = new System.Drawing.Size(612, 67);
            this.pnlReset.TabIndex = 2;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.LightGray;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(251, 0);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(125, 59);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "ARRENDITI";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnArreso_Click);
            // 
            // btnMod
            // 
            this.btnMod.BackColor = System.Drawing.Color.LightGray;
            this.btnMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMod.Location = new System.Drawing.Point(4, 4);
            this.btnMod.Margin = new System.Windows.Forms.Padding(4);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(120, 49);
            this.btnMod.TabIndex = 6;
            this.btnMod.Text = "MODALITA\'";
            this.btnMod.UseVisualStyleBackColor = false;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // btnBandiera
            // 
            this.btnBandiera.BackColor = System.Drawing.Color.LightGray;
            this.btnBandiera.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBandiera.Location = new System.Drawing.Point(132, 4);
            this.btnBandiera.Margin = new System.Windows.Forms.Padding(4);
            this.btnBandiera.Name = "btnBandiera";
            this.btnBandiera.Size = new System.Drawing.Size(120, 49);
            this.btnBandiera.TabIndex = 7;
            this.btnBandiera.Text = "BANDIERA";
            this.btnBandiera.UseVisualStyleBackColor = false;
            this.btnBandiera.Click += new System.EventHandler(this.btnBandiera_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.LightGray;
            this.flowLayoutPanel1.Controls.Add(this.btnMod);
            this.flowLayoutPanel1.Controls.Add(this.btnBandiera);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(48, 129);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(366, 62);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.LightGray;
            this.flowLayoutPanel2.Controls.Add(this.btnResetTotale);
            this.flowLayoutPanel2.Controls.Add(this.btnStat);
            this.flowLayoutPanel2.Controls.Add(this.btnAiuto);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(48, 54);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(366, 57);
            this.flowLayoutPanel2.TabIndex = 11;
            // 
            // btnResetTotale
            // 
            this.btnResetTotale.BackColor = System.Drawing.Color.LightGray;
            this.btnResetTotale.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetTotale.Location = new System.Drawing.Point(4, 4);
            this.btnResetTotale.Margin = new System.Windows.Forms.Padding(4);
            this.btnResetTotale.Name = "btnResetTotale";
            this.btnResetTotale.Size = new System.Drawing.Size(141, 43);
            this.btnResetTotale.TabIndex = 12;
            this.btnResetTotale.Text = "RESET TOTALE";
            this.btnResetTotale.UseVisualStyleBackColor = false;
            this.btnResetTotale.Click += new System.EventHandler(this.btnResetTotale_Click);
            // 
            // btnStat
            // 
            this.btnStat.BackColor = System.Drawing.Color.LightGray;
            this.btnStat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStat.Location = new System.Drawing.Point(153, 4);
            this.btnStat.Margin = new System.Windows.Forms.Padding(4);
            this.btnStat.Name = "btnStat";
            this.btnStat.Size = new System.Drawing.Size(113, 43);
            this.btnStat.TabIndex = 14;
            this.btnStat.Text = "STATISTICHE";
            this.btnStat.UseVisualStyleBackColor = false;
            this.btnStat.Click += new System.EventHandler(this.btnStat_Click);
            // 
            // btnAiuto
            // 
            this.btnAiuto.BackColor = System.Drawing.Color.LightGray;
            this.btnAiuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAiuto.Location = new System.Drawing.Point(274, 4);
            this.btnAiuto.Margin = new System.Windows.Forms.Padding(4);
            this.btnAiuto.Name = "btnAiuto";
            this.btnAiuto.Size = new System.Drawing.Size(83, 43);
            this.btnAiuto.TabIndex = 15;
            this.btnAiuto.Text = "AIUTO";
            this.btnAiuto.UseVisualStyleBackColor = false;
            this.btnAiuto.Click += new System.EventHandler(this.btnAiuto_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(550, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "PUNTEGGIO: ";
            // 
            // lblPunt
            // 
            this.lblPunt.BackColor = System.Drawing.Color.Black;
            this.lblPunt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPunt.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPunt.ForeColor = System.Drawing.Color.Red;
            this.lblPunt.Location = new System.Drawing.Point(710, 18);
            this.lblPunt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPunt.Name = "lblPunt";
            this.lblPunt.Size = new System.Drawing.Size(80, 31);
            this.lblPunt.TabIndex = 13;
            this.lblPunt.Text = "000";
            this.lblPunt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(550, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "CELLE RIMASTE:";
            // 
            // lblCelleRim
            // 
            this.lblCelleRim.BackColor = System.Drawing.Color.Black;
            this.lblCelleRim.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCelleRim.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelleRim.ForeColor = System.Drawing.Color.Red;
            this.lblCelleRim.Location = new System.Drawing.Point(710, 61);
            this.lblCelleRim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCelleRim.Name = "lblCelleRim";
            this.lblCelleRim.Size = new System.Drawing.Size(80, 31);
            this.lblCelleRim.TabIndex = 15;
            this.lblCelleRim.Text = "000";
            this.lblCelleRim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(550, 195);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "MODALITA\':";
            // 
            // lblMod
            // 
            this.lblMod.BackColor = System.Drawing.Color.Black;
            this.lblMod.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMod.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMod.ForeColor = System.Drawing.Color.Lime;
            this.lblMod.Location = new System.Drawing.Point(710, 189);
            this.lblMod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMod.Name = "lblMod";
            this.lblMod.Size = new System.Drawing.Size(160, 31);
            this.lblMod.TabIndex = 17;
            this.lblMod.Text = "NORMALE";
            this.lblMod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtG
            // 
            this.dtG.AllowUserToAddRows = false;
            this.dtG.AllowUserToDeleteRows = false;
            this.dtG.AllowUserToResizeColumns = false;
            this.dtG.AllowUserToResizeRows = false;
            this.dtG.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dtG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtG.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dtG.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtG.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtG.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtG.GridColor = System.Drawing.Color.White;
            this.dtG.Location = new System.Drawing.Point(48, 336);
            this.dtG.Margin = new System.Windows.Forms.Padding(4);
            this.dtG.MultiSelect = false;
            this.dtG.Name = "dtG";
            this.dtG.ReadOnly = true;
            this.dtG.RowHeadersVisible = false;
            this.dtG.RowHeadersWidth = 51;
            this.dtG.RowTemplate.Height = 24;
            this.dtG.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dtG.Size = new System.Drawing.Size(400, 369);
            this.dtG.TabIndex = 1;
            this.dtG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtG_CellClick);
            this.dtG.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtG_CellMouseClick);
            // 
            // tmr1
            // 
            this.tmr1.Tick += new System.EventHandler(this.tmr1_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(550, 154);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "TEMPO:";
            // 
            // lblTempo
            // 
            this.lblTempo.BackColor = System.Drawing.Color.Black;
            this.lblTempo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTempo.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempo.ForeColor = System.Drawing.Color.Red;
            this.lblTempo.Location = new System.Drawing.Point(710, 146);
            this.lblTempo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(80, 31);
            this.lblTempo.TabIndex = 19;
            this.lblTempo.Text = "000";
            this.lblTempo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(550, 110);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "MINE RIMASTE:";
            // 
            // lblMineRim
            // 
            this.lblMineRim.BackColor = System.Drawing.Color.Black;
            this.lblMineRim.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMineRim.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMineRim.ForeColor = System.Drawing.Color.Red;
            this.lblMineRim.Location = new System.Drawing.Point(710, 102);
            this.lblMineRim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMineRim.Name = "lblMineRim";
            this.lblMineRim.Size = new System.Drawing.Size(80, 31);
            this.lblMineRim.TabIndex = 21;
            this.lblMineRim.Text = "000";
            this.lblMineRim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1067, 738);
            this.Controls.Add(this.lblMineRim);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblTempo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtG);
            this.Controls.Add(this.lblMod);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCelleRim);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPunt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pnlReset);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Campo Minato";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlReset.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlReset;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Button btnBandiera;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnResetTotale;
        private System.Windows.Forms.Button btnStat;
        private System.Windows.Forms.Button btnAiuto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPunt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCelleRim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMod;
        private System.Windows.Forms.DataGridView dtG;
        private System.Windows.Forms.Timer tmr1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTempo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblMineRim;
    }
}