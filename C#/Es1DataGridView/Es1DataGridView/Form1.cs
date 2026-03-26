namespace Es1DataGridView
{
    public partial class Form1 : Form
    {
        int giocatore = 1;
        //i giocatori saranno due, contrassegnati 0 e 1
        int punti1 = 0;
        int punti0 = 0;
        int difficoltà = 5;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.RowHeadersWidth = 50;
            dataGridView1.ColumnHeadersHeight = 50;

            //permette di selezionare una singola cella alla volta, invece di selezionare righe intere o colonne intere.
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;

            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;

            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ColumnHeadersVisible = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            int c = e.ColumnIndex;
            
            int punti = Convert.ToInt16(dataGridView1.Rows[r].Cells[c].Value);
           
            giocatore = (1 + giocatore) % 2; //alterna 0 e 1

            //Se clicchi una cella già scelta, perdi subito.
            if ((dataGridView1.Rows[r].Cells[c].Style.BackColor == Color.Red)

            || dataGridView1.Rows[r].Cells[c].Style.BackColor == Color.Aqua)
                punti = 22; //il giocatore corrente perderà!!!
          
            if (giocatore == 0)
            {
                dataGridView1.Rows[r].Cells[c].Style.BackColor = Color.Red;
               
                dataGridView1.ClearSelection();
                punti0 += punti;
                
                if (punti0 > 21)
                {
                    dataGridView1.Enabled = false;
                    MessageBox.Show("Vince il Blu");
                
                    button1.Enabled = true;
                    button2.Enabled = true; //TAFF
                    button3.Enabled = true;
                }
                else if (punti0 == 21)
                {
                    dataGridView1.Enabled = false;
                    MessageBox.Show("Vince il Rosso");
                    button1.Enabled = true;
                    button2.Enabled = true; //TAFF
                    button3.Enabled = true;
                }
            }
            else //giocatore == 1
            {
                dataGridView1.Rows[r].Cells[c].Style.BackColor = Color.Aqua;
                dataGridView1.ClearSelection();
                punti1 += punti;
                if (punti1 > 21)
                {
                    dataGridView1.Enabled = false;
                    MessageBox.Show("Vince il Rosso");
                    button1.Enabled = true;
                    button2.Enabled = true; //TAFF
                    button3.Enabled = true;
                }
                else if (punti1 == 21)
                {
                    dataGridView1.Enabled = false;
                    MessageBox.Show("Vince il Blu");
                    button1.Enabled = true;
                    button2.Enabled = true; //TAFF
                    button3.Enabled = true;
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //valori di inizio gioco
            giocatore = 1; //i giocatori saranno due, contrassegnati 0 e 1
            punti1 = 0;
            punti0 = 0;
            button2.Enabled = false;
            button3.Enabled = false;

            //imposta dimensioni tavola
            dataGridView1.RowCount = difficoltà;
            dataGridView1.ColumnCount = difficoltà;
            
            //scrive valori nella tavola
            Random valori = new Random();
            for (int r = 0; r < difficoltà; r++)
                for (int c = 0; c < difficoltà; c++)
                    dataGridView1.Rows[r].Cells[c].Value = valori.Next(0, 10);
            dataGridView1.ClearSelection();
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            difficoltà++;
            button1.Text = "" + difficoltà;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            difficoltà--;
            button1.Text = "" + difficoltà;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string s = "devi fare 21 col tuo colore";
            MessageBox.Show(s);
        }
    }
}
