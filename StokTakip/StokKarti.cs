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
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace StokTakip
{
    public partial class StokKarti : Form
    {
        
        public StokKarti()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice captureDevice;
        string imagepath;
        decimal bfiyat, kfiyat,a;
       
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



        private void StokKarti_Load(object sender, EventArgs e)
        {
            panel4.Enabled = false;
            cmbKategoriDoldur();
            cmbBirimDoldur();

            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            for (int i = 0; i < filterInfoCollection.Count; i++)
            {
                comboBox1.Items.Add(filterInfoCollection[i].Name);
            }

        }
        private void btnQr_Click(object sender, EventArgs e)
        {
            panel4.Enabled = true;




        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox2.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox2.Image != null)
            {
                BarcodeReader barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap)pictureBox2.Image);
                if (result != null)
                {
                    richTextBox1.Text = result.ToString();

                    timer1.Stop();
                    if (captureDevice.IsRunning)
                    {
                        captureDevice.Stop();
                        MessageBox.Show(result.ToString());
                    }
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
          
        }



        
        private void btnGörselEkle_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Resim Seç";
            openFileDialog1.Filter = "Png Dosyaları(*.png)|*.png| Jpeg Dosyaları(*.jpeg)|*.jpeg| Jpg Dosyaları(*.jpg)|*.jpg| Gif Dosyaları(*.gif)|*.gif| Tif Dosyaları(*.tif)|*.tif";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                imagepath = openFileDialog1.FileName;
                lblresim.Visible= false;
            }
            bgl.baglanti().Close();
        }
        private void btnKdvHesapla_Click(object sender, EventArgs e)
        {
            bfiyat = decimal.Parse(txtBirimFiyat.Text);
            kfiyat = bfiyat + bfiyat * 18 / 100;
            
            txtKdvFiyat.Text=kfiyat.ToString();
            a=Convert.ToDecimal(txtKdvFiyat.Text);
            
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

        }
        private void btnIptal_Click(object sender, EventArgs e)
        {
            lblresim.Visible = true;
            pictureBox1.Image = null;
            txtBarkodNo.Text = null;
            cmbKategori.Text = "";
            txtcins.Text = "";
            cmbBirim.Text = "";
            txtMiktar.Text = "";
            txtaciklama1.Text = "";
            txtaciklama2.Text = "";
            txtBirimFiyat.Text = "";
            txtKdvFiyat.Text = "";

            pictureBox2.Image= null;
            richTextBox1.Text = null;
            comboBox1.Text = null;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Grafik gecis = new Grafik();
            gecis.Show();
        }

        private void btnbaslat_Click(object sender, EventArgs e)
        {
            captureDevice = new VideoCaptureDevice(filterInfoCollection[comboBox1.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;  // += den sonra 2 defa tab basınca çıkıyor.
            captureDevice.Start();
            timer1.Start();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {

            DateTime tarih = DateTime.Now;

            FileStream fileStream = new FileStream(imagepath, FileMode.Open, FileAccess.Read);
            BinaryReader binaryReader = new BinaryReader(fileStream);
            byte[] resim = binaryReader.ReadBytes((int)fileStream.Length);
            binaryReader.Close();
            fileStream.Close();


            SqlCommand cmd = new SqlCommand("insert into tbl_StokTakip(StkBarkod,StkKategori,StkCinsi,StkBirim,StkMiktar,StkAçıklama1,StkAçıklama2,StkBirimFiyat,StkKdvFiyat,StkTarih,StkGörsel) " +
            "values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", txtBarkodNo.Text);
            cmd.Parameters.AddWithValue("@p2", cmbKategori.SelectedIndex + 1);
            cmd.Parameters.AddWithValue("@p3", txtcins.Text);
            cmd.Parameters.AddWithValue("@p4", cmbBirim.SelectedIndex + 1);
            cmd.Parameters.AddWithValue("@p5", txtMiktar.Text);
            cmd.Parameters.AddWithValue("@p6", txtaciklama1.Text);
            cmd.Parameters.AddWithValue("@p7", txtaciklama2.Text);
            cmd.Parameters.AddWithValue("@p8", txtBirimFiyat.Text);
            cmd.Parameters.AddWithValue("@p9", a);
            cmd.Parameters.AddWithValue("@p10", tarih.ToString("d"));
            cmd.Parameters.Add("@p11", SqlDbType.Image, resim.Length).Value = resim;
            cmd.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }


        private void button5_Click(object sender, EventArgs e)
        {
            StokListesi gecis = new StokListesi();
            gecis.Show();
            this.Hide();

        }

    }
}
