using System.Windows.Forms;

namespace EsIMCBM
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
            this.components = new System.ComponentModel.Container();
            this.txtNomeCognome = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblNomeCognome = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.lblPeso = new System.Windows.Forms.Label();
            this.txtAltezza = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstPersone = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.rdbIMC = new System.Windows.Forms.RadioButton();
            this.rdbIMCMedia = new System.Windows.Forms.RadioButton();
            this.rdbIMCModa = new System.Windows.Forms.RadioButton();
            this.rdbIMCVarianza = new System.Windows.Forms.RadioButton();
            this.rdbMediaSotto = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.rdbIMCMediana = new System.Windows.Forms.RadioButton();
            this.btnEsegui = new System.Windows.Forms.Button();
            this.lblComandi = new System.Windows.Forms.Label();
            this.lblRisp = new System.Windows.Forms.Label();
            this.txtRisposte = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNomeCognome
            // 
            this.txtNomeCognome.Location = new System.Drawing.Point(12, 36);
            this.txtNomeCognome.Name = "txtNomeCognome";
            this.txtNomeCognome.Size = new System.Drawing.Size(112, 22);
            this.txtNomeCognome.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lblNomeCognome
            // 
            this.lblNomeCognome.AutoSize = true;
            this.lblNomeCognome.Location = new System.Drawing.Point(18, 20);
            this.lblNomeCognome.Name = "lblNomeCognome";
            this.lblNomeCognome.Size = new System.Drawing.Size(106, 16);
            this.lblNomeCognome.TabIndex = 2;
            this.lblNomeCognome.Text = "Cognome Nome";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(291, 36);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(112, 22);
            this.txtPeso.TabIndex = 3;
            this.txtPeso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPeso_KeyPress);
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(312, 17);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(78, 16);
            this.lblPeso.TabIndex = 4;
            this.lblPeso.Text = "Peso (in kg)";
            // 
            // txtAltezza
            // 
            this.txtAltezza.Location = new System.Drawing.Point(493, 36);
            this.txtAltezza.Name = "txtAltezza";
            this.txtAltezza.Size = new System.Drawing.Size(112, 22);
            this.txtAltezza.TabIndex = 5;
            this.txtAltezza.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAltezza_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(501, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Altezza (in cm)";
            // 
            // lstPersone
            // 
            this.lstPersone.FormattingEnabled = true;
            this.lstPersone.ItemHeight = 16;
            this.lstPersone.Location = new System.Drawing.Point(12, 80);
            this.lstPersone.Name = "lstPersone";
            this.lstPersone.Size = new System.Drawing.Size(524, 260);
            this.lstPersone.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(650, 22);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 50);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // rdbIMC
            // 
            this.rdbIMC.AutoSize = true;
            this.rdbIMC.Location = new System.Drawing.Point(3, 29);
            this.rdbIMC.Name = "rdbIMC";
            this.rdbIMC.Size = new System.Drawing.Size(177, 20);
            this.rdbIMC.TabIndex = 9;
            this.rdbIMC.TabStop = true;
            this.rdbIMC.Text = "CALCOLO IMC SINGOLO";
            this.rdbIMC.UseVisualStyleBackColor = true;
            // 
            // rdbIMCMedia
            // 
            this.rdbIMCMedia.AutoSize = true;
            this.rdbIMCMedia.Location = new System.Drawing.Point(3, 3);
            this.rdbIMCMedia.Name = "rdbIMCMedia";
            this.rdbIMCMedia.Size = new System.Drawing.Size(96, 20);
            this.rdbIMCMedia.TabIndex = 10;
            this.rdbIMCMedia.TabStop = true;
            this.rdbIMCMedia.Text = "MEDIA IMC\r\n";
            this.rdbIMCMedia.UseVisualStyleBackColor = true;
            // 
            // rdbIMCModa
            // 
            this.rdbIMCModa.AutoSize = true;
            this.rdbIMCModa.Location = new System.Drawing.Point(3, 55);
            this.rdbIMCModa.Name = "rdbIMCModa";
            this.rdbIMCModa.Size = new System.Drawing.Size(94, 20);
            this.rdbIMCModa.TabIndex = 11;
            this.rdbIMCModa.TabStop = true;
            this.rdbIMCModa.Text = "MODA IMC";
            this.rdbIMCModa.UseVisualStyleBackColor = true;
            // 
            // rdbIMCVarianza
            // 
            this.rdbIMCVarianza.AutoSize = true;
            this.rdbIMCVarianza.Location = new System.Drawing.Point(3, 107);
            this.rdbIMCVarianza.Name = "rdbIMCVarianza";
            this.rdbIMCVarianza.Size = new System.Drawing.Size(121, 20);
            this.rdbIMCVarianza.TabIndex = 13;
            this.rdbIMCVarianza.TabStop = true;
            this.rdbIMCVarianza.Text = "VARIANZA IMC";
            this.rdbIMCVarianza.UseVisualStyleBackColor = true;
            // 
            // rdbMediaSotto
            // 
            this.rdbMediaSotto.AutoSize = true;
            this.rdbMediaSotto.Location = new System.Drawing.Point(3, 133);
            this.rdbMediaSotto.Name = "rdbMediaSotto";
            this.rdbMediaSotto.Size = new System.Drawing.Size(133, 36);
            this.rdbMediaSotto.TabIndex = 14;
            this.rdbMediaSotto.TabStop = true;
            this.rdbMediaSotto.Text = "MEDIA \r\nSOTTOGRUPPO";
            this.rdbMediaSotto.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.rdbIMCVarianza, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.rdbIMCModa, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.rdbIMCMedia, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.rdbMediaSotto, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.rdbIMC, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.rdbIMCMediana, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(564, 127);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(206, 188);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // rdbIMCMediana
            // 
            this.rdbIMCMediana.AutoSize = true;
            this.rdbIMCMediana.Location = new System.Drawing.Point(3, 81);
            this.rdbIMCMediana.Name = "rdbIMCMediana";
            this.rdbIMCMediana.Size = new System.Drawing.Size(115, 20);
            this.rdbIMCMediana.TabIndex = 12;
            this.rdbIMCMediana.TabStop = true;
            this.rdbIMCMediana.Text = "MEDIANA IMC\r\n";
            this.rdbIMCMediana.UseVisualStyleBackColor = true;
            // 
            // btnEsegui
            // 
            this.btnEsegui.Location = new System.Drawing.Point(606, 330);
            this.btnEsegui.Name = "btnEsegui";
            this.btnEsegui.Size = new System.Drawing.Size(100, 50);
            this.btnEsegui.TabIndex = 16;
            this.btnEsegui.Text = "ESEGUI";
            this.btnEsegui.UseVisualStyleBackColor = true;
            this.btnEsegui.Click += new System.EventHandler(this.btnEsegui_Click);
            // 
            // lblComandi
            // 
            this.lblComandi.AutoSize = true;
            this.lblComandi.Location = new System.Drawing.Point(619, 92);
            this.lblComandi.Name = "lblComandi";
            this.lblComandi.Size = new System.Drawing.Size(69, 16);
            this.lblComandi.TabIndex = 17;
            this.lblComandi.Text = "COMANDI";
            // 
            // lblRisp
            // 
            this.lblRisp.AutoSize = true;
            this.lblRisp.Location = new System.Drawing.Point(144, 364);
            this.lblRisp.Name = "lblRisp";
            this.lblRisp.Size = new System.Drawing.Size(75, 16);
            this.lblRisp.TabIndex = 18;
            this.lblRisp.Text = "RISPOSTE";
            // 
            // txtRisposte
            // 
            this.txtRisposte.Location = new System.Drawing.Point(36, 393);
            this.txtRisposte.Multiline = true;
            this.txtRisposte.Name = "txtRisposte";
            this.txtRisposte.ReadOnly = true;
            this.txtRisposte.Size = new System.Drawing.Size(400, 44);
            this.txtRisposte.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtRisposte);
            this.Controls.Add(this.lblRisp);
            this.Controls.Add(this.lblComandi);
            this.Controls.Add(this.btnEsegui);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstPersone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAltezza);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.lblNomeCognome);
            this.Controls.Add(this.txtNomeCognome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomeCognome;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lblNomeCognome;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.TextBox txtAltezza;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstPersone;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.RadioButton rdbIMC;
        private System.Windows.Forms.RadioButton rdbIMCMedia;
        private System.Windows.Forms.RadioButton rdbIMCModa;
        private System.Windows.Forms.RadioButton rdbIMCVarianza;
        private System.Windows.Forms.RadioButton rdbMediaSotto;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnEsegui;
        private System.Windows.Forms.RadioButton rdbIMCMediana;
        private System.Windows.Forms.Label lblComandi;
        private System.Windows.Forms.Label lblRisp;
        private System.Windows.Forms.TextBox txtRisposte;
    }
}

