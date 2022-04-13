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
    public partial class FrmProductAdd : DevExpress.XtraEditors.XtraUserControl
    {
        private static FrmProductAdd _instance;

        public static FrmProductAdd Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new FrmProductAdd();
                return _instance;
            }
        }

        public static string productad { get; internal set; }

        sqlbaglantisi bgl = new sqlbaglantisi();

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from TBLURUNLER", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        public FrmProductAdd()
        {

            InitializeComponent();
        }




        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void barStaticItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtProfilNO.EditValue = "";
            txtID.EditValue = "";
            txtAd.EditValue = "";
            txtAdet.EditValue = "";
        }

        private void BtnKaydet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (BtnKaydet.Caption == "Kaydet")
            {
                try
                {
                    SqlCommand komut = new SqlCommand("insert into TBLURUNLER (profilno,ad,depogiris) values (@p1,@p2,@p3)", bgl.baglanti());
                    komut.Parameters.AddWithValue("@p1", txtProfilNO.EditValue);
                    komut.Parameters.AddWithValue("@p2", txtAd.EditValue);
                    komut.Parameters.AddWithValue("@p3", txtAdet.EditValue);
                    komut.ExecuteNonQuery();
                    bgl.baglanti();
                    listele();
                    XtraMessageBox.Show("Ürün başarı ile eklendi.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {

                    XtraMessageBox.Show("Veritabanına kayıt alınması için değer girmediniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            if (BtnKaydet.Caption == "Sauvegarder")
            {
                try
                {
                    SqlCommand komut = new SqlCommand("insert into TBLURUNLER (profilno,ad,depogiris) values (@p1,@p2,@p3)", bgl.baglanti());
                    komut.Parameters.AddWithValue("@p1", txtProfilNO.EditValue);
                    komut.Parameters.AddWithValue("@p2", txtAd.EditValue);
                    komut.Parameters.AddWithValue("@p3", txtAdet.EditValue);
                    komut.ExecuteNonQuery();
                    bgl.baglanti();
                    listele();
                    XtraMessageBox.Show("Ürün başarı ile eklendi.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {

                    XtraMessageBox.Show("Veritabanına kayıt alınması için değer girmediniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            if (BtnKaydet.Caption == "Ekle")
            {
                try
                {
                    SqlCommand komut = new SqlCommand("update TBLURUNLER set depogiris=depogiris+@p1 where profilno=@p2", bgl.baglanti());
                    komut.Parameters.AddWithValue("@p1", txtAdet.EditValue);
                    komut.Parameters.AddWithValue("@p2", txtProfilNO.EditValue);
                    komut.ExecuteNonQuery();
                    bgl.baglanti();
                    listele();
                    XtraMessageBox.Show("Adet eklemesi ile eklendi.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {

                    XtraMessageBox.Show("Veritabanına kayıt alınması için değer girmediniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            if (BtnKaydet.Caption == "Ajouter")
            {
                try
                {
                    SqlCommand komut = new SqlCommand("update TBLURUNLER set depogiris=depogiris+@p1 where profilno=@p2", bgl.baglanti());
                    komut.Parameters.AddWithValue("@p1", txtAdet.EditValue);
                    komut.Parameters.AddWithValue("@p2", txtProfilNO.EditValue);
                    komut.ExecuteNonQuery();
                    bgl.baglanti();
                    listele();
                    XtraMessageBox.Show("Adet eklemesi ile eklendi.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {

                    XtraMessageBox.Show("Veritabanına kayıt alınması için değer girmediniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }


        }
        public string iddeger;

        private void FrmProductAdd_Load(object sender, EventArgs e)
        {
            listele();
            lblid.Text = productad;

            SqlCommand komut = new SqlCommand("select dil from TBLADMIN where id=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lblid.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblsqldil.Text = dr[0].ToString();
            }


        }
        private void btnSil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (txtID.EditValue != null)
                {
                    DialogResult secenek = XtraMessageBox.Show(iddeger + " ID veritabanından silmek istediğinize emin misiniz?", "Bildirim", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (secenek == DialogResult.Yes)
                    {
                        SqlCommand komut = new SqlCommand("delete from TBLURUNLER where id=@p1", bgl.baglanti());
                        komut.Parameters.AddWithValue("@p1", txtID.EditValue);
                        komut.ExecuteNonQuery();
                        bgl.baglanti();
                        listele();
                        XtraMessageBox.Show("Ürün başarı ile silindi.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (secenek == DialogResult.No)
                    {

                    }
                  
                }
                else if (txtID.EditValue == null)
                {
                    XtraMessageBox.Show("Ürün haraketi silinemedi lütfen ID giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Ürün sistem de kayıtlı veya değer girmediniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

              
            }


        }

        private void txtProfilNO_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtID_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                iddeger = txtID.EditValue.ToString();
            }
            catch (Exception)
            {


            }


        }

        public int sayac;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            if (sayac == 15)
            {
                listele();
            }
            if (sayac == 16)
            {
                sayac = 0;
            }
        }

        private void checkAdetEkleme_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (lblsqldil.Text == "False")
            {
                if (checkAdetEkleme.Checked)
                {
                    BtnKaydet.Caption = "Ekle";
                    txtAd.Enabled = false;
                    txtID.Enabled = false;
                }
                else
                {
                    BtnKaydet.Caption = "Kaydet";
                    txtAd.Enabled = true;
                    txtID.Enabled = true;
                }
            }
            if (lblsqldil.Text == "True")
            {
                if (checkAdetEkleme.Checked && lblsqldil.Text == "True")
                {
                    BtnKaydet.Caption = "Ajouter";
                    txtAd.Enabled = false;
                    txtID.Enabled = false;
                }
                else
                {
                    BtnKaydet.Caption = "Sauvegarder";
                    txtAd.Enabled = true;
                    txtID.Enabled = true;
                }
            }


        }

        private void lbllang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void lbldil_Click(object sender, EventArgs e)
        {

        }

        private void lbldil_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblsqldil_TextChanged(object sender, EventArgs e)
        {
            if (lblsqldil.Text == "True")
            {
                lblurunid.Caption = "Num d'article:";
                lblprofilno.Caption = "Profil NO:";
                lblad.Caption = "Nom:";
                lbladet.Caption = "Pièce:";
                checkAdetEkleme.Caption = "Ajout de pièces:";
                BtnKaydet.Caption = "Sauvegarder";
                btnSil.Caption = "Effacer";
                btnTemizle.Caption = "Propre";

            }
            if (lblsqldil.Text == "False")
            {
                lblurunid.Caption = "Ürün ID:";
                lblprofilno.Caption = "Profil NO:";
                lblad.Caption = "AD:";
                lbladet.Caption = "ADET:";
                checkAdetEkleme.Caption = "Adet Ekleme:";
                BtnKaydet.Caption = "Kaydet";
                btnSil.Caption = "Sil";
                btnTemizle.Caption = "Temizle";

            }
        }
        public int sayac2;
        private void timer2_Tick(object sender, EventArgs e)
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
    }
}
