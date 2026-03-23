using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsLibriBM
{
    public partial class Form2 : Form
    {
        public int nlibri, nlibridisp, nlibrigen;
        public List<Libro> lstLibri = new List<Libro>();
        public string[] arr = new string[] { "-Giallo: ", " -Fantasy: ", " -Fantascienza: ", " -Romanzo: ", " -Saggio: " };
        public Form2(List<Libro> libri)
        {
            InitializeComponent();
            lstLibri = libri;
            ContaLibriDisp();
            ContaLibGen();
            txtTotLib.Text = $"Libri totali = {lstLibri.Count}";
        }

        public void ContaLibriDisp()
        {
            foreach(Libro lib in lstLibri)
            {
                if (lib.disponibile) nlibridisp++;
            }
            txtDsipLib.Text = $"Libri disponibili = {nlibridisp}";
        }

        public void ContaLibGen()
        {
            
            for(int i=0; i<5;i++)
            {
                nlibrigen = 0;
                foreach (Libro lib in lstLibri)
                {
                    if (lib.genere == (Genere)i) nlibrigen++;
                }
                lstLibriGen.Items.Add(arr[i] + nlibrigen);
            }
        }
    }
}
