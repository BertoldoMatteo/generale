using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsCreatMagBM
{
    public enum Razza{
        Drago,
        Elfo,
        Troll,
        Fata
    }

    public struct Creatura
    {
        public string Nome;
        public Razza razza;
        public double LivelloMagia;
        public int count;

        public Creatura(string name, Razza razz, double level, int counter)
        {
            Nome= name;
            razza = razz;
            LivelloMagia= level;
            count = counter;
        }

        public string ToString()
        {
            return $"CREATURA {count}  Nome: {Nome}  Razza: {razza}  Livello Magia: {LivelloMagia}";
        }
    }



    public partial class Form1 : Form
    {
        public List<Creatura> creature = new List<Creatura>();
        public List<Creatura> filtrRazza = new List<Creatura>();
        int count;
        bool trovato;
        string str;
        double media, somma;
        public Form1()
        {
            str = "";
            trovato = false;
            count = 0; somma=0;
            InitializeComponent();
            cmbRazza.DataSource = Enum.GetValues(typeof(Razza));
            for (int i = 0; i <= 10; i++)
            {
                cmbMagia.Items.Add(i);
            }
        }

        private void btnAvvia_Click_1(object sender, EventArgs e)
        {
            pnlAvvia.Visible = false;
            MessageBox.Show("Inserisci dati per aggiungere creatura");
        }

        private void btnEvoca_Click(object sender, EventArgs e)
        {
            lstCreature.Items.Clear();
            Evoca();
            foreach(Creatura creat in creature)
            {
                str = creat.ToString();
                lstCreature.Items.Add(str);
            }
        }

        public void Evoca()
        {
            Creatura cretura = new Creatura();
            if (txtNome.Text == null)
            {
                MessageBox.Show("Inserisci nome!");
                return;
            }
            cretura.Nome = txtNome.Text;

            cretura.razza = (Razza)cmbRazza.SelectedItem;
            cretura.count = count;
            count++;
            if (cmbMagia.SelectedIndex == 0)
            {
                MessageBox.Show("Inserisci il livello Magia");
                return;
            }
            cretura.LivelloMagia = (int)cmbMagia.SelectedItem;
            creature.Add(cretura);
        }

        private void btnScaccia_Click(object sender, EventArgs e)
        {
            lstCreature.Items.Clear();
            Scaccia();
            foreach (Creatura creat in creature)
            {
                str = creat.ToString();
                lstCreature.Items.Add(str);
            }
        }

        public void Scaccia()
        {
            int i = 0;
            Creatura cretura = new Creatura();
            for (int indice = 0; indice < creature.Count; indice++)
            {
                Creatura creat = creature[indice];
                if (txtNome.Text == creat.Nome)
                {
                    trovato = true;
                    cretura.Nome = txtNome.Text;
                    creature.RemoveAt(i);
                }
                i++;
            }
            if (!trovato)
            {
                MessageBox.Show("Inserisci nome!");
                return;
            }

        }

        private void btnMediaMagia_Click(object sender, EventArgs e)
        {
            media = 0; somma = 0;
            Creatura creat = new Creatura();
            for(int i = 0; i < creature.Count; i++)
            {
                creat = creature[i];
                somma += (int)creat.LivelloMagia;
            }
            media = somma/ creature.Count;
            MessageBox.Show($"La media dei livelli di Magia vale: {media}");
        }

        private void btnCreatureDeboli_Click(object sender, EventArgs e)
        {
            somma = 0;
            foreach (Creatura cret in creature)
            {
                if (cret.LivelloMagia < 5) somma++;
            }
            MessageBox.Show($"I livelli di Magia bassi sono: {somma}");
        }

        private void btnFiltraRazza_Click(object sender, EventArgs e)
        {
            lstCreature.Items.Clear();
            foreach(Creatura cret in creature)
            {
                if (cret.razza == (Razza)cmbRazza.SelectedItem) lstCreature.Items.Add(cret.ToString());
            }
        }

        private void btnCreaturaPotente_Click(object sender, EventArgs e)
        {
            Creatura max = new Creatura();
            max.LivelloMagia = 0;
            foreach(Creatura cret in creature)
            {
                if(cret.LivelloMagia>max.LivelloMagia) max = cret;
            }
            lstCreature.Items.Clear();
            lstCreature.Items.Add(max.ToString());
        }
    }
}
