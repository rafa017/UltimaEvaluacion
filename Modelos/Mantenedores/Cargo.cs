using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Modelos
{
    public class Cargo : IDataEntity
    {

        public int codigo { get; set; }
        public string nombre { get; set; }
        public data Data { get; set; }
        public List<Parametros> parametros { get; set; }

        public Cargo()
        {
            Data = new data();
            parametros = new List<Parametros>();

        }

    }
}
