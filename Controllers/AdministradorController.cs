using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PontoDigitalMVC.Models;
using PontoDigitalMVC.Repositories;
using PontoDigitalMVC.ViewModel;

namespace PontoDigitalMVC.Controllers
{
    public class AdministradorController : Controller
    {
        ComentarioRepositorio comentarioRepositorio = new ComentarioRepositorio();
        UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();

        public IActionResult Index()
        {
            List<UsuarioModel> listaDeUsuarios = usuarioRepositorio.ListaDeUsuarios();
            var quantidadeDeUsuairos = listaDeUsuarios.Count();
            ViewData["quantidadeDeUsuarios"] = quantidadeDeUsuairos;

            List<ComentarioModel> listaDeComentarios = comentarioRepositorio.ListaDeComentarios();
            var quantidadeDeComentarios = listaDeComentarios.Count();
            ViewData["quantidadeDeComentarios"] = quantidadeDeComentarios;
            return View();
        }

        public IActionResult Usuarios()
        {   
            ListasViewModel usuarios = new ListasViewModel();

            var listaRecuperada = usuarioRepositorio.ListaDeUsuarios();

            usuarios.Usuarios = listaRecuperada;

            return View(usuarios);
        }

        public IActionResult Comentarios()
        {
            ListasViewModel comentarios = new ListasViewModel();

            var listaRecuperada = comentarioRepositorio.ListaDeComentarios();

            comentarios.Comentarios = listaRecuperada;

            return View(comentarios);
        }

        public IActionResult AprovarComentario(int id)
        {
            comentarioRepositorio.Aprovar(id);
            
            var listaRecuperadaUsuario = usuarioRepositorio.ListaDeUsuarios();
            var listaRecuperadaComentario = comentarioRepositorio.ListaDeComentarios();
            var ListasViewModel = new ListasViewModel(listaRecuperadaComentario, listaRecuperadaUsuario);

            return View("Comentarios", ListasViewModel);
        }

        public IActionResult RejeitarComentario(int id)
        {
            comentarioRepositorio.Rejeitar(id);

            var listaRecuperadaUsuario = usuarioRepositorio.ListaDeUsuarios();
            var listaRecuperadaComentario = comentarioRepositorio.ListaDeComentarios();
            var ListasViewModel = new ListasViewModel(listaRecuperadaComentario, listaRecuperadaUsuario);

            return View("Comentarios", ListasViewModel);
        }
    }
}