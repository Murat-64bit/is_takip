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
    public partial class FrmHareketler : DevExpress.XtraEditors.XtraUserControl
    {
        private static FrmHareketler _instance;

        public static FrmHareketler Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new FrmHareketler();
                return _instance;
            }
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        public FrmHareketler()
        {
            InitializeComponent();
        }

        private void FrmHareketler_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from TBLHARAKETLER", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        public int sayac;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            if (sayac==15)
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from TBLHARAKETLER", bgl.baglanti());
                DataTable dt = new DataTable();
                da.Fill(dt);
                gridControl1.DataSource = dt;
            }
            if (sayac==17)
            {
                sayac = 0;
            }
        }
    }
}
