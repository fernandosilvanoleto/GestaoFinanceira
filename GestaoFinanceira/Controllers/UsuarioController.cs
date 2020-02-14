using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestaoFinanceira.Models;
using Microsoft.AspNetCore.Mvc;

namespace GestaoFinanceira.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ValidarLogin(UsuarioModel usuario)
        {
            bool login = usuario.ValidarLogin();
            if (login)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                TempData["MensagemLoginInvalidoController"] = "Dados de Login Inválidos. Por favor, corrigir!";
                return RedirectToAction("Login");
            }
        }
    }
}