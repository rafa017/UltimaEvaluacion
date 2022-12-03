using Modelos;
using Modelos.Mantenedores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace Negocio.Mantenedores
{

    public class EmpleadoBL : ICrud<Empleado>
    {
        ResponseExec resp = new ResponseExec();

        public ResponseExec Create(Empleado o)
        {
            try
            {
                resp.error = !o.Data.execData("INSERT Empleado (Id_empleado, Numero, Rut ) VALUES ('" + o.id_empleado + "', '" + o.departamento + "', '" + o.Rut + "')");
                resp.mensaje = "Todo bien";

            }
            catch (Exception e)
            {
                resp.error = true;
                resp.mensaje = e.Message;
            }

            return resp;
        }

        public ResponseExec Delete(Empleado o)
        {
            try
            {
                resp.error = !o.Data.execData("DELETE FROM Empleado WHERE Id_empleado=  '" + o.id_empleado + "'");
                resp.mensaje = "Todo bien";

            }
            catch (Exception e)
            {
                resp.error = true;
                resp.mensaje = e.Message;
            }

            return resp;
        }

        public List<Empleado> Get(Empleado o)
        {
            return convertToList(o.Data.queryData("SELECT * FROM Empleado"));
        }

        public Empleado GetById(Empleado o)
        {
            return convertToList(o.Data.queryData("SELECT * FROM Empleado WHERE Id_empledo='" + o.id_empleado + "'")).FirstOrDefault();
        }

        public List<Empleado> GetQuery(Empleado o)
        {
            return convertToList(o.Data.queryData("SELECT * FROM Empleado WHERE Id_empleado='" + o.id_empleado + "'"));
        }

        public ResponseExec Update(Empleado o)
        {
            try
            {
                resp.error = !o.Data.execData("UPDATE Empleado WHERE Id_empleado='" + o.id_empleado + "'");
                resp.mensaje = "Todo bien";

            }
            catch (Exception e)
            {
                resp.error = true;
                resp.mensaje = e.Message;
            }

            return resp;
        }
        public List<Empleado> convertToList(DataTable dt)
        {
            List<Empleado> listado = new List<Empleado>();
            foreach (DataRow item in dt.Rows)
            {
                Empleado o = new Empleado();
                o.id_empleado = int.Parse(item.ItemArray[0].ToString());
             
                listado.Add(o);
            }
            return listado;
        }
    }
}
