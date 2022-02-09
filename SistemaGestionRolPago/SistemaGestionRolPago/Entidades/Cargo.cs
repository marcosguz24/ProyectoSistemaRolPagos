using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Cargo
    {
        public int CargoId { get; set; }
        public string Nombre_Cargo { get; set; }

        //Propiedades de la relacion 1- n con Departamento
        public Departamento Departamentos { get; set; }
        public int DepartamentoId { get; set; }
        //Propiedad de la relacion 1 - 1 con Contrato
        public Contrato Contratos { get; set; }
        public int ContratoId { get; set; }
    }
}
