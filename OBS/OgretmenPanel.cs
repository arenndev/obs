using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBS
{
    public partial class OgretmenPanel : Form
    {
        public OgretmenPanel()
        {
            InitializeComponent();
        }

        private void btnOgrenciEkle_Click(object sender, EventArgs e)
        {
            OgrenciEkleSilGuncelle ogrenciEkleSilGuncelle = new OgrenciEkleSilGuncelle();
            ogrenciEkleSilGuncelle.Show();
        }

        private void btnDersEkle_Click(object sender, EventArgs e)
        {
            DersEkleSilGuncelle dersEkleSilGuncelle = new DersEkleSilGuncelle();
            dersEkleSilGuncelle.Show();
        }

        private void btnSinavNotGir_Click(object sender, EventArgs e)
        {
            SınavNotuGir sınavNotuGir = new SınavNotuGir();
            sınavNotuGir.Show();
        }

        private void btnDevamsizlikGir_Click(object sender, EventArgs e)
        {
            DevamsızlıkGir devamsızlıkGir = new DevamsızlıkGir();
            devamsızlıkGir.Show();
        }

        private void btnOgrenciListele_Click(object sender, EventArgs e)
        {
            OgrenciListele ogrenciListele= new OgrenciListele();
            ogrenciListele.Show();
        }

        private void btnDersListele_Click(object sender, EventArgs e)
        {
            DersListele dersListele= new DersListele();
            dersListele.Show();
        }

        private void btnSınavNotlarıListele_Click(object sender, EventArgs e)
        {
            SınavNotlarınıListele sınavNotlarınıListele = new SınavNotlarınıListele();
            sınavNotlarınıListele.Show();
        }

        private void btnDevamsizlikListele_Click(object sender, EventArgs e)
        {
            DevamsızlıkListele devamsızlıkListele = new DevamsızlıkListele();
            devamsızlıkListele.Show();
        }
    }
}
