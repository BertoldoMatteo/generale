namespace StazioneMeteoTaff
{
    public partial class frmAggiungi : Form
    {

        public CStazioneMeteo stazione { get; set; }
        public frmAggiungi()
        {
            InitializeComponent();
        }

        public frmAggiungi(CStazioneMeteo s) : this()
        {
            stazione = s;
            CaricaDatiNelForm();
        }

        private void btnAvvia_Click(object sender, EventArgs e)
        {
            try
            {
                int numero = int.Parse(textBoxNumero.Text);
                double barometro = double.Parse(textBoxBarometro.Text);

                double[] temp = new double[4];
                temp[0] = double.Parse(textBoxTemp1.Text);
                temp[1] = double.Parse(textBoxTemp2.Text);
                temp[2] = double.Parse(textBoxTemp3.Text);
                temp[3] = double.Parse(textBoxTemp4.Text);

                double pluviometro = double.Parse(textBoxPluviometro.Text);
                double igrometro = double.Parse(textBoxIgrometro.Text);
                double anemometro = double.Parse(textBoxAnemometro.Text);

                // CREAZIONE OGGETTO
                stazione = new CStazioneMeteo(
                    numero,
                    barometro,
                    temp,
                    pluviometro,
                    igrometro,
                    anemometro
                );

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore nei dati: " + ex.Message);
            }

        }

        private void frmAggiungi_Load(object sender, EventArgs e)
        {

        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void CaricaDatiNelForm()
        {
            if (stazione == null)
                return;

            textBoxNumero.Text = stazione.NumeroStazione.ToString();
            textBoxBarometro.Text = stazione.Barometro.ToString();

            textBoxTemp1.Text = stazione.Temperature[0].ToString();
            textBoxTemp2.Text = stazione.Temperature[1].ToString();
            textBoxTemp3.Text = stazione.Temperature[2].ToString();
            textBoxTemp4.Text = stazione.Temperature[3].ToString();

            textBoxPluviometro.Text = stazione.Pluviometro.ToString();
            textBoxIgrometro.Text = stazione.Igrometro.ToString();
            textBoxAnemometro.Text = stazione.Anemometro.ToString();
        }

    }
}
