using System;
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
        public int ind;
        public List<Persona> lista;
        public double IMC, varianza, somma, media, diff;
        public string str, comando;
        public string[] arr = {"Magro(Sottopeso)","Normale(NormoPeso)", "Svovrappeso", "Grasso (Obesità)"};
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
        }
        public Form1()
        {
            InitializeComponent();
            lista = new List<Persona>();
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
        }

        private void btnEsegui_Click(object sender, EventArgs e)
        {
            comando = Comando();
            txtRisposte.Text = comando;
        }

        public string Comando()
        {
            if (rdbIMCMedia.Checked)
            {
                media = MediaIMC();
                IndiceMC(media);
                str = $"MEDIA IMC = {Math.Round(media,2)}, STATO = " + arr[ind];
                return str;
            }
            else if (rdbIMC.Checked && lstPersone.SelectedIndex >=0)
            {
                Persona persona = new Persona();
                persona = lista[lstPersone.SelectedIndex];
                IMC = persona.IMC;
                IndiceMC(IMC);
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
                return "NON HO CAPITO";
            }else if (rdbIMC.Checked){
                return "CLICCARE ELEMENTO NELLA LISTBOX";
            }
                return "CLICCARE UN RADIO BUTTON";
        }

        public int IndiceMC(double IMC)
        {
            if (IMC < 18.5) ind = 0;
            else if(IMC < 25)ind = 1;
            else if(IMC < 30) ind = 2;
            else ind = 3;
            return ind ;
        }

        public double MediaIMC()
        {
            somma = 0;
            media = 0;
            for(int i= 0; i<lista.Count; i++)
            {
                somma+=CalcoloIMC(lista[i]);
            }
            media = somma/=lista.Count;
            return media;
        }

        public double CalcoloIMC(Persona persona)
        {
            IMC = 0;
            double HeigthM = persona.height / 100.0;
            IMC += persona.weigth / (HeigthM * HeigthM);
            return IMC;
        }

        public string ModaIMC()
        {
            somma = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                IMC = lista[i].IMC;
                somma+=IndiceMC(IMC);
            }
            somma/=lista.Count;
            ind = (int)Math.Round(somma);
            return arr[ind];
        }

        public string Mediana()
        {
            int[] valori = new int[lista.Count];
            int lung = lista.Count;
            for(int i = 0; i < lung; i++)
            {
                valori[i] = (IndiceMC(lista[i].IMC));
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
            for(int i=0; i<lista.Count; i++)
            {
                diff += (lista[i].IMC - media);
                somma += Math.Pow(diff, 2);
            }
            varianza= somma/Math.Abs(media);
            return varianza;
        }
    }
}
