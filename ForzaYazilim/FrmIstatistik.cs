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

    public partial class FrmIstatistik : DevExpress.XtraEditors.XtraUserControl
    {
        private static FrmIstatistik _instance;

        public static FrmIstatistik Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new FrmIstatistik();
                return _instance;
            }
        }

        public static string istatestikad { get; internal set; }

        sqlbaglantisi bgl = new sqlbaglantisi();
        public FrmIstatistik()
        {
            InitializeComponent();
        }
        private void FrmIstatistik_Load(object sender, EventArgs e)
        {

            lblid.Text = istatestikad;


            SqlCommand komut1 = new SqlCommand("select ad,sum(depogiris) as 'Miktar' from tblurunler group by ad", bgl.baglanti());
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                chartControl1.Series["Piece"].Points.AddPoint(Convert.ToString(dr1[0]), int.Parse(dr1[1].ToString()));
            }
            SqlCommand komut2 = new SqlCommand("select tarih,sum(depocikis) as 'Miktar' from tblstok group by tarih", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                chartControl2.Series["Piece"].Points.AddPoint(Convert.ToString(dr2[0]), int.Parse(dr2[1].ToString()));
            }
            SqlDataAdapter da = new SqlDataAdapter("select ad,depogiris from tblurunler order by id desc", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl2.DataSource = dt;

            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("SELECT tblurunler.ad,depogiris AS 'Stok' FROM TBLURUNLER WHERE depogiris < 20 ", bgl.baglanti());

            da2.Fill(dt2);
            gridControl1.DataSource = dt2;

            SqlCommand komut3 = new SqlCommand("select cikisyapanid,sum(depocikis) from tblstok group by cikisyapanid", bgl.baglanti());
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                chartControl4.Series["Piece"].Points.AddPoint(Convert.ToString(dr3[0]), int.Parse(dr3[1].ToString()));
            }
        }
     

        private void btnYenile_Click(object sender, EventArgs e)
        {

            SqlCommand komut1 = new SqlCommand("select ad,sum(depogiris) as 'Miktar' from tblurunler group by ad", bgl.baglanti());
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                chartControl1.Series["Piece"].Points.AddPoint(Convert.ToString(dr1[0]), int.Parse(dr1[1].ToString()));
            }
            SqlCommand komut2 = new SqlCommand("select tarih,sum(depocikis) as 'Miktar' from tblstok group by tarih", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                chartControl2.Series["Piece"].Points.AddPoint(Convert.ToString(dr2[0]), int.Parse(dr2[1].ToString()));
            }
            SqlDataAdapter da = new SqlDataAdapter("select ad,depogiris from tblurunler order by id desc", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl2.DataSource = dt;

            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("SELECT tblurunler.ad,depogiris AS 'Stok' FROM TBLURUNLER WHERE depogiris < 20 ", bgl.baglanti());

            da2.Fill(dt2);
            gridControl1.DataSource = dt2;

            SqlCommand komut3 = new SqlCommand("select cikisyapanid,sum(depocikis) from tblstok group by cikisyapanid", bgl.baglanti());
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                chartControl4.Series["Piece"].Points.AddPoint(Convert.ToString(dr3[0]), int.Parse(dr3[1].ToString()));
            }
        }

        private void lblsqldil_TextChanged(object sender, EventArgs e)
        {
            if (lblsqldil.Text == "True")
            {
                toplamadeleter.Text = "Nombre total";
                AdetCikisTarih.Text = "Nombre de date de sortie";
                sonEklenenler.Text = "Dernier ajouté";
                SonIslemID.Text = "Dernier processeur";
                stoksayisi20dendusukler.Text = "Produits avec moins de 20 stocks";


            }
            if (lblsqldil.Text == "False")
            {
                toplamadeleter.Text = "Toplam Adetler";
                AdetCikisTarih.Text = "Adet Düşüş Tarihleri";
                sonEklenenler.Text = "Son Eklenenler";
                SonIslemID.Text = "Son İşlem Yapan ID";
                stoksayisi20dendusukler.Text = "Stok sayısı 20'den düşükler";

            }
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

    }
}
