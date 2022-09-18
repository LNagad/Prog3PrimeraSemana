using Application.Enums;
using Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Service
{
    public class ZodiacoService
    {
        public string getZodiaco(ZodiacoViewModel vm)
        {
            string zodiaco = String.Empty;

            switch (vm.mMonth)
            {
                case (int)Month.MARZO:
                    _ = vm.dDay < 21 ? zodiaco = "Piscis" : zodiaco = "Aries";
                    break;
                case (int)Month.ABRIL:
                    _ = vm.dDay <= 20 ? zodiaco = "Aries" : zodiaco = "Tauro";
                    break;
                case (int)Month.MAYO:
                    _ = vm.dDay <= 21 ? zodiaco = "Tauro" : zodiaco = "Géminis";
                    break;
                case (int)Month.JUNIO:
                    _ = vm.dDay <= 21 ? zodiaco = "Géminis" : zodiaco = "Cáncer";
                    break;
                case (int)Month.JULIO:
                    _ = vm.dDay <= 22 ? zodiaco = "Cáncer" : zodiaco = "Leo";
                    break;
                case (int)Month.AGOSTO:
                    _ = vm.dDay <= 23 ? zodiaco = "Leo" : zodiaco = "Virgo";
                    break;
                case (int)Month.SEPTIEMBRE:
                    _ = vm.dDay <= 23 ? zodiaco = "Virgo" : zodiaco = "Libra";
                    break;
                case (int)Month.OCTUBRE:
                    _ = vm.dDay <= 23 ? zodiaco = "Libra" : zodiaco = "Escorpio";
                    break;
                case (int)Month.NOVIEMBRE:
                    _ = vm.dDay <= 22 ? zodiaco = "Escorpio" : zodiaco = "Sagitario";
                    break;
                case (int)Month.DICIEMBRE:
                    _ = vm.dDay <= 21 ? zodiaco = "Sagitario" : zodiaco = "Capricornio";
                    break;
                case (int)Month.ENERO:
                    _ = vm.dDay <= 20 ? zodiaco = "Capricornio" : zodiaco = "Acuario";
                    break;
                case (int)Month.FEBRERO:
                    _ = vm.dDay <= 19 ? zodiaco = "Acuario" : zodiaco = "Piscis";
                    break;
                default:
                    zodiaco = "No se pudo encontrar tu zodiaco!";
                    break;
            }
            return zodiaco;
        }

    }
}
