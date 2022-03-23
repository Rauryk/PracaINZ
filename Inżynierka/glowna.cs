using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;
using System.Configuration;
using System.Data.SqlClient;
namespace Inżynierka
{
    public partial class glowna : Form
    {
        public glowna()
        {
           
            string conneconnectionString = @"Data Source=PC;Initial Catalog=inzynierka;Integrated Security=True;";
            InitializeComponent();


            using (SqlConnection sqlcon = new SqlConnection(conneconnectionString)) 
            {
                sqlcon.Open();
                SqlDataAdapter sqlda = new SqlDataAdapter("select * from klasa", sqlcon);
                DataTable dbta = new DataTable();
                sqlda.Fill(dbta);
                dataGridView1.DataSource = dbta;
            }
        }

        private void dodaj_Click(object sender, EventArgs e)
        {
            zadanie form2 = new zadanie();
            form2.Show();
        }

        private void generuj_Click(object sender, EventArgs e)
        {
            generuj form2 = new generuj();
            form2.Show();
        }

        private void usunzmien_Click(object sender, EventArgs e)
        {
            dzialanianabazie form2 = new dzialanianabazie();
            form2.Show();
        }
    }
}
