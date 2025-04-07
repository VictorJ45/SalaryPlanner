using System;
using System.Linq;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text;
using Proiect.DataSet1TableAdapters;

namespace Proiect
{
    public partial class FormModificareParola : Form
    {
        private DataSet1 dataSet;
        private PROCENTAJETableAdapter tableAdapter;
        public FormModificareParola(DataSet1 dataSet, PROCENTAJETableAdapter tableAdapter)
        {
            InitializeComponent();
            this.dataSet = dataSet;
            this.tableAdapter = tableAdapter;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string parolaVeche = txtParolaVeche.Text.Trim();
            string parolaNoua = txtParolaNoua.Text.Trim();
            string confirmareParola = txtConfirmare.Text.Trim();
            var rand = dataSet.PROCENTAJE.FirstOrDefault(); // ⚠️ Acum e înainte de a-l folosi

            if (rand == null)
            {
                MessageBox.Show("Nu s-a găsit rândul din tabelul PROCENTAJE.");
                return;
            }
            string hashVeche = HashParola(parolaVeche);
            string hashNoua = HashParola(parolaNoua);


            MessageBox.Show("Hash generat din input: \n" + hashVeche +"\nHash salvat în DB: \n" + rand.PAROLA_CRIPTATA);
            MessageBox.Show("Text introdus: [" + txtParolaVeche.Text + "]");

            if (string.IsNullOrEmpty(parolaVeche) || string.IsNullOrEmpty(parolaNoua))
            {
                MessageBox.Show("Completează toate câmpurile.");
                return;
            }

            if (parolaNoua != confirmareParola)
            {
                MessageBox.Show("Parola nouă și confirmarea nu coincid.");
                return;
            }

            if (parolaNoua.Length < 6)
            {
                MessageBox.Show("Parola trebuie să aibă cel puțin 6 caractere.");
                return;
            }

            if (rand == null)
            {
                MessageBox.Show("Nu s-a găsit rândul din tabelul PROCENTAJE.");
                return;
            }

            if (rand.PAROLA_CRIPTATA != hashVeche)
            {
                MessageBox.Show("Parola veche este greșită.");
                return;
            }

            try
            {
                rand.PAROLA_CRIPTATA = hashNoua;
                this.Validate();
                tableAdapter.Update(dataSet.PROCENTAJE);
                MessageBox.Show("Parola a fost schimbată cu succes!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la salvare: " + ex.Message);
            }
        }
        private string HashParola(string parola)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] hashBytes = sha.ComputeHash(Encoding.UTF8.GetBytes(parola));
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
