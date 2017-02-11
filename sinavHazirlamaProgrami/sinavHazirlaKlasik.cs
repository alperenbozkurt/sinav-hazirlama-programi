using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace sinavHazirlamaProgrami
{
    public partial class sinavHazirla : Form
    {
        public sinavHazirla()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                List<KlasikSoru> Sorular = new List<KlasikSoru>();
                List<TestSorusu> SorularTest = new List<TestSorusu>();




                int TCK = Convert.ToInt32(nmcCKYTest.Value), TK = Convert.ToInt32(nmcKLYTest.Value), TO = Convert.ToInt32(nmcORTATest.Value), TZ = Convert.ToInt32(nmcZORTest.Value), TCZ = Convert.ToInt32(nmcCOKZORTest.Value), KCK = Convert.ToInt32(nmcCokkolay.Value), KK = Convert.ToInt32(nmcKolay.Value), KO = Convert.ToInt32(nmcOrta.Value), KZ = Convert.ToInt32(nmcZor.Value), KCZ = Convert.ToInt32(nmcCokZor.Value);
                baglatistr bgl = new baglatistr();
                int toplamSoruSayisi = KCK + KK + KO + KZ + KCZ + TCK + TK + TO + TZ + TCZ;
                Random rnd = new Random();
                for (int i = 0, c = 0; i < toplamSoruSayisi; i++, c++)
                {
                    if (KCK > 0)
                    {
                        List<KlasikSoru> klasikCokkolaysorular = new List<KlasikSoru>();
                        SqlConnection baglanti = new SqlConnection(bgl.baglan);
                        baglanti.Open();
                        SqlCommand komut = new SqlCommand("Select * from KlasikSoru where Yazili='" + Yazili + "' and Donem='" + Donem + "' and Ders_Id=" + (cmbDers.SelectedItem as Dersler).Id + " and Kolaylik='Çok Kolay'", baglanti);
                        SqlDataReader dr = komut.ExecuteReader();
                        while (dr.Read())
                        {
                            KlasikSoru ksoru = new KlasikSoru();

                            ksoru.Id = Convert.ToInt32(dr["Id"]);
                            ksoru.Soru = dr["Soru"].ToString();
                            ksoru.Cevap = dr["Cevap"].ToString();
                            ksoru.Sinif = dr["Sinif"].ToString();
                            ksoru.Donem = dr["Donem"].ToString();
                            ksoru.Yazili = dr["Yazili"].ToString();
                            ksoru.Ders_Id = Convert.ToInt32(dr["Ders_Id"]);
                            ksoru.Kolaylik = dr["Kolaylik"].ToString();
                            klasikCokkolaysorular.Add(ksoru);
                        }
                        baglanti.Close();
                        int rastgeleSayi = rnd.Next(0, klasikCokkolaysorular.Count);
                        if (Sorular.Contains(klasikCokkolaysorular[rastgeleSayi]))
                        {
                            i--;
                            if (c >= 100)
                            {
                                MessageBox.Show("Soru Çekereken Hata Oluştu.Lütfen Bankadaki Soru Sayısını Kontrol Ediniz!");
                                break;
                            }
                        }
                        else
                        {
                            Sorular.Add(klasikCokkolaysorular[rastgeleSayi]);
                            KCK--;
                        }

                    }
                    //Kolaylarrrrr
                    else if (KK > 0)
                    {
                        List<KlasikSoru> klasikkolaysorular = new List<KlasikSoru>();
                        SqlConnection baglanti = new SqlConnection(bgl.baglan);
                        baglanti.Open();
                        SqlCommand komut = new SqlCommand("Select * from KlasikSoru where Sinif='" + Sinif + "' and Yazili='" + Yazili + "' and Donem='" + Donem + "'and Ders_Id=" + (cmbDers.SelectedItem as Dersler).Id + " and Kolaylik='Kolay'", baglanti);
                        SqlDataReader dr = komut.ExecuteReader();
                        while (dr.Read())
                        {
                            KlasikSoru ksoru = new KlasikSoru();

                            ksoru.Id = Convert.ToInt32(dr["Id"]);
                            ksoru.Soru = dr["Soru"].ToString();
                            ksoru.Cevap = dr["Cevap"].ToString();
                            ksoru.Sinif = dr["Sinif"].ToString();
                            ksoru.Donem = dr["Donem"].ToString();
                            ksoru.Yazili = dr["Yazili"].ToString();
                            ksoru.Ders_Id = Convert.ToInt32(dr["Ders_Id"]);
                            ksoru.Kolaylik = dr["Kolaylik"].ToString();
                            klasikkolaysorular.Add(ksoru);
                        }
                        baglanti.Close();
                        int rastgeleSayi = rnd.Next(0, klasikkolaysorular.Count);
                        if (Sorular.Contains(klasikkolaysorular[rastgeleSayi]))
                        {
                            i--;
                            if (c >= 100)
                            {
                                MessageBox.Show("Soru Çekereken Hata Oluştu.Lütfen Bankadaki Soru Sayısını Kontrol Ediniz!");
                                break;
                            }
                        }
                        else
                        {
                            Sorular.Add(klasikkolaysorular[rastgeleSayi]);
                            KK--;
                        }

                    }
                    //Ortalarrrrrr
                    else if (KO > 0)
                    {
                        List<KlasikSoru> klasikOrtasorular = new List<KlasikSoru>();
                        SqlConnection baglanti = new SqlConnection(bgl.baglan);
                        baglanti.Open();
                        SqlCommand komut = new SqlCommand("Select * from KlasikSoru where Sinif='" + Sinif + "' and  Yazili='" + Yazili + "' and Donem='" + Donem + "'and Ders_Id=" + (cmbDers.SelectedItem as Dersler).Id + " and Kolaylik='Orta'", baglanti);
                        SqlDataReader dr = komut.ExecuteReader();
                        while (dr.Read())
                        {
                            KlasikSoru ksoru = new KlasikSoru();

                            ksoru.Id = Convert.ToInt32(dr["Id"]);
                            ksoru.Soru = dr["Soru"].ToString();
                            ksoru.Cevap = dr["Cevap"].ToString();
                            ksoru.Sinif = dr["Sinif"].ToString();
                            ksoru.Donem = dr["Donem"].ToString();
                            ksoru.Yazili = dr["Yazili"].ToString();
                            ksoru.Ders_Id = Convert.ToInt32(dr["Ders_Id"]);
                            ksoru.Kolaylik = dr["Kolaylik"].ToString();
                            klasikOrtasorular.Add(ksoru);
                        }
                        baglanti.Close();
                        int rastgeleSayi = rnd.Next(0, klasikOrtasorular.Count);
                        if (Sorular.Contains(klasikOrtasorular[rastgeleSayi]))
                        {
                            i--;
                            if (c >= 100)
                            {
                                MessageBox.Show("Soru Çekereken Hata Oluştu.Lütfen Bankadaki Soru Sayısını Kontrol Ediniz!");
                                break;
                            }
                        }
                        else
                        {
                            Sorular.Add(klasikOrtasorular[rastgeleSayi]);
                            KO--;
                        }
                    }
                    //Zorlarrrrrrr
                    else if (KZ > 0)
                    {
                        List<KlasikSoru> klasikZorsorular = new List<KlasikSoru>();
                        SqlConnection baglanti = new SqlConnection(bgl.baglan);
                        baglanti.Open();
                        SqlCommand komut = new SqlCommand("Select * from KlasikSoru where Sinif='" + Sinif + "' and Yazili='" + Yazili + "' and Donem='" + Donem + "'and Ders_Id=" + (cmbDers.SelectedItem as Dersler).Id + " and Kolaylik='Zor'", baglanti);
                        SqlDataReader dr = komut.ExecuteReader();
                        while (dr.Read())
                        {
                            KlasikSoru ksoru = new KlasikSoru();

                            ksoru.Id = Convert.ToInt32(dr["Id"]);
                            ksoru.Soru = dr["Soru"].ToString();
                            ksoru.Cevap = dr["Cevap"].ToString();
                            ksoru.Sinif = dr["Sinif"].ToString();
                            ksoru.Donem = dr["Donem"].ToString();
                            ksoru.Yazili = dr["Yazili"].ToString();
                            ksoru.Ders_Id = Convert.ToInt32(dr["Ders_Id"]);
                            ksoru.Kolaylik = dr["Kolaylik"].ToString();
                            klasikZorsorular.Add(ksoru);
                        }
                        baglanti.Close();
                        int rastgeleSayi = rnd.Next(0, klasikZorsorular.Count);
                        if (Sorular.Contains(klasikZorsorular[rastgeleSayi]))
                        {
                            i--;
                            if (c >= 100)
                            {
                                MessageBox.Show("Soru Çekereken Hata Oluştu.Lütfen Bankadaki Soru Sayısını Kontrol Ediniz!");
                                break;
                            }
                        }
                        else
                        {
                            Sorular.Add(klasikZorsorular[rastgeleSayi]);
                            KZ--;
                        }
                    }
                    //CokZorrr
                    else if (KCZ > 0)
                    {
                        List<KlasikSoru> klasikCokZorsorular = new List<KlasikSoru>();
                        SqlConnection baglanti = new SqlConnection(bgl.baglan);
                        baglanti.Open();
                        SqlCommand komut = new SqlCommand("Select * from KlasikSoru where Sinif='" + Sinif + "' and Yazili='" + Yazili + "' and Donem='" + Donem + "'and Ders_Id=" + (cmbDers.SelectedItem as Dersler).Id + " and Kolaylik='Çok Zor'", baglanti);
                        SqlDataReader dr = komut.ExecuteReader();
                        while (dr.Read())
                        {
                            KlasikSoru ksoru = new KlasikSoru();

                            ksoru.Id = Convert.ToInt32(dr["Id"]);
                            ksoru.Soru = dr["Soru"].ToString();
                            ksoru.Cevap = dr["Cevap"].ToString();
                            ksoru.Sinif = dr["Sinif"].ToString();
                            ksoru.Donem = dr["Donem"].ToString();
                            ksoru.Yazili = dr["Yazili"].ToString();
                            ksoru.Ders_Id = Convert.ToInt32(dr["Ders_Id"]);
                            ksoru.Kolaylik = dr["Kolaylik"].ToString();
                            klasikCokZorsorular.Add(ksoru);
                        }
                        baglanti.Close();
                        int rastgeleSayi = rnd.Next(0, klasikCokZorsorular.Count);
                        if (Sorular.Contains(klasikCokZorsorular[rastgeleSayi]))
                        {
                            i--;
                            if (c >= 100)
                            {
                                MessageBox.Show("Soru Çekereken Hata Oluştu.Lütfen Bankadaki Soru Sayısını Kontrol Ediniz!");
                                break;
                            }
                        }
                        else
                        {
                            Sorular.Add(klasikCokZorsorular[rastgeleSayi]);
                            KCZ--;
                        }
                    }
                    //Testlerrrrr
                    //Çok Kolayyy
                    else if (TCK > 0)
                    {
                        List<TestSorusu> TestCokKolaysorular = new List<TestSorusu>();
                        SqlConnection baglanti = new SqlConnection(bgl.baglan);
                        baglanti.Open();
                        SqlCommand komut = new SqlCommand("Select * from TestSoru  where Sinif='" + Sinif + "' and Yazili='" + Yazili + "' and Donem='" + Donem + "'and Ders_Id=" + (cmbDers.SelectedItem as Dersler).Id + " and Kolaylik='Çok Kolay'", baglanti);
                        SqlDataReader dr = komut.ExecuteReader();
                        while (dr.Read())
                        {
                            TestSorusu Tsoru = new TestSorusu();
                            Tsoru.Id = Convert.ToInt32(dr["Id"]);
                            Tsoru.Soru = dr["Soru"].ToString();
                            Tsoru.DCevap = dr["DCevap"].ToString();
                            Tsoru.YCevap1 = dr["YCevap1"].ToString();
                            Tsoru.YCevap2 = dr["YCevap2"].ToString();
                            Tsoru.YCevap3 = dr["YCevap3"].ToString();
                            Tsoru.Ycevap4 = dr["YCevap4"].ToString();
                            Tsoru.Sinif = dr["Sinif"].ToString();
                            Tsoru.Donem = dr["Donem"].ToString();
                            Tsoru.Yazili = dr["Yazili"].ToString();
                            Tsoru.Ders_Id = Convert.ToInt32(dr["Ders_Id"]);
                            Tsoru.Kolaylik = dr["Kolaylik"].ToString();
                            TestCokKolaysorular.Add(Tsoru);
                        }
                        baglanti.Close();
                        int rastgeleSayi = rnd.Next(0, TestCokKolaysorular.Count);
                        if (SorularTest.Contains(TestCokKolaysorular[rastgeleSayi]))
                        {
                            i--;
                            if (c >= 100)
                            {
                                MessageBox.Show("Soru Çekereken Hata Oluştu.Lütfen Bankadaki Soru Sayısını Kontrol Ediniz!");
                                break;
                            }
                        }
                        else
                        {
                            SorularTest.Add(TestCokKolaysorular[rastgeleSayi]);
                            TCK--;
                        }
                    }
                    //// KOLAY 
                    else if (TK > 0)
                    {
                        List<TestSorusu> TestKolaysorular = new List<TestSorusu>();
                        SqlConnection baglanti = new SqlConnection(bgl.baglan);
                        baglanti.Open();
                        SqlCommand komut = new SqlCommand("Select * from TestSoru where Sinif='" + Sinif + "' and Yazili='" + Yazili + "' and Donem='" + Donem + "'and Ders_Id=" + (cmbDers.SelectedItem as Dersler).Id + " and Kolaylik='Kolay'", baglanti);
                        SqlDataReader dr = komut.ExecuteReader();
                        while (dr.Read())
                        {
                            TestSorusu Tsoru = new TestSorusu();
                            Tsoru.Id = Convert.ToInt32(dr["Id"]);
                            Tsoru.Soru = dr["Soru"].ToString();
                            Tsoru.DCevap = dr["DCevap"].ToString();
                            Tsoru.YCevap1 = dr["YCevap1"].ToString();
                            Tsoru.YCevap2 = dr["YCevap2"].ToString();
                            Tsoru.YCevap3 = dr["YCevap3"].ToString();
                            Tsoru.Ycevap4 = dr["YCevap4"].ToString();
                            Tsoru.Sinif = dr["Sinif"].ToString();
                            Tsoru.Donem = dr["Donem"].ToString();
                            Tsoru.Yazili = dr["Yazili"].ToString();
                            Tsoru.Ders_Id = Convert.ToInt32(dr["Ders_Id"]);
                            Tsoru.Kolaylik = dr["Kolaylik"].ToString();
                            TestKolaysorular.Add(Tsoru);
                        }
                        baglanti.Close();
                        int rastgeleSayi = rnd.Next(0, TestKolaysorular.Count);
                        if (SorularTest.Contains(TestKolaysorular[rastgeleSayi]))
                        {
                            i--;
                            if (c >= 100)
                            {
                                MessageBox.Show("Soru Çekereken Hata Oluştu.Lütfen Bankadaki Soru Sayısını Kontrol Ediniz!");
                                break;
                            }
                        }
                        else
                        {
                            SorularTest.Add(TestKolaysorular[rastgeleSayi]);
                            TK--;
                        }
                    }

                        // ORTA 
                    else if (TO > 0)
                    {
                        List<TestSorusu> TestOrtasorular = new List<TestSorusu>();
                        SqlConnection baglanti = new SqlConnection(bgl.baglan);
                        baglanti.Open();
                        SqlCommand komut = new SqlCommand("Select * from TestSoru where Sinif='" + Sinif + "' and  Yazili='" + Yazili + "' and Donem='" + Donem + "'and Ders_Id=" + (cmbDers.SelectedItem as Dersler).Id + " and Kolaylik='Orta'", baglanti);
                        SqlDataReader dr = komut.ExecuteReader();
                        while (dr.Read())
                        {
                            TestSorusu Tsoru = new TestSorusu();
                            Tsoru.Id = Convert.ToInt32(dr["Id"]);
                            Tsoru.Soru = dr["Soru"].ToString();
                            Tsoru.DCevap = dr["DCevap"].ToString();
                            Tsoru.YCevap1 = dr["YCevap1"].ToString();
                            Tsoru.YCevap2 = dr["YCevap2"].ToString();
                            Tsoru.YCevap3 = dr["YCevap3"].ToString();
                            Tsoru.Ycevap4 = dr["YCevap4"].ToString();
                            Tsoru.Sinif = dr["Sinif"].ToString();
                            Tsoru.Donem = dr["Donem"].ToString();
                            Tsoru.Yazili = dr["Yazili"].ToString();
                            Tsoru.Ders_Id = Convert.ToInt32(dr["Ders_Id"]);
                            Tsoru.Kolaylik = dr["Kolaylik"].ToString();
                            TestOrtasorular.Add(Tsoru);
                        }
                        baglanti.Close();
                        int rastgeleSayi = rnd.Next(0, TestOrtasorular.Count);
                        if (SorularTest.Contains(TestOrtasorular[rastgeleSayi]))
                        {
                            i--;
                            if (c >= 100)
                            {
                                MessageBox.Show("Soru Çekereken Hata Oluştu.Lütfen Bankadaki Soru Sayısını Kontrol Ediniz!");
                                break;
                            }
                        }
                        else
                        {
                            SorularTest.Add(TestOrtasorular[rastgeleSayi]);
                            TO--;
                        }
                    }
                    // ZOR 
                    else if (TZ > 0)
                    {
                        List<TestSorusu> TestZorsorular = new List<TestSorusu>();
                        SqlConnection baglanti = new SqlConnection(bgl.baglan);
                        baglanti.Open();
                        SqlCommand komut = new SqlCommand("Select * from TestSoru where Sinif='" + Sinif + "' and Yazili='" + Yazili + "' and Donem='" + Donem + "'and Ders_Id=" + (cmbDers.SelectedItem as Dersler).Id + " and Kolaylik='Zor'", baglanti);
                        SqlDataReader dr = komut.ExecuteReader();
                        while (dr.Read())
                        {
                            TestSorusu Tsoru = new TestSorusu();
                            Tsoru.Id = Convert.ToInt32(dr["Id"]);
                            Tsoru.Soru = dr["Soru"].ToString();
                            Tsoru.DCevap = dr["DCevap"].ToString();
                            Tsoru.YCevap1 = dr["YCevap1"].ToString();
                            Tsoru.YCevap2 = dr["YCevap2"].ToString();
                            Tsoru.YCevap3 = dr["YCevap3"].ToString();
                            Tsoru.Ycevap4 = dr["YCevap4"].ToString();
                            Tsoru.Sinif = dr["Sinif"].ToString();
                            Tsoru.Donem = dr["Donem"].ToString();
                            Tsoru.Yazili = dr["Yazili"].ToString();
                            Tsoru.Ders_Id = Convert.ToInt32(dr["Ders_Id"]);
                            Tsoru.Kolaylik = dr["Kolaylik"].ToString();
                            TestZorsorular.Add(Tsoru);
                        }
                        baglanti.Close();
                        int rastgeleSayi = rnd.Next(0, TestZorsorular.Count);
                        if (SorularTest.Contains(TestZorsorular[rastgeleSayi]))
                        {
                            i--;
                            if (c >= 100)
                            {
                                MessageBox.Show("Soru Çekereken Hata Oluştu.Lütfen Bankadaki Soru Sayısını Kontrol Ediniz!");
                                break;
                            }
                        }
                        else
                        {
                            SorularTest.Add(TestZorsorular[rastgeleSayi]);
                            TZ--;
                        }
                    }
                    //ÇOK ZOR 
                    else if (TZ > 0)
                    {
                        List<TestSorusu> TestCokZorsorular = new List<TestSorusu>();
                        SqlConnection baglanti = new SqlConnection(bgl.baglan);
                        baglanti.Open();
                        SqlCommand komut = new SqlCommand("Select * from TestSoru Sinif='" + Sinif + "' and  where Yazili='" + Yazili + "' and Donem='" + Donem + "'and Ders_Id=" + (cmbDers.SelectedItem as Dersler).Id + " and Kolaylik='Çok Zor'", baglanti);
                        SqlDataReader dr = komut.ExecuteReader();
                        while (dr.Read())
                        {
                            TestSorusu Tsoru = new TestSorusu();
                            Tsoru.Id = Convert.ToInt32(dr["Id"]);
                            Tsoru.Soru = dr["Soru"].ToString();
                            Tsoru.DCevap = dr["DCevap"].ToString();
                            Tsoru.YCevap1 = dr["YCevap1"].ToString();
                            Tsoru.YCevap2 = dr["YCevap2"].ToString();
                            Tsoru.YCevap3 = dr["YCevap3"].ToString();
                            Tsoru.Ycevap4 = dr["YCevap4"].ToString();
                            Tsoru.Sinif = dr["Sinif"].ToString();
                            Tsoru.Donem = dr["Donem"].ToString();
                            Tsoru.Yazili = dr["Yazili"].ToString();
                            Tsoru.Ders_Id = Convert.ToInt32(dr["Ders_Id"]);
                            Tsoru.Kolaylik = dr["Kolaylik"].ToString();
                            TestCokZorsorular.Add(Tsoru);
                        }
                        baglanti.Close();
                        int rastgeleSayi = rnd.Next(0, TestCokZorsorular.Count);
                        if (SorularTest.Contains(TestCokZorsorular[rastgeleSayi]))
                        {
                            i--;
                            if (c >= 100)
                            {
                                MessageBox.Show("Soru Çekereken Hata Oluştu.Lütfen Bankadaki Soru Sayısını Kontrol Ediniz!");
                                break;
                            }
                        }
                        else
                        {
                            SorularTest.Add(TestCokZorsorular[rastgeleSayi]);
                            TCZ--;
                        }
                    }
                }/////forr kapanısı
                int sorununNumarasi = 1;
                richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
                richTextBox2.SelectionAlignment = HorizontalAlignment.Center;
                richTextBox1.SelectedText = "Ulus Teknik ve Endüstri Meslek Lisesi " + (cmbDers.SelectedItem as Dersler).Ders + " Dersi, " + Sinif + ", " + Donem + ", " + Yazili + " Soruları \n \n";
                richTextBox2.SelectedText = "Ulus Teknik ve Endüstri Meslek Lisesi " + (cmbDers.SelectedItem as Dersler).Ders + " Dersi, " + Sinif + ", " + Donem + ", " + Yazili + " Cevap Anahtarı \n \n";
                richTextBox2.SelectionAlignment = HorizontalAlignment.Left;
                richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
                Random r = new Random();
                for (int i = 0, o = 0; i < Sorular.Count; i++, o++)
                {
                    int rastgele = r.Next(0, Sorular.Count);
                    string ifade = richTextBox1.Text;
                    if (ifade.Contains(") " + Sorular[rastgele].Soru + "\n\n\n"))
                    {
                        if (!(o >= 100))
                        {
                            i--;
                        }

                    }
                    else
                    {
                        richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, richTextBox1.Font.Size, FontStyle.Bold);
                        richTextBox2.SelectionFont = new Font(richTextBox1.Font.FontFamily, richTextBox1.Font.Size, FontStyle.Bold);
                        richTextBox1.SelectedText = sorununNumarasi  + ") " + Sorular[rastgele].Soru + "\n\n\n";
                        richTextBox2.SelectedText = sorununNumarasi  + ") " + Sorular[rastgele].Soru + "\n";
                        richTextBox2.SelectionColor = Color.Red;
                        richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, richTextBox1.Font.Size);
                        richTextBox2.SelectionFont = new Font(richTextBox1.Font.FontFamily, richTextBox1.Font.Size);
                        richTextBox2.SelectedText = Sorular[rastgele].Cevap + "\n\n";
                        sorununNumarasi++;
                    }
                }
                int d = 0;
                for (int i = 0, o = 0; i < SorularTest.Count; i++, o++)
                {
                    string ifade = richTextBox1.Text;
                    Secenekler Secenekler = new Secenekler();
                    int rastgele = r.Next(d, SorularTest.Count);

                    if (ifade.Contains(") " + SorularTest[rastgele].Soru + "\n"))
                    {
                        if (o <= 500)
                        {
                            i--;
                        }
                        else
                        {
                            d++;
                        }
                    }
                    else
                    {
                        richTextBox2.SelectionFont = new Font(richTextBox1.Font.FontFamily, richTextBox1.Font.Size, FontStyle.Bold);
                        richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, richTextBox1.Font.Size, FontStyle.Bold);
                        richTextBox1.SelectedText = sorununNumarasi + ") " + SorularTest[rastgele].Soru + "\n";
                        richTextBox2.SelectedText = sorununNumarasi + ") " + SorularTest[rastgele].Soru + "\n";
                        sorununNumarasi++;
                        int z = 0;
                        bool girmedi1 = true, girmedi2 = true, girmedi3 = true, girmedi4 = true, girmedi5 = true;

                        string secenekAdlari = "ABCDE";
                        for (int j = 0; j < 5; j++)
                        {
                            int tutulanSayi = r.Next(0, 5);
                            if (tutulanSayi == 0 && girmedi1)
                            {
                                girmedi1 = false;

                                richTextBox1.SelectedText = "   " + secenekAdlari[z] + ") " + SorularTest[rastgele].DCevap + "\n";
                                richTextBox2.SelectionColor = Color.Red;
                                richTextBox2.SelectedText = "   " + secenekAdlari[z] + ") " + SorularTest[rastgele].DCevap + "\n";
                                z++;
                            }
                            else if (tutulanSayi == 1 && girmedi2)
                            {
                                girmedi2 = false;
                                richTextBox1.SelectedText = "   " + secenekAdlari[z] + ") " + SorularTest[rastgele].YCevap1 + "\n";
                                richTextBox2.SelectedText = "   " + secenekAdlari[z] + ") " + SorularTest[rastgele].YCevap1 + "\n";
                                z++;
                            }
                            else if (tutulanSayi == 2 && girmedi3)
                            {
                                girmedi3 = false;
                                richTextBox1.SelectedText = "   " + secenekAdlari[z] + ") " + SorularTest[rastgele].YCevap2 + "\n";
                                richTextBox2.SelectedText = "   " + secenekAdlari[z] + ") " + SorularTest[rastgele].YCevap2 + "\n";
                                z++;
                            }
                            else if (tutulanSayi == 3 && girmedi4)
                            {
                                girmedi4 = false;
                                richTextBox1.SelectedText = "   " + secenekAdlari[z] + ") " + SorularTest[rastgele].YCevap3 + "\n";
                                richTextBox2.SelectedText = "   " + secenekAdlari[z] + ") " + SorularTest[rastgele].YCevap3 + "\n";
                                z++;
                            }
                            else if (tutulanSayi == 4 && girmedi5)
                            {
                                girmedi5 = false;
                                richTextBox1.SelectedText = "   " + secenekAdlari[z] + ") " + SorularTest[rastgele].Ycevap4 + "\n";
                                richTextBox2.SelectedText = "   " + secenekAdlari[z] + ") " + SorularTest[rastgele].Ycevap4 + "\n";
                                z++;
                            }
                            else
                            {
                                j--;
                            }
                        }
                    }



                }
                richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
                richTextBox2.SelectionAlignment = HorizontalAlignment.Right;
                richTextBox1.SelectedText = "Başarılar Dilerim\n" + Form1.girisYapanKullaniciAdi + " " + Form1.girisYapanKullaniciSoyadi;
                richTextBox2.SelectedText = "Başarılar Dilerim\n" + Form1.girisYapanKullaniciAdi +" "+ Form1.girisYapanKullaniciSoyadi;
                
                button1.Enabled = false;
            }

            catch (Exception)
            {
                MessageBox.Show("Kaynakta soru bulamadı.","Hata Oldu");
            }
        }

        public string Sinif = "", Donem = "", Yazili = "";
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

        private void sinavHazirla_Load(object sender, EventArgs e)
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
                MessageBox.Show(ex.Source, "Bağlantıda Hata Oluştu");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            richTextBox2.Text = "";
            button1.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            PrintDocument documentToPrint = new PrintDocument();
            printDialog.Document = documentToPrint;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                StringReader reader = new StringReader(richTextBox1.Text);
                documentToPrint.Print();
            }
            
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            StringReader reader = new StringReader(richTextBox1.Text);
            float LinesPerPage = 0;
            float YPosition = 0;
            int Count = 0;
            float LeftMargin = e.MarginBounds.Left;
            float TopMargin = e.MarginBounds.Top;
            string Line = null;
            Font PrintFont = richTextBox1.Font;
            SolidBrush PrintBrush = new SolidBrush(Color.Black);

            LinesPerPage = e.MarginBounds.Height / PrintFont.GetHeight(e.Graphics);

            while (Count < LinesPerPage && ((Line = reader.ReadLine()) != null))
            {
                YPosition = TopMargin + (Count * PrintFont.GetHeight(e.Graphics));
                e.Graphics.DrawString(Line, PrintFont, PrintBrush, LeftMargin, YPosition, new StringFormat());
                Count++;
            }

            if (Line != null)
            {
                e.HasMorePages = true;
            }
            else
            {
                e.HasMorePages = false;
            }
            PrintBrush.Dispose();

        }
        

    }
}
