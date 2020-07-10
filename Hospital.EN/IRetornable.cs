using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital.EN
{
   public interface IRetornable
    {
        Resultado Resultado { get; set; }
        string Informacion { get; set; }
    }
}
