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
    public partial class ReyonRapor : Form
    {
        public ReyonRapor()
        {
            InitializeComponent();
        }

        private void ReyonRapor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stokTakipDBDataSet.tbl_ReyonGonderilen' table. You can move, or remove it, as needed.
            this.tbl_ReyonGonderilenTableAdapter.Fill(this.stokTakipDBDataSet.tbl_ReyonGonderilen);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
