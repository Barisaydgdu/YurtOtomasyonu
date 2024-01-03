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
    public partial class FrmOgrenciListesi : Form
    {
        public FrmOgrenciListesi()
        {
            InitializeComponent();
            gridviewUpdate();
        }
        YurtOtomasyonEntities db = new YurtOtomasyonEntities();
        private void gridviewUpdate()
        {
            dataGridView1.DataSource = db.tblKullanici.Where(p=> p.RolID==3).ToList();
        }

        private void FrmOgrenciListesi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtOtomasyonDataSet.tblKullanici' table. You can move, or remove it, as needed.
            this.tblKullaniciTableAdapter.Fill(this.yurtOtomasyonDataSet.tblKullanici);
            
        }
    }
}
