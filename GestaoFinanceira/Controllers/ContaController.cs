﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestaoFinanceira.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GestaoFinanceira.Controllers
{
    public class ContaController : Controller
    {
        IHttpContextAccessor httpContextAccessorController;

        public ContaController(IHttpContextAccessor httpContextAccessor)
        {
            httpContextAccessorController = httpContextAccessor;
        }

        public IActionResult Index()
        {
            ContaModel contaController = new ContaModel(httpContextAccessorController);
            ViewBag.ListaContaController = contaController.ListaContaModel();
            return View();
        }

        [HttpPost]
        public IActionResult CriarConta(ContaModel formulario)
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
        public IActionResult CriarConta()
        {
            return View();
        }

       public IActionResult ExcluirConta(int id)
        {
            ContaModel contaController = new ContaModel(httpContextAccessorController);
            contaController.ExcluirContaModel(id);
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