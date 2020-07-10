using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital.EN
{
    public class Retorno : IRetornable
    {
        //public Retorno();
        public Resultado Resultado { get; set; }
        public string Informacion { get; set; }
    }


}
