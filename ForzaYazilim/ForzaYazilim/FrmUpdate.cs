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
using System.Net;

namespace ForzaYazilim
{
    public partial class FrmUpdate : DevExpress.XtraEditors.XtraUserControl
    {
        private static FrmUpdate _instance;

        public static FrmUpdate Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new FrmUpdate();
                return _instance;
            }
        }

        public static string updatead { get; internal set; }

        sqlbaglantisi bgl = new sqlbaglantisi();

        public FrmUpdate()
        {
            InitializeComponent();
        }
        void sontarih()
        {
            SqlCommand komut = new SqlCommand("SELECT top 1 sontarih,surum FROM tblupdatetarih ORDER BY id desc", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblguncellemetarih.Text = dr[0].ToString();
                mevcutsurum.Text = dr[1].ToString();
            }
        }

        void guncelleme()
        {
            SqlCommand komut = new SqlCommand("SELECT top 1 sonsurumtarih,sonsurum FROM tblupdate ORDER BY id desc", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblguncellemetarihi.Text = dr[0].ToString();
                lblsonsurum.Text = dr[1].ToString();
            }
        }
        void link()
        {
            SqlCommand komut = new SqlCommand("SELECT top 1 link1 FROM tblupdate ORDER BY id desc", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lbllink.Text = dr[0].ToString();
            }
        }
        public int aydi;
        private void FrmUpdate_Load(object sender, EventArgs e)
        {
            link();
            sontarih();
            guncelleme();
            lbltarih.Text= DateTime.Now.ToString("dd/MM/yyyy");
            lblid.Text = updatead;

            SqlCommand komut = new SqlCommand("select dil from TBLADMIN where id=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lblid.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblsqldil.Text = dr[0].ToString();
            }
        }
        public string uygulamad;
        private void btnindir_Click(object sender, EventArgs e)
        {
            uygulamad = txtuyuglamaad.Text;
            if (txtuyuglamaad.Text != "")
            {
                btnindir.Visible = false;

                prograsbar.Visible = true;
                WebClient vClient = new WebClient();
                vClient.DownloadFileAsync(new Uri(lbllink.Text), Application.StartupPath + @"\" + uygulamad + ".exe");
                vClient.DownloadFileCompleted += new AsyncCompletedEventHandler(VClient_DownloadFileCompleted);
                vClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(VClient_DownloadProgressChanged);
            }
            else
            {
                XtraMessageBox.Show("Uygulama adını boş bırakmayınız","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
           
        }

        private void VClient_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            prograsbar.EditValue = e.ProgressPercentage;
        }

        private void VClient_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tblupdatetarih (sontarih,surum) values (@p1,@p2)",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lbltarih.Text);
            komut.Parameters.AddWithValue("@p2", lblsonsurum.Text);
            komut.ExecuteNonQuery();
            btnindir.Visible = true;
            sontarih();
            prograsbar.Visible = false;
            XtraMessageBox.Show("Uygulama başarı ile indirildi", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lblsqldil_TextChanged(object sender, EventArgs e)
        {
            if (lblsqldil.Text == "True")
            {
                songuncellemetarihi.Text = "Date de la dernière mise à jour";
                textmevcut.Text = "Version actuelle";
                gelenguncellemetarihi.Text = "Date de mise à jour entrante";
                sonsurum.Text = "Dernière version";
                uygulamayiguncellemepaneli.Text = "Mise à jour du panneau d'application";
                btnindir.Text = "Télécharger";
                indireleceksunucu.Text = "Serveur à télécharger";
                uygulamaninadi.Text = "Nom de l'application (*)";

            }
            if (lblsqldil.Text == "False")
            {
                songuncellemetarihi.Text = "Son Güncelleme Tarihi";
                textmevcut.Text = "Mevcut Sürüm";
                gelenguncellemetarihi.Text = "Gelen Güncelleme Tarihi";
                sonsurum.Text = "Son Sürüm";
                uygulamayiguncellemepaneli.Text = "Uygulamayı Güncelleme Paneli";
                btnindir.Text = "İndir";
                indireleceksunucu.Text = "İndirilcek sunucu:";
                uygulamaninadi.Text = "Uygulama adı(*)";

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
                guncelleme();
                link();

            }
            if (sayac2 == 6)
            {
                sayac2 = 0;
            }
        }
    }
}