namespace sinavHazirlamaProgrami
{
    partial class SoruGuncelle
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
            dgvKlasik = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            dgvTest = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(dgvKlasik)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(dgvTest)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKlasik
            // 
            dgvKlasik.BackgroundColor = System.Drawing.SystemColors.Control;
            dgvKlasik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKlasik.Location = new System.Drawing.Point(21, 34);
            dgvKlasik.Name = "dgvKlasik";
            dgvKlasik.Size = new System.Drawing.Size(830, 162);
            dgvKlasik.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(dgvKlasik);
            this.groupBox1.Location = new System.Drawing.Point(34, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(866, 232);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Klasik Sorular";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(752, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 22);
            this.button1.TabIndex = 1;
            this.button1.Text = "Getir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(dgvTest);
            this.groupBox2.Location = new System.Drawing.Point(34, 250);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(866, 198);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Test Soruları";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(752, 167);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 22);
            this.button2.TabIndex = 2;
            this.button2.Text = "Getir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgvTest
            // 
            dgvTest.BackgroundColor = System.Drawing.SystemColors.Control;
            dgvTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTest.Location = new System.Drawing.Point(21, 19);
            dgvTest.Name = "dgvTest";
            dgvTest.Size = new System.Drawing.Size(830, 142);
            dgvTest.TabIndex = 1;
            // 
            // SoruGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 477);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "SoruGuncelle";
            this.ShowIcon = false;
            this.Text = "Soru Güncelle";
            this.Load += new System.EventHandler(this.SoruGuncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(dgvKlasik)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(dgvTest)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        public static System.Windows.Forms.DataGridView dgvTest;
        public static System.Windows.Forms.DataGridView dgvKlasik;
    }
}