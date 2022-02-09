using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Asistencia
    {
        public int AsistenciaId { get; set; }
        public string Hora_Asistencia { get; set; }
        public DateTime Fecha_Asistencia { get; set; }
        public string Tipo_Asistencia { get; set; }

        //Propiedades relacion con Empleado
        public IEnumerable<Empleado> Lista_Empleados { get; set; }
    }
}
