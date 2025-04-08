namespace Proiect
{
    partial class AdaugareAngajat
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
            this.txtNume = new System.Windows.Forms.TextBox();
            this.txtPrenume = new System.Windows.Forms.TextBox();
            this.txtFunctie = new System.Windows.Forms.TextBox();
            this.txtRetineri = new System.Windows.Forms.TextBox();
            this.txtSporProc = new System.Windows.Forms.TextBox();
            this.txtSalarBaza = new System.Windows.Forms.TextBox();
            this.txtPremiiBrute = new System.Windows.Forms.TextBox();
            this.btnSalveaza = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.anulare = new System.Windows.Forms.Button();
            this.picAngajat = new System.Windows.Forms.PictureBox();
            this.btnIncarcaPoza = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picAngajat)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(160, 63);
            this.txtNume.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(196, 31);
            this.txtNume.TabIndex = 0;
            // 
            // txtPrenume
            // 
            this.txtPrenume.Location = new System.Drawing.Point(160, 142);
            this.txtPrenume.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtPrenume.Name = "txtPrenume";
            this.txtPrenume.Size = new System.Drawing.Size(196, 31);
            this.txtPrenume.TabIndex = 1;
            // 
            // txtFunctie
            // 
            this.txtFunctie.Location = new System.Drawing.Point(160, 225);
            this.txtFunctie.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtFunctie.Name = "txtFunctie";
            this.txtFunctie.Size = new System.Drawing.Size(196, 31);
            this.txtFunctie.TabIndex = 2;
            // 
            // txtRetineri
            // 
            this.txtRetineri.Location = new System.Drawing.Point(358, 304);
            this.txtRetineri.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtRetineri.Name = "txtRetineri";
            this.txtRetineri.Size = new System.Drawing.Size(196, 31);
            this.txtRetineri.TabIndex = 3;
            this.txtRetineri.Text = "0";
            this.txtRetineri.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtSporProc
            // 
            this.txtSporProc.Location = new System.Drawing.Point(566, 142);
            this.txtSporProc.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtSporProc.Name = "txtSporProc";
            this.txtSporProc.Size = new System.Drawing.Size(196, 31);
            this.txtSporProc.TabIndex = 4;
            this.txtSporProc.Text = "0";
            // 
            // txtSalarBaza
            // 
            this.txtSalarBaza.Location = new System.Drawing.Point(566, 63);
            this.txtSalarBaza.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtSalarBaza.Name = "txtSalarBaza";
            this.txtSalarBaza.Size = new System.Drawing.Size(196, 31);
            this.txtSalarBaza.TabIndex = 5;
            // 
            // txtPremiiBrute
            // 
            this.txtPremiiBrute.Location = new System.Drawing.Point(566, 225);
            this.txtPremiiBrute.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtPremiiBrute.Name = "txtPremiiBrute";
            this.txtPremiiBrute.Size = new System.Drawing.Size(196, 31);
            this.txtPremiiBrute.TabIndex = 6;
            this.txtPremiiBrute.Text = "0";
            this.txtPremiiBrute.TextChanged += new System.EventHandler(this.txtPremiiBrute_TextChanged);
            // 
            // btnSalveaza
            // 
            this.btnSalveaza.Location = new System.Drawing.Point(272, 396);
            this.btnSalveaza.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSalveaza.Name = "btnSalveaza";
            this.btnSalveaza.Size = new System.Drawing.Size(150, 44);
            this.btnSalveaza.TabIndex = 7;
            this.btnSalveaza.Text = "Salveaza";
            this.btnSalveaza.UseVisualStyleBackColor = true;
            this.btnSalveaza.Click += new System.EventHandler(this.btnSalveaza_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nume";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 148);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Prenume";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 231);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Functie";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(432, 69);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Salariu Brut";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(397, 148);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Spor(procentaj)";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(428, 231);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Premii Brute";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(276, 310);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Retineri";
            // 
            // anulare
            // 
            this.anulare.Location = new System.Drawing.Point(502, 396);
            this.anulare.Name = "anulare";
            this.anulare.Size = new System.Drawing.Size(170, 44);
            this.anulare.TabIndex = 15;
            this.anulare.Text = "Anuleaza";
            this.anulare.UseVisualStyleBackColor = true;
            this.anulare.Click += new System.EventHandler(this.anulare_Click);
            // 
            // picAngajat
            // 
            this.picAngajat.Location = new System.Drawing.Point(872, 63);
            this.picAngajat.Name = "picAngajat";
            this.picAngajat.Size = new System.Drawing.Size(305, 214);
            this.picAngajat.TabIndex = 16;
            this.picAngajat.TabStop = false;
            this.picAngajat.Click += new System.EventHandler(this.picAngajat_Click);
            // 
            // btnIncarcaPoza
            // 
            this.btnIncarcaPoza.Location = new System.Drawing.Point(933, 322);
            this.btnIncarcaPoza.Name = "btnIncarcaPoza";
            this.btnIncarcaPoza.Size = new System.Drawing.Size(170, 44);
            this.btnIncarcaPoza.TabIndex = 17;
            this.btnIncarcaPoza.Text = "Adauga poza";
            this.btnIncarcaPoza.UseVisualStyleBackColor = true;
            this.btnIncarcaPoza.Click += new System.EventHandler(this.btnIncarcaPoza_Click);
            // 
            // AdaugareAngajat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.btnIncarcaPoza);
            this.Controls.Add(this.picAngajat);
            this.Controls.Add(this.anulare);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalveaza);
            this.Controls.Add(this.txtPremiiBrute);
            this.Controls.Add(this.txtSalarBaza);
            this.Controls.Add(this.txtSporProc);
            this.Controls.Add(this.txtRetineri);
            this.Controls.Add(this.txtFunctie);
            this.Controls.Add(this.txtPrenume);
            this.Controls.Add(this.txtNume);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "AdaugareAngajat";
            this.Text = "AdaugareAngajat";
            ((System.ComponentModel.ISupportInitialize)(this.picAngajat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.TextBox txtPrenume;
        private System.Windows.Forms.TextBox txtFunctie;
        private System.Windows.Forms.TextBox txtRetineri;
        private System.Windows.Forms.TextBox txtSporProc;
        private System.Windows.Forms.TextBox txtSalarBaza;
        private System.Windows.Forms.TextBox txtPremiiBrute;
        private System.Windows.Forms.Button btnSalveaza;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button anulare;
        private System.Windows.Forms.PictureBox picAngajat;
        private System.Windows.Forms.Button btnIncarcaPoza;
    }
}