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
            // TODO: This line of code loads data into the 'yurtOtomasyonDataSet.tblPersonel' table. You can move, or remove it, as needed.
            this.tblPersonelTableAdapter.Fill(this.yurtOtomasyonDataSet.tblPersonel);
            // TODO: This line of code loads data into the 'yurtOtomasyonDataSet.tblOgrenci' table. You can move, or remove it, as needed.

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
                            RefreshRoomInfo();
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
        private void RefreshRoomInfo()
        {
            lblKacBos.Text = db.tblOda.Count(p => p.OdaMevcutKisi == 0).ToString();
            label2.Text = db.tblOda.Count().ToString();
        }
        private void RefreshSorguGridview()
        {
            YurtOtomasyonEntities vt = new YurtOtomasyonEntities();
            int odaNo = Convert.ToInt32(txtOdaNo.Text);
            dataGridView3.DataSource = db.tblKullanici.Where(P => P.OdaID == odaNo || P.tblOda.OdaNo == odaNo).ToList();
        }
        private void btnOdaSorgu_Click(object sender, EventArgs e)
        {
            try
            {
                int odaID = Convert.ToInt32(txtOdaNo.Text);

                // Belirtilen odada kalan kullanıcıları al
                var kullaniciListesi = db.tblKullanici
                    .Where(k => k.OdaID == odaID && k.tblOda != null)  // tblOda null değilse devam et
                    .Select(k => new
                    {
                        Ad = k.KullaniciAd,
                        Soyad = k.KullaniciSoyad,
                        TCKimlik = k.KullaniciTC,
                        Telefon = k.KullaniciTel,
                        Email = k.KullaniciMail,
                        OdaNo = k.tblOda != null ? k.tblOda.OdaNo : 0  // tblOda null değilse OdaNo'yu al, nullsa 0 olarak ayarla
                    })
                    .ToList();

                // Eğer kullanıcı listesi boşsa uyarı ver
                if (kullaniciListesi.Count == 0)
                {
                    MessageBox.Show("Belirtilen odada kalan kullanıcı bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Kullanıcı bilgilerini üçüncü DataGridView'de göster (dataGridView3)
                    dataGridView3.DataSource = kullaniciListesi;

                    // DataGridView'in sütunlarını düzenle
                    dataGridView3.Columns["Ad"].HeaderText = "Adı";
                    dataGridView3.Columns["Soyad"].HeaderText = "Soyadı";
                    dataGridView3.Columns["TCKimlik"].HeaderText = "TC Kimlik No";
                    dataGridView3.Columns["Telefon"].HeaderText = "Telefon";
                    dataGridView3.Columns["Email"].HeaderText = "E-Posta";
                    dataGridView3.Columns["OdaNo"].HeaderText = "Oda No";

                    // Sütunları düzenle
                    dataGridView3.Columns["Ad"].Visible = true;
                    dataGridView3.Columns["Soyad"].Visible = true;
                    dataGridView3.Columns["TCKimlik"].Visible = true;
                    dataGridView3.Columns["Telefon"].Visible = true;
                    dataGridView3.Columns["Email"].Visible = true;
                    dataGridView3.Columns["OdaNo"].Visible = true;
                }
            }
            catch (Exception ex)
            {
                // Hataları ele al
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
