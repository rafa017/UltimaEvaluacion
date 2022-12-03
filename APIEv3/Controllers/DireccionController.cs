using Modelos;
using Negocio.Mantenedores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace APIEv3.Controllers
{
    public class DireccionController : Controller
    {
        DireccionBL direBL = new DireccionBL();
        Direccion dire = new Direccion();
        ErrorResponse error;


        [HttpPost]
        [Route("api/v1/Direccion/nuevo")]
        public ActionResult Create(DireccionDTO o)
        {
            try
            {
                dire.Calle = o.Calle;
                dire.Calle = o.Calle;
                return ok(direBL.Create(dire));

            }
            catch (Exception ex)
            {
                error = new ErrorResponse(ex);

            }
        }

        [HttpGet]
        [Route("api/v1/Direccion/listar")]
        public ActionResult Listar(DireccionDTO o)
        {
            try
            {

                return ok(direBL.Get(dire));

            }
            catch (Exception ex)
            {
                error = new ErrorResponse(ex);

            }
        }

        [HttpGet]
        [Route("api/v1/Direccion/Buscar")]
        public ActionResult Buscar(DireccionDTO o)
        {
            try
            {
                dire.Calle = o.Calle;
                return ok(direBL.GetById(dire));

            }
            catch (Exception ex)
            {
                error = new ErrorResponse(ex);

            }
        }

        [HttpGet]
        [Route("api/v1/Direccion/Buscar")]
        public ActionResult Buscar(DireccionDTO o)
        {
            try
            {
                dire.Region = o.Region;
                return ok(direBL.GetQuery(dire));

            }
            catch (Exception ex)
            {
                error = new ErrorResponse(ex);

            }
        }

        [HttpDelete]
        [Route("api/v1/Direccion/Eliminar")]
        public ActionResult Eliminar(DireccionDTO o)
        {
            try
            {
                dire.Calle = o.Calle;
                return ok(direBL.Delete(dire));

            }
            catch (Exception ex)
            {
                error = new ErrorResponse(ex);

            }
        }

        [HttpPut]
        [Route("api/v1/Direccion/Atualizar")]
        public ActionResult Actualizar(DireccionDTO o)
        {
            try
            {
                dire.Calle = o.Calle;
                dire.Calle = o.Calle;
                return ok(direBL.Update(dire));

            }
            catch (Exception ex)
            {
                error = new ErrorResponse(ex);

            }
        }
    }
}
