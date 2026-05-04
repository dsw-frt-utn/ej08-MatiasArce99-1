using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Problema1;

public partial class ProductHelper
{
    public string FormatearPrecio(decimal price)
    {
        return price.ToString("0.00");
    }
}
