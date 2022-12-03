using Modelos;
using Negocio.Mantenedores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace APIEv3.Controllers
{
    public class CargoController : Controller
    {
        CargoBL cargoBL = new CargoBL();
        Cargo cargo = new Cargo();
        ErrorResponse error;



      
        [HttpPost]
        [Route("api/v1/Cargo/nuevo")]
        public ActionResult Create(CargoDTO o)
        {
            try
            {
                cargo.codigo = o.codigo;
                cargo.nombre = o.nombre;
                return ok(cargoBL.Create(cargo));
              
            }
            catch (Exception ex)
            {
                error = new ErrorResponse(ex);
             
            }
        }

        [HttpGet]
        [Route("api/v1/Cargo/listar")]
        public ActionResult Listar(CargoDTO o)
        {
            try
            {
             
                return ok(cargoBL.Get(cargo));

            }
            catch (Exception ex)
            {
                error = new ErrorResponse(ex);

            }
        }

        [HttpGet]
        [Route("api/v1/Cargo/Buscar")]
        public ActionResult Buscar(CargoDTO o)
        {
            try
            {
                cargo.codigo = o.codigo;
                return ok(cargoBL.GetById(cargo));

            }
            catch (Exception ex)
            {
                error = new ErrorResponse(ex);

            }
        }

        [HttpGet]
        [Route("api/v1/Cargo/BuscarNombre")]
        public ActionResult BuscarNombre(CargoDTO o)
        {
            try
            {
                cargo.nombre = o.nombre;
                return ok(cargoBL.GetQuery(cargo));

            }
            catch (Exception ex)
            {
                error = new ErrorResponse(ex);

            }
        }

        [HttpDelete]
        [Route("api/v1/Cargo/Eliminar")]
        public ActionResult Eliminar(CargoDTO o)
        {
            try
            {
                cargo.codigo = o.codigo;
                return ok(cargoBL.Delete(cargo));

            }
            catch (Exception ex)
            {
                error = new ErrorResponse(ex);

            }
        }

        [HttpPut]
        [Route("api/v1/Cargo/Atualizar")]
        public ActionResult Actualizar(CargoDTO o)
        {
            try
            {
                cargo.codigo = o.codigo;
                cargo.nombre = o.nombre;
                return ok(cargoBL.Update(cargo));

            }
            catch (Exception ex)
            {
                error = new ErrorResponse(ex);

            }
        }

    }

    
}
