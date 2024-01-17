using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YurtOtomasyonu.ServiceReference1;

namespace YurtOtomasyonu
{
    public partial class FrmKullaniciIslemleri : Form
    {
        public FrmKullaniciIslemleri()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var yetki = comboBox1.SelectedValue;
            YurtOtomasyonEntities vt = new YurtOtomasyonEntities();
            
        }

        private void FrmKullaniciIslemleri_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtOtomasyonDataSet1.tblRol' table. You can move, or remove it, as needed.
            this.tblRolTableAdapter1.Fill(this.yurtOtomasyonDataSet1.tblRol);
            // TODO: This line of code loads data into the 'yurtOtomasyonDataSet.tblKullanici' table. You can move, or remove it, as needed.
            this.tblKullaniciTableAdapter.Fill(this.yurtOtomasyonDataSet.tblKullanici);
            // TODO: This line of code loads data into the 'yurtOtomasyonDataSet.tblOda' table. You can move, or remove it, as needed.
            this.tblOdaTableAdapter.Fill(this.yurtOtomasyonDataSet.tblOda);

        }

        private void btnPKaydet_Click(object sender, EventArgs e)
        {
            using (YurtOtomasyonEntities db = new YurtOtomasyonEntities())
            {
                var transaction = db.Database.BeginTransaction();

                long TCNO = Convert.ToInt64(mtbUserTC.Text);
                int dYili = Convert.ToInt32(txtUserDY.Text);
                string ad = txtUserAd.Text.ToUpper();
                string soyad = txtUserSoyad.Text.ToUpper();
                KPSPublicSoapClient dogrulama = new KPSPublicSoapClient();
                bool gercek = dogrulama.TCKimlikNoDogrula(TCNO, ad, soyad, dYili);
                int yetki = Convert.ToInt32(comboBox1.SelectedValue);

                if (gercek == true)
                {
                    try
                    {
                        tblKullanici user = new tblKullanici();

                        user.KullaniciAd = txtUserAd.Text;
                        user.KullaniciSoyad = txtUserSoyad.Text;
                        user.KullaniciTC = mtbUserTC.Text;
                        user.KullaniciMail = mtbUserMail.Text;
                        user.KullaniciTel = txtUserTel.Text;
                        user.KullaniciSifre = txtUserSifre.Text;
                        user.KullaniciDYili = Convert.ToInt32(txtUserDY.Text);
                        user.RolID = yetki;
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
                else
                {
                    MessageBox.Show("Doğrulama Başarısız!");
                }


            }

        }

        private void mtbUserMail_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
