using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestaoFinanceira.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GestaoFinanceira.Controllers
{
    public class PlanoContaController : Controller
    {
        IHttpContextAccessor httpContextAccessorController;

        public PlanoContaController(IHttpContextAccessor httpContextAccessor)
        {
            httpContextAccessorController = httpContextAccessor;
        }

        public IActionResult Index()
        {
            PlanoContaModel objPlanoContas = new PlanoContaModel(httpContextAccessorController);
            ViewBag.ListaPlanoContasController = objPlanoContas.ListaPlanoContaModel();
            return View();
        }

        [HttpPost]
        public IActionResult CriarPlanoConta(PlanoContaModel formulario)
        {
            if (ModelState.IsValid)
            {
                formulario.httpContextAccessorModel = httpContextAccessorController;
                formulario.Insert();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        [HttpGet]
        public IActionResult CriarPlanoConta()
        {
            return View();
        }

        public IActionResult ExcluirConta(int id)
        {
            PlanoContaModel contaController = new PlanoContaModel(httpContextAccessorController);
            contaController.ExcluirPlanoContaModel(id);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult EditarConta(int id)
        {
            if (id != 0)
            {
                ContaModel contaController = new ContaModel(httpContextAccessorController);
                ViewBag.ContaEspecifica = contaController.ListaContaEspecifica(id);
                return View();
            }
            else
            {
                return RedirectToAction(nameof(Index));
            }
        }

        [HttpPost]
        public IActionResult EditarConta(ContaModel formulario)
        {
            if (ModelState.IsValid)
            {
                formulario.httpContextAccessorModel = httpContextAccessorController;
                formulario.Update(formulario);
            }
            return RedirectToAction(nameof(Index));
        }

    }
}