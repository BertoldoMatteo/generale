using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsPuffiBM
{
    public struct Punto
    {
        public int x, y;

        public Punto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Punto W() => new Punto(this.x, this.y - 5);
        public Punto S() => new Punto(this.x, this.y + 5);
        public Punto A() => new Punto(this.x - 5, this.y);
        public Punto D() => new Punto(this.x + 5, this.y);
    }
    public partial class Form1 : Form
    {
        private Punto punto;
        public Random random;
        public int randomx;
        public int randomy;
        public int count, diffy, diffx;


        private void btnLegenda_Click(object sender, EventArgs e)
        {
            pnlLegenda.Visible = true;
        }

        private void btnIstruzioni_Click(object sender, EventArgs e)
        {
            lblIstruzioni.Visible = true;
        }

        private void btnAvvia_Click_1(object sender, EventArgs e)
        {
            btnAvvia.Visible = false;
            pnlAvvia.Visible = false;
        }

        public Form1()
        {
            InitializeComponent();
            punto = new Punto(224, 77);
            this.KeyPreview = true;
            this.KeyDown += keyDown;
            random = new Random();
            count = 0;

        }

        private void keyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W && pnlPuffo.Location.Y > -5) punto = punto.W();
            else if (e.KeyCode == Keys.S && pnlPuffo.Location.Y < 155) punto = punto.S();
            else if (e.KeyCode == Keys.A && pnlPuffo.Location.X > 0) punto = punto.A();
            else if (e.KeyCode == Keys.D && pnlPuffo.Location.X < 440) punto = punto.D();
            pnlPuffo.Location = new Point((int)punto.x, (int)punto.y);
            diffx = Math.Abs(pnlPuffo.Location.X - pnlCasa.Location.X);
            diffy = Math.Abs(pnlPuffo.Location.Y - pnlCasa.Location.Y);
            if (diffx+diffy<70)
            {
                randomx = random.Next(441);
                randomy = random.Next(156);
                pnlCasa.Location = new Point(randomx, randomy);
                count++;
                txtPunti.Text = $"{count}";
            }
        }
    }
}
