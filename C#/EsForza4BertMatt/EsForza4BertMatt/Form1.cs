using System;
using System.Drawing;
using System.Windows.Forms;

namespace EsForza4BertMatt
{
    public partial class Form1 : Form
    {
        private int[,] griglia = new int[6, 7]; // 0=Vuoto, 1=Rosso, -1=Blu
        private int turno = 1;
        private bool giocoFinito = false;
        private int vittorieRosso = 0, vittorieBlu = 0;

        public Form1()
        {
            InitializeComponent();
            ConfiguraEventi();
            NuovaPartita();
        }

        private void ConfiguraEventi()
        {
            btn1.Click += (s, e) => EseguiMossa(0);
            btn2.Click += (s, e) => EseguiMossa(1);
            btn3.Click += (s, e) => EseguiMossa(2);
            btn4.Click += (s, e) => EseguiMossa(3);
            btn5.Click += (s, e) => EseguiMossa(4);
            btn6.Click += (s, e) => EseguiMossa(5);
            btn7.Click += (s, e) => EseguiMossa(6);
            btnRefresh.Click += (s, e) => NuovaPartita();

            // Ri-allinea i bottoni quando la finestra viene ridimensionata
            this.Resize += (s, e) => AllineaBottoni();
        }

        private void NuovaPartita()
        {
            giocoFinito = false;
            turno = 1;
            griglia = new int[6, 7];
            tplScacchiera.Controls.Clear();

            for (int r = 0; r < 6; r++)
            {
                for (int c = 0; c < 7; c++)
                {
                    Panel p = new Panel
                    {
                        Dock = DockStyle.Fill,
                        BackColor = Color.White,
                        Margin = new Padding(4)
                    };
                    tplScacchiera.Controls.Add(p, c, r);
                }
            }
            AggiornaStato();
            AllineaBottoni();
        }

        private void EseguiMossa(int colonna)
        {
            if (giocoFinito) return;

            for (int r = 5; r >= 0; r--) // Cerca la prima riga libera dal basso
            {
                if (griglia[r, colonna] == 0)
                {
                    griglia[r, colonna] = turno;
                    Control cella = tplScacchiera.GetControlFromPosition(colonna, r);
                    cella.BackColor = (turno == 1) ? Color.Red : Color.Blue;

                    if (ControllaVittoria(r, colonna))
                    {
                        giocoFinito = true;
                        if (turno == 1) vittorieRosso++; else vittorieBlu++;
                        AggiornaStato();
                        MessageBox.Show("FINE PARTITA: Ha vinto il giocatore " + (turno == 1 ? "ROSSO" : "BLU") + "!");
                        return;
                    }

                    turno = -turno; // Cambio turno
                    AggiornaStato();
                    return;
                }
            }
        }

        private void AggiornaStato()
        {
            // 1. Label testo
            lblTurno.Text = "TURNO ATTUALE: " + (turno == 1 ? "ROSSO" : "BLU");
            lblTurno.ForeColor = (turno == 1) ? Color.Red : Color.Blue;
            lblVittorie.Text = $"Punteggio Generale | ROSSO: {vittorieRosso}  -  BLU: {vittorieBlu}";

            // 2. Gestione Bottoni (Colori e Disabled)
            Button[] btns = { btn1, btn2, btn3, btn4, btn5, btn6, btn7 };
            Color coloreTurno = (turno == 1) ? Color.Red : Color.Blue;

            for (int i = 0; i < 7; i++)
            {
                if (giocoFinito)
                {
                    btns[i].Enabled = false;
                    btns[i].BackColor = Color.LightGray;
                }
                else if (griglia[0, i] != 0) // Colonna piena (riga 0 occupata)
                {
                    btns[i].Enabled = false;
                    btns[i].BackColor = Color.DimGray;
                    btns[i].ForeColor = Color.White;
                }
                else
                {
                    btns[i].Enabled = true;
                    btns[i].BackColor = coloreTurno;
                    btns[i].ForeColor = Color.White;
                }
            }
        }

        private void AllineaBottoni()
        {
            Button[] btns = { btn1, btn2, btn3, btn4, btn5, btn6, btn7 };
            float colWidth = (float)tplScacchiera.Width / 7;
            for (int i = 0; i < 7; i++)
            {
                // Centra ogni bottone esattamente sopra la colonna della griglia
                btns[i].Left = tplScacchiera.Left + (int)(i * colWidth) + (int)(colWidth / 2) - (btns[i].Width / 2);
                btns[i].Top = tplScacchiera.Top - 55;
            }
        }

        private bool ControllaVittoria(int r, int c)
        {
            return (Conta(r, c, 0, 1) >= 4 ||  // Orizzontale
                    Conta(r, c, 1, 0) >= 4 ||  // Verticale
                    Conta(r, c, 1, 1) >= 4 ||  // Diagonale \
                    Conta(r, c, 1, -1) >= 4);   // Diagonale /
        }

        private int Conta(int r, int c, int dr, int dc)
        {
            int count = 1;
            // Direzione avanti
            count += ContaDirezione(r, c, dr, dc);
            // Direzione opposta
            count += ContaDirezione(r, c, -dr, -dc);
            return count;
        }

        private int ContaDirezione(int r, int c, int dr, int dc)
        {
            int t = 0;
            int nr = r + dr;
            int nc = c + dc;
            while (nr >= 0 && nr < 6 && nc >= 0 && nc < 7 && griglia[nr, nc] == turno)
            {
                t++;
                nr += dr;
                nc += dc;
            }
            return t;
        }
    }
}