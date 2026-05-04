using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace Dsw2026Ej8.Problema3;

public class Problema3
{
    public string CompararCopias(int originalValue, Product product)
    {
        int _variableLocal = originalValue;
        _variableLocal++;

        Product p = product;
        p.SetDescripcion("Producto modificado");

        return $"{originalValue} - {_variableLocal} - {p.GetDescripcion()}";
    }
}
