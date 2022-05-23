using Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Service
{
    public class CalcPrestamosService
    {
        public double calcularCuotasAPagar(CalcPrestamosViewModel vm)
        {
            double cuotaAPagarMensual;
            try
            {
                var interes = vm.montoPrestamo * vm.interes / 100;
                vm.totalAPagar = vm.montoPrestamo + interes;
                vm.cuotaAPagarMensual = Math.Round(vm.totalAPagar / vm.cuotasMensuales, 2) ;
                cuotaAPagarMensual = vm.cuotaAPagarMensual;
            }
            catch (Exception ex)
            {
                throw;
            }
            return cuotaAPagarMensual;
        }
    }
}
