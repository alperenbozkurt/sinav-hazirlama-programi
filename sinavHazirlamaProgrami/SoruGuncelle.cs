using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace sinavHazirlamaProgrami
{
    public partial class SoruGuncelle : Form
    {
        public SoruGuncelle()
        {
            InitializeComponent();
        }
        public static string soru = "", DCevap = "", YCevap1 = "", YCevap2 = "", YCevap3 = "", YCevap4 = "", Sinif = "", Donem = "", Yazili = "", kolaylik = "";
        public static string ksoru = "", kcevap = "", kSinif = "", kDonem = "", kYazili = "", kKolaylik = "";
        public static int id = 0, ders = 0;
        public static int kId = 0, kDersId = 0;
        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void SoruGuncelle_Load(object sender, EventArgs e)
        {
            baglatistr bgl = new baglatistr();
            SqlConnection bagla = new SqlConnection(bgl.baglan);
            DataTable Ktablo = new DataTable();
            DataTable Ttablo = new DataTable();
            SqlDataAdapter kdt = new SqlDataAdapter("Select * from KlasikSoru", bagla);
            SqlDataAdapter tdt = new SqlDataAdapter("Select * from TestSoru", bagla);
            bagla.Open();
            kdt.Fill(Ktablo);
            tdt.Fill(Ttablo);
            dgvKlasik.DataSource = Ktablo;
            dgvTest.DataSource = Ttablo;
            bagla.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SGTest sgt = new SGTest();
            dgvTest.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            id = Convert.ToInt32(dgvTest.CurrentRow.Cells[0].Value);
            soru = dgvTest.CurrentRow.Cells[1].Value.ToString();
            DCevap = dgvTest.CurrentRow.Cells[2].Value.ToString();
            YCevap1 = dgvTest.CurrentRow.Cells[3].Value.ToString();
            YCevap2 = dgvTest.CurrentRow.Cells[4].Value.ToString();
            YCevap3 = dgvTest.CurrentRow.Cells[5].Value.ToString();
            YCevap4 = dgvTest.CurrentRow.Cells[6].Value.ToString();
            Sinif = dgvTest.CurrentRow.Cells[7].Value.ToString();
            Donem = dgvTest.CurrentRow.Cells[8].Value.ToString();
            Yazili = dgvTest.CurrentRow.Cells[9].Value.ToString();
            ders = Convert.ToInt32(dgvTest.CurrentRow.Cells[10].Value);
            kolaylik = dgvTest.CurrentRow.Cells[11].Value.ToString();
            sgt.Show();
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SGKlasik sgk = new SGKlasik();
            dgvKlasik.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            kId = Convert.ToInt32(dgvKlasik.CurrentRow.Cells[0].Value);
            ksoru = dgvKlasik.CurrentRow.Cells[1].Value.ToString();
            kcevap = dgvKlasik.CurrentRow.Cells[2].Value.ToString();
            kSinif = dgvKlasik.CurrentRow.Cells[3].Value.ToString();
            kDonem = dgvKlasik.CurrentRow.Cells[4].Value.ToString();
            kYazili = dgvKlasik.CurrentRow.Cells[5].Value.ToString();
            kDersId = Convert.ToInt32(dgvKlasik.CurrentRow.Cells[6].Value);
            kKolaylik = dgvKlasik.CurrentRow.Cells[7].Value.ToString();
            sgk.Show();
        }
    }
}
