namespace EsLibriBM
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
            this.lstElenco = new System.Windows.Forms.ListBox();
            this.lblTitolo = new System.Windows.Forms.Label();
            this.lblInput = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPagine = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbGenere = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAnno = new System.Windows.Forms.TextBox();
            this.lblAutore = new System.Windows.Forms.Label();
            this.txtAutore = new System.Windows.Forms.TextBox();
            this.lblTitLib = new System.Windows.Forms.Label();
            this.txtTitLib = new System.Windows.Forms.TextBox();
            this.btnRicercaGenere = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.rdbOrdTit = new System.Windows.Forms.RadioButton();
            this.rdbOrdCresc = new System.Windows.Forms.RadioButton();
            this.rdbOrdDec = new System.Windows.Forms.RadioButton();
            this.btnRicercaAutore = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstElenco
            // 
            this.lstElenco.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstElenco.FormattingEnabled = true;
            this.lstElenco.ItemHeight = 16;
            this.lstElenco.Location = new System.Drawing.Point(12, 45);
            this.lstElenco.Name = "lstElenco";
            this.lstElenco.Size = new System.Drawing.Size(526, 244);
            this.lstElenco.TabIndex = 0;
            // 
            // lblTitolo
            // 
            this.lblTitolo.AutoSize = true;
            this.lblTitolo.Location = new System.Drawing.Point(246, 9);
            this.lblTitolo.Name = "lblTitolo";
            this.lblTitolo.Size = new System.Drawing.Size(210, 16);
            this.lblTitolo.TabIndex = 1;
            this.lblTitolo.Text = "LIBREARIA \"LETTURE INFINITE\"";
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(658, 9);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(48, 16);
            this.lblInput.TabIndex = 2;
            this.lblInput.Text = "INPUT";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtISBN);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtPagine);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmbGenere);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtAnno);
            this.panel1.Controls.Add(this.lblAutore);
            this.panel1.Controls.Add(this.txtAutore);
            this.panel1.Controls.Add(this.lblTitLib);
            this.panel1.Controls.Add(this.txtTitLib);
            this.panel1.Location = new System.Drawing.Point(544, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 304);
            this.panel1.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(52, 205);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(122, 66);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(128, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Codice ISBN";
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(129, 146);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(100, 22);
            this.txtISBN.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Pagine";
            // 
            // txtPagine
            // 
            this.txtPagine.Location = new System.Drawing.Point(3, 146);
            this.txtPagine.Name = "txtPagine";
            this.txtPagine.Size = new System.Drawing.Size(100, 22);
            this.txtPagine.TabIndex = 8;
            this.txtPagine.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPagine_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Genere";
            // 
            // cmbGenere
            // 
            this.cmbGenere.FormattingEnabled = true;
            this.cmbGenere.Location = new System.Drawing.Point(0, 88);
            this.cmbGenere.Name = "cmbGenere";
            this.cmbGenere.Size = new System.Drawing.Size(121, 24);
            this.cmbGenere.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Anno \r\nPubblicazione";
            // 
            // txtAnno
            // 
            this.txtAnno.Location = new System.Drawing.Point(129, 90);
            this.txtAnno.Name = "txtAnno";
            this.txtAnno.Size = new System.Drawing.Size(100, 22);
            this.txtAnno.TabIndex = 4;
            this.txtAnno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAnno_KeyPress);
            // 
            // lblAutore
            // 
            this.lblAutore.AutoSize = true;
            this.lblAutore.Location = new System.Drawing.Point(128, 12);
            this.lblAutore.Name = "lblAutore";
            this.lblAutore.Size = new System.Drawing.Size(46, 16);
            this.lblAutore.TabIndex = 3;
            this.lblAutore.Text = "Autore";
            // 
            // txtAutore
            // 
            this.txtAutore.Location = new System.Drawing.Point(129, 31);
            this.txtAutore.Name = "txtAutore";
            this.txtAutore.Size = new System.Drawing.Size(100, 22);
            this.txtAutore.TabIndex = 2;
            // 
            // lblTitLib
            // 
            this.lblTitLib.AutoSize = true;
            this.lblTitLib.Location = new System.Drawing.Point(12, 12);
            this.lblTitLib.Name = "lblTitLib";
            this.lblTitLib.Size = new System.Drawing.Size(74, 16);
            this.lblTitLib.TabIndex = 1;
            this.lblTitLib.Text = "Titolo Libro";
            // 
            // txtTitLib
            // 
            this.txtTitLib.Location = new System.Drawing.Point(3, 31);
            this.txtTitLib.Name = "txtTitLib";
            this.txtTitLib.Size = new System.Drawing.Size(100, 22);
            this.txtTitLib.TabIndex = 0;
            // 
            // btnRicercaGenere
            // 
            this.btnRicercaGenere.Location = new System.Drawing.Point(49, 310);
            this.btnRicercaGenere.Name = "btnRicercaGenere";
            this.btnRicercaGenere.Size = new System.Drawing.Size(100, 50);
            this.btnRicercaGenere.TabIndex = 16;
            this.btnRicercaGenere.Text = "GENERE";
            this.btnRicercaGenere.UseVisualStyleBackColor = true;
            this.btnRicercaGenere.Click += new System.EventHandler(this.btnRicercaGenere_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(246, 327);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "ORDINAMENTO";
            // 
            // rdbOrdTit
            // 
            this.rdbOrdTit.AutoSize = true;
            this.rdbOrdTit.Location = new System.Drawing.Point(249, 346);
            this.rdbOrdTit.Name = "rdbOrdTit";
            this.rdbOrdTit.Size = new System.Drawing.Size(94, 20);
            this.rdbOrdTit.TabIndex = 17;
            this.rdbOrdTit.TabStop = true;
            this.rdbOrdTit.Text = "Titolo (A-Z)";
            this.rdbOrdTit.UseVisualStyleBackColor = true;
            this.rdbOrdTit.CheckedChanged += new System.EventHandler(this.rdbOrdTit_CheckedChanged);
            // 
            // rdbOrdCresc
            // 
            this.rdbOrdCresc.AutoSize = true;
            this.rdbOrdCresc.Location = new System.Drawing.Point(249, 373);
            this.rdbOrdCresc.Name = "rdbOrdCresc";
            this.rdbOrdCresc.Size = new System.Drawing.Size(230, 20);
            this.rdbOrdCresc.TabIndex = 18;
            this.rdbOrdCresc.TabStop = true;
            this.rdbOrdCresc.Text = "Anno di pubblicazione (crescente)";
            this.rdbOrdCresc.UseVisualStyleBackColor = true;
            this.rdbOrdCresc.CheckedChanged += new System.EventHandler(this.rdbOrdCresc_CheckedChanged);
            // 
            // rdbOrdDec
            // 
            this.rdbOrdDec.AutoSize = true;
            this.rdbOrdDec.Location = new System.Drawing.Point(247, 399);
            this.rdbOrdDec.Name = "rdbOrdDec";
            this.rdbOrdDec.Size = new System.Drawing.Size(246, 20);
            this.rdbOrdDec.TabIndex = 19;
            this.rdbOrdDec.TabStop = true;
            this.rdbOrdDec.Text = "Anno di pubblicazione (decrescente)";
            this.rdbOrdDec.UseVisualStyleBackColor = true;
            this.rdbOrdDec.CheckedChanged += new System.EventHandler(this.rdbOrdDec_CheckedChanged);
            // 
            // btnRicercaAutore
            // 
            this.btnRicercaAutore.Location = new System.Drawing.Point(49, 373);
            this.btnRicercaAutore.Name = "btnRicercaAutore";
            this.btnRicercaAutore.Size = new System.Drawing.Size(100, 50);
            this.btnRicercaAutore.TabIndex = 20;
            this.btnRicercaAutore.Text = "AUTORE";
            this.btnRicercaAutore.UseVisualStyleBackColor = true;
            this.btnRicercaAutore.Click += new System.EventHandler(this.btnRicercaAutore_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "RICERCA";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(596, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 50);
            this.button1.TabIndex = 22;
            this.button1.Text = "STATISTICHE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnRicercaAutore);
            this.Controls.Add(this.rdbOrdDec);
            this.Controls.Add(this.rdbOrdCresc);
            this.Controls.Add(this.rdbOrdTit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnRicercaGenere);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.lblTitolo);
            this.Controls.Add(this.lstElenco);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstElenco;
        private System.Windows.Forms.Label lblTitolo;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtAnno;
        private System.Windows.Forms.Label lblAutore;
        private System.Windows.Forms.TextBox txtAutore;
        private System.Windows.Forms.Label lblTitLib;
        private System.Windows.Forms.TextBox txtTitLib;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPagine;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbGenere;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRicercaGenere;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdbOrdTit;
        private System.Windows.Forms.RadioButton rdbOrdCresc;
        private System.Windows.Forms.RadioButton rdbOrdDec;
        private System.Windows.Forms.Button btnRicercaAutore;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}

