
using Clinica.EN;
using Clinica.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;

namespace Clinica.BL
{
   public class CitaBL
    {

        public CitaDAL CitaDal = new CitaDAL();

        public DataTable MostrarCitas()
        {
            DataTable tabla = new DataTable();
            tabla = CitaDal.MostrarDatos();
            return tabla;
        }

        //public void AgregarCita(Cita pCita)
        //{
        //    try
        //    {
        //        CitaDAL.AgregarCita(pCita);
        //    }
        //    catch
        //    {
        //        throw;
        //    }
           

        //}

    }
}
