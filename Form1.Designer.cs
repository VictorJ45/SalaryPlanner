namespace Proiect
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nRCRTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nUMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRENUMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fUNCTIEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sALARBAZADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPORPROCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pREMIIBRUTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rETINERIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tOTALBRUTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cASDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cASSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bRUTIMPOZABILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iMPOZITDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vIRATCARDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aNGAJATIBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Proiect.DataSet1();
            this.aNGAJATIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aNGAJATITableAdapter = new Proiect.DataSet1TableAdapters.ANGAJATITableAdapter();
            this.pROCENTAJEBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pROCENTAJEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pROCENTAJETableAdapter = new Proiect.DataSet1TableAdapters.PROCENTAJETableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSchimbaParola = new System.Windows.Forms.Button();
            this.btnModificaProcente = new System.Windows.Forms.Button();
            this.btnActualizare = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtCautare = new System.Windows.Forms.TextBox();
            this.lblRezultat = new System.Windows.Forms.Label();
            this.panelShortcuts = new System.Windows.Forms.Panel();
            this.btnAjutor = new System.Windows.Forms.Button();
            this.btnIesire = new System.Windows.Forms.Button();
            this.picPoza = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aNGAJATIBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aNGAJATIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROCENTAJEBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROCENTAJEBindingSource)).BeginInit();
            this.panelShortcuts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPoza)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nRCRTDataGridViewTextBoxColumn,
            this.nUMEDataGridViewTextBoxColumn,
            this.pRENUMEDataGridViewTextBoxColumn,
            this.fUNCTIEDataGridViewTextBoxColumn,
            this.sALARBAZADataGridViewTextBoxColumn,
            this.sPORPROCDataGridViewTextBoxColumn,
            this.pREMIIBRUTEDataGridViewTextBoxColumn,
            this.rETINERIDataGridViewTextBoxColumn,
            this.tOTALBRUTDataGridViewTextBoxColumn,
            this.cASDataGridViewTextBoxColumn,
            this.cASSDataGridViewTextBoxColumn,
            this.bRUTIMPOZABILDataGridViewTextBoxColumn,
            this.iMPOZITDataGridViewTextBoxColumn,
            this.vIRATCARDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.aNGAJATIBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(28, 146);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1443, 222);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // nRCRTDataGridViewTextBoxColumn
            // 
            this.nRCRTDataGridViewTextBoxColumn.DataPropertyName = "NRCRT";
            this.nRCRTDataGridViewTextBoxColumn.HeaderText = "NRCRT";
            this.nRCRTDataGridViewTextBoxColumn.Name = "nRCRTDataGridViewTextBoxColumn";
            // 
            // nUMEDataGridViewTextBoxColumn
            // 
            this.nUMEDataGridViewTextBoxColumn.DataPropertyName = "NUME";
            this.nUMEDataGridViewTextBoxColumn.HeaderText = "NUME";
            this.nUMEDataGridViewTextBoxColumn.Name = "nUMEDataGridViewTextBoxColumn";
            // 
            // pRENUMEDataGridViewTextBoxColumn
            // 
            this.pRENUMEDataGridViewTextBoxColumn.DataPropertyName = "PRENUME";
            this.pRENUMEDataGridViewTextBoxColumn.HeaderText = "PRENUME";
            this.pRENUMEDataGridViewTextBoxColumn.Name = "pRENUMEDataGridViewTextBoxColumn";
            // 
            // fUNCTIEDataGridViewTextBoxColumn
            // 
            this.fUNCTIEDataGridViewTextBoxColumn.DataPropertyName = "FUNCTIE";
            this.fUNCTIEDataGridViewTextBoxColumn.HeaderText = "FUNCTIE";
            this.fUNCTIEDataGridViewTextBoxColumn.Name = "fUNCTIEDataGridViewTextBoxColumn";
            // 
            // sALARBAZADataGridViewTextBoxColumn
            // 
            this.sALARBAZADataGridViewTextBoxColumn.DataPropertyName = "SALAR_BAZA";
            this.sALARBAZADataGridViewTextBoxColumn.HeaderText = "SALAR_BAZA";
            this.sALARBAZADataGridViewTextBoxColumn.Name = "sALARBAZADataGridViewTextBoxColumn";
            // 
            // sPORPROCDataGridViewTextBoxColumn
            // 
            this.sPORPROCDataGridViewTextBoxColumn.DataPropertyName = "SPOR_PROC";
            this.sPORPROCDataGridViewTextBoxColumn.HeaderText = "SPOR_PROC";
            this.sPORPROCDataGridViewTextBoxColumn.Name = "sPORPROCDataGridViewTextBoxColumn";
            // 
            // pREMIIBRUTEDataGridViewTextBoxColumn
            // 
            this.pREMIIBRUTEDataGridViewTextBoxColumn.DataPropertyName = "PREMII_BRUTE";
            this.pREMIIBRUTEDataGridViewTextBoxColumn.HeaderText = "PREMII_BRUTE";
            this.pREMIIBRUTEDataGridViewTextBoxColumn.Name = "pREMIIBRUTEDataGridViewTextBoxColumn";
            // 
            // rETINERIDataGridViewTextBoxColumn
            // 
            this.rETINERIDataGridViewTextBoxColumn.DataPropertyName = "RETINERI";
            this.rETINERIDataGridViewTextBoxColumn.HeaderText = "RETINERI";
            this.rETINERIDataGridViewTextBoxColumn.Name = "rETINERIDataGridViewTextBoxColumn";
            // 
            // tOTALBRUTDataGridViewTextBoxColumn
            // 
            this.tOTALBRUTDataGridViewTextBoxColumn.DataPropertyName = "TOTAL_BRUT";
            this.tOTALBRUTDataGridViewTextBoxColumn.HeaderText = "TOTAL_BRUT";
            this.tOTALBRUTDataGridViewTextBoxColumn.Name = "tOTALBRUTDataGridViewTextBoxColumn";
            // 
            // cASDataGridViewTextBoxColumn
            // 
            this.cASDataGridViewTextBoxColumn.DataPropertyName = "CAS";
            this.cASDataGridViewTextBoxColumn.HeaderText = "CAS";
            this.cASDataGridViewTextBoxColumn.Name = "cASDataGridViewTextBoxColumn";
            // 
            // cASSDataGridViewTextBoxColumn
            // 
            this.cASSDataGridViewTextBoxColumn.DataPropertyName = "CASS";
            this.cASSDataGridViewTextBoxColumn.HeaderText = "CASS";
            this.cASSDataGridViewTextBoxColumn.Name = "cASSDataGridViewTextBoxColumn";
            // 
            // bRUTIMPOZABILDataGridViewTextBoxColumn
            // 
            this.bRUTIMPOZABILDataGridViewTextBoxColumn.DataPropertyName = "BRUT_IMPOZABIL";
            this.bRUTIMPOZABILDataGridViewTextBoxColumn.HeaderText = "BRUT_IMPOZABIL";
            this.bRUTIMPOZABILDataGridViewTextBoxColumn.Name = "bRUTIMPOZABILDataGridViewTextBoxColumn";
            // 
            // iMPOZITDataGridViewTextBoxColumn
            // 
            this.iMPOZITDataGridViewTextBoxColumn.DataPropertyName = "IMPOZIT";
            this.iMPOZITDataGridViewTextBoxColumn.HeaderText = "IMPOZIT";
            this.iMPOZITDataGridViewTextBoxColumn.Name = "iMPOZITDataGridViewTextBoxColumn";
            // 
            // vIRATCARDDataGridViewTextBoxColumn
            // 
            this.vIRATCARDDataGridViewTextBoxColumn.DataPropertyName = "VIRAT_CARD";
            this.vIRATCARDDataGridViewTextBoxColumn.HeaderText = "VIRAT_CARD";
            this.vIRATCARDDataGridViewTextBoxColumn.Name = "vIRATCARDDataGridViewTextBoxColumn";
            // 
            // aNGAJATIBindingSource1
            // 
            this.aNGAJATIBindingSource1.DataMember = "ANGAJATI";
            this.aNGAJATIBindingSource1.DataSource = this.dataSet1BindingSource;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aNGAJATIBindingSource
            // 
            this.aNGAJATIBindingSource.DataMember = "ANGAJATI";
            this.aNGAJATIBindingSource.DataSource = this.dataSet1BindingSource;
            // 
            // aNGAJATITableAdapter
            // 
            this.aNGAJATITableAdapter.ClearBeforeFill = true;
            // 
            // pROCENTAJEBindingSource1
            // 
            this.pROCENTAJEBindingSource1.DataMember = "PROCENTAJE";
            this.pROCENTAJEBindingSource1.DataSource = this.dataSet1BindingSource;
            // 
            // pROCENTAJEBindingSource
            // 
            this.pROCENTAJEBindingSource.DataMember = "PROCENTAJE";
            this.pROCENTAJEBindingSource.DataSource = this.dataSet1BindingSource;
            // 
            // pROCENTAJETableAdapter
            // 
            this.pROCENTAJETableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(929, 433);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(542, 51);
            this.button1.TabIndex = 2;
            this.button1.Text = "AdaugareAngajat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSchimbaParola
            // 
            this.btnSchimbaParola.Location = new System.Drawing.Point(28, 433);
            this.btnSchimbaParola.Name = "btnSchimbaParola";
            this.btnSchimbaParola.Size = new System.Drawing.Size(542, 51);
            this.btnSchimbaParola.TabIndex = 3;
            this.btnSchimbaParola.Text = "Schimba parola";
            this.btnSchimbaParola.UseVisualStyleBackColor = true;
            this.btnSchimbaParola.Click += new System.EventHandler(this.btnSchimbaParola_Click);
            // 
            // btnModificaProcente
            // 
            this.btnModificaProcente.Location = new System.Drawing.Point(28, 507);
            this.btnModificaProcente.Name = "btnModificaProcente";
            this.btnModificaProcente.Size = new System.Drawing.Size(542, 51);
            this.btnModificaProcente.TabIndex = 4;
            this.btnModificaProcente.Text = "Modifcare procente";
            this.btnModificaProcente.UseVisualStyleBackColor = true;
            this.btnModificaProcente.Click += new System.EventHandler(this.btnModificaProcente_Click);
            // 
            // btnActualizare
            // 
            this.btnActualizare.Location = new System.Drawing.Point(929, 507);
            this.btnActualizare.Name = "btnActualizare";
            this.btnActualizare.Size = new System.Drawing.Size(542, 51);
            this.btnActualizare.TabIndex = 5;
            this.btnActualizare.Text = "Actualizare date";
            this.btnActualizare.UseVisualStyleBackColor = true;
            this.btnActualizare.Click += new System.EventHandler(this.btnActualizare_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(28, 593);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(542, 51);
            this.button3.TabIndex = 7;
            this.button3.Text = "Stergere";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtCautare
            // 
            this.txtCautare.Location = new System.Drawing.Point(929, 609);
            this.txtCautare.Name = "txtCautare";
            this.txtCautare.Size = new System.Drawing.Size(542, 20);
            this.txtCautare.TabIndex = 8;
            this.txtCautare.TextChanged += new System.EventHandler(this.txtCautare_TextChanged);
            // 
            // lblRezultat
            // 
            this.lblRezultat.AutoSize = true;
            this.lblRezultat.Location = new System.Drawing.Point(926, 674);
            this.lblRezultat.Name = "lblRezultat";
            this.lblRezultat.Size = new System.Drawing.Size(0, 13);
            this.lblRezultat.TabIndex = 9;
            // 
            // panelShortcuts
            // 
            this.panelShortcuts.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panelShortcuts.Controls.Add(this.btnIesire);
            this.panelShortcuts.Controls.Add(this.btnAjutor);
            this.panelShortcuts.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShortcuts.Location = new System.Drawing.Point(0, 0);
            this.panelShortcuts.Name = "panelShortcuts";
            this.panelShortcuts.Size = new System.Drawing.Size(2293, 100);
            this.panelShortcuts.TabIndex = 11;
            // 
            // btnAjutor
            // 
            this.btnAjutor.Location = new System.Drawing.Point(380, 15);
            this.btnAjutor.Name = "btnAjutor";
            this.btnAjutor.Size = new System.Drawing.Size(174, 58);
            this.btnAjutor.TabIndex = 2;
            this.btnAjutor.Text = "Ajutor";
            this.btnAjutor.UseVisualStyleBackColor = true;
            this.btnAjutor.Click += new System.EventHandler(this.btnAjutor_Click);
            // 
            // btnIesire
            // 
            this.btnIesire.Location = new System.Drawing.Point(913, 15);
            this.btnIesire.Name = "btnIesire";
            this.btnIesire.Size = new System.Drawing.Size(174, 58);
            this.btnIesire.TabIndex = 3;
            this.btnIesire.Text = "Iesire";
            this.btnIesire.UseVisualStyleBackColor = true;
            this.btnIesire.Click += new System.EventHandler(this.btnIesire_Click);
            // 
            // picPoza
            // 
            this.picPoza.Location = new System.Drawing.Point(1574, 169);
            this.picPoza.Name = "picPoza";
            this.picPoza.Size = new System.Drawing.Size(700, 600);
            this.picPoza.TabIndex = 12;
            this.picPoza.TabStop = false;
            this.picPoza.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2293, 1057);
            this.Controls.Add(this.picPoza);
            this.Controls.Add(this.panelShortcuts);
            this.Controls.Add(this.lblRezultat);
            this.Controls.Add(this.txtCautare);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnActualizare);
            this.Controls.Add(this.btnModificaProcente);
            this.Controls.Add(this.btnSchimbaParola);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aNGAJATIBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aNGAJATIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROCENTAJEBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROCENTAJEBindingSource)).EndInit();
            this.panelShortcuts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPoza)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource aNGAJATIBindingSource;
        private DataSet1TableAdapters.ANGAJATITableAdapter aNGAJATITableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nRCRTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nUMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRENUMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fUNCTIEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sALARBAZADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sPORPROCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pREMIIBRUTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rETINERIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tOTALBRUTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cASDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cASSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bRUTIMPOZABILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iMPOZITDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vIRATCARDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource aNGAJATIBindingSource1;
        private System.Windows.Forms.BindingSource pROCENTAJEBindingSource;
        private DataSet1TableAdapters.PROCENTAJETableAdapter pROCENTAJETableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource pROCENTAJEBindingSource1;
        private System.Windows.Forms.Button btnSchimbaParola;
        private System.Windows.Forms.Button btnModificaProcente;
        private System.Windows.Forms.Button btnActualizare;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtCautare;
        private System.Windows.Forms.Label lblRezultat;
        private System.Windows.Forms.Panel panelShortcuts;
        private System.Windows.Forms.Button btnIesire;
        private System.Windows.Forms.Button btnAjutor;
        private System.Windows.Forms.PictureBox picPoza;
    }
}

