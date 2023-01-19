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
    public partial class DevamsızlıkGir : Form
    {
        public DevamsızlıkGir()
        {
            InitializeComponent();
        }

        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter dataAdapter;

        string connectionString = "server=DESKTOP-C0SDBQE\\SQLEXPRESS; Initial Catalog=obs; Integrated Security=SSPI";

        void DevamsızlıkEkle()
        {
            baglanti = new SqlConnection("server=DESKTOP-C0SDBQE\\SQLEXPRESS; Initial Catalog=obs; Integrated Security=SSPI");
            baglanti.Open();
            dataAdapter = new SqlDataAdapter("Select * FROM Devamsızlık", baglanti);
            DataTable tablo = new DataTable();
            dataAdapter.Fill(tablo);
            dataGridDevamsızlık.DataSource = tablo;
            baglanti.Close();
        }

        private void DevamsızlıkGir_Load(object sender, EventArgs e)
        {
            DevamsızlıkEkle();
        }

        private void dataGridDevamsızlık_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtBoxDersId.Text = dataGridDevamsızlık.CurrentRow.Cells[1].Value.ToString();
            txtBoxOgrenciNo.Text = dataGridDevamsızlık.CurrentRow.Cells[2].Value.ToString();
            txtBoxTarih.Text = dataGridDevamsızlık.CurrentRow.Cells[3].Value.ToString();
            txtBoxSınavId.Text = dataGridDevamsızlık.CurrentRow.Cells[0].Value.ToString();
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

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string sorgu = $" INSERT INTO Devamsızlık (DersId, OgrenciNo, Tarih) VALUES ('{txtBoxDersId.Text}','{txtBoxOgrenciNo.Text}','{txtBoxTarih.Text}') ";
            CreateCommand(sorgu, connectionString);
            DevamsızlıkEkle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string sorgu = $" DELETE FROM Devamsızlık WHERE Id='{txtBoxSınavId.Text}'";
            CreateCommand(sorgu, connectionString);
            DevamsızlıkEkle();
        }
    }
}



//(DersId = '{txtBoxDersId.Text}', ogrenciNo = '{txtBoxOgrenciNo.Text}', Tarih = '{txtBoxTarih.Text}')