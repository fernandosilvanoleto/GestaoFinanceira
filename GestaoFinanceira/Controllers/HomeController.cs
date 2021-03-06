﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GestaoFinanceira.Models;

namespace GestaoFinanceira.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            HomeModel objHomeModelController = new HomeModel();
            string nomeModelController = objHomeModelController.LerNomeUsuarioModel();
            ViewData["NomeController"] = nomeModelController;
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Menu()
        {
            return View();
        }

        // ao se criar uma view, vc precisa referenciar no controller. Se não, não funciona a parada...
        public IActionResult Ajuda()
        {
            return View();
        }
    }
}
