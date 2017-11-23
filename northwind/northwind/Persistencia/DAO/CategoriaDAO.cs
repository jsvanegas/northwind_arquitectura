using northwind.Persistencia.Conexion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static northwind.Persistencia.VO.EntidadesSerializables;
using northwind.Persistencia.VO;

namespace northwind.Persistencia.DAO
{
    public class CategoriaDAO : GenericoDAO, IDAO<Categories, Categorias>
    {
        public CategoriaDAO(NorthwindEntities cnn) : base(cnn)
        {
        }

        public int Actualizar(Categories entidad)
        {
            var categoria = this.ConsultarPorId(entidad.CategoryID);
            this.mezclarEntidades<Categories>(categoria, entidad, "CategoryID");
            return cnn.SaveChanges();
        }

        public Categorias ConsultarPorId(int idEntidad)
        {
            var categoria = this.cnn.Categories.SingleOrDefault(c => c.CategoryID == idEntidad);
            return new Categorias()
            {
                CategoryID = categoria.CategoryID,
                CategoryName = categoria.CategoryName,
                Description = categoria.Description
            };
        }

        public IEnumerable<Categorias> ConsultarTodos()
        {
            var categorias = cnn.Categories.Select(c => new Categorias()
            {
                CategoryID = c.CategoryID,
                CategoryName = c.CategoryName,
                Description = c.Description
            }).ToList();
            return categorias;
        }

        public int Eliminar(int idEntidad)
        {
            var categoria = this.ConsultarPorId(idEntidad);
            this.cnn.Categories.Remove(categoria);
            return cnn.SaveChanges();
        }

        public int Insertar(Categories entidad)
        {
            cnn.Categories.Add(entidad);
            cnn.SaveChanges();
            return entidad.CategoryID;
        }
    }
}