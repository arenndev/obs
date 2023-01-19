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

namespace OBS
{
    public partial class SınavNotuGir : Form
    {
        public SınavNotuGir()
        {
            InitializeComponent();
        }

        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter dataAdapter;

        string connectionString = "server=DESKTOP-C0SDBQE\\SQLEXPRESS; Initial Catalog=obs; Integrated Security=SSPI";

        void SınavEkle()
        {
            baglanti = new SqlConnection("server=DESKTOP-C0SDBQE\\SQLEXPRESS; Initial Catalog=obs; Integrated Security=SSPI");
            baglanti.Open();
            dataAdapter = new SqlDataAdapter("Select * FROM Sınavlar", baglanti);
            DataTable tablo = new DataTable();
            dataAdapter.Fill(tablo);
            dataGridSınavNotu.DataSource = tablo;
            baglanti.Close();
        }

        private void SınavNotuGir_Load(object sender, EventArgs e)
        {
            SınavEkle();
            txtBoxSınavId.Clear();
            txtBoxDersId.Clear();
            txtBoxOgrenciNo.Clear();
            txtBoxDersAdı.Clear();
            txtBoxAdSoyad.Clear();
            txtBoxFinal.Clear();
            txtBoxVize.Clear();
            txtBoxBüt.Clear();
        }

        private void dataGridSınavNotu_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtBoxSınavId.Text = dataGridSınavNotu.CurrentRow.Cells[0].Value.ToString();
            txtBoxDersId.Text = dataGridSınavNotu.CurrentRow.Cells[1].Value.ToString();
            txtBoxOgrenciNo.Text = dataGridSınavNotu.CurrentRow.Cells[2].Value.ToString();
            txtBoxDersAdı.Text = dataGridSınavNotu.CurrentRow.Cells[3].Value.ToString();
            txtBoxAdSoyad.Text = dataGridSınavNotu.CurrentRow.Cells[4].Value.ToString();
            txtBoxFinal.Text = dataGridSınavNotu.CurrentRow.Cells[5].Value.ToString();
            txtBoxVize.Text = dataGridSınavNotu.CurrentRow.Cells[6].Value.ToString();
        }
        private static void CreateCommand(string queryString, string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }


        private void btnNotGir_Click(object sender, EventArgs e)
        {
            string sorgu = $"UPDATE Sınavlar SET VizeNotu='{txtBoxVize.Text}', FinalNotu='{txtBoxFinal.Text}', BütünlemeNotu='{txtBoxBüt.Text}' WHERE SınavId= '{txtBoxSınavId.Text}'";
            CreateCommand(sorgu, connectionString);
            SınavEkle();
        }

        private void btnNotSil_Click(object sender, EventArgs e)
        {
            string sorgu = $" DELETE FROM Sınavlar Where SınavId='{txtBoxSınavId.Text}'";
            CreateCommand(sorgu, connectionString);
            SınavEkle();
        }

        
    }
}
