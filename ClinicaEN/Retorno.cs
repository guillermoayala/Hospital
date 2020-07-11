using System;
using System.Collections.Generic;
using System.Text;

namespace Clinica.EN
{
    public class Retorno : IRetornable
    {
        //public Retorno();
        public Resultado Resultado { get; set; }
        public string Informacion { get; set; }
    }


}
