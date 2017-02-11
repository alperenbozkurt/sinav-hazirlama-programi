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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int k = 0;
        private void txtKullaniciAdi_Click(object sender, EventArgs e)
        {
            k++;
            if (k==1)
            {
                txtKullaniciAdi.Text = "";
            }
        }
        

        int s;
        private void txtSifre_Click(object sender, EventArgs e)
        {
            s++;
            if (s == 1)
            {
                txtSifre.Text = "";
            }
        }
        public static string girisYapanKullaniciAdi = "";
        public static string girisYapanKullaniciSoyadi = "";
        public static bool yetki;
        private void btnGiris_Click(object sender, EventArgs e)
        {

            if (txtSifre.Text == "" || txtKullaniciAdi.Text == "")
            {
                MessageBox.Show("Kullanıcı adını veya şifrenizi yanlış girdiniz.. Lütfen tekrar deneyiniz...","Hata");
                return;
                
            }
            else
            {

                if (txtKullaniciAdi.Text == "Admin" && txtSifre.Text == "Admin")
                {
                    MessageBox.Show("Admin Girişi");
                    yetki = true;
                    frmAnaEkran frmanaekran = new frmAnaEkran();
                    frmanaekran.Show();
                    this.Hide();
                    return;
                }

            }

            baglatistr bgl = new baglatistr();
            SqlConnection baglanti = new SqlConnection(bgl.baglan);
            SqlCommand komut = new SqlCommand("select Id,Adi,Soyadi,Sifre,KullaniciAdi,Brans_Id from Kullanicilar", baglanti);
            baglanti.Open();
            SqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                Kullanicilar kullanici = new Kullanicilar();
                kullanici.Id = Convert.ToInt32(dr["Id"]);
                kullanici.Adi = dr["Adi"].ToString();
                kullanici.Soyadi = dr["Soyadi"].ToString();
                kullanici.Sifre = dr["Sifre"].ToString();
                kullanici.KullaniciAdi = dr["KullaniciAdi"].ToString();
                kullanici.Brans_Id = Convert.ToInt32(dr["Brans_Id"]);

                if (kullanici.KullaniciAdi == txtKullaniciAdi.Text)
                {
                    if (kullanici.Sifre == txtSifre.Text)
                    {
                        MessageBox.Show("Kullanici Girişi");
                        yetki = false;
                        girisYapanKullaniciAdi = kullanici.Adi;
                        girisYapanKullaniciSoyadi = kullanici.Soyadi;
                        frmAnaEkran frmanaekran = new frmAnaEkran();
                        frmanaekran.Show();

                        this.Hide();
                        baglanti.Close();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı adını veya şifrenizi yanlış girdiniz.. Lütfen tekrar deneyiniz...", "Hata");
                        baglanti.Close();
                        return;

                    }
                }
                //else
                //{
                //    MessageBox.Show("Kullanıcı Adı veya Şifre yanlış.");
                //}
            }
            MessageBox.Show("Kullanıcı adını veya şifrenizi yanlış girdiniz.. Lütfen tekrar deneyiniz...", "Hata");
            baglanti.Close();

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
