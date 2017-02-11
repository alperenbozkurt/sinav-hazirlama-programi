namespace sinavHazirlamaProgrami
{
    partial class bransEkle
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtBrans = new System.Windows.Forms.TextBox();
            this.dgvBrans = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBrans)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(141, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "Branşı Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBrans
            // 
            this.txtBrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBrans.Location = new System.Drawing.Point(12, 168);
            this.txtBrans.Name = "txtBrans";
            this.txtBrans.Size = new System.Drawing.Size(253, 27);
            this.txtBrans.TabIndex = 1;
            // 
            // dgvBrans
            // 
            this.dgvBrans.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvBrans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBrans.Location = new System.Drawing.Point(15, 12);
            this.dgvBrans.Name = "dgvBrans";
            this.dgvBrans.Size = new System.Drawing.Size(250, 150);
            this.dgvBrans.TabIndex = 2;
            // 
            // bransEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 239);
            this.Controls.Add(this.dgvBrans);
            this.Controls.Add(this.txtBrans);
            this.Controls.Add(this.button1);
            this.Name = "bransEkle";
            this.ShowIcon = false;
            this.Text = "Branş Ekleme Penceresi";
            this.Load += new System.EventHandler(this.bransEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBrans)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBrans;
        private System.Windows.Forms.DataGridView dgvBrans;
    }
}