using Microsoft.AspNetCore.Mvc;

namespace PontoDigitalMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["NomeView"] = "Home";
            return View();
        }
    }
}