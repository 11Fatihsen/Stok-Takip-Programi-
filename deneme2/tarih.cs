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

namespace deneme2
{
    public partial class tarih : Form
    {
        public tarih()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-O55E6N8\\SQLEXPRESS;Initial Catalog=StokTakipVT;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime tarih = DateTime.Now;
            baglan.Open();
            SqlCommand cmd = new SqlCommand("insert into tarih(tarih) values (@p1)", baglan);
            cmd.Parameters.Add("@p1",tarih.ToString("d"));
            cmd.ExecuteNonQuery();
            baglan.Close();
        }

        private void tarih_Load(object sender, EventArgs e)
        {

        }
    }
}
