using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Inżynierka
{
    public partial class zadanie : Form
    {
        string conneconnectionString = @"Data Source=PC;Initial Catalog=inzynierka;Integrated Security=True;";
        public zadanie()
        {
            InitializeComponent();
            LadujRozdzialy();
        }

       void LadujRozdzialy()
        {
            using (SqlDataAdapter sda = new SqlDataAdapter("SELECT id, nazwa FROM Rozdzial", conneconnectionString))
            {
                DataTable dt = new DataTable();
                sda.Fill(dt);
                DataRow row = dt.NewRow();
                row[0] = 0;
                row[1] = "wybierz rozdział";
                dt.Rows.InsertAt(row, 0);
                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "nazwa";
                comboBox1.ValueMember = "id";
            }
            using (SqlDataAdapter sda = new SqlDataAdapter("SELECT id FROM klasa", conneconnectionString))
            {
                DataTable dt = new DataTable();
                sda.Fill(dt);
                DataRow row = dt.NewRow();
                comboBox2.DataSource = dt;
                comboBox2.DisplayMember = "id";
                comboBox2.ValueMember = "id";
            }

        }

        

        private void dodaj_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(conneconnectionString))
            {
                sqlcon.Open();
                SqlDataAdapter sqlda = new SqlDataAdapter("select id from zadania ", sqlcon);
                DataTable dbta = new DataTable();
                sqlda.Fill(dbta);
                int id =dbta.Rows.Count+1;
                int rodzajzadania, maturalne;
                if (typ_zadania.Checked == true) rodzajzadania = 2;
                else rodzajzadania = 1;
                if (czyMatura.Checked == true) maturalne = 1;
                else maturalne = 2;
                SqlCommand sqlCommand = new SqlCommand(@"insert into zadania(id,OpisZadania,Klasa,Rozdzial,rodzajzadania,Maturalne) values('" + id+"','" + tresc_zdania.Text + "','" +(int)(comboBox2.SelectedIndex+1) + "','" + comboBox1.SelectedIndex + "','" +rodzajzadania  + "','"+maturalne+"')");
                //sqlcon.Open();
                 sqlCommand.Connection = sqlcon;
                sqlCommand.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show("zadanie zostało dodane");


            }
        }

        
    }
    
}
