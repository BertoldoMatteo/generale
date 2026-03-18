using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace EsRicettaDigBM
{
    public partial class Form1 : Form
    {
        public enum Frolla
        {
            Classica,
            Integrale,
            Sablé,
            Montana,
            Milano,
            al_Cacao
        }

        public enum Marmellata
        {
            Arance,
            Limoni,
            Mandarini,
            Albicocche,
            Fragole,
            Pesche
        }

        public struct Ricetta
        {
            public int id;
            public Frolla frolla;
            public Marmellata marmellata;
            public int tempo;
            public int diametro;
            public char decorazione;
            public string name;


            public Ricetta(int id, Frolla frolla, Marmellata marmellata, int tempo, int diametro, char decorazione, string name)
            {
                this.id = id;
                this.frolla = frolla;
                this.marmellata = marmellata;
                this.tempo = tempo;
                this.diametro = diametro;
                this.decorazione = decorazione;
                this.name = name;
            }

            public string stampa()
            {
                return $"N° {this.id} -name : {this.name} -frolla : {this.frolla} -marmellata : {this.marmellata} -tempo : {this.tempo} -diametro : {this.diametro} -decorazione{this.decorazione}";
            }

            public string print()
            {
                return $"{this.id};{this.name};{this.frolla};{this.marmellata};{this.tempo};{this.diametro};{this.decorazione}";
            }
        }

        public string namefile = "ricette.csv";
        public string[] riga, elementi;
        public List<Ricetta> lstRicette;
        public Ricetta ricetta;
        public int count;
        
        public Form1()
        {
            InitializeComponent();
            cmbFrolla.DataSource = Enum.GetValues(typeof(Frolla));
            cmbMarmellata.DataSource = Enum.GetValues(typeof(Marmellata));
            lstRicette = new List<Ricetta>();
            riga = new string[10];
            elementi = new string[10];
            count = 0;
            download();
        }

        public void download()
        {
            if (File.Exists(namefile))
            {
                riga = File.ReadAllLines(namefile);
                for(int i=1; i<riga.Length; i++)
                {
                    elementi = riga[i].Split(';');
                    Estrai();
                    count++;
                }
                CaricaLista();
            }
        }

        public void Estrai()
        {
            ricetta.id = int.Parse(elementi[0]);
            ricetta.name = elementi[1];
            Frolla.TryParse(elementi[2], ignoreCase: true, out Frolla frolla);
            ricetta.frolla = frolla;
            Marmellata.TryParse(elementi[3], ignoreCase: true, out Marmellata marmellata);
            ricetta.marmellata = marmellata;
            ricetta.tempo = int.Parse(elementi[4]);
            ricetta.diametro = int.Parse(elementi[5]);
            ricetta.decorazione = char.Parse(elementi[6]);
            lstRicette.Add(ricetta);
        }

        private void txtTempoCottura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '-')
            {
                e.KeyChar = (char)0;
            }
        }

        private void txtDiametro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '-')
            {
                e.KeyChar = (char)0;
            }
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            if (Controllo())
            {
                ricetta.id = count;
                ricetta.name = txtNome.Text;
                ricetta.frolla = (Frolla)cmbFrolla.SelectedIndex;
                ricetta.marmellata = (Marmellata)cmbMarmellata.SelectedIndex;
                ricetta.tempo = int.Parse(txtTempoCottura.Text);
                ricetta.diametro = int.Parse(txtDiametro.Text);
                if (rdbF.Checked) ricetta.decorazione = 'F';
                else ricetta.decorazione = 'T';
                lstRicette.Add(ricetta);
                CaricaLista();
                count++;
            }
        }

        public bool Controllo()
        {
            if(cmbFrolla.SelectedIndex == -1)
            {
                MessageBox.Show("Inserisci il tipo di Frolla");
                return false;
            }
            if(cmbMarmellata.SelectedIndex == -1)
            {
                MessageBox.Show("Inserisci il tipo di marmellata");
                return false;
            }
            if(int.Parse(txtTempoCottura.Text)<=0 || int.Parse(txtTempoCottura.Text) >= 1440)
            {
                MessageBox.Show("Inserisci un tempo di cottura valido : >0 e <1440 min (24 ore)");
                return false;
            }
            if(int.Parse(txtDiametro.Text) <= 0 || int.Parse(txtDiametro.Text) >= 120)
            {
                MessageBox.Show("Inserisci un diametro valido : >0 e < 120 min (1,20 m)");
                return false;
            }
            if(txtNome.Text == "")
            {
                MessageBox.Show("Inserisci un nome alla ricetta");
                return false;
            }
            if(!rdbT.Checked && !rdbF.Checked)
            {
                MessageBox.Show("Inserisci l'opzione di decorazione (SI/NO)");
                return false;
            }
            return true;
        }

        private void btnRicerca_Click(object sender, EventArgs e)
        {
            string nome = Interaction.InputBox("Inserisci ricetta", "RICERCA", "");
            if(nome.Length != 0)
            {
                lstElenco.Items.Clear();
                foreach(Ricetta r in lstRicette)
                {
                    if (r.name == nome) lstElenco.Items.Add(r.stampa());
                }
            }
        }

        private void btnSsave_Click(object sender, EventArgs e)
        {
            File.WriteAllText(namefile, "");
            File.AppendAllText(namefile, "ID;NAME;FROLLA;MARMELLATA;TEMPO;DIAMETRO;DECORAZIONE" + "\n");
            foreach (Ricetta r in lstRicette) File.AppendAllText(namefile, r.print() + "\n");

        }

        public void CaricaLista()
        {
            lstElenco.Items.Clear();
            lstRicette = lstRicette.OrderBy(r => r.name).ToList();
            foreach (Ricetta r in lstRicette)
            {
                lstElenco.Items.Add(r.stampa());
            }
        }
    }
}
