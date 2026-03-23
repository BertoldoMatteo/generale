namespace EsLibriBM
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotLib = new System.Windows.Forms.TextBox();
            this.txtDsipLib = new System.Windows.Forms.TextBox();
            this.lstLibriGen = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(301, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONTEGGIO E STATISTICHE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "NUMERO TOTALE DI LIBRI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "NUMERO DI LIBRI PER GENERE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "NUMERO DI LIBRI DISPONIBILI";
            // 
            // txtTotLib
            // 
            this.txtTotLib.Location = new System.Drawing.Point(329, 123);
            this.txtTotLib.Name = "txtTotLib";
            this.txtTotLib.ReadOnly = true;
            this.txtTotLib.Size = new System.Drawing.Size(200, 22);
            this.txtTotLib.TabIndex = 4;
            // 
            // txtDsipLib
            // 
            this.txtDsipLib.Location = new System.Drawing.Point(329, 183);
            this.txtDsipLib.Name = "txtDsipLib";
            this.txtDsipLib.ReadOnly = true;
            this.txtDsipLib.Size = new System.Drawing.Size(200, 22);
            this.txtDsipLib.TabIndex = 5;
            // 
            // lstLibriGen
            // 
            this.lstLibriGen.FormattingEnabled = true;
            this.lstLibriGen.ItemHeight = 16;
            this.lstLibriGen.Location = new System.Drawing.Point(304, 261);
            this.lstLibriGen.Name = "lstLibriGen";
            this.lstLibriGen.Size = new System.Drawing.Size(237, 148);
            this.lstLibriGen.TabIndex = 6;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstLibriGen);
            this.Controls.Add(this.txtDsipLib);
            this.Controls.Add(this.txtTotLib);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotLib;
        private System.Windows.Forms.TextBox txtDsipLib;
        private System.Windows.Forms.ListBox lstLibriGen;
    }
}