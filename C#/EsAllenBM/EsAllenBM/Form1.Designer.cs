namespace EsAllenBM
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.lstAllenamenti = new System.Windows.Forms.ListBox();
            this.lblName = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.txtMinute = new System.Windows.Forms.TextBox();
            this.txtPlace = new System.Windows.Forms.TextBox();
            this.lblMinute = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblPlace = new System.Windows.Forms.Label();
            this.pnlOption2 = new System.Windows.Forms.Panel();
            this.btnSequenza = new System.Windows.Forms.Button();
            this.btnPlace40 = new System.Windows.Forms.Button();
            this.btnMaxType = new System.Windows.Forms.Button();
            this.btnStampa1 = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pnlOption2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(665, 242);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 50);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lstAllenamenti
            // 
            this.lstAllenamenti.FormattingEnabled = true;
            this.lstAllenamenti.ItemHeight = 16;
            this.lstAllenamenti.Location = new System.Drawing.Point(12, 12);
            this.lstAllenamenti.Name = "lstAllenamenti";
            this.lstAllenamenti.Size = new System.Drawing.Size(465, 420);
            this.lstAllenamenti.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(322, 42);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 16);
            this.lblName.TabIndex = 2;
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "corsa",
            "pesi",
            "nuoto"});
            this.cmbType.Location = new System.Drawing.Point(659, 132);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(121, 24);
            this.cmbType.TabIndex = 3;
            // 
            // txtMinute
            // 
            this.txtMinute.Location = new System.Drawing.Point(665, 55);
            this.txtMinute.Name = "txtMinute";
            this.txtMinute.Size = new System.Drawing.Size(100, 22);
            this.txtMinute.TabIndex = 4;
            this.txtMinute.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMinute_KeyPress);
            // 
            // txtPlace
            // 
            this.txtPlace.Location = new System.Drawing.Point(661, 201);
            this.txtPlace.Name = "txtPlace";
            this.txtPlace.Size = new System.Drawing.Size(100, 22);
            this.txtPlace.TabIndex = 5;
            // 
            // lblMinute
            // 
            this.lblMinute.AutoSize = true;
            this.lblMinute.Location = new System.Drawing.Point(658, 20);
            this.lblMinute.Name = "lblMinute";
            this.lblMinute.Size = new System.Drawing.Size(81, 32);
            this.lblMinute.TabIndex = 6;
            this.lblMinute.Text = "DURATION \r\nTRAINING";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(662, 106);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(131, 16);
            this.lblType.TabIndex = 7;
            this.lblType.Text = "TYPE OF TRAINING";
            // 
            // lblPlace
            // 
            this.lblPlace.AutoSize = true;
            this.lblPlace.Location = new System.Drawing.Point(689, 173);
            this.lblPlace.Name = "lblPlace";
            this.lblPlace.Size = new System.Drawing.Size(50, 16);
            this.lblPlace.TabIndex = 8;
            this.lblPlace.Text = "PLACE";
            // 
            // pnlOption2
            // 
            this.pnlOption2.Controls.Add(this.btnSequenza);
            this.pnlOption2.Controls.Add(this.btnPlace40);
            this.pnlOption2.Controls.Add(this.btnMaxType);
            this.pnlOption2.Controls.Add(this.btnStampa1);
            this.pnlOption2.Location = new System.Drawing.Point(483, 20);
            this.pnlOption2.Name = "pnlOption2";
            this.pnlOption2.Size = new System.Drawing.Size(153, 370);
            this.pnlOption2.TabIndex = 9;
            // 
            // btnSequenza
            // 
            this.btnSequenza.Location = new System.Drawing.Point(16, 269);
            this.btnSequenza.Name = "btnSequenza";
            this.btnSequenza.Size = new System.Drawing.Size(119, 74);
            this.btnSequenza.TabIndex = 3;
            this.btnSequenza.Text = "SEQUENCE";
            this.btnSequenza.UseVisualStyleBackColor = true;
            this.btnSequenza.Click += new System.EventHandler(this.btnSequenza_Click);
            // 
            // btnPlace40
            // 
            this.btnPlace40.Location = new System.Drawing.Point(16, 169);
            this.btnPlace40.Name = "btnPlace40";
            this.btnPlace40.Size = new System.Drawing.Size(119, 74);
            this.btnPlace40.TabIndex = 2;
            this.btnPlace40.Text = "PRINT DURATION > 40";
            this.btnPlace40.UseVisualStyleBackColor = true;
            this.btnPlace40.Click += new System.EventHandler(this.btnPlace40_Click);
            // 
            // btnMaxType
            // 
            this.btnMaxType.Location = new System.Drawing.Point(16, 83);
            this.btnMaxType.Name = "btnMaxType";
            this.btnMaxType.Size = new System.Drawing.Size(119, 74);
            this.btnMaxType.TabIndex = 1;
            this.btnMaxType.Text = "PRINT MAX TRAINING";
            this.btnMaxType.UseVisualStyleBackColor = true;
            this.btnMaxType.Click += new System.EventHandler(this.btnMaxType_Click);
            // 
            // btnStampa1
            // 
            this.btnStampa1.Location = new System.Drawing.Point(16, 3);
            this.btnStampa1.Name = "btnStampa1";
            this.btnStampa1.Size = new System.Drawing.Size(119, 74);
            this.btnStampa1.TabIndex = 0;
            this.btnStampa1.Text = "PRINT TRAINING FOR TYPE";
            this.btnStampa1.UseVisualStyleBackColor = true;
            this.btnStampa1.Click += new System.EventHandler(this.btnStampa1_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(665, 388);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 50);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(665, 313);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 50);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pnlOption2);
            this.Controls.Add(this.lblPlace);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblMinute);
            this.Controls.Add(this.txtPlace);
            this.Controls.Add(this.txtMinute);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lstAllenamenti);
            this.Controls.Add(this.btnAdd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlOption2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lstAllenamenti;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.TextBox txtMinute;
        private System.Windows.Forms.TextBox txtPlace;
        private System.Windows.Forms.Label lblMinute;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblPlace;
        private System.Windows.Forms.Panel pnlOption2;
        private System.Windows.Forms.Button btnSequenza;
        private System.Windows.Forms.Button btnPlace40;
        private System.Windows.Forms.Button btnMaxType;
        private System.Windows.Forms.Button btnStampa1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
    }
}

