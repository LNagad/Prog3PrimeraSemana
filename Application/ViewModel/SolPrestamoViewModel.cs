using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModel
{
    public class SolPrestamoViewModel
    {
        public double montoPrestamo { get; set; }
        public int tipoPrestamo { get; set; }
        public int cuotasMensuales { get; set; }
        public int interesAnual { get; set; }
        public double cuotaMensual { get; set; }
    }
}
