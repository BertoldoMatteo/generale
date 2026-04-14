using EsOperatoreSIM;
using System;
using System.Drawing;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace EsOperatoreSIM
{
    public partial class FormSIM : Form
    {
        private SIM sim;
        public FormSIM()
        {
            InitializeComponent();
        }
        private void BtnCreaSIM_Click(object sender, EventArgs e)
        {
            string numero = txtNumero.Text.Trim();
            if (string.IsNullOrEmpty(numero))
            {
                MessageBox.Show("Inserisci un numero di telefono.", "Errore");
                return;
            }
            if (numero.Length != 10)
            {
                MessageBox.Show("Inserisci il numero di telefono di 10 cifre.", "Errore");
                return;
            }
            if (!double.TryParse(txtCredito.Text, out double credito) || credito < 0)
            {
                MessageBox.Show("Inserisci un credito valido (numero >= 0).", "Errore");
                return;
            }

            sim = new SIM(numero, credito);
            grpTelefonata.Enabled = true;
            grpCerca.Enabled = true;
            btnStampa.Enabled = true;
            grpCrea.Enabled = false;

            Stampa($"SIM creata per {numero} con credito €{credito}\n");
        }
        private void BtnAggiungi_Click(object sender, EventArgs e)
        {
            string dest = txtDest.Text.Trim();
            if (string.IsNullOrEmpty(dest))
            {
                MessageBox.Show("Inserisci il numero destinatario.", "Errore");
                return;
            }
            if (dest.Length != 10)
            {
                MessageBox.Show("Inserisci il numero destinatario di 10 cifre.", "Errore");
                return;
            }
            if(dest == sim.NumTel)
            {
                MessageBox.Show("Numero destinatario uguale al numero SIM.", "Errore");
                return;
            }
            if (!int.TryParse(txtDurata.Text, out int durata) || durata <= 0)
            {
                MessageBox.Show("Inserisci una durata valida (minuti interi > 0).", "Errore");
                return;
            }

            sim.AggTel(dest, durata);
            Stampa($"Aggiunta telefonata → {dest} ({durata} min)\n");
            txtDest.Clear();
            txtDurata.Clear();
            txtDest.Focus();
        }
        private void BtnCerca_Click(object sender, EventArgs e)
        {
            string numero = txtCercaNumero.Text.Trim();
            if (string.IsNullOrEmpty(numero))
            {
                MessageBox.Show("Inserisci un numero da cercare.", "Errore");
                return;
            }
            if (numero.Length != 10)
            {
                MessageBox.Show("Inserisci un numero da cercare di 10 cifre.", "Errore");
                return;
            }
            int count = sim.CalcTelNum(numero);
            Stampa($"Telefonate verso {numero}: {count}\n");
        }
        private void BtnStampa_Click(object sender, EventArgs e)
        {
            rtbOutput.Clear();
            Stampa(sim.StampaDati());
        }
        private void Stampa(string testo) => rtbOutput.AppendText(testo);
        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e) => NumeroTel(e);
        private void txtDest_KeyPress_1(object sender, KeyPressEventArgs e) => NumeroTel(e);
        private void txtCercaNumero_KeyPress(object sender, KeyPressEventArgs e) => NumeroTel(e);
        private void txtDurata_KeyPress(object sender, KeyPressEventArgs e) => NumeroTel(e);
        public void NumeroTel(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.KeyChar = (char)0;
            }
        }
        private void txtCredito_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.KeyChar = (char)0;
            }
        }
    }
}
