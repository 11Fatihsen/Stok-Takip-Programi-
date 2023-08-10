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

namespace StokTakip
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();
        SqlCommand cmd;
        SqlDataReader dr;
        int hak = 3;

        private void Login_Load(object sender, EventArgs e)
        {
            DateTime Tarih = DateTime.Now;
            txtTarih.Text=(Tarih.ToString("D"));
          
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("Select * from tbl_Kullanicilar where KulKullaniciAd='" + txt_kullaniciadi.Text + "' and KulSifre='" + txt_sifre.Text + "'", bgl.baglanti()); //text formatında yazıcaksak tek tırnak koyuyorum
            dr = cmd.ExecuteReader();
            string yetki = "";

            while (dr.Read())
            {
                yetki = dr["KulYetki"].ToString();
            }
            if (yetki != "")
            {
                Anasayfa  gecis= new Anasayfa();
                this.Hide();
                Anasayfa.a_yetki = yetki;
                gecis.ShowDialog();

            }
            else
            {

                MessageBox.Show("Kullanıcı bilgileri hatalı!!!","Hatalı Giriş",MessageBoxButtons.OK,MessageBoxIcon.Error);
                if (hak > 0)
                {
                    hak -= 1;
                    

                }
                if (hak == 0)
                {

                    Application.Exit();
                }


            }
            bgl.baglanti().Close();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            while (txt_sifre.UseSystemPasswordChar = false)
            {
                if (txt_sifre.UseSystemPasswordChar = true)
                {
                    txt_sifre.UseSystemPasswordChar = false;
                }
                else
                {
                    txt_sifre.UseSystemPasswordChar = true;
                }
            }
         
        }

        private void txtTarih_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
