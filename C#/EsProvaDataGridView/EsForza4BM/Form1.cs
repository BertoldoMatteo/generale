using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsForza4BM
{
    public partial class Form1 : Form
    {
        public int giocatore = 1;
        public int punti1 = 0;
        public int punti0 = 0;
        public int difficoltà = 5;

        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dtG.CurrentCell.RowIndex;
            int c = dtG.CurrentCell.ColumnIndex;
            int punti = Convert.ToInt16(dtG.Rows[r].Cells[c].Value);

            giocatore = (1 + giocatore) % 2;

            if (dtG.Rows[r].Cells[c].Style.BackColor == Color.Red ||
                dtG.Rows[r].Cells[c].Style.BackColor == Color.Aqua)
                punti = 22;

            // BUG 2 FIX: assegna punti e colore PRIMA di alternare il giocatore
            if (giocatore == 1) // turno Blu
            {
                dtG.Rows[r].Cells[c].Style.BackColor = Color.Aqua;
                dtG.ClearSelection();
                punti1 += punti;

                // BUG 3 FIX: messaggi corretti — chi sfora 21 perde, chi fa 21 vince
                if (punti1 > 21)
                {
                    dtG.Enabled = false;
                    MessageBox.Show("Vince il Rosso");
                    btn1.Enabled = false;
                }
                else if (punti1 == 21)
                {
                    dtG.Enabled = false;
                    MessageBox.Show("Vince il Blu");
                    btn1.Enabled = false;
                }
            }
            else // giocatore == 0, turno Rosso
            {
                dtG.Rows[r].Cells[c].Style.BackColor = Color.Red;
                dtG.ClearSelection();
                punti0 += punti;

                if (punti0 > 21)
                {
                    dtG.Enabled = false;
                    MessageBox.Show("Vince il Blu");
                    btn1.Enabled = false;
                }
                else if (punti0 == 21)
                {
                    dtG.Enabled = false;
                    MessageBox.Show("Vince il Rosso");
                    btn1.Enabled = false;
                }
            }

            // BUG 2 FIX: alterna il giocatore DOPO aver gestito il turno corrente
            giocatore = (1 + giocatore) % 2;
            btn1.Enabled = false;
        }

        private void dtG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Abilita btn1 quando il giocatore seleziona una cella
            btn1.Enabled = true;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            giocatore = 1;
            punti1 = 0;
            punti0 = 0;
            btn2.Enabled = true;
            btn3.Enabled = true;

            dtG.RowCount = difficoltà;
            dtG.ColumnCount = difficoltà;
            

            Random valori = new Random();
            for (int r = 0; r < difficoltà; r++)
                for (int c = 0; c < difficoltà; c++)
                {
                    dtG.Rows[r].Cells[c].Value = valori.Next(0, 10);
                    // BUG 1 FIX: resetta il colore delle celle ad ogni nuova partita
                    dtG.Rows[r].Cells[c].Style.BackColor = Color.White;
                }

            dtG.ClearSelection();
            dtG.Enabled = true;
            btn1.Enabled = false;
            
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            difficoltà++;
            // BUG 4 FIX: aggiorna btn2 stesso, non btn1
            btn2.Text = "+" + difficoltà;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (difficoltà > 1) difficoltà--;
            // BUG 4 FIX: aggiorna btn3 stesso, non btn1
            btn3.Text = "-" + difficoltà;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            string s = "devi fare 21 col tuo colore";
            MessageBox.Show(s);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtG.RowHeadersWidth = 25;
            dtG.ColumnHeadersHeight = 25;
            dtG.SelectionMode = DataGridViewSelectionMode.CellSelect; //FullRowSelect-FullColumnSelect
            dtG.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            dtG.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dtG.RowHeadersVisible = false;
            dtG.ColumnHeadersVisible = false; //intestazione non visibile
        }
    }
}