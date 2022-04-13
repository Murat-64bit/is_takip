using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using DevExpress.XtraSplashScreen;
using ForzaYazilim.Properties;

namespace ForzaYazilim
{
    public partial class FrmAnaSayfa : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public FrmAnaSayfa()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        public int aydi;
        private void BtnUrunMenu_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement6_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement7_Click(object sender, EventArgs e)
        {

        }

        private void BtnUrunEkle_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(FrmProductAdd.Instance))
            {

                container.Controls.Add(FrmProductAdd.Instance);
                FrmProductAdd.Instance.Dock = DockStyle.Fill;
                FrmProductAdd.Instance.BringToFront();

            }
            FrmProductAdd.Instance.BringToFront();
        }
        
        private void FrmAnaSayfa_Load(object sender, EventArgs e)
        {


            FluentSplashScreenOptions op = new FluentSplashScreenOptions();
            op.Title = "Always the best";
            op.Subtitle = "Forza Metal Panel";
            op.RightFooter = "Starting...";
            op.LeftFooter = "muratturk.org" + Environment.NewLine + "All Rights reserved.";
            op.LoadingIndicatorType = FluentLoadingIndicatorType.Dots;
            op.OpacityColor = Color.DodgerBlue;
            op.Opacity = 130;

            //op.LogoImageOptions.SvgImage = Resources.logo;

            DevExpress.XtraSplashScreen.SplashScreenManager.ShowFluentSplashScreen(
                op,
                parentForm: this,
                useFadeIn: true,
                useFadeOut: true
            );
            System.Threading.Thread.Sleep(1500);
            lblid.Text = aydi.ToString();
            

            if (!container.Controls.Contains(FrmIstatistik.Instance))
            {
                container.Controls.Add(FrmIstatistik.Instance);
                FrmIstatistik.Instance.Dock = DockStyle.Fill;
                FrmIstatistik.Instance.BringToFront();

            }
            FrmIstatistik.Instance.BringToFront();


            SqlCommand komut = new SqlCommand("select dil from TBLADMIN where id=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lblid.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblsqldil.Text = dr[0].ToString();
            }
            if (lblsqldil.Text == "True")
            {
                dilswitch.IsOn = true;
            }
            else
            {
                dilswitch.IsOn = false;

            }
            DevExpress.XtraSplashScreen.SplashScreenManager.CloseForm();

        }

        private void BtnUrunCikisi_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(FrmProductHistory.Instance))
            {
                container.Controls.Add(FrmProductHistory.Instance);
                FrmProductHistory.Instance.Dock = DockStyle.Fill;
                FrmProductHistory.Instance.BringToFront();

            }
            FrmProductHistory.Instance.BringToFront();
        }

        
 

        private void btnHesaplar_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(FrmAccounts.Instance))
            {
                container.Controls.Add(FrmAccounts.Instance);
                FrmAccounts.Instance.Dock = DockStyle.Fill;
                FrmAccounts.Instance.BringToFront();

            }
            FrmAccounts.Instance.BringToFront();
            //XtraMessageBox.Show("Şuan mevcut değil","Bildirim",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show("Yapım aşamasında", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //if (!container.Controls.Contains(FrmUpdate.Instance))
            //{
            //    container.Controls.Add(FrmUpdate.Instance);
            //    FrmUpdate.Instance.Dock = DockStyle.Fill;
            //    FrmUpdate.Instance.BringToFront();

            //}
            //FrmUpdate.Instance.BringToFront();
        }
        private void dilswitch_Toggled(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBLADMIN set dil=@p1 where id=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", dilswitch.IsOn);
            komut.Parameters.AddWithValue("@p2", lblid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();


            if (dilswitch.IsOn == true)
            {

                btnAnaSayfa.Text = "Page d'accueil";
                btnistatistik.Text = "Graphique";
                btnNotlar.Text = "Remarques";
                BtnUrunMenu.Text = "Menu produit";
                BtnUrunEkle.Text = "Ajouter un produit";
                BtnUrunCikisi.Text = "Mouvement de produit";
                btnRaporlar.Text = "Reports";
                btnSecenekler.Text = "Options";
                btnHesaplar.Text = "Comptes";
                btnGuncelle.Text = "Mettre à jour";
                btnDil.Text = "Langue";
               

            }
            if (dilswitch.IsOn == false)
            {
              
                btnAnaSayfa.Text = "Ana Sayfa";
                btnistatistik.Text = "Grafikler";
                btnNotlar.Text = "Notlar";
                BtnUrunMenu.Text = "Ürün Menüsü";
                BtnUrunEkle.Text = "Ürün Ekle";
                BtnUrunCikisi.Text = "Ürün Çıkışı";
                btnRaporlar.Text = "Raporlar";
                btnSecenekler.Text = "Seçenekler";
                btnHesaplar.Text = "Hesaplar";
                btnGuncelle.Text = "Güncelle";
                btnDil.Text = "Dil";
            }
        }

        private void lblid_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement1_Click(object sender, EventArgs e)
        {

        }

        private void btnGrafikler_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(FrmIstatistik.Instance))
            {
                container.Controls.Add(FrmIstatistik.Instance);
                FrmIstatistik.Instance.Dock = DockStyle.Fill;
                FrmIstatistik.Instance.BringToFront();

            }
            FrmIstatistik.Instance.BringToFront();
        }

        private void btnNotlar_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(FrmNotlar.Instance))
            {
                container.Controls.Add(FrmNotlar.Instance);
                FrmNotlar.Instance.Dock = DockStyle.Fill;
                FrmNotlar.Instance.BringToFront();

            }
            FrmNotlar.Instance.BringToFront();
        }

        private void btnNotEkle_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(FrmNotDetay.Instance))
            {
                container.Controls.Add(FrmNotDetay.Instance);
                FrmNotDetay.Instance.Dock = DockStyle.Fill;
                FrmNotDetay.Instance.BringToFront();

            }
            FrmNotDetay.Instance.BringToFront();
        }

        private void BtnNot_Click(object sender, EventArgs e)
        {
           
        }

        private void fluentDesignFormControl1_Click(object sender, EventArgs e)
        {

        }

        private void FrmAnaSayfa_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        public string MyProprty { get; set; }
        private void accordionControl1_Click(object sender, EventArgs e)
        {
            
        }

        private void container_Click(object sender, EventArgs e)
        {

        }

        private void btnRaporlar_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(FrmRaporlar.Instance))
            {
                container.Controls.Add(FrmRaporlar.Instance);
                FrmRaporlar.Instance.Dock = DockStyle.Fill;
                FrmRaporlar.Instance.BringToFront();

            }
            FrmRaporlar.Instance.BringToFront();
        }
    }
}
