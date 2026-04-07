using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.PerformanceData;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace EsFantasyParkBM
{
    public partial class BigliettiForm : Form
    {
        public enum Tipo
        {
            Club,
            Platinum,
            Gold,
            Silver
        }

        public struct Biglietto
        {
            public int id;
            public DateTime date;
            public Tipo type;
            public string name;
            public Biglietto(int id, DateTime data, Tipo tipo, string nome)
            {
                this.name = nome;
                this.id = id;
                this.date = data;
                this.type = tipo;
            }

            public string Calcolaid(int id)
            {
                return id < 10 ? "000" + id.ToString() : id < 100 ? "00" + id.ToString() : id < 1000 ? "0" + id.ToString() : id.ToString();
            }

            public string stampa()
            {
                string codice = Calcolaid(this.id);
                return $"ID: {codice}, NAME: {this.name}, TYPE: {this.type}, DATE: {this.date};";
            }

            public string print()
            {
                string codice = Calcolaid(this.id);
                return $"{codice},{this.name},{this.type},{this.date}";
            }
        }
        
        public Biglietto biglietto;
        public List<Biglietto> bigliettoList;
        public string tipo;
        public int countid, idtemp;
        public bool trovato, notifiche;

        public BigliettiForm()
        {
            InitializeComponent();
            bigliettoList = new List<Biglietto>();
            LeggiCSV();
            cmbTipo.DataSource = Enum.GetValues(typeof(Tipo));
            trovato = false;
            notifiche = true;
        }


        public void Lista()
        {
            lstBiglietti.Items.Clear();
            foreach (Biglietto big in bigliettoList)
            {
                lstBiglietti.Items.Add(big.stampa());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Controllo())
            {
                lstBiglietti.Items.Add(biglietto.stampa());
                bigliettoList.Add(biglietto);
                AggiornaCSV();
            }
        }

        public void AggiornaCSV()
        {
            using(StreamWriter sw = new StreamWriter("biglietti.csv"))
            {
                sw.WriteLine("ID,NAME,TIPO,DATE");
                foreach(Biglietto big in bigliettoList)
                {
                    sw.WriteLine(big.print());
                }
            }
        }

        public void LeggiCSV()
        {
            if (File.Exists("biglietti.csv"))
            {
                using(StreamReader sr = new StreamReader("biglietti.csv"))
                {
                    sr.ReadLine();
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(',');
                        biglietto = new Biglietto();
                        biglietto.id = int.Parse(line[0]);
                        biglietto.name = line[1];
                        biglietto.type = (Tipo)Enum.Parse(typeof(Tipo), line[2]);
                        biglietto.date = DateTime.Parse(line[3]);
                        countid = biglietto.id;
                        bigliettoList.Add(biglietto);
                    }
                }
                Lista();
            }
            else
            {
                File.WriteAllText("biglietti.csv", "ID,NAME,TIPO,DATE");
                if(notifiche) MessageBox.Show("File creato correttamente");
                LeggiCSV();
            }
        }

        public bool Controllo()
        {
            biglietto = new Biglietto();
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                if (notifiche) MessageBox.Show("Inserisci il nome del visitatore");
                return false;
            }

            biglietto.name = txtNome.Text;

            if(cmbTipo.SelectedIndex == -1)
            {
                if (notifiche) MessageBox.Show("Inserisci il tipo di biglietto");
                return false;
            }

            biglietto.type = (Tipo)cmbTipo.SelectedIndex;

            if (dtTData.Value.CompareTo(DateTime.Today) < 0)
            {
                if (notifiche) MessageBox.Show("Inserisci data valida");
                return false;
            }

            biglietto.date = dtTData.Value;
            countid++;
            biglietto.id = countid;
            

            return true;
        }

        private void rdbSi_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbSi.Checked) notifiche = true;
            else notifiche = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string ricerca = Interaction.InputBox(
                "Inserisci id di ricerca (scrivi all per reset)",
                "RICERCA PER ID (di 4 cifre)",
                ""
                );
            if (ricerca == "")
            {
                if (notifiche) MessageBox.Show("Inserisci codice biglietto");
            }
            else if (ricerca == "all")
            {
                Lista();
            }
            else if (ricerca.Length != 4)
            {
                if (notifiche) MessageBox.Show("Inserisci il codice a 4 cifre");
            }
            else
            {
                foreach (Biglietto big in bigliettoList)
                {
                    if (int.Parse(ricerca) == big.id)
                    {
                        lstBiglietti.Items.Clear();
                        lstBiglietti.Items.Add(big.stampa());
                        trovato = true;
                    }
                }
                if (!trovato) if(notifiche) MessageBox.Show("Biglietto inesistente");
                trovato = false;
            }       
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            if(lstBiglietti.SelectedIndex != -1)
            {
                idtemp = int.Parse(lstBiglietti.SelectedItem.ToString().Substring(4, 4));
                for (int i = 0; i < bigliettoList.Count; i++) if (bigliettoList[i].id == idtemp) bigliettoList.RemoveAt(i);
                Lista();
                AggiornaCSV();
                if (notifiche) MessageBox.Show("Biglietto Eliminato correttamente");
            }
            else
            {
                if (notifiche) MessageBox.Show("Selezionare biglietto da eliminare nella ListBox");
            }
        }
    }
}
