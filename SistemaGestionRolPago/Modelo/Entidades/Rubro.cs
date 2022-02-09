using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Rubro
    {
        public int RubroId { get; set; }
        public string Nombre_Rubro { get; set; }
        public string Tipo_Rubro { get; set; }
        public int Mes_Pago_Rubro { get; set; }
        public int Dias_Gracia_Rubro { get; set; }

        //Propiedad relacion con Empleado
        public IEnumerable<Empleado> Empleados { get; set; }

        //Propiedad relacion con RubrosEmpleados
        //public IEnumerable<RubroEmpleado> RubroEmpleado { get; set; }

        //Propiedad relacion con RolPagos
        public RolPago Rol_Pagos { get; set; }
        public int RolPagosId { get; set; }
    }
}
