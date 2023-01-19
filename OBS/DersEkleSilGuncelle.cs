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
    public partial class DersEkleSilGuncelle : Form
    {
        public DersEkleSilGuncelle()
        {
            InitializeComponent();
        }


        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter dataAdapter;

        string connectionString = "server=DESKTOP-C0SDBQE\\SQLEXPRESS; Initial Catalog=obs; Integrated Security=SSPI";

        void DersEkle()
        {
            baglanti = new SqlConnection("server=DESKTOP-C0SDBQE\\SQLEXPRESS; Initial Catalog=obs; Integrated Security=SSPI");
            baglanti.Open();
            dataAdapter = new SqlDataAdapter("Select * FROM Dersler", baglanti);
            DataTable tablo = new DataTable();
            dataAdapter.Fill(tablo);
            dataGridDersEkleSilGuncelle.DataSource = tablo;
            baglanti.Close();
        }

        private void DersEkleSilGuncelle_Load(object sender, EventArgs e)
        {
            DersEkle();
            txtBoxDersAdi.Clear();
            txtBoxDersId.Clear();
            txtBoxDersKodu.Clear();
            txtBoxDersKredisi.Clear();
            
        }

        private void dataGridDersEkleSilGuncelle_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtBoxDersAdi.Text = dataGridDersEkleSilGuncelle.CurrentRow.Cells[1].Value.ToString();
            txtBoxDersId.Text = dataGridDersEkleSilGuncelle.CurrentRow.Cells[0].Value.ToString();
            txtBoxDersKodu.Text = dataGridDersEkleSilGuncelle.CurrentRow.Cells[2].Value.ToString();
            txtBoxDersKredisi.Text = dataGridDersEkleSilGuncelle.CurrentRow.Cells[3].Value.ToString();
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
            string sorgu = $"INSERT INTO Dersler(DersAd,DersKod,DersKredisi) VALUES ('{txtBoxDersAdi.Text}', '{txtBoxDersKodu.Text}', '{txtBoxDersKredisi.Text}')";
            CreateCommand(sorgu, connectionString);
            DersEkle();

            txtBoxDersAdi.Clear();
            txtBoxDersId.Clear();
            txtBoxDersKodu.Clear();
            txtBoxDersKredisi.Clear();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string sorgu = $"DELETE FROM Dersler WHERE DersId={txtBoxDersId.Text}";
            CreateCommand(sorgu, connectionString);
            DersEkle();

            txtBoxDersAdi.Clear();
            txtBoxDersId.Clear();
            txtBoxDersKodu.Clear();
            txtBoxDersKredisi.Clear();
        }

        private void btnGuncelle_Click(object sender, EventArgs e) 
        {
            string sorgu = $"UPDATE Dersler SET DersAd='{txtBoxDersAdi.Text}', DersKod='{txtBoxDersKodu.Text}', DersKredisi='{txtBoxDersKredisi.Text}' WHERE DersId='{txtBoxDersId.Text}'";
            CreateCommand(sorgu, connectionString);
            DersEkle(); 
        }
    }

  
}
