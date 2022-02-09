using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class RubroEmpleado
    {
        public int RubrosId { get; set; }
        public int EmpeladoId { get; set; }

        //Relacion
        public Rubro Rubros { get; set; }
        public Empleado Empleados { get; set; }
    }
}
