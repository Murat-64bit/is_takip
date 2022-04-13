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
    public partial class FrmNotlar : DevExpress.XtraEditors.XtraUserControl
    {
        private static FrmNotlar _instance;

        public static FrmNotlar Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new FrmNotlar();
                return _instance;
            }
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        public FrmNotlar()
        {
            InitializeComponent();
        }

        private void FrmNotlar_Load(object sender, EventArgs e)
        {

            //SqlCommand komut = new SqlCommand("select * ");
        }
        

        private void lbldogum_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

        }
    }
}
