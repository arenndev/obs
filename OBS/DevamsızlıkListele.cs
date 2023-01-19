using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OBS
{
    public partial class DevamsızlıkListele : Form
    {
        public DevamsızlıkListele()
        {
            InitializeComponent();
        }
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter dataAdapter;

        string connectionString = "server=DESKTOP-C0SDBQE\\SQLEXPRESS; Initial Catalog=obs; Integrated Security=SSPI";

        void DevamsızlıkListeleme()
        {
            baglanti = new SqlConnection("server=DESKTOP-C0SDBQE\\SQLEXPRESS; Initial Catalog=obs; Integrated Security=SSPI");
            baglanti.Open();
            dataAdapter = new SqlDataAdapter("Select * FROM Devamsızlık", baglanti);
            DataTable tablo = new DataTable();
            dataAdapter.Fill(tablo);
            dataGridDevamsızlıkList.DataSource = tablo;
            baglanti.Close();
        }

        private void DevamsızlıkListele_Load(object sender, EventArgs e)
        {
            DevamsızlıkListeleme();
        }
    }
}
