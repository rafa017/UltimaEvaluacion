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
    public class JefeBL : ICrud<Jefe>
    {
        ResponseExec resp = new ResponseExec();
        public ResponseExec Create(Jefe o)
        {
            try
            {
                resp.error = !o.Data.execData("INSERT Jefe (Id_jefe, Rut) VALUES ('" + o.id_jefe + "', '" + o.Rut + "')");
                resp.mensaje = "Todo bien";

            }
            catch (Exception e)
            {
                resp.error = true;
                resp.mensaje = e.Message;
            }

            return resp;
        }

        public ResponseExec Delete(Jefe o)
        {
            try
            {
                resp.error = !o.Data.execData("DELETE FROM Jefe WHERE Id_jefe=  '" + o.id_jefe + "'");
                resp.mensaje = "Todo bien";

            }
            catch (Exception e)
            {
                resp.error = true;
                resp.mensaje = e.Message;
            }

            return resp;
        }

        public List<Jefe> Get(Jefe o)
        {
            return convertToList(o.Data.queryData("SELECT * FROM Jefe"));
        }

        public Jefe GetById(Jefe o)
        {
            return convertToList(o.Data.queryData("SELECT * FROM Jefe WHERE Id_jefe='" + o.id_jefe + "'")).FirstOrDefault();
        }

        public List<Jefe> GetQuery(Jefe o)
        {
            return convertToList(o.Data.queryData("SELECT * FROM Jefe WHERE Id_jefe='" + o.id_jefe + "'"));
        }

        public ResponseExec Update(Jefe o)
        {
            try
            {
                resp.error = !o.Data.execData("UPDATE Jefe WHERE Id_jefe='" + o.id_jefe + "'");
                resp.mensaje = "Todo bien";

            }
            catch (Exception e)
            {
                resp.error = true;
                resp.mensaje = e.Message;
            }

            return resp;
        }
        public List<Jefe> convertToList(DataTable dt)
        {
            List<Jefe> listado = new List<Jefe>();
            foreach (DataRow item in dt.Rows)
            {
                Jefe o = new Jefe();
                o.id_jefe = int.Parse(item.ItemArray[0].ToString());

                listado.Add(o);
            }
            return listado;
        }
    }
}
