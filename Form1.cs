using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
            this.aNGAJATITableAdapter.Fill(this.dataSet1.ANGAJATI);
            this.pROCENTAJETableAdapter.Fill(this.dataSet1.PROCENTAJE);
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                if (col.Name.ToUpper().Contains("IMAGINE"))
                {
                    col.Visible = false;
                }
            }
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            ToolTip hint = new ToolTip();
            hint.SetToolTip(btnAjutor, "Deschide fereastra de ajutor");
            hint.SetToolTip(btnIesire, "Închide aplicația");

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

        private void button3_Click(object sender, EventArgs e)
        {
            var f = new FormStergereAngajat(this.dataSet1, this.aNGAJATITableAdapter);
            f.ShowDialog();
            this.aNGAJATITableAdapter.Fill(this.dataSet1.ANGAJATI);
        }

        private void txtCautare_TextChanged(object sender, EventArgs e)
        {
            string cautare = txtCautare.Text.Trim().ToLower();

            var rand = dataSet1.ANGAJATI
                .FirstOrDefault(a => a.NUME.ToLower().Contains(cautare) || a.PRENUME.ToLower().Contains(cautare));

            if (rand != null)
            {
                lblRezultat.Text = $"{rand.NUME} {rand.PRENUME} - {rand.FUNCTIE}";

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.DataBoundItem is DataRowView drv)
                    {
                        var a = (DataSet1.ANGAJATIRow)drv.Row;
                        if (a.NRCRT == rand.NRCRT) 
                        {
                            row.Selected = true;
                            dataGridView1.FirstDisplayedScrollingRowIndex = row.Index;
                            break;
                        }
                    }
                }
            }
            else
            {
                lblRezultat.Text = "Nicio potrivire.";
                dataGridView1.ClearSelection();
            }
        }

        private void btnAdaugaShortcut_Click(object sender, EventArgs e)
        {

        }

        private void btnAjutor_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
        "Aplicația permite:\n- Calcul salarii\n- Adăugare / Ștergere / Modificare angajați\n- Generare rapoarte\n- Protecție modificare procente\n\nSucces!",
        "Ajutor", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnIesire_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnStergeShortcut_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    picPoza.Image = null;
                    return;
                }

                var rowView = dataGridView1.SelectedRows[0].DataBoundItem as DataRowView;
                if (rowView == null)
                {
                    picPoza.Image = null;
                    return;
                }

                var row = rowView.Row;

                if (!row.IsNull("IMAGINE"))
                {
                    byte[] imgData = (byte[])row["IMAGINE"];

                    // Dacă e gol, nu încerca să încarci
                    if (imgData.Length > 0)
                    {
                        using (MemoryStream ms = new MemoryStream(imgData))
                        {
                            picPoza.Image = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        picPoza.Image = null; // sau imagine default
                    }
                }
                else
                {
                    picPoza.Image = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la afișarea imaginii: " + ex.Message);
                picPoza.Image = null;
            }
        }
    }
}
