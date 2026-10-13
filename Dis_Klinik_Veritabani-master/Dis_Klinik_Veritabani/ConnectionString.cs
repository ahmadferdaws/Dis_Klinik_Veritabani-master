using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Dis_Klinik_Veritabani
{
    internal class ConnectionString
    {
        public SqlConnection GetCon()
        {
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = @"Data Source=ALI-ZAHRAT;Initial Catalog=DentalDb;Integrated Security=True;TrustServerCertificate=True";
            return baglanti;
        }
    }
}
