using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestaoFinanceira.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GestaoFinanceira.Controllers
{
    public class TransacaoController : Controller
    {
        IHttpContextAccessor httpContextAccessorController;

        public TransacaoController(IHttpContextAccessor httpContextAccessor)
        {
            httpContextAccessorController = httpContextAccessor;
        }

        public IActionResult Index()
        {
            TransacaoModel objTransacao = new TransacaoModel(httpContextAccessorController);
            ViewBag.ListaTransacaoController = objTransacao.ListaTransacaoModel();
            return View();
        }

        public IActionResult CriarTransacao()
        {
            ViewBag.ListaContas = new ContaModel(httpContextAccessorController).ListaContaModel();
            ViewBag.ListaPlanoContas = new PlanoContaModel(httpContextAccessorController).ListaPlanoContaModel();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CriarTransacao(TransacaoModel formulario)
        {
            if (ModelState.IsValid)
            {
                formulario.httpContextAccessorModel = httpContextAccessorController;
                formulario.Inserir();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        public IActionResult Extrato()
        {
            return View();
        }

        public IActionResult Dashboard()
        {
            return View();
        }
    }
}