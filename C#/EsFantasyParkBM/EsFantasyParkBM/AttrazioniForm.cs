using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsFantasyParkBM
{
    public partial class AttrazioniForm : Form
    {
        public int[] persone;
        public int add;
        public bool notifiche;
        public AttrazioniForm()
        {
            InitializeComponent();
            persone = new int[3];
            LeggiCSV();
            notifiche = true;
        }

        private void txtAddSpe_KeyPress(object sender, KeyPressEventArgs e) => text(e);
        private void txtExitSpe_KeyPress(object sender, KeyPressEventArgs e) => text(e);
        private void txtAddCasa_KeyPress(object sender, KeyPressEventArgs e) => text(e);
        private void txtExitCasa_KeyPress(object sender, KeyPressEventArgs e) => text(e);
        private void txtAddTun_KeyPress(object sender, KeyPressEventArgs e) => text(e);
        private void txtExitTun_KeyPress(object sender, KeyPressEventArgs e) => text(e);
        

        private void btnAddSpe_Click(object sender, EventArgs e)
        {
            
            if (vuoto(txtAddSpe.Text))
            {
                if(notifiche) MessageBox.Show("Inserire il numero di persone che entrano nella stanza con gli specchi");
            }
            else
            {
                Aggiungi(0, int.Parse(txtAddSpe.Text), 10);
                txtFilaSpe.Text = persone[0].ToString();
            }
        }

        private void btnAddCasa_Click(object sender, EventArgs e)
        {
            if (vuoto(txtAddCasa.Text))
            {
                if (notifiche) MessageBox.Show("Inserire il numero di persone che entrano nella Casa delle Illusioni");
            }
            else
            {
                Aggiungi(1, int.Parse(txtAddCasa.Text), 12);
                txtFilaCasa.Text = persone[1].ToString();
            }
        }

        private void btnAddTun_Click(object sender, EventArgs e)
        {
            if (vuoto(txtAddTun.Text))
            {
                if (notifiche) MessageBox.Show("Inserire il numero di persone che entrano nel Tunnel delle Stelle");
            }
            else
            {
                Aggiungi(2, int.Parse(txtAddTun.Text), 15);
                txtFilaTun.Text = persone[2].ToString();
            }
        }

        private void btnExitSpe_Click(object sender, EventArgs e)
        {
            if (vuoto(txtExitSpe.Text))
            {
                if (notifiche) MessageBox.Show("Inserire il numero di persone che escono dalla stanza con gli specchi");
            }
            else
            {
                Exit(0, int.Parse(txtExitSpe.Text));
                txtFilaSpe.Text = persone[0].ToString();
            }
        }

        private void btnExitCasa_Click(object sender, EventArgs e)
        {
            if (vuoto(txtExitCasa.Text))
            {
                if (notifiche) MessageBox.Show("Inserire il numero di persone che escono dalla Casa delle Illusioni");
            }
            else
            {
                Exit(1, int.Parse(txtExitCasa.Text));
                txtFilaCasa.Text = persone[1].ToString();
            }
        }

        private void btnExitTun_Click(object sender, EventArgs e)
        {
            if (vuoto(txtExitTun.Text))
            {
                if (notifiche) MessageBox.Show("Inserire il numero di persone che escono dal tunnel delle Stelle");
            }
            else
            {
                Exit(2, int.Parse(txtExitTun.Text));
                txtFilaTun.Text = persone[2].ToString();
            }
        }

        public void Exit(int n, int del)
        {
            if (persone[n] < del)
            {
                if (notifiche) MessageBox.Show($"Inserite più persone di quelle presenti, sono uscite {persone[n]}");
                persone[n] = 0;
            }
            else
            {
                if (notifiche) MessageBox.Show($"Tutte le {del} persone sono uscite");
                persone[n] -= del;
            }
            CaricaCSV();
        }

        public void Aggiungi(int n, int add, int lim)
        {
            if (add + persone[n] > lim)
            {
                if (notifiche) MessageBox.Show($"Limite raggiunto, rimangono fuori {add + persone[n] - lim} persone");
                persone[n] = lim;
            }
            else
            {
                persone[n] += add;
                if (notifiche) MessageBox.Show($"Tutte le {add} persone sono entrate");
            }
            CaricaCSV();
        }

        public void text(KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != (char)Keys.Clear)
            {
                e.KeyChar = (char)0;
                e.Handled = true;
            }
        }

        public bool vuoto(string str)
        {
            if (str == "") return true;
            return false;
        }

        public void LeggiCSV()
        {
            if (!File.Exists("attrazioni.csv"))
            {
                File.WriteAllText("attrazioni.csv", "0,0,0");
                if (notifiche) MessageBox.Show("File creato con successo");
            }
            using (StreamReader sr = new StreamReader("attrazioni.csv"))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    if(line != null)
                    {
                        string[] linea = line.Split(',');
                        for (int i = 0; i < 3; i++) persone[i] = int.Parse(linea[i]);
                        txtFilaSpe.Text = persone[0].ToString();
                        txtFilaCasa.Text = persone[1].ToString();
                        txtFilaTun.Text = persone[2].ToString();
                    }
                    

                }
            }
        }

        public void CaricaCSV()
        {
            using (StreamWriter sw = new StreamWriter("attrazioni.csv"))
            {
                sw.WriteLine($"{persone[0]},{persone[1]},{persone[2]}");
            }
        }
    }
}
