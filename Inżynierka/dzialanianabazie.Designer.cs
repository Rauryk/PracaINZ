namespace Inżynierka
{
    partial class dzialanianabazie
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
            this.tablice = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.zapisz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tablice
            // 
            this.tablice.FormattingEnabled = true;
            this.tablice.Items.AddRange(new object[] {
            "klasa",
            "RodzajZad",
            "Rozdzial",
            "uczen"});
            this.tablice.Location = new System.Drawing.Point(12, 12);
            this.tablice.Name = "tablice";
            this.tablice.Size = new System.Drawing.Size(121, 21);
            this.tablice.TabIndex = 0;
            this.tablice.SelectedIndexChanged += new System.EventHandler(this.tablice_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(775, 367);
            this.dataGridView1.TabIndex = 1;
            // 
            // zapisz
            // 
            this.zapisz.Location = new System.Drawing.Point(633, 9);
            this.zapisz.Name = "zapisz";
            this.zapisz.Size = new System.Drawing.Size(101, 23);
            this.zapisz.TabIndex = 2;
            this.zapisz.Text = "zapisz zmiany";
            this.zapisz.UseVisualStyleBackColor = true;
            this.zapisz.Click += new System.EventHandler(this.zapisz_Click);
            // 
            // dzialanianabazie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.zapisz);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tablice);
            this.Name = "dzialanianabazie";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox tablice;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button zapisz;
    }
}