using Application.Service;
using Application.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace ControladoresYVistaApp.Controllers
{
    public class MonedasController : Controller
    {
        private MonedasService _monedas = new();

        public IActionResult Monedas()
        {
            MonedasViewModel vm = new();

            vm.ConverterAmount =  _monedas.CoinConvertion(vm);

            return View(vm);
        }

        [HttpPost]
        public IActionResult Monedas(MonedasViewModel vm)
        {
            vm.ConverterAmount = _monedas.CoinConvertion(vm);

            return View(vm);
        }
    }
}
