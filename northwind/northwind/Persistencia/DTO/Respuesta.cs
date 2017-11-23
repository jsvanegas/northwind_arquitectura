using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using northwind.Persistencia.Conexion;
using northwind.Negocios.Constantes;

namespace northwind.Persistencia.DTO
{
    public class Respuesta
    {

        public int Codigo { get; set; }
        public String Mensaje { get; set; }
        public Object Datos { get; set; }

        public void AsignarError(int codigo, string mensaje, object datos) {
            this.Codigo = codigo;
            this.Mensaje = mensaje;
            this.Datos = datos;
        }

        public void AsignarError(int codigo, string mensaje)
        {
            this.Codigo = codigo;
            this.Mensaje = mensaje;
        }

        public void AsignarError(string mensaje, object datos=null)
        {
            this.Codigo = -1;
            this.Mensaje = mensaje;
            this.Datos = datos;
        }

        public void asignarRespuestaConsulta(IEnumerable<Categories> datos)
        {
            if (datos.Count()>0)
            {
                this.Mensaje = Mensajes.Respuestas.CONSULTA_CORRECTA;
                this.Codigo = 1;
                this.Datos = datos;
                return;
            }

            this.Mensaje = Mensajes.Respuestas.CONSULTA_VACIA;
            this.Codigo = 0;
            this.Datos = null;
        }

        public void asignarRespuestaConsulta(object datos)
        {
            if (datos!=null)
            {
                this.Mensaje = Mensajes.Respuestas.CONSULTA_CORRECTA;
                this.Codigo = 1;
                this.Datos = datos;
                return;
            }

            this.Mensaje = Mensajes.Respuestas.CONSULTA_VACIA;
            this.Codigo = 0;
            this.Datos = null;
        }
        public void asignarRespuestaActualizacion(int respuesta)
        {
            if (respuesta > 0)
            {
                this.Mensaje = Mensajes.Respuestas.ACTULIZACION_EXITOSA;
                this.Codigo = 1;
                this.Datos = null;
                return;
            }

            this.Mensaje = Mensajes.Respuestas.CONSULTA_VACIA;
            this.Codigo = 0;
            this.Datos = null;
        }


    }
}