using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Problema5;

public class Sale
{
    private double importe;
    public virtual decimal CalculateTotal(double importe)
    {
        return (decimal)importe;
    }
    public decimal ObtenerImporteFinal(Sale sale)
    {
        return sale.CalculateTotal(importe);
    }
}
