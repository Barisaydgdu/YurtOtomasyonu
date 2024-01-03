namespace YurtOtomasyonu
{
    partial class FrmOgrenciListesi
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.yurtOtomasyonDataSet = new YurtOtomasyonu.YurtOtomasyonDataSet();
            this.tblKullaniciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblKullaniciTableAdapter = new YurtOtomasyonu.YurtOtomasyonDataSetTableAdapters.tblKullaniciTableAdapter();
            this.kullaniciAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullaniciSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullaniciTelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullaniciMailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullaniciDYiliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullaniciTCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKullaniciBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(24, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(950, 521);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "                    ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(282, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Öğrenci Listesi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kullaniciAdDataGridViewTextBoxColumn,
            this.kullaniciSoyadDataGridViewTextBoxColumn,
            this.kullaniciTelDataGridViewTextBoxColumn,
            this.kullaniciMailDataGridViewTextBoxColumn,
            this.kullaniciDYiliDataGridViewTextBoxColumn,
            this.kullaniciTCDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblKullaniciBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(44, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(804, 470);
            this.dataGridView1.TabIndex = 0;
            // 
            // yurtOtomasyonDataSet
            // 
            this.yurtOtomasyonDataSet.DataSetName = "YurtOtomasyonDataSet";
            this.yurtOtomasyonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblKullaniciBindingSource
            // 
            this.tblKullaniciBindingSource.DataMember = "tblKullanici";
            this.tblKullaniciBindingSource.DataSource = this.yurtOtomasyonDataSet;
            // 
            // tblKullaniciTableAdapter
            // 
            this.tblKullaniciTableAdapter.ClearBeforeFill = true;
            // 
            // kullaniciAdDataGridViewTextBoxColumn
            // 
            this.kullaniciAdDataGridViewTextBoxColumn.DataPropertyName = "KullaniciAd";
            this.kullaniciAdDataGridViewTextBoxColumn.HeaderText = "KullaniciAd";
            this.kullaniciAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kullaniciAdDataGridViewTextBoxColumn.Name = "kullaniciAdDataGridViewTextBoxColumn";
            this.kullaniciAdDataGridViewTextBoxColumn.Width = 125;
            // 
            // kullaniciSoyadDataGridViewTextBoxColumn
            // 
            this.kullaniciSoyadDataGridViewTextBoxColumn.DataPropertyName = "KullaniciSoyad";
            this.kullaniciSoyadDataGridViewTextBoxColumn.HeaderText = "KullaniciSoyad";
            this.kullaniciSoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kullaniciSoyadDataGridViewTextBoxColumn.Name = "kullaniciSoyadDataGridViewTextBoxColumn";
            this.kullaniciSoyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // kullaniciTelDataGridViewTextBoxColumn
            // 
            this.kullaniciTelDataGridViewTextBoxColumn.DataPropertyName = "KullaniciTel";
            this.kullaniciTelDataGridViewTextBoxColumn.HeaderText = "KullaniciTel";
            this.kullaniciTelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kullaniciTelDataGridViewTextBoxColumn.Name = "kullaniciTelDataGridViewTextBoxColumn";
            this.kullaniciTelDataGridViewTextBoxColumn.Width = 125;
            // 
            // kullaniciMailDataGridViewTextBoxColumn
            // 
            this.kullaniciMailDataGridViewTextBoxColumn.DataPropertyName = "KullaniciMail";
            this.kullaniciMailDataGridViewTextBoxColumn.HeaderText = "KullaniciMail";
            this.kullaniciMailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kullaniciMailDataGridViewTextBoxColumn.Name = "kullaniciMailDataGridViewTextBoxColumn";
            this.kullaniciMailDataGridViewTextBoxColumn.Width = 125;
            // 
            // kullaniciDYiliDataGridViewTextBoxColumn
            // 
            this.kullaniciDYiliDataGridViewTextBoxColumn.DataPropertyName = "KullaniciDYili";
            this.kullaniciDYiliDataGridViewTextBoxColumn.HeaderText = "KullaniciDYili";
            this.kullaniciDYiliDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kullaniciDYiliDataGridViewTextBoxColumn.Name = "kullaniciDYiliDataGridViewTextBoxColumn";
            this.kullaniciDYiliDataGridViewTextBoxColumn.Width = 125;
            // 
            // kullaniciTCDataGridViewTextBoxColumn
            // 
            this.kullaniciTCDataGridViewTextBoxColumn.DataPropertyName = "KullaniciTC";
            this.kullaniciTCDataGridViewTextBoxColumn.HeaderText = "KullaniciTC";
            this.kullaniciTCDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kullaniciTCDataGridViewTextBoxColumn.Name = "kullaniciTCDataGridViewTextBoxColumn";
            this.kullaniciTCDataGridViewTextBoxColumn.Width = 125;
            // 
            // FrmOgrenciListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1036, 617);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FrmOgrenciListesi";
            this.Text = "FrmOgrenciListesi";
            this.Load += new System.EventHandler(this.FrmOgrenciListesi_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKullaniciBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private YurtOtomasyonDataSet yurtOtomasyonDataSet;
        private System.Windows.Forms.BindingSource tblKullaniciBindingSource;
        private YurtOtomasyonDataSetTableAdapters.tblKullaniciTableAdapter tblKullaniciTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullaniciAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullaniciSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullaniciTelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullaniciMailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullaniciDYiliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullaniciTCDataGridViewTextBoxColumn;
    }
}