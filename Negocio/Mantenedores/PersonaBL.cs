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
    public class PersonaBL : ICrud<Persona>
    {
        ResponseExec resp = new ResponseExec();

        public ResponseExec Create(Persona o)
        {
            try
            {
                resp.error = !o.Data.execData("INSERT Persona (Rut, Nombre, Apellido) VALUES ('" + o.Rut + "', '" + o.Nombre + "', , '" + o.Apellido + "')");
                resp.mensaje = "Todo bien";

            }
            catch (Exception e)
            {
                resp.error = true;
                resp.mensaje = e.Message;
            }

            return resp;
        }

        public ResponseExec Delete(Persona o)
        {
            try
            {
                resp.error = !o.Data.execData("DELETE FROM Empleado WHERE Rut=  '" + o.Rut + "'");
                resp.mensaje = "Todo bien";

            }
            catch (Exception e)
            {
                resp.error = true;
                resp.mensaje = e.Message;
            }

            return resp;
        }

        public List<Persona> Get(Persona o)
        {
            return convertToList(o.Data.queryData("SELECT * FROM Persona"));
        }

        public Persona GetById(Persona o)
        {
            return convertToList(o.Data.queryData("SELECT * FROM Persona WHERE Rut='" + o.Rut + "'")).FirstOrDefault();
        }

        public List<Persona> GetQuery(Persona o)
        {
            return convertToList(o.Data.queryData("SELECT * FROM Persona WHERE Rut='" + o.Rut + "'"));
        }

        public ResponseExec Update(Persona o)
        {
            try
            {
                resp.error = !o.Data.execData("UPDATE Persona SET  Nombre='" + o.Nombre + "', Apellido='" + o.Apellido + "' WHERE Rut='" + o.Rut + "'");
                resp.mensaje = "Todo bien";

            }
            catch (Exception e)
            {
                resp.error = true;
                resp.mensaje = e.Message;
            }

            return resp;
        }
        public List<Persona> convertToList(DataTable dt)
        {
            List<Persona> listado = new List<Persona>();
            foreach (DataRow item in dt.Rows)
            {
                Persona o = new Persona();
                o.Rut = item.ItemArray[0].ToString();
                o.Nombre = item.ItemArray[1].ToString();
                o.Apellido = item.ItemArray[2].ToString();
                listado.Add(o);
            }
            return listado;
        }
    }
}
