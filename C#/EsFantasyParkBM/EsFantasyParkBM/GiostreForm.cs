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
    public partial class GiostreForm : Form
    {
        public int[] persone;
        public bool notifiche;
        public GiostreForm()
        {
            InitializeComponent();
            persone = new int[3];
            LeggiCSV();
            notifiche = true;
        }

        private void txtAddvel_KeyPress(object sender, KeyPressEventArgs e) => Number(e);
        private void txtAddObl_KeyPress(object sender, KeyPressEventArgs e) => Number(e);
        private void txtAddBlu_KeyPress(object sender, KeyPressEventArgs e) => Number(e);

        private void btnAddVel_Click(object sender, EventArgs e)
        {
            if(txtAddvel.Text != "")
            {
                persone[0] += int.Parse(txtAddvel.Text);
                txtFilaVel.Text = persone[0].ToString();
                Corretto();
            }
        }

        private void btnAddObl_Click(object sender, EventArgs e)
        {
            if (txtAddObl.Text != "")
            {
                persone[1] += int.Parse(txtAddObl.Text);
                txtFilaObl.Text = persone[1].ToString();
                Corretto();
            }
        }

        private void btnAddBlu_Click(object sender, EventArgs e)
        {
            if (txtAddObl.Text != "")
            {
                persone[2] += int.Parse(txtAddBlu.Text);
                txtFilaBlu.Text = persone[2].ToString();
                Corretto();
            }
        }

        public void Corretto()
        {
            if(notifiche) MessageBox.Show("Persone aggiunte correttamente");
            CaricaCSV();
        }

        private void btnLaunchVel_Click(object sender, EventArgs e)
        {
            Launch(0, 28);
            txtFilaVel.Text = persone[0].ToString();
        }

        private void btnLaunchObl_Click(object sender, EventArgs e)
        {
            Launch(1, 18);
            txtFilaObl.Text = persone[1].ToString();
        }

        private void btnLaunchBlu_Click(object sender, EventArgs e)
        {
            Launch(2, 28);
            txtFilaBlu.Text = persone[2].ToString();
            
        }

        public void Launch(int n, int lim)
        {
            if (persone[n] < lim)
            {
                if (notifiche) MessageBox.Show($"Vagone partito correttamente con {persone[n]} persone");
                persone[n] = 0;
            }
            else
            {
                if (notifiche) MessageBox.Show($"Vagone partito correttamente con {lim} persone");
                persone[n] -= lim;
            }
            CaricaCSV();
        }

        public void Number(KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != (char)Keys.Clear)
            {
                e.KeyChar = (char)0;
                e.Handled = true;
            }
        }

        public void LeggiCSV()
        {
            if (!File.Exists("giostre.csv"))
            {
                File.WriteAllText("giostre.csv", "0,0,0");
                if (notifiche) MessageBox.Show("File creato con successo");
            }
            using (StreamReader sr = new StreamReader("giostre.csv"))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    if (line != null)
                    {
                        string[] linea = line.Split(',');
                        for (int i = 0; i < 3; i++) persone[i] = int.Parse(linea[i]);
                        txtFilaVel.Text = persone[0].ToString();
                        txtFilaObl.Text = persone[1].ToString();
                        txtFilaBlu.Text = persone[2].ToString();
                    }


                }
            }
        }

        public void CaricaCSV()
        {
            using (StreamWriter sw = new StreamWriter("giostre.csv"))
            {
                sw.WriteLine($"{persone[0]},{persone[1]},{persone[2]}");
            }
        }

        private void rdbSi_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbSi.Checked) notifiche = true;
            else notifiche = false;
        }
    }
}
