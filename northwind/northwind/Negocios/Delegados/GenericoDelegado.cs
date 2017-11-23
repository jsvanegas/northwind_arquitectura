using northwind.Persistencia.Conexion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace northwind.Negocios.Delegados
{
    public class GenericoDelegado
    {
        protected NorthwindEntities cnn;
        public GenericoDelegado(NorthwindEntities cnn) {
            this.cnn = cnn;
        }
    }
}