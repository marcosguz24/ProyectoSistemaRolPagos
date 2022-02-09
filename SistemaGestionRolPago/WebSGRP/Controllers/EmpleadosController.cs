using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Modelo.Entidades;
using ModeloDB;
using System.Collections.Generic;
using System.Linq;

namespace WebSGRP.Controllers
{
    public class EmpleadosController : Controller
    {
        private readonly SGRPDB db;
        public EmpleadosController(SGRPDB db)
        {
            this.db = db;
        }

        //Recuperacion de los Departamentos y enviar hacia la vista
        public IActionResult Index()
        {
            IEnumerable<Empleado> listaEmpleados = db.empleados
                .Include(empleado => empleado.Contrato)
                    .ThenInclude(contrato => contrato.Cargos)
                .Include(empleado => empleado.Nombre_Ciudad)
                .Include(empleado => empleado.Permiso)
                .Include(empleado => empleado.Rubros)
                .Include(empleado => empleado.AsistenciaEmpleados);

            return View(listaEmpleados);
        }

        /*==========================================================
         *              Creacion de un nuevo Empleado
         *  ----------- Enviar a un formulario vacio -----------
         *==========================================================*/
        [HttpGet]
        public IActionResult Create()
        {
            var listaContratos = db.contratos
                .Select(contrato => new
                {
                    ContratoId = contrato.ContratoId,
                    Tipo_Contrato = contrato.Tipos_Contratos.Nombre_Tipo_Contrato
                }).ToList();

            var listaCiudad = db.ciudades
                .Select(ciudad => new
                {
                    CiudadId = ciudad.CiudadId,
                    NombreCiudad = ciudad.Nombre_Ciudad
                }).ToList();

            var listaPermisos = db.permisos
                .Select(permisos => new
                {
                    PermisosId = permisos.PermisoId,
                    Tipo_Permiso = permisos.Nombre_Permiso
                }).ToList();

            var listaRubros = db.rubros
                .Select(rubro => new
                {
                    RubrosId = rubro.RubroId,
                    NombreRubro = rubro.Nombre_Rubro
                }).ToList();
            
            var listaAsistencia = db.asistencias
                .Select(asistencia => new
                {
                    AsistenciasId = asistencia.AsistenciaId,
                    TipoAsistencia = asistencia.Tipo_Asistencia
                }).ToList();

            var selectListaContratos = new SelectList(listaContratos, "ContratoId", "Tipos_Contratos");
            var selectListaCiudad = new SelectList(listaCiudad, "CiudadId", "NombreCiudad");
            var selectListaPermisos = new SelectList(listaPermisos, "PermisosId", "Tipo_Permiso");
            var selectListaRubro = new SelectList(listaRubros, "RubroId", "NombreRubro");
            var selectListaAsistencia = new SelectList(listaAsistencia, "AsistenciasId", "TipoAsistencia");

            ViewBag.selectListaContratos = selectListaContratos;
            ViewBag.selectListaCiudades = selectListaCiudad;
            ViewBag.selectListaPermisos = selectListaPermisos;
            ViewBag.selectListaRubros = selectListaRubro;
            ViewBag.selectListaAsistencias = selectListaAsistencia;

            return View();
        }

        [HttpPost]
        public IActionResult Create(Empleado empleado)
        {
            db.empleados.Add(empleado);
            db.SaveChanges();
            TempData["mensaje"] = $"El Departamento {empleado.Nombres_Empleado + empleado.Apellidos_Empleado} ha sido creado exitositosamente.";
            return RedirectToAction("Index");
        }

        /*======================================================================================
         *                      Edicion de un Empleado
         *---Enviar a un formulario con los datos del Empleado Seleccionado a acutalizar ---
         *======================================================================================*/
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Empleado empleado = db.empleados.Find(id);
            return View(empleado);
        }

        [HttpPost]
        public IActionResult Edit(Empleado empleado)
        {
            db.empleados.Update(empleado);
            db.SaveChanges();
            TempData["mensaje"] = $"El Departamento {empleado.Nombres_Empleado + empleado.Apellidos_Empleado} ha sido actualizado exitositosamente.";
            return RedirectToAction("Index");
        }

        /*=====================================================================================
         *                      Eliminacion de un Empleado
         *---Enviar a un formulario con los datos del Empleado Seleccionado a eliminar ---
         *=====================================================================================*/
        [HttpGet]
        public IActionResult Delete(int id)
        {
            Empleado empleado = db.empleados.Find(id);
            return View(empleado);
        }

        [HttpPost]
        public IActionResult Delete(Empleado empleado)
        {
            db.empleados.Remove(empleado);
            db.SaveChanges();
            TempData["mensaje"] = "El Empleado ha sido eliminado exitositosamente.";
            return RedirectToAction("Index");
        }
    }
}
