namespace YurtOtomasyonu
{
    partial class FrmKullaniciIslemleri
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKullaniciIslemleri));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tblRolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurtOtomasyonDataSet = new YurtOtomasyonu.YurtOtomasyonDataSet();
            this.txtUserDY = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserSifre = new System.Windows.Forms.TextBox();
            this.lblUserSifre = new System.Windows.Forms.Label();
            this.btnPKaydet = new System.Windows.Forms.Button();
            this.txtUserAd = new System.Windows.Forms.TextBox();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.mtbUserMail = new System.Windows.Forms.MaskedTextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.txtUserTel = new System.Windows.Forms.TextBox();
            this.txtUserSoyad = new System.Windows.Forms.MaskedTextBox();
            this.lblPTel = new System.Windows.Forms.Label();
            this.mtbUserTC = new System.Windows.Forms.MaskedTextBox();
            this.lblTC = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tblRolTableAdapter = new YurtOtomasyonu.YurtOtomasyonDataSetTableAdapters.tblRolTableAdapter();
            this.tblOdaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblOdaTableAdapter = new YurtOtomasyonu.YurtOtomasyonDataSetTableAdapters.tblOdaTableAdapter();
            this.tblRolBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fKtblKullanicitblRolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblKullaniciTableAdapter = new YurtOtomasyonu.YurtOtomasyonDataSetTableAdapters.tblKullaniciTableAdapter();
            this.yurtOtomasyonDataSet1 = new YurtOtomasyonu.YurtOtomasyonDataSet1();
            this.tblRolBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tblRolTableAdapter1 = new YurtOtomasyonu.YurtOtomasyonDataSet1TableAdapters.tblRolTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblRolBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOdaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRolBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKtblKullanicitblRolBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRolBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.txtUserDY);
            this.groupBox1.Controls.Add(this.label2);
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
            this.groupBox1.Location = new System.Drawing.Point(281, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 477);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kullanıcı Kayıt";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.tblRolBindingSource2;
            this.comboBox1.DisplayMember = "RollAd";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(184, 336);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(193, 33);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.ValueMember = "RolID";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tblRolBindingSource
            // 
            this.tblRolBindingSource.DataMember = "tblRol";
            this.tblRolBindingSource.DataSource = this.yurtOtomasyonDataSet;
            // 
            // yurtOtomasyonDataSet
            // 
            this.yurtOtomasyonDataSet.DataSetName = "YurtOtomasyonDataSet";
            this.yurtOtomasyonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtUserDY
            // 
            this.txtUserDY.Location = new System.Drawing.Point(184, 170);
            this.txtUserDY.Name = "txtUserDY";
            this.txtUserDY.Size = new System.Drawing.Size(193, 34);
            this.txtUserDY.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "DOĞUM YILI:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 339);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "YETKİ:";
            // 
            // txtUserSifre
            // 
            this.txtUserSifre.Location = new System.Drawing.Point(184, 293);
            this.txtUserSifre.Name = "txtUserSifre";
            this.txtUserSifre.Size = new System.Drawing.Size(193, 34);
            this.txtUserSifre.TabIndex = 7;
            this.txtUserSifre.UseSystemPasswordChar = true;
            // 
            // lblUserSifre
            // 
            this.lblUserSifre.AutoSize = true;
            this.lblUserSifre.Location = new System.Drawing.Point(91, 296);
            this.lblUserSifre.Name = "lblUserSifre";
            this.lblUserSifre.Size = new System.Drawing.Size(89, 25);
            this.lblUserSifre.TabIndex = 15;
            this.lblUserSifre.Text = "ŞİFRE:";
            // 
            // btnPKaydet
            // 
            this.btnPKaydet.Location = new System.Drawing.Point(217, 436);
            this.btnPKaydet.Name = "btnPKaydet";
            this.btnPKaydet.Size = new System.Drawing.Size(144, 35);
            this.btnPKaydet.TabIndex = 9;
            this.btnPKaydet.Text = "KAYDET";
            this.btnPKaydet.UseVisualStyleBackColor = true;
            this.btnPKaydet.Click += new System.EventHandler(this.btnPKaydet_Click);
            // 
            // txtUserAd
            // 
            this.txtUserAd.Location = new System.Drawing.Point(185, 73);
            this.txtUserAd.Name = "txtUserAd";
            this.txtUserAd.Size = new System.Drawing.Size(193, 34);
            this.txtUserAd.TabIndex = 2;
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(84, 125);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(97, 25);
            this.lblSoyad.TabIndex = 7;
            this.lblSoyad.Text = "SOYAD:";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(128, 76);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(53, 25);
            this.lblAd.TabIndex = 6;
            this.lblAd.Text = "AD:";
            // 
            // mtbUserMail
            // 
            this.mtbUserMail.Location = new System.Drawing.Point(184, 250);
            this.mtbUserMail.Name = "mtbUserMail";
            this.mtbUserMail.Size = new System.Drawing.Size(193, 34);
            this.mtbUserMail.TabIndex = 6;
            this.mtbUserMail.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbUserMail_MaskInputRejected);
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(97, 259);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(83, 25);
            this.lblMail.TabIndex = 4;
            this.lblMail.Text = "MAİL:";
            // 
            // txtUserTel
            // 
            this.txtUserTel.Location = new System.Drawing.Point(184, 210);
            this.txtUserTel.Name = "txtUserTel";
            this.txtUserTel.Size = new System.Drawing.Size(193, 34);
            this.txtUserTel.TabIndex = 5;
            // 
            // txtUserSoyad
            // 
            this.txtUserSoyad.Location = new System.Drawing.Point(185, 122);
            this.txtUserSoyad.Name = "txtUserSoyad";
            this.txtUserSoyad.Size = new System.Drawing.Size(193, 34);
            this.txtUserSoyad.TabIndex = 3;
            // 
            // lblPTel
            // 
            this.lblPTel.AutoSize = true;
            this.lblPTel.Location = new System.Drawing.Point(50, 213);
            this.lblPTel.Name = "lblPTel";
            this.lblPTel.Size = new System.Drawing.Size(130, 25);
            this.lblPTel.TabIndex = 10;
            this.lblPTel.Text = "TELEFON:";
            // 
            // mtbUserTC
            // 
            this.mtbUserTC.Location = new System.Drawing.Point(185, 21);
            this.mtbUserTC.Mask = "00000000000";
            this.mtbUserTC.Name = "mtbUserTC";
            this.mtbUserTC.Size = new System.Drawing.Size(193, 34);
            this.mtbUserTC.TabIndex = 1;
            this.mtbUserTC.ValidatingType = typeof(int);
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.Location = new System.Drawing.Point(88, 30);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(93, 25);
            this.lblTC.TabIndex = 0;
            this.lblTC.Text = "TC NO:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(701, 85);
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
            // tblRolTableAdapter
            // 
            this.tblRolTableAdapter.ClearBeforeFill = true;
            // 
            // tblOdaBindingSource
            // 
            this.tblOdaBindingSource.DataMember = "tblOda";
            this.tblOdaBindingSource.DataSource = this.yurtOtomasyonDataSet;
            // 
            // tblOdaTableAdapter
            // 
            this.tblOdaTableAdapter.ClearBeforeFill = true;
            // 
            // tblRolBindingSource1
            // 
            this.tblRolBindingSource1.DataMember = "tblRol";
            this.tblRolBindingSource1.DataSource = this.yurtOtomasyonDataSet;
            // 
            // fKtblKullanicitblRolBindingSource
            // 
            this.fKtblKullanicitblRolBindingSource.DataMember = "FK_tblKullanici_tblRol";
            this.fKtblKullanicitblRolBindingSource.DataSource = this.tblRolBindingSource1;
            // 
            // tblKullaniciTableAdapter
            // 
            this.tblKullaniciTableAdapter.ClearBeforeFill = true;
            // 
            // yurtOtomasyonDataSet1
            // 
            this.yurtOtomasyonDataSet1.DataSetName = "YurtOtomasyonDataSet1";
            this.yurtOtomasyonDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblRolBindingSource2
            // 
            this.tblRolBindingSource2.DataMember = "tblRol";
            this.tblRolBindingSource2.DataSource = this.yurtOtomasyonDataSet1;
            // 
            // tblRolTableAdapter1
            // 
            this.tblRolTableAdapter1.ClearBeforeFill = true;
            // 
            // FrmKullaniciIslemleri
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
            this.Name = "FrmKullaniciIslemleri";
            this.Text = "FrmPersonelIslemleri";
            this.Load += new System.EventHandler(this.FrmKullaniciIslemleri_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblRolBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOdaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRolBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKtblKullanicitblRolBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRolBindingSource2)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserDY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private YurtOtomasyonDataSet yurtOtomasyonDataSet;
        private System.Windows.Forms.BindingSource tblRolBindingSource;
        private YurtOtomasyonDataSetTableAdapters.tblRolTableAdapter tblRolTableAdapter;
        private System.Windows.Forms.BindingSource tblOdaBindingSource;
        private YurtOtomasyonDataSetTableAdapters.tblOdaTableAdapter tblOdaTableAdapter;
        private System.Windows.Forms.BindingSource tblRolBindingSource1;
        private System.Windows.Forms.BindingSource fKtblKullanicitblRolBindingSource;
        private YurtOtomasyonDataSetTableAdapters.tblKullaniciTableAdapter tblKullaniciTableAdapter;
        private YurtOtomasyonDataSet1 yurtOtomasyonDataSet1;
        private System.Windows.Forms.BindingSource tblRolBindingSource2;
        private YurtOtomasyonDataSet1TableAdapters.tblRolTableAdapter tblRolTableAdapter1;
    }
}