using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestaoFinanceira.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GestaoFinanceira.Controllers
{
    public class UsuarioController : Controller
    {
        [HttpGet]
        public IActionResult Login(int? id)
        {
            if (id != null)
            {
                HttpContext.Session.SetString("IdUsuarioLogado", string.Empty); //sair da sessão de login
                HttpContext.Session.SetString("NomeUsuarioLogado", string.Empty); //sair da sessão de login
            }
            return View();
        }

        [HttpPost]
        public IActionResult ValidarLogin(UsuarioModel usuario)
        {
            bool login = usuario.ValidarLogin();
            if (login)
            {
                HttpContext.Session.SetString("NomeUsuarioLogado", usuario.Nome); //entrar na sessão de login
                HttpContext.Session.SetString("IdUsuarioLogado", usuario.Id.ToString()); //entrar na sessão de login
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