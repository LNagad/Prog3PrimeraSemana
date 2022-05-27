using Application.Service;
using Application.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FuegoALaLata.Controllers
{
    public class AppController : Controller
    {
        private readonly ZodiacoService zodiacoService;
        private readonly CalcPrestamosService obj;
        public AppController()
        {
            zodiacoService = new();
            obj = new();
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
            }
            else if (vm.dDate == 0)
            {
                ViewBag.zodiacoData = "Hubo un problema con el dia...";
            }
            else
            {
                ViewBag.zodiacoData = zodiacoService.getZodiaco(vm);
            }

            return View();
        }
        public IActionResult Conversion()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Conversion(ConversionViewModel vm)
        {
            ConversionService cs = new();

            ViewBag.resultado = cs.convertCoin(vm);

            return View();
        }
        public IActionResult CalPrestamos()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CalPrestamos(CalcPrestamosViewModel vm)
        {
             
            switch (vm.tipoPrestamo)
            {
                case 1: vm.interes = 22; break;
                case 12: vm.interes = 22; break;
                case 8: vm.interes = 22; break;
                default: vm.interes = 0; break;
            }

            var resultado = obj.calcularCuotasAPagar(vm);
            ViewBag.resultado = resultado;
            return View("CalPrestamosResultado", vm);
        }
    }
}
