using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.DAL.Common
{
   public class DbCommon
    {
      
        private SqlConnection Conexion = new SqlConnection("Data Source=.;Initial Catalog=Hospital;Integrated Security=True");
        public SqlConnection AbrirSQL()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }
    }
}
