using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModel
{
    public class MonedasViewModel
    {
        public int CoinStart { get; set; }
        public double CoinStartAmount { get; set; }

        public int CoinEnd { get; set; }
        public double CoinEndAmount { get; set; }

        public double ConverterAmount { get; set; }
    }
}
