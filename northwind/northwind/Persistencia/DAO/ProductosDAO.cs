using northwind.Persistencia.Conexion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static northwind.Persistencia.VO.EntidadesSerializables;
using northwind.Persistencia.VO;

namespace northwind.Persistencia.DAO
{
    public class ProductosDAO : GenericoDAO, IDAO<Products, Productos>
    {
        public ProductosDAO(NorthwindEntities cnn) : base(cnn)
        {
        }

        public int Actualizar(Products entidad)
        {
            var producto = this.ConsultarPorId(entidad.ProductID);
            this.mezclarEntidades<Products>(producto, entidad, "ProductID");
            return cnn.SaveChanges();
        }

        public Productos ConsultarPorId(int idEntidad)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Productos> ConsultarTodos()
        {
            throw new NotImplementedException();
        }

        public int Eliminar(int idEntidad)
        {
            throw new NotImplementedException();
        }

        public int Insertar(Products entidad)
        {
            throw new NotImplementedException();
        }

        public string Pruebas()
        {
            return "pruebas";
        }
    }
}