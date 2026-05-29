using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace EsDictionaryRubrica
{
    public partial class Form1 : Form
    {
        private Dictionary<string, Contatto> Rubrica;
        private List<string> lstContatti; //lista index -> key
        private void Form1_Load(object sender, EventArgs e)
        {
             Rubrica = new Dictionary<string, Contatto>();
             lstContatti = new List<string>();
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            Aggiungi agg = new Aggiungi(Rubrica, lstContatti);
            agg.ShowDialog();
            AggiornaLista();
        }

        private void btnElimina_Click(object sender, EventArgs e)
        {
            if (lstNumeri.SelectedIndex != -1)
            {
                Rubrica.Remove(lstContatti[lstNumeri.SelectedIndex]);
                lstContatti.RemoveAt(lstNumeri.SelectedIndex);
                MessageBox.Show("Contatto eliminato con successo!!");
                AggiornaLista();
            }
            else
            {
                MessageBox.Show("Clicca sulla lista il contatto da eliminare");
            }
        }

        public void AggiornaLista()
        {
            lstNumeri.Items.Clear();
            for (int i = 0; i < lstContatti.Count; i++)
            {
                string nome = lstContatti[i];
                Contatto c = Rubrica[nome];
                lstNumeri.Items.Add(nome + " - " + c.Print());
            }
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            if (lstNumeri.SelectedIndex != -1)
            {
                string nome = lstContatti[lstNumeri.SelectedIndex];
                Contatto c = Rubrica[nome];
                Modifica mod = new Modifica(Rubrica, lstContatti, nome, c);
                mod.ShowDialog();
                AggiornaLista();
            }
            else
            {
                MessageBox.Show("Clicca sulla lista il contatto da modificare");
            }
        }

        private void btnCerca_Click(object sender, EventArgs e)
        {
            string nome = Interaction.InputBox(
                "Inserisci nome ",
                "Ricerca ",
                ""
                );

            if (nome != "" && Rubrica.ContainsKey(nome))
            {
                lstNumeri.Items.Clear();
                Contatto c = Rubrica[nome];
                lstNumeri.Items.Add(nome + " - " + c.Print());
            }
            else
            {
                MessageBox.Show("Nome non trovato!");
                AggiornaLista();
            }
        }
    }
}
