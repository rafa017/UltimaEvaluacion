using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Modelos
{ 
    public class Departamento : IDataEntity
    {
        public int Numero { get; set; }
        public string Nombre { get; set; }

        public Direccion direccion { get; set; }
        public data Data { get; set; }
        public List<Parametros> parametros { get; set; }

        public Departamento() 
        {
            Data = new data();
            parametros = new List<Parametros>();

        }

        public Departamento(int numero, string nombre, Direccion direccion)
        {
            Numero = numero;
            Nombre = nombre;
            this.direccion = direccion;
        }

        public void direccionDepartamento(string calle, string region, int numero, string ciudad)
        {

        }
    }
}
