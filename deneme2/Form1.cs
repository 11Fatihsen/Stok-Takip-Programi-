using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deneme2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-O55E6N8\\SQLEXPRESS;Initial Catalog=StokTakipVT;Integrated Security=True");
        
        private void Form1_Load(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand cmd = new SqlCommand("Select * from imagedeneme",baglan);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dataGridView1.DataSource = dt;
            DateTime tarih = DateTime.Now;
            textBox1.Text=(tarih.ToString("d"));

            baglan.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select * from imagedeneme where id='" + int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString())+"'",baglan);
            SqlDataReader dr= komut.ExecuteReader();
            if (dr.Read())
            {
                if (dr["images"]!=null)
                {
                    byte[] resim = new byte[0];
                    resim = (byte[])dr["images"];
                    MemoryStream memoryStream= new MemoryStream(resim);
                    pictureBox1.Image=Image.FromStream(memoryStream);
                    dr.Close();
                    komut.Dispose();
                    baglan.Close();

                }
            }
            baglan.Close();
        }
    }
}
