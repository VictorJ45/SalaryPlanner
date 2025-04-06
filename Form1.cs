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
            // TODO: This line of code loads data into the 'dataSet1.PROCENTAJE' table. You can move, or remove it, as needed.
            this.pROCENTAJETableAdapter.Fill(this.dataSet1.PROCENTAJE);
            // TODO: This line of code loads data into the 'dataSet1.ANGAJATI' table. You can move, or remove it, as needed.
            this.aNGAJATITableAdapter.Fill(this.dataSet1.ANGAJATI);
            // TODO: This line of code loads data into the 'dataSet1.ANGAJATI' table. You can move, or remove it, as needed.
            this.aNGAJATITableAdapter.Fill(this.dataSet1.ANGAJATI);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var f = new AdaugareAngajat();

            if (f.ShowDialog() == DialogResult.OK)
            {
                // Inserare în baza de date cu valorile din popup
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
                        0, 0, 0, 0, 0, 0 // se vor calcula în trigger
                    );

                    MessageBox.Show("Angajat adăugat cu succes!");
                    this.aNGAJATITableAdapter.Fill(this.dataSet1.ANGAJATI); // reîncărcare tabel
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Eroare la inserare: " + ex.Message);
                }
            }
        }
    }
}
