using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Proiect.DataSet1TableAdapters;

namespace Proiect
{
    public partial class FormModificareProcente : Form
    {

        private DataSet1 dataSet;
        private PROCENTAJETableAdapter tableAdapter;
        public FormModificareProcente(DataSet1 ds, PROCENTAJETableAdapter adapter)
        {
            InitializeComponent();
            this.dataSet = ds;
            this.tableAdapter = adapter;

            if (dataSet.PROCENTAJE.Count == 0)
                tableAdapter.Fill(dataSet.PROCENTAJE);

            var procente = dataSet.PROCENTAJE.FirstOrDefault();
            if (procente != null)
            {
                txtCAS.Text = procente.CAS_PROC.ToString();
                txtCASS.Text = procente.CASS_PROC.ToString();
                txtImpozit.Text = procente.IMPOZIT_PROC.ToString();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSalveaza_Click(object sender, EventArgs e)
        {
            try
            {
                decimal cas = decimal.Parse(txtCAS.Text);
                decimal cass = decimal.Parse(txtCASS.Text);
                decimal impozit = decimal.Parse(txtImpozit.Text);

                var rand = dataSet.PROCENTAJE.FirstOrDefault();
                if (rand != null)
                {
                    rand.CAS_PROC = cas;
                    rand.CASS_PROC = cass;
                    rand.IMPOZIT_PROC = impozit;

                    this.Validate();
                    tableAdapter.Update(dataSet.PROCENTAJE);
                }

                // Conectare la baza de date
                using (OracleConnection conexiune = new OracleConnection("USER ID=PROIECT;PASSWORD=proiect;DATA SOURCE=localhost:1521/XE;TNS_ADMIN=C:\\Users\\victo\\Oracle\\network\\admin;PERSIST SECURITY INFO=True"))
                {
                    conexiune.Open();
                    MessageBox.Show("Conexiune realizată cu succes!");
                    OracleCommand cmd = new OracleCommand("Recalculeaza_Salarii", conexiune);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Procentele au fost salvate și salariile recalculate!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare: " + ex.Message);
            }
        }
    }
}
