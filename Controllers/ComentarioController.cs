using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PontoDigitalMVC.Models;
using PontoDigitalMVC.Repositories;

namespace PontoDigitalMVC.Controllers 
{
    public class ComentarioController : Controller 
    {
        private const string SESSION_CLIENTE = "_ClIENTE";

        ComentarioRepositorio comentarioRepositorio = new ComentarioRepositorio ();
        UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();

        public IActionResult Index () 
        {
            return View ();
        }

        public IActionResult Comentar (IFormCollection form) 
        {
            ComentarioModel comentario = new ComentarioModel ();
            comentario.Usuario = new UsuarioModel();
            
            comentario.Usuario.Nome = HttpContext.Session.GetString(SESSION_CLIENTE);
            comentario.Texto = form["comentario"];

            comentarioRepositorio.InserirComentario (comentario);

            return RedirectToAction ("Index", "Home");
        }

    }
}