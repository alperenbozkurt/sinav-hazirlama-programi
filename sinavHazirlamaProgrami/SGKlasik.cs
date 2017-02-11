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
    public partial class SGKlasik : Form
    {
        public SGKlasik()
        {
            InitializeComponent();
        }
        public string Kolaylik = "", Sinif = "", Donem = "", Yazili = "";
        private void SGKlasik_Load(object sender, EventArgs e)
        {
            txtSoru.Text = SoruGuncelle.ksoru;
            txtCevap.Text = SoruGuncelle.kcevap;
            //--------------------------Kolaylik------------------
            if (rbCokKolay.Text == SoruGuncelle.kKolaylik)
            {
                rbCokKolay.Checked = true;
            }
            else if (rbKolay.Text == SoruGuncelle.kKolaylik)
            {
                rbKolay.Checked = true;
            }
            else if (rbOrta.Text == SoruGuncelle.kKolaylik)
            {
                rbOrta.Checked = true;
            }
            else if (rbZor.Text == SoruGuncelle.kKolaylik)
            {
                rbZor.Checked = true;
            }
            else
            {
                rbCokZor.Checked = true;
            }
            //-----------------Sinif----------------------------------
            if (rbDokuzuncuSinif.Text == SoruGuncelle.kSinif)
            {
                rbDokuzuncuSinif.Checked = true;
            }
            else if (rbOnuncuSinif.Text == SoruGuncelle.kSinif)
            {
                rbOnuncuSinif.Checked = true;
            }
            else if (rbonbirinciSinif.Text == SoruGuncelle.kSinif)
            {
                rbonbirinciSinif.Checked = true;
            }
            else
            {
                rbonikinciSinif.Checked = true;
            }
            //-----------------------Dönem--------------------------
            if (rbdonemBir.Text == SoruGuncelle.kDonem)
            {
                rbdonemBir.Checked = true;
            }
            else
            {
                rbikinciDonem.Checked = true;
            }
            //------------------Yazilı-----------------------------
            if (rbYaziliBir.Text == SoruGuncelle.kYazili)
            {
                rbYaziliBir.Checked = true;
            }
            else if (rbYaziliiki.Text == SoruGuncelle.kYazili)
            {
                rbYaziliiki.Checked = true;
            }
            else
            {
                rbYaziliuc.Checked = true;
            }
            //--------------------------------------
            baglatistr bgl = new baglatistr();
            List<Dersler> dersler = new List<Dersler>();
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


            cmbDers.DataSource = dersler;
            cmbDers.DisplayMember = "Ders";

            baglanti.Close();
            cmbDers.SelectedIndex = Convert.ToInt32(SoruGuncelle.kDersId) - 1;
            Kolaylik = SoruGuncelle.kKolaylik;
            Sinif = SoruGuncelle.kSinif;
            Donem = SoruGuncelle.kDonem;
            Yazili = SoruGuncelle.kYazili;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglatistr bgl = new baglatistr();
            try
            {
                SqlConnection baglanti = new SqlConnection(bgl.baglan);
                //"UPDATE TestSoru SET Soru='" + txtSoru.Text + "' , DCevap'" + txtDCevap.Text + "' , YCevap1='" + txtYCevap1.Text + "' , YCevap2='" + txtYCevap2.Text + "' or YCevap3='" + txtYCevap3.Text + "' or YCevap4='" + txtYCevap4.Text + "' or Sinif='" + Sinif + "' or Donem='" + Donem + "' or Yazili='" + Yazili + "' or Ders_Id=" + (cmbDers.SelectedItem as Dersler).Id + " orKolaylik'" + Kolaylik + "' where Id="+SoruGuncelle.id+" ", baglanti
                SqlCommand komut = new SqlCommand("UPDATE KlasikSoru SET  Soru='" + txtSoru.Text + "', Cevap='" + txtCevap.Text + "', Sinif='" + Sinif + "' , Donem='" + Donem + "' , Yazili='" + Yazili + "' , Ders_Id=" + Convert.ToInt32((cmbDers.SelectedItem as Dersler).Id) + ", Kolaylik ='" + Kolaylik + "' WHERE Id=" + SoruGuncelle.kId, baglanti);

                baglanti.Open();
                komut.ExecuteNonQuery();

                baglanti.Close();

                MessageBox.Show("Güncelleme başarılı");


                SqlConnection bagla = new SqlConnection(bgl.baglan);
                DataTable Ktablo = new DataTable();
                SqlDataAdapter kdt = new SqlDataAdapter("Select * from KlasikSoru", bagla);
                bagla.Open();
                kdt.Fill(Ktablo);
                SoruGuncelle.dgvKlasik.DataSource = Ktablo;
                bagla.Close();
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Kayıt Sırasında Hata Oluşdu");
            }
           

        }
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

        //--------------------------------Sınıf----------------------------------
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
        //-----------------------------------Dönem---------------------------------------------

        private void rbdonemBir_CheckedChanged(object sender, EventArgs e)
        {
            Donem = rbdonemBir.Text;
        }

        private void rbikinciDonem_CheckedChanged(object sender, EventArgs e)
        {
            Donem = rbikinciDonem.Text;
        }
        //---------------------------------------Yazılı----------------------------------------

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

    }
}
