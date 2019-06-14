using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PatrimonioEmpresa.Models.Contexto;
using PatrimonioEmpresa.Models.Entidades;

namespace PatrimonioEmpresa.Controllers
{
    public class MarcaController : Controller
    {
        private readonly ContextoMarca _contextoM;

        public MarcaController(ContextoMarca contextoM)
        {
            _contextoM = contextoM;
        }

        public IActionResult Index()
        {
            var lista = _contextoM.Marca.ToList();
            return View(lista);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var marca = new Marca();
            return View(marca);
        }

        [HttpPost]
        public IActionResult Create(Marca marca)
        {
            if (ModelState.IsValid)
            {
                _contextoM.Marca.Add(marca);
                _contextoM.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(marca);
        }

        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var marca = _contextoM.Marca.Find(Id);
            return View(marca);
        }

        [HttpPost]
        public IActionResult Edit(Marca marca)
        {
            if (ModelState.IsValid)
            {
                _contextoM.Marca.Update(marca);
                _contextoM.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(marca);
            }
        }

        [HttpGet]
        public IActionResult Delete(int Id)
        {
            var marca = _contextoM.Marca.Find(Id);
            return View(marca);
        }

        [HttpPost]
        public IActionResult Delete(Marca marca)
        {
            if (marca != null)
            {
                _contextoM.Marca.Remove(marca);
                _contextoM.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(marca);
        }

        [HttpGet]
        public IActionResult Details(int Id)
        {
            var marca = _contextoM.Marca.Find(Id);
            return View(marca);
        }
    }
}