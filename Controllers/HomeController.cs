using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PontoDigitalMVC.Controllers
{
    public class HomeController : Controller
    {
        private const string SESSION_EMAIL = "_EMAIL";
        private const string SESSION_CLIENTE= "_ClIENTE";
        private const string SESSION_ADM = "_ADM";

        public IActionResult Index()
        {                    
            ViewData["Adm"] = HttpContext.Session.GetString(SESSION_ADM);
            ViewData["User"] = HttpContext.Session.GetString(SESSION_EMAIL);
            ViewData["NomeView"] = "Home";
            return View();
        }
    }
}