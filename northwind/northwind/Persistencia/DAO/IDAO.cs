using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace northwind.Persistencia.DAO
{
    /// <summary>
    /// Interface de la que deben heredar todos los DAO
    /// </summary>
    /// <typeparam name="T">Entidad generada por Entity Framework</typeparam>
    /// <typeparam name="V">Entidad extendida, para serializaciones</typeparam>
    interface IDAO<T, V>
    {
        int Insertar(T entidad);
        int Actualizar(T entidad);
        int Eliminar(int idEntidad);
        IEnumerable<V> ConsultarTodos();
        V ConsultarPorId(int idEntidad);
    }
}
