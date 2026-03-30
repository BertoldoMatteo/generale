namespace EsForza4BertMatt
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitolo = new System.Windows.Forms.Label();
            this.lblTurno = new System.Windows.Forms.Label();
            this.lblVittorie = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.tplScacchiera = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();

            // Titolo centrato in alto
            this.lblTitolo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitolo.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitolo.Location = new System.Drawing.Point(0, 0);
            this.lblTitolo.Size = new System.Drawing.Size(900, 60);
            this.lblTitolo.Text = "FORZA 4";
            this.lblTitolo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // Label Turno
            this.lblTurno.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTurno.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTurno.Location = new System.Drawing.Point(0, 60);
            this.lblTurno.Size = new System.Drawing.Size(900, 40);
            this.lblTurno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // Griglia Blu (TableLayoutPanel)
            this.tplScacchiera.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tplScacchiera.BackColor = System.Drawing.Color.RoyalBlue;
            this.tplScacchiera.ColumnCount = 7;
            for (int i = 0; i < 7; i++) this.tplScacchiera.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28f));
            this.tplScacchiera.RowCount = 6;
            for (int i = 0; i < 6; i++) this.tplScacchiera.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66f));
            this.tplScacchiera.Location = new System.Drawing.Point(50, 160);
            this.tplScacchiera.Size = new System.Drawing.Size(800, 350);
            this.tplScacchiera.Padding = new System.Windows.Forms.Padding(5);

            // Bottoni Colonne (Posizionamento gestito da AllineaBottoni in Form1.cs)
            System.Windows.Forms.Button[] btns = { btn1, btn2, btn3, btn4, btn5, btn6, btn7 };
            for (int i = 0; i < 7; i++)
            {
                btns[i].Size = new System.Drawing.Size(65, 45);
                btns[i].Text = "↓";
                btns[i].Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
                btns[i].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                this.Controls.Add(btns[i]);
            }

            // Pulsante Restart
            this.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnRefresh.BackColor = System.Drawing.Color.DimGray;
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(50, 530);
            this.btnRefresh.Size = new System.Drawing.Size(150, 45);
            this.btnRefresh.Text = "NUOVA PARTITA";
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            // Label Vittorie
            this.lblVittorie.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblVittorie.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblVittorie.Location = new System.Drawing.Point(220, 530);
            this.lblVittorie.Size = new System.Drawing.Size(630, 45);
            this.lblVittorie.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // Form Settings
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.lblVittorie);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.tplScacchiera);
            this.Controls.Add(this.lblTurno);
            this.Controls.Add(this.lblTitolo);
            this.MinimumSize = new System.Drawing.Size(700, 550);
            this.Text = "Forza 4 - BertMatt Edition";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblTitolo, lblTurno, lblVittorie;
        private System.Windows.Forms.Button btn1, btn2, btn3, btn4, btn5, btn6, btn7, btnRefresh;
        private System.Windows.Forms.TableLayoutPanel tplScacchiera;
    }
}