using Microsoft.EntityFrameworkCore;
using Modelo.Entidades;
using ModeloDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers
{

    public class OperacionesRolPagos
    {
        readonly SGRPDB db;

        public OperacionesRolPagos(SGRPDB db)
        {
            this.db = db;
        }

        public Empleado empleado { get; set; }
        public Contrato contrato { get; set; }

        public List<Empleado> listaEmpleado { get; set; }

        public OperacionesRolPagos(Empleado empleado)
        {
            this.empleado = empleado;
        }

        public OperacionesRolPagos(List<Empleado> listaEmpleado)
        {
            this.listaEmpleado = listaEmpleado;
        }

        public OperacionesRolPagos(Contrato contrato)
        {
            this.contrato = contrato;
            empleado.Contrato = contrato;
        }

        /*+================================================================+
         *|                  Calcular Asistencia                           |
         *+================================================================+*/
        public int calcularAsistencia()
        {
            /*var asistenciaEmpleado = db.empleados
                .Include(emple => emple.AsistenciaEmpleados)
                .Include(emple => emple.Rubros)
                    .ThenInclude(rubro => rubro.Rol_Pagos)
                .Single(emple => emple.EmpleadoId == empleado.EmpleadoId);*/

            
                DateTime fechaInicio = empleado.AsistenciaEmpleados.Hora_Inicio;
                DateTime fechaFin = empleado.AsistenciaEmpleados.Hora_Fin;
                var numeroDias = (fechaFin - fechaInicio).Days;

            return numeroDias;
                        
        }

        /*+================================================================+
         *|                  Calcular el Numero de Horas                   |
         *+================================================================+*/
        public int calcularNumeroHoras()
        {
            /*var horasEmpleado = db.empleados
                .Include(emple => emple.AsistenciaEmpleados)
                .Include(emple => emple.Rubros)
                    .ThenInclude(rubro => rubro.Rol_Pagos)
                .Single(emple => emple.EmpleadoId == empleado.EmpleadoId);

            var numeroHoras = 0;

            foreach (var numerosHoras in empleado.AsistenciaEmpleados.Lista_Empleados)
            {
                DateTime horaInicio = numerosHoras.AsistenciaEmpleados.Hora_Inicio;
                DateTime horaFin = empleado.AsistenciaEmpleados.Hora_Fin;

                numeroHoras = (horaFin - horaInicio).Hours;
            }*/

            var numeroHorasInicio = empleado.AsistenciaEmpleados.Hora_Inicio;
            var numeroHorasFin = empleado.AsistenciaEmpleados.Hora_Fin;

            var numeroHoras = (numeroHorasFin - numeroHorasInicio).Hours;

            return numeroHoras;
        }

        /*+================================================================+
         *|                  Calcular las Horas Extras                     |
         *+================================================================+*/
        public int calcularHorasExtras()
        {
            var numeroHoras = calcularNumeroHoras();
            var horasExtras = numeroHoras - 8;
            return horasExtras;
        }

        /*+================================================================+
         *|                Calcular el Valor de la Hora                    |
         *+================================================================+*/
        public double valorHora()
        {
            /*var sueldoEmpleado = db.empleados
                .Include(emple => emple.Contrato)
                .Include(emple => emple.Rubros)
                    .ThenInclude(rubro => rubro.Rol_Pagos)
                .Single(emple => emple.EmpleadoId == empleado.EmpleadoId);

            double sueldoHora = 0;

            foreach (var salario in empleado.Contrato.Empleados)
            {
                var sueldo = salario.Contrato.Sueldo_Contrato;
                sueldoHora = ((double)((sueldo / 30) / 8));
            }*/

            var sueldoEmpleado = empleado.sueldo;
            var sueldoHora = ((double)((sueldoEmpleado / 30) / 8));

            return (double)sueldoHora;
        }

        /*+================================================================+
         *|             Calcular el Decimo Tercer Sueldo                   |
         *+================================================================+*/
        public double calcularDecimoTercer()
        {
            /*var decimoTercerSueldoEmpleado = db.empleados
                .Include(emple => emple.Contrato)
                .Include(emple => emple.Rubros)
                    .ThenInclude(rubro => rubro.Rol_Pagos)
                .Where(emple => emple.EmpleadoId == empleado.EmpleadoId);

            var horasExtras = calcularHorasExtras();
            double decimoTercerSueldo = 0;

            foreach (var decimoTercero in empleado.Contrato.Empleados)
            {
                var sueldo = decimoTercero.Contrato.Sueldo_Contrato;

                horasExtras = (int)(valorHora() * (double)1.25);
                var sueldoAcumulado = (sueldo + horasExtras) * 12;
                decimoTercerSueldo = (double)(sueldoAcumulado / 12);
            }*/


            var horasExtras = calcularHorasExtras();
            var sueldoAcumulado = (double)(empleado.sueldo + horasExtras) * 12;
            var decimoTercerSueldo = (double)(sueldoAcumulado / 12); 

            return decimoTercerSueldo;
        }

        public double calcularDecimoCuarto()
        {
            /*var decimoCuartoSueldoEmpleado = db.empleados
                .Include(emple => emple.Contrato)
                .Include(emple => emple.Rubros)
                    .ThenInclude(rubro => rubro.Rol_Pagos)
                .Single(emple => emple.EmpleadoId == empleado.EmpleadoId);

            double decimoCuartoSueldo = 0;

            foreach (var decimoCuarto in empleado.Contrato.Empleados)
            {
                var sueldo = decimoCuarto.Contrato.Sueldo_Contrato;
                decimoCuartoSueldo = (double)(sueldo / 365);
            }*/
            var sueldo = empleado.sueldo;
            var decimoCuartoSueldo = (double)(sueldo / 365);
            var decimoCuartoSueldoAcumulado = decimoCuartoSueldo * 30;

            return (double)decimoCuartoSueldoAcumulado;
        }

        /*+================================================================+
         *|                  Calcular Aportacion al IESS                   |
         *+================================================================+*/
        public double calcularAportacionIESS()
        {
            /*var aportacionIESSEmpleado = db.empleados
                .Include(emple => emple.Contrato)
                .Include(emple => emple.Rubros)
                    .ThenInclude(rubro => rubro.Rol_Pagos)
                .Single(emple => emple.EmpleadoId == empleado.EmpleadoId);

            double aportacionesIESS = 0;

            foreach (var aportacionIEES in empleado.Contrato.Empleados)
            {
                var sueldo = aportacionIEES.Contrato.Sueldo_Contrato;
                aportacionesIESS = ((double)sueldo * 9.45) / 100;
            }
            */
            var sueldo = empleado.sueldo;
            var aportacionesIESS = ((double)sueldo * 9.45) / 100;

            return (double)aportacionesIESS;
        }


        /*+================================================================+
         *|                  Calcular Quincena                             |
         *+================================================================+*/
        public double calcularQuincena()
        {
            /*var quincenaEmpleado = db.empleados
                .Include(emple => emple.Contrato)
                .Include(emple => emple.Rubros)
                    .ThenInclude(rubro => rubro.Rol_Pagos)
                .Single(emple => emple.EmpleadoId == empleado.EmpleadoId);

            double quincena = 0;

            foreach (var quin in empleado.Contrato.Empleados)
            {
                var sueldo = quin.Contrato.Sueldo_Contrato;
                quincena = (double)sueldo * 0.3;
            }*/

            var sueldo = empleado.sueldo;
            var quincena = (double)sueldo * 0.3;

            return quincena;
        }

        /*+================================================================+
         *|                  Calcular Sueldo                               |
         *+================================================================+*/
        public double salarioMensual()
        {
            /*var salarioMensualEmpleado = db.empleados
                .Include(emple => emple.Contrato)
                .Include(emple => emple.Rubros)
                    .ThenInclude(rubro => rubro.Rol_Pagos)
                .Single(emple => emple.EmpleadoId == empleado.EmpleadoId);*/

            var decimoTerceraRemuneracion = calcularDecimoTercer();
            var decimoCuartaRemuneracion = calcularDecimoCuarto();
            var quincena = calcularQuincena();
            var aporteIESS = calcularAportacionIESS();
            //double salario = 0;

            /*foreach (var salarioMensual in salarioMensualEmpleado.Contrato.Empleados)
            {
                var sueldoMensual = salarioMensual.Contrato.Sueldo_Contrato;
                var ingresos = (double)sueldoMensual + decimoTerceraRemuneracion + decimoCuartaRemuneracion;
                var egresos = quincena + aporteIESS;
                salario = ingresos - egresos;
            }*/

            var sueldoMensual = empleado.sueldo;
            var ingresos = (double)sueldoMensual + decimoTerceraRemuneracion + decimoCuartaRemuneracion;
            var egresos = quincena + aporteIESS;
            var salario = ingresos - egresos;

            return (double)salario;

        }
    }
}
