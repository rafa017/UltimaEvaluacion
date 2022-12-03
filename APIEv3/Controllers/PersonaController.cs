using Modelos.Mantenedores;
using Negocio.Mantenedores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace APIEv3.Controllers
{
    public class PersonaController : Controller
    {
        PersonaBL pesronaBL = new PersonaBL();
        Persona persona = new Persona();
        ErrorResponse error;




        [HttpPost]
        [Route("api/v1/Persona/nuevo")]
        public ActionResult Create(PersonaDTO o)
        {
            try
            {
                persona.Rut = o.Rut;
                persona.Nombre = o.Nombre;
                persona.Apellido = o.Apellido;
                return ok(PersonaBL.Create(persona));

            }
            catch (Exception ex)
            {
                error = new ErrorResponse(ex);

            }
        }

        [HttpGet]
        [Route("api/v1/Persona/listar")]
        public ActionResult Listar(PersonaDTO o)
        {
            try
            {

                return ok(PersonaBL.Get(persona));

            }
            catch (Exception ex)
            {
                error = new ErrorResponse(ex);

            }
        }

        [HttpGet]
        [Route("api/v1/Persona/Buscar")]
        public ActionResult Buscar(PersonaDTO o)
        {
            try
            {
                persona.rut = o.rut;
                return ok(pesronaBL.GetById(persona));

            }
            catch (Exception ex)
            {
                error = new ErrorResponse(ex);

            }
        }

        [HttpGet]
        [Route("api/v1/Persona/BuscarNombre")]
        public ActionResult BuscarNombre(PersonaDTO o)
        {
            try
            {
                persona.Nombre = o.Nombre;
                return ok(pesronaBL.GetQuery(persona));

            }
            catch (Exception ex)
            {
                error = new ErrorResponse(ex);

            }
        }

        [HttpDelete]
        [Route("api/v1/Persona/Eliminar")]
        public ActionResult Eliminar(PersonaDTO o)
        {
            try
            {
                persona.Rut = o.Rut;
                return ok(pesronaBL.Delete(persona));

            }
            catch (Exception ex)
            {
                error = new ErrorResponse(ex);

            }
        }

        [HttpPut]
        [Route("api/v1/Persona/Atualizar")]
        public ActionResult Actualizar(PersonaDTO o)
        {
            try
            {
                persona.Rut = o.Rut;
                persona.Nombre = o.Nombre;
                persona.Apellido = o.Apellido;
                return ok(pesronaBL.Update(persona));

            }
            catch (Exception ex)
            {
                error = new ErrorResponse(ex);

            }
        }
    }
}
