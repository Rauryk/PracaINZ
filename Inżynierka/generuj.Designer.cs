namespace Inżynierka
{
    partial class generuj
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
            this.ilosc_egzaminow = new System.Windows.Forms.TextBox();
            this.ilosc_otwartych = new System.Windows.Forms.TextBox();
            this.matura = new System.Windows.Forms.CheckBox();
            this.klasa = new System.Windows.Forms.ComboBox();
            this.rozdzial = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.podklasa = new System.Windows.Forms.ComboBox();
            this.ilosc_zamnietych = new System.Windows.Forms.TextBox();
            this.listazadań = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.listazadań)).BeginInit();
            this.SuspendLayout();
            // 
            // ilosc_egzaminow
            // 
            this.ilosc_egzaminow.Location = new System.Drawing.Point(103, 16);
            this.ilosc_egzaminow.Name = "ilosc_egzaminow";
            this.ilosc_egzaminow.Size = new System.Drawing.Size(100, 20);
            this.ilosc_egzaminow.TabIndex = 0;
            // 
            // ilosc_otwartych
            // 
            this.ilosc_otwartych.Location = new System.Drawing.Point(103, 79);
            this.ilosc_otwartych.Name = "ilosc_otwartych";
            this.ilosc_otwartych.Size = new System.Drawing.Size(100, 20);
            this.ilosc_otwartych.TabIndex = 2;
            this.ilosc_otwartych.Text = "0";
            // 
            // matura
            // 
            this.matura.AutoSize = true;
            this.matura.Location = new System.Drawing.Point(103, 389);
            this.matura.Name = "matura";
            this.matura.Size = new System.Drawing.Size(59, 17);
            this.matura.TabIndex = 4;
            this.matura.Text = "Matura";
            this.matura.UseVisualStyleBackColor = true;
            this.matura.CheckedChanged += new System.EventHandler(this.matura_CheckedChanged);
            // 
            // klasa
            // 
            this.klasa.FormattingEnabled = true;
            this.klasa.Location = new System.Drawing.Point(103, 156);
            this.klasa.Name = "klasa";
            this.klasa.Size = new System.Drawing.Size(121, 21);
            this.klasa.TabIndex = 5;
            // 
            // rozdzial
            // 
            this.rozdzial.FormattingEnabled = true;
            this.rozdzial.Location = new System.Drawing.Point(103, 231);
            this.rozdzial.Name = "rozdzial";
            this.rozdzial.Size = new System.Drawing.Size(121, 21);
            this.rozdzial.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(649, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Generuj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ilość egzaminów";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Klasa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Rozdział";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 26);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ilość zadań \r\notwartych ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(391, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 26);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ilość zadań\r\nzamkniętych \r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Pod klasa";
            // 
            // podklasa
            // 
            this.podklasa.FormattingEnabled = true;
            this.podklasa.Location = new System.Drawing.Point(352, 156);
            this.podklasa.Name = "podklasa";
            this.podklasa.Size = new System.Drawing.Size(121, 21);
            this.podklasa.TabIndex = 15;
            // 
            // ilosc_zamnietych
            // 
            this.ilosc_zamnietych.Location = new System.Drawing.Point(498, 79);
            this.ilosc_zamnietych.Name = "ilosc_zamnietych";
            this.ilosc_zamnietych.Size = new System.Drawing.Size(100, 20);
            this.ilosc_zamnietych.TabIndex = 3;
            this.ilosc_zamnietych.Text = "0";
            // 
            // listazadań
            // 
            this.listazadań.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listazadań.Location = new System.Drawing.Point(358, 230);
            this.listazadań.Name = "listazadań";
            this.listazadań.Size = new System.Drawing.Size(430, 150);
            this.listazadań.TabIndex = 16;
            // 
            // generuj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listazadań);
            this.Controls.Add(this.podklasa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rozdzial);
            this.Controls.Add(this.klasa);
            this.Controls.Add(this.matura);
            this.Controls.Add(this.ilosc_zamnietych);
            this.Controls.Add(this.ilosc_otwartych);
            this.Controls.Add(this.ilosc_egzaminow);
            this.Name = "generuj";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.listazadań)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ilosc_egzaminow;
        private System.Windows.Forms.TextBox ilosc_otwartych;
        private System.Windows.Forms.CheckBox matura;
        private System.Windows.Forms.ComboBox klasa;
        private System.Windows.Forms.ComboBox rozdzial;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox podklasa;
        private System.Windows.Forms.TextBox ilosc_zamnietych;
        private System.Windows.Forms.DataGridView listazadań;
    }
}