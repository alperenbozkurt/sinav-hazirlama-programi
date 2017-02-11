using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace sinavHazirlamaProgrami
{
    public partial class bransEkle : Form
    {
        public bransEkle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            baglatistr bgl = new baglatistr();
            try
            {
                SqlConnection baglanti = new SqlConnection(bgl.baglan);
                SqlCommand komut = new SqlCommand("insert Branslar(Brans) values ('" + txtBrans.Text + "')", baglanti);

                baglanti.Open();

                komut.ExecuteNonQuery();

                baglanti.Close();
                MessageBox.Show(txtBrans.Text +" Başarıyla eklendi");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Source,"Hata Oldu");
            }

            SqlConnection bagla = new SqlConnection(bgl.baglan);
            DataTable Ktablo = new DataTable();
            SqlDataAdapter kdt = new SqlDataAdapter("Select * from Branslar", bagla);
            bagla.Open();
            kdt.Fill(Ktablo);
            dgvBrans.DataSource = Ktablo;
            bagla.Close();
            

        }

        private void bransEkle_Load(object sender, EventArgs e)
        {
            baglatistr bgl = new baglatistr();
            SqlConnection bagla = new SqlConnection(bgl.baglan);
            DataTable Ktablo = new DataTable();
            SqlDataAdapter kdt = new SqlDataAdapter("Select * from Branslar", bagla);
            bagla.Open();
            kdt.Fill(Ktablo);
            dgvBrans.DataSource = Ktablo;
            bagla.Close();
        }

    }
}
