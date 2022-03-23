namespace Inżynierka
{
    partial class zadanie
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
            this.tresc_zdania = new System.Windows.Forms.RichTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.typ_zadania = new System.Windows.Forms.CheckBox();
            this.czyMatura = new System.Windows.Forms.CheckBox();
            this.dodaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tresc_zdania
            // 
            this.tresc_zdania.Location = new System.Drawing.Point(12, 12);
            this.tresc_zdania.Name = "tresc_zdania";
            this.tresc_zdania.Size = new System.Drawing.Size(642, 285);
            this.tresc_zdania.TabIndex = 1;
            this.tresc_zdania.Text = "";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(13, 315);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(641, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(13, 354);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 3;
           // 
            // typ_zadania
            // 
            this.typ_zadania.AutoSize = true;
            this.typ_zadania.Location = new System.Drawing.Point(13, 391);
            this.typ_zadania.Name = "typ_zadania";
            this.typ_zadania.Size = new System.Drawing.Size(101, 17);
            this.typ_zadania.TabIndex = 4;
            this.typ_zadania.Text = "zadanie otwartę";
            this.typ_zadania.UseVisualStyleBackColor = true;
            // 
            // czyMatura
            // 
            this.czyMatura.AutoSize = true;
            this.czyMatura.Checked = true;
            this.czyMatura.CheckState = System.Windows.Forms.CheckState.Checked;
            this.czyMatura.Location = new System.Drawing.Point(12, 415);
            this.czyMatura.Name = "czyMatura";
            this.czyMatura.Size = new System.Drawing.Size(112, 17);
            this.czyMatura.TabIndex = 5;
            this.czyMatura.Text = "zadanie maturalne";
            this.czyMatura.UseVisualStyleBackColor = true;
            // 
            // dodaj
            // 
            this.dodaj.Location = new System.Drawing.Point(689, 415);
            this.dodaj.Name = "dodaj";
            this.dodaj.Size = new System.Drawing.Size(99, 23);
            this.dodaj.TabIndex = 6;
            this.dodaj.Text = "dodaj zadanie";
            this.dodaj.UseVisualStyleBackColor = true;
            this.dodaj.Click += new System.EventHandler(this.dodaj_Click);
            // 
            // zadanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dodaj);
            this.Controls.Add(this.czyMatura);
            this.Controls.Add(this.typ_zadania);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tresc_zdania);
            this.Name = "zadanie";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox tresc_zdania;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.CheckBox typ_zadania;
        private System.Windows.Forms.CheckBox czyMatura;
        private System.Windows.Forms.Button dodaj;
    }
}