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
        AdministradorRepositorio administradorRepositorio = new AdministradorRepositorio();

        private const string SESSION_EMAIL = "_EMAIL";
        private const string SESSION_CLIENTE = "_ClIENTE";
        private const string SESSION_ADM = "_ADM";
        
        public IActionResult Index()
        {
            ViewData["NomeView"] = "Login";
            return View();
        }

        [HttpPost]
        public IActionResult LogarUsuario(IFormCollection form)
        {
            var usuario = form["email"];
            var senha = form["senha"];
            
            var cliente = usuarioRepositorio.ListaDeUsuarios();
            var admin = administradorRepositorio.DadosDoAdministrador();
            
            foreach (var item in admin)
            {
                if (item.SenhaAdm.Equals(senha) && item.EmailAdm.Equals(usuario))
                {
                    HttpContext.Session.SetString(SESSION_ADM, usuario);
                    HttpContext.Session.SetString(SESSION_CLIENTE, item.NomeAdm);

                    return RedirectToAction("Index", "Administrador");
                } else {
                    continue;
                }
            }

            foreach (var item in cliente)
            {
                if (item != null && item.Senha.Equals(senha) && item.Email.Equals(usuario))
                {
                    HttpContext.Session.SetString(SESSION_EMAIL, usuario);
                    HttpContext.Session.SetString(SESSION_CLIENTE, item.Nome);
                }
            }
            ViewData["NomeView"] = "Login";
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Remove(SESSION_EMAIL);
            HttpContext.Session.Remove(SESSION_CLIENTE);
            HttpContext.Session.Clear();

            return RedirectToAction("Index", "Home");
        }
    }
}