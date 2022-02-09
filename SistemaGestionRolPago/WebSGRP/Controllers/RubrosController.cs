using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Modelo.Entidades;
using ModeloDB;
using System.Collections.Generic;
using System.Linq;

namespace WebSGRP.Controllers
{
    public class RubrosController : Controller
    {
        private readonly SGRPDB db;
        public RubrosController(SGRPDB db)
        {
            this.db = db;
        }

        //Recuperacion de los rubros y enviar hacia la vista
        public IActionResult Index()
        {
            IEnumerable<Rubro> listaRubros = 
                db.rubros
                .Include(rubro => rubro.Rol_Pagos);

            return View(listaRubros);
        }

        /*==========================================================
         *              Creacion de un nuevo Rubro
         *  ----------- Enviar a un formulario vacio -----------
         *==========================================================*/
        [HttpGet]
        IActionResult Create()
        {
            var listaRolPago = db.rolPagos
                .Select(rolPago => new
                {
                    RolPagoId = rolPago.RolPagoId,
                    Descripcion = rolPago.Descripcion_RolPagos
                }).ToList();


            var selectlistaRolPago = new SelectList(listaRolPago, "RolPagoId", "Descripcion");

            ViewBag.selectlistaRolPago = selectlistaRolPago;

            return View();
        }

        [HttpPost]
        public IActionResult Create(Rubro rubro)
        {
            db.rubros.Add(rubro);
            db.SaveChanges();
            TempData["mensaje"] = $"El rubro {rubro.Nombre_Rubro} ha sido creado exitositosamente.";
            return RedirectToAction("Index");
        }

        /*======================================================================================
         *                      Edicion de un Rubro
         *  --- Enviar a un formulario con los datos del Rubro Seleccionado a acutalizar ---
         *======================================================================================*/
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Rubro rubro = db.rubros.Find(id);
            return View(rubro);
        }

        [HttpPost]
        public IActionResult Edit(Rubro rubro)
        {
            db.rubros.Update(rubro);
            db.SaveChanges();
            TempData["mensaje"] = $"El rubro {rubro.Nombre_Rubro} ha sido actualizado exitositosamente.";
            return RedirectToAction("Index");
        }

        /*=====================================================================================
         *                      Eliminacion de un Rubro
         *  ---Enviar a un formulario con los datos del Rubro Seleccionado a eliminar ---
         *=====================================================================================*/
        [HttpGet]
        public IActionResult Delete(int id)
        {
            Rubro rubro = db.rubros.Find(id);
            return View(rubro);
        }

        [HttpPost]
        public IActionResult Delete(Rubro rubro)
        {
            db.rubros.Remove(rubro);
            db.SaveChanges();
            TempData["mensaje"] = "El rubro ha sido eliminado exitositosamente.";
            return RedirectToAction("Index");
        }
    }
}
