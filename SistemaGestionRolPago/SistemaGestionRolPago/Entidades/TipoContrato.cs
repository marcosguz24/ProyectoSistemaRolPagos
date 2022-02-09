using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class TipoContrato
    {
        public int TipoContratoId { get; set; }
        public string Nombre_Tipo_Contrato { get; set; }
        public string Descripcion_Tipo_Contrato { get; set; }

        //Propiedad de la relacion 1 - n con Contrato
        public IEnumerable<Contrato> Contratos { get; set; }
    }
}
