namespace EsFantasyParkBM
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBiglietti = new System.Windows.Forms.Button();
            this.btnGiostre = new System.Windows.Forms.Button();
            this.btnAttrazioni = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(241, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "✨ FANTASY PARK ✨";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(270, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gestionale interno del parco";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(161, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(433, 60);
            this.label3.TabIndex = 2;
            this.label3.Text = "Benvenuti al Fantasia Park: domate l\'Oblivion e il Raptor,\r\npoi perdetevi tra spe" +
    "cchi e stelle \r\nin un\'avventura magica indimenticabile!";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBiglietti
            // 
            this.btnBiglietti.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnBiglietti.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBiglietti.BackgroundImage")));
            this.btnBiglietti.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBiglietti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBiglietti.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnBiglietti.FlatAppearance.BorderSize = 2;
            this.btnBiglietti.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnBiglietti.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnBiglietti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBiglietti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBiglietti.ForeColor = System.Drawing.Color.White;
            this.btnBiglietti.Location = new System.Drawing.Point(45, 227);
            this.btnBiglietti.Name = "btnBiglietti";
            this.btnBiglietti.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnBiglietti.Size = new System.Drawing.Size(150, 100);
            this.btnBiglietti.TabIndex = 3;
            this.btnBiglietti.Text = "BIGLIETTI";
            this.btnBiglietti.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBiglietti.UseVisualStyleBackColor = false;
            this.btnBiglietti.Click += new System.EventHandler(this.btnBiglietti_Click);
            // 
            // btnGiostre
            // 
            this.btnGiostre.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnGiostre.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGiostre.BackgroundImage")));
            this.btnGiostre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGiostre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGiostre.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.btnGiostre.FlatAppearance.BorderSize = 2;
            this.btnGiostre.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.btnGiostre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.btnGiostre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiostre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiostre.ForeColor = System.Drawing.Color.White;
            this.btnGiostre.Location = new System.Drawing.Point(322, 227);
            this.btnGiostre.Name = "btnGiostre";
            this.btnGiostre.Size = new System.Drawing.Size(150, 100);
            this.btnGiostre.TabIndex = 4;
            this.btnGiostre.Text = "GIOSTRE";
            this.btnGiostre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGiostre.UseVisualStyleBackColor = false;
            this.btnGiostre.Click += new System.EventHandler(this.btnGiostre_Click);
            // 
            // btnAttrazioni
            // 
            this.btnAttrazioni.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAttrazioni.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAttrazioni.BackgroundImage")));
            this.btnAttrazioni.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAttrazioni.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAttrazioni.FlatAppearance.BorderColor = System.Drawing.Color.Orchid;
            this.btnAttrazioni.FlatAppearance.BorderSize = 2;
            this.btnAttrazioni.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orchid;
            this.btnAttrazioni.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orchid;
            this.btnAttrazioni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttrazioni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttrazioni.ForeColor = System.Drawing.Color.White;
            this.btnAttrazioni.Location = new System.Drawing.Point(574, 227);
            this.btnAttrazioni.Name = "btnAttrazioni";
            this.btnAttrazioni.Size = new System.Drawing.Size(150, 100);
            this.btnAttrazioni.TabIndex = 5;
            this.btnAttrazioni.Text = "ATTRAZIONI";
            this.btnAttrazioni.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAttrazioni.UseVisualStyleBackColor = false;
            this.btnAttrazioni.Click += new System.EventHandler(this.btnAttrazioni_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Firebrick;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(361, 348);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 75);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAttrazioni);
            this.Controls.Add(this.btnGiostre);
            this.Controls.Add(this.btnBiglietti);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBiglietti;
        private System.Windows.Forms.Button btnGiostre;
        private System.Windows.Forms.Button btnAttrazioni;
        private System.Windows.Forms.Button btnExit;
    }
}

