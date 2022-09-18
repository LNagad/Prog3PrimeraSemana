using Application.Service;
using Application.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace ControladoresYVistaApp.Controllers
{
    public class ZodiacoController : Controller
    {
        private readonly ZodiacoService _zodiacoService = new();

        public IActionResult Zodiaco()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Zodiaco(ZodiacoViewModel vm)
        {

            ViewBag.zodiaco = _zodiacoService.getZodiaco(vm);

            return View();
        }
    }
}
