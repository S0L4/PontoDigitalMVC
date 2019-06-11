using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PontoDigitalMVC.Models;
using PontoDigitalMVC.Repositories;

namespace PontoDigitalMVC.Controllers 
{
    public class ComentarioController : Controller 
    {
        ComentarioRepositorio comentarioRepositorio = new ComentarioRepositorio ();

        public IActionResult Index () 
        {
            return View ();
        }

        public IActionResult Comentar (IFormCollection form) 
        {
            ComentarioModel comentario = new ComentarioModel ();
            UsuarioModel usuario = new UsuarioModel();
            usuario.Nome = form["nome"];

            comentario.Texto = form["comentario"];

            comentarioRepositorio.InserirComentario (comentario);

            ViewData["Action"] = "Comentario";
            return RedirectToAction ("Index", "Home");
        }

    }
}