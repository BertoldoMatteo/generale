using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public partial class Form1 : Form
    {
        int count;
        string colore;
        public Form1()
        {
            InitializeComponent();
            count = 0;
            btnScopo.Text = "Cliccami!";
        }

        private void btnScopo_Click(object sender, EventArgs e)
        {
            colore = txtName.Text;
            
            switch (colore)
            {
                case "Rosso":
                    btnScopo.Text = "Ciao!";
                    btnScopo.BackColor = Color.Red;
                    this.BackColor = Color.Red;
                    break;
                case "Verde":
                    btnScopo.Text = "Benvenuto al Rossi!";
                    btnScopo.BackColor = Color.Green;
                    break;
                case "Nero":
                    btnScopo.Text = "Oggi c'è verifica!";
                    btnScopo.BackColor = Color.Black;
                    break;
                case "Viola":
                    btnScopo.Text = "Hai studiato?";
                    btnScopo.BackColor = Color.Violet;
                    break;
                case "Oro":
                    btnScopo.Text = "Non credo!";
                    btnScopo.BackColor = Color.Gold;
                    break;
                default:
                    btnScopo.Text = "Hai cliccato " + count + " volte!";
                    btnScopo.BackColor = Color.Brown;
                    break;
            }
            count++;
        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }
    }
}
