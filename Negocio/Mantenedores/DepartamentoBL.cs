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
    public class DepartamentoBL : ICrud<Departamento>
    {
        ResponseExec resp = new ResponseExec();
        public ResponseExec Create(Departamento o)
        {
            try
            {
                resp.error = !o.Data.execData("INSERT INTO (Numero, Nombre, Direccion) VALUES ('" + o.Numero + "', '" + o.Nombre + "', '"+o.direccion+"')");
                resp.mensaje = "Todo bien";

            }
            catch (Exception e)
            {
                resp.error = true;
                resp.mensaje = e.Message;
            }

            return resp;
        }

        public ResponseExec Delete(Departamento o)
        {
            try
            {
                resp.error = !o.Data.execData("DELETE FROM Departamento WHERE Numero=  '" + o.Numero + "'");
                resp.mensaje = "Todo bien";

            }
            catch (Exception e)
            {
                resp.error = true;
                resp.mensaje = e.Message;
            }

            return resp;
        }

        public List<Departamento> Get(Departamento o)
        {
            return convertToList(o.Data.queryData("SELECT * FROM Departamento"));
        }

        public Departamento GetById(Departamento o)
        {
            return convertToList(o.Data.queryData("SELECT * FROM Departamento WHERE Numero='" + o.Numero + "'")).FirstOrDefault();
        }

        public List<Departamento> GetQuery(Departamento o)
        {
            return convertToList(o.Data.queryData("SELECT * FROM Cargo WHERE Nombre='" + o.Nombre + "'"));
        }

        public ResponseExec Update(Departamento o)
        {
            try
            {
                resp.error = !o.Data.execData("UPDATE Departamento SET  Nombre='" + o.Nombre + "' WHERE Nuemro='" + o.Numero + "'");
                resp.mensaje = "Todo bien";

            }
            catch (Exception e)
            {
                resp.error = true;
                resp.mensaje = e.Message;
            }

            return resp;
        }
        public List<Departamento> convertToList(DataTable dt)
        {
            List<Departamento> listado = new List<Departamento>();
            foreach (DataRow item in dt.Rows)
            {
                Departamento o = new Departamento();
                o.Numero = int.Parse(item.ItemArray[0].ToString());
                o.Nombre = item.ItemArray[1].ToString();
                listado.Add(o);
            }
            return listado;
        }
    }
}
