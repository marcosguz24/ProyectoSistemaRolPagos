using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Ciudad
    {
        public int CiudadId { get; set; }
        public string Nombre_Ciudad { get; set; }

        //Propiedad relacion con Region
        public Region Regiones { get; set; }
        public int RegionId { get; set; }
    }
}
