namespace Proiect
{
    partial class FormStergereAngajat
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
            this.txtNume = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtPrenume = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCautare = new System.Windows.Forms.Button();
            this.lblDetalii = new System.Windows.Forms.GroupBox();
            this.btnStergere = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(225, 47);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(325, 20);
            this.txtNume.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtPrenume
            // 
            this.txtPrenume.Location = new System.Drawing.Point(225, 101);
            this.txtPrenume.Name = "txtPrenume";
            this.txtPrenume.Size = new System.Drawing.Size(325, 20);
            this.txtPrenume.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nume";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Prenume";
            // 
            // btnCautare
            // 
            this.btnCautare.Location = new System.Drawing.Point(12, 182);
            this.btnCautare.Name = "btnCautare";
            this.btnCautare.Size = new System.Drawing.Size(325, 41);
            this.btnCautare.TabIndex = 5;
            this.btnCautare.Text = "Cauta";
            this.btnCautare.UseVisualStyleBackColor = true;
            this.btnCautare.Click += new System.EventHandler(this.btnCautare_Click);
            // 
            // lblDetalii
            // 
            this.lblDetalii.Location = new System.Drawing.Point(360, 167);
            this.lblDetalii.Name = "lblDetalii";
            this.lblDetalii.Size = new System.Drawing.Size(428, 243);
            this.lblDetalii.TabIndex = 6;
            this.lblDetalii.TabStop = false;
            this.lblDetalii.Text = "Detalii angajat";
            // 
            // btnStergere
            // 
            this.btnStergere.Location = new System.Drawing.Point(12, 251);
            this.btnStergere.Name = "btnStergere";
            this.btnStergere.Size = new System.Drawing.Size(325, 41);
            this.btnStergere.TabIndex = 7;
            this.btnStergere.Text = "Sterge";
            this.btnStergere.UseVisualStyleBackColor = true;
            this.btnStergere.Click += new System.EventHandler(this.btnStergere_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(12, 318);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(325, 41);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Anulare";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormStergereAngajat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnStergere);
            this.Controls.Add(this.lblDetalii);
            this.Controls.Add(this.btnCautare);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrenume);
            this.Controls.Add(this.txtNume);
            this.Name = "FormStergereAngajat";
            this.Text = "FormStergereAngajat";
            this.Load += new System.EventHandler(this.FormStergereAngajat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtPrenume;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCautare;
        private System.Windows.Forms.GroupBox lblDetalii;
        private System.Windows.Forms.Button btnStergere;
        private System.Windows.Forms.Button btnCancel;
    }
}