
namespace binding2
{
    partial class Form2
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
            this.cmbCantanti = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstCanzoni = new System.Windows.Forms.ListBox();
            this.txtNazionalita = new System.Windows.Forms.TextBox();
            this.txtAnno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbCantanti
            // 
            this.cmbCantanti.FormattingEnabled = true;
            this.cmbCantanti.Location = new System.Drawing.Point(85, 86);
            this.cmbCantanti.Name = "cmbCantanti";
            this.cmbCantanti.Size = new System.Drawing.Size(121, 24);
            this.cmbCantanti.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cantanti";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nazionalità";
            // 
            // lstCanzoni
            // 
            this.lstCanzoni.FormattingEnabled = true;
            this.lstCanzoni.ItemHeight = 16;
            this.lstCanzoni.Location = new System.Drawing.Point(379, 41);
            this.lstCanzoni.Name = "lstCanzoni";
            this.lstCanzoni.Size = new System.Drawing.Size(392, 244);
            this.lstCanzoni.TabIndex = 3;
            // 
            // txtNazionalita
            // 
            this.txtNazionalita.Location = new System.Drawing.Point(88, 205);
            this.txtNazionalita.Name = "txtNazionalita";
            this.txtNazionalita.Size = new System.Drawing.Size(118, 22);
            this.txtNazionalita.TabIndex = 4;
            // 
            // txtAnno
            // 
            this.txtAnno.Location = new System.Drawing.Point(85, 328);
            this.txtAnno.Name = "txtAnno";
            this.txtAnno.Size = new System.Drawing.Size(118, 22);
            this.txtAnno.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Anno di produzione";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtAnno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNazionalita);
            this.Controls.Add(this.lstCanzoni);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCantanti);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCantanti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstCanzoni;
        private System.Windows.Forms.TextBox txtNazionalita;
        private System.Windows.Forms.TextBox txtAnno;
        private System.Windows.Forms.Label label3;
    }
}