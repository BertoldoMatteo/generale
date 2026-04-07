using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsFantasyParkBM
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
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
    }
}
