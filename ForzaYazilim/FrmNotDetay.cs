using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ForzaYazilim
{
    public partial class FrmNotDetay : DevExpress.XtraEditors.XtraUserControl
    {
        private static FrmNotDetay _instance;

        public static FrmNotDetay Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new FrmNotDetay();
                return _instance;
            }
        }
        public FrmNotDetay()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();


        private void FrmNotDetay_Load(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult secenek = XtraMessageBox.Show("Notu veritabanına eklemek istediğinize emin misiniz?", "Bildirim", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (secenek == DialogResult.Yes)
                {
                    SqlCommand komut = new SqlCommand("insert into TBLNOTLAR (baslik,detay) values (@p1,@p2)", bgl.baglanti());
                    komut.Parameters.AddWithValue("@p1", txtbaslik.Text);
                    komut.Parameters.AddWithValue("@p2", txtileti.Text);
                    komut.ExecuteNonQuery();
                    XtraMessageBox.Show("Not kayıt başarı ile eklendi", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (secenek == DialogResult.No)
                {

                }
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Notu eklerken bir aksaklık yaşandı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }


    }
}

