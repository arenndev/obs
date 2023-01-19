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
    public partial class OgrenciPaneli : Form
    {
        public OgrenciPaneli()
        {
            InitializeComponent();
        }

        private void btnDersleriListele_Click(object sender, EventArgs e)
        {
            DersListele dersListele = new DersListele();
            dersListele.Show();
        }

        private void btnSinavNotuListele_Click(object sender, EventArgs e)
        {
            SınavNotlarınıListele sınavNotlarınıListele = new SınavNotlarınıListele();
            sınavNotlarınıListele.Show();

        }

        private void btnDevamsizlikListele_Click(object sender, EventArgs e)
        {
            DevamsızlıkListele devamsızlıkListele = new DevamsızlıkListele();
            devamsızlıkListele.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SınavNotlarınıListele sınavNotlarınıListele = new SınavNotlarınıListele();
            sınavNotlarınıListele.Show();
        }
    }
}
