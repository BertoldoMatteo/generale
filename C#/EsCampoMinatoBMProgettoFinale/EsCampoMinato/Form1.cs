using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace EsCampoMinato
{
    public partial class Form1 : Form
    {

        public int[,] posizioni;                                                            //array bidimensionale di interi per tenere traccia del valore di ogni cella(-1 = Mina/0 = Vuota /1-8 numero di mine adiacenti)
        public string[] arrMod = { "PRINCIPIANTE", "INTERMEDIO", "AVANZATO"};               //modalità di gioco
        public int[] dim = { 9, 16, 30};                                                    //array di interi per impostare il numero di celle per riga/colonna del "campo minato" in base alla difficoltà
        public int[] CELL_SIZE = { 25, 20, 18};                                             //array di interi per impostare la grandezza delle celle in base alla difficoltà
        public int[] mine = { 10, 40, 99};                                                  //array di interi per impostare il numero di mine in base alla difficoltà
        public Random rand;                                                                 //variabile di classe Random per il numero randomico, che serve per la collocazione delle mine
        public int x,y,n;                                                                   //variabili intere per coordinate
        public int rim;                                                                     //variabile intera per tenere traccia delle celle "vuote" rimaste
        public int mod = 0;                                                                 //variabile intera per tenere traccia della modalità in gioco
        public bool flag = false;                                                           //variabile booleana per attivare/disattivare modalità flag per ipotizzare le mine
        public float sec;                                                                   //variabile di tipo float per tenere traccia dei secondi che passano
        public int minrim;                                                                  //variabili per tenere traccia delle ipotesi di mine rimaste
        public int vinto = 0, perso = 0, arreso = 0;                                        //variabili intera per tenere traccia dei risultati delle partite
        public float timeVinto = 0, timePerso = 0, timeArreso = 0;                          //variabili di tipo float per tenere traccia del tempo delle partite
        public int celVinto = 0, celPerso = 0, celArreso = 0;                               //variabili intera per tenere traccia delle celle scoperte nelle partite
        public Statistiche stat;                                                            //dichiaro il form statistiche per la successiva apertura e invio dell'aggionamento dati


        //funzione eseguita dal programma per far apparire l'interfaccia
        public Form1()
        {
            InitializeComponent();
            rand = new Random();
        }

        //funzione che viene eseguita al caricamento del form iniziale
        private void Form1_Load(object sender, EventArgs e)
        {
            this.AutoScroll = true;
            tmr1.Start();
            Reset();
            stat = new Statistiche();
        }

        //funzione per eseguire il reset, ogni volta che vogliamo ripristinare il campo minato
        public void Reset()
        {
            DimensioneCampo(dim[mod]);
            ImpostazioniCampo();
            ColoraCampo();
            CaricaMine(mine[mod]);
            AggiornaCelRim((dim[mod] * dim[mod]) - mine[mod]);
            lblPunt.Text = vinto.ToString();
            lblMod.Text = arrMod[mod];
            AggiornaMinRim(mine[mod]);
            sec = 0;
        }

        //funzione per colorare tutto il campo coperto di grigio
        public void ColoraCampo()
        {
            for (int y = 0; y < dim[mod]; y++)
            {
                for (int x = 0; x < dim[mod]; x++)
                {
                    dtG[x, y].Style.BackColor = Color.Gray;
                }
            }
        }

        //funzione per impostare in maniera corretta il campo
        public void ImpostazioniCampo()
        {
            dtG.AllowUserToResizeColumns = false;
            dtG.AllowUserToResizeRows = false;
            dtG.ClearSelection();
            dtG.ScrollBars = ScrollBars.None;
            dtG.ReadOnly = true;
            dtG.RowHeadersVisible = false;
            dtG.ColumnHeadersVisible = false;
            dtG.DefaultCellStyle.SelectionBackColor = dtG.DefaultCellStyle.BackColor;
            dtG.DefaultCellStyle.SelectionForeColor = dtG.DefaultCellStyle.ForeColor;
        }

        //funzione per impostare il campo a inizio programma e in caso di reset
        public void DimensioneCampo(int n)
        {
            dtG.Columns.Clear();
            dtG.Rows.Clear();
            dtG.RowCount = n;
            dtG.ColumnCount = n;
            dtG.Width = CELL_SIZE[mod] * n;
            dtG.Height = CELL_SIZE[mod] * n;

            foreach (DataGridViewColumn col in dtG.Columns) col.Width = CELL_SIZE[mod];
            foreach (DataGridViewRow row in dtG.Rows) row.Height = CELL_SIZE[mod];

            pnlReset.Width = dtG.Width;

            pnlReset.Location = new Point(dtG.Location.X, dtG.Location.Y - pnlReset.Height - 6);
            btnReset.Location = new Point((pnlReset.Width - btnReset.Width) / 2, (pnlReset.Height - btnReset.Height) / 2);

            dtG.Enabled = true;
            posizioni = new int[n, n];
        }

        // funzione per caricare le mine sul campo
        public void CaricaMine(int m)
        {
            for(int i=0; i<m; i++)
            {
                do
                {
                    x = rand.Next(dtG.RowCount);
                    y = rand.Next(dtG.ColumnCount);

                } while (posizioni[y, x] == -1);

                posizioni[y, x] = -1;
                Attorno(y, x);  //funzione per caricare i numeri attorno
            }
        }

        //funzione per dare valore alle celle vicino alle mine. Aumento di 1 il valore di ogni cella adiacente ad una bomba
        public void Attorno(int y,int x)
        {
            if (y != 0) //striscia alta
            {
                if (x != 0) if (posizioni[y - 1, x - 1] != -1) posizioni[y - 1, x - 1] += 1;
                if (posizioni[y - 1, x] != -1) posizioni[y - 1, x] += 1;
                if (x != dim[mod]-1) if (posizioni[y - 1, x + 1] != -1) posizioni[y - 1, x + 1] += 1;
            }
            if (y != dim[mod]-1) //striscia bassa
            {
                if (x != 0) if (posizioni[y + 1, x - 1] != -1) posizioni[y + 1, x - 1] += 1;
                if (posizioni[y + 1, x] != -1) posizioni[y + 1, x] += 1;
                if (x != dim[mod]-1) if (posizioni[y + 1, x + 1] != -1) posizioni[y + 1, x + 1] += 1;
            }
            if (x != 0) if (posizioni[y, x - 1] != -1) posizioni[y, x - 1] += 1; //blocco sinistra
            if (x != dim[mod]-1) if(posizioni[y, x + 1] != -1) posizioni[y, x + 1] += 1; //blocco destra
        }

        //bottone per eseguire il Reset();
        private void btnArreso_Click(object sender, EventArgs e) => FinePartita(2);

        //bottone per cambiare difficolltà
        private void btnMod_Click(object sender, EventArgs e)
        {
            mod += 1;
            if (mod == 3) mod = 0;
            tmr1.Stop();
            arreso++;
            timeArreso += sec;
            celArreso += (dim[mod] * dim[mod]) - mine[mod] - rim;
            MessageBox.Show("MODALITA' CAMBIATE CON SUCCESSO. CMQ TI SEI ARRESO");
            Reset();
            tmr1.Start();
        }

        //bottone per cambiare modalità di click (se il pulsante è rosso, piazzo bandiere ovvero "ipotesi di mine")
        private void btnBandiera_Click(object sender, EventArgs e)
        {
            flag = !flag;
            if (flag == true) btnBandiera.BackColor = Color.Red;
            else btnBandiera.BackColor = Color.LightGray;

        }

        //bottone per azzerare tutte le variabili di gioco e Reset();
        private void btnResetTotale_Click(object sender, EventArgs e)
        {
            vinto = 0;
            perso = 0;
            arreso = 0;
            timeVinto = 0;
            timePerso = 0;
            timeArreso = 0;
            celVinto = 0;
            celPerso = 0;
            celArreso = 0;
            tmr1.Stop();
            MessageBox.Show("Fine Partita. Reset Completo");
            Reset();
            tmr1.Start();        
        }

        //bottone per visualizzare le statistiche partite a schermo
        private void btnStat_Click(object sender, EventArgs e) => stat.Show();

        //bottone per visualizzare istruzioni di gioco
        private void btnAiuto_Click(object sender, EventArgs e)
        {
            Aiuto aiuto = new Aiuto();
            aiuto.ShowDialog();
        }

        //temporizzazione del tempo che lo aumenta di 0,1 ogni 100 millisecondi
        private void tmr1_Tick(object sender, EventArgs e)
        {
            sec += (float)0.1;
            lblTempo.Text =  sec < 100 ? sec.ToString("F1") + "s" : ((int)sec).ToString() + "s";

        }

        //evento che accade al click di una cella della DataGridView (campo minato)
        private void dtG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (flag == true)
            {
                if (dtG[e.ColumnIndex, e.RowIndex].Style.BackColor != Color.Red && minrim > 0)
                {
                    dtG[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Red;
                    AggiornaMinRim(--minrim);
                }
                else
                {
                    dtG[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Gray;
                    AggiornaMinRim(++minrim);
                }
            }
            else
            {
                if (dtG[e.ColumnIndex, e.RowIndex].Style.BackColor == Color.Gray)
                    Mostra(e.RowIndex, e.ColumnIndex);
            }
        }

        //se clicco una cella della griglia con tasto destro piazzo le supposizioni di dove sono le bombe
        private void dtG_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (dtG[e.ColumnIndex, e.RowIndex].Style.BackColor == Color.Gray && minrim > 0)
                {
                    dtG[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Red;
                    AggiornaMinRim(--minrim); //metto il -- davanti alla variabile pk prima deve avvenire la sottrazione e poi il passaggio del valore

                }
                else if (dtG[e.ColumnIndex, e.RowIndex].Style.BackColor == Color.Red)
                {
                    dtG[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Gray;
                    AggiornaMinRim(++minrim); //metto il ++ davanti alla variabile pk prima deve avvenire la somma e poi il passaggio del valore
                }

            }
        }

        //evento che mostra la cella sottostante e fa partire evento finePartita se si clicca una mina o se si sono cliccate tutte le celle libere da mine
        public void Mostra(int y, int x)
        {
            if (posizioni[y, x] == -1)
            {
                Colora(y, x);
                FinePartita(1); //se becchi la bombe
            }
            else if (posizioni[y, x] != 0)
            {
                Colora(y, x); //se becchi celle vicino bomba
            }
            else // se becchi celle vuote si espande
            {
                Espandi(y, x);
            }
            if (rim == 0)
            {
                FinePartita(0); //vittoria per aver trovato tutte le celle senza mina
            }

        }

        //funzione per espandere la zona che viene cliccata, nel caso questa sia "vuota", non abbia mine adiacenti
        public void Espandi(int y, int x)
        {
            if (y < 0 || y >= dim[mod] || x < 0 || x >= dim[mod]) return;

            if (dtG[x, y].Style.BackColor == Color.White) return;

            if (dtG[x, y].Style.BackColor == Color.Red) AggiornaMinRim(++minrim); 

            Colora(y, x);
            

            if (posizioni[y, x] != 0) return;


            Espandi(y - 1, x - 1); // Alto-Sinistra
            Espandi(y - 1, x);     // Alto
            Espandi(y - 1, x + 1); // Alto-Destra

            Espandi(y, x - 1);     // Sinistra
            Espandi(y, x + 1);     // Destra

            Espandi(y + 1, x - 1); // Basso-Sinistra
            Espandi(y + 1, x);     // Basso
            Espandi(y + 1, x + 1); // Basso-Destra
        }

        //funzione per calcolare la cella del colore corrispondente
        public void Colora(int y, int x)
        {
            if (posizioni[y, x] == -1)
            {
                dtG[x, y].Style.BackColor = Color.Red;
                return;
            }
            AggiornaCelRim(--rim);
            dtG[x, y].Style.BackColor = Color.White;
            switch (posizioni[y, x])
            {
                case 0:
                    dtG[x, y].Style.ForeColor = Color.White;
                    break;
                case 1:
                    dtG[x, y].Value = 1;
                    dtG[x, y].Style.ForeColor = Color.Blue;
                    break;
                case 2:
                    dtG[x, y].Value = 2;
                    dtG[x, y].Style.ForeColor = Color.Green;
                    break;
                case 3:
                    dtG[x, y].Value = 3;
                    dtG[x, y].Style.ForeColor = Color.Red;
                    break;
                case 4:
                    dtG[x, y].Value = 4;
                    dtG[x, y].Style.ForeColor = Color.DarkViolet;
                    break;
                case 5:
                    dtG[x, y].Value = 5;
                    dtG[x, y].Style.ForeColor = Color.Brown;
                    break;
                case 6:
                    dtG[x, y].Value = 6;
                    dtG[x, y].Style.ForeColor = Color.Cyan;
                    break;
                case 7:
                    dtG[x, y].Value = 7;
                    dtG[x, y].Style.ForeColor = Color.Black;
                    break;
                case 8:
                    dtG[x, y].Value = 8;
                    dtG[x, y].Style.ForeColor = Color.Gray;
                    break;
            }
        }

        //funzione per mostrare tutto il campo scoperto
        public void MostraCampo()
        {
            for (int y = 0; y < dim[mod]; y++)
            {
                for (int x = 0; x < dim[mod]; x++)
                {
                    Colora(y, x);
                }
            }
        }

        //aggirono valori delle variabili e delle label per indicare le supposizioni mine rimaste
        public void AggiornaMinRim(int min)
        {
            if (min <= 0) MessageBox.Show("Hai finito le bandierine disponibili");
            minrim = min;
            lblMineRim.Text = minrim.ToString();

        }

        //aggirono valori delle variabili e delle label per indicare le celle non mine rimaste
        public void AggiornaCelRim(int cel)
        {
            rim = cel;
            lblCelleRim.Text = rim.ToString();
        }

        //funzione di fine partita : 0 = VINTO - 1 = PERSO - 2 = ARRESO
        public void FinePartita(int end)
        {
            tmr1.Stop();
            Console.Beep();
            switch (end)
            {
                case 0:
                    vinto++;
                    lblPunt.Text = vinto.ToString();
                    timeVinto += sec;
                    celVinto += (dim[mod] * dim[mod]) - mine[mod];
                    MessageBox.Show("HAI VINTO!!");
                    break;
                case 1:
                    perso++;
                    timePerso += sec;
                    celPerso += (dim[mod] * dim[mod]) - mine[mod] - rim;
                    MostraCampo();
                    lblCelleRim.Text = "000";
                    MessageBox.Show("HAI PERSO!! BOOM!!");
                    break;
                case 2:

                    arreso++;
                    timeArreso += sec;
                    celArreso += (dim[mod] * dim[mod]) - mine[mod] - rim;
                    MostraCampo();
                    lblCelleRim.Text = "000";
                    MessageBox.Show("TI SEI ARRESO!!");
                    break;
            }
            Reset();

            if (stat != null && !stat.IsDisposed)
            {
                stat.AggiornaStat(vinto, perso, arreso, timeVinto, timePerso, timeArreso, celVinto, celPerso, celArreso);
            }
            tmr1.Start();
        }
    }
}

