using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Modelo.Entidades;
using ModeloDB;
using System.Collections.Generic;
using System.Linq;

namespace WebSGRP.Controllers
{
    public class RolPagosController : Controller
    {
        private readonly SGRPDB db;
        public RolPagosController(SGRPDB db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<RolPago> listaRolPagos = db.rolPagos
                .Include(rol => rol.Rubros)
                    .ThenInclude(rubro => rubro.Empleados);
            return View(listaRolPagos);
        }

        /*==========================================================
         *             Creacion de un nuevo Rol Pago
         *  ----------- Enviar a un formulario vacio -----------
         *==========================================================*/
        [HttpGet]
        public IActionResult Create()
        {
            var listaRubro = db.rubros
                .Select(rubro => new
                {
                    RubroId = rubro.RubroId,
                    Rubro = rubro.Nombre_Rubro
                }).ToList();

            var selectListaRubro = new SelectList(listaRubro, "RubroId", "Rubro");

            ViewBag.selectListaRubro = selectListaRubro;

            return View();
        }

        [HttpPost]
        public IActionResult Create(RolPago rolPago)
        {
            db.rolPagos.Add(rolPago);
            db.SaveChanges();
            TempData["mensaje"] = $"El Rol de Pago {rolPago.Rubros.Nombre_Rubro} ha sido creado exitositosamente.";
            return RedirectToAction("Index");
        }

        /*======================================================================================
         *                      Edicion de un Rol de Pago
         *---Enviar a un formulario con los datos del Rol de Pago Seleccionado a acutalizar ---
         *======================================================================================*/
        [HttpGet]
        public IActionResult Edit(int id)
        {
            RolPago rolPago = db.rolPagos.Find(id);
            return View(rolPago);
        }

        [HttpPost]
        public IActionResult Edit(RolPago rolPago)
        {
            db.rolPagos.Update(rolPago);
            db.SaveChanges();
            TempData["mensaje"] = $"El Rol de Pago {rolPago.Rubros.Nombre_Rubro} ha sido actualizado exitositosamente.";
            return RedirectToAction("Index");
        }

        /*=====================================================================================
         *                      Eliminacion de un Rol de Pago
         *---Enviar a un formulario con los datos del Rol de Pago Seleccionado a eliminar ---
         *=====================================================================================*/
        [HttpGet]
        public IActionResult Delete(int id)
        {
            RolPago rolPago = db.rolPagos.Find(id);
            return View(rolPago);
        }

        [HttpPost]
        public IActionResult Delete(RolPago rolPago)
        {
            db.rolPagos.Remove(rolPago);
            db.SaveChanges();
            TempData["mensaje"] = "El Rol de Pago ha sido eliminado exitositosamente.";
            return RedirectToAction("Index");
        }
    }
}
