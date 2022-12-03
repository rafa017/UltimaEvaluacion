using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Modelos
{
    public class Direccion : IDataEntity
    {
        public string Calle { get; set; }
        public string Region { get; set; }
        public int Numero { get; set; }
        public string Ciudad { get; set; }
        public data Data { get; set; }
        public List<Parametros> parametros { get; set; }

        public Direccion()
        {
            Data = new data();
            parametros = new List<Parametros>();

        }


    }
}
