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
    public partial class OgretmenGiris : Form
    {
        public OgretmenGiris()
        {
            InitializeComponent();
        }

        private void OgretmenGiris_Load(object sender, EventArgs e)
        {
            Idveyasifre.Hide();
        }

        private void OgretmenGirisYap_Click(object sender, EventArgs e)
        {
            string Kullanici;
            string sifre;

            Kullanici = txtBoxOgretmenId.Text;
            sifre = txtBoxOgretmenSifre.Text;
            
            if ( Kullanici == "1" && sifre == "1234") 
            {
                this.Hide();
                OgretmenPanel ogretmenPanel = new OgretmenPanel();
                ogretmenPanel.Show();
            }
            else
            {
                Idveyasifre.Show();
            }
        }
    }
}
