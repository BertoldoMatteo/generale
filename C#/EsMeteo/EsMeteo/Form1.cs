using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsMeteo
{
    
    public partial class Form1 : Form
    {
        private int count;
        private string[] riga;
        private string ID, err;
        private double press, piogg, umid, vento;
        private double[] temp;
        public int id;
        private StazioneMeteo StazMet;
        private List<StazioneMeteo> lstStazmet = new List<StazioneMeteo>();
        public Form1()
        {
            InitializeComponent();
            temp = new double[4];
            riga = new string[10];
            err = "";
            id = -1;
            count = 0;
        }

        private void LeggiFile()
        {
            if (!File.Exists("file.csv")) File.Create("file.csv");
            else
            {
                using (StreamReader sr = new StreamReader("file.csv"))
                {
                    sr.ReadLine();
                    while (!sr.EndOfStream)
                    {
                        Valori(sr.ReadLine().Split(','));
                        StazioneMeteo StazMet = new StazioneMeteo(ID, press, temp, piogg, umid, vento);
                        lstStazioni.Items.Add(StazMet.ID);
                        lstStazmet.Add(StazMet);
                        count = int.Parse(ID)+1;
                    }
                }
            }
        }
        private void Valori(string[] riga)
        {
            ID = riga[0];
            double.TryParse(riga[1], out press);
            double.TryParse(riga[2], out temp[0]);
            double.TryParse(riga[3], out temp[1]);
            double.TryParse(riga[4], out temp[2]);
            double.TryParse(riga[5], out temp[3]);
            double.TryParse(riga[6], out piogg);
            double.TryParse(riga[7], out umid);
            double.TryParse(riga[8], out vento);
        }
        private void btnCreaStaz_Click(object sender, EventArgs e)
        {
            ID = count.ToString();
            count++;
            press = 0;
            temp = new double [4];
            piogg = 0;
            umid = 0;
            vento = 0;
            StazioneMeteo stazMet = new StazioneMeteo(ID, press, temp, piogg, umid, vento);
            lstStazmet.Add(stazMet);
            Lista(stazMet);
            Info(stazMet);
        }
        private void LetturaGen()
        {
            err = "";
            Lettura(txtPressione, ref press, "PRESSIONE");
            Lettura(txtTemp0, ref temp[0], "TEMPERATURA (00:00)");
            Lettura(txtTemp1, ref temp[1], "TEMPERATURA (06:00)");
            Lettura(txtTemp2, ref temp[2], "TEMPERATURA (12:00)");
            Lettura(txtTemp3, ref temp[3], "TEMPERATURA (18:00)");
            Lettura(txtPioggia, ref piogg, "PIOGGIA");
            Lettura1(txtUmidità, ref umid, "UMIDITA'");
            Lettura(txtVento, ref vento, "VENTO");
        }

        private void Lista(StazioneMeteo StazMet) //aggiungi elemento alla lista dellestazioni (lstStazMet)
        {
            lstStazioni.Items.Add(StazMet.ID);
        }
        private void Info(StazioneMeteo StazMet) //funzione per visualizzare informazioni stazione a schermo
        {
            rctInfo.Text = StazMet.Info();
        }
        private void lstStazioni_SelectedIndexChanged(object sender, EventArgs e)//stampo info quando cambio Index
        {
            if (lstStazioni.SelectedIndex == -1) return;
            if(id == -1 || id == lstStazioni.SelectedIndex) id = lstStazioni.SelectedIndex;
            else
            {
                riga = new string[10];
                LetturaGen();
                if (err.Length > 0)
                {
                    MessageBox.Show(err, "ERRORE");
                    return;
                }
                StazMet = new StazioneMeteo(lstStazmet[id].ID, press, temp, piogg, umid, vento);
                lstStazmet[id] = StazMet;
                id = lstStazioni.SelectedIndex;
            }
            Info(lstStazmet[id]);
            CaricaDati(lstStazmet[id]);
            pctImg.BackgroundImage = lstStazmet[id].Pioggia() ? Image.FromFile("pioggia.jpg") : Image.FromFile("sole.jpg");
        }
        private void CaricaDati(StazioneMeteo StazMet1)
        {
            Valori(StazMet1.Print().Split(','));
            txtPressione.Text = press.ToString();
            txtTemp0.Text = temp[0].ToString();
            txtTemp1.Text = temp[1].ToString();
            txtTemp2.Text = temp[2].ToString();
            txtTemp3.Text = temp[3].ToString();
            txtPioggia.Text = piogg.ToString();
            txtUmidità.Text = umid.ToString();
            txtVento.Text = vento.ToString();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            CaricaDati(StazMet = new StazioneMeteo());
        }
        private void txtId_KeyPress(object sender, KeyPressEventArgs e) => Numero(e);
        private void txtPressione_KeyPress(object sender, KeyPressEventArgs e) => Numero(e);
        private void txtTemp0_KeyPress(object sender, KeyPressEventArgs e) => Numero1(e);
        private void txtTemp1_KeyPress(object sender, KeyPressEventArgs e) => Numero1(e);
        private void txtTemp2_KeyPress(object sender, KeyPressEventArgs e) => Numero1(e);
        private void txtTemp3_KeyPress(object sender, KeyPressEventArgs e) => Numero1(e);
        private void txtPioggia_KeyPress(object sender, KeyPressEventArgs e) => Numero(e);
        private void txtUmidità_KeyPress(object sender, KeyPressEventArgs e) => Numero(e);
        private void txtVento_KeyPress(object sender, KeyPressEventArgs e) => Numero(e);
        private void btnReport_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter("file.csv"))
            {
                sw.WriteLine("ID,PRESSIONE,TEMP(00:00),TEMP(06:00),TEMP(12:00),TEMP(18:00),PIOGGIA,UMIDITA',VENTO");
                foreach(StazioneMeteo StazMet in lstStazmet)
                {
                    sw.WriteLine(StazMet.Print());
                }
            }
            MessageBox.Show("File salvato con successo ✅");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LeggiFile();
        }

        private void Numero(KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != ',' && e.KeyChar != '.') 
                e.KeyChar = (char)0;
        }
        private void Numero1(KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != ',' && e.KeyChar != '.' && e.KeyChar != '-')
                e.KeyChar = (char)0;
        }
        private bool Lettura(TextBox testo,ref double valore, string message)
        {
            if (testo.Text == "")
            {
                err += $"Inserire valore {message}\n";
                return false;
            }
            double.TryParse(testo.Text, out valore);
            return true;
        }
        private bool Lettura1(TextBox testo,ref double valore, string message)
        {
            if (Lettura(testo,ref valore, message))
            {
                if(valore > 100)
                {
                    err+= $"Inserire valore {message} in % tra 0-100";
                    return false;
                }
            }
            return true;
        }
    }
}
