using Modelos;
using Negocio.Mantenedores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace APIEv3.Controllers
{
    public class DepartamentoController : Controller
    {
        DepartamentoBL depaBL = new DepartamentoBL();
        Departamento depa = new Departamento();
        ErrorResponse error;


        [HttpPost]
        [Route("api/v1/Departamento/nuevo")]
        public ActionResult Create(DepartamentoDTO o)
        {
            try
            {
                depa.Numero = o.Numero;
                depa.Nombre = o.Nombre;
                return ok(depaBL.Create(depa));

            }
            catch (Exception ex)
            {
                error = new ErrorResponse(ex);

            }
        }

        [HttpGet]
        [Route("api/v1/Departamento/listar")]
        public ActionResult Listar(DepartamentoDTO o)
        {
            try
            {

                return ok(depaBL.Get(depa));

            }
            catch (Exception ex)
            {
                error = new ErrorResponse(ex);

            }
        }

        [HttpGet]
        [Route("api/v1/Departamento/Buscar")]
        public ActionResult Buscar(DepartamentoDTO o)
        {
            try
            {
                depa.Numero = o.Numero;
                return ok(depaBL.GetById(depa));

            }
            catch (Exception ex)
            {
                error = new ErrorResponse(ex);

            }
        }

        [HttpGet]
        [Route("api/v1/Departamento/BuscarNombre")]
        public ActionResult BuscarNombre(DepartamentoDTO o)
        {
            try
            {
                depa.Nombre = o.Nombre;
                return ok(depaBL.GetQuery(depa));

            }
            catch (Exception ex)
            {
                error = new ErrorResponse(ex);

            }
        }

        [HttpDelete]
        [Route("api/v1/Departamento/Eliminar")]
        public ActionResult Eliminar(DepartamentoDTO o)
        {
            try
            {
                depa.Numero = o.Numero;
                return ok(depaBL.Delete(depa));

            }
            catch (Exception ex)
            {
                error = new ErrorResponse(ex);

            }
        }

        [HttpPut]
        [Route("api/v1/Departamento/Atualizar")]
        public ActionResult Actualizar(DepartamentoDTO o)
        {
            try
            {
                depa.Numero = o.Numero;
                depa.Nombre = o.Nombre;
                return ok(depaBL.Update(depa));

            }
            catch (Exception ex)
            {
                error = new ErrorResponse(ex);

            }
        }

    }
}
