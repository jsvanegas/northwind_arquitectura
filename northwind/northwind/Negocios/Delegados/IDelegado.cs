using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace northwind.Negocios.Delegados
{
    /// <summary>
    /// Interface que deben implementar todos los delegados
    /// </summary>
    /// <typeparam name="T">Entidad Generada por Entity Framework</typeparam>
    /// <typeparam name="V">Entidad sellada para serializar</typeparam>
    interface IDelegado<T, V>
    {
        int Insertar(T entidad);
        int Actualizar(T entidad);
        int Eliminar(int idEntidad);
        IEnumerable<T> ConsultarTodos();
        T ConsultarPorId(int idEntidad);
    }
}
