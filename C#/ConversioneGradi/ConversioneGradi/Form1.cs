using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversioneGradi
{
    public partial class Form1 : Form
    {
        double ris, n;
        bool Valid;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInvio_Click(object sender, EventArgs e)
        {
            txtOut.Text = ""+ris;
            Valid = double.TryParse(txtIn.Text, out n);
            if (!Valid)
            {
                MessageBox.Show("Inserire un numero valido");
                return;
            }
            switch (cmbConversioni.SelectedIndex)
            {
                case 1:
                    ris = (n * 9 / 5) + 32;
                    break;
                case 2:
                    ris = (n - 32) * 5 / 9;
                    break;
                case 3:
                    ris = n / 1.6;
                    break;
                case 4:
                    ris = n * 1.6;
                    break;
                default:
                    MessageBox.Show("Inserire una conversione");
                    return;
            }
        }
    }
}
