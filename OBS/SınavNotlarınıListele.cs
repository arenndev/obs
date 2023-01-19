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
using System.Data.Common;

namespace OBS
{
    public partial class SınavNotlarınıListele : Form
    {
        public SınavNotlarınıListele()
        {
            InitializeComponent();
        }

        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter dataAdapter;

        string connectionString = "server=DESKTOP-C0SDBQE\\SQLEXPRESS; Initial Catalog=obs; Integrated Security=SSPI";

        void SınavNotuListele()
        {
            baglanti = new SqlConnection("server=DESKTOP-C0SDBQE\\SQLEXPRESS; Initial Catalog=obs; Integrated Security=SSPI");
            baglanti.Open();
            dataAdapter = new SqlDataAdapter("Select * FROM Sınavlar", baglanti);
            DataTable tablo = new DataTable();
            dataAdapter.Fill(tablo);
            dataGridSınavNotu.DataSource = tablo;
            baglanti.Close();
        }

        private void SınavNotlarınıListele_Load(object sender, EventArgs e)
        {
            SınavNotuListele();
        }
    }
}
