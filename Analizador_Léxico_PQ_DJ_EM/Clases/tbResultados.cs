using System;

namespace Analizador_Léxico_PQ_DJ_EM.Clases
{
    internal class tbResultados
    {
        int IdResultado { get; set; }

        int IdToken { get; set; }

        int Linea { get; set; }

        int Columna { get; set; }

        String Identificador { get; set; }
    }
}
