﻿namespace YurtOtomasyonu
{
    partial class FrmFormGöster
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tblKullaniciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurtOtomasyonDataSet = new YurtOtomasyonu.YurtOtomasyonDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tblKullaniciTableAdapter = new YurtOtomasyonu.YurtOtomasyonDataSetTableAdapters.tblKullaniciTableAdapter();
            this.tblOdaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblOdaTableAdapter = new YurtOtomasyonu.YurtOtomasyonDataSetTableAdapters.tblOdaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tblKullaniciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOdaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tblKullaniciBindingSource
            // 
            this.tblKullaniciBindingSource.DataMember = "tblKullanici";
            this.tblKullaniciBindingSource.DataSource = this.yurtOtomasyonDataSet;
            // 
            // yurtOtomasyonDataSet
            // 
            this.yurtOtomasyonDataSet.DataSetName = "YurtOtomasyonDataSet";
            this.yurtOtomasyonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tblKullaniciBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "YurtOtomasyonu.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(940, 429);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // tblKullaniciTableAdapter
            // 
            this.tblKullaniciTableAdapter.ClearBeforeFill = true;
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
            // FrmFormGöster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 429);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmFormGöster";
            this.Text = "FrmFormGöster";
            this.Load += new System.EventHandler(this.FrmFormGöster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblKullaniciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOdaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private YurtOtomasyonDataSet yurtOtomasyonDataSet;
        private System.Windows.Forms.BindingSource tblKullaniciBindingSource;
        private YurtOtomasyonDataSetTableAdapters.tblKullaniciTableAdapter tblKullaniciTableAdapter;
        private System.Windows.Forms.BindingSource tblOdaBindingSource;
        private YurtOtomasyonDataSetTableAdapters.tblOdaTableAdapter tblOdaTableAdapter;
    }
}