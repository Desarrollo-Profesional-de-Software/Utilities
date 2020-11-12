using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public static class Extensiones
    {
        public static bool CaseInsensitiveContains(this string texto, string valor, StringComparison stringComparison = StringComparison.OrdinalIgnoreCase)
        {
            return texto.IndexOf(valor, stringComparison) >= 0;
        }

        public static decimal ParseDecimal(this string valor, decimal valorDefault = 0)
        {
            decimal parsedDecimal;
            if (decimal.TryParse(valor, out parsedDecimal))
            {
                return parsedDecimal;
            }
            return valorDefault;
        }

        public static int ParseInt(this string valor, int valorDefault = 0)
        {
            int parsedInt;
            if (int.TryParse(valor, out parsedInt))
            {
                return parsedInt;
            }
            return valorDefault;
        }
    }
}
