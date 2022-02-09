using CargaDatos;
using Modelo.Entidades;
using ModeloDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CargaDatos.DatosIniciales;

namespace SGRP
{
    public class Grabar
    {
        public void DatosIniciales()
        {
            DatosIniciales datosIniciales = new DatosIniciales();
            var listas = datosIniciales.Carga();

            /*=============================================================================================
             *                              Extraer del diccionario las listas
             *=============================================================================================*/
            var listaAsistencia         =                   (List<Asistencia>)listas[ListasTipo.Asistencias];
            var listaCargo              =                   (List<Cargo>)listas[ListasTipo.Cargos];
            var listaContrato           =                   (List<Contrato>)listas[ListasTipo.Contratos];
            var listaCiudad             =                   (List<Ciudad>)listas[ListasTipo.Ciudades];
            var listaDepartamento       =                   (List<Departamento>)listas[ListasTipo.Departamentos];
            var listaJornadaTrabajo     =                   (List<JornadaTrabajo>)listas[ListasTipo.JornadaTrabajos];
            var listaPermiso            =                   (List<Permiso>)listas[ListasTipo.Permisos];
            var listaRegion             =                   (List<Region>)listas[ListasTipo.Regiones];
            var listaRolPago            =                   (List<RolPago>)listas[ListasTipo.RolPagos];
            var listaEmpleado           =                   (List<Empleado>)listas[ListasTipo.Empleados];
            var listaRubro              =                   (List<Rubro>)listas[ListasTipo.Rubros];
            var listaTipoContrato       =                   (List<TipoContrato>)listas[ListasTipo.TipoContratos];
            var listaTipoPermiso        =                   (List<TipoPermiso>)listas[ListasTipo.TipoPermisos];

            /*============================================================
             *                            Grabar
             *============================================================*/
            using (SGRPDB db = SGRPDBBuilder.Crear())
            {
                // Se asegura que se borre y vuelva a crear la base de datos
                db.PeprararDB();

                //Se agrega los listados
                db.asistencias.AddRange(listaAsistencia);
                db.cargos.AddRange(listaCargo);
                db.contratos.AddRange(listaContrato);
                db.ciudades.AddRange(listaCiudad);
                db.departamentos.AddRange(listaDepartamento);
                db.jornadasTrabajos.AddRange(listaJornadaTrabajo);
                db.permisos.AddRange(listaPermiso);
                db.regiones.AddRange(listaRegion);
                db.rolPagos.AddRange(listaRolPago);
                db.rubros.AddRange(listaRubro);
                db.empleados.AddRange(listaEmpleado);
                db.tiposContratos.AddRange(listaTipoContrato);
                db.tiposPermisos.AddRange(listaTipoPermiso);

                db.SaveChanges();
            
            }
            
        }
    }
}
