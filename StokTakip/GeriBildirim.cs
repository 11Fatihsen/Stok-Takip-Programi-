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

namespace StokTakip
{
    public partial class GeriBildirim : Form
    {
        public GeriBildirim()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MailMessage mesajım = new MailMessage();
            SmtpClient istemci = new SmtpClient();
            istemci.Credentials = new System.Net.NetworkCredential("Collection11_Depo@outlook.com", "******");
            istemci.Port = 587;
            istemci.Host = "smtp.outlook.com";
            istemci.EnableSsl = true;
            mesajım.To.Add("FS_Destek@outlook.com");
            mesajım.From = new MailAddress("Collection11_Depo@outlook.com", "Collection11");
            mesajım.Subject = cmbIcerikTuru.Text;
            mesajım.Body = rchMesaj.Text;
            istemci.Send(mesajım);
        }

        private void GeriBildirim_Load(object sender, EventArgs e)
        {

        }
    }
}
