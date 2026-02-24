namespace Form1
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
            this.btnScopo = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnScopo
            // 
            this.btnScopo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnScopo.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnScopo.Font = new System.Drawing.Font("Miriam CLM", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnScopo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnScopo.Image = ((System.Drawing.Image)(resources.GetObject("btnScopo.Image")));
            this.btnScopo.Location = new System.Drawing.Point(134, 79);
            this.btnScopo.Name = "btnScopo";
            this.btnScopo.Size = new System.Drawing.Size(188, 222);
            this.btnScopo.TabIndex = 0;
            this.btnScopo.Text = "Ciao";
            this.btnScopo.UseVisualStyleBackColor = false;
            this.btnScopo.Click += new System.EventHandler(this.btnScopo_Click);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.Aquamarine;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Location = new System.Drawing.Point(452, 182);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtName.Size = new System.Drawing.Size(151, 57);
            this.txtName.TabIndex = 1;
            this.txtName.Text = "Inserisci colore";
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNome
            // 
            this.lblNome.BackColor = System.Drawing.Color.Teal;
            this.lblNome.Location = new System.Drawing.Point(475, 137);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(100, 38);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Inserisci un colore!";
            this.lblNome.Click += new System.EventHandler(this.lblNome_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnScopo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnScopo;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblNome;
    }
}

