using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PontoDigitalMVC.Models;
using PontoDigitalMVC.Repositories;

namespace PontoDigitalMVC.Controllers
{
    public class CadastroController : Controller
    {
        UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();

        [HttpGet]
        public IActionResult Index()
        {
            ViewData["NomeView"] = "Cadastro";
            return View();
        }

        [HttpPost]
        public IActionResult CadastrarUsuario(IFormCollection form)
        {
            UsuarioModel usuario = new UsuarioModel();
            usuario.Nome = form["nome"];
            usuario.Email = form["email"];
            usuario.Senha = form["senha"];
            usuario.DataNascimento = DateTime.Parse(form["data-nascimento"]);

            usuarioRepositorio.InserirUsuario(usuario);

            ViewData["Action"] = "Cadastro";
            return RedirectToAction("Index", "Home");
        }
    }
}