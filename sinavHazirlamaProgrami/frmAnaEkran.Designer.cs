namespace sinavHazirlamaProgrami
{
    partial class frmAnaEkran
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnaEkran));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soruEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testSorusuMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.klasikSoruEkleMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.kullaniciEkleMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.dersEkleMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.BransEkleMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.sınavHazırlaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soruGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkımızdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.iletişimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mesajlarıGörToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.dosyaToolStripMenuItem,
            this.hakkımızdaToolStripMenuItem,
            this.yardımToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(724, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniToolStripMenuItem,
            this.sınavHazırlaToolStripMenuItem,
            this.soruGüncelleToolStripMenuItem,
            this.toolStripSeparator1,
            this.çıkışToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // yeniToolStripMenuItem
            // 
            this.yeniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.soruEkleToolStripMenuItem,
            this.kullaniciEkleMenu,
            this.dersEkleMenu,
            this.BransEkleMenu});
            this.yeniToolStripMenuItem.Name = "yeniToolStripMenuItem";
            this.yeniToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.yeniToolStripMenuItem.Text = "Ekle";
            // 
            // soruEkleToolStripMenuItem
            // 
            this.soruEkleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testSorusuMenu,
            this.klasikSoruEkleMenu});
            this.soruEkleToolStripMenuItem.Name = "soruEkleToolStripMenuItem";
            this.soruEkleToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.soruEkleToolStripMenuItem.Text = "Soru Ekle";
            // 
            // testSorusuMenu
            // 
            this.testSorusuMenu.Name = "testSorusuMenu";
            this.testSorusuMenu.Size = new System.Drawing.Size(159, 22);
            this.testSorusuMenu.Text = "Test Sorusu Ekle";
            this.testSorusuMenu.Click += new System.EventHandler(this.testSorusuMenu_Click);
            // 
            // klasikSoruEkleMenu
            // 
            this.klasikSoruEkleMenu.Name = "klasikSoruEkleMenu";
            this.klasikSoruEkleMenu.Size = new System.Drawing.Size(159, 22);
            this.klasikSoruEkleMenu.Text = "Klasik Soru Ekle";
            this.klasikSoruEkleMenu.Click += new System.EventHandler(this.klasikSoruEkleMenu_Click);
            // 
            // kullaniciEkleMenu
            // 
            this.kullaniciEkleMenu.Enabled = false;
            this.kullaniciEkleMenu.Name = "kullaniciEkleMenu";
            this.kullaniciEkleMenu.Size = new System.Drawing.Size(143, 22);
            this.kullaniciEkleMenu.Text = "Kullanıcı Ekle";
            this.kullaniciEkleMenu.Click += new System.EventHandler(this.kullaniciEkleMenu_Click);
            // 
            // dersEkleMenu
            // 
            this.dersEkleMenu.Name = "dersEkleMenu";
            this.dersEkleMenu.Size = new System.Drawing.Size(143, 22);
            this.dersEkleMenu.Text = "Ders Ekle";
            this.dersEkleMenu.Click += new System.EventHandler(this.dersEkleMenu_Click);
            // 
            // BransEkleMenu
            // 
            this.BransEkleMenu.Name = "BransEkleMenu";
            this.BransEkleMenu.Size = new System.Drawing.Size(143, 22);
            this.BransEkleMenu.Text = "Branş Ekle";
            this.BransEkleMenu.Click += new System.EventHandler(this.branşEkleToolStripMenuItem_Click);
            // 
            // sınavHazırlaToolStripMenuItem
            // 
            this.sınavHazırlaToolStripMenuItem.Name = "sınavHazırlaToolStripMenuItem";
            this.sınavHazırlaToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.sınavHazırlaToolStripMenuItem.Text = "Sınav Hazırla";
            this.sınavHazırlaToolStripMenuItem.Click += new System.EventHandler(this.sınavHazırlaToolStripMenuItem_Click);
            // 
            // soruGüncelleToolStripMenuItem
            // 
            this.soruGüncelleToolStripMenuItem.Name = "soruGüncelleToolStripMenuItem";
            this.soruGüncelleToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.soruGüncelleToolStripMenuItem.Text = "Soru Güncelle";
            this.soruGüncelleToolStripMenuItem.Click += new System.EventHandler(this.soruDüzenleToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(144, 6);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // hakkımızdaToolStripMenuItem
            // 
            this.hakkımızdaToolStripMenuItem.Name = "hakkımızdaToolStripMenuItem";
            this.hakkımızdaToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.hakkımızdaToolStripMenuItem.Text = "Hakkımızda";
            this.hakkımızdaToolStripMenuItem.Click += new System.EventHandler(this.hakkımızdaToolStripMenuItem_Click);
            // 
            // yardımToolStripMenuItem1
            // 
            this.yardımToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iletişimToolStripMenuItem,
            this.mesajlarıGörToolStripMenuItem});
            this.yardımToolStripMenuItem1.Name = "yardımToolStripMenuItem1";
            this.yardımToolStripMenuItem1.Size = new System.Drawing.Size(57, 20);
            this.yardımToolStripMenuItem1.Text = "Yardım";
            this.yardımToolStripMenuItem1.Click += new System.EventHandler(this.yardımToolStripMenuItem1_Click);
            // 
            // iletişimToolStripMenuItem
            // 
            this.iletişimToolStripMenuItem.Name = "iletişimToolStripMenuItem";
            this.iletişimToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.iletişimToolStripMenuItem.Text = "İletişim";
            this.iletişimToolStripMenuItem.Click += new System.EventHandler(this.iletişimToolStripMenuItem_Click);
            // 
            // mesajlarıGörToolStripMenuItem
            // 
            this.mesajlarıGörToolStripMenuItem.Name = "mesajlarıGörToolStripMenuItem";
            this.mesajlarıGörToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.mesajlarıGörToolStripMenuItem.Text = "Mesajları Gör";
            this.mesajlarıGörToolStripMenuItem.Click += new System.EventHandler(this.mesajlarıGörToolStripMenuItem_Click);
            // 
            // frmAnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(724, 372);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmAnaEkran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sınav Hazırlama Programı";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAnaEkran_FormClosed);
            this.Load += new System.EventHandler(this.frmAnaEkran_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soruEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testSorusuMenu;
        private System.Windows.Forms.ToolStripMenuItem klasikSoruEkleMenu;
        private System.Windows.Forms.ToolStripMenuItem kullaniciEkleMenu;
        private System.Windows.Forms.ToolStripMenuItem dersEkleMenu;
        private System.Windows.Forms.ToolStripMenuItem BransEkleMenu;
        private System.Windows.Forms.ToolStripMenuItem hakkımızdaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sınavHazırlaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem iletişimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soruGüncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mesajlarıGörToolStripMenuItem;
    }
}