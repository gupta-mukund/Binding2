
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
            this.SuspendLayout();
            // 
            // txtNomeStudente
            // 
            this.txtNomeStudente.Location = new System.Drawing.Point(173, 335);
            this.txtNomeStudente.Name = "txtNomeStudente";
            this.txtNomeStudente.Size = new System.Drawing.Size(100, 20);
            this.txtNomeStudente.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome Studente";
            // 
            // txtNomeStudenteBind
            // 
            this.txtNomeStudenteBind.Location = new System.Drawing.Point(173, 361);
            this.txtNomeStudenteBind.Name = "txtNomeStudenteBind";
            this.txtNomeStudenteBind.Size = new System.Drawing.Size(100, 20);
            this.txtNomeStudenteBind.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNomeStudenteBind);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomeStudente);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomeStudente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeStudenteBind;
    }
}

