using Modelos.Mantenedores;
using Negocio.Mantenedores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace APIEv3.Controllers
{
    public class EmpleadoController : Controller
    {
        EmpleadoBL empBL = new EmpleadoBL();
        Empleado emp = new Empleado();
        ErrorResponse error;


        [HttpPost]
        [Route("api/v1/Empleado/nuevo")]
        public ActionResult Create(EmpleadoDTO o)
        {
            try
            {
                emp.id_empleado = o.id_empleado;
               
                return ok(empBL.Create(emp));

            }
            catch (Exception ex)
            {
                error = new ErrorResponse(ex);

            }
        }

        [HttpGet]
        [Route("api/v1/Empleado/listar")]
        public ActionResult Listar(EmpleadoDTO o)
        {
            try
            {

                return ok(empBL.Get(emp));

            }
            catch (Exception ex)
            {
                error = new ErrorResponse(ex);

            }
        }

        [HttpGet]
        [Route("api/v1/Empleado/Buscar")]
        public ActionResult Buscar(EmpleadoDTO o)
        {
            try
            {
                emp.id_empleado = o.id_empleado;
                return ok(empBL.GetById(emp));

            }
            catch (Exception ex)
            {
                error = new ErrorResponse(ex);

            }
        }

        [HttpGet]
        [Route("api/v1/Empleado/Buscar")]
        public ActionResult Buscar(EmpleadoDTO o)
        {
            try
            {
                emp.id_empleado = o.id_empleado;
                return ok(empBL.GetQuery(emp));

            }
            catch (Exception ex)
            {
                error = new ErrorResponse(ex);

            }
        }

        [HttpDelete]
        [Route("api/v1/Empleado/Eliminar")]
        public ActionResult Eliminar(EmpleadoDTO o)
        {
            try
            {
                emp.id_empleado = o.id_empleado;
                return ok(empBL.Delete(emp));

            }
            catch (Exception ex)
            {
                error = new ErrorResponse(ex);

            }
        }

        [HttpPut]
        [Route("api/v1/Empleado/Atualizar")]
        public ActionResult Actualizar(EmpleadoDTO o)
        {
            try
            {
                emp.id_empleado = o.id_empleado;
              
                return ok(empBL.Update(emp));

            }
            catch (Exception ex)
            {
                error = new ErrorResponse(ex);

            }
        }
    }
}
