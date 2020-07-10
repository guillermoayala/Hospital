using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.DAL.Common
{
   public class DbCommon
    {
        public static SqlConnection ObtenerConexionDbPrincipal()
        {
            return new SqlConnection("Data Source=.;Initial Catalog=Hospital;Integrated Security=True");
        }
    }
}
