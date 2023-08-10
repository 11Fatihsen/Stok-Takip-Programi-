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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StokTakip
{
    public partial class KullaniciIslemleri : Form
    {
        public KullaniciIslemleri()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl=new SqlBaglantisi();

        public void Veridoldur()
        {
            SqlCommand cmd = new SqlCommand("Select KulId as 'Id', KulAdSoyad as 'Ad Soyad', KulKullaniciAd as 'Kullanıcı Adı'," +
                " KulSifre as 'Şifre',KulEposta as 'E-Posta', KulTel as 'Telefon', tbl_yetki.yetkiAd as 'Yetki' " +
                "from tbl_Kullanicilar inner join tbl_yetki on tbl_Kullanicilar.KulYetki=tbl_yetki.yetkiId;", bgl.baglanti());
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dataGridView1.DataSource = dt;
            

            bgl.baglanti().Close();
        }
        void iptal()
        {
            txtadsoyad.Text = "";
            txteposta.Text = "";
            mtxttelefon.Text = "";
            cmbyetki.Text = "";
            txtkullaniciadi.Text = "";
            txtsifre.Text = "";
            lblid.Text ="";
        }
       public void cmbyetkidoldur()
        {
            SqlCommand cmd = new SqlCommand("Select * from tbl_yetki", bgl.baglanti());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbyetki.Items.Add(dr[1]);
            }
            bgl.baglanti().Close();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            Veridoldur();
            cmbyetkidoldur();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into tbl_Kullanicilar(KulAdSoyad,KulEposta,KulTel,KulYetki,KulKullaniciAd,KulSifre) " +
                "values (@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1",txtadsoyad.Text);
            cmd.Parameters.AddWithValue("@p2", txteposta.Text);
            cmd.Parameters.AddWithValue("@p3", mtxttelefon.Text);
            cmd.Parameters.AddWithValue("@p4", cmbyetki.SelectedIndex +1);
            cmd.Parameters.AddWithValue("@p5", txtkullaniciadi.Text);
            cmd.Parameters.AddWithValue("@p6", txtsifre.Text);
            cmd.ExecuteNonQuery();
            bgl.baglanti().Close();
            Veridoldur();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update tbl_Kullanicilar set KulAdSoyad=@p1,KulEposta=@p2,KulTel=@p3,KulYetki=@p4," +
                "KulKullaniciAd=@p5,KulSifre=@p6 where KulId=@p0", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p0", lblid.Text);
            cmd.Parameters.AddWithValue("@p1", txtadsoyad.Text);
            cmd.Parameters.AddWithValue("@p2", txteposta.Text);
            cmd.Parameters.AddWithValue("@p3", mtxttelefon.Text);
            cmd.Parameters.AddWithValue("@p4", cmbyetki.SelectedIndex + 1);
            cmd.Parameters.AddWithValue("@p5", txtkullaniciadi.Text);
            cmd.Parameters.AddWithValue("@p6", txtsifre.Text);
            cmd.ExecuteNonQuery();
            bgl.baglanti().Close();
            Veridoldur();
        }

    

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Delete from tbl_Kullanicilar where KulId=@p1 and KulAdSoyad=@p2",bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1",lblid.Text);
            cmd.Parameters.AddWithValue("@p2",txtadsoyad.Text);
            cmd.ExecuteNonQuery();
            bgl.baglanti().Close();
            Veridoldur();
            MessageBox.Show("Kullanıcı Kaydı Silindi.", "Silme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            iptal();
        }

        private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtadsoyad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txteposta.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            mtxttelefon.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            cmbyetki.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            txtkullaniciadi.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtsifre.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            lblid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
        }
    }
}
