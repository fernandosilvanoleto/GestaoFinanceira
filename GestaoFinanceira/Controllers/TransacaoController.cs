using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestaoFinanceira.Models;
using GestaoFinanceira.Util;
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

        [HttpGet]
        public IActionResult EditarTransacao(int? id)
        {
            if (id != null)
            {
                TransacaoModel transacao = new TransacaoModel(httpContextAccessorController);
                ViewBag.TransacaoEspecifica = transacao.ListaTransacaoEspecificaModel(id);
                ViewBag.ListaContas = new ContaModel(httpContextAccessorController).ListaContaModel();
                ViewBag.ListaPlanoContas = new PlanoContaModel(httpContextAccessorController).ListaPlanoContaModel();
                return View();
            }
            return View(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditarTransacao(TransacaoModel transacao)
        {
            if (ModelState.IsValid)
            {
                transacao.httpContextAccessorModel = httpContextAccessorController;
                transacao.Update(transacao);
            }
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult ExcluirTransacao(int id)
        {
            TransacaoModel obj = new TransacaoModel(httpContextAccessorController);
            ViewBag.Registro = obj.ListaTransacaoEspecificaModel(id);
            return View();
        }

        [HttpGet]
        public IActionResult Excluir(int id)
        {

            TransacaoModel obj = new TransacaoModel(httpContextAccessorController);
            obj.Excluir(id);
            return RedirectToAction(nameof(Index));
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