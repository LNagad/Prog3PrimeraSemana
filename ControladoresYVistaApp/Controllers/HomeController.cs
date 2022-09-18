using Microsoft.AspNetCore.Mvc;

namespace ControladoresYVistaApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
