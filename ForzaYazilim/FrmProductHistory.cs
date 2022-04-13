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
    public partial class FrmProductHistory : DevExpress.XtraEditors.XtraUserControl
    {
        private static FrmProductHistory _instance;

        public static FrmProductHistory Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new FrmProductHistory();
                return _instance;
            }
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        public static string MyPorperty { get; internal set; }

        void profilno()
        {
            SqlCommand komut = new SqlCommand("select id,ad from tblurunler where profilno=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtprofilno.EditValue);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txturunid.EditValue = dr[0].ToString();
                txtad.EditValue = dr[1].ToString();
            }
            bgl.baglanti().Close();
        }

        void listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from TBLSTOK", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;

        }

        public FrmProductHistory()
        {
            InitializeComponent();
        }


        public int ayfi;
        private void FrmProductHistory_Load(object sender, EventArgs e)
        {

            listele();
           
        frmLogin fr = new frmLogin();
            
            lblid.Text = MyPorperty;
            
            lbltarih.Caption = DateTime.Now.ToString("dd/MM/yyyy");
            SqlCommand komut = new SqlCommand("select dil from TBLADMIN where id=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lblid.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblsqldil.Text = dr[0].ToString();
            }


        }

        private void btnkaydet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("insert into TBLSTOK (profilno,urunid,depocikis,tarih,gramaj,metraj,toplam,cikisyapanid) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtprofilno.EditValue);
                komut.Parameters.AddWithValue("@p2", txturunid.EditValue);
                komut.Parameters.AddWithValue("@p3", txtadet.EditValue);
                komut.Parameters.AddWithValue("@p4", lbltarih.Caption);
                komut.Parameters.AddWithValue("@p5", decimal.Parse(txtgramaj.EditValue.ToString()));
                komut.Parameters.AddWithValue("@p6", decimal.Parse(txtmetraj.EditValue.ToString()));
                komut.Parameters.AddWithValue("@p7", decimal.Parse(txttoplam.EditValue.ToString()));
                komut.Parameters.AddWithValue("@p8", lblid.Text);
                komut.ExecuteNonQuery();
                SqlCommand komut3 = new SqlCommand("insert into TBLHARAKETLER (ad,tarih,oncekiadet,sonrakiadet,fark,cikisyapanid) values (@s1,@s2,@s3,@s4,@s5,@s6)", bgl.baglanti());
                komut3.Parameters.AddWithValue("@s1", short.Parse(txturunid.EditValue.ToString()));
                komut3.Parameters.AddWithValue("@s2", lbltarih.Caption);
                komut3.Parameters.AddWithValue("@s3", decimal.Parse(lblOncekiAdet.Caption));
                komut3.Parameters.AddWithValue("@s4", decimal.Parse(lblSonrakiAdet.Caption));
                komut3.Parameters.AddWithValue("@s5", txtadet.EditValue);
                komut3.Parameters.AddWithValue("@s6", lblid.Text);


            komut3.ExecuteNonQuery();
                bgl.baglanti().Close();
                SqlCommand komut4 = new SqlCommand("update TBLURUNLER set depogiris=depogiris-@t1 where id=@t2", bgl.baglanti());
                komut4.Parameters.AddWithValue("@t1", txtadet.EditValue);
                komut4.Parameters.AddWithValue("@t2", txturunid.EditValue);
                komut4.ExecuteNonQuery();
                bgl.baglanti().Close();
                XtraMessageBox.Show("Stock entry has been successfully added", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

                listele();
        }
            catch (Exception)
            {

                XtraMessageBox.Show("You are not logged in or a problem occurred.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


}


        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            listele();
        }

        private void txtprofilno_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                profilno();
            }
            catch (Exception)
            {


            }

        }

        private void txtadet_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                double gramaj, toplam, metraj;
                int miktar;
                metraj = Convert.ToDouble(txtmetraj.EditValue);
                miktar = Convert.ToInt32(txtadet.EditValue);
                gramaj = Convert.ToDouble(txtgramaj.EditValue);
                toplam = miktar * gramaj * metraj;

                txttoplam.EditValue = toplam.ToString();



            }
            catch (Exception)
            {


            }

            SqlCommand komut2 = new SqlCommand("select depogiris=depogiris-@p1 from tblurunler where id=@p2", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", txtadet.EditValue);
            komut2.Parameters.AddWithValue("@p2", txturunid.EditValue);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                lblSonrakiAdet.Caption = dr2[0].ToString();
            }
            bgl.baglanti().Close();

        }

        private void txtgramaj_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                double gramaj, toplam, metraj;
                int miktar;
                metraj = Convert.ToDouble(txtmetraj.EditValue);
                miktar = Convert.ToInt32(txtadet.EditValue);
                gramaj = Convert.ToDouble(txtgramaj.EditValue);
                toplam = miktar * gramaj * metraj;

                txttoplam.EditValue = toplam.ToString();
            }
            catch (Exception)
            {


            }
        }

        private void txtmetraj_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                double gramaj, toplam, metraj;
                int miktar;
                metraj = Convert.ToDouble(txtmetraj.EditValue);
                miktar = Convert.ToInt32(txtadet.EditValue);
                gramaj = Convert.ToDouble(txtgramaj.EditValue);
                toplam = miktar * gramaj * metraj;

                txttoplam.EditValue = toplam.ToString();
            }
            catch (Exception)
            {


            }
        }

       
        private void txturunid_EditValueChanged(object sender, EventArgs e)
        {
          

            //SqlCommand komut2 = new SqlCommand("select depogiris from tblurunler where id=@p1", bgl.baglanti());
            //komut2.Parameters.AddWithValue("@p1", txturunid.EditValue);
            //SqlDataReader dr2 = komut2.ExecuteReader();
            //while (dr2.Read())
            //{
            //    lblOncekiAdet.Caption = dr2[0].ToString();
            //}
            //bgl.baglanti().Close();

        }
        public string iddeger;
        private void txtid_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                iddeger = txtid.EditValue.ToString();
            }
            catch (Exception)
            {


            }


        }

        private void btnsil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult secenek = XtraMessageBox.Show(iddeger + " ID veritabanından silmek istediğinize emin misiniz?", "Bildirim", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secenek == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("delete from TBLSTOK where id=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtid.EditValue);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                XtraMessageBox.Show("Ürün haraketi silindi.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
            }
            else if (secenek == DialogResult.No)
            {

            }
        }

        private void txturunid_EditValueChanged_1(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select depogiris from tblurunler where id=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txturunid.EditValue);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblOncekiAdet.Caption = dr[0].ToString();
            }
            bgl.baglanti().Close();
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtid.EditValue = dr["id"].ToString();
                txtprofilno.EditValue = dr["profilno"].ToString();
      
            }
        
        }

        private void lblsqldil_Click(object sender, EventArgs e)
        {
          
        }

        public int sayac2;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac2++;
            if (sayac2 == 5)
            {

                SqlCommand komut = new SqlCommand("select dil from TBLADMIN where id=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", lblid.Text);
                SqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    lblsqldil.Text = dr[0].ToString();
                }

            }
            if (sayac2 == 6)
            {
                sayac2 = 0;
            }
        }

        private void lblsqldil_TextChanged(object sender, EventArgs e)
        {
            if (lblsqldil.Text == "True")
            {
                lblaydi.Caption = "ID:";
                lblprofilno.Caption = "Profıl NO:";
                lbladet.Caption = "Pièce:";
                lblgramaj.Caption = "Poids:";
                lblurunid.Caption = "ID produit:";
                lblad.Caption = "Nom:";
                lbltoplam.Caption = "Total:";
                lblmetraj.Caption = "Quantité:";
                btnkaydet.Caption = "Sauvegarder";
                btnsil.Caption = "Effacer";
                btntemizle.Caption = "Propre";
                btnlistele.Caption = "Lister";

            }       
            if (lblsqldil.Text == "False")
            {
                lblaydi.Caption = "ID:";
                lblprofilno.Caption = "Profil NO:";
                lbladet.Caption = "ADET:";
                lblgramaj.Caption = "GRAMAJ:";
                lblurunid.Caption = "Ürün ID:";
                lblad.Caption = "AD:";
                lbltoplam.Caption = "TOPLAM:";
                lblmetraj.Caption = "METRAJ:";
                btnkaydet.Caption = "Kaydet";
                btnsil.Caption = "Sil";
                btntemizle.Caption = "Temizle";
                btnlistele.Caption = "Listele";

            }
        }

        private void btntemizle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                txtid.EditValue = "";
                txtprofilno.EditValue = "";
                txtadet.EditValue = "";
                txtgramaj.EditValue = "";
                txturunid.EditValue = "";
                txtad.EditValue = "";
                txttoplam.EditValue = "";
                txtmetraj.EditValue = "";
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Zaten veri mesaj kutuları temiz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }

        }
    }
}
