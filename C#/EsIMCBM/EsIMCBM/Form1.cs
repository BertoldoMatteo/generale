using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsIMCBM
{
    public partial class Form1 : Form
    {
        public int ind, lung, index;
        public List<Persona> lista;
        public double IMC, varianza, somma, media, diff, HeigthM;
        public string str, comando, dir, content;
        public string[] arr = { "Magro(Sottopeso)", "Normale(NormoPeso)", "Sovrappeso", "Grasso (Obesità)" };
        public int[] valori;
        Persona persona;

        public struct Persona
        {
            public string name;
            public int weigth, height;
            public double IMC;

            public Persona(string name, int weigth, int height, double IMC)
            {
                this.name = name;
                this.weigth = weigth;
                this.height = height;
                this.IMC = IMC;
            }

            public string descrizione()
            {
                return $"{name} : peso = {weigth} , altezza = {height}";
            }

            public string descrizioneConIMC(string desc)
            {
                return $"{name} : peso = {weigth} , altezza = {height} , IMC = {desc}";
            }
        }

        public Form1()
        {
            InitializeComponent();
            lista = new List<Persona>();
            dir = @"C:\Users\ASUS\Desktop\INFORMATICA_TERZA\C#\EsIMCBM\EsIMCBM\output.txt";

            if (File.Exists(dir))
                content = File.ReadAllText(dir);
            else
                content = "";
        }

        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != (char)Keys.Clear)
            {
                e.KeyChar = (char)0;
                e.Handled = true;
            }
        }

        private void txtAltezza_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != (char)Keys.Clear)
            {
                e.KeyChar = (char)0;
                e.Handled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Persona person = new Persona();
            person.name = txtNomeCognome.Text;
            person.weigth = int.Parse(txtPeso.Text);
            person.height = int.Parse(txtAltezza.Text);
            person.IMC = CalcoloIMC(person);
            lstPersone.Items.Add(person.descrizione());
            lista.Add(person);
            content += person.descrizione() + "\n";
        }

        private void btnEsegui_Click(object sender, EventArgs e)
        {
            comando = Comando();
            txtRisposte.Text = comando;
            if (rdbIMC.Checked && lstPersone.SelectedIndex >= 0)
            {
                index = lstPersone.SelectedIndex;
                Persona p = lista[index];
                str = p.descrizioneConIMC(arr[IndiceIMC(Math.Round(p.IMC, 2))]);
                lstPersone.Items[index] = str;
                content = content.Replace(p.descrizione() + "\n", str + "\n");
            }
        }

        public string Comando()
        {
            if (rdbIMCMedia.Checked)
            {
                media = MediaIMC();
                IndiceIMC(media);
                str = $"MEDIA IMC = {Math.Round(media, 2)}, STATO = " + arr[ind];
                return str;
            }
            else if (rdbIMC.Checked && lstPersone.SelectedIndex >= 0)
            {
                persona = new Persona();
                persona = lista[lstPersone.SelectedIndex];
                IMC = persona.IMC;
                IndiceIMC(IMC);
                str = $"IMC = {Math.Round(IMC, 2)}, STATO = " + arr[ind];
                return str;
            }
            else if (rdbIMCModa.Checked)
            {
                str = ModaIMC();
                str = $"MODA IMC , STATO = " + str;
                return str;
            }
            else if (rdbIMCMediana.Checked)
            {
                str = Mediana();
                str = $"MEDIANA IMC , STATO = " + str;
                return str;
            }
            else if (rdbIMCVarianza.Checked)
            {
                varianza = Varianza();
                str = $"VARIANZA IMC = {varianza}";
                return str;
            }
            else if (rdbMediaSotto.Checked)
            {
                str = MediaSottogruppo();
                return str;
            }
            else if (rdbIMC.Checked)
            {
                return "CLICCARE ELEMENTO NELLA LISTBOX";
            }
            return "CLICCARE UN RADIO BUTTON";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            File.WriteAllText(dir, content);
            MessageBox.Show("Salvato con successo!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public int IndiceIMC(double IMC)
        {
            if (IMC < 18.5) ind = 0;
            else if (IMC < 25) ind = 1;
            else if (IMC < 30) ind = 2;
            else ind = 3;
            return ind;
        }

        public double MediaIMC()
        {
            somma = 0;
            media = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                somma += CalcoloIMC(lista[i]);
            }
            media = somma /= lista.Count;
            return media;
        }

        public double CalcoloIMC(Persona persona)
        {
            IMC = 0;
            HeigthM = persona.height / 100.0;
            IMC += persona.weigth / (HeigthM * HeigthM);
            return IMC;
        }

        public string ModaIMC()
        {
            ind = 0;
            int[] mod = new int[4];
            for (int i = 0; i < lista.Count; i++)
            {
                IMC = lista[i].IMC;
                mod[IndiceIMC(IMC)]++;
            }
            
            for(int i=0; i<mod.Length; i++)
            {
                if(mod[i] > mod[ind])
                {
                    ind = i;
                }
            }
            return arr[ind];
        }

        public string Mediana()
        {
            valori = new int[lista.Count];
            lung = lista.Count;
            for (int i = 0; i < lung; i++)
            {
                valori[i] = (IndiceIMC(lista[i].IMC));
            }
            Array.Sort(valori);
            ind = valori[valori.Length / 2];
            return arr[ind];
        }

        public double Varianza()
        {
            diff = 0;
            media = MediaIMC();
            somma = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                diff += (lista[i].IMC - media);
                somma += Math.Pow(diff, 2);
            }
            varianza = somma / Math.Abs(media);
            return varianza;
        }

        public string MediaSottogruppo()
        {
            if (lstPersone.SelectedIndex >= 0)
            {
                str = $"MediaSottogruppo : {arr[IndiceIMC(lista[lstPersone.SelectedIndex].IMC)]}";
                ind = IndiceIMC(lista[lstPersone.SelectedIndex].IMC);
                for (int i = 0; i < lista.Count; i++)
                {
                    if (IndiceIMC(lista[i].IMC) == ind)
                    {
                        somma += lista[i].IMC;
                        lung++;
                    }
                    media = somma / lung;
                }
                str += $" = {media}";
                return str;
            }
            else
            {
                return "Seleziona elemento lista";
            }
        }
    }
}