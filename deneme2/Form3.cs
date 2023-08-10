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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-O55E6N8\\SQLEXPRESS;Initial Catalog=StokTakipVT;Integrated Security=True");

        private void Form3_Load(object sender, EventArgs e)
        {
            listeleme();
            baglan.Open();
            SqlCommand cmd = new SqlCommand("Select * from tbl1",baglan);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[1]);
            }
            baglan.Close();
        }
        public void listeleme()
        {
            baglan.Open();
            SqlCommand cmd = new SqlCommand("Select tbl2.ad, tbl1.kategori from tbl1 inner join tbl2  on  tbl1.id = tbl2.kategori;", baglan);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dataGridView1.DataSource = dt;

            baglan.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand Komut = new SqlCommand("insert into tbl2(kategori,ad) values (@p1,@p2) ",baglan);                                                                     //Komut sınıfı türettik  "@p1 ve @p2" bizim parametrelerimiz.
            
            Komut.Parameters.AddWithValue("@p1", comboBox1.SelectedIndex +1);
            Komut.Parameters.AddWithValue("@p2", textBox1.Text);

            Komut.ExecuteNonQuery();
            baglan.Close();
            listeleme();
        }
    }
}
