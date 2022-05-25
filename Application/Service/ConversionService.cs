using Application.Enums;
using Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Service
{
    public class ConversionService
    {
        public double convertCoin(ConversionViewModel mv)
        {
            double MyProperty;

            double DOLAR = 55.5;
            double EURO = 60.5;

            int monedaInicial = mv.monedaInicial;
            int monedaFinal = mv.monedaFinal;
            double cantidadAConvertir = mv.cantidadAConvertir;
            double resultado = mv.resultado;

            switch (monedaInicial)
            {
                case (int)fromCoin.DOLAR:

                    if (monedaFinal == (int)toCoin.PESO)
                    {
                        resultado = cantidadAConvertir * 55.20;

                    }
                    else if (monedaFinal == (int)toCoin.EURO)
                    {
                        resultado = cantidadAConvertir * 0.93;

                    }
                    else
                    {
                        resultado = cantidadAConvertir;
                    }
                break;

                case (int)fromCoin.EURO:

                    if (monedaFinal == (int)toCoin.PESO)
                    {
                        resultado = cantidadAConvertir * 59.25;

                    }
                    else if (monedaFinal == (int)toCoin.DOLAR)
                    {
                        resultado = cantidadAConvertir * 1.07;

                    }
                    else
                    {
                        resultado = cantidadAConvertir;
                    }
                break;

                case (int)fromCoin.PESO:

                    if (monedaFinal == (int)toCoin.EURO)
                    {
                        resultado = cantidadAConvertir * 0.017;

                    }
                    else if (monedaFinal == (int)toCoin.DOLAR)
                    {
                        resultado = cantidadAConvertir * 0.018;

                    }
                    else
                    {
                        resultado = cantidadAConvertir;
                    }
                    break;
            }

            return resultado;
        }
    }
}
