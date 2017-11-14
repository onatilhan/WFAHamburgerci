namespace WFAHamburgerci
{
    partial class Form1
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rbBuyuk = new System.Windows.Forms.RadioButton();
			this.rbOrta = new System.Windows.Forms.RadioButton();
			this.rbKucuk = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.cbMenuler = new System.Windows.Forms.ComboBox();
			this.btnSiparisEkle = new System.Windows.Forms.Button();
			this.lstSiparisler = new System.Windows.Forms.ListBox();
			this.label2 = new System.Windows.Forms.Label();
			this.lblToplamTutar = new System.Windows.Forms.Label();
			this.btmSiparisTamamla = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.nmrAdet = new System.Windows.Forms.NumericUpDown();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.flpExtraMalzemeler = new System.Windows.Forms.FlowLayoutPanel();
			this.label4 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nmrAdet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rbBuyuk);
			this.groupBox1.Controls.Add(this.rbOrta);
			this.groupBox1.Controls.Add(this.rbKucuk);
			this.groupBox1.Location = new System.Drawing.Point(16, 249);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(333, 75);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Boyut Seçin";
			// 
			// rbBuyuk
			// 
			this.rbBuyuk.AutoSize = true;
			this.rbBuyuk.Location = new System.Drawing.Point(174, 33);
			this.rbBuyuk.Name = "rbBuyuk";
			this.rbBuyuk.Size = new System.Drawing.Size(93, 29);
			this.rbBuyuk.TabIndex = 6;
			this.rbBuyuk.TabStop = true;
			this.rbBuyuk.Text = "Büyük";
			this.rbBuyuk.UseVisualStyleBackColor = true;
			// 
			// rbOrta
			// 
			this.rbOrta.AutoSize = true;
			this.rbOrta.Location = new System.Drawing.Point(98, 33);
			this.rbOrta.Name = "rbOrta";
			this.rbOrta.Size = new System.Drawing.Size(75, 29);
			this.rbOrta.TabIndex = 5;
			this.rbOrta.TabStop = true;
			this.rbOrta.Text = "Orta";
			this.rbOrta.UseVisualStyleBackColor = true;
			// 
			// rbKucuk
			// 
			this.rbKucuk.AutoSize = true;
			this.rbKucuk.Checked = true;
			this.rbKucuk.Location = new System.Drawing.Point(6, 33);
			this.rbKucuk.Name = "rbKucuk";
			this.rbKucuk.Size = new System.Drawing.Size(94, 29);
			this.rbKucuk.TabIndex = 4;
			this.rbKucuk.TabStop = true;
			this.rbKucuk.Text = "Küçük";
			this.rbKucuk.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 183);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(127, 25);
			this.label1.TabIndex = 2;
			this.label1.Text = "Menü Seçin";
			// 
			// cbMenuler
			// 
			this.cbMenuler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbMenuler.FormattingEnabled = true;
			this.cbMenuler.Location = new System.Drawing.Point(12, 206);
			this.cbMenuler.Name = "cbMenuler";
			this.cbMenuler.Size = new System.Drawing.Size(337, 33);
			this.cbMenuler.TabIndex = 3;
			// 
			// btnSiparisEkle
			// 
			this.btnSiparisEkle.Location = new System.Drawing.Point(12, 554);
			this.btnSiparisEkle.Name = "btnSiparisEkle";
			this.btnSiparisEkle.Size = new System.Drawing.Size(337, 37);
			this.btnSiparisEkle.TabIndex = 5;
			this.btnSiparisEkle.Text = "Sipariş Ekle";
			this.btnSiparisEkle.UseVisualStyleBackColor = true;
			this.btnSiparisEkle.Click += new System.EventHandler(this.btnSiparisEkle_Click);
			// 
			// lstSiparisler
			// 
			this.lstSiparisler.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lstSiparisler.FormattingEnabled = true;
			this.lstSiparisler.ItemHeight = 25;
			this.lstSiparisler.Location = new System.Drawing.Point(365, 12);
			this.lstSiparisler.Name = "lstSiparisler";
			this.lstSiparisler.Size = new System.Drawing.Size(1072, 504);
			this.lstSiparisler.TabIndex = 6;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(374, 554);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(154, 25);
			this.label2.TabIndex = 7;
			this.label2.Text = "Toplam Tutar :";
			// 
			// lblToplamTutar
			// 
			this.lblToplamTutar.AutoSize = true;
			this.lblToplamTutar.Location = new System.Drawing.Point(504, 554);
			this.lblToplamTutar.Name = "lblToplamTutar";
			this.lblToplamTutar.Size = new System.Drawing.Size(56, 25);
			this.lblToplamTutar.TabIndex = 7;
			this.lblToplamTutar.Text = "0 TL";
			// 
			// btmSiparisTamamla
			// 
			this.btmSiparisTamamla.Location = new System.Drawing.Point(978, 546);
			this.btmSiparisTamamla.Name = "btmSiparisTamamla";
			this.btmSiparisTamamla.Size = new System.Drawing.Size(242, 36);
			this.btmSiparisTamamla.TabIndex = 8;
			this.btmSiparisTamamla.Text = "Siparişi Tamamla";
			this.btmSiparisTamamla.UseVisualStyleBackColor = true;
			this.btmSiparisTamamla.Click += new System.EventHandler(this.btmSiparisTamamla_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(8, 520);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(70, 25);
			this.label3.TabIndex = 7;
			this.label3.Text = "Adet :";
			// 
			// nmrAdet
			// 
			this.nmrAdet.Location = new System.Drawing.Point(71, 520);
			this.nmrAdet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nmrAdet.Name = "nmrAdet";
			this.nmrAdet.Size = new System.Drawing.Size(278, 30);
			this.nmrAdet.TabIndex = 9;
			this.nmrAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::WFAHamburgerci.Properties.Resources.hamburger;
			this.pictureBox1.Location = new System.Drawing.Point(12, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(337, 150);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// flpExtraMalzemeler
			// 
			this.flpExtraMalzemeler.Location = new System.Drawing.Point(16, 367);
			this.flpExtraMalzemeler.Name = "flpExtraMalzemeler";
			this.flpExtraMalzemeler.Size = new System.Drawing.Size(333, 137);
			this.flpExtraMalzemeler.TabIndex = 10;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(18, 344);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(179, 25);
			this.label4.TabIndex = 7;
			this.label4.Text = "Extra Malzemeler";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1237, 603);
			this.Controls.Add(this.flpExtraMalzemeler);
			this.Controls.Add(this.nmrAdet);
			this.Controls.Add(this.btmSiparisTamamla);
			this.Controls.Add(this.lblToplamTutar);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lstSiparisler);
			this.Controls.Add(this.btnSiparisEkle);
			this.Controls.Add(this.cbMenuler);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.pictureBox1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nmrAdet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbKucuk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMenuler;
        private System.Windows.Forms.Button btnSiparisEkle;
        private System.Windows.Forms.ListBox lstSiparisler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.Button btmSiparisTamamla;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nmrAdet;
        private System.Windows.Forms.RadioButton rbBuyuk;
        private System.Windows.Forms.RadioButton rbOrta;
        private System.Windows.Forms.FlowLayoutPanel flpExtraMalzemeler;
        private System.Windows.Forms.Label label4;
    }
}

