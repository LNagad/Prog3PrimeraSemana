using Application.Service;
using Application.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FuegoALaLata.Controllers
{
    public class AppController : Controller
    {
        private readonly ZodiacoService zodiacoService;
        public AppController()
        {
            zodiacoService = new();
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Zodiaco()
        {
            ViewBag.zodiacoData = "";
            return View();
        }
        [HttpPost]
        public IActionResult Zodiaco(ZodiacoViewModel vm)
        {
            if (vm.dDate > 31)
            {
                ViewBag.zodiacoData = "Hubo un problema con el dia...";
            } else if (vm.dDate == 0) {
                ViewBag.zodiacoData = "Hubo un problema con el dia...";
            } else
            {
                ViewBag.zodiacoData = zodiacoService.getZodiaco(vm);
            }
            return View();
        }
    }
}
