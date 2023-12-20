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
                // burası güncellenmeli -- Güncelleme Kısmında Hata Var. --
                int guncellenecekOda = Convert.ToInt32(txtOgrOdaNo.Text );
                tblKullanici guncellenekKisi = db.tblKullanici.FirstOrDefault(p => p.OdaID == guncellenecekOda);

                if (guncellenekKisi != null)
                {
                    guncellenekKisi.OdaID = Convert.ToInt32(txtOgrOdaNo.Text);

                    db.SaveChanges();

                    
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
