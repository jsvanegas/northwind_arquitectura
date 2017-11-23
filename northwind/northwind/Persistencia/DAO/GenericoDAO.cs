using northwind.Persistencia.Conexion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace northwind.Persistencia.DAO
{
    public class GenericoDAO
    {

        protected NorthwindEntities cnn;

        public GenericoDAO(NorthwindEntities cnn) {
            this.cnn = cnn;
        }

        public void mezclarEntidades<T>(T destino, T origen, string propiedadId) {
            Type t = typeof(T);
            var propiedades = t.GetProperties().Where(p => p.CanRead && p.CanWrite && p.Name!=propiedadId);
            foreach (var prop in propiedades)
            {
                var valor = prop.GetValue(origen, null);
                prop.SetValue(destino, valor, null);
            }
        }


    }
}