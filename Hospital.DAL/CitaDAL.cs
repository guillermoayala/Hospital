using Hospital.DAL.Common;
using Hospital.EN;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.DAL
{
   public class CitaDAL
    {

        SqlDataReader Read;
        DataTable tabla = new DataTable();
        public DataTable MostrarDatos()
        {
            SqlCommand Com = new SqlCommand();
        
            Com.Connection = DbCommon.ObtenerConexionDbPrincipal();
            Com.CommandText = "Select * from Citas";
            Read = Com.ExecuteReader();
            tabla.Load(Read);
            return tabla;




        }
        public static Retorno AgregarCita(Cita pCita)
        {
            try
            {
                using (SqlConnection pConn = DbCommon.ObtenerConexionDbPrincipal())
                {
                    SqlCommand cmdAgregarCita = new SqlCommand("[AgregarCita]", pConn as SqlConnection);
                    cmdAgregarCita.CommandType = CommandType.StoredProcedure;
                    cmdAgregarCita.Parameters.AddWithValue("@IdPaciente", pCita.Paciente.IdPaciente);
                    cmdAgregarCita.Parameters.AddWithValue("@IdDoctor", pCita.Doctor.IdDoctor);
                    cmdAgregarCita.Parameters.AddWithValue("@Nota", pCita.Nota);
                    cmdAgregarCita.Parameters.AddWithValue("@IdSucursal", pCita.Sucursal.IdSucursal);
                    cmdAgregarCita.Parameters.AddWithValue("@FechaHora", pCita.FechaHora);
                    cmdAgregarCita.Parameters.AddWithValue("@Estado", pCita.FechaHora);

                    pConn.Open();

                    int res = cmdAgregarCita.ExecuteNonQuery();

                    if (res == 1)
                    {
                        return new Retorno{ Resultado = Resultado.Exito };
                    
                    }
                    else
                    {
                        throw new Exception("Inconsistecia en rows registradas en DB");
                    }
                }

            }
            catch (Exception ex)
            {
                return new Retorno { Resultado = Resultado.Fallo }; ;
            }

        }

    }
}
