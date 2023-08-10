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

namespace StokTakip
{
    public partial class Grafik : Form
    {
        public Grafik()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
     
        private void Grafik_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select KtgAd, sum(StkMiktar) from tbl_UrunKategori, tbl_StokTakip where tbl_UrunKategori.KtgId=tbl_StokTakip.StkKategori group by KtgAd ", bgl.baglanti());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                chart1.Series["Stok Miktarı"].Points.AddXY(dr["KtgAd"], dr[1]);
            }
            
          
            bgl.baglanti().Close();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
