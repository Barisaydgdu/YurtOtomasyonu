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
    public partial class FrmFormGöster : Form
    {
        public FrmFormGöster()
        {
            InitializeComponent();
        }

        private void FrmFormGöster_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtOtomasyonDataSet.tblOda' table. You can move, or remove it, as needed.
            this.tblOdaTableAdapter.Fill(this.yurtOtomasyonDataSet.tblOda);
            // TODO: This line of code loads data into the 'yurtOtomasyonDataSet.tblKullanici' table. You can move, or remove it, as needed.
            this.tblKullaniciTableAdapter.Fill(this.yurtOtomasyonDataSet.tblKullanici);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
