using System;
using System.Collections.Generic;
using System.Text;

namespace Clinica.EN
{
    public enum Resultado
    {
        Fallo = 0,
        FalloValidacion = 1,
        FalloHeredado = 2,
        Exito = 3,
        Inconsistencia = 4,
        Indefinido = 5,
        SinRegistros = 6,
        ResultadoNoEsperado = 7,
        NoEncontradoEnSession = 8,
        ContextoNoAutenticado = 9,
        FalloAutenticacion = 10,
        FalloAuthToken = 11,
        NoAutorizado = 12
    }
}
