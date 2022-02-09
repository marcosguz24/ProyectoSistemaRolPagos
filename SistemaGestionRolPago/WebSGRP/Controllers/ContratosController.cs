using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Modelo.Entidades;
using ModeloDB;
using System.Collections.Generic;
using System.Linq;

namespace WebSGRP.Controllers
{
    public class ContratosController : Controller
    {
        private readonly SGRPDB db;
        public ContratosController(SGRPDB db)
        {
            this.db = db;
        }

        //Recuperacion de los contratos y enviar hacia la vista
        public IActionResult Index()
        {
            IEnumerable<Contrato> listaContrato =
                db.contratos
                .Include(Contrato => Contrato.Tipos_Contratos)
                .Include(contarto => contarto.Cargos)
                    .ThenInclude(Cargo => Cargo.Departamentos);
            return View(listaContrato);
        }

        /*==========================================================
         *              Creacion de una nueva Contrato
         *  ----------- Enviar a un formulario vacio -----------
         *==========================================================*/
        [HttpGet]
        IActionResult Create()
        {
            var listaTipoContratos = db.tiposContratos
                .Select(tipoContrato => new
                {
                    TipoContratoId = tipoContrato.TipoContratoId,
                    NombreTipoContrato = tipoContrato.Nombre_Tipo_Contrato,
                    DescripcionTipoContrato = tipoContrato.Descripcion_Tipo_Contrato
                }).ToList();

            var listaCargos = db.cargos
                .Select(cargo => new
                {
                    CargoId = cargo.CargoId,
                    NombreCargo = cargo.Nombre_Cargo
                }).ToList();

            var listaDepartamentos = db.departamentos
                .Select(departamento => new
                {
                    DepartamentoId = departamento.DepartamentoId,
                    NombreDepartamento = departamento.Nombre_Departamento
                }).ToList();

            var selectListaTipoContrato = new SelectList(listaTipoContratos, "TipoContratoId", "NombreTipoContrato", "DescripcionTipoContrato");
            var selectListaCargos = new SelectList(listaCargos, "CargoId", "NombreCargo");
            var selectListaDepartamentos = new SelectList(listaDepartamentos, "DepartamentoId", "NombreDepartamento");

            ViewBag.selectListaTipoContrato = selectListaTipoContrato;
            ViewBag.selectListaCargos = selectListaCargos;
            ViewBag.selectListaDepartamentos = selectListaDepartamentos;

            return View();
        }

        [HttpPost]
        public IActionResult Create(Contrato contrato)
        {
            db.contratos.Add(contrato);
            db.SaveChanges();
            TempData["mensaje"] = $"El contrato {contrato.Tipos_Contratos.Nombre_Tipo_Contrato} ha sido creado exitositosamente.";
            return RedirectToAction("Index");
        }

        /*======================================================================================
         *                      Edicion de un Contrato
         *  --- Enviar a un formulario con los datos del Contrato Seleccionado a acutalizar ---
         *======================================================================================*/
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Contrato contrato = db.contratos.Find(id);
            return View(contrato);
        }

        [HttpPost]
        public IActionResult Edit(Contrato contrato)
        {
            db.contratos.Update(contrato);
            db.SaveChanges();
            TempData["mensaje"] = $"El contrato {contrato.Tipos_Contratos.Nombre_Tipo_Contrato} ha sido actualizado exitositosamente.";
            return RedirectToAction("Index");
        }

        /*=====================================================================================
         *                      Eliminacion de un Contrato
         *  ---Enviar a un formulario con los datos del Contrato Seleccionado a eliminar ---
         *=====================================================================================*/
        [HttpGet]
        public IActionResult Delete(int id)
        {
            Contrato contrato = db.contratos.Find(id);
            return View(contrato);
        }

        [HttpPost]
        public IActionResult Delete(Contrato contrato)
        {
            db.contratos.Remove(contrato);
            db.SaveChanges();
            TempData["mensaje"] = "El contrato ha sido eliminado exitositosamente.";
            return RedirectToAction("Index");
        }
    }
}
