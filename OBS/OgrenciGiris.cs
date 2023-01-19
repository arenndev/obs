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
    public partial class OgrenciGiris : Form
    {
        public OgrenciGiris()
        {
            InitializeComponent();
        }

        private void btnOgrenciGirisYap_Click(object sender, EventArgs e)
        {
            string Kullanici;
            string sifre;

            Kullanici = txtBoxOgrenciNo.Text;
            sifre = txtBoxOgrenciSifre.Text;

            if (Kullanici == "212106062" && sifre == "1234")
            {
                this.Hide();
                OgrenciPaneli ogrenciPaneli = new OgrenciPaneli();
                ogrenciPaneli.Show();
            }
            else
            {
                lblKullaniciBilgileriYanlis.Show();
            }
        }

        private void OgrenciGiris_Load(object sender, EventArgs e)
        {
            lblKullaniciBilgileriYanlis.Hide();
        }
    }
}
