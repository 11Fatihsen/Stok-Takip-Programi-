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
using System.IO;
using System.Data.SqlClient;
using System.Runtime.Remoting;

namespace deneme2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-O55E6N8\\SQLEXPRESS;Initial Catalog=StokTakipVT;Integrated Security=True");
        string imagepath;
        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglan.Open();
            openFileDialog1.Title = "Resim Seç";
            openFileDialog1.Filter = "Jpg Dosyaları(*.jpg)|*.jpg| Jpeg Dosyaları(*.jpeg)|*.jpeg| Png Dosyaları(*.png)|*.png| Gif Dosyaları(*.gif)|*.gif| Tif Dosyaları(*.tif)|*.tif";
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                pictureBox1.Image=Image.FromFile(openFileDialog1.FileName);
                imagepath= openFileDialog1.FileName;
            }
            baglan.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileStream fileStream = new FileStream(imagepath, FileMode.Open, FileAccess.Read);
            BinaryReader binaryReader = new BinaryReader(fileStream);
            byte[] resim = binaryReader.ReadBytes((int)fileStream.Length);
            binaryReader.Close();
            fileStream.Close();


            baglan.Open();
            SqlCommand cmd = new SqlCommand("insert into imagedeneme(images) values(@images)", baglan);
            cmd.Parameters.Add("@images",SqlDbType.Image,resim.Length).Value=resim;
            cmd.ExecuteNonQuery();

            baglan.Close();
            MessageBox.Show("Kayıt Eklendi","Ksyıt",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 geecis= new Form1();
            geecis.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }
    }
}
