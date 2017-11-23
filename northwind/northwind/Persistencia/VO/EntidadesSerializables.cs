using northwind.Persistencia.Conexion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace northwind.Persistencia.VO
{
    public class EntidadesSerializables
    {
        public sealed class Categorias : Categories { }
        public sealed class Productos : Products { }
        public sealed class Clientes : Customers { }
        public sealed class Empleados : Employees { }
        public sealed class Ordenes : Orders { }
        public sealed class DetallesOrden : Order_Details { }
    }
}