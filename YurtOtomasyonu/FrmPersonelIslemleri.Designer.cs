namespace YurtOtomasyonu
{
    partial class FrmPersonelIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPersonelIslemleri));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtUserAd = new System.Windows.Forms.TextBox();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.mtbUserMail = new System.Windows.Forms.MaskedTextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.txtUserSoyad = new System.Windows.Forms.MaskedTextBox();
            this.mtbUserTC = new System.Windows.Forms.MaskedTextBox();
            this.lblTC = new System.Windows.Forms.Label();
            this.btnPKaydet = new System.Windows.Forms.Button();
            this.txtUserTel = new System.Windows.Forms.TextBox();
            this.lblPTel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtUserSifre = new System.Windows.Forms.TextBox();
            this.lblUserSifre = new System.Windows.Forms.Label();
            this.txtUserRol = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtUserRol);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtUserSifre);
            this.groupBox1.Controls.Add(this.lblUserSifre);
            this.groupBox1.Controls.Add(this.btnPKaydet);
            this.groupBox1.Controls.Add(this.txtUserAd);
            this.groupBox1.Controls.Add(this.lblSoyad);
            this.groupBox1.Controls.Add(this.lblAd);
            this.groupBox1.Controls.Add(this.mtbUserMail);
            this.groupBox1.Controls.Add(this.lblMail);
            this.groupBox1.Controls.Add(this.txtUserTel);
            this.groupBox1.Controls.Add(this.txtUserSoyad);
            this.groupBox1.Controls.Add(this.lblPTel);
            this.groupBox1.Controls.Add(this.mtbUserTC);
            this.groupBox1.Controls.Add(this.lblTC);
            this.groupBox1.Location = new System.Drawing.Point(280, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 412);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kullanıcı Kayıt";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtUserAd
            // 
            this.txtUserAd.Location = new System.Drawing.Point(168, 73);
            this.txtUserAd.Name = "txtUserAd";
            this.txtUserAd.Size = new System.Drawing.Size(193, 34);
            this.txtUserAd.TabIndex = 8;
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(65, 125);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(97, 25);
            this.lblSoyad.TabIndex = 7;
            this.lblSoyad.Text = "SOYAD:";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(109, 76);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(53, 25);
            this.lblAd.TabIndex = 6;
            this.lblAd.Text = "AD:";
            // 
            // mtbUserMail
            // 
            this.mtbUserMail.Location = new System.Drawing.Point(168, 227);
            this.mtbUserMail.Name = "mtbUserMail";
            this.mtbUserMail.Size = new System.Drawing.Size(193, 34);
            this.mtbUserMail.TabIndex = 5;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(79, 236);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(83, 25);
            this.lblMail.TabIndex = 4;
            this.lblMail.Text = "MAİL:";
            // 
            // txtUserSoyad
            // 
            this.txtUserSoyad.Location = new System.Drawing.Point(168, 122);
            this.txtUserSoyad.Name = "txtUserSoyad";
            this.txtUserSoyad.Size = new System.Drawing.Size(193, 34);
            this.txtUserSoyad.TabIndex = 3;
            // 
            // mtbUserTC
            // 
            this.mtbUserTC.Location = new System.Drawing.Point(168, 21);
            this.mtbUserTC.Mask = "00000000000";
            this.mtbUserTC.Name = "mtbUserTC";
            this.mtbUserTC.Size = new System.Drawing.Size(193, 34);
            this.mtbUserTC.TabIndex = 1;
            this.mtbUserTC.ValidatingType = typeof(int);
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.Location = new System.Drawing.Point(69, 30);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(93, 25);
            this.lblTC.TabIndex = 0;
            this.lblTC.Text = "TC NO:";
            // 
            // btnPKaydet
            // 
            this.btnPKaydet.Location = new System.Drawing.Point(229, 371);
            this.btnPKaydet.Name = "btnPKaydet";
            this.btnPKaydet.Size = new System.Drawing.Size(144, 35);
            this.btnPKaydet.TabIndex = 14;
            this.btnPKaydet.Text = "KAYDET";
            this.btnPKaydet.UseVisualStyleBackColor = true;
            this.btnPKaydet.Click += new System.EventHandler(this.btnPKaydet_Click);
            // 
            // txtUserTel
            // 
            this.txtUserTel.Location = new System.Drawing.Point(168, 178);
            this.txtUserTel.Name = "txtUserTel";
            this.txtUserTel.Size = new System.Drawing.Size(193, 34);
            this.txtUserTel.TabIndex = 11;
            // 
            // lblPTel
            // 
            this.lblPTel.AutoSize = true;
            this.lblPTel.Location = new System.Drawing.Point(32, 181);
            this.lblPTel.Name = "lblPTel";
            this.lblPTel.Size = new System.Drawing.Size(130, 25);
            this.lblPTel.TabIndex = 10;
            this.lblPTel.Text = "TELEFON:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(701, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 203);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(25, 85);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(213, 203);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // txtUserSifre
            // 
            this.txtUserSifre.Location = new System.Drawing.Point(168, 270);
            this.txtUserSifre.Name = "txtUserSifre";
            this.txtUserSifre.Size = new System.Drawing.Size(193, 34);
            this.txtUserSifre.TabIndex = 16;
            // 
            // lblUserSifre
            // 
            this.lblUserSifre.AutoSize = true;
            this.lblUserSifre.Location = new System.Drawing.Point(73, 273);
            this.lblUserSifre.Name = "lblUserSifre";
            this.lblUserSifre.Size = new System.Drawing.Size(89, 25);
            this.lblUserSifre.TabIndex = 15;
            this.lblUserSifre.Text = "ŞİFRE:";
            // 
            // txtUserRol
            // 
            this.txtUserRol.Location = new System.Drawing.Point(168, 313);
            this.txtUserRol.Name = "txtUserRol";
            this.txtUserRol.Size = new System.Drawing.Size(193, 34);
            this.txtUserRol.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "YETKİ:";
            // 
            // FrmPersonelIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(936, 501);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmPersonelIslemleri";
            this.Text = "FrmPersonelIslemleri";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox mtbUserMail;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.MaskedTextBox txtUserSoyad;
        private System.Windows.Forms.MaskedTextBox mtbUserTC;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.TextBox txtUserAd;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.TextBox txtUserTel;
        private System.Windows.Forms.Label lblPTel;
        private System.Windows.Forms.Button btnPKaydet;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtUserSifre;
        private System.Windows.Forms.Label lblUserSifre;
        private System.Windows.Forms.TextBox txtUserRol;
        private System.Windows.Forms.Label label1;
    }
}