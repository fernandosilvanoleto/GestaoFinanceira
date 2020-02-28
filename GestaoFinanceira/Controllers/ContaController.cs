using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestaoFinanceira.Models;
using Microsoft.AspNetCore.Mvc;

namespace GestaoFinanceira.Controllers
{
    public class ContaController : Controller
    {
        public IActionResult Index()
        {
            ContaModel contaController = new ContaModel();
            ViewBag.ListaContaController = contaController.ListaContaModel();
            return View();
        }
    }
}