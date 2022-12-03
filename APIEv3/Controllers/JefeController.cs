using Modelos.Mantenedores;
using Negocio.Mantenedores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace APIEv3.Controllers
{
    public class JefeController : Controller
    {
        JefeBL jefeBL = new JefeBL();
        Jefe jefe = new Jefe();
        ErrorResponse error;




        [HttpPost]
        [Route("api/v1/Jefe/nuevo")]
        public ActionResult Create(JefeDTO o)
        {
            try
            {
                jefe.id_jefe = o.id_jefe;
                return ok(jefeBL.Create(jefe));

            }
            catch (Exception ex)
            {
                error = new ErrorResponse(ex);

            }
        }

        [HttpGet]
        [Route("api/v1/Jefe/listar")]
        public ActionResult Listar(JefeDTO o)
        {
            try
            {

                return ok(jefeBL.Get(jefe));

            }
            catch (Exception ex)
            {
                error = new ErrorResponse(ex);

            }
        }

        [HttpGet]
        [Route("api/v1/Jefe/Buscar")]
        public ActionResult Buscar(JefeDTO o)
        {
            try
            {
                jefe.id_jefe = o.id_jefe;
                return ok(jefeBL.GetById(jefe));

            }
            catch (Exception ex)
            {
                error = new ErrorResponse(ex);

            }
        }

        [HttpGet]
        [Route("api/v1/Jefe/BuscarNombre")]
        public ActionResult BuscarNombre(JefeDTO o)
        {
            try
            {
                jefe.id_jefe = o.id_jefe;
                return ok(jefeBL.GetQuery(jefe));

            }
            catch (Exception ex)
            {
                error = new ErrorResponse(ex);

            }
        }

        [HttpDelete]
        [Route("api/v1/Jefe/Eliminar")]
        public ActionResult Eliminar(JefeDTO o)
        {
            try
            {
                jefe.id_jefe = o.id_jefe;
                return ok(jefeBL.Delete(jefe));

            }
            catch (Exception ex)
            {
                error = new ErrorResponse(ex);

            }
        }

        [HttpPut]
        [Route("api/v1/Jefe/Atualizar")]
        public ActionResult Actualizar(JefeDTO o)
        {
            try
            {
                jefe.id_jefe = o.id_jefe;
           
                return ok(jefeBL.Update(jefe));

            }
            catch (Exception ex)
            {
                error = new ErrorResponse(ex);

            }
        }
    }
}
