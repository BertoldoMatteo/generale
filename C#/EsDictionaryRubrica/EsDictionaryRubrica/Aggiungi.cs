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
    public partial class Aggiungi : Form
    {
        private Dictionary<string, Contatto> rubrica;
        private List<string> lstContatti;

        public Aggiungi(Dictionary<string, Contatto> rubrica, List<string> lstContatti)
        {
            InitializeComponent();
            this.rubrica = rubrica;
            this.lstContatti = lstContatti;
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text.Trim();
            string telefono = txtTelefono.Text.Trim();
            string email = txtEmail.Text.Trim();
            DateTime data = dtpCompleanno.Value;

            if (nome == "")
            {
                MessageBox.Show("Inserire un nome");
                return;
            }

            if (rubrica.ContainsKey(nome))
            {
                MessageBox.Show("Nome già presente in rubrica");
                return;
            }

            try
            {
                Contatto c = new Contatto();
                c.Telefono = telefono;
                c.Email = email;
                c.DataCompleanno = data;

                rubrica.Add(nome, c);
                lstContatti.Add(nome);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
