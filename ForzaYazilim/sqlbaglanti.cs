using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ForzaYazilim
{
    class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=91.151.93.29;Initial Catalog=DboForzaMetal;User Id=kisitli; password=:z#sKiYo}BB24rYyEYOY*DdDhV7P;");
            baglan.Open();
            return baglan;
        }
    }
}
