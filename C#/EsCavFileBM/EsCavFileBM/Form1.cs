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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace EsCavFileBM
{
    public partial class Form1 : Form
    {
        public enum razza
        {
            Arabo,
            Maremmano,
            Andaluso,
            QuarteHorse,
            Frisone
        }

        public struct Cavallo
        {
            public string name;
            public razza race;
            public int age, id;
            public string sesso;
            public Cavallo(string name, razza race, int age, string sesso, int id)
            {
                this.name = name;
                this.race = race;
                this.age = age;
                this.sesso = sesso;
                this.id = id;
            }

            public string descrizione()
            {
                string str = "";
                str += $" HORSE N° {this.id} : ";
                str += $"AGE = {this.age}, ";
                str += $"NAME = {this.name}, ";
                str += $"RACE = {this.race}, ";
                str += $"SESSO = {this.sesso}";
                return str;
            }

        }

        List<Cavallo> lstCav;
        public int i;//utilizzo come contatore nella lettura del file
        public char separator;
        public string[] cavalloinput;
        public Cavallo cavallo;
        public string str;
        public int age, limcav;


        public Form1()
        {
            lstCav = new List<Cavallo>();
            InitializeComponent();
            lstCav = Carica(lstCav);
            separator = ';';
            limcav = lstCav.Count;
        }

        public List<Cavallo> Carica(List<Cavallo> lstCav)
        {
            i = 0;

            using (StreamReader sr = new StreamReader(@"C:\Users\ASUS\Desktop\INFORMATICA_TERZA\C#\EsCavFileBM\EsCavFileBM\bin\Debug\file.txt"))
            {
                if (sr.ReadLine() != null)
                {
                    while (!sr.EndOfStream)
                    {
                        lstCav.Add(ConvertiIN(sr.ReadLine()));
                    }
                }
            }
        return lstCav;
        }


        public Cavallo ConvertiIN(string riga)
        {
            cavallo = new Cavallo();
            cavalloinput = riga.Split(separator);
            cavallo.name = cavalloinput[0];
            Enum.TryParse<razza>(cavalloinput[1], out razza race);
            cavallo.race = race;
            cavallo.age=int.Parse(cavalloinput[2]);
            cavallo.sesso = cavalloinput[3] == "MALE" ? "MALE" : "FEMALE"; // true se maschio, false se femmina
            return cavallo;
        }

        


        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != (char)Keys.Clear)
            {
                e.KeyChar = (char)0;
                e.Handled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (limcav <= 10)
            {
                cavallo = new Cavallo();
                bool Valid = Aggiungi(ref cavallo);
                if (Valid)
                {
                    cavallo.id = lstCav.Count;
                    lstCav.Add(cavallo);
                    limcav++;
                    lstCavalli.Items.Clear();
                    foreach(Cavallo cav in lstCav)
                    {
                        lstCavalli.Items.Add(cav);
                    }
                }
            }
            else
            {
                MessageBox.Show("Limite cavalli raggiunto");
            }
            
        }
        public bool Aggiungi(ref Cavallo cavallo)
        {
            if (txtName != null)
            {
                cavallo.name = txtName.Text;
            }
            else
            {
                MessageBox.Show("Inserisci il nome!");
                return false;
            }
            if (cmbRace.SelectedIndex >= 0)
            {
                Enum.TryParse(cmbRace.SelectedText, ignoreCase: true, out razza race);
                cavallo.race = race;
            }
            else
            {
                MessageBox.Show("Inserisci il nome!");
                return false;
            }

            age = int.Parse(txtAge.Text);

            if (txtAge != null)
            {
                if(age > 1964 && age <= 2026)
                {
                    int.TryParse(txtAge.Text, out int age);
                    cavallo.age = age;
                }
                else
                {
                    MessageBox.Show("Insersci anno di nascita compresa tra 1964 e 2026");
                    return false;
                }
                
            }
            else
            {
                MessageBox.Show("Inserisci l'età");
                return false;
            }
            if (rdbM.Checked) cavallo.sesso = "MALE";
            else if (rdbF.Checked) cavallo.sesso = "FEMALE";
            else
            {
                MessageBox.Show("Inserisci il sesso");
                return false;
            } 
            return true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lstCavalli.Items.Clear();
            if (txtName.Text != null)
            {
                foreach (Cavallo i in lstCav)
                {
                    if(i.name == txtName.Text)
                    {
                        lstCavalli.Items.Add(i.descrizione());
                    }
                }
            }
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(lstCavalli.SelectedIndex >= 0)
            {
                cavallo = lstCav[lstCavalli.SelectedIndex];
                Edit(ref cavallo);
            }
        }

        public void Edit(ref Cavallo cavallo)
        {
            if (txtName != null)
            {
                cavallo.name = txtName.Text;
            }

            if (cmbRace.SelectedIndex >= 0)
            {
                Enum.TryParse(cmbRace.SelectedText, ignoreCase: true, out razza race);
                cavallo.race = race;
            }
            age = int.Parse(txtAge.Text);

            if (txtAge != null)
            {
                if (age < 1964 && age <= 2026)
                {
                    int.TryParse(txtAge.Text, out int age);
                    cavallo.age = age;
                }
                else
                {
                    MessageBox.Show("Insersci età compresa tra 0 e 62");
                }

            }
            if (rdbM.Checked) cavallo.sesso = "MALE";
            else if (rdbF.Checked) cavallo.sesso = "FEMALE";
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(lstCavalli.SelectedIndex>=0)
            {
                lstCav.RemoveAt(lstCavalli.SelectedIndex);
                lstCavalli.Items.RemoveAt(lstCavalli.SelectedIndex);
                limcav--;
            }
            else
            {
                MessageBox.Show("Click the Horse that you want to remove");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CaricaOUT(lstCav);
        }

        public void CaricaOUT(List<Cavallo> lstCav)
        {
            i = 0;

            using (StreamWriter sw = new StreamWriter(@"C:\Users\ASUS\Desktop\INFORMATICA_TERZA\C#\EsCavFileBM\EsCavFileBM\bin\Debug\file.txt"))
            {
                foreach(Cavallo cav in lstCav)
                {
                    sw.WriteLine(ConvertiOUT(cav));
                }

            }
        }

        public string ConvertiOUT(Cavallo cavallo)
        {
            str += cavallo.name;
            str += ";";
            str += cavallo.age;
            str += ";";
            str += cavallo.race;
            str += ";";
            str += cavallo.sesso;
            str += "\n";
            return str;
        }

    }
}
