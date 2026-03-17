namespace EsUEFABM
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
            this.lblCasa1 = new System.Windows.Forms.Label();
            this.lblOspite2 = new System.Windows.Forms.Label();
            this.lblOspite1 = new System.Windows.Forms.Label();
            this.lblCasa2 = new System.Windows.Forms.Label();
            this.txtOspite2 = new System.Windows.Forms.TextBox();
            this.txtCasa2 = new System.Windows.Forms.TextBox();
            this.lstPart = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSalva = new System.Windows.Forms.Button();
            this.btnStat = new System.Windows.Forms.Button();
            this.txtCasa1 = new System.Windows.Forms.TextBox();
            this.txtOspite1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCerca = new System.Windows.Forms.ComboBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCasa1
            // 
            this.lblCasa1.AutoSize = true;
            this.lblCasa1.Location = new System.Drawing.Point(72, 39);
            this.lblCasa1.Name = "lblCasa1";
            this.lblCasa1.Size = new System.Drawing.Size(129, 16);
            this.lblCasa1.TabIndex = 0;
            this.lblCasa1.Text = "SQUADRA DI CASA";
            // 
            // lblOspite2
            // 
            this.lblOspite2.AutoSize = true;
            this.lblOspite2.Location = new System.Drawing.Point(418, 86);
            this.lblOspite2.Name = "lblOspite2";
            this.lblOspite2.Size = new System.Drawing.Size(156, 16);
            this.lblOspite2.TabIndex = 1;
            this.lblOspite2.Text = "GOL SEGNATI (OSPITE)";
            // 
            // lblOspite1
            // 
            this.lblOspite1.AutoSize = true;
            this.lblOspite1.Location = new System.Drawing.Point(418, 39);
            this.lblOspite1.Name = "lblOspite1";
            this.lblOspite1.Size = new System.Drawing.Size(126, 16);
            this.lblOspite1.TabIndex = 2;
            this.lblOspite1.Text = "SQUADRA OSPITE";
            // 
            // lblCasa2
            // 
            this.lblCasa2.AutoSize = true;
            this.lblCasa2.Location = new System.Drawing.Point(72, 86);
            this.lblCasa2.Name = "lblCasa2";
            this.lblCasa2.Size = new System.Drawing.Size(143, 16);
            this.lblCasa2.TabIndex = 3;
            this.lblCasa2.Text = "GOL SEGNATI (CASA)";
            // 
            // txtOspite2
            // 
            this.txtOspite2.Location = new System.Drawing.Point(618, 86);
            this.txtOspite2.Name = "txtOspite2";
            this.txtOspite2.Size = new System.Drawing.Size(100, 22);
            this.txtOspite2.TabIndex = 5;
            this.txtOspite2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOspite2_KeyPress);
            // 
            // txtCasa2
            // 
            this.txtCasa2.Location = new System.Drawing.Point(234, 86);
            this.txtCasa2.Name = "txtCasa2";
            this.txtCasa2.Size = new System.Drawing.Size(100, 22);
            this.txtCasa2.TabIndex = 7;
            this.txtCasa2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCasa2_KeyPress);
            // 
            // lstPart
            // 
            this.lstPart.FormattingEnabled = true;
            this.lstPart.ItemHeight = 16;
            this.lstPart.Location = new System.Drawing.Point(42, 153);
            this.lstPart.Name = "lstPart";
            this.lstPart.Size = new System.Drawing.Size(469, 244);
            this.lstPart.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(552, 153);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 60);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "AGGIUNGI";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSalva
            // 
            this.btnSalva.Location = new System.Drawing.Point(608, 219);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(110, 60);
            this.btnSalva.TabIndex = 13;
            this.btnSalva.Text = "SALVA";
            this.btnSalva.UseVisualStyleBackColor = true;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // btnStat
            // 
            this.btnStat.Location = new System.Drawing.Point(668, 153);
            this.btnStat.Name = "btnStat";
            this.btnStat.Size = new System.Drawing.Size(110, 60);
            this.btnStat.TabIndex = 14;
            this.btnStat.Text = "STATISTICHE";
            this.btnStat.UseVisualStyleBackColor = true;
            this.btnStat.Click += new System.EventHandler(this.btnStat_Click);
            // 
            // txtCasa1
            // 
            this.txtCasa1.Location = new System.Drawing.Point(234, 39);
            this.txtCasa1.Name = "txtCasa1";
            this.txtCasa1.Size = new System.Drawing.Size(100, 22);
            this.txtCasa1.TabIndex = 15;
            // 
            // txtOspite1
            // 
            this.txtOspite1.Location = new System.Drawing.Point(618, 33);
            this.txtOspite1.Name = "txtOspite1";
            this.txtOspite1.Size = new System.Drawing.Size(100, 22);
            this.txtOspite1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(634, 326);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "CERCA";
            // 
            // cmbCerca
            // 
            this.cmbCerca.FormattingEnabled = true;
            this.cmbCerca.Location = new System.Drawing.Point(584, 345);
            this.cmbCerca.Name = "cmbCerca";
            this.cmbCerca.Size = new System.Drawing.Size(150, 24);
            this.cmbCerca.TabIndex = 18;
            this.cmbCerca.SelectedIndexChanged += new System.EventHandler(this.cmbCerca_SelectedIndexChanged);
            this.cmbCerca.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmbCerca_MouseClick);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(618, 374);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 19;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.cmbCerca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOspite1);
            this.Controls.Add(this.txtCasa1);
            this.Controls.Add(this.btnStat);
            this.Controls.Add(this.btnSalva);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstPart);
            this.Controls.Add(this.txtCasa2);
            this.Controls.Add(this.txtOspite2);
            this.Controls.Add(this.lblCasa2);
            this.Controls.Add(this.lblOspite1);
            this.Controls.Add(this.lblOspite2);
            this.Controls.Add(this.lblCasa1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCasa1;
        private System.Windows.Forms.Label lblOspite2;
        private System.Windows.Forms.Label lblOspite1;
        private System.Windows.Forms.Label lblCasa2;
        private System.Windows.Forms.TextBox txtOspite2;
        private System.Windows.Forms.TextBox txtCasa2;
        private System.Windows.Forms.ListBox lstPart;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.Button btnStat;
        private System.Windows.Forms.TextBox txtCasa1;
        private System.Windows.Forms.TextBox txtOspite1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCerca;
        private System.Windows.Forms.Button btnReset;
    }
}

