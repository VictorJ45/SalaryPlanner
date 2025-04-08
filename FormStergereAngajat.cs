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
    public partial class FormStergereAngajat : Form
    {
        private DataSet1 dataSet;
        private ANGAJATITableAdapter adapter;
        private DataSet1.ANGAJATIRow angajatGasit;
        public FormStergereAngajat(DataSet1 ds, ANGAJATITableAdapter tableAdapter)
        {
            InitializeComponent();
            this.dataSet = ds;
            this.adapter = tableAdapter;

            if (dataSet.ANGAJATI.Count == 0)
                adapter.Fill(dataSet.ANGAJATI);
        }

        private void FormStergereAngajat_Load(object sender, EventArgs e)
        {

        }

        private void btnCautare_Click(object sender, EventArgs e)
        {
            string nume = txtNume.Text.Trim();
            string prenume = txtPrenume.Text.Trim();

            angajatGasit = dataSet.ANGAJATI
                .FirstOrDefault(a => a.NUME.Equals(nume, StringComparison.OrdinalIgnoreCase)
                                  && a.PRENUME.Equals(prenume, StringComparison.OrdinalIgnoreCase));

            if (angajatGasit != null)
            {
                lblDetalii.Text = $"Găsit: {angajatGasit.NUME} {angajatGasit.PRENUME}, {angajatGasit.FUNCTIE}";
                btnStergere.Enabled = true;
            }
            else
            {
                lblDetalii.Text = "Angajatul nu a fost găsit.";
                btnStergere.Enabled = false;
            }
        }

        private void btnStergere_Click(object sender, EventArgs e)
        {
            if (angajatGasit == null)
            {
                MessageBox.Show("Niciun angajat selectat pentru ștergere.");
                return;
            }

            var confirm = MessageBox.Show($"Sigur dorești să ștergi angajatul {angajatGasit.NUME} {angajatGasit.PRENUME}?",
                "Confirmare ștergere", MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {
                angajatGasit.Delete();
                adapter.Update(dataSet.ANGAJATI);
                MessageBox.Show("Angajatul a fost șters cu succes.");
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
