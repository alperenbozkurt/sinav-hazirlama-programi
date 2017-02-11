using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sinavHazirlamaProgrami
{
    public partial class ailetisim : Form
    {
        public ailetisim()
        {
            InitializeComponent();
        }

        private void ailetisim_Load(object sender, EventArgs e)
        {
            baglatistr bgl = new baglatistr();
            SqlConnection bagla = new SqlConnection(bgl.baglan);
            DataTable tablo = new DataTable();
            SqlDataAdapter dt = new SqlDataAdapter("Select * from Iletisim", bagla);
            bagla.Open();
            dt.Fill(tablo);
            dgvMesajlar.DataSource = tablo;
            bagla.Close();
        }
    }
}
