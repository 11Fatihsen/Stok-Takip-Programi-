using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakip
{
    public partial class StokRaporu : Form
    {
        public StokRaporu()
        {
            InitializeComponent();
        }

        private void StokRaporu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stokTakipDBDataSet1.tbl_StokTakip' table. You can move, or remove it, as needed.
            this.tbl_StokTakipTableAdapter.Fill(this.stokTakipDBDataSet1.tbl_StokTakip);

            this.reportViewer1.RefreshReport();
        }
    }
}
