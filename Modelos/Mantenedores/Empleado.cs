using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Modelos.Mantenedores
{
    public class Empleado : Persona, IDataEntity
    {

        public int id_empleado { get; set; }
        public List<Departamento> departamento { get; set; }
        public List<Persona> persona { get; set; }
        public data Data { get; set; }
        public List<Parametros> parametros { get; set; }


        public Empleado()
        {
            Data = new data();
            parametros = new List<Parametros>();
            departamento = new List<Departamento>();
            persona = new List<Persona>();
        }


        public void agregarDepartamento(Departamento depto)
        {
            departamento.Add(depto);
        }
      
    }
}
