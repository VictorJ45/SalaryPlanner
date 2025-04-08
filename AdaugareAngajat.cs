using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace Proiect
{
    public partial class AdaugareAngajat : Form
    {
        public AdaugareAngajat()
        {
            InitializeComponent();
        }

        private byte[] pozaAngajat = null;
        public string Nume => txtNume.Text;
        public string Prenume => txtPrenume.Text;
        public string Functie => txtFunctie.Text;
        public int SalarBaza => int.Parse(txtSalarBaza.Text);
        public int SporProc => int.Parse(txtSporProc.Text);
        public int Premii => int.Parse(txtPremiiBrute.Text);
        public int Retineri => int.Parse(txtRetineri.Text);

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalveaza_Click(object sender, EventArgs e)
        {
            string connString = "USER ID=PROIECT;PASSWORD=proiect;DATA SOURCE=localhost:1521/XE;TNS_ADMIN=C:\\Users\\victo\\Oracle\\network\\admin;PERSIST SECURITY INFO=True";
            using (OracleConnection conn = new OracleConnection(connString))
            {
                conn.Open();

                string sql = @"INSERT INTO ANGAJATI 
                    (NUME, PRENUME, FUNCTIE, SALAR_BAZA, SPOR_PROC, PREMII_BRUTE, RETINERI,
                     TOTAL_BRUT, CAS, CASS, BRUT_IMPOZABIL, IMPOZIT, VIRAT_CARD, IMAGINE)
                    VALUES
                    (:nume, :prenume, :functie, :salar, :spor, :premii, :retineri,
                     0, 0, 0, 0, 0, 0, :poza)";

                using (OracleCommand cmd = new OracleCommand(sql, conn))
                {
                    cmd.Parameters.Add("nume", txtNume.Text);
                    cmd.Parameters.Add("prenume", txtPrenume.Text);
                    cmd.Parameters.Add("functie", txtFunctie.Text);
                    cmd.Parameters.Add("salar", int.Parse(txtSalarBaza.Text));
                    cmd.Parameters.Add("spor", int.Parse(txtSporProc.Text));
                    cmd.Parameters.Add("premii", int.Parse(txtPremiiBrute.Text));
                    cmd.Parameters.Add("retineri", int.Parse(txtRetineri.Text));
                    cmd.Parameters.Add("poza", OracleDbType.Blob).Value = pozaAngajat ?? new byte[0];

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Angajat adăugat cu succes!");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtPremiiBrute_TextChanged(object sender, EventArgs e)
        {

        }

        private void anulare_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnIncarcaPoza_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Imagini (*.jpg; *.png)|*.jpg;*.png";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pozaAngajat = File.ReadAllBytes(dlg.FileName);
                picAngajat.Image = Image.FromStream(new MemoryStream(pozaAngajat));
            }
        }

        private void picAngajat_Click(object sender, EventArgs e)
        {

        }
    }
}

