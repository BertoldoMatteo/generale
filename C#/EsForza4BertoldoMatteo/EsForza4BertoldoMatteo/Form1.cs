using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsForza4BertoldoMatteo
{
    public partial class Form1 : Form
    {
        public int[,] arrbid;
        public bool Turno; //true = red ; false = blu;
        public int pos, turn, count;

        public Form1()
        {
            InitializeComponent();
            arrbid = new int[6, 7];
            Turno = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtG.RowCount = 6;
            dtG.ColumnCount = 7;
            dtG.RowHeadersVisible = false;
            dtG.ColumnHeadersVisible = false;

            int cellW = dtG.Width / 7;
            int cellH = dtG.Height / 6;

            foreach(DataGridViewColumn col in dtG.Columns) col.Width = cellW;

            foreach(DataGridViewRow row in dtG.Rows) row.Height = cellH;

            dtG.Enabled = false;

            lblRed.Text = "0";
            lblBlu.Text = "0";
        }

        public int Aggiungi(int c)
        {
            for (int r = 5; r >= 0; r--)
            {
                if (arrbid[r, c] != 0) continue;
                arrbid[r, c] = Turno ? 1 : -1;
                dtG.Rows[r].Cells[c].Style.BackColor = Turno ? Color.Red : Color.Blue;
                if (r == 0) DisabilitaBottone(c);
                return r;
            }
            return -1;
        }
        public void DisabilitaBottone(int c)
        {
            switch (c)
            {
                case 0: btn1.Enabled = false; break;
                case 1: btn2.Enabled = false; break;
                case 2: btn3.Enabled = false; break;
                case 3: btn4.Enabled = false; break;
                case 4: btn5.Enabled = false; break;
                case 5: btn6.Enabled = false; break;
                case 6: btn7.Enabled = false; break;
            }
        }

        public void CambioTurno()
        {
            Turno = !Turno;
            Color c = Turno ? Color.Red : Color.Blue;
            lblTurno.Text = Turno ? "RED" : "BLUE";
            btn1.BackColor = btn2.BackColor = btn3.BackColor = btn4.BackColor =
            btn5.BackColor = btn6.BackColor = btn7.BackColor = c;
            
        }

        public bool Controllo4(int r, int c)
        {
            turn = arrbid[r, c];
            return (Conta(r, c, 0, 1) >= 4 ||
                    Conta(r, c, 1, 0) >= 4 ||
                    Conta(r, c, 1, 1) >= 4 ||
                    Conta(r, c, 1, -1) >= 4 );
        }

        public int Conta(int r, int c, int dirv, int diro)
        {
            count = 1;
            count += ContaDir(r, c, dirv, diro);
            count += ContaDir(r, c, -dirv, -diro);
            return count;
        }

        public int ContaDir(int r, int c, int dirv, int diro)
        {
            int p = 0;
            int nr = r + dirv;
            int nc = c + diro;
            while(nr >=0 && nr < 6 && nc >= 0 && nc < 7 && arrbid[nr, nc] == turn)
            {
                p++;
                nr += dirv;
                nc += diro;
            }
            return p;
        }

        private void GestisciMossa(int colonna)
        {
            pos = Aggiungi(colonna);
            if (pos == -1) return; // colonna piena, non dovrebbe succedere se il bottone è disabilitato

            if (Controllo4(pos, colonna))
            {
                if (Turno) lblRed.Text = (int.Parse(lblRed.Text) + 1).ToString();
                else lblBlu.Text = (int.Parse(lblBlu.Text) + 1).ToString();
                MessageBox.Show("FINE PARTITA: Ha vinto il giocatore " + (Turno ? "ROSSO" : "BLU") + "!");
                return;
            }
            CambioTurno();
        }

        private void ResetGriglia()
        {
            arrbid = new int[6, 7];
            for (int r = 0; r < 6; r++)
                for (int c = 0; c < 7; c++)
                    dtG.Rows[r].Cells[c].Style.BackColor = Color.Empty;
            btn1.Enabled = btn2.Enabled = btn3.Enabled = btn4.Enabled =
            btn5.Enabled = btn6.Enabled = btn7.Enabled = true;
            Turno = false;
            CambioTurno(); // ritorna a RED
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            ResetGriglia();
        }
        private void btnResetGame_Click(object sender, EventArgs e)
        {
            ResetGriglia();
            lblBlu.Text = "0";
            lblRed.Text = "0";
        }

        private void btn1_Click(object sender, EventArgs e) => GestisciMossa(0);
        private void btn2_Click(object sender, EventArgs e) => GestisciMossa(1);
        private void btn3_Click(object sender, EventArgs e) => GestisciMossa(2);
        private void btn4_Click(object sender, EventArgs e) => GestisciMossa(3);
        private void btn5_Click(object sender, EventArgs e) => GestisciMossa(4);
        private void btn6_Click(object sender, EventArgs e) => GestisciMossa(5);
        private void btn7_Click(object sender, EventArgs e) => GestisciMossa(6);
    }
}
