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
using DevExpress.Utils;
using System.Data.SqlClient;

namespace ForzaYazilim
{
    public partial class FrmAccounts : DevExpress.XtraEditors.XtraUserControl
    {

        private static FrmAccounts _instance;

        public static FrmAccounts Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new FrmAccounts();
                return _instance;
            }
        }

        public static string acountsad { get; internal set; }

        public FrmAccounts()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select id,kad,ksoyad,kmail,kdogum from TBLADMIN", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        private void FrmAccounts_Load(object sender, EventArgs e)
        {



            listele();

            bgl.baglanti().Close();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                lblid.Text = dr["id"].ToString();
                lblkad.Text = dr["kad"].ToString();
                lblksoyad.Text = dr["ksoyad"].ToString();
                lblmail.Text = dr["kmail"].ToString();
                lbldogumtarihi.Text = dr["kdogum"].ToString();


            }

            lblsqlid.Text = acountsad;


            SqlCommand komut3 = new SqlCommand("select dil from TBLADMIN where id=@p1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", lblsqlid.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                lblsqldil.Text = dr3[0].ToString();
            }

        }

        private void ttcKad_GetActiveObjectInfo(object sender, ToolTipControllerGetActiveObjectInfoEventArgs e)
        {

        }

        private void sidePanel1_Click(object sender, EventArgs e)
        {

        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void lblDuzenle_Click(object sender, EventArgs e)
        {
            if (chkKayit.Checked != true)
            {
                btnKayit.Visible = false;
                btnDuzenle.Visible = false;
                btnSil.Visible = false;
                btnTamam.Visible = true;
                btnVazgec.Visible = true;
                chkDuzen.Checked = true;




                if (chkDuzen.Checked == true)
                {
                    DataRow dr2 = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                    if (dr2 != null)
                    {
                        lblid.Text = dr2["id"].ToString();
                        txtkad.Text = lblkad.Text;
                        txtksoyad.Text = lblksoyad.Text;
                        txteposta.Text = lblmail.Text;
                        txtdogumtarihi.Text = lbldogumtarihi.Text;
                    }
                }

                if (chkDuzen.Checked == true)
                {
                    txtkad.Visible = true;
                    txtksoyad.Visible = true;
                    txteposta.Visible = true;
                    txtdogumtarihi.Visible = true;
                    txtksifre.Visible = true;
                }

            }
            else
            {
                XtraMessageBox.Show("Kayıt sisteminiz zaten açık lütfen kapatma tuşuna tıklayınız.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            // 00;43

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void gridView1_Click(object sender, EventArgs e)
        {

            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                lblid.Text = dr["id"].ToString();
                lblkad.Text = dr["kad"].ToString();
                lblksoyad.Text = dr["ksoyad"].ToString();
                lblmail.Text = dr["kmail"].ToString();
                lbldogumtarihi.Text = dr["kdogum"].ToString();

            }

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            chkDuzen.Checked = false;
            chkKayit.Checked = false;

            btnKayit.Visible = true;
            btnDuzenle.Visible = true;
            btnSil.Visible = true;
            btnTamam.Visible = false;
            btnVazgec.Visible = false;

            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                lblid.Text = dr["id"].ToString();
                lblkad.Text = dr["kad"].ToString();
                lblksoyad.Text = dr["ksoyad"].ToString();
                lblmail.Text = dr["kmail"].ToString();
                lbldogumtarihi.Text = dr["kdogum"].ToString();

            }

            txtkad.Text = "";
            txtksoyad.Text = "";
            txteposta.Text = "";
            txtdogumtarihi.Text = "";
            txtksifre.Text = "";


            if (chkDuzen.Checked == false)
            {
                txtkad.Visible = false;
                txtksoyad.Visible = false;
                txteposta.Visible = false;
                txtdogumtarihi.Visible = false;
                txtksifre.Visible = false;
            }

        }

        private void hyperlinkLabelControl1_Click(object sender, EventArgs e)
        {



            if (chkDuzen.Checked != true)
            {
                btnKayit.Visible = false;
                btnDuzenle.Visible = false;
                btnSil.Visible = false;
                btnTamam.Visible = true;
                btnVazgec.Visible = true;
                chkKayit.Checked = true;


                if (chkKayit.Checked == true)
                {
                    txtkad.Visible = true;
                    txtksoyad.Visible = true;
                    txteposta.Visible = true;
                    txtdogumtarihi.Visible = true;
                    txtksifre.Visible = true;
                }
            }
            else
            {
                XtraMessageBox.Show("Düzenleme sisteminiz zaten açık lütfen kapatma tuşuna tıklayınız.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public string iddeger;
        private void hyperlinkLabelControl2_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult secenek = XtraMessageBox.Show(iddeger + " ID veritabanından silmek istediğinize emin misiniz?", "Bildirim", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (secenek == DialogResult.Yes)
                {
                    SqlCommand komut = new SqlCommand("delete from TBLADMIN where id=@p1", bgl.baglanti());
                    komut.Parameters.AddWithValue("@p1", lblid.Text);
                    komut.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    XtraMessageBox.Show("Kullanıcı başarı ile veritabanından silindi.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listele();
                }
                else if (secenek == DialogResult.No)
                {

                }
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Ürün sistem de kayıtlı bulundu bu yüzden silinemiyor.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        private void lblid_TextChanged(object sender, EventArgs e)
        {
            iddeger = lblid.Text;
            SqlCommand sifre = new SqlCommand("select ksifre from TBLADMIN where id=@p1", bgl.baglanti());
            sifre.Parameters.AddWithValue("@p1", lblid.Text);
            SqlDataReader dr2 = sifre.ExecuteReader();
            if (dr2.Read())
            {
                lblSifreAl.Text = dr2[0].ToString();
            }
        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            if (chkKayit.Checked == true)
            {
                SqlCommand komut = new SqlCommand("insert into TBLADMIN (kad,ksoyad,kmail,kdogum,ksifre,dil)" +
                    "values (@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtkad.Text);
                komut.Parameters.AddWithValue("@p2", txtksoyad.Text);
                komut.Parameters.AddWithValue("@p3", txteposta.Text);
                komut.Parameters.AddWithValue("@p4", txtdogumtarihi.Text);
                komut.Parameters.AddWithValue("@p5", txtksifre.Text);
                komut.Parameters.AddWithValue("@p6", dilswitch.IsOn);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                XtraMessageBox.Show("Kullanıcı başarı ile veritabanına eklendi.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
                btnKayit.Visible = true;
                btnDuzenle.Visible = true;
                btnSil.Visible = true;
                btnTamam.Visible = false;
                btnVazgec.Visible = false;
                chkKayit.Checked = false;
                txtkad.Visible = false;
                txtksoyad.Visible = false;
                txteposta.Visible = false;
                txtdogumtarihi.Visible = false;
                txtksifre.Visible = false;
                listele();
            }

            if (chkDuzen.Checked == true)
            {
                if (txtksifre.Text == lblSifreAl.Text)
                {
                    SqlCommand komut = new SqlCommand("update TBLADMIN set kad=@p1,ksoyad=@p2,kmail=@p3,kdogum=@p4,ksifre=@p5,dil=@p6 where id=@p7", bgl.baglanti());
                    komut.Parameters.AddWithValue("@p1", txtkad.Text);
                    komut.Parameters.AddWithValue("@p2", txtksoyad.Text);
                    komut.Parameters.AddWithValue("@p3", txteposta.Text);
                    komut.Parameters.AddWithValue("@p4", txtdogumtarihi.Text);
                    komut.Parameters.AddWithValue("@p5", txtksifre.Text);
                    komut.Parameters.AddWithValue("@p6", dilswitch.IsOn);
                    komut.Parameters.AddWithValue("@p7", lblid.Text);
                    komut.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    XtraMessageBox.Show("Kullanıcı başarı ile veritabanında güncellendi.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listele();
                    btnKayit.Visible = true;
                    btnDuzenle.Visible = true;
                    btnSil.Visible = true;
                    btnTamam.Visible = false;
                    btnVazgec.Visible = false;
                    chkDuzen.Checked = false;

                    txtkad.Visible = false;
                    txtksoyad.Visible = false;
                    txteposta.Visible = false;
                    txtdogumtarihi.Visible = false;
                    txtksifre.Visible = false;
                    listele();

                }
                else
                {
                    XtraMessageBox.Show("Şifreniz önce ki şifreniz ile uyuşmuyor.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }



        }

        private void lblSifreAl_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            iddeger = lblid.Text;
            SqlCommand sifre = new SqlCommand("select ksifre from TBLADMIN where id=@p1", bgl.baglanti());
            sifre.Parameters.AddWithValue("@p1", lblid.Text);
            SqlDataReader dr2 = sifre.ExecuteReader();
            if (dr2.Read())
            {
                lblSifreAl.Text = dr2[0].ToString();
            }
        }

        private void lblsqldil_TextChanged(object sender, EventArgs e)
        {
            if (lblsqldil.Text == "True")
            {
                lblkullaniciad.Text = "Nom d'utilisateur";
                lblsoyad.Text = "Nom de famille";
                lblepostaadresi.Text = "Adresse e-mail";
                lbldogum.Text = "Date de naissance";
                lblkullanicisifre.Text = "Mot de passe de l'utilisateur";
                lblkullanicianadil.Text = "Langue maternelle";
                btnKayit.Text = "Sauvegarder";
                btnDuzenle.Text = "Éditer";
                btnSil.Text = "Effacer";



            }
            if (lblsqldil.Text == "False")
            {
                lblkullaniciad.Text = "Kullanıcı Adı";
                lblsoyad.Text = "Kullanıcı Soyadı";
                lblepostaadresi.Text = "Kullanıcı E-Posta Adresi";
                lbldogum.Text = "Kullanıcı Doğum Tarihi";
                lblkullanicisifre.Text = "Kullanıcı Şifresi";
                lblkullanicianadil.Text = "Kullanıcı Ana Dil";
                btnKayit.Text = "Kaydet";
                btnDuzenle.Text = "Düzenle";
                btnSil.Text = "Sil";

            }
        }
        public int sayac2;
        private void timer2_Tick(object sender, EventArgs e)
        {
            sayac2++;
            if (sayac2 == 10)
            {

                SqlCommand komut = new SqlCommand("select dil from TBLADMIN where id=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", lblsqlid.Text);
                SqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    lblsqldil.Text = dr[0].ToString();
                }

            }
            if (sayac2 == 11)
            {
                sayac2 = 0;
            }
        }

    }
}