using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Modelos.Mantenedores
{
    public class Persona : IDataEntity
    {
        public string Rut { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public data Data { get; set; }
        public List<Parametros> parametros { get; set; }


        public Persona()
        {
            Data = new data();
            parametros = new List<Parametros>();

        }

        public Persona(string rut, string nombre, string apellido)
        {
            Rut = rut;
            Nombre = nombre;
            Apellido = apellido;
        }
    }
}

