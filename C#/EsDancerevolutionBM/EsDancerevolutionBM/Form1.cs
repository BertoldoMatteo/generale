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

namespace EsDancerevolutionBM
{
    public partial class Form1 : Form
    {
        public enum Colors
        {
            Red,
            Yellow,
            Blue,
            Orange,
            White
        }

        private int num;
        private Timer timer;
        SoundPlayer musica = new SoundPlayer("musica.wav");

        public Form1()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 5000; // Imposta l'intervallo del timer a 5 secondi (5000 millisecondi)
            timer.Tick += Timer_Tick;
            timer.Start();
            SetRandomColor();
            musica.PlayLooping();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("Tempo scaduto!");
            SetRandomColor();
            timer.Start();
        }

        private void btnRed_Click(object sender, EventArgs e) => button(0);
        private void btnYellow_Click(object sender, EventArgs e) => button(1);
        private void btnBlue_Click(object sender, EventArgs e) => button(2);
        private void btnOrange_Click(object sender, EventArgs e) => button(3);
        private void btnWhite_Click(object sender, EventArgs e) => button(4);

        public void button(int n)
        {
            if (num == n)
            {
                SetRandomColor();
                timer.Stop();
                timer.Start();
            }
            else MessageBox.Show("Sbagliato!");
        }

        public void SetRandomColor()
        {
            Random rand = new Random();
            num = rand.Next(0, 5);
            Illumina(num);
        }

        public void Illumina(int num)
        {
            Reset();
            switch (num)
            {
                case 0:
                    btnRed.BackgroundImage = Image.FromFile("red.png");
                    break;
                case 1:
                    btnYellow.BackgroundImage = Image.FromFile("yellow.png");
                    break;
                case 2:
                    btnBlue.BackgroundImage = Image.FromFile("blue.png");
                    break;
                case 3:
                    btnOrange.BackgroundImage = Image.FromFile("orange.png");
                    break;
                case 4:
                    btnWhite.BackgroundImage = Image.FromFile("white.png");
                    break;
                default:
                    MessageBox.Show("Error");
                    break;
            }
        }
        public void Reset()
        {
            btnRed.BackgroundImage = Image.FromFile("frecciaE.png");
            btnYellow.BackgroundImage = Image.FromFile("frecciaN.png");
            btnBlue.BackgroundImage = Image.FromFile("frecciaO.png");
            btnOrange.BackgroundImage = Image.FromFile("frecciaS.png");
            btnWhite.BackgroundImage = Image.FromFile("cerchio.png");
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar) && e.KeyChar != '\b') {
                e.KeyChar = (char)0;
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                int newInterval = int.Parse(textBox1.Text) * 1000;
                timer.Interval = newInterval;
                MessageBox.Show("Intervallo cambiato a " + textBox1.Text + " secondi.");
            }
            else
            {
                MessageBox.Show("Inserisci un numero valido.");
            }
        }
    }
}
