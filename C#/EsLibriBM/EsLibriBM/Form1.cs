using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static EsLibriBM.Form1;

namespace EsLibriBM
{
    public partial class Form1 : Form
    {
        public List<Libro> lstLibri;
        public Libro libro;
        public string riga;
        public string[] car;

        public Form1()
        {
            InitializeComponent();
            lstLibri = new List<Libro>();
            download();
            cmbGenere.DataSource = Enum.GetValues(typeof(Genere));
        }

        public void download()
        {
            if (File.Exists("libri.csv"))
            {
                using(StreamReader sr = new StreamReader("libri.csv"))
                {
                    sr.ReadLine();
                    while (!sr.EndOfStream)
                    {
                        car = new string[10];
                        car = sr.ReadLine().Split(',');
                        libro = new Libro();
                        libro.titolo = car[0];
                        libro.autore = car[1];
                        libro.genere = (Genere)Enum.Parse(typeof(Genere), car[2]);
                        libro.anno = int.Parse(car[3]);
                        libro.pagine = int.Parse(car[4]);
                        libro.disponibile = car[5] == "SI" ? true : false;
                        libro.ISBN = car[6];
                        lstLibri.Add(libro);
                        CaricaElenco();
                    }
                }
            }
        }

        public void upload()
        {
            using(StreamWriter sw = new StreamWriter("libri.csv", false))
            {
                sw.WriteLine("Titolo,Autore,Genere,Anno,Pagine,Disponibile,Codice ISBN");
                foreach (Libro libro in lstLibri)
                {
                    sw.WriteLine(libro.print());
                }
            }
        }

        public void CaricaElenco()
        {
            lstElenco.Items.Clear();
            foreach(Libro libro in lstLibri)
            {
                lstElenco.Items.Add(libro.stampa());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Controllo();
            upload();
        }

        public void Controllo()
        {
            libro = new Libro();
            if(txtAnno.Text != "")
            {
                if (int.Parse(txtAnno.Text) < 2027) libro.anno = int.Parse(txtAnno.Text);
                else
                {
                    MessageBox.Show("Inserisci anno di pubblicazione valido");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Riempi il campo dell'anno di pubblicazione");
                return;
            }

            if(txtTitLib.Text != "") libro.titolo = txtTitLib.Text;
            else
            {
                MessageBox.Show("Inserisci il titolo del libro");
                return;
            }

            if (txtAutore.Text != "") libro.autore = txtAutore.Text;
            else
            {
                MessageBox.Show("Inserisci l'autore del libro");
                return;
            }

            if(cmbGenere.SelectedIndex == -1)
            {
                MessageBox.Show("Inserisci il genere del libro");
                return;
            }else libro.genere = (Genere)cmbGenere.SelectedItem;

            libro.disponibile = true;
            if(txtISBN.Text == "")
            {
                MessageBox.Show("Inserisci il codice ISBN del libro");
                return;
            }else libro.ISBN = txtISBN.Text;

            lstLibri.Add(libro);
            lstElenco.Items.Add(libro.stampa());
        }

        private void btnRicercaGenere_Click(object sender, EventArgs e)
        {
            string genere = Interaction.InputBox(
                "Inserisci il genere da cercare (scrivi \"all\" per reset)",
                "RICERCA PER GENERE (Giallo, Fantasy, Fantascienza, Romanzo, Saggio)",
                ""
                );

            lstElenco.Items.Clear();
            if (genere == "all") CaricaElenco();
            if (genere == "")
            {
                MessageBox.Show("Inserire un parametro di ricerca!!");
                CaricaElenco();
                return;
            }
            foreach(Libro libro in lstLibri)
            {
                if (libro.genere.ToString() == genere) lstElenco.Items.Add(libro.stampa());
            }
        }

        private void btnRicercaAutore_Click(object sender, EventArgs e)
        {
            string autore = Interaction.InputBox(
                "Inserisci l'autore da cercare (scrivi \"all\" per reset)",
                "RICERCA PER AUTORE",
                ""
                );

            lstElenco.Items.Clear();
            if (autore == "all") CaricaElenco();
            if (autore == "")
            {
                MessageBox.Show("Inserire un parametro di ricerca!!");
                CaricaElenco();
                return;
            }
            foreach (Libro libro in lstLibri)
            {
                if (libro.autore == autore) lstElenco.Items.Add(libro.stampa());
            }
        }

        private void txtAnno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '-')
            {
                e.KeyChar = (char)0;
            }
        }

        private void txtPagine_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '-')
            {
                e.KeyChar = (char)0;
            }
        }

        private void rdbOrdCresc_CheckedChanged(object sender, EventArgs e)
        {
            for(int i=1; i<lstLibri.Count; i++)
            {
                Libro key = lstLibri[i];
                int j = i - 1;

                while(j >=0 && lstLibri[j].anno> key.anno)
                {
                    lstLibri[j+1] = lstLibri[j];
                    j--;
                }

                lstLibri[j + 1] = key;
            }
            CaricaElenco();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(lstLibri);
            f2.ShowDialog();
        }

        private void rdbOrdTit_CheckedChanged(object sender, EventArgs e)
        {
            for(int i=1; i<lstLibri.Count; i++)
            {
                Libro key = lstLibri[i];
                int j = i - 1;
                while (j >= 0 && string.Compare(lstLibri[j].titolo, key.titolo) > 0)
                {
                    lstLibri[j + 1] = lstLibri[j];
                    j--;
                }
                lstLibri[j + 1] = key;
            }
        }

        private void rdbOrdDec_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 1; i < lstLibri.Count; i++)
            {
                Libro key = lstLibri[i];
                int j = i - 1;

                while (j >=0 && lstLibri[j].anno < key.anno)
                {
                    lstLibri[j+1] = lstLibri[j];
                    j--;
                }

                lstLibri[j + 1] = key;
            }
            CaricaElenco();
        }
    }
}
