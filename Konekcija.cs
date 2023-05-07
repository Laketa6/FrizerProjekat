using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrizerProjekat
{
    class Konekcija
    {
        static public SqlConnection Connect()
        {
            string CS = ConfigurationManager.ConnectionStrings["FrizerKonekcija"].ConnectionString;
            SqlConnection veza = new SqlConnection(CS);
            return veza;
        }
    }
}
