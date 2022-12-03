using Modelos;
using Modelos.Mantenedores;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Mantenedores
{
    public class CargoBL : ICrud<Cargo>
    {
        ResponseExec resp = new ResponseExec();

        public ResponseExec Create(Cargo o)
        {
            try
            {
                resp.error = !o.Data.execData("INSERT INTO (Codigo, Nombre) VALUES ('"+o.codigo+"', '"+o.nombre+"')");
                resp.mensaje = "Todo bien";
                
            }
            catch (Exception e)
            {
                resp.error = true;
                resp.mensaje = e.Message;
            }

            return resp;
        }

        public ResponseExec Delete(Cargo o)
        {
            try
            {
                resp.error = !o.Data.execData("DELETE FROM Cargo WHERE Codigo=  '" + o.codigo + "'");
                resp.mensaje = "Todo bien";

            }
            catch (Exception e)
            {
                resp.error = true;
                resp.mensaje = e.Message;
            }

            return resp;
        }

        public List<Cargo> Get(Cargo o)
        {
           return convertToList (o.Data.queryData("SELECT * FROM Cargo"));
        }

        public Cargo GetById(Cargo o)
        {
            return convertToList(o.Data.queryData("SELECT * FROM Cargo WHERE Codigo='"+o.codigo+"'")).FirstOrDefault();
        }

        public List<Cargo> GetQuery(Cargo o)
        {
            return convertToList(o.Data.queryData("SELECT * FROM Cargo WHERE Nombre='"+o.nombre+"'"));
        }

        public ResponseExec Update(Cargo o)
        {
            try
            {
                resp.error = !o.Data.execData("UPDATE Cargo SET  Nombre='" + o.nombre + "' WHERE Codigo='" + o.codigo + "'");
                resp.mensaje = "Todo bien";

            }
            catch (Exception e)
            {
                resp.error = true;
                resp.mensaje = e.Message;
            }

            return resp;
        }

        public List<Cargo> convertToList(DataTable dt)
        {
            List<Cargo> listado = new List<Cargo>();
            foreach(DataRow item in dt.Rows) 
            {
                Cargo o = new Cargo();
                o.codigo = int.Parse(item.ItemArray[0].ToString());
                o.nombre = item.ItemArray[1].ToString();
                listado.Add(o);
            }
            return listado; 
        }
    }

}
