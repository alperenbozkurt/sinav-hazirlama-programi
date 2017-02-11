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
    public partial class SGTest : Form
    {
        public SGTest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglatistr bgl = new baglatistr();
            try
            {
                SqlConnection baglanti = new SqlConnection(bgl.baglan);
                //"UPDATE TestSoru SET Soru='" + txtSoru.Text + "' , DCevap'" + txtDCevap.Text + "' , YCevap1='" + txtYCevap1.Text + "' , YCevap2='" + txtYCevap2.Text + "' or YCevap3='" + txtYCevap3.Text + "' or YCevap4='" + txtYCevap4.Text + "' or Sinif='" + Sinif + "' or Donem='" + Donem + "' or Yazili='" + Yazili + "' or Ders_Id=" + (cmbDers.SelectedItem as Dersler).Id + " orKolaylik'" + Kolaylik + "' where Id="+SoruGuncelle.id+" ", baglanti
                SqlCommand komut = new SqlCommand("UPDATE TestSoru SET  Soru='" + txtSoru.Text + "', DCevap='" + txtDCevap.Text + "', YCevap1='" + txtYCevap1.Text + "' , YCevap2='" + txtYCevap2.Text + "' , YCevap3='" + txtYCevap3.Text + "' , YCevap4='" + txtYCevap4.Text + "' , Sinif='" + Sinif + "' , Donem='" + Donem + "' , Yazili='" + Yazili + "' , Ders_Id=" + Convert.ToInt32((cmbDers.SelectedItem as Dersler).Id) + ", Kolaylik ='" + Kolaylik + "' WHERE Id=" + SoruGuncelle.id, baglanti);
                
                baglanti.Open();
                komut.ExecuteNonQuery();

                baglanti.Close();

                MessageBox.Show("Güncelleme başarılı");


                SqlConnection bagla = new SqlConnection(bgl.baglan);
                DataTable Ttablo = new DataTable();
                SqlDataAdapter tdt = new SqlDataAdapter("Select * from TestSoru", bagla);
                bagla.Open();
                tdt.Fill(Ttablo);
                SoruGuncelle.dgvTest.DataSource = Ttablo;
                bagla.Close();
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Kayıt Sırasında Hata Oluşdu");
            }
        }
        public string Kolaylik = "", Sinif = "", Donem = "", Yazili = "";
        //-----------------------------Kolaylık-----------------------------------------
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

        private void SGTest_Load(object sender, EventArgs e)
        {
            txtSoru.Text = SoruGuncelle.soru.ToString();
            txtDCevap.Text = SoruGuncelle.DCevap.ToString();
            txtYCevap1.Text = SoruGuncelle.YCevap1;
            txtYCevap2.Text = SoruGuncelle.YCevap2;
            txtYCevap3.Text = SoruGuncelle.YCevap3;
            txtYCevap4.Text = SoruGuncelle.YCevap4;
            //--------------------------------------------
            if (rbCokKolay.Text==SoruGuncelle.kolaylik)
            {
                rbCokKolay.Checked=true;
            }
            else if (rbKolay.Text==SoruGuncelle.kolaylik)
            {
                rbKolay.Checked = true;
            }
            else if (rbOrta.Text==SoruGuncelle.kolaylik)
            {
                rbOrta.Checked = true;
            }
            else if (rbZor.Text==SoruGuncelle.kolaylik)
            {
                rbZor.Checked = true;
            }
            else 
            {
                rbCokZor.Checked = true;
            }
            //---------------------------------------------------
            if (rbDokuzuncuSinif.Text==SoruGuncelle.Sinif)
            {
                rbDokuzuncuSinif.Checked = true;
            }
            else if (rbOnuncuSinif.Text==SoruGuncelle.Sinif)
            {
                rbOnuncuSinif.Checked = true;
            }
            else if (rbonbirinciSinif.Text==SoruGuncelle.Sinif)
            {
                rbonbirinciSinif.Checked = true;
            }
            else 
            {
                rbonikinciSinif.Checked = true;
            }
            //-------------------------------------------------
            if (rbdonemBir.Text==SoruGuncelle.Donem)
            {
                rbdonemBir.Checked = true;
            }
            else
            {
                rbikinciDonem.Checked = true;
            }
            //-----------------------------------------------
            if (rbYaziliBir.Text==SoruGuncelle.Yazili)
            {
                rbYaziliBir.Checked = true;
            }
            else if (rbYaziliiki.Text==SoruGuncelle.Yazili)
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
            cmbDers.SelectedIndex = Convert.ToInt32(SoruGuncelle.ders) - 1;
            Kolaylik = SoruGuncelle.kolaylik;
            Sinif = SoruGuncelle.Sinif;
            Donem = SoruGuncelle.Donem;
            Yazili = SoruGuncelle.Yazili;
        }
    }
}
