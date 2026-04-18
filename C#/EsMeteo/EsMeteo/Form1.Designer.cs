namespace EsMeteo
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
            this.label1 = new System.Windows.Forms.Label();
            this.grpIgrometro = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtUmidità = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.grpTERMOMETRO = new System.Windows.Forms.GroupBox();
            this.txtTemp3 = new System.Windows.Forms.TextBox();
            this.txtTemp2 = new System.Windows.Forms.TextBox();
            this.txtTemp1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTemp0 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grpBAROMETRO = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPressione = new System.Windows.Forms.TextBox();
            this.grpPluviometro = new System.Windows.Forms.GroupBox();
            this.txtPioggia = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.grpAnemometro = new System.Windows.Forms.GroupBox();
            this.txtVento = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnCreaStaz = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.lstStazioni = new System.Windows.Forms.ListBox();
            this.label13 = new System.Windows.Forms.Label();
            this.rctInfo = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pctImg = new System.Windows.Forms.PictureBox();
            this.grpIgrometro.SuspendLayout();
            this.grpTERMOMETRO.SuspendLayout();
            this.grpBAROMETRO.SuspendLayout();
            this.grpPluviometro.SuspendLayout();
            this.grpAnemometro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctImg)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "STAZIONE METEO";
            // 
            // grpIgrometro
            // 
            this.grpIgrometro.BackColor = System.Drawing.Color.IndianRed;
            this.grpIgrometro.Controls.Add(this.label11);
            this.grpIgrometro.Controls.Add(this.txtUmidità);
            this.grpIgrometro.Controls.Add(this.label10);
            this.grpIgrometro.Location = new System.Drawing.Point(224, 64);
            this.grpIgrometro.Name = "grpIgrometro";
            this.grpIgrometro.Size = new System.Drawing.Size(189, 102);
            this.grpIgrometro.TabIndex = 3;
            this.grpIgrometro.TabStop = false;
            this.grpIgrometro.Text = "IGROMETRO";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 18);
            this.label11.TabIndex = 18;
            this.label11.Text = "12:00";
            // 
            // txtUmidità
            // 
            this.txtUmidità.Location = new System.Drawing.Point(52, 56);
            this.txtUmidità.Name = "txtUmidità";
            this.txtUmidità.Size = new System.Drawing.Size(131, 26);
            this.txtUmidità.TabIndex = 12;
            this.txtUmidità.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUmidità_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(47, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 18);
            this.label10.TabIndex = 11;
            this.label10.Text = "UMIDITA\' (%)";
            // 
            // grpTERMOMETRO
            // 
            this.grpTERMOMETRO.BackColor = System.Drawing.Color.IndianRed;
            this.grpTERMOMETRO.Controls.Add(this.txtTemp3);
            this.grpTERMOMETRO.Controls.Add(this.txtTemp2);
            this.grpTERMOMETRO.Controls.Add(this.txtTemp1);
            this.grpTERMOMETRO.Controls.Add(this.label8);
            this.grpTERMOMETRO.Controls.Add(this.label7);
            this.grpTERMOMETRO.Controls.Add(this.label6);
            this.grpTERMOMETRO.Controls.Add(this.label5);
            this.grpTERMOMETRO.Controls.Add(this.txtTemp0);
            this.grpTERMOMETRO.Controls.Add(this.label4);
            this.grpTERMOMETRO.Location = new System.Drawing.Point(12, 172);
            this.grpTERMOMETRO.Name = "grpTERMOMETRO";
            this.grpTERMOMETRO.Size = new System.Drawing.Size(203, 176);
            this.grpTERMOMETRO.TabIndex = 4;
            this.grpTERMOMETRO.TabStop = false;
            this.grpTERMOMETRO.Text = "TERMOMETRO";
            // 
            // txtTemp3
            // 
            this.txtTemp3.Location = new System.Drawing.Point(50, 142);
            this.txtTemp3.Name = "txtTemp3";
            this.txtTemp3.Size = new System.Drawing.Size(131, 26);
            this.txtTemp3.TabIndex = 17;
            this.txtTemp3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTemp3_KeyPress);
            // 
            // txtTemp2
            // 
            this.txtTemp2.Location = new System.Drawing.Point(49, 110);
            this.txtTemp2.Name = "txtTemp2";
            this.txtTemp2.Size = new System.Drawing.Size(131, 26);
            this.txtTemp2.TabIndex = 16;
            this.txtTemp2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTemp2_KeyPress);
            // 
            // txtTemp1
            // 
            this.txtTemp1.Location = new System.Drawing.Point(50, 79);
            this.txtTemp1.Name = "txtTemp1";
            this.txtTemp1.Size = new System.Drawing.Size(131, 26);
            this.txtTemp1.TabIndex = 15;
            this.txtTemp1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTemp1_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = "18:00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "12:00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "06:00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "00:00";
            // 
            // txtTemp0
            // 
            this.txtTemp0.Location = new System.Drawing.Point(49, 47);
            this.txtTemp0.Name = "txtTemp0";
            this.txtTemp0.Size = new System.Drawing.Size(131, 26);
            this.txtTemp0.TabIndex = 10;
            this.txtTemp0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTemp0_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "TEMPERATURA (°C)";
            // 
            // grpBAROMETRO
            // 
            this.grpBAROMETRO.BackColor = System.Drawing.Color.IndianRed;
            this.grpBAROMETRO.Controls.Add(this.label3);
            this.grpBAROMETRO.Controls.Add(this.txtPressione);
            this.grpBAROMETRO.Location = new System.Drawing.Point(15, 64);
            this.grpBAROMETRO.Name = "grpBAROMETRO";
            this.grpBAROMETRO.Size = new System.Drawing.Size(203, 102);
            this.grpBAROMETRO.TabIndex = 5;
            this.grpBAROMETRO.TabStop = false;
            this.grpBAROMETRO.Text = "BAROMETRO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "PRESSIONE (hPa)";
            // 
            // txtPressione
            // 
            this.txtPressione.Location = new System.Drawing.Point(28, 46);
            this.txtPressione.Name = "txtPressione";
            this.txtPressione.Size = new System.Drawing.Size(144, 26);
            this.txtPressione.TabIndex = 9;
            this.txtPressione.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPressione_KeyPress);
            // 
            // grpPluviometro
            // 
            this.grpPluviometro.BackColor = System.Drawing.Color.IndianRed;
            this.grpPluviometro.Controls.Add(this.txtPioggia);
            this.grpPluviometro.Controls.Add(this.label9);
            this.grpPluviometro.Location = new System.Drawing.Point(12, 354);
            this.grpPluviometro.Name = "grpPluviometro";
            this.grpPluviometro.Size = new System.Drawing.Size(203, 83);
            this.grpPluviometro.TabIndex = 6;
            this.grpPluviometro.TabStop = false;
            this.grpPluviometro.Text = "PLUVIOMETRO";
            // 
            // txtPioggia
            // 
            this.txtPioggia.Location = new System.Drawing.Point(34, 50);
            this.txtPioggia.Name = "txtPioggia";
            this.txtPioggia.Size = new System.Drawing.Size(131, 26);
            this.txtPioggia.TabIndex = 10;
            this.txtPioggia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPioggia_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(49, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 18);
            this.label9.TabIndex = 8;
            this.label9.Text = "PIOGGIA (mm)";
            // 
            // grpAnemometro
            // 
            this.grpAnemometro.BackColor = System.Drawing.Color.IndianRed;
            this.grpAnemometro.Controls.Add(this.txtVento);
            this.grpAnemometro.Controls.Add(this.label12);
            this.grpAnemometro.Location = new System.Drawing.Point(224, 172);
            this.grpAnemometro.Name = "grpAnemometro";
            this.grpAnemometro.Size = new System.Drawing.Size(189, 92);
            this.grpAnemometro.TabIndex = 6;
            this.grpAnemometro.TabStop = false;
            this.grpAnemometro.Text = "ANEMOMETRO";
            // 
            // txtVento
            // 
            this.txtVento.Location = new System.Drawing.Point(34, 54);
            this.txtVento.Name = "txtVento";
            this.txtVento.Size = new System.Drawing.Size(131, 26);
            this.txtVento.TabIndex = 12;
            this.txtVento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVento_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(49, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 18);
            this.label12.TabIndex = 11;
            this.label12.Text = "VENTO (Km/h)";
            // 
            // btnCreaStaz
            // 
            this.btnCreaStaz.BackColor = System.Drawing.Color.IndianRed;
            this.btnCreaStaz.Location = new System.Drawing.Point(430, 28);
            this.btnCreaStaz.Name = "btnCreaStaz";
            this.btnCreaStaz.Size = new System.Drawing.Size(125, 56);
            this.btnCreaStaz.TabIndex = 8;
            this.btnCreaStaz.Text = "CREA STAZIONE";
            this.btnCreaStaz.UseVisualStyleBackColor = false;
            this.btnCreaStaz.Click += new System.EventHandler(this.btnCreaStaz_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.IndianRed;
            this.btnReset.Location = new System.Drawing.Point(561, 28);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(106, 57);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.IndianRed;
            this.btnReport.Location = new System.Drawing.Point(673, 28);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(109, 57);
            this.btnReport.TabIndex = 10;
            this.btnReport.Text = "REPORT";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // lstStazioni
            // 
            this.lstStazioni.FormattingEnabled = true;
            this.lstStazioni.ItemHeight = 18;
            this.lstStazioni.Location = new System.Drawing.Point(430, 87);
            this.lstStazioni.Name = "lstStazioni";
            this.lstStazioni.Size = new System.Drawing.Size(352, 400);
            this.lstStazioni.TabIndex = 11;
            this.lstStazioni.SelectedIndexChanged += new System.EventHandler(this.lstStazioni_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(230, 275);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(180, 28);
            this.label13.TabIndex = 12;
            this.label13.Text = "INFORMAZIONI";
            // 
            // rctInfo
            // 
            this.rctInfo.Location = new System.Drawing.Point(224, 306);
            this.rctInfo.Name = "rctInfo";
            this.rctInfo.Size = new System.Drawing.Size(189, 186);
            this.rctInfo.TabIndex = 13;
            this.rctInfo.Text = "  ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 453);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 39);
            this.label2.TabIndex = 15;
            this.label2.Text = "PIOGGIA";
            // 
            // pctImg
            // 
            this.pctImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctImg.Location = new System.Drawing.Point(154, 453);
            this.pctImg.Name = "pctImg";
            this.pctImg.Size = new System.Drawing.Size(48, 41);
            this.pctImg.TabIndex = 17;
            this.pctImg.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(800, 506);
            this.Controls.Add(this.pctImg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rctInfo);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lstStazioni);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCreaStaz);
            this.Controls.Add(this.grpAnemometro);
            this.Controls.Add(this.grpPluviometro);
            this.Controls.Add(this.grpBAROMETRO);
            this.Controls.Add(this.grpTERMOMETRO);
            this.Controls.Add(this.grpIgrometro);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpIgrometro.ResumeLayout(false);
            this.grpIgrometro.PerformLayout();
            this.grpTERMOMETRO.ResumeLayout(false);
            this.grpTERMOMETRO.PerformLayout();
            this.grpBAROMETRO.ResumeLayout(false);
            this.grpBAROMETRO.PerformLayout();
            this.grpPluviometro.ResumeLayout(false);
            this.grpPluviometro.PerformLayout();
            this.grpAnemometro.ResumeLayout(false);
            this.grpAnemometro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpIgrometro;
        private System.Windows.Forms.GroupBox grpTERMOMETRO;
        private System.Windows.Forms.GroupBox grpBAROMETRO;
        private System.Windows.Forms.GroupBox grpPluviometro;
        private System.Windows.Forms.GroupBox grpAnemometro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPressione;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTemp0;
        private System.Windows.Forms.TextBox txtTemp3;
        private System.Windows.Forms.TextBox txtTemp2;
        private System.Windows.Forms.TextBox txtTemp1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPioggia;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtUmidità;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtVento;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCreaStaz;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListBox lstStazioni;
        private System.Windows.Forms.RichTextBox rctInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pctImg;
    }
}

