namespace EsDancerevolutionBM
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
            this.btnRed = new System.Windows.Forms.Button();
            this.btnWhite = new System.Windows.Forms.Button();
            this.btnBlue = new System.Windows.Forms.Button();
            this.btnYellow = new System.Windows.Forms.Button();
            this.btnOrange = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRed
            // 
            this.btnRed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRed.Location = new System.Drawing.Point(545, 157);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(100, 100);
            this.btnRed.TabIndex = 0;
            this.btnRed.Text = "RED";
            this.btnRed.UseVisualStyleBackColor = true;
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
            // 
            // btnWhite
            // 
            this.btnWhite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnWhite.Location = new System.Drawing.Point(365, 157);
            this.btnWhite.Name = "btnWhite";
            this.btnWhite.Size = new System.Drawing.Size(100, 100);
            this.btnWhite.TabIndex = 1;
            this.btnWhite.Text = "WHITE";
            this.btnWhite.UseVisualStyleBackColor = true;
            this.btnWhite.Click += new System.EventHandler(this.btnWhite_Click);
            // 
            // btnBlue
            // 
            this.btnBlue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBlue.Location = new System.Drawing.Point(177, 157);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(100, 100);
            this.btnBlue.TabIndex = 2;
            this.btnBlue.Text = "BLUE";
            this.btnBlue.UseVisualStyleBackColor = true;
            this.btnBlue.Click += new System.EventHandler(this.btnBlue_Click);
            // 
            // btnYellow
            // 
            this.btnYellow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnYellow.Location = new System.Drawing.Point(365, 12);
            this.btnYellow.Name = "btnYellow";
            this.btnYellow.Size = new System.Drawing.Size(100, 100);
            this.btnYellow.TabIndex = 3;
            this.btnYellow.Text = "YELLOW";
            this.btnYellow.UseVisualStyleBackColor = true;
            this.btnYellow.Click += new System.EventHandler(this.btnYellow_Click);
            // 
            // btnOrange
            // 
            this.btnOrange.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOrange.FlatAppearance.BorderSize = 0;
            this.btnOrange.Location = new System.Drawing.Point(365, 288);
            this.btnOrange.Name = "btnOrange";
            this.btnOrange.Size = new System.Drawing.Size(100, 100);
            this.btnOrange.TabIndex = 4;
            this.btnOrange.Text = "ORANGE";
            this.btnOrange.UseVisualStyleBackColor = true;
            this.btnOrange.Click += new System.EventHandler(this.btnOrange_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "TIMER : ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(76, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(101, 22);
            this.textBox1.TabIndex = 6;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(76, 7);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(101, 28);
            this.btnChange.TabIndex = 7;
            this.btnChange.Text = "CHANGE";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOrange);
            this.Controls.Add(this.btnYellow);
            this.Controls.Add(this.btnBlue);
            this.Controls.Add(this.btnWhite);
            this.Controls.Add(this.btnRed);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Button btnWhite;
        private System.Windows.Forms.Button btnBlue;
        private System.Windows.Forms.Button btnYellow;
        private System.Windows.Forms.Button btnOrange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnChange;
    }
}

