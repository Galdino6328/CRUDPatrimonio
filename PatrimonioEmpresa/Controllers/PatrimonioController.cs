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
        private readonly Contexto _contexto;

        public PatrimonioController(Contexto contexto)
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

    public class MarcaController : Controller
    {
        private readonly Contexto _contextoM;

        public MarcaController(Contexto contextoM)
        {
            _contextoM = contextoM;
        }

        public IActionResult Index()
        {
            var lista = _contextoM.Marca.ToList();
            //CarregaTipoPatrimonio();
            return View(lista);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var marca = new Marca();
            //CarregaTipoPatrimonio();
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

            //CarregaTipoPatrimonio();
            return View(marca);
        }

        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var marca = _contextoM.Marca.Find(Id);

            //CarregaTipoPatrimonio();
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
                //CarregaTipoPatrimonio();
                return View(marca);
            }
        }

        [HttpGet]
        public IActionResult Delete(int Id)
        {
            var marca = _contextoM.Marca.Find(Id);
           //CarregaTipoPatrimonio();
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
           // CarregaTipoPatrimonio();
            return View(marca);
        }

    }

}