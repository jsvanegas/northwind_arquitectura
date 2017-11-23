using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using northwind.Persistencia.Conexion;
using static northwind.Persistencia.VO.EntidadesSerializables;
using northwind.Negocios.Excepciones;
using northwind.Negocios.Constantes;
using northwind.Persistencia.DAO;

namespace northwind.Negocios.Delegados
{
    public class CategoriasDelegado : GenericoDelegado, IDelegado<Categories, Categorias>
    {
        private CategoriaDAO categoriaDAO;

        public CategoriasDelegado(NorthwindEntities cnn) : base(cnn)
        {
            this.categoriaDAO = new CategoriaDAO(cnn);
        }

        public int Actualizar(Categories entidad)
        {
            try
            {
                return categoriaDAO.Actualizar(entidad);
            }
            catch (Exception ex)
            {
                throw new NorthwindException(Mensajes.Errores.ERROR_ACTUALIZAR_CATEGORIA, ex) ;
            }
        }

        public Categories ConsultarPorId(int idEntidad)
        {
            try
            {
                return categoriaDAO.ConsultarPorId(idEntidad);
            }
            catch (Exception ex)
            {
                throw new NorthwindException(Mensajes.Errores.ERROR_CONSULTAR_ID, ex);
            }
        }

        public IEnumerable<Categories> ConsultarTodos()
        {
            try
            {
                return categoriaDAO.ConsultarTodos();
            }
            catch (Exception ex)
            {
                throw new NorthwindException(Mensajes.Errores.ERROR_CONSULTAR, ex);
            }
        }

        public int Eliminar(int idEntidad)
        {
            try
            {
                return categoriaDAO.Eliminar(idEntidad);
            }
            catch (Exception ex)
            {
                throw new NorthwindException(Mensajes.Errores.ERROR_ELIMINAR_CATEGORIA, ex);
            }
        }

        public int Insertar(Categories entidad)
        {
            try
            {
                return categoriaDAO.Insertar(entidad);
            }
            catch (Exception ex)
            {
                throw new NorthwindException(Mensajes.Errores.ERROR_INSERTAR_CATEGORIA, ex);
            }
        }
    }
}