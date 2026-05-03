using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StazioneMeteoTaff
{
    public partial class FormInizio : Form
    {
        List<CStazioneMeteo> stazionimeterologiche;

        public FormInizio()
        {
            InitializeComponent();
            stazionimeterologiche = new();
         
            lstListaStazioni.Items.Clear();
            lstListaStazioni.Font = new Font("Consolas", 12);
        }

        private void btnNEW_Click(object sender, EventArgs e)
        {
            frmAggiungi form = new frmAggiungi();


            if (form.ShowDialog() == DialogResult.OK)
            {
                CStazioneMeteo stazione = form.stazione;
                stazionimeterologiche.Add(stazione);

                lstListaStazioni.Items.Add(stazione.GetDatiSensori());
            }
        }

        private void btn_Report_Click(object sender, EventArgs e)
        {
            int index = lstListaStazioni.SelectedIndex;

            if (index == -1)
            {
                MessageBox.Show("Nessuna stazione selezionata");
                return;
            }

            CStazioneMeteo s = stazionimeterologiche[index];

            MessageBox.Show(s.GetReport(), "Report Stazione Meteo");
        }

        private void btnHaPiovuto_Click(object sender, EventArgs e)
        {
            int index = lstListaStazioni.SelectedIndex;

            if (index == -1)
            {
                MessageBox.Show("Nessuna stazione selezionata");
                return;
            }

            CStazioneMeteo s = stazionimeterologiche[index];

            MessageBox.Show(s.HaPiovuto() ? "Ha piovuto oggi." : "Non ha piovuto.");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            int index = lstListaStazioni.SelectedIndex;

            if (index == -1)
            {
                MessageBox.Show("Nessuna stazione selezionata");
                return;
            }

            CStazioneMeteo s = stazionimeterologiche[index];
            s.ResetGiornaliero();

            MessageBox.Show("Valori resettati per il nuovo giorno.");

            lstListaStazioni.Items.Clear();

            foreach (var st in stazionimeterologiche)
                lstListaStazioni.Items.Add(st.GetDatiSensori());
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            int index = lstListaStazioni.SelectedIndex;

            if (index == -1)
            {
                MessageBox.Show("Nessuna stazione selezionata");
                return;
            }

            CStazioneMeteo s = stazionimeterologiche[index];
            frmAggiungi form = new frmAggiungi(s);

            if (form.ShowDialog() == DialogResult.OK)
            {
                //sostituisco i vecchi valori con i nuovi
                stazionimeterologiche[index] = form.stazione;

                lstListaStazioni.Items.Clear();

                foreach (var st in stazionimeterologiche)
                    lstListaStazioni.Items.Add(st.GetDatiSensori());

            }
        }

        private void SalvaCSV(string path)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                foreach (CStazioneMeteo s in stazionimeterologiche)
                {
                    if (s != null)
                    {
                        sw.WriteLine(
                            $"{s.NumeroStazione};{s.Barometro};" +
                            $"{s.Temperature[0]};{s.Temperature[1]};{s.Temperature[2]};{s.Temperature[3]};" +
                            $"{s.Pluviometro};{s.Igrometro};{s.Anemometro}"
                        );
                    }
                }
            }
        }


        private void CaricaCSV(string path)
        {
            if (!File.Exists(path))
                return;

            foreach (string riga in File.ReadAllLines(path))
            {
                string[] campi = riga.Split(';');

                int numero = int.Parse(campi[0]);
                double bar = double.Parse(campi[1]);

                double[] temp = {
                        double.Parse(campi[2]),
                        double.Parse(campi[3]),
                        double.Parse(campi[4]),
                        double.Parse(campi[5])
                 };

                double plu = double.Parse(campi[6]);
                double igr = double.Parse(campi[7]);
                double ane = double.Parse(campi[8]);

                CStazioneMeteo s = new CStazioneMeteo(numero, bar, temp, plu, igr, ane);
                stazionimeterologiche.Add(s);
            }

            lstListaStazioni.Items.Clear();

            foreach (var st in stazionimeterologiche)
                lstListaStazioni.Items.Add(st.GetDatiSensori());
        }

        private void FormInizio_Load(object sender, EventArgs e)
        {
            CaricaCSV("stazioni.csv");
        }

        private void FormInizio_FormClosing(object sender, FormClosingEventArgs e)
        {
            SalvaCSV("stazioni.csv");
        }
    }
}
