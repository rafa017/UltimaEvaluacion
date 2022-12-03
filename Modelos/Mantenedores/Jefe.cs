using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Modelos.Mantenedores
{
    public class Jefe : Persona, IDataEntity
    {
        public int id_jefe { get; set; }
        public List<Persona> persona { get; set; }
        public data Data { get; set; }

     

        public List<Parametros> parametros { get; set; }

        public Jefe()
        {
            Data = new data();
            parametros = new List<Parametros>();
            persona = new List<Persona>();

        }
    }
}

