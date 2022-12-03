using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Negocio.Mantenedores
{
    public class DireccionBL : ICrud<Direccion>
    {
        ResponseExec resp = new ResponseExec();
        public ResponseExec Create(Direccion o)
        {
            try
            {
                resp.error = !o.Data.execData("INSERT Direccion (Calle, Region, Numero, Ciudad) VALUES ('" + o.Calle + "', '" + o.Region + "', , '" + o.Numero + "', , '" + o.Ciudad + "')");
                resp.mensaje = "Todo bien";

            }
            catch (Exception e)
            {
                resp.error = true;
                resp.mensaje = e.Message;
            }

            return resp;
        }

        public ResponseExec Delete(Direccion o)
        {
            try
            {
                resp.error = !o.Data.execData("DELETE FROM Direccion WHERE Calle=  '" + o.Calle + "'");
                resp.mensaje = "Todo bien";

            }
            catch (Exception e)
            {
                resp.error = true;
                resp.mensaje = e.Message;
            }

            return resp;
        }

        public List<Direccion> Get(Direccion o)
        {
            return convertToList(o.Data.queryData("SELECT * FROM Direccion"));
        }

        public Direccion GetById(Direccion o)
        {
            return convertToList(o.Data.queryData("SELECT * FROM Direccion WHERE Calle='" + o.Calle + "'")).FirstOrDefault();
        }

        public List<Direccion> GetQuery(Direccion o)
        {
            return convertToList(o.Data.queryData("SELECT * FROM Direccion WHERE Calle='" + o.Calle + "'"));
        }

        public ResponseExec Update(Direccion o)
        {
            try
            {
                resp.error = !o.Data.execData("UPDATE Direccion SET  Region='" + o.Region + "', Numero='" + o.Numero + "', Ciudad='" + o.Ciudad + "' WHERE Calle='" + o.Calle + "'");
                resp.mensaje = "Todo bien";

            }
            catch (Exception e)
            {
                resp.error = true;
                resp.mensaje = e.Message;
            }

            return resp;
        }
        public List<Direccion> convertToList(DataTable dt)
        {
            List<Direccion> listado = new List<Direccion>();
            foreach (DataRow item in dt.Rows)
            {
                Direccion o = new Direccion();
                o.Calle = item.ItemArray[0].ToString();
                o.Region = item.ItemArray[1].ToString();
                o.Numero = int.Parse(item.ItemArray[2].ToString());
                o.Ciudad = item.ItemArray[3].ToString();
                listado.Add(o);
            }
            return listado;
        }
    }
}
