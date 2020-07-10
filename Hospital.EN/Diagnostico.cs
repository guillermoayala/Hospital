using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital.EN
{
   public class Diagnostico
    {
        public int IdDiagnostico { get; set; }
        public Cita IdCita { get; set; }
        public string NotasMedico { get; set; }


    }
}
