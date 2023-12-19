using System;
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
    public partial class FrmOgrenciEkleme : Form
    {
        public FrmOgrenciEkleme()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (YurtOtomasyonEntities db = new YurtOtomasyonEntities())
            {
                var transaction = db.Database.BeginTransaction();
                try
                {
                    tblOgrenci ogr = new tblOgrenci();
                    ogr.OgrenciAd = txtOgrAd.Text;
                    ogr.OgrenciSoyad = txtOgrSoyad.Text;
                    ogr.OgrenciTC = mtbOgrTC.Text;
                    ogr.OgrenciMail = txtOgrMail.Text;
                    ogr.OgrenciOdaID = Convert.ToInt32(txtOdaNo.Text);
                    ogr.OgrenciVeliAd = txtVeliAd.Text;
                    ogr.OgrenciVeliSoyad = txtVeliSoyad.Text;
                    ogr.OgrenciVeliTel = mtbVeliTel.Text;
                    ogr.OgrenciTelefon = mtbOgrTel.Text;
                    ogr.OgrenciDYılı = Convert.ToInt32(txtOgrDT.Text);                    
                    db.tblOgrenci.Add(ogr);
                    int sonuc = db.SaveChanges();
                    if (sonuc > 0)
                    {
                        transaction.Commit();
                        MessageBox.Show("Kayıt Yapıldı");
                        db.SaveChanges();
                    }
                }
                catch (Exception hata)
                {
                    transaction.Rollback();
                    MessageBox.Show("Kayıt Yapılamadı.");
                   
                }
            }
            
            //if (sonuc > 0)
            //{
            //    MessageBox.Show("Kayıt Başarılı");

            //}
            //else
            //{
            //    MessageBox.Show("Kayıt Başarısız");
            //}


        }
    }
}
