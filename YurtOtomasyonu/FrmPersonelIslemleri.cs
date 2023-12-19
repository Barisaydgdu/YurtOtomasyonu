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
    public partial class FrmPersonelIslemleri : Form
    {
        public FrmPersonelIslemleri()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblMaas_Click(object sender, EventArgs e)
        {

        }

        private void btnPKaydet_Click(object sender, EventArgs e)
        {
            using (YurtOtomasyonEntities db = new YurtOtomasyonEntities())
            {
                var transaction =  db.Database.BeginTransaction();
                try
                {
                    tblKullanici user = new tblKullanici();

                    user.KullaniciAd = txtUserAd.Text;
                    user.KullaniciSoyad = txtUserSoyad.Text;
                    user.KullaniciTC = mtbUserTC.Text;
                    user.KullaniciMail = mtbUserMail.Text;
                    user.KullaniciTel = txtUserTel.Text;
                    user.KullaniciSifre = txtUserSifre.Text;
                    user.RolID = Convert.ToInt16(txtUserRol.Text);
                    db.tblKullanici.Add(user);
                    int sonuc = db.SaveChanges();
                    if (sonuc > 0)
                    {
                        transaction.Commit();
                        MessageBox.Show("Kayıt Yapıldı");
                        db.SaveChanges();
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Kayıt Yapılamadı.");

                }
            }

        }               
    }
}
