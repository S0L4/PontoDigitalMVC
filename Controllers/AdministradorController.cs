using Microsoft.AspNetCore.Mvc;
using PontoDigitalMVC.Repositories;
using PontoDigitalMVC.ViewModel;

namespace PontoDigitalMVC.Controllers
{
    public class AdministradorController : Controller
    {
        ComentarioRepositorio comentarioRepositorio = new ComentarioRepositorio();

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Usuarios()
        {   
            
            return View();
        }
        public IActionResult Comentarios()
        {
            ComentariosViewModel comentarios = new ComentariosViewModel();

            var listaRecuperada = comentarioRepositorio.ListaDeComentarios();

            comentarios.listaDeComentarios = listaRecuperada;

            return View(comentarios);
        }
    }
}