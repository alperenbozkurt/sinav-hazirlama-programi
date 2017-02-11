using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sinavHazirlamaProgrami
{
    public partial class frmAnaEkran : Form
    {
        public frmAnaEkran()
        {
            InitializeComponent();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frmGiris = new Form1();
            frmGiris.Show();
            this.Hide();
        }

        private void testSorusuMenu_Click(object sender, EventArgs e)
        {
            testSorusuEkle frmTest = new testSorusuEkle();
            frmTest.MdiParent = this;
            frmTest.Show();
        }

        private void klasikSoruEkleMenu_Click(object sender, EventArgs e)
        {
            klasikSoruEkle klasikSoruEkle = new klasikSoruEkle();
            klasikSoruEkle.MdiParent = this;
            klasikSoruEkle.Show();
        }

        private void kullaniciEkleMenu_Click(object sender, EventArgs e)
        {
            KullaniciEkle kullaniciEkle = new KullaniciEkle();
            kullaniciEkle.MdiParent = this;
            kullaniciEkle.Show();
        }

        private void dersEkleMenu_Click(object sender, EventArgs e)
        {
            dersEkle dersEkle = new dersEkle();
            dersEkle.MdiParent = this;
            dersEkle.Show();
        }

        private void branşEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            bransEkle bransEkle = new bransEkle();
            bransEkle.MdiParent = this;
            bransEkle.Show();
        }

        private void klasikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            klasikSoruEkle klasikSoruEkle = new klasikSoruEkle();
            klasikSoruEkle.MdiParent = this;
            klasikSoruEkle.Show();
        }

        private void TestSoruEkleMenu_Click(object sender, EventArgs e)
        {
            testSorusuEkle testSorusuEkle = new testSorusuEkle();
            testSorusuEkle.MdiParent = this;
            testSorusuEkle.Show();
        }

        private void ayarlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void frmAnaEkran_Load(object sender, EventArgs e)
        {
            //Control rengiyle
            foreach (Control control in this.Controls)
            {
                // #2
                MdiClient client = control as MdiClient;
                if (!(client == null))
                {
                    client.BackColor = Color.DarkSeaGreen;
                    break;
                }
            }
            ////-----
            if (!Form1.yetki)
            {
                kullaniciEkleMenu.Visible = false;
                iletişimToolStripMenuItem.Visible = true;
                mesajlarıGörToolStripMenuItem.Visible = false;
            }
            else if (Form1.yetki)
            {
                kullaniciEkleMenu.Enabled = true;
                iletişimToolStripMenuItem.Visible = false;
                mesajlarıGörToolStripMenuItem.Visible = true;
            }
        }

        private void yardımToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void iletişimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIletisim iletisim = new frmIletisim();
            iletisim.MdiParent = this;
            iletisim.Show();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void sınavHazırlaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sinavHazirla sHazirla = new sinavHazirla();
            sHazirla.MdiParent = this;
            sHazirla.Show();
        }

        private void soruDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SoruGuncelle sGuncelle = new SoruGuncelle();
            sGuncelle.MdiParent = this;
            sGuncelle.Show();
        }

        private void frmAnaEkran_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void mesajlarıGörToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ailetisim atletisim = new ailetisim();
            atletisim.MdiParent = this;
            atletisim.Show();

        }

        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hakkimizda frmHakka = new hakkimizda();
            frmHakka.MdiParent = this;
            frmHakka.Show();
        }

       
    }
}
