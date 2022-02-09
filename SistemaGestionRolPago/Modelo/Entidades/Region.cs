using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public enum Regiones { Costa, Sierra, Amazonia, Galapagos}
    public class Region
    {
        public int RegionId { get; set; }
        public Regiones Nombre_Region { get; set; }

        //Propiedad relacion con Pais
        public Pais Paises { get; set; }
        public int PaisId { get; set; }

        public IEnumerable<Ciudad> Ciudades { get; set; }
    }
}
