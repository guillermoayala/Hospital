

using Hospital.EN;
using Hospital.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.BL
{
   public class CitaBL
    {
        public void AgregarCita(Cita pCita)
        {
            try
            {
                CitaDAL.AgregarCita(pCita);
            }
            catch
            {
                throw;
            }
           

        }

    }
}
