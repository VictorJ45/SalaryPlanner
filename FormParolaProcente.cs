using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Proiect.DataSet1TableAdapters;

namespace Proiect
{
    public partial class FormParolaProcente : Form
    {
        private DataSet1 dataSet;
        private PROCENTAJETableAdapter tableAdapter;

        public bool Autorizat { get; private set; } = false;
        public FormParolaProcente(DataSet1 ds, PROCENTAJETableAdapter adapter)
        {
            InitializeComponent();
            this.dataSet = ds;
            this.tableAdapter = adapter;

            if (dataSet.PROCENTAJE.Count == 0)
                tableAdapter.Fill(dataSet.PROCENTAJE);
        }

        private void btnConfirmare_Click(object sender, EventArgs e)
        {
            string input = txtParola.Text.Trim();
            string hash = HashParola(input);

            var rand = dataSet.PROCENTAJE.FirstOrDefault();
            if (rand != null && rand.PAROLA_CRIPTATA == hash)
            {
                Autorizat = true;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Parola introdusă este greșită.");
                txtParola.Clear();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void txtParola_TextChanged(object sender, EventArgs e)
        {

        }
        private string HashParola(string parola)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] hashBytes = sha.ComputeHash(Encoding.UTF8.GetBytes(parola));
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }
    }
}
