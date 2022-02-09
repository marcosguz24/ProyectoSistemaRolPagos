using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class TipoDiscapacidad
    {
        public int TipoDiscapacidadId { get; set; }
        public string NombreTipoDiscapacidad { get; set; }
        public string Descripcion_TipoDiscapacidad { get; set; }

        //Propiedad de la relacion 1 - n  con Empleado
        public Empleado Empleados { get; set; }

        //Propiedad de la relacion con DiscapacidadEmpleado
        public IEnumerable<DiscapacidadEmpleado> discapacidadEmpleados { get; set; }
    }
}
