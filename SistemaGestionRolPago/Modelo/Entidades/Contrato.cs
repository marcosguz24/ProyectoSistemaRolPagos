using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Contrato
    {
        public int ContratoId { get; set; }

        [DataType(DataType.Date)]
        public DateTime Inicio_Contrato { get; set; }

        [DataType(DataType.Date)]
        public DateTime Fin_Contrato { get; set; }

        public decimal Sueldo_Contrato { get; set; }

        //Propiedad para implementar la relacion 1 - n con TipoContrato
        public TipoContrato Tipos_Contratos { get; set; }
        public int TipoContratoId { get; set; }

        //Propiedad para implementar la relacion 1 - 1 con Cargo
        public Cargo Cargos { get; set; }
        public int CargoId { get; set; }

        //Propiedad para implementar la realacion 1 - 1 con Empleado
        public IEnumerable<Empleado> Empleados { get; set; }
    }
}
