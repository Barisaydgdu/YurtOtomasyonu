namespace YurtOtomasyonu
{
    partial class FrmOdaBilgileri
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.odaNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odaMevcutKisiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odaKapasiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odaAktiflikDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tblOdaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurtOtomasyonDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurtOtomasyonDataSet = new YurtOtomasyonu.YurtOtomasyonDataSet();
            this.lblOdaSayisi = new System.Windows.Forms.Label();
            this.lblBosOda = new System.Windows.Forms.Label();
            this.lblKacBos = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tblOdaTableAdapter = new YurtOtomasyonu.YurtOtomasyonDataSetTableAdapters.tblOdaTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblOdaUyari = new System.Windows.Forms.Label();
            this.txtOgrOdaNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPKaydet = new System.Windows.Forms.Button();
            this.mtbOgrEkleTC = new System.Windows.Forms.MaskedTextBox();
            this.lblTC = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtOdaNo = new System.Windows.Forms.TextBox();
            this.btnOdaSorgu = new System.Windows.Forms.Button();
            this.tblPersonelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblOgrenciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblOgrenciTableAdapter = new YurtOtomasyonu.YurtOtomasyonDataSetTableAdapters.tblOgrenciTableAdapter();
            this.tblPersonelTableAdapter = new YurtOtomasyonu.YurtOtomasyonDataSetTableAdapters.tblPersonelTableAdapter();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOdaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOgrenciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(31, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(607, 387);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.odaNoDataGridViewTextBoxColumn,
            this.odaMevcutKisiDataGridViewTextBoxColumn,
            this.odaKapasiteDataGridViewTextBoxColumn,
            this.odaAktiflikDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.tblOdaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(26, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(551, 279);
            this.dataGridView1.TabIndex = 0;
            // 
            // odaNoDataGridViewTextBoxColumn
            // 
            this.odaNoDataGridViewTextBoxColumn.DataPropertyName = "OdaNo";
            this.odaNoDataGridViewTextBoxColumn.HeaderText = "OdaNo";
            this.odaNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.odaNoDataGridViewTextBoxColumn.Name = "odaNoDataGridViewTextBoxColumn";
            this.odaNoDataGridViewTextBoxColumn.Width = 113;
            // 
            // odaMevcutKisiDataGridViewTextBoxColumn
            // 
            this.odaMevcutKisiDataGridViewTextBoxColumn.DataPropertyName = "OdaMevcutKisi";
            this.odaMevcutKisiDataGridViewTextBoxColumn.HeaderText = "OdaMevcutKisi";
            this.odaMevcutKisiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.odaMevcutKisiDataGridViewTextBoxColumn.Name = "odaMevcutKisiDataGridViewTextBoxColumn";
            this.odaMevcutKisiDataGridViewTextBoxColumn.Width = 125;
            // 
            // odaKapasiteDataGridViewTextBoxColumn
            // 
            this.odaKapasiteDataGridViewTextBoxColumn.DataPropertyName = "OdaKapasite";
            this.odaKapasiteDataGridViewTextBoxColumn.HeaderText = "OdaKapasite";
            this.odaKapasiteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.odaKapasiteDataGridViewTextBoxColumn.Name = "odaKapasiteDataGridViewTextBoxColumn";
            this.odaKapasiteDataGridViewTextBoxColumn.Width = 125;
            // 
            // odaAktiflikDataGridViewCheckBoxColumn
            // 
            this.odaAktiflikDataGridViewCheckBoxColumn.DataPropertyName = "OdaAktiflik";
            this.odaAktiflikDataGridViewCheckBoxColumn.HeaderText = "OdaAktiflik";
            this.odaAktiflikDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.odaAktiflikDataGridViewCheckBoxColumn.Name = "odaAktiflikDataGridViewCheckBoxColumn";
            this.odaAktiflikDataGridViewCheckBoxColumn.Width = 125;
            // 
            // tblOdaBindingSource
            // 
            this.tblOdaBindingSource.DataMember = "tblOda";
            this.tblOdaBindingSource.DataSource = this.yurtOtomasyonDataSetBindingSource;
            // 
            // yurtOtomasyonDataSetBindingSource
            // 
            this.yurtOtomasyonDataSetBindingSource.DataSource = this.yurtOtomasyonDataSet;
            this.yurtOtomasyonDataSetBindingSource.Position = 0;
            // 
            // yurtOtomasyonDataSet
            // 
            this.yurtOtomasyonDataSet.DataSetName = "YurtOtomasyonDataSet";
            this.yurtOtomasyonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblOdaSayisi
            // 
            this.lblOdaSayisi.AutoSize = true;
            this.lblOdaSayisi.Location = new System.Drawing.Point(215, 9);
            this.lblOdaSayisi.Name = "lblOdaSayisi";
            this.lblOdaSayisi.Size = new System.Drawing.Size(118, 25);
            this.lblOdaSayisi.TabIndex = 3;
            this.lblOdaSayisi.Text = "Oda Sayısı";
            // 
            // lblBosOda
            // 
            this.lblBosOda.AutoSize = true;
            this.lblBosOda.Location = new System.Drawing.Point(410, 9);
            this.lblBosOda.Name = "lblBosOda";
            this.lblBosOda.Size = new System.Drawing.Size(161, 25);
            this.lblBosOda.TabIndex = 4;
            this.lblBosOda.Text = "Boş Oda Sayısı";
            // 
            // lblKacBos
            // 
            this.lblKacBos.AutoSize = true;
            this.lblKacBos.Font = new System.Drawing.Font("MV Boli", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKacBos.Location = new System.Drawing.Point(461, 34);
            this.lblKacBos.Name = "lblKacBos";
            this.lblKacBos.Size = new System.Drawing.Size(49, 49);
            this.lblKacBos.TabIndex = 6;
            this.lblKacBos.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(250, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 49);
            this.label2.TabIndex = 7;
            this.label2.Text = "0";
            // 
            // tblOdaTableAdapter
            // 
            this.tblOdaTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblOdaUyari);
            this.groupBox2.Controls.Add(this.txtOgrOdaNo);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnPKaydet);
            this.groupBox2.Controls.Add(this.mtbOgrEkleTC);
            this.groupBox2.Controls.Add(this.lblTC);
            this.groupBox2.Location = new System.Drawing.Point(31, 501);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(391, 223);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Öğrenci Kayıt";
            // 
            // lblOdaUyari
            // 
            this.lblOdaUyari.AutoSize = true;
            this.lblOdaUyari.Location = new System.Drawing.Point(212, 173);
            this.lblOdaUyari.Name = "lblOdaUyari";
            this.lblOdaUyari.Size = new System.Drawing.Size(0, 25);
            this.lblOdaUyari.TabIndex = 19;
            // 
            // txtOgrOdaNo
            // 
            this.txtOgrOdaNo.Location = new System.Drawing.Point(168, 70);
            this.txtOgrOdaNo.Name = "txtOgrOdaNo";
            this.txtOgrOdaNo.Size = new System.Drawing.Size(193, 34);
            this.txtOgrOdaNo.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "ODA:";
            // 
            // btnPKaydet
            // 
            this.btnPKaydet.Location = new System.Drawing.Point(217, 122);
            this.btnPKaydet.Name = "btnPKaydet";
            this.btnPKaydet.Size = new System.Drawing.Size(144, 35);
            this.btnPKaydet.TabIndex = 14;
            this.btnPKaydet.Text = "KAYDET";
            this.btnPKaydet.UseVisualStyleBackColor = true;
            this.btnPKaydet.Click += new System.EventHandler(this.btnPKaydet_Click);
            // 
            // mtbOgrEkleTC
            // 
            this.mtbOgrEkleTC.Location = new System.Drawing.Point(168, 21);
            this.mtbOgrEkleTC.Mask = "00000000000";
            this.mtbOgrEkleTC.Name = "mtbOgrEkleTC";
            this.mtbOgrEkleTC.Size = new System.Drawing.Size(193, 34);
            this.mtbOgrEkleTC.TabIndex = 1;
            this.mtbOgrEkleTC.ValidatingType = typeof(int);
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView3);
            this.groupBox3.Location = new System.Drawing.Point(655, 86);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(368, 306);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // txtOdaNo
            // 
            this.txtOdaNo.Location = new System.Drawing.Point(684, 424);
            this.txtOdaNo.Name = "txtOdaNo";
            this.txtOdaNo.Size = new System.Drawing.Size(125, 34);
            this.txtOdaNo.TabIndex = 16;
            // 
            // btnOdaSorgu
            // 
            this.btnOdaSorgu.Location = new System.Drawing.Point(844, 424);
            this.btnOdaSorgu.Name = "btnOdaSorgu";
            this.btnOdaSorgu.Size = new System.Drawing.Size(144, 35);
            this.btnOdaSorgu.TabIndex = 15;
            this.btnOdaSorgu.Text = "SORGULA";
            this.btnOdaSorgu.UseVisualStyleBackColor = true;
            this.btnOdaSorgu.Click += new System.EventHandler(this.btnOdaSorgu_Click);
            // 
            // tblPersonelBindingSource
            // 
            this.tblPersonelBindingSource.DataMember = "tblPersonel";
            this.tblPersonelBindingSource.DataSource = this.yurtOtomasyonDataSetBindingSource;
            // 
            // tblOgrenciBindingSource
            // 
            this.tblOgrenciBindingSource.DataMember = "tblOgrenci";
            this.tblOgrenciBindingSource.DataSource = this.yurtOtomasyonDataSetBindingSource;
            // 
            // tblOgrenciTableAdapter
            // 
            this.tblOgrenciTableAdapter.ClearBeforeFill = true;
            // 
            // tblPersonelTableAdapter
            // 
            this.tblPersonelTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(3, 30);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(362, 273);
            this.dataGridView3.TabIndex = 10;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // FrmOdaBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1101, 828);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.txtOdaNo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnOdaSorgu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblKacBos);
            this.Controls.Add(this.lblBosOda);
            this.Controls.Add(this.lblOdaSayisi);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOdaBilgileri";
            this.Text = "FrmOdaBilgileri";
            this.Load += new System.EventHandler(this.FrmOdaBilgileri_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOdaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOgrenciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblOdaSayisi;
        private System.Windows.Forms.Label lblBosOda;
        private System.Windows.Forms.Label lblKacBos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource yurtOtomasyonDataSetBindingSource;
        private YurtOtomasyonDataSet yurtOtomasyonDataSet;
        private System.Windows.Forms.BindingSource tblOdaBindingSource;
        private YurtOtomasyonDataSetTableAdapters.tblOdaTableAdapter tblOdaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn odaNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odaMevcutKisiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odaKapasiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn odaAktiflikDataGridViewCheckBoxColumn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtOgrOdaNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPKaydet;
        private System.Windows.Forms.MaskedTextBox mtbOgrEkleTC;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.Label lblOdaUyari;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.BindingSource tblOgrenciBindingSource;
        private YurtOtomasyonDataSetTableAdapters.tblOgrenciTableAdapter tblOgrenciTableAdapter;
        private System.Windows.Forms.Button btnOdaSorgu;
        private System.Windows.Forms.TextBox txtOdaNo;
        private System.Windows.Forms.BindingSource tblPersonelBindingSource;
        private YurtOtomasyonDataSetTableAdapters.tblPersonelTableAdapter tblPersonelTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView3;
    }
}