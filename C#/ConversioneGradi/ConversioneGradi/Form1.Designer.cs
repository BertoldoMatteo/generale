namespace ConversioneGradi
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
            this.cmbConversioni = new System.Windows.Forms.ComboBox();
            this.txtOut = new System.Windows.Forms.TextBox();
            this.txtIn = new System.Windows.Forms.TextBox();
            this.iblInput = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.lblConv = new System.Windows.Forms.Label();
            this.btnInvio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbConversioni
            // 
            this.cmbConversioni.BackColor = System.Drawing.Color.Bisque;
            this.cmbConversioni.FormattingEnabled = true;
            this.cmbConversioni.Items.AddRange(new object[] {
            "Celsius-Fahrenheit",
            "Fahrenheit-Celsius",
            "Kilometri-Miglia",
            "Miglia-Kilometri"});
            this.cmbConversioni.Location = new System.Drawing.Point(263, 69);
            this.cmbConversioni.Name = "cmbConversioni";
            this.cmbConversioni.Size = new System.Drawing.Size(167, 24);
            this.cmbConversioni.TabIndex = 0;
            // 
            // txtOut
            // 
            this.txtOut.Location = new System.Drawing.Point(378, 172);
            this.txtOut.Multiline = true;
            this.txtOut.Name = "txtOut";
            this.txtOut.ReadOnly = true;
            this.txtOut.Size = new System.Drawing.Size(115, 22);
            this.txtOut.TabIndex = 1;
            // 
            // txtIn
            // 
            this.txtIn.Location = new System.Drawing.Point(181, 172);
            this.txtIn.Multiline = true;
            this.txtIn.Name = "txtIn";
            this.txtIn.Size = new System.Drawing.Size(109, 22);
            this.txtIn.TabIndex = 2;
            // 
            // iblInput
            // 
            this.iblInput.AutoSize = true;
            this.iblInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iblInput.Location = new System.Drawing.Point(201, 144);
            this.iblInput.Name = "iblInput";
            this.iblInput.Size = new System.Drawing.Size(71, 25);
            this.iblInput.TabIndex = 3;
            this.iblInput.Text = "INPUT";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.Location = new System.Drawing.Point(383, 144);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(95, 25);
            this.lblOutput.TabIndex = 4;
            this.lblOutput.Text = "OUTPUT";
            // 
            // lblConv
            // 
            this.lblConv.AutoSize = true;
            this.lblConv.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConv.Location = new System.Drawing.Point(258, 37);
            this.lblConv.Name = "lblConv";
            this.lblConv.Size = new System.Drawing.Size(172, 29);
            this.lblConv.TabIndex = 5;
            this.lblConv.Text = "COVERSIONE";
            // 
            // btnInvio
            // 
            this.btnInvio.BackColor = System.Drawing.Color.Salmon;
            this.btnInvio.Location = new System.Drawing.Point(450, 45);
            this.btnInvio.Name = "btnInvio";
            this.btnInvio.Size = new System.Drawing.Size(115, 48);
            this.btnInvio.TabIndex = 6;
            this.btnInvio.Text = "INVIA";
            this.btnInvio.UseVisualStyleBackColor = false;
            this.btnInvio.Click += new System.EventHandler(this.btnInvio_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInvio);
            this.Controls.Add(this.lblConv);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.iblInput);
            this.Controls.Add(this.txtIn);
            this.Controls.Add(this.txtOut);
            this.Controls.Add(this.cmbConversioni);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbConversioni;
        private System.Windows.Forms.TextBox txtOut;
        private System.Windows.Forms.TextBox txtIn;
        private System.Windows.Forms.Label iblInput;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label lblConv;
        private System.Windows.Forms.Button btnInvio;
    }
}

