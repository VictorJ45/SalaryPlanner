using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proiect.DataSet1TableAdapters;

namespace Proiect
{
    public partial class FormActualizareAngajat : Form
    {
        private DataSet1 dataSet;
        private ANGAJATITableAdapter adapter;

        private DataSet1.ANGAJATIRow angajatGasit;

        public FormActualizareAngajat(DataSet1 ds, ANGAJATITableAdapter tableAdapter)
        {
            InitializeComponent();
            this.dataSet = ds;
            this.adapter = tableAdapter;

            if (dataSet.ANGAJATI.Count == 0)
                adapter.Fill(dataSet.ANGAJATI);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCautare_Click(object sender, EventArgs e)
        {
            string nume = txtNume.Text.Trim();
            string prenume = txtPrenume.Text.Trim();

            // Caută angajatul în dataset
            angajatGasit = dataSet.ANGAJATI
                .FirstOrDefault(a => a.NUME.Equals(nume, StringComparison.OrdinalIgnoreCase)
                                  && a.PRENUME.Equals(prenume, StringComparison.OrdinalIgnoreCase));

            if (angajatGasit != null)
            {
                // Populate toate câmpurile
                txtNume.Text = angajatGasit.NUME;
                txtPrenume.Text = angajatGasit.PRENUME;
                txtSalar.Text = angajatGasit.SALAR_BAZA.ToString();
                txtSpor.Text = angajatGasit.SPOR_PROC.ToString();
                txtPremii.Text = angajatGasit.PREMII_BRUTE.ToString();
                txtRetineri.Text = angajatGasit.RETINERI.ToString();
            }
            else
            {
                MessageBox.Show("Angajatul nu a fost găsit.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSalveaza_Click(object sender, EventArgs e)
        {
            if (angajatGasit == null)
            {
                MessageBox.Show("Niciun angajat selectat pentru actualizare.");
                return;
            }

            try
            {
                angajatGasit.NUME = txtNume.Text.Trim();
                angajatGasit.PRENUME = txtPrenume.Text.Trim();
                angajatGasit.SALAR_BAZA = decimal.Parse(txtSalar.Text);
                angajatGasit.SPOR_PROC = decimal.Parse(txtSpor.Text);
                angajatGasit.PREMII_BRUTE = decimal.Parse(txtPremii.Text);
                angajatGasit.RETINERI = decimal.Parse(txtRetineri.Text);

                this.Validate();
                adapter.Update(dataSet.ANGAJATI);

                MessageBox.Show("Datele angajatului au fost actualizate cu succes!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la salvare: " + ex.Message);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
