namespace StazioneMeteoTaff
{
    partial class FormInizio
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
            btnNEW = new Button();
            btn_Report = new Button();
            btnHaPiovuto = new Button();
            btnReset = new Button();
            btnModifica = new Button();
            lstListaStazioni = new ListBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnNEW
            // 
            btnNEW.Location = new Point(20, 377);
            btnNEW.Name = "btnNEW";
            btnNEW.Size = new Size(101, 42);
            btnNEW.TabIndex = 0;
            btnNEW.Text = "AGGIUNGI";
            btnNEW.UseVisualStyleBackColor = true;
            btnNEW.Click += btnNEW_Click;
            // 
            // btn_Report
            // 
            btn_Report.Location = new Point(150, 377);
            btn_Report.Name = "btn_Report";
            btn_Report.Size = new Size(101, 42);
            btn_Report.TabIndex = 1;
            btn_Report.Text = "REPORT";
            btn_Report.UseVisualStyleBackColor = true;
            btn_Report.Click += btn_Report_Click;
            // 
            // btnHaPiovuto
            // 
            btnHaPiovuto.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHaPiovuto.Location = new Point(268, 377);
            btnHaPiovuto.Name = "btnHaPiovuto";
            btnHaPiovuto.Size = new Size(101, 42);
            btnHaPiovuto.TabIndex = 2;
            btnHaPiovuto.Text = "HA PIOVUTO";
            btnHaPiovuto.UseVisualStyleBackColor = true;
            btnHaPiovuto.Click += btnHaPiovuto_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(400, 377);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(101, 42);
            btnReset.TabIndex = 3;
            btnReset.Text = "RESET";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnModifica
            // 
            btnModifica.Location = new Point(525, 377);
            btnModifica.Name = "btnModifica";
            btnModifica.Size = new Size(101, 42);
            btnModifica.TabIndex = 4;
            btnModifica.Text = "MODIFICA";
            btnModifica.UseVisualStyleBackColor = true;
            btnModifica.Click += btnModifica_Click;
            // 
            // lstListaStazioni
            // 
            lstListaStazioni.FormattingEnabled = true;
            lstListaStazioni.Location = new Point(20, 67);
            lstListaStazioni.Name = "lstListaStazioni";
            lstListaStazioni.Size = new Size(1035, 304);
            lstListaStazioni.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 42);
            label1.Name = "label1";
            label1.Size = new Size(714, 23);
            label1.TabIndex = 6;
            label1.Text = "Stazione   Barometro   Temp(00/06/12/18)   Pluvio   Igro   Anemo";
            // 
            // FormInizio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 450);
            Controls.Add(label1);
            Controls.Add(lstListaStazioni);
            Controls.Add(btnModifica);
            Controls.Add(btnReset);
            Controls.Add(btnHaPiovuto);
            Controls.Add(btn_Report);
            Controls.Add(btnNEW);
            Name = "FormInizio";
            Text = "FInizio";
            FormClosing += FormInizio_FormClosing;
            Load += FormInizio_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNEW;
        private Button btn_Report;
        private Button btnHaPiovuto;
        private Button btnReset;
        private Button btnModifica;
        private ListBox lstListaStazioni;
        private Label label1;
    }
}