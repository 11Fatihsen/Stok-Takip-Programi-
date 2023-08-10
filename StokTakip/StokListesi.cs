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
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StokTakip
{
    public partial class StokListesi : Form
    {
        public StokListesi()
        {
            InitializeComponent();
        }


        SqlBaglantisi bgl = new SqlBaglantisi();
        public string aktarım;
        string imagepath;
        decimal a, b;



         void Veridoldur()
        {
            SqlCommand cmd = new SqlCommand("Select Stkid as 'Id',StkBarkod as 'Barkod No',tbl_UrunKategori.KtgAd as 'Kategori',StkCinsi as 'Cinsi',tbl_Birimler.BrmAd as 'Birim',StkMiktar as 'Miktar',StkAçıklama1 as 'Açıklma-1',StkAçıklama2 as 'Açıklama-2',StkBirimFiyat as 'Birim Fiyat',StkKdvFiyat as 'KDV Fiyat',StkTarih as 'Giriş Tarihi',StkDegisimTarih as 'Değişim Tarihi',StkGörsel as 'Görsel' from tbl_StokTakip inner join tbl_UrunKategori on tbl_StokTakip.StkKategori=tbl_UrunKategori.KtgId inner join tbl_Birimler on tbl_StokTakip.StkBirim=tbl_Birimler.id ;", bgl.baglanti());
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dataGridView1.DataSource = dt;
            

            bgl.baglanti().Close();
        }
        public void veribosaltma()
        {
            lblresim.Visible = true;
            pictureBox1.Image = null;
            txtstok.Text = null;
            txtBarkodNo.Text = null;
            cmbKategori.Text = "";
            txtcins.Text = "";
            cmbBirim.Text = "";
            txtMiktar.Text = "";
            txtaciklama1.Text = "";
            txtaciklama2.Text = "";
            txtBirimFiyat.Text = "";
            txtKdvFiyat.Text = "";
        }

        public void cmbKategoriDoldur()
        {

            SqlCommand cmd = new SqlCommand("Select * from tbl_UrunKategori", bgl.baglanti());
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());

            cmbKategori.DataSource = dt;
            cmbKategori.ValueMember = "KtgId";
            cmbKategori.DisplayMember = "KtgAd";
            cmbKategori.Text = "";
            bgl.baglanti().Close();
        }
        void cmbBirimDoldur()
        {

            SqlCommand cmd = new SqlCommand("Select * from tbl_Birimler", bgl.baglanti());
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());

            cmbBirim.DataSource = dt;
            cmbBirim.ValueMember = "id";
            cmbBirim.DisplayMember = "BrmAd";
            cmbBirim.Text = "";
            bgl.baglanti().Close();
        }


        private void StokListesi_Load(object sender, EventArgs e)
        {
            Veridoldur();
          
            cmbKategoriDoldur();
            cmbBirimDoldur();
            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           

            



            SqlCommand komut = new SqlCommand("Select * from tbl_StokTakip where Stkid='" + int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()) + "'", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                if (dr["StkGörsel"] != null)
                {
                    byte[] resim = new byte[0];
                    resim = (byte[])dr["StkGörsel"];
                    MemoryStream memoryStream = new MemoryStream(resim);
                    pictureBox1.Image = Image.FromStream(memoryStream);
                    dr.Close();
                    komut.Dispose();
                    bgl.baglanti().Close();

                }
            }

            lblresim.Visible = false;

        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            veribosaltma();

        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Resim Seç";
            openFileDialog1.Filter = "Jpg Dosyaları(*.jpg)|*.jpg| Jpeg Dosyaları(*.jpeg)|*.jpeg| Png Dosyaları(*.png)|*.png| Gif Dosyaları(*.gif)|*.gif| Tif Dosyaları(*.tif)|*.tif";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                imagepath = openFileDialog1.FileName;
                lblresim.Visible = false;
            }
            bgl.baglanti().Close();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            a = Convert.ToDecimal(txtBirimFiyat.Text);
            b = Convert.ToDecimal(txtKdvFiyat.Text);
            DateTime tarih = DateTime.Now;

            FileStream fileStream = new FileStream(imagepath, FileMode.Open, FileAccess.Read);
            BinaryReader binaryReader = new BinaryReader(fileStream);
            byte[] resim = binaryReader.ReadBytes((int)fileStream.Length);
            binaryReader.Close();
            fileStream.Close();

            SqlCommand cmd = new SqlCommand("update tbl_StokTakip set StkBarkod=@p1,StkKategori=@p2,StkCinsi=@p3,StkBirim=@p4,StkMiktar=@p5," +
                "StkAçıklama1=@p6,StkAçıklama2=@p7,StkBirimFiyat=@p8,StkKdvFiyat=@p9,StkDegisimTarih=@p10,StkGörsel=@p11 where Stkid=@p0", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p0", txtstok.Text);
            cmd.Parameters.AddWithValue("@p1", txtBarkodNo.Text);
            cmd.Parameters.AddWithValue("@p2", cmbKategori.SelectedIndex + 1);
            cmd.Parameters.AddWithValue("@p3", txtcins.Text);
            cmd.Parameters.AddWithValue("@p4", cmbBirim.SelectedIndex + 1);
            cmd.Parameters.AddWithValue("@p5", txtMiktar.Text);
            cmd.Parameters.AddWithValue("@p6", txtaciklama1.Text);
            cmd.Parameters.AddWithValue("@p7", txtaciklama2.Text);
            cmd.Parameters.AddWithValue("@p8", a);
            cmd.Parameters.AddWithValue("@p9", b);
            cmd.Parameters.AddWithValue("@p10", tarih.ToString("d"));
            cmd.Parameters.Add("@p11", SqlDbType.Image, resim.Length).Value = resim;
            cmd.ExecuteNonQuery();
            bgl.baglanti().Close();
            Veridoldur();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Seçtiğiniz kaydı silmek istediğinize emin misiniz?", "Silme Onay İşlemi", MessageBoxButtons.YesNoCancel);
            if (d == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("Delete from tbl_StokTakip where Stkid=@p1", bgl.baglanti());
                cmd.Parameters.AddWithValue("@p1", txtstok.Text);
                cmd.ExecuteNonQuery();
                bgl.baglanti().Close();
                Veridoldur();
                veribosaltma();
                MessageBox.Show("Kullanıcı Kaydı Silindi.", "Silme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            StokRaporu gecis = new StokRaporu();
            gecis.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Grafik gecis = new Grafik();
            gecis.Show();   
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtstok.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtBarkodNo.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            cmbKategori.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtcins.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            cmbBirim.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtMiktar.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txtaciklama1.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            txtaciklama2.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            txtBirimFiyat.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            txtKdvFiyat.Text = dataGridView1.Rows[secilen].Cells[9].Value.ToString();

            SqlCommand komut = new SqlCommand("Select * from tbl_StokTakip where Stkid='" + int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()) + "'", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                if (dr["StkGörsel"] != null)
                {
                    byte[] resim = new byte[0];
                    resim = (byte[])dr["StkGörsel"];
                    MemoryStream memoryStream = new MemoryStream(resim);
                    pictureBox1.Image = Image.FromStream(memoryStream);
                    dr.Close();
                    komut.Dispose();
                    bgl.baglanti().Close();

                }
            }

            lblresim.Visible = false;

        }

        private void btnArama_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select Stkid as 'Id', StkBarkod as 'Barkod', tbl_UrunKategori.KtgAd as 'Kategorisi'," +
                            " StkCinsi as 'Cinsi',tbl_Birimler.BrmAd as 'Birim', StkMiktar as 'Miktar', StkAçıklama1 as 'Açıklama 1'," +
                            "StkAçıklama2 as 'Açıklama2',StkBirimFiyat as 'Birim Fiyatı',StkKdvFiyat as 'KDV''li Fiyat' ,StkTarih as 'Giriş Tarihi',StkDegisimTarih as 'Değişim Tarihi',StkGörsel as 'Ürün Görseli'" +
                            "from tbl_StokTakip inner join tbl_UrunKategori on tbl_StokTakip.StkKategori=tbl_UrunKategori.KtgId " +
                            "inner join tbl_Birimler on tbl_StokTakip.StkKategori=tbl_Birimler.id where StkBarkod like '%"+ txtarama.Text+"%';", bgl.baglanti());
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dataGridView1.DataSource = dt;
        }

    
    }
}
