namespace sinavHazirlamaProgrami
{
    partial class ailetisim
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
            this.dgvMesajlar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesajlar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMesajlar
            // 
            this.dgvMesajlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMesajlar.Location = new System.Drawing.Point(12, 12);
            this.dgvMesajlar.Name = "dgvMesajlar";
            this.dgvMesajlar.Size = new System.Drawing.Size(588, 404);
            this.dgvMesajlar.TabIndex = 0;
            // 
            // ailetisim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 428);
            this.Controls.Add(this.dgvMesajlar);
            this.Name = "ailetisim";
            this.ShowIcon = false;
            this.Text = "Gelen Mesajlar";
            this.Load += new System.EventHandler(this.ailetisim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesajlar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMesajlar;
    }
}