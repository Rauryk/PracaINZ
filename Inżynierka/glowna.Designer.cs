namespace Inżynierka
{
    partial class glowna
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.email = new System.Windows.Forms.TextBox();
            this.poloczenie = new System.Windows.Forms.Button();
            this.dodaj = new System.Windows.Forms.Button();
            this.generuj = new System.Windows.Forms.Button();
            this.usunzmien = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(548, 288);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(80, 23);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(100, 20);
            this.email.TabIndex = 1;
            // 
            // poloczenie
            // 
            this.poloczenie.Location = new System.Drawing.Point(80, 80);
            this.poloczenie.Name = "poloczenie";
            this.poloczenie.Size = new System.Drawing.Size(180, 41);
            this.poloczenie.TabIndex = 2;
            this.poloczenie.Text = "Sprawdz połączenie z bazą";
            this.poloczenie.UseVisualStyleBackColor = true;
            // 
            // dodaj
            // 
            this.dodaj.Location = new System.Drawing.Point(80, 140);
            this.dodaj.Name = "dodaj";
            this.dodaj.Size = new System.Drawing.Size(180, 41);
            this.dodaj.TabIndex = 3;
            this.dodaj.Text = "Dodaj zadanie";
            this.dodaj.UseVisualStyleBackColor = true;
            this.dodaj.Click += new System.EventHandler(this.dodaj_Click);
            // 
            // generuj
            // 
            this.generuj.Location = new System.Drawing.Point(80, 202);
            this.generuj.Name = "generuj";
            this.generuj.Size = new System.Drawing.Size(180, 41);
            this.generuj.TabIndex = 4;
            this.generuj.Text = "Generuj egzamin";
            this.generuj.UseVisualStyleBackColor = true;
            this.generuj.Click += new System.EventHandler(this.generuj_Click);
            // 
            // usunzmien
            // 
            this.usunzmien.Location = new System.Drawing.Point(80, 261);
            this.usunzmien.Name = "usunzmien";
            this.usunzmien.Size = new System.Drawing.Size(180, 41);
            this.usunzmien.TabIndex = 5;
            this.usunzmien.Text = "dodaj zmień usuń";
            this.usunzmien.UseVisualStyleBackColor = true;
            this.usunzmien.Click += new System.EventHandler(this.usunzmien_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "E-mail";
            // 
            // glowna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usunzmien);
            this.Controls.Add(this.generuj);
            this.Controls.Add(this.dodaj);
            this.Controls.Add(this.poloczenie);
            this.Controls.Add(this.email);
            this.Controls.Add(this.dataGridView1);
            this.Name = "glowna";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Button poloczenie;
        private System.Windows.Forms.Button dodaj;
        private System.Windows.Forms.Button generuj;
        private System.Windows.Forms.Button usunzmien;
        private System.Windows.Forms.Label label1;
    }
}

