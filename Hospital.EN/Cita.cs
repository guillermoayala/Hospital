using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital.EN
{
   public class Cita
    {
        public int IdCita { get; set; }
        public Pacientes Paciente { get; set; }
        public Doctores Doctor { get; set; }
        public string Nota { get; set; }
        public Sucursal Sucursal { get; set; }
        public DateTime FechaHora { get; set; }
        public bool Estado { get; set; }
    }
}
