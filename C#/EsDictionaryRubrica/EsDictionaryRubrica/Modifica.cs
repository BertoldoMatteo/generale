using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsDictionaryRubrica
{
    public partial class Modifica : Form
    {
        private Dictionary<string, Contatto> rubrica;
        private List<string> lstContatti;
        private string nomeOriginale;

        public Modifica(Dictionary<string, Contatto> rubrica, List<string> lstContatti, string nomeOriginale, Contatto contatto)
        {
            InitializeComponent();
            this.rubrica = rubrica;
            this.lstContatti = lstContatti;
            this.nomeOriginale = nomeOriginale;

            txtNome.Text = nomeOriginale;
            txtTelefono.Text = contatto.Telefono;
            txtEmail.Text = contatto.Email;
            dtpCompleanno.Value = contatto.DataCompleanno;
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            string nuovoNome = txtNome.Text.Trim();
            string telefono = txtTelefono.Text.Trim();
            string email = txtEmail.Text.Trim();
            DateTime data = dtpCompleanno.Value;

            if (nuovoNome == "")
            {
                MessageBox.Show("Inserire un nome");
                return;
            }

            try
            {
                if (nuovoNome != nomeOriginale)
                {
                    if (rubrica.ContainsKey(nuovoNome))
                    {
                        MessageBox.Show("Nome già presente in rubrica");
                        return;
                    }

                    int indice = lstContatti.IndexOf(nomeOriginale);

                    rubrica.Remove(nomeOriginale);

                    Contatto c = new Contatto();
                    c.Telefono = telefono;
                    c.Email = email;
                    c.DataCompleanno = data;

                    rubrica.Add(nuovoNome, c);
                    lstContatti[indice] = nuovoNome;
                }
                else
                {
                    Contatto c = rubrica[nomeOriginale];
                    c.Telefono = telefono;
                    c.Email = email;
                    c.DataCompleanno = data;
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
