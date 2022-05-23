using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModel
{
    public class CalcPrestamosViewModel
    {
        public double montoPrestamo { get; set; }
        public int tipoPrestamo { get; set; }
        public int cuotasMensuales { get; set; }
        public int interes { get; set; }
        public double totalAPagar { get; set; }
        public double cuotaAPagarMensual { get; set; }
    }
}
