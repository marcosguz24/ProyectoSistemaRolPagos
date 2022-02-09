using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Modelo.Entidades;
using ModeloDB;
using System.Collections.Generic;
using System.Linq;

namespace WebSGRP.Controllers
{
    public class CiudadesController : Controller
    {
        private readonly SGRPDB db;

        public CiudadesController(SGRPDB db)
        {
            this.db = db;
        }

        //Recuperacion de las Ciudades y enviar hacia la vista
        public IActionResult Index()
        {
            IEnumerable<Ciudad> listaCiudad = 
                db.ciudades
                .Include(ciudad => ciudad.Regiones);
            return View(listaCiudad);
        }

        /*==========================================================
         *              Creacion de una nueva Ciudad
         *  ----------- Enviar a un formulario vacio -----------
         *==========================================================*/
        [HttpGet]
        public IActionResult Create()
        {
            var listaRegiones = db.regiones
                .Select(region => new 
                { 
                    RegionId = region.RegionId,
                    Nombre = region.Nombre_Region
                }).ToList();

            var selectListaRegiones = new SelectList(listaRegiones, "RegionId", "Nombre");

            ViewBag.selectListaRegiones = selectListaRegiones;

            return View();
        }

        [HttpPost]
        public IActionResult Create(Ciudad ciudad)
        {
            db.ciudades.Add(ciudad);
            db.SaveChanges();
            TempData["mensaje"] = $"La ciudad {ciudad.Nombre_Ciudad} ha sido creado exitositosamente.";
            return RedirectToAction("Index");
        }

        /*======================================================================================
         *                      Edicion de una Ciudad
         *  --- Enviar a un formulario con los datos del Ciudad Seleccionado a acutalizar ---
         *======================================================================================*/
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Ciudad ciudad = db.ciudades.Find(id);
            return View(ciudad);
        }

        [HttpPost]
        public IActionResult Edit(Ciudad ciudad)
        {
            db.ciudades.Update(ciudad);
            db.SaveChanges();
            TempData["mensaje"] = $"La ciudad {ciudad.Nombre_Ciudad} ha sido actualizado exitositosamente.";
            return RedirectToAction("Index");
        }

        /*=====================================================================================
         *                      Eliminacion de una Ciudad
         *---Enviar a un formulario con los datos de la Ciudad Seleccionado a eliminar ---
         *=====================================================================================*/
        [HttpGet]
        public IActionResult Delete(int id)
        {
            Ciudad ciudad = db.ciudades.Find(id);
            return View(ciudad);
        }

        [HttpPost]
        public IActionResult Delete(Ciudad ciudad)
        {
            db.ciudades.Remove(ciudad);
            db.SaveChanges();
            TempData["mensaje"] = "La ciudad ha sido eliminado exitositosamente.";
            return RedirectToAction("Index");
        }
    }
}

