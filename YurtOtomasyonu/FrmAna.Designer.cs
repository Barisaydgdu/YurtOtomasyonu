namespace YurtOtomasyonu
{
    partial class FrmAna
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
            this.mnOgrenci = new System.Windows.Forms.MenuStrip();
            this.asdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odaBilgisiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ödemeSayfasıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnPersonel = new System.Windows.Forms.MenuStrip();
            this.personelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odaBilgisiToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnYetkili = new System.Windows.Forms.MenuStrip();
            this.yetkiliSayfasıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmOgrenciEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.personelEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odaBilgisiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yetkiliSayfasıToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnOgrenci.SuspendLayout();
            this.mnPersonel.SuspendLayout();
            this.mnYetkili.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnOgrenci
            // 
            this.mnOgrenci.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnOgrenci.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asdToolStripMenuItem,
            this.odaBilgisiToolStripMenuItem1,
            this.ödemeSayfasıToolStripMenuItem});
            this.mnOgrenci.Location = new System.Drawing.Point(0, 60);
            this.mnOgrenci.Name = "mnOgrenci";
            this.mnOgrenci.Padding = new System.Windows.Forms.Padding(14, 3, 0, 3);
            this.mnOgrenci.Size = new System.Drawing.Size(776, 30);
            this.mnOgrenci.TabIndex = 0;
            this.mnOgrenci.Text = "mnOgrenci";
            // 
            // asdToolStripMenuItem
            // 
            this.asdToolStripMenuItem.Name = "asdToolStripMenuItem";
            this.asdToolStripMenuItem.Size = new System.Drawing.Size(125, 24);
            this.asdToolStripMenuItem.Text = "Öğrenci Sayfası";
            // 
            // odaBilgisiToolStripMenuItem1
            // 
            this.odaBilgisiToolStripMenuItem1.Name = "odaBilgisiToolStripMenuItem1";
            this.odaBilgisiToolStripMenuItem1.Size = new System.Drawing.Size(95, 24);
            this.odaBilgisiToolStripMenuItem1.Text = "Oda Bilgisi";
            // 
            // ödemeSayfasıToolStripMenuItem
            // 
            this.ödemeSayfasıToolStripMenuItem.Name = "ödemeSayfasıToolStripMenuItem";
            this.ödemeSayfasıToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.ödemeSayfasıToolStripMenuItem.Text = "Ödeme Sayfası";
            // 
            // mnPersonel
            // 
            this.mnPersonel.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnPersonel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personelToolStripMenuItem,
            this.öğrenciEkleToolStripMenuItem,
            this.odaBilgisiToolStripMenuItem2});
            this.mnPersonel.Location = new System.Drawing.Point(0, 30);
            this.mnPersonel.Name = "mnPersonel";
            this.mnPersonel.Padding = new System.Windows.Forms.Padding(14, 3, 0, 3);
            this.mnPersonel.Size = new System.Drawing.Size(776, 30);
            this.mnPersonel.TabIndex = 1;
            this.mnPersonel.Text = "mnPersonel";
            // 
            // personelToolStripMenuItem
            // 
            this.personelToolStripMenuItem.Name = "personelToolStripMenuItem";
            this.personelToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.personelToolStripMenuItem.Text = "Personel Sayfası";
            // 
            // öğrenciEkleToolStripMenuItem
            // 
            this.öğrenciEkleToolStripMenuItem.Name = "öğrenciEkleToolStripMenuItem";
            this.öğrenciEkleToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.öğrenciEkleToolStripMenuItem.Text = "Öğrenci Ekle";
            this.öğrenciEkleToolStripMenuItem.Click += new System.EventHandler(this.öğrenciEkleToolStripMenuItem_Click);
            // 
            // odaBilgisiToolStripMenuItem2
            // 
            this.odaBilgisiToolStripMenuItem2.Name = "odaBilgisiToolStripMenuItem2";
            this.odaBilgisiToolStripMenuItem2.Size = new System.Drawing.Size(95, 24);
            this.odaBilgisiToolStripMenuItem2.Text = "Oda Bilgisi";
            this.odaBilgisiToolStripMenuItem2.Click += new System.EventHandler(this.odaBilgisiToolStripMenuItem2_Click);
            // 
            // mnYetkili
            // 
            this.mnYetkili.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnYetkili.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yetkiliSayfasıToolStripMenuItem,
            this.personelEkleToolStripMenuItem,
            this.odaBilgisiToolStripMenuItem,
            this.yetkiliSayfasıToolStripMenuItem1});
            this.mnYetkili.Location = new System.Drawing.Point(0, 0);
            this.mnYetkili.Name = "mnYetkili";
            this.mnYetkili.Padding = new System.Windows.Forms.Padding(14, 3, 0, 3);
            this.mnYetkili.Size = new System.Drawing.Size(776, 30);
            this.mnYetkili.TabIndex = 2;
            this.mnYetkili.Text = "mnYetkili";
            // 
            // yetkiliSayfasıToolStripMenuItem
            // 
            this.yetkiliSayfasıToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmOgrenciEkle});
            this.yetkiliSayfasıToolStripMenuItem.Name = "yetkiliSayfasıToolStripMenuItem";
            this.yetkiliSayfasıToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.yetkiliSayfasıToolStripMenuItem.Text = "Öğrenci Ekle";
            this.yetkiliSayfasıToolStripMenuItem.Click += new System.EventHandler(this.yetkiliSayfasıToolStripMenuItem_Click);
            // 
            // tsmOgrenciEkle
            // 
            this.tsmOgrenciEkle.Name = "tsmOgrenciEkle";
            this.tsmOgrenciEkle.Size = new System.Drawing.Size(175, 26);
            this.tsmOgrenciEkle.Text = "Öğrenci Ekle";
            this.tsmOgrenciEkle.Click += new System.EventHandler(this.tsmOgrenciEkle_Click);
            // 
            // personelEkleToolStripMenuItem
            // 
            this.personelEkleToolStripMenuItem.Name = "personelEkleToolStripMenuItem";
            this.personelEkleToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.personelEkleToolStripMenuItem.Text = "Personel Ekle";
            this.personelEkleToolStripMenuItem.Click += new System.EventHandler(this.personelEkleToolStripMenuItem_Click);
            // 
            // odaBilgisiToolStripMenuItem
            // 
            this.odaBilgisiToolStripMenuItem.Name = "odaBilgisiToolStripMenuItem";
            this.odaBilgisiToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.odaBilgisiToolStripMenuItem.Text = "Oda Bilgisi";
            this.odaBilgisiToolStripMenuItem.Click += new System.EventHandler(this.odaBilgisiToolStripMenuItem_Click);
            // 
            // yetkiliSayfasıToolStripMenuItem1
            // 
            this.yetkiliSayfasıToolStripMenuItem1.Name = "yetkiliSayfasıToolStripMenuItem1";
            this.yetkiliSayfasıToolStripMenuItem1.Size = new System.Drawing.Size(110, 24);
            this.yetkiliSayfasıToolStripMenuItem1.Text = "yetkili sayfası";
            // 
            // FrmAna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(776, 381);
            this.Controls.Add(this.mnOgrenci);
            this.Controls.Add(this.mnPersonel);
            this.Controls.Add(this.mnYetkili);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnOgrenci;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmAna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAna";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmAna_Load);
            this.mnOgrenci.ResumeLayout(false);
            this.mnOgrenci.PerformLayout();
            this.mnPersonel.ResumeLayout(false);
            this.mnPersonel.PerformLayout();
            this.mnYetkili.ResumeLayout(false);
            this.mnYetkili.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnOgrenci;
        private System.Windows.Forms.ToolStripMenuItem asdToolStripMenuItem;
        private System.Windows.Forms.MenuStrip mnPersonel;
        private System.Windows.Forms.ToolStripMenuItem personelToolStripMenuItem;
        private System.Windows.Forms.MenuStrip mnYetkili;
        private System.Windows.Forms.ToolStripMenuItem yetkiliSayfasıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odaBilgisiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yetkiliSayfasıToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmOgrenciEkle;
        private System.Windows.Forms.ToolStripMenuItem odaBilgisiToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ödemeSayfasıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odaBilgisiToolStripMenuItem2;
    }
}