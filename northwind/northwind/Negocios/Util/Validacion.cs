using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace northwind.Negocios.Util
{
    public class Validacion
    {
        public static bool ValidarStrings(params string[] parametros)
        {
            for (int i = 0; i < parametros.Length; i++)
            {
                if (string.IsNullOrEmpty(parametros[i]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}