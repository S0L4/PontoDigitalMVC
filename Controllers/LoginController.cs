using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PontoDigitalMVC.Models;
using PontoDigitalMVC.Repositories;

namespace PontoDigitalMVC.Controllers
{
    public class LoginController : Controller
    {
        UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();

        [HttpGet]
        public IActionResult Index()
        {
            ViewData["NomeView"] = "Login";
            return View();
        }

        [HttpPost]
        public IActionResult ListarUsuario(IFormCollection form)
        {
            var usario = form["email"];
            var senha = form["senha"];

            return RedirectToAction("Index", "Home");
        }
    }
}