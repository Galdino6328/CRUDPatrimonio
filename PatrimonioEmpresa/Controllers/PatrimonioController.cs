using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PatrimonioEmpresa.Models.Contexto;
using PatrimonioEmpresa.Models.Entidades;

namespace PatrimonioEmpresa.Controllers
{
    public class PatrimonioController : Controller
    {
        private readonly ContextoPatrimonio _contexto;

        public PatrimonioController(ContextoPatrimonio contexto)
        {
            _contexto = contexto;
        }

        public IActionResult Index()
        {
            var lista = _contexto.Patrimonio.ToList();
            CarregaTipoPatrimonio();
            return View(lista);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var patrimonio = new Patrimonio();
            CarregaTipoPatrimonio();
            return View(patrimonio);
        }

        [HttpPost]
        public IActionResult Create(Patrimonio patrimonio)
        {
            if (ModelState.IsValid)
            {
                _contexto.Patrimonio.Add(patrimonio);
                _contexto.SaveChanges();

                return RedirectToAction("Index");
            }

            CarregaTipoPatrimonio();
            return View(patrimonio);
        }

        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var patrimonio = _contexto.Patrimonio.Find(Id);

            CarregaTipoPatrimonio();
            return View(patrimonio);
        }

        [HttpPost]
        public IActionResult Edit(Patrimonio patrimonio)
        {
            if (ModelState.IsValid)
            {
                _contexto.Patrimonio.Update(patrimonio);
                _contexto.SaveChanges();

                return RedirectToAction("Index");
            }
            else
            {
                CarregaTipoPatrimonio();
                return View(patrimonio);
            }
        }

        [HttpGet]
        public IActionResult Delete(int Id)
        {
            var patrimonio = _contexto.Patrimonio.Find(Id);
            CarregaTipoPatrimonio();
            return View(patrimonio);
        }

        [HttpPost]
        public IActionResult Delete(Patrimonio _patrimonio)
        {
            var patrimonio = _contexto.Patrimonio.Find(_patrimonio.Id);
            if (patrimonio != null)
            {
                _contexto.Patrimonio.Remove(patrimonio);
                _contexto.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(patrimonio);
        }

        [HttpGet]
        public IActionResult Details(int Id)
        {
            var patrimonio = _contexto.Patrimonio.Find(Id);
            CarregaTipoPatrimonio();
            return View(patrimonio);
        }

        /// <summary>
        /// 
        /// </summary>
        public void CarregaTipoPatrimonio()
        {
            var ItensTipoPatrimonio = new List<SelectListItem>
            {
                new SelectListItem{ Value ="1", Text ="Fisicos"},
                new SelectListItem{ Value ="2", Text ="Não Fisicos"},
                new SelectListItem{ Value ="3", Text ="Abstratos"}
            };

            ViewBag.TiposPatrimonio = ItensTipoPatrimonio;
        }

    }

}