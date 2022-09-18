using Application.Service;
using Application.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace ControladoresYVistaApp.Controllers
{
    public class PrestamosController : Controller
    {
        private PrestamosService _prestamo = new();

        public IActionResult Prestamos()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Prestamos(SolPrestamoViewModel vm)
        {
            ViewBag.monto = _prestamo.SolPrestamo(vm);

            return View();
        }
    }
}
