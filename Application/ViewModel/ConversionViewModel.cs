using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModel
{
    public class ConversionViewModel
    {
        public int monedaInicial { get; set; }
        public double cantidadAConvertir { get; set; }
        public int monedaFinal { get; set; }
        public double resultado { get; set; }
    }
}
