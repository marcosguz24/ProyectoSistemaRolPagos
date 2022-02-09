using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class TipoPermiso
    {
        public int TipoPermisoId { get; set; }
        public string Nombre_Tipo_Permiso { get; set; }
        public string Descripcion_Tipo_Permiso { get; set; }

        //Propiedad de la relacion 1 - 1 con Permiso
        public IEnumerable<Permiso> permiso { get; set; }
    }
}
