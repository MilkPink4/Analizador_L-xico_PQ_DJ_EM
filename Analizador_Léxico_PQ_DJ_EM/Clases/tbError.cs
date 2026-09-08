using System;


namespace Analizador_Léxico_PQ_DJ_EM.Clases
{
    internal class tbError
    {
        int IdError { get; set; }

        int LineaError { get; set; }

        int ColumnaError { get; set; }

        String Error { get; set; }

        String Observacion { get; set; }
    }
}
