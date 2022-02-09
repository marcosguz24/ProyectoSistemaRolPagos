using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Empleado
    {
        public int EmpleadoId { get; set; }
        public string Apellidos_Empleado { get; set; }
        public string Nombres_Empleado { get; set; }
        public string Cedula_Empleado { get; set; }
        public string Email_Empleado { get; set; }
        public string Celular_Empleado { get; set; }
        public string Profesion_Empleado { get; set; }
        public string Nivel_Educacion_Empleado { get; set; }
        public string Sexo_Empelado { get; set; }
        public string Estado_Civil { get; set; }
        public string Banco { get; set; }
        public string Tipo_Cuenta { get; set; }
        public string Numero_Cuenta { get; set; }

        //Propiedad relacion con Contrato
        public Contrato contrato { get; set; }

        //Propiedad relacion con Ciudad
        public Ciudad Nombre_Ciudad { get; set; }

        //Propiedad relacion con TipoDiscapacidad
        public TipoDiscapacidad TiposDiscapacidades { get; set; }
        public int TipoDiscapacidadId { get; set; }

        //Propiedad relacion con DiscapacidadEmpleado
        public IEnumerable<DiscapacidadEmpleado> Discapacidad { get; set; }

        //Propiedad relacion con JornadaTrabajo
        public JornadaTrabajo Jornada_Trabajo { get; set; }
        public int JornadaTrabajoId { get; set; }

        //Porpiedad relacion con Permiso
        public Permiso Permisos { get; set; }
        public int PermisosId { get; set; }

        //Propiedad relacion con Rubros
        public Rubro Rubros { get; set; }
        public int RubrosId { get; set; }

        //Propiedad relacion con RubrosEmpleados
        public IEnumerable<RubroEmpleado> RubroEmpleado { get; set; }

        //Propiedad relacion con Asistencia
        public Asistencia AsistenciaEmpleados { get; set; }
        public int AsistenciaId { get; set; }
    }
}
