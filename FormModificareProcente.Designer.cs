namespace Proiect
{
    partial class FormModificareProcente
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCAS = new System.Windows.Forms.TextBox();
            this.txtCASS = new System.Windows.Forms.TextBox();
            this.txtImpozit = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSalveaza = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CAS (%)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CASS (%)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "IMPOZIT (%)";
            // 
            // txtCAS
            // 
            this.txtCAS.Location = new System.Drawing.Point(223, 53);
            this.txtCAS.Name = "txtCAS";
            this.txtCAS.Size = new System.Drawing.Size(100, 20);
            this.txtCAS.TabIndex = 3;
            // 
            // txtCASS
            // 
            this.txtCASS.Location = new System.Drawing.Point(223, 96);
            this.txtCASS.Name = "txtCASS";
            this.txtCASS.Size = new System.Drawing.Size(100, 20);
            this.txtCASS.TabIndex = 4;
            // 
            // txtImpozit
            // 
            this.txtImpozit.Location = new System.Drawing.Point(223, 148);
            this.txtImpozit.Name = "txtImpozit";
            this.txtImpozit.Size = new System.Drawing.Size(100, 20);
            this.txtImpozit.TabIndex = 5;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(12, 224);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(151, 53);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Anuleaza";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSalveaza
            // 
            this.btnSalveaza.Location = new System.Drawing.Point(213, 224);
            this.btnSalveaza.Name = "btnSalveaza";
            this.btnSalveaza.Size = new System.Drawing.Size(155, 53);
            this.btnSalveaza.TabIndex = 7;
            this.btnSalveaza.Text = "Salveaza";
            this.btnSalveaza.UseVisualStyleBackColor = true;
            this.btnSalveaza.Click += new System.EventHandler(this.btnSalveaza_Click);
            // 
            // FormModificareProcente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 324);
            this.Controls.Add(this.btnSalveaza);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtImpozit);
            this.Controls.Add(this.txtCASS);
            this.Controls.Add(this.txtCAS);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormModificareProcente";
            this.Text = "FormModificareProcente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCAS;
        private System.Windows.Forms.TextBox txtCASS;
        private System.Windows.Forms.TextBox txtImpozit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSalveaza;
    }
}