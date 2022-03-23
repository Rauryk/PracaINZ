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
    public partial class dzialanianabazie : Form
    {
        string conneconnectionString = @"Data Source=PC;Initial Catalog=inzynierka;Integrated Security=True;";
        int a;
        public dzialanianabazie()
        {

            InitializeComponent();
          
        }

       

        

        private void tablice_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            using (SqlConnection sqlcon = new SqlConnection(conneconnectionString))
            {
                sqlcon.Open();
                SqlDataAdapter sqlda = new SqlDataAdapter("select * from " + tablice.Text, sqlcon);
                DataTable dbta = new DataTable();
                sqlda.Fill(dbta);
                dataGridView1.DataSource = dbta;
                a = dataGridView1.Rows.Count-1;
            }

        }
        private void zapisz_Click(object sender, EventArgs e)
        {
            switch (tablice.SelectedItem.ToString().Trim())
            {
                case "klasa":

                    for (int i = a; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        using (SqlConnection sqlcon = new SqlConnection(conneconnectionString))
                        {
                            SqlCommand sqlCommand = new SqlCommand(@"insert into klasa(id) values('" + (int)dataGridView1.Rows[i].Cells[0].Value + "')");
                            sqlcon.Open();
                            sqlCommand.Connection = sqlcon;
                            sqlCommand.ExecuteNonQuery();
                            sqlcon.Close();
                        }
                    }; break;
                case "RodzajZad":
                    for (int i = a; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        using (SqlConnection sqlcon = new SqlConnection(conneconnectionString))
                        {
                            SqlCommand sqlCommand = new SqlCommand(@"insert into RodzajZad(id,nazwa) values('" + (int)dataGridView1.Rows[i].Cells[0].Value +"','"+(string) dataGridView1.Rows[i].Cells[1].Value+"')");
                            sqlcon.Open();
                            sqlCommand.Connection = sqlcon;
                            sqlCommand.ExecuteNonQuery();
                            sqlcon.Close();
                        }
                    }; break;
                case "Rozdzial":
                    for (int i = a; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        using (SqlConnection sqlcon = new SqlConnection(conneconnectionString))
                        {
                            SqlCommand sqlCommand = new SqlCommand(@"insert into Rozdzial(id,nazwa) values('" + (int)dataGridView1.Rows[i].Cells[0].Value + "','" +(string) dataGridView1.Rows[i].Cells[1].Value + "')");
                            sqlcon.Open();
                            sqlCommand.Connection = sqlcon;
                            sqlCommand.ExecuteNonQuery();
                            sqlcon.Close();
                        }
                    }; break;
                case "uczen":
                    for (int i = a; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        using (SqlConnection sqlcon = new SqlConnection(conneconnectionString))
                        {
                            SqlCommand sqlCommand = new SqlCommand(@"insert into uczen(id,ImieNazwisko,nrklasy,podklasa,email) values('" + (int)dataGridView1.Rows[i].Cells[0].Value + "','" +(string) dataGridView1.Rows[i].Cells[1].Value + "','" + (int)dataGridView1.Rows[i].Cells[2].Value + "','" +(string) dataGridView1.Rows[i].Cells[3].Value + "','" +(string) dataGridView1.Rows[i].Cells[4].Value+ "')"); 
                            sqlcon.Open();
                            sqlCommand.Connection = sqlcon;
                            sqlCommand.ExecuteNonQuery();
                            sqlcon.Close();
                        }
                    }; break;
        
            }
        }
    }
}
