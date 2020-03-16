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
    }
}