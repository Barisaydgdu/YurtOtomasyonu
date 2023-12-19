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
    public partial class FrmOgrenciGiris : Form
    {
        public tblKullanici GirisyapanKullanici;
        public FrmOgrenciGiris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string KullaniciTC = mtbKullaniciTC.Text;
            string KullaniciSifre = txtKullaniciSifre.Text;
            

            if (string.IsNullOrEmpty(KullaniciTC) || string.IsNullOrEmpty(KullaniciSifre))
            {
                MessageBox.Show("Boş Bırakılamaz.");
            }
            else
            {
                YurtOtomasyonEntities db = new YurtOtomasyonEntities();
                GirisyapanKullanici = db.tblKullanici.FirstOrDefault(p => p.KullaniciTC== KullaniciTC && p.KullaniciSifre== KullaniciSifre);
                
                if (GirisyapanKullanici != null)
                {
                    mtbKullaniciTC.Clear();
                    txtKullaniciSifre.Clear();
                    FrmAna frmOrtak = new FrmAna(GirisyapanKullanici);
                    frmOrtak.Show();
                    //this.Hide();
                }
            }
        }
    }
}
