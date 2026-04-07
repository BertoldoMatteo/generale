using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsFantasyParkBM
{
    public partial class Form1 : Form
    {
        SoundPlayer player;
        bool staSuonando = false;

        public Form1()
        {
            InitializeComponent();
            player = new SoundPlayer("sottofondo.wav");
        }

        private void btnBiglietti_Click(object sender, EventArgs e)
        {
            BigliettiForm bigliettiForm = new BigliettiForm();
            bigliettiForm.Show();
        }

        private void btnAttrazioni_Click(object sender, EventArgs e)
        {
            AttrazioniForm attrazioniForm = new AttrazioniForm();
            attrazioniForm.Show();
        }

        private void btnGiostre_Click(object sender, EventArgs e)
        {
            GiostreForm giostreForm = new GiostreForm();
            giostreForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMusic_Click_1(object sender, EventArgs e)
        {
            if (staSuonando)
            {
                player.Stop();
                btnMusic.BackgroundImage = Properties.Resources.Volume_OFF;
                staSuonando = false;
            }
            else
            {
                if (System.IO.File.Exists("sottofondo.wav"))
                {
                    player.PlayLooping();
                    btnMusic.BackgroundImage = Properties.Resources.Volume_ON;
                    staSuonando = true;
                }
                else
                {
                    MessageBox.Show("File audio non trovato!");
                }
            }
        }
    }
}