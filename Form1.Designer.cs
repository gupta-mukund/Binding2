
namespace binding2
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNomeStudente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeStudenteBind = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.cmbNazionalita = new System.Windows.Forms.TextBox();
            this.cmbNickName = new System.Windows.Forms.TextBox();
            this.cmbGenere = new System.Windows.Forms.ComboBox();
            this.cmbCantante = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtJson = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNomeStudente
            // 
            this.txtNomeStudente.Location = new System.Drawing.Point(163, 390);
            this.txtNomeStudente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNomeStudente.Name = "txtNomeStudente";
            this.txtNomeStudente.Size = new System.Drawing.Size(219, 22);
            this.txtNomeStudente.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 412);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome Studente";
            // 
            // txtNomeStudenteBind
            // 
            this.txtNomeStudenteBind.Location = new System.Drawing.Point(163, 422);
            this.txtNomeStudenteBind.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNomeStudenteBind.Name = "txtNomeStudenteBind";
            this.txtNomeStudenteBind.Size = new System.Drawing.Size(219, 22);
            this.txtNomeStudenteBind.TabIndex = 2;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(163, 116);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(219, 22);
            this.txtNome.TabIndex = 3;
            // 
            // cmbNazionalita
            // 
            this.cmbNazionalita.Location = new System.Drawing.Point(163, 306);
            this.cmbNazionalita.Margin = new System.Windows.Forms.Padding(4);
            this.cmbNazionalita.Name = "cmbNazionalita";
            this.cmbNazionalita.Size = new System.Drawing.Size(219, 22);
            this.cmbNazionalita.TabIndex = 4;
            // 
            // cmbNickName
            // 
            this.cmbNickName.Location = new System.Drawing.Point(163, 233);
            this.cmbNickName.Margin = new System.Windows.Forms.Padding(4);
            this.cmbNickName.Name = "cmbNickName";
            this.cmbNickName.Size = new System.Drawing.Size(219, 22);
            this.cmbNickName.TabIndex = 5;
            // 
            // cmbGenere
            // 
            this.cmbGenere.FormattingEnabled = true;
            this.cmbGenere.Location = new System.Drawing.Point(163, 55);
            this.cmbGenere.Name = "cmbGenere";
            this.cmbGenere.Size = new System.Drawing.Size(219, 24);
            this.cmbGenere.TabIndex = 6;
            // 
            // cmbCantante
            // 
            this.cmbCantante.FormattingEnabled = true;
            this.cmbCantante.Location = new System.Drawing.Point(163, 169);
            this.cmbCantante.Name = "cmbCantante";
            this.cmbCantante.Size = new System.Drawing.Size(219, 24);
            this.cmbCantante.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 238);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Pseudonimo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 176);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Cantanti";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 121);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nome\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 62);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Genere Musicale";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 311);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Nazionalità";
            // 
            // txtJson
            // 
            this.txtJson.Location = new System.Drawing.Point(506, 37);
            this.txtJson.Multiline = true;
            this.txtJson.Name = "txtJson";
            this.txtJson.Size = new System.Drawing.Size(513, 476);
            this.txtJson.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(163, 489);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Next Form =>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtJson);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbCantante);
            this.Controls.Add(this.cmbGenere);
            this.Controls.Add(this.cmbNickName);
            this.Controls.Add(this.cmbNazionalita);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtNomeStudenteBind);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomeStudente);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomeStudente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeStudenteBind;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox cmbNazionalita;
        private System.Windows.Forms.TextBox cmbNickName;
        private System.Windows.Forms.ComboBox cmbGenere;
        private System.Windows.Forms.ComboBox cmbCantante;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtJson;
        private System.Windows.Forms.Button button1;
    }
}

