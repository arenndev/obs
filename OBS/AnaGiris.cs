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
    public partial class AnaGiris : Form
    {
        public AnaGiris()
        {
            InitializeComponent();
        }

        private void btnOgrenciGirisi_Click(object sender, EventArgs e)
        {
            OgrenciGiris ogrenciGiris= new OgrenciGiris();
            ogrenciGiris.Show();
        }

        private void btnOgretmenGirisi_Click(object sender, EventArgs e)
        {
            OgretmenGiris ogretmenGiris = new OgretmenGiris();
            ogretmenGiris.Show();
        }
    }
}
