using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ForzaYazilim
{
    public partial class FrmRaporlar : DevExpress.XtraEditors.XtraUserControl
    {
        private static FrmRaporlar _instance;

        public static FrmRaporlar Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new FrmRaporlar();
                return _instance;
            }
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        void listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from TBLHARAKETLER",bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl.DataSource = dt;
        }
        public FrmRaporlar()
        {
            InitializeComponent();
            listele();
    
        
        }
        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl.ShowRibbonPrintPreview();
        }

        private void bbiRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            listele();
        }
        private void gridControl_Click(object sender, EventArgs e)
        {
            DataRow dr = gridView.GetDataRow(gridView.FocusedRowHandle);
            if (dr != null)
            {
                lblaydi.Text = dr["id"].ToString();

            }
        }
        private void bbiDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult secenek = XtraMessageBox.Show( "Öğeyi veritabanından silmek istediğinize emin misiniz?", "Bildirim", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secenek == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("delete from TBLHARAKETLER where id=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", lblaydi.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                XtraMessageBox.Show("Ürün haraketi silindi.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
            }
            else if (secenek == DialogResult.No)
            {

            }
        }

    
    }
}
