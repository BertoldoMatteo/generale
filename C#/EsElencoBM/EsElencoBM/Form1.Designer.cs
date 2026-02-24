namespace EsElencoBM
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
            this.btnInput = new System.Windows.Forms.Button();
            this.lstElenco = new System.Windows.Forms.ListBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblIn = new System.Windows.Forms.Label();
            this.lblBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnInput
            // 
            this.btnInput.AllowDrop = true;
            this.btnInput.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnInput.Location = new System.Drawing.Point(264, 120);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(100, 50);
            this.btnInput.TabIndex = 0;
            this.btnInput.Text = "INVIO";
            this.btnInput.UseVisualStyleBackColor = false;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // lstElenco
            // 
            this.lstElenco.BackColor = System.Drawing.SystemColors.Highlight;
            this.lstElenco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstElenco.FormattingEnabled = true;
            this.lstElenco.ItemHeight = 25;
            this.lstElenco.Location = new System.Drawing.Point(464, 108);
            this.lstElenco.Name = "lstElenco";
            this.lstElenco.Size = new System.Drawing.Size(263, 254);
            this.lstElenco.TabIndex = 1;
            // 
            // txtInput
            // 
            this.txtInput.BackColor = System.Drawing.SystemColors.Highlight;
            this.txtInput.Location = new System.Drawing.Point(25, 159);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(200, 22);
            this.txtInput.TabIndex = 2;
            // 
            // lblIn
            // 
            this.lblIn.AutoSize = true;
            this.lblIn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lblIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIn.Location = new System.Drawing.Point(75, 108);
            this.lblIn.Name = "lblIn";
            this.lblIn.Size = new System.Drawing.Size(93, 39);
            this.lblIn.TabIndex = 3;
            this.lblIn.Text = "Input";
            // 
            // lblBox
            // 
            this.lblBox.AutoSize = true;
            this.lblBox.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lblBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBox.Location = new System.Drawing.Point(521, 44);
            this.lblBox.Name = "lblBox";
            this.lblBox.Size = new System.Drawing.Size(158, 39);
            this.lblBox.TabIndex = 5;
            this.lblBox.Text = "ELENCO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblBox);
            this.Controls.Add(this.lblIn);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lstElenco);
            this.Controls.Add(this.btnInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.ListBox lstElenco;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblIn;
        private System.Windows.Forms.Label lblBox;
    }
}

