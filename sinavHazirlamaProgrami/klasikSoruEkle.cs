﻿using System;
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
    public partial class klasikSoruEkle : Form
    {
        public klasikSoruEkle()
        {
            InitializeComponent();
        }

       


        private void button1_Click(object sender, EventArgs e)
        {
            baglatistr bgl = new baglatistr();
            try
            {
                SqlConnection baglanti = new SqlConnection(bgl.baglan);
                SqlCommand komut = new SqlCommand("insert KlasikSoru(Soru,Cevap,Sinif,Donem,Yazili,Ders_Id,Kolaylik) values ('"+txtSoru.Text+"','"+txtCevap.Text+"','"+Sinif+"','"+Donem+"','"+Yazili+"','"+(cmbDers.SelectedItem as Dersler).Id+"','"+Kolaylik+"')", baglanti);
                baglanti.Open();
                komut.ExecuteNonQuery();

                baglanti.Close();

                MessageBox.Show("Kayıt başarılı");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Source, "Kayıt Sırasında Hata Oluşdu");
            }
        }

        private void klasikSoruEkle_Load(object sender, EventArgs e)
        {
            baglatistr bgl = new baglatistr();

            List<Dersler> dersler = new List<Dersler>();

            try
            {
                SqlConnection baglanti = new SqlConnection(bgl.baglan);
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select Id,Ders,Brans_Id from Dersler", baglanti);
                SqlDataReader dr = komut.ExecuteReader();

                while (dr.Read())
                {
                    Dersler ders = new Dersler();

                    ders.Id = Convert.ToInt32(dr["Id"]);
                    ders.Ders = dr["Ders"].ToString();
                    ders.Brans_Id = Convert.ToInt32(dr["Brans_Id"]);
                    dersler.Add(ders);
                }

                baglanti.Close();
                cmbDers.DataSource = dersler;
                cmbDers.DisplayMember = "Ders";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Source, "Bağlantıda Hata Oluşdu");
            }

        }
        public string Kolaylik = "", Sinif = "",Donem = "",Yazili="";
        

        private void rbCokKolay_CheckedChanged(object sender, EventArgs e)
        {
            Kolaylik = rbCokKolay.Text;
        }

        private void rbKolay_CheckedChanged(object sender, EventArgs e)
        {
            Kolaylik = rbKolay.Text;
        }

        private void rbOrta_CheckedChanged(object sender, EventArgs e)
        {
            Kolaylik = rbOrta.Text;
        }

        private void rbZor_CheckedChanged(object sender, EventArgs e)
        {
            Kolaylik = rbZor.Text;
        }

        private void rbKazik_CheckedChanged(object sender, EventArgs e)
        {
            Kolaylik = rbCokZor.Text;
        }

//------------------------------------------------------------------------------------------
        private void rbDokuzuncuSinif_CheckedChanged(object sender, EventArgs e)
        {
            Sinif = rbDokuzuncuSinif.Text;
        }

        private void rbOnuncuSinif_CheckedChanged(object sender, EventArgs e)
        {
            Sinif = rbOnuncuSinif.Text;
        }

        private void rbonbirinciSinif_CheckedChanged(object sender, EventArgs e)
        {
            Sinif = rbonbirinciSinif.Text;
        }

        private void rbonikinciSinif_CheckedChanged(object sender, EventArgs e)
        {
            Sinif = rbonikinciSinif.Text;
        }
//----------------------------------DÖNEM------------------------------------------
        private void rbdonemBir_CheckedChanged(object sender, EventArgs e)
        {
            Donem = rbdonemBir.Text;
        }

        private void rbikinciDonem_CheckedChanged(object sender, EventArgs e)
        {
            Donem = rbikinciDonem.Text;
        }


        //--------------------------YAZILI-------------------------------------------
        private void rbYaziliBir_CheckedChanged(object sender, EventArgs e)
        {
            Yazili = rbYaziliBir.Text;
        }

        private void rbYaziliiki_CheckedChanged(object sender, EventArgs e)
        {
            Yazili = rbYaziliiki.Text;
        }

        private void rbYaziliuc_CheckedChanged(object sender, EventArgs e)
        {
            Yazili = rbYaziliuc.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtSoru.Text = "";
            txtCevap.Text = "";
            rbCokKolay.Checked = false;
            rbKolay.Checked = false;
            rbOrta.Checked = false;
            rbZor.Checked = false;
            rbCokZor.Checked = false;
            rbdonemBir.Checked = false;
            rbikinciDonem.Checked = false;
            rbDokuzuncuSinif.Checked = false;
            rbOnuncuSinif.Checked = false;
            rbonbirinciSinif.Checked = false;
            rbonikinciSinif.Checked = false;
            rbYaziliBir.Checked = false;
            rbYaziliiki.Checked = false;
            rbYaziliuc.Checked = false;

        }
    }
}
