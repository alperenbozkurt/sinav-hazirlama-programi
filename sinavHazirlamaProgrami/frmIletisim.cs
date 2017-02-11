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
    public partial class frmIletisim : Form
    {
        public frmIletisim()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglatistr bgl = new baglatistr();

            try
            {
                SqlConnection Baglanti = new SqlConnection(bgl.baglan);
                string cumle = rchMesaj.Text + "\n ----------- \n" + Form1.girisYapanKullaniciAdi + " " + Form1.girisYapanKullaniciSoyadi + " tarafından " + DateTime.Now.Hour + ":" + DateTime.Now.Minute + " | " + DateTime.Now.Day + "." + DateTime.Now.Month + "." + DateTime.Now.Year + " tarihinde gönderildi.";
                SqlCommand Komut = new SqlCommand("insert Iletisim values('" + cumle + "','" + txtEPosta.Text + "')", Baglanti);
                Baglanti.Open();
                Komut.ExecuteNonQuery();
                Baglanti.Close();
                MessageBox.Show("Başarıyla Gönderildi");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Source, "Hata Oldu");
            }




        }

        private void İletişim_Load(object sender, EventArgs e)
        {
        }
    }
}