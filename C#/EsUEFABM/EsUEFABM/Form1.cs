using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsUEFABM
{
    public partial class Form1 : Form
    {
        public struct Partita
        {
            public int id;
            public string squadraC, squadraO;
            public int goalC, goalO;

            public Partita(int id, string squadraC, int goalC, string squadraO, int goalO)
            {
                this.id = id; 
                this.squadraC = squadraC;
                this.goalC = goalC;
                this.squadraO = squadraO;
                this.goalO = goalO;

            }

            public string stampa()
            {
                return $"PARTITA N° {this.id} CASA : {this.squadraC} = {this.goalC}   -   OSPITI : {this.squadraO} = {this.goalO}";
            }

            public string output()
            {
                return $"{this.id};{this.squadraC};{this.squadraO};{this.goalC};{this.goalO}";
            }

        }

        public int count, maxgoals, totgoal, mgoalp, nsquadre, mgoals, maxgolas;
        public List<Partita> lstPartite;
        public Partita partita;
        public string namefile = "Partite.txt", riga;
        public string[] dati;
        public string[] squadre;
        public int[] psquadre;

        public Form1()
        {
            InitializeComponent();
            squadre = new string[20];
            psquadre = new int[20];
            lstPartite = new List<Partita>(); // anche lstPartite!
            count = 0;
            nsquadre = 0;
            Download();
        }

        public void Download()
        {
            if(File.Exists(namefile))
            {
                using (StreamReader sr = new StreamReader(namefile))
                {
                    while (!sr.EndOfStream)
                    {
                        riga = sr.ReadLine();
                        if(riga != null) ConvertiIN();
                    }
                }
            }
            else
            {
                MessageBox.Show("File di caricamento non trovato");
            }
                
        }

        private void txtCasa2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' &&  e.KeyChar != (char)Keys.Clear && e.KeyChar != '-')
            {
                e.Handled = true;
                e.KeyChar = (char)0;
            }
        }

        private void txtOspite2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != (char)Keys.Clear && e.KeyChar != '-')
            {
                e.Handled = true;
                e.KeyChar = (char)0;
            }
        }


        private void cmbCerca_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCerca.DataSource = squadre;

            if (cmbCerca.SelectedIndex != -1)
            {
                lstPart.Items.Clear();
                foreach (Partita p in lstPartite) if (cmbCerca.Text == p.squadraC || cmbCerca.Text == p.squadraO) lstPart.Items.Add(p.stampa());
            }
        }

        private void cmbCerca_MouseClick(object sender, MouseEventArgs e)
        {
            cmbCerca.DataSource = squadre;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lstPart.Items.Clear();
            foreach (Partita p in lstPartite)  lstPart.Items.Add(p.stampa());
        }

        public void ConvertiIN()
        {
            partita = new Partita();
            dati = new string[5];
            dati = riga.Split(';');
            partita.id = int.Parse(dati[0]);
            partita.squadraC = dati[1];
            partita.squadraO = dati[2];
            partita.goalC = int.Parse(dati[3]);
            partita.goalO = int.Parse(dati[4]);

            if (!squadre.Contains(partita.squadraC))
            {
                squadre[nsquadre] = partita.squadraC;
                psquadre[nsquadre] = partita.goalC;
                nsquadre++;
            }
            else
            {
                psquadre[Array.IndexOf(squadre, partita.squadraC)] += partita.goalC;
            }

            if (!squadre.Contains(partita.squadraO))
            {
                squadre[nsquadre] = partita.squadraO;
                psquadre[nsquadre] = partita.goalO;
                nsquadre++;
            }
            else
            {
                psquadre[Array.IndexOf(squadre, partita.squadraO)] += partita.goalO;
            }

            
            lstPart.Items.Add(partita.stampa());
            lstPartite.Add(partita);
            count = partita.id;
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            Upload();
        }

        public void Upload()
        {
            using (StreamWriter sr = new StreamWriter(namefile))
            {
                foreach (Partita partita in lstPartite)
                {
                    sr.WriteLine(partita.output());
                }
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            partita = new Partita();
            if (Verifica())
            {
                partita.id = count;
                partita.squadraC = txtCasa1.Text;
                partita.squadraO = txtOspite1.Text;

                partita.goalC = int.Parse(txtCasa2.Text);
                partita.goalO = int.Parse(txtOspite2.Text);
                
                if (!squadre.Contains(partita.squadraC))
                {
                    squadre[nsquadre] = partita.squadraC;
                    psquadre[nsquadre] = partita.goalC;
                    nsquadre++;
                }
                else
                {
                    psquadre[Array.IndexOf(squadre, partita.squadraC)] += partita.goalC;
                }

                if (!squadre.Contains(partita.squadraO))
                {
                    squadre[nsquadre] = partita.squadraO;
                    psquadre[nsquadre] = partita.goalO;
                    nsquadre++;
                }
                else
                {
                    psquadre[Array.IndexOf(squadre, partita.squadraO)] += partita.goalO;
                }

                lstPart.Items.Add(partita.stampa());
                lstPartite.Add(partita);
                count++;
            }
        }
        private void btnStat_Click(object sender, EventArgs e)
        {
            totgoal = 0;
            mgoals = 0;
            maxgoals = 0;
            mgoalp = 0;
            for (int i=0; i<nsquadre; i++)
            {
                if (psquadre[i] > maxgoals)
                {
                    maxgoals = psquadre[i];
                    mgoals = i;
                }
                totgoal += psquadre[i];
            }
            foreach(Partita p in lstPartite) if ((p.goalO + p.goalC) > mgoalp) mgoalp = p.id;

            MessageBox.Show($"Squadra con il maggior numero di goal : {squadre[mgoals]} = {psquadre[mgoals]}{Environment.NewLine}Numero totale dei goal di campionato : {totgoal}{Environment.NewLine}Partita con il maggior numero di goal : PARTITA N° {mgoalp}");
        }

        public bool Verifica() {
        
            if(txtCasa1.Text == "")
            {
                MessageBox.Show("Inserisci il nome della squadra di casa");
                txtCasa1.Focus();
                return false;
            }
            if(txtOspite1.Text == "")
            {
                MessageBox.Show("Inserisci il nome della squadra ospite");
                txtOspite2.Focus();
                return false;
            }
            if(txtCasa1.Text == txtOspite1.Text)
            {
                MessageBox.Show("Le due squadre non possono avere lo stesso nome!!");
                txtCasa1.Focus();
                return false;
            }
            if(txtCasa2.Text == "")
            {
                MessageBox.Show("Inserire un valore di goal valido per la squadra di casa");
                txtCasa2.Focus();
                return false;
            }
            else if(int.Parse(txtCasa2.Text) < 0)
            {
                MessageBox.Show("Inserire un valore di goal valido per la squadra di casa");
                txtCasa2.Focus();
                return false;
            }
            if (txtOspite2.Text == "")
            {
                MessageBox.Show("Inserire un valore di goal valido per la squadra ospite");
                txtOspite2.Focus();
                return false;
            }else if(int.Parse(txtOspite2.Text) < 0)
            {
                MessageBox.Show("Inserire un valore di goal valido per la squadra ospite");
                txtOspite2.Focus();
                return false;
            }
            return true;
        }

    }
}
