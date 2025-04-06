using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect
{
    public partial class AdaugareAngajat : Form
    {
        public AdaugareAngajat()
        {
            InitializeComponent();
        }

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
           
            // Validare: asigură-te că toate câmpurile sunt completate corect
            if (string.IsNullOrWhiteSpace(txtNume.Text) ||
                string.IsNullOrWhiteSpace(txtPrenume.Text) ||
                string.IsNullOrWhiteSpace(txtFunctie.Text) ||
                !int.TryParse(txtSalarBaza.Text, out _) ||
                !int.TryParse(txtSporProc.Text, out _) ||
                !int.TryParse(txtPremiiBrute.Text, out _) ||
                !int.TryParse(txtRetineri.Text, out _))
            {
                MessageBox.Show("Te rugăm să completezi toate câmpurile corect.", "Date invalide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // ieșim, nu se închide fereastra
            }

            // Dacă toate sunt OK, continuăm
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}

