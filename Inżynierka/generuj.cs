using System;
using System.Collections;
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
    public partial class generuj : Form
    {
        string conneconnectionString = @"Data Source=PC;Initial Catalog=inzynierka;Integrated Security=True;";
        public generuj()
        {
            InitializeComponent();
            ladujbaze();
        }
     
        void ladujbaze()
        {
            using (SqlDataAdapter sda = new SqlDataAdapter("SELECT id, nazwa FROM Rozdzial", conneconnectionString))
            {
                DataTable dt = new DataTable();
                sda.Fill(dt);
                DataRow row = dt.NewRow();
                dt.Rows.InsertAt(row, 0);
                rozdzial.DataSource = dt;
                rozdzial.ValueMember = "id";
                rozdzial.DisplayMember = "nazwa";


            }
            using (SqlDataAdapter sda = new SqlDataAdapter("SELECT id FROM klasa", conneconnectionString))
            {
                DataTable dt = new DataTable();
                sda.Fill(dt);
                DataRow row = dt.NewRow();
                dt.Rows.InsertAt(row, 0);
                klasa.DataSource = dt;
                klasa.DisplayMember = "id";
                klasa.ValueMember = "id";
            }
            using (SqlDataAdapter sda = new SqlDataAdapter("SELECT litera FROM TablicaPodklasa", conneconnectionString))
            {
                DataTable dt = new DataTable();
                sda.Fill(dt);
                DataRow row = dt.NewRow();
                podklasa.DataSource = dt;
                podklasa.DisplayMember = "litera";
                podklasa.ValueMember = "litera";
            }
            //string a = podklasa.SelectedValue.ToString();
        }
        private void matura_CheckedChanged(object sender, EventArgs e)
        {
            if (matura.Checked == true)
            {
                label4.Visible = false;
                rozdzial.Enabled = false;
                rozdzial.Visible = false;
            }
            else
            {
                label4.Visible = true;
                rozdzial.Enabled = true;
                rozdzial.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArrayList arrayList_zamkniete = new ArrayList();
            ArrayList arrayList_otwarte = new ArrayList();
            if (matura.Checked == false)
            {
                if (int.Parse(ilosc_zamnietych.Text) < 0)
                    using (SqlDataAdapter sda = new SqlDataAdapter("SELECT opiszadania FROM zadania where RodzajZadania = 1 and Rozdzial=" + rozdzial.SelectedIndex.ToString() + " and klasa =" + klasa.SelectedIndex.ToString(), conneconnectionString))
                    {
                        DataSet dataSet = new DataSet();
                        sda.Fill(dataSet);


                        foreach (DataRow dataRow in dataSet.Tables[0].Rows)
                        {
                            arrayList_zamkniete.Add(dataRow[0].ToString());
                        }
                    }
                if (int.Parse(ilosc_otwartych.Text) < 0)
                    using (SqlDataAdapter sda = new SqlDataAdapter("SELECT opiszadania FROM zadania where RodzajZadania = 2 and Rozdzial=" + rozdzial.SelectedIndex.ToString() + " and klasa =" + klasa.SelectedIndex.ToString(), conneconnectionString))
                    {
                        DataSet dataSet = new DataSet();
                        sda.Fill(dataSet);
                        

                        foreach (DataRow dataRow in dataSet.Tables[0].Rows)
                        {
                            arrayList_otwarte.Add(dataRow[0].ToString());
                        }
                    }

            }
            else
            {
                if (int.Parse(ilosc_zamnietych.Text) < 0)
                    using (SqlDataAdapter sda = new SqlDataAdapter("SELECT opiszadania FROM zadania where Maturalne = 1 and RodzajZadania = 1", conneconnectionString))
                {
                    DataSet dataSet = new DataSet();
                    sda.Fill(dataSet);


                    foreach (DataRow dataRow in dataSet.Tables[0].Rows)
                    {
                        arrayList_zamkniete.Add(dataRow[0].ToString());
                    }

                }
                if (int.Parse(ilosc_otwartych.Text) < 0)
                    using (SqlDataAdapter sda = new SqlDataAdapter("SELECT opiszadania FROM zadania where Maturalne = 1 and RodzajZadania = 2", conneconnectionString))
                {
                    DataSet dataSet = new DataSet();
                    sda.Fill(dataSet);


                    foreach (DataRow dataRow in dataSet.Tables[0].Rows)
                    {
                        arrayList_otwarte.Add(dataRow[0].ToString());
                    }

                }
            }
            //MessageBox.Show(tab.Length.ToString());

        }
    }
}
