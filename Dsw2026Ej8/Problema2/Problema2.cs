using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Problema2;

public class Problema2
{
    public string CrearResumenVenta(long productCode, string productDescription, int quantity, decimal unitPrice)
    {
        double total;

        if (quantity <= 0)
        {
            total = 0;
        } else
        {
            total = (double)(quantity * unitPrice);
        }

        var resumen = new
        {
            code = productCode,
            description = productDescription,
            quantity = quantity,
            total = total
        };

        return $"{resumen.code} - {resumen.description} - {resumen.total}";
    }
}
