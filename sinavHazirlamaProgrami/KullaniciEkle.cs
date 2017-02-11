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
    public partial class KullaniciEkle : Form
    {
        public KullaniciEkle()
        {
            InitializeComponent();
        }

        private void KullaniciEkle_Load(object sender, EventArgs e)
        {
            baglatistr bgl = new baglatistr();

            List<Branslar> branslar = new List<Branslar>();

            try
            {
                SqlConnection baglanti = new SqlConnection(bgl.baglan);
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select Id,Brans from Branslar", baglanti);
                SqlDataReader dr = komut.ExecuteReader();

                while (dr.Read())
                {
                    Branslar brans = new Branslar();

                    brans.Id = Convert.ToInt32(dr["Id"]);
                    brans.Brans = dr["Brans"].ToString();

                    branslar.Add(brans);
                }

                baglanti.Close();
                cmbBrans.DataSource = branslar;
                cmbBrans.DisplayMember = "Brans";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Source, "Hata Oldu");
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglatistr bgl = new baglatistr();

            try
            {
                SqlConnection baglanti = new SqlConnection(bgl.baglan);
                SqlCommand komut = new SqlCommand("insert Kullanicilar values ('" + txtAdi.Text + "','" + txtSoyadi.Text + "','" + txtKullaniciAdi.Text + "','" + txtSifre.Text + "'," + (cmbBrans.SelectedItem as Branslar).Id + ")", baglanti);
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Başarılı Bir Şekilde Kayıt Oldu!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Hata Oluştu!");
            }
        }
    }
}
