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

        public Punto W(int mov) => new Punto(this.x, this.y - mov);
        public Punto S(int mov) => new Punto(this.x, this.y + mov);
        public Punto A(int mov) => new Punto(this.x - mov, this.y);
        public Punto D(int mov) => new Punto(this.x + mov, this.y);
    }
    public partial class Form1 : Form
    {
        private Punto casa, albero, Garga, puffo;
        public Random random;
        public int randomy, randomx,posx, posy, count, diffy, diffx, mov, puntiP, puntiG, spazioWidth, spazioHeight;

        private void btnHelp_Click(object sender, EventArgs e)
        {
            randomP();
        }

        public bool Turno, mescola, colpitoP, colpitoG; // vero se tocca al Puffo, Falso se tocca a Gargamella
        public Panel[] arr;

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
            count = 0; puntiP = 0; puntiG = 0;
            Turno = true; mescola = false; colpitoP = false; colpitoG = false;
            lblPuntiP.Text = "0"; lblPuntiG.Text = "0";
        }

        public Form1()
        {
            InitializeComponent();
            puffo = new Punto(pnlPuffo.Location.X, pnlPuffo.Location.Y);
            Garga = new Punto(pnlGarga.Location.X, pnlGarga.Location.Y);
            casa = new Punto(pnlCasa.Location.X, pnlCasa.Location.Y);
            albero = new Punto(pnlAlbero1.Location.X, pnlAlbero1.Location.Y);
            this.KeyPreview = true;
            this.KeyDown += keyDown;

            random = new Random();
            count = 0; puntiP = 0; puntiG = 0;
            mov = 0;
            spazioHeight = 0;
            spazioWidth = 0;
            Turno = true;
            mescola = false;
            colpitoP = false;
            colpitoG = false;
            arr = new Panel[] { pnlAlbero1, pnlAlbero2, pnlAlbero3, pnlAlbero4, pnlAlbero5, pnlAlbero6, pnlAlbero7, pnlAlbero8, pnlAlbero9, pnlAlbero10 };
        }

        private void keyDown(object sender, KeyEventArgs e)
        {
            spazioHeight = pnlGioco.Height;
            spazioWidth = pnlGioco.Width;
            mov = Math.Max(1, spazioWidth / 100);

            if(Turno)
            {
                lblTurno.Text = "PUFFO";
                pnlGioco.BackColor = Color.LightBlue;
                muoviP(e.KeyCode);
                count++;
                puffo = Controllo(puffo, pnlPuffo);
                pnlPuffo.Location = new Point((int)puffo.x, (int)puffo.y);
            }
            else
            {
                lblTurno.Text = "GARGAMELLA";
                pnlGioco.BackColor = Color.Black;
                muoviG(e.KeyCode);
                
                count++;
                Garga = Controllo(Garga, pnlGarga);
                pnlGarga.Location = new Point((int)Garga.x, (int)Garga.y);
            }

            if (pnlPuffo.Bounds.IntersectsWith(pnlCasa.Bounds))
            {
                randomC();
                puntiP++;
                lblPuntiP.Text = $"{puntiP}";
                mescola = true;
            }
            else if (pnlPuffo.Bounds.IntersectsWith(pnlGarga.Bounds))
            {
                randomP();
                puntiP--;
                puntiG++;
                lblPuntiP.Text = $"{puntiP}";
                lblPuntiG.Text = $"{puntiG}";
            }

            bool nuovoColpitoP = false;
            bool nuovoColpitoG = false;

            foreach (Panel i in arr)
            {
                if (Turno && pnlPuffo.Bounds.IntersectsWith(i.Bounds) && !colpitoP)
                {
                    posx = (i.Location.X - pnlPuffo.Location.X > 0)
                        ? i.Location.X - pnlPuffo.Width - 5
                        : i.Location.X + i.Width + 5;
                    posy = (i.Location.Y - pnlPuffo.Location.Y > 0)
                        ? i.Location.Y - pnlPuffo.Height - 5
                        : i.Location.Y + i.Height + 5;

                    posx = Math.Max(0, Math.Min(posx, spazioWidth - pnlPuffo.Width));
                    posy = Math.Max(0, Math.Min(posy, spazioHeight - pnlPuffo.Height));

                    puffo.x = posx; puffo.y = posy;
                    pnlPuffo.Location = new Point(posx, posy);
                    count = 10;
                    nuovoColpitoP = true;
                }
                else if (!Turno && pnlGarga.Bounds.IntersectsWith(i.Bounds) && !colpitoG)
                {
                    posx = (i.Location.X - pnlGarga.Location.X > 0)
                        ? i.Location.X - pnlGarga.Width - 5
                        : i.Location.X + i.Width + 5;
                    posy = (i.Location.Y - pnlGarga.Location.Y > 0)
                        ? i.Location.Y - pnlGarga.Height - 5
                        : i.Location.Y + i.Height + 5;

                    posx = Math.Max(0, Math.Min(posx, spazioWidth - pnlGarga.Width));
                    posy = Math.Max(0, Math.Min(posy, spazioHeight - pnlGarga.Height));

                    Garga.x = posx; Garga.y = posy;
                    pnlGarga.Location = new Point(posx, posy);
                    count = 10;
                    nuovoColpitoG = true;
                }
            }

            colpitoP = nuovoColpitoP;
            colpitoG = nuovoColpitoG;

            if (mescola)
            {
                foreach(Panel i in arr)
                {
                    randomA();
                    i.Location = new Point(albero.x, albero.y);
                }
                mescola = false;
            }

            if (count >= 10) { Turno = !Turno; count = 0; }
        }


        public void randomC()
        {
            randomx = random.Next(pnlGioco.Width - pnlCasa.Width);
            randomy = random.Next(pnlGioco.Height - pnlCasa.Height);
            casa.x = randomx;
            casa.y = randomy;
            pnlCasa.Location = new Point(casa.x, casa.y);
        }

        public void randomP()
        {
            randomx = random.Next(pnlGioco.Width - pnlPuffo.Width);
            randomy = random.Next(pnlGioco.Height - pnlPuffo.Height);
            puffo.x = randomx;
            puffo.y = randomy;
            pnlPuffo.Location = new Point(puffo.x, puffo.y);
        }

        public void randomA()
        {
            randomx = random.Next(pnlGioco.Width - pnlAlbero1.Width);
            randomy = random.Next(pnlGioco.Height - pnlAlbero1.Height);
            albero = new Punto(randomx, randomy);
        }
        public void muoviP(Keys e)
        {
            switch (e)
            {
                case Keys.W:
                    puffo = puffo.W(mov);
                    break;

                case Keys.S:
                    puffo = puffo.S(mov);
                    break;

                case Keys.A:
                    puffo = puffo.A(mov);
                    break;
                case Keys.D:
                    puffo = puffo.D(mov);
                    break;
                default:
                    count--;
                    break;
            }
        }

        public void muoviG(Keys e)
        {
            switch (e)
            {
                case Keys.I:
                    Garga = Garga.W(mov);
                    break;
                case Keys.J:
                    Garga = Garga.A(mov);
                    break;
                case Keys.K:
                    Garga = Garga.S(mov);
                    break;
                case Keys.L:
                    Garga = Garga.D(mov);
                    break;
                default:
                    count--;
                    break;

            }
        }
        public Punto Controllo(Punto point, Panel panel)
        {
            if (point.x < 0) point.x = 0;
            else if (point.x > spazioWidth - panel.Width) point.x = spazioWidth - panel.Width;

            if (point.y < 0) point.y = 0;
            else if (point.y > pnlGioco.Height - panel.Height) point.y = spazioHeight - panel.Height;
            return point;
        }
    }
}
