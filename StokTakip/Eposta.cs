using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;

namespace StokTakip
{
    public partial class Eposta : Form
    {
        public Eposta()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl=new SqlBaglantisi();

        void CmbGondericiDoldur()
        {
            SqlCommand cmd = new SqlCommand("Select KulAdSoyad from tbl_Kullanicilar", bgl.baglanti());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbGonderici.Items.Add(dr[0].ToString());
            }
            bgl.baglanti().Close();
        }
        void CmbAlıcıDoldur()
        {
            SqlCommand cmd = new SqlCommand("Select PiEposta from tbl_PersonelIletisim", bgl.baglanti());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbAlıcı.Items.Add(dr[0].ToString());
            }
            bgl.baglanti().Close();
        }

        private void btnDosya_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "İleti için Ek Dosya Seçebilirsiniz.";
            ofd.ShowDialog();
            txtdosyaYolu.Text = ofd.FileName;
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            MailMessage mesajım = new MailMessage();
            SmtpClient istemci = new SmtpClient();
            istemci.Credentials = new System.Net.NetworkCredential("Collection11_Depo@outlook.com", "******");
            istemci.Port = 587;
            istemci.Host = "smtp.outlook.com";
            istemci.EnableSsl = true;
            mesajım.To.Add(cmbAlıcı.Text);
            mesajım.From = new MailAddress("Collection11_Depo@outlook.com", cmbGonderici.Text);
            mesajım.Subject = txtIcerikBasligi.Text;
            mesajım.Body = richtxtIcerik.Text;
            if (txtdosyaYolu.Text != null)
            {
                mesajım.Attachments.Add(new Attachment(txtdosyaYolu.Text));
            }
            istemci.Send(mesajım);
        }

        private void Eposta_Load(object sender, EventArgs e)
        {
            CmbGondericiDoldur();
            CmbAlıcıDoldur();
        }
    }
}
