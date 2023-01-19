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
    public partial class OgrenciEkleSilGuncelle : Form
    {
        public OgrenciEkleSilGuncelle()
        {
            InitializeComponent();
        }

        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter dataAdapter;

        string connectionString = "server=DESKTOP-C0SDBQE\\SQLEXPRESS; Initial Catalog=obs; Integrated Security=SSPI";

        void OgrenciEkle()
        {
            baglanti = new SqlConnection("server=DESKTOP-C0SDBQE\\SQLEXPRESS; Initial Catalog=obs; Integrated Security=SSPI");
            baglanti.Open();
            dataAdapter = new SqlDataAdapter("Select * FROM Ogrenci", baglanti);
            DataTable tablo = new DataTable();
            dataAdapter.Fill(tablo);
            dataGridOgrenciEkleSilGuncelle.DataSource = tablo;
            baglanti.Close();
        }

        private void OgrenciEkleSilGuncelle_Load(object sender, EventArgs e)
        {
            OgrenciEkle();
            txtBoxAdSoyad.Clear();
            txtBoxBolumAdi.Clear();
            txtBoxBolumId.Clear();
            txtBoxCinsiyet.Clear();
            txtBoxDogumTarihi.Clear();
            txtBoxDogumYeri.Clear();
            txtBoxOgrenciNo.Clear();
        }

        private void dataGridOgrenciEkleSilGuncelle_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtBoxAdSoyad.Text = dataGridOgrenciEkleSilGuncelle.CurrentRow.Cells[0].Value.ToString();
            txtBoxOgrenciNo.Text = dataGridOgrenciEkleSilGuncelle.CurrentRow.Cells[1].Value.ToString();
            txtBoxDogumYeri.Text = dataGridOgrenciEkleSilGuncelle.CurrentRow.Cells[2].Value.ToString();
            txtBoxDogumTarihi.Text = dataGridOgrenciEkleSilGuncelle.CurrentRow.Cells[3].Value.ToString();
            txtBoxBolumId.Text = dataGridOgrenciEkleSilGuncelle.CurrentRow.Cells[4].Value.ToString();
            txtBoxCinsiyet.Text = dataGridOgrenciEkleSilGuncelle.CurrentRow.Cells[5].Value.ToString();
            txtBoxBolumAdi.Text = dataGridOgrenciEkleSilGuncelle.CurrentRow.Cells[6].Value.ToString();

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
            string sorgu = $"INSERT INTO Ogrenci(AdSoyad, dogumYeri, dogumTarihi, BolumId, Cinsiyet, BolumAdı) VALUES ('{txtBoxAdSoyad.Text}', '{txtBoxDogumYeri.Text}', '{txtBoxDogumTarihi.Text}', '{txtBoxBolumId.Text}', '{txtBoxCinsiyet.Text}', '{txtBoxBolumAdi.Text}')";
            CreateCommand(sorgu, connectionString);
            OgrenciEkle();

            txtBoxAdSoyad.Clear();
            txtBoxBolumAdi.Clear();
            txtBoxBolumId.Clear();
            txtBoxCinsiyet.Clear();
            txtBoxDogumTarihi.Clear();
            txtBoxDogumYeri.Clear();
            txtBoxOgrenciNo.Clear();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string sorgu = $"DELETE FROM Ogrenci WHERE ogrenciNo={txtBoxOgrenciNo.Text}";
            CreateCommand(sorgu, connectionString);
            OgrenciEkle();

            txtBoxAdSoyad.Clear();
            txtBoxBolumAdi.Clear();
            txtBoxBolumId.Clear();
            txtBoxCinsiyet.Clear();
            txtBoxDogumTarihi.Clear();
            txtBoxDogumYeri.Clear();
            txtBoxOgrenciNo.Clear(); 
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string sorgu = $"UPDATE  Ogrenci SET AdSoyad='{txtBoxAdSoyad.Text}', dogumYeri='{txtBoxDogumYeri.Text}', dogumTarihi='{txtBoxDogumTarihi.Text}', bolumId='{txtBoxBolumId.Text}', Cinsiyet='{txtBoxCinsiyet.Text}', BolumAdı='{txtBoxBolumAdi.Text}' WHERE ogrenciNo='{txtBoxOgrenciNo.Text}'";
            CreateCommand(sorgu, connectionString);
            baglanti.Close();
            OgrenciEkle();
            

            txtBoxAdSoyad.Clear();
            txtBoxBolumAdi.Clear();
            txtBoxBolumId.Clear();
            txtBoxCinsiyet.Clear();
            txtBoxDogumTarihi.Clear();
            txtBoxDogumYeri.Clear();
            txtBoxOgrenciNo.Clear();

        }
    }
}
