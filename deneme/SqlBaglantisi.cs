using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip
{
    class SqlBaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-O55E6N8\\SQLEXPRESS;Initial Catalog=StokTakipVT;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
        
    }
}
