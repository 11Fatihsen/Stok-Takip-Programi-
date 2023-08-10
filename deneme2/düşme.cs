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

namespace deneme2
{
    public partial class düşme : Form
    {
        public düşme()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-O55E6N8\\SQLEXPRESS;Initial Catalog=StokTakipVT;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand Komut = new SqlCommand("update ürün set adet = adet -'"+textBox2.Text+"' where id=' "+textBox1.Text+"'", baglan);
            //update TBLURUNLER set ADET = ADET - '" + textBox11.Text + "' where URUNID = '" + Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value) + "' "

            Komut.Parameters.AddWithValue("@p1", textBox1.Text);
            Komut.Parameters.AddWithValue("@p2", "-" + textBox2.Text);
            
            SqlCommand deneme=new SqlCommand("Select adet from ürün", baglan);
            SqlDataReader dr = deneme.ExecuteReader();
            while (dr.Read())
            {
                textBox3.Text = dr[0].ToString();
            }
            
            //if (textBox3.Text>0)
            {
              //  Komut.ExecuteNonQuery();
            }
            //else 
            {
              //  MessageBox.Show("Stoğunuzunda o kadar ürün yoktur.");
            }
            
            baglan.Close();
        }

        private void düşme_Load(object sender, EventArgs e)
        {

        }
    }
}
