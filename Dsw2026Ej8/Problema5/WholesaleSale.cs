using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Problema5;

public class WholesaleSale : Sale
{
    public override decimal CalculateTotal(double importe)
    {
        importe -= (importe * 0.10);
        return (decimal)importe;
    }
}
