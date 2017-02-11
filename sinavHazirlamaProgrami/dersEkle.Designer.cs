namespace sinavHazirlamaProgrami
{
    partial class dersEkle
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
            this.cmbBranslar = new System.Windows.Forms.ComboBox();
            this.txtDers = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvDers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDers)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbBranslar
            // 
            this.cmbBranslar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBranslar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbBranslar.FormattingEnabled = true;
            this.cmbBranslar.Location = new System.Drawing.Point(20, 175);
            this.cmbBranslar.Name = "cmbBranslar";
            this.cmbBranslar.Size = new System.Drawing.Size(526, 28);
            this.cmbBranslar.TabIndex = 0;
            // 
            // txtDers
            // 
            this.txtDers.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDers.Location = new System.Drawing.Point(20, 209);
            this.txtDers.Name = "txtDers";
            this.txtDers.Size = new System.Drawing.Size(526, 27);
            this.txtDers.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(420, 242);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "Dersi Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvDers
            // 
            this.dgvDers.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDers.Location = new System.Drawing.Point(20, 12);
            this.dgvDers.Name = "dgvDers";
            this.dgvDers.Size = new System.Drawing.Size(526, 150);
            this.dgvDers.TabIndex = 3;
            // 
            // dersEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 293);
            this.Controls.Add(this.dgvDers);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtDers);
            this.Controls.Add(this.cmbBranslar);
            this.Name = "dersEkle";
            this.ShowIcon = false;
            this.Text = "Ders Ekleme Formu";
            this.Load += new System.EventHandler(this.dersEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBranslar;
        private System.Windows.Forms.TextBox txtDers;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvDers;
    }
}