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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.pROCENTAJETableAdapter.Fill(this.dataSet1.PROCENTAJE);
            this.aNGAJATITableAdapter.Fill(this.dataSet1.ANGAJATI);
            this.aNGAJATITableAdapter.Fill(this.dataSet1.ANGAJATI);
            dataGridView1.ReadOnly = true;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var f = new AdaugareAngajat();

            if (f.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    this.aNGAJATITableAdapter.Insert(
                        f.Nume,
                        f.Prenume,
                        f.Functie,
                        f.SalarBaza,
                        f.SporProc,
                        f.Premii,
                        f.Retineri,
                        0, 0, 0, 0, 0, 0 
                    );

                    MessageBox.Show("Angajat adăugat cu succes!");
                    this.aNGAJATITableAdapter.Fill(this.dataSet1.ANGAJATI);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Eroare la inserare: " + ex.Message);
                }
            }
        }

        private void btnSchimbaParola_Click(object sender, EventArgs e)
        {
            var f = new FormModificareParola(this.dataSet1, this.pROCENTAJETableAdapter);
            if (f.ShowDialog() == DialogResult.OK)
            {
                this.pROCENTAJETableAdapter.Fill(this.dataSet1.PROCENTAJE); 
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnModificaProcente_Click(object sender, EventArgs e)
        {
            var fParola = new FormParolaProcente(this.dataSet1, this.pROCENTAJETableAdapter);
            if (fParola.ShowDialog() == DialogResult.OK && fParola.Autorizat)
            {
                var fProcente = new FormModificareProcente(this.dataSet1, this.pROCENTAJETableAdapter);
                if (fProcente.ShowDialog() == DialogResult.OK)
                {
                    this.aNGAJATITableAdapter.Fill(this.dataSet1.ANGAJATI);
                }
            }
            else
            {
                MessageBox.Show("Parola greșită. Acces refuzat.");
            }
        }

        private void btnActualizare_Click(object sender, EventArgs e)
        {
            var f = new FormActualizareAngajat(this.dataSet1, this.aNGAJATITableAdapter);
            f.ShowDialog();
            this.aNGAJATITableAdapter.Fill(this.dataSet1.ANGAJATI);
        }
    }
}
