using Microsoft.EntityFrameworkCore;
using Modelo.Entidades;
using System;
using System.Collections.Generic;

namespace SGRP
{
    internal class Program
    {
        public static object SGRPDB { get; private set; }
        static void Main(string[] args)
        {
            Grabar grabar = new Grabar();
            
            grabar.DatosIniciales();
            
            using (var db = SGRPDBBuilder.Crear())
            {
                var listaEmpleados = db.empleados
                    .Include(empleado => empleado.Contrato)
                        .ThenInclude(contrato => contrato.Tipos_Contratos)
                    .Include(empleado => empleado.Contrato)
                        .ThenInclude(cont => cont.Cargos)
                            .ThenInclude(contrato => contrato.Departamentos) //Observacion
                    .Include(empleado => empleado.Permiso)
                        .ThenInclude(permiso => permiso.Tipo_Permisos)
                    .Include(empleado => empleado.AsistenciaEmpleados);

                Console.WriteLine("+====================================================+\n" +
                                  "|\t           Lista de Empleados\t                   |\n" +
                                  "+====================================================+");

                foreach (var empleado in listaEmpleados)
                {
                    Console.WriteLine(
                        empleado.EmpleadoId + " \n" +
                        empleado.Nombres_Empleado + " " + empleado.Apellidos_Empleado + " \n" +
                        empleado.AsistenciaEmpleados.Tipo_Asistencia
                        );

                    /*foreach (var contrato in empleado.Contrato)
                    {
                        Console.WriteLine(
                        
                        );
                    }*/
                }
            }
        }
    }
}
