using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;

namespace Stok_Takip_Otomasyonu
{
    class sqlbaglantisi
    {
        public SqlConnection baglanti = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Stok_Takip.mdf;Integrated Security=True");
      
    }    
}
