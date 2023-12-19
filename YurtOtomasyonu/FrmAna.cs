﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YurtOtomasyonu
{
    public partial class FrmAna : Form
    {
        public FrmAna()
        {
            InitializeComponent();
        }
        
        public tblKullanici kullaniciLogin;



        public FrmAna(tblKullanici LoginOlanKullanici)
        {
            InitializeComponent();
            kullaniciLogin = LoginOlanKullanici;

            

            mnYetkili.Visible = false;
            mnPersonel.Visible = false;
            mnOgrenci.Visible = false;
            switch (LoginOlanKullanici.RolID)
            {
                case 1: mnYetkili.Visible = true;break;
                case 2: mnPersonel.Visible = true;break;
                case 3: mnOgrenci.Visible = true;break;
            }

        }

        private void tsmOgrenciEkle_Click(object sender, EventArgs e)
        {
            FrmOgrenciEkleme ogrEkleme = new FrmOgrenciEkleme();
            ogrEkleme.MdiParent = this; 
            ogrEkleme.Show();
        }

        private void yetkiliSayfasıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOgrenciEkleme frmOgrEkle = new FrmOgrenciEkleme();
            frmOgrEkle.MdiParent = this;
            frmOgrEkle.Show();
        }

        private void FrmAna_Load(object sender, EventArgs e)
        {

        }

        private void personelEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPersonelIslemleri frmpersonelEkle = new FrmPersonelIslemleri();
            frmpersonelEkle.MdiParent = this;
            frmpersonelEkle.Show();
        }

        private void öğrenciEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOgrenciEkleme frmOgrEkle = new FrmOgrenciEkleme();
            frmOgrEkle.MdiParent = this;
            frmOgrEkle.Show();
        }
    }
}