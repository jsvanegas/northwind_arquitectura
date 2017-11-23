using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace northwind.Negocios.Constantes
{
    public class Mensajes
    {
        public class Errores {
            public static string ERROR_CONSULTAR = "Ocurrió al consultar";
            public static string ERROR_CONSULTAR_ID = "Ocurrió al consultar el dato especificado";
            public static string ERROR_INSERTAR_CATEGORIA = "Ocurrió un error al registrar la categoría";
            public static string ERROR_ACTUALIZAR_CATEGORIA = "Ocurrió un error al actualizar la categoría";
            public static string ERROR_ELIMINAR_CATEGORIA = "Ocurrió un error eliminar categoría";
        }
        public class Respuestas {
            public static string CONSULTA_CORRECTA = "Consulta Correcta";
            public static string CONSULTA_VACIA = "No se encontraron datos en la búsqueda";
            public static string ACTULIZACION_EXITOSA = "La actualización fue exitosa";

        }


    }
}