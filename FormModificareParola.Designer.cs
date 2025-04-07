namespace Proiect
{
    partial class FormModificareParola
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
            this.txtParolaVeche = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtParolaNoua = new System.Windows.Forms.TextBox();
            this.txtConfirmare = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSchimbaParola = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtParolaVeche
            // 
            this.txtParolaVeche.Location = new System.Drawing.Point(45, 12);
            this.txtParolaVeche.Name = "txtParolaVeche";
            this.txtParolaVeche.Size = new System.Drawing.Size(136, 31);
            this.txtParolaVeche.TabIndex = 0;
            this.txtParolaVeche.UseSystemPasswordChar = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtParolaNoua
            // 
            this.txtParolaNoua.Location = new System.Drawing.Point(45, 67);
            this.txtParolaNoua.Name = "txtParolaNoua";
            this.txtParolaNoua.Size = new System.Drawing.Size(136, 31);
            this.txtParolaNoua.TabIndex = 2;
            this.txtParolaNoua.UseSystemPasswordChar = true;
            // 
            // txtConfirmare
            // 
            this.txtConfirmare.Location = new System.Drawing.Point(45, 125);
            this.txtConfirmare.Name = "txtConfirmare";
            this.txtConfirmare.Size = new System.Drawing.Size(136, 31);
            this.txtConfirmare.TabIndex = 3;
            this.txtConfirmare.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Parola veche";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Parola noua";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(198, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Confirmare parola noua";
            // 
            // btnSchimbaParola
            // 
            this.btnSchimbaParola.Location = new System.Drawing.Point(56, 180);
            this.btnSchimbaParola.Name = "btnSchimbaParola";
            this.btnSchimbaParola.Size = new System.Drawing.Size(125, 38);
            this.btnSchimbaParola.TabIndex = 7;
            this.btnSchimbaParola.Text = "Salveaza";
            this.btnSchimbaParola.UseVisualStyleBackColor = true;
            this.btnSchimbaParola.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(260, 180);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(113, 38);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Anulare";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormModificareParola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 230);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSchimbaParola);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtConfirmare);
            this.Controls.Add(this.txtParolaNoua);
            this.Controls.Add(this.txtParolaVeche);
            this.Name = "FormModificareParola";
            this.Text = "FormModificareParola";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtParolaVeche;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtParolaNoua;
        private System.Windows.Forms.TextBox txtConfirmare;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSchimbaParola;
        private System.Windows.Forms.Button btnCancel;
    }
}