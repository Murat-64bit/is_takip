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
using DevExpress.XtraEditors;
namespace ForzaYazilim
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
      
        private void btnlogin_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("select id from TBLADMIN where kmail=@t1 and ksifre=@t2", bgl.baglanti());
            komut2.Parameters.AddWithValue("@t1", txtmail.Text);
            komut2.Parameters.AddWithValue("@t2", txtpassword.Text);
            SqlDataReader dr2 = komut2.ExecuteReader();
            if (dr2.Read())
            {
                lblid.Text = dr2[0].ToString();
               

            }
            SqlCommand komut = new SqlCommand("select * from TBLADMIN where kmail=@p1 and ksifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtmail.Text);
            komut.Parameters.AddWithValue("@p2", txtpassword.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmAnaSayfa fr = new FrmAnaSayfa();
                FrmProductHistory.MyPorperty = lblid.Text;
                FrmProductAdd.productad = lblid.Text;
                FrmIstatistik.istatestikad = lblid.Text;
                FrmAccounts.acountsad = lblid.Text;
                FrmUpdate.updatead = lblid.Text;

                fr.aydi = Convert.ToInt32(lblid.Text);
                this.Hide();
                fr.Show();
            }
            else
            {
                XtraMessageBox.Show("Hatalı Kullanıcı Adı veya Şifre", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            bgl.baglanti().Close();

     
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
           
        }

        private void txtpassword_EditValueChanged(object sender, EventArgs e)
        {
           
        }

    
    }
}
