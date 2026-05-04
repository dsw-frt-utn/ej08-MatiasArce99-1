using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Problema4;

public class Problema4
{
    public double CalcularPromedio(int? nota1, int? nota2, int? nota3)
    {
        double promedio;

        if (nota1 != null && nota2 != null && nota3 != null)
        {
            promedio = (double)(nota1 + nota2 + nota3)/3;
        } else
        {
            Console.WriteLine("Las notas no pueden ser NULL");
        }
        return $"{promedio}";
    }
}
