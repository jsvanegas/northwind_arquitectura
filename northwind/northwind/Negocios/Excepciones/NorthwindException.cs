using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace northwind.Negocios.Excepciones
{
    public class NorthwindException: Exception
    {        
        public NorthwindException(string mensaje, Exception ex) : base(mensaje, ex) {

        }
        
    }
}