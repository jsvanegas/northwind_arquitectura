using northwind.Negocios.Delegados;
using northwind.Negocios.Excepciones;
using northwind.Persistencia.Conexion;
using northwind.Persistencia.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;

namespace northwind.Negocios.Controllers
{
    public class CategoriasController : ApiController
    {
        [HttpPost, HttpGet]
        [Route("api/categorias/consultar")]
        public Respuesta ConsultarCategorias() {
            var respuesta = new Respuesta();
            try
            {
                using (var cnn = new NorthwindEntities()) {
                    var delegado = new CategoriasDelegado(cnn);
                    respuesta.asignarRespuestaConsulta(delegado.ConsultarTodos());
                }
            }
            catch (NorthwindException ex)
            {
                respuesta.AsignarError(ex.Message);
            }
            return respuesta;
        }

        [HttpPost]
        [Route("api/categorias/consultar/id")]
        public Respuesta ConsultarCategorias(FormDataCollection parametros)
        {
            var respuesta = new Respuesta();
            try
            {
                using (var cnn = new NorthwindEntities())
                {
                    var delegado = new CategoriasDelegado(cnn);
                    int id = 0;
                    int.TryParse(parametros["id"], out id);
                    respuesta.asignarRespuestaConsulta(delegado.ConsultarPorId(id));
                }
            }
            catch (NorthwindException ex)
            {
                respuesta.AsignarError(ex.Message);
            }
            return respuesta;
        }

        [HttpPut]
        [Route("api/categorias/actualizar")]
        public Respuesta ActualizaCategoria(Categories categoria)
        {
            var respuesta = new Respuesta();
            try
            {
                using (var cnn = new NorthwindEntities())
                {
                    var delegado = new CategoriasDelegado(cnn);
                    respuesta.asignarRespuestaActualizacion(delegado.Actualizar(categoria));
                }
            }
            catch (NorthwindException ex)
            {
                respuesta.AsignarError(ex.Message);
            }
            return respuesta;
        }


    }
}
