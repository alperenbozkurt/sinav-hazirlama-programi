using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace sinavHazirlamaProgrami
{
    public partial class dersEkle : Form
    {
        public dersEkle()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            baglatistr bgl = new baglatistr();
            try
            {
                SqlConnection baglanti = new SqlConnection(bgl.baglan);
                SqlCommand komut = new SqlCommand("insert Dersler values('"+txtDers.Text+"',"+(cmbBranslar.SelectedItem as Branslar).Id+")", baglanti);
                DataTable Ktablo = new DataTable();
                SqlDataAdapter kdt = new SqlDataAdapter("Select * from Dersler", baglanti);
                baglanti.Open();
                komut.ExecuteNonQuery();
                kdt.Fill(Ktablo);
                baglanti.Close();
                dgvDers.DataSource = Ktablo;
                MessageBox.Show("Kayıt Başarılı");
            }
            catch
            { }
        }

        private void dersEkle_Load(object sender, EventArgs e)
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

                baglanti.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter kdt = new SqlDataAdapter("Select * from Dersler", baglanti);
                kdt.Fill(dt);


                dgvDers.DataSource = dt;
                baglanti.Close();
                cmbBranslar.DataSource = branslar;
                cmbBranslar.DisplayMember = "Brans";
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Source,"Hata Oldu");
            }

            
        }
    }
}
