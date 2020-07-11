using Clinica.DAL.Common;
using Clinica.EN;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.DAL
{
   public class CitaDAL
    {
        DbCommon conexion = new DbCommon();
        SqlDataReader Read;
        DataTable tabla = new DataTable();
        public DataTable MostrarDatos()
        {
            SqlCommand Com = new SqlCommand();
        
            Com.Connection = conexion.AbrirSQL();
            Com.CommandText = "MostrarCitas";
            Com.CommandType = CommandType.StoredProcedure;
            Read = Com.ExecuteReader();
            tabla.Load(Read);
            return tabla;




        }
        //public static Retorno AgregarCita(Cita pCita)
        //{
        //    try
        //    {
        //        using (SqlConnection pConn = conexion.AbrirSQL())
        //        {
        //            SqlCommand cmdAgregarCita = new SqlCommand("[AgregarCita]", pConn as SqlConnection);
        //            cmdAgregarCita.CommandType = CommandType.StoredProcedure;
        //            cmdAgregarCita.Parameters.AddWithValue("@IdPaciente", pCita.Paciente.IdPaciente);
        //            cmdAgregarCita.Parameters.AddWithValue("@IdDoctor", pCita.Doctor.IdDoctor);
        //            cmdAgregarCita.Parameters.AddWithValue("@Nota", pCita.Nota);
        //            cmdAgregarCita.Parameters.AddWithValue("@IdSucursal", pCita.Sucursal.IdSucursal);
        //            cmdAgregarCita.Parameters.AddWithValue("@FechaHora", pCita.FechaHora);
        //            cmdAgregarCita.Parameters.AddWithValue("@Estado", pCita.FechaHora);

        //            pConn.Open();

        //            int res = cmdAgregarCita.ExecuteNonQuery();

        //            if (res == 1)
        //            {
        //                return new Retorno{ Resultado = Resultado.Exito };
                    
        //            }
        //            else
        //            {
        //                throw new Exception("Inconsistecia en rows registradas en DB");
        //            }
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        return new Retorno { Resultado = Resultado.Fallo }; ;
        //    }

        //}

    }
}
