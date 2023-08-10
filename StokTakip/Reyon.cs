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
    public partial class Reyon : Form
    {
        public Reyon()
        {
            InitializeComponent();
        }
        
        SqlBaglantisi bgl = new SqlBaglantisi();
        CurrencyManager cm;
        CurrencyManager cm2;
        CurrencyManager cm3;
        int deger;
        decimal a;
        public void Veridoldur()
        {
            SqlCommand cmd = new SqlCommand("Select Stkid as 'Id',StkBarkod as 'Barkod No',tbl_UrunKategori.KtgAd as 'Kategori',StkCinsi as 'Cinsi',tbl_Birimler.BrmAd as 'Birim',StkMiktar as 'Miktar',StkAçıklama1 as 'Açıklma-1',StkAçıklama2 as 'Açıklama-2',StkBirimFiyat as 'Birim Fiyat',StkKdvFiyat as 'KDV Fiyat',StkTarih as 'Giriş Tarihi',StkDegisimTarih as 'Değişim Tarihi',StkGörsel as 'Görsel' from tbl_StokTakip inner join tbl_UrunKategori on tbl_StokTakip.StkKategori=tbl_UrunKategori.KtgId inner join tbl_Birimler on tbl_StokTakip.StkBirim=tbl_Birimler.id ;", bgl.baglanti());
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dataGridView1.DataSource = dt;
            cm = (CurrencyManager)BindingContext[dt];

            bgl.baglanti().Close();
        }
        public void txt_veri_doldur()
        {
            //SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-O55E6N8\\SQLEXPRESS;Initial Catalog=Eczane;Integrated Security=True");

            //baglanti.Open();
            SqlCommand cmd = new SqlCommand("Select Stkid , StkBarkod, StkCinsi, StkKdvFiyat from tbl_StokTakip ;", bgl.baglanti());
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            txtStok.DataBindings.Add("Text", dt, "Stkid");
            txtBarkod.DataBindings.Add("Text", dt, "StkBarkod");
            txtCinsi.DataBindings.Add("Text", dt, "StkCinsi");
            txtKdvFiyat.DataBindings.Add("Text", dt, "StkKdvFiyat");
            cm2 = (CurrencyManager)BindingContext[dt];
            bgl.baglanti().Close();
           
        }
        public void ReyonGonderilenVerileri()
        {
            a = Convert.ToDecimal(txtKdvFiyat.Text);
            DateTime tarih = DateTime.Now;
            SqlCommand cmd = new SqlCommand("insert into tbl_ReyonGonderilen(RynStokNo,RynBarkod,RynCinsi,RynMiktar,RynKdvFiyat,RynTarih) " +
            "values (@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", txtStok.Text);
            cmd.Parameters.AddWithValue("@p2", txtBarkod.Text) ;
            cmd.Parameters.AddWithValue("@p3", txtCinsi.Text);
            cmd.Parameters.AddWithValue("@p4", txtMiktar.Text);
            cmd.Parameters.AddWithValue("@p5", a);
            cmd.Parameters.AddWithValue("@p6", tarih.ToString("d"));
            cmd.ExecuteNonQuery();
            bgl.baglanti().Close();
        }
        private void Reyon_Load(object sender, EventArgs e)
        {
            
            Veridoldur();
            txt_veri_doldur();
            btnOrta.Text= "Kayıt " + (cm.Position + 1) + "/" + (cm.Count);
            
        }

        private void btnGönder_Click(object sender, EventArgs e)
        {


            SqlCommand cmd = new SqlCommand("update tbl_StokTakip set StkMiktar= StkMiktar -'"+txtMiktar.Text+"' where Stkid='"+txtStok.Text+"'", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p0", txtStok.Text);
            cmd.Parameters.AddWithValue("@p1", "-" + txtMiktar.Text);
            cmd.ExecuteNonQuery();
            bgl.baglanti().Close();
            Veridoldur();
            ReyonGonderilenVerileri();



            txtMiktar.Text = null;










        }

        private void btnIleeri_Click(object sender, EventArgs e)
        {
            cm.Position++;
            cm2.Position++;
            btnOrta.Text = "Kayıt " + (cm.Position + 1) + "/" + (cm.Count);
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            cm.Position--;
            cm2.Position--;
            btnOrta.Text = "Kayıt " + (cm.Position + 1) + "/" + (cm.Count);
        }

        private void btnSon_Click(object sender, EventArgs e)
        {
            cm.Position = cm.Count - 1;
            cm2.Position = cm2.Count - 1;
            btnOrta.Text = "Kayıt " + (cm.Position + 1) + "/" + (cm.Count);
        }


        private void btnIlk_Click(object sender, EventArgs e)
        {
            cm.Position = 0;
            cm2.Position = 0;
            btnOrta.Text = "Kayıt " + (cm.Position + 1) + "/" + (cm.Count);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReyonRapor gecis  = new ReyonRapor();
            gecis.Show();
            this.Hide();
        }
    }
}
