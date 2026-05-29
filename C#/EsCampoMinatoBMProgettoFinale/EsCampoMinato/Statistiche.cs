using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsCampoMinato
{
    public partial class Statistiche : Form
    {
        public int totPartite;
        public float totTempo;
        public float PercVittoria;
        public int nSerie = 0;
        public int win = 0;
        public int SerieMax = 0;

        public Statistiche()
        {
            InitializeComponent();
        }

        //funzione per aggiornare le label con tutte le statistiche
        public void AggiornaStat(int vinte, int perse, int abbandonate, float timeVinto, float timePerso, float timeAbbandonato, int celVinte, int celPerse, int celAbbandonate)
        {
            totPartite = vinte + perse + abbandonate;
            lblVinte.Text = vinte.ToString();
            lblPerse.Text = perse.ToString();
            lblAbbandonate.Text = abbandonate.ToString();
            lblTotPartite.Text = (totPartite).ToString();

            lblTempoVinte.Text = timeVinto >= 100.0 ? ((int)timeVinto).ToString() + "s" : timeVinto.ToString("F1") + "s";
            lblTempoPerse.Text = timePerso >= 100.0 ? ((int)timePerso).ToString() + "s" : timePerso.ToString("F1") + "s";
            lblTempoAbbandonate.Text = timeAbbandonato >= 100.0 ? ((int)timeVinto).ToString() + "s" : timeAbbandonato.ToString("F1") + "s";
            totTempo = timeVinto + timePerso + timeAbbandonato;
            lblTempoTot.Text = totTempo >= 100.0 ? ((int)totTempo).ToString() : (totTempo).ToString("F1") + "s";

            lblCelleVinte.Text = celVinte.ToString();
            lblCellePerse.Text = celPerse.ToString();
            lblCelleAbbandonate.Text = celAbbandonate.ToString();
            lblCelleTot.Text = (celVinte + celPerse + celAbbandonate).ToString();

            PercVittoria = (((float)vinte / (float)totPartite) * 100);
            lblPercVittoria.Text = ((int)PercVittoria).ToString() + "%";
            if(vinte > win)
            {
                win = vinte;
                nSerie++;
                lblSerie.Text = nSerie.ToString();
                if(nSerie > SerieMax)
                {
                    SerieMax = nSerie;
                    lblSerieMax.Text = SerieMax.ToString();
                }
            }
            else
            {
                nSerie = 0;
                lblSerie.Text = nSerie.ToString();
            }
        }
    }
}
