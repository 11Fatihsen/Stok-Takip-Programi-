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
    public partial class Personel : Form
    {
        public Personel()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();

        public void Veridoldur()
        {
            SqlCommand cmd = new SqlCommand("Select  PiId as 'Id', PiAdSoyad as 'Ad Soyad',PiEposta as 'E-Posta', tbl_Departman.DepAd as 'Departman' " +
                "from tbl_PersonelIletisim inner join tbl_Departman on tbl_PersonelIletisim.PiDepartman=tbl_Departman.DepId;", bgl.baglanti());
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dataGridView1.DataSource = dt;


            bgl.baglanti().Close();
        }

        public void cmbyetkidoldur()
        {
            SqlCommand cmd = new SqlCommand("Select * from tbl_Departman", bgl.baglanti());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbyetki.Items.Add(dr[1]);
            }
            bgl.baglanti().Close();
        }

        void iptal()
        {
            txtadsoyad.Text = "";
            txteposta.Text = "";
            cmbyetki.Text = "";
          
        }
        private void Personel_Load(object sender, EventArgs e)
        {
            Veridoldur();
            cmbyetkidoldur();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            lblid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtadsoyad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txteposta.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmbyetki.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
        
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into tbl_PersonelIletisim(PiAdSoyad,PiEposta,PiDepartman) " +
               "values (@p1,@p2,@p3)", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", txtadsoyad.Text);
            cmd.Parameters.AddWithValue("@p2", txteposta.Text);
            cmd.Parameters.AddWithValue("@p3", cmbyetki.SelectedIndex + 1);
            cmd.ExecuteNonQuery();
            bgl.baglanti().Close();
            Veridoldur();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Delete from tbl_PersonelIletisim where PiId=@p1 and PiAdSoyad=@p2", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", lblid.Text);
            cmd.Parameters.AddWithValue("@p2", txtadsoyad.Text);
            cmd.ExecuteNonQuery();
            bgl.baglanti().Close();
            Veridoldur();
            iptal();
            MessageBox.Show("Personel Kaydı Silindi.", "Silme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update tbl_PersonelIletisim set PiAdSoyad=@p1,PiEposta=@p2,PiDepartman=@p3 where PiId=@p0", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p0", lblid.Text);
            cmd.Parameters.AddWithValue("@p1", txtadsoyad.Text);
            cmd.Parameters.AddWithValue("@p2", txteposta.Text);
            cmd.Parameters.AddWithValue("@p3", cmbyetki.SelectedIndex + 1);
            cmd.ExecuteNonQuery();
            bgl.baglanti().Close();
            Veridoldur();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            iptal();
        }
    }
}
