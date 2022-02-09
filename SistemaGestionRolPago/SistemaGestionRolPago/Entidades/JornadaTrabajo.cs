using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class JornadaTrabajo
    {
        public int JornadaTrabajoId { get; set; }
        public string Tipo_Jornada { get; set; }

        //Propiedad de la relacion 1 - n con Empleado
        public IEnumerable<Empleado> Empleados { get; set; }
    }
}
