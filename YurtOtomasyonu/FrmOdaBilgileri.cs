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
    public partial class FrmOdaBilgileri : Form
    {
        public FrmOdaBilgileri()
        {
            InitializeComponent();
        }
        YurtOtomasyonEntities db = new YurtOtomasyonEntities();

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmOdaBilgileri_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtOtomasyonDataSet.tblOda' table. You can move, or remove it, as needed.
            this.tblOdaTableAdapter.Fill(this.yurtOtomasyonDataSet.tblOda);

            lblKacBos.Text = db.tblOda.Count(p => p.OdaMevcutKisi == 0).ToString();
            label2.Text = db.tblOda.Count().ToString();
            
        }

        private void btnPKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                int odaNO = Convert.ToInt32(txtOgrOdaNo.Text);
                string guncellenecekTC = mtbOgrEkleTC.Text;

                tblKullanici SwapRoom = db.tblKullanici.FirstOrDefault(p => p.KullaniciTC == guncellenecekTC);

                if (SwapRoom != null)
                {
                    int eskiOdaID = SwapRoom.OdaID ?? 0;

                    int yeniOdaID = Convert.ToInt32(txtOgrOdaNo.Text);

                    // Odanın mevcut kapasitesini kontrol et
                    tblOda yeniOda = db.tblOda.FirstOrDefault(o => o.OdaID == yeniOdaID);
                    if (yeniOda != null && yeniOda.OdaMevcutKisi < yeniOda.OdaKapasite)
                    {
                        // Odanın mevcut kapasitesi dolu değilse devam et

                        SwapRoom.OdaID = yeniOdaID;

                        if (eskiOdaID > 0)
                        {
                            tblOda eskiOda = db.tblOda.FirstOrDefault(o => o.OdaID == eskiOdaID);
                            if (eskiOda != null && eskiOda.OdaMevcutKisi > 0)
                            {
                                eskiOda.OdaMevcutKisi--;
                            }
                        }

                        yeniOda.OdaMevcutKisi++;

                        int kayitSonuc = db.SaveChanges();

                        if (kayitSonuc > 0)
                        {
                            lblOdaUyari.Text = "İşlem Başarılı!";
                            RefreshDataGridView();
                        }
                        else
                        {
                            lblOdaUyari.Text = "İşlem Başarısız!";
                        }
                    }
                    else
                    {
                        lblOdaUyari.Text = "Oda kapasitesi dolu. Başka bir oda seçiniz.";
                    }
                }
                else
                {
                    lblOdaUyari.Text = "Öğrenci bulunamadı.";
                }
            }
            catch (Exception ex)
            {
                lblOdaUyari.Text = "Hata oluştu: " + ex.Message;
            }
        }

        private void RefreshDataGridView()
        {
            dataGridView1.DataSource = db.tblOda.ToList();
        }
    }
}
