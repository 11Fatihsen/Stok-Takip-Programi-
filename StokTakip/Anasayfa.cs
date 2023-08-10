using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakip
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }
        public static string a_yetki;
        private void Anasayfa_Load(object sender, EventArgs e)
        {
            if (a_yetki == "2")
            {
                btnYönetim.Enabled = false;
                toolTip1.SetToolTip(panel6, "Yönetim Kısmına Sadece Yönetici Erişebilir.");
                
            }
        }

        private void btnStokKarti_Click(object sender, EventArgs e)
        {
            StokKarti gecis = new StokKarti();
            gecis.Show();
        }

        private void btnStokListesi_Click(object sender, EventArgs e)
        {
            StokListesi gecis = new StokListesi();
            gecis.Show();
        }

        private void btnReyonSevk_Click(object sender, EventArgs e)
        {
            Reyon gecis = new Reyon();
            gecis.Show();
        }

        private void btnYönetim_Click(object sender, EventArgs e)
        {
            Yönetim gecis = new Yönetim();
            gecis.Show();
        }

        private void btnİletişim_Click(object sender, EventArgs e)
        {
            Eposta gecis = new Eposta();
            gecis.Show();
        }

        private void btnGeribildirim_Click(object sender, EventArgs e)
        {
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult cıkıs;
            cıkıs = MessageBox.Show("Çıkmak İstediğinize Emin misiniz ?","Çıkış",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (cıkıs==DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        private void btnGeribildirim_Click_1(object sender, EventArgs e)
        {
            GeriBildirim gecis = new GeriBildirim();
            gecis.Show();
        }
    }
}
