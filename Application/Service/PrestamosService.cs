using Application.Enums;
using Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Service
{
    public class PrestamosService
    {
        
        public double SolPrestamo(SolPrestamoViewModel vm)
        {
            double interesAnual = 0;
            double cuotaMensual = 0;
            double montoPrestamo = vm.montoPrestamo;
            int cantidadMeses = vm.cuotasMensuales;

            switch (vm.tipoPrestamo)
            {
                case (int)tipoPrestamos.PERSONAL:

                    interesAnual = (montoPrestamo * 22) / 100;

                    cuotaMensual = montoPrestamo + interesAnual;

                    cuotaMensual = cuotaMensual /cantidadMeses;
                    
                    break;
                case (int)tipoPrestamos.AUTOMOVIL:

                    interesAnual = (montoPrestamo * 12) / 100;

                    cuotaMensual = montoPrestamo + interesAnual;

                    cuotaMensual = cuotaMensual / cantidadMeses;


                    break;
                case (int)tipoPrestamos.HIPOTECARIO:

                    interesAnual = (montoPrestamo * 8) / 100;

                    cuotaMensual = montoPrestamo + interesAnual;

                    cuotaMensual = cuotaMensual / cantidadMeses;


                    break;
            }

            return Math.Round(cuotaMensual, 2);
        }
    }
}
