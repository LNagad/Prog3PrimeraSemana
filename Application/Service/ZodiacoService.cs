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
        public String getZodiaco (ZodiacoViewModel vm)
        {
            string zodiaco = String.Empty;

            switch (vm.mDate)
            {
                case (int)Months.MARZO:
                    _ = vm.dDate < 21 ? zodiaco = "Piscis" : zodiaco = "Aries";
                break;
                case (int)Months.ABRIL:
                    _ = vm.dDate < 20 ? zodiaco = "Aries" : zodiaco = "Tauro";
                break;
                case (int)Months.MAYO:
                    _ = vm.dDate < 21 ? zodiaco = "Tauro " : zodiaco = "Géminis ";
                    break;
                case (int)Months.JUNIO:
                    _ = vm.dDate < 20 ? zodiaco = "Géminis" : zodiaco = "Cáncer ";
                    break;
                case (int)Months.JULYO:
                    _ = vm.dDate < 23 ? zodiaco = "Cáncer" : zodiaco = "Leo";
                    break;
                case (int)Months.AGOSTO:
                    _ = vm.dDate < 23 ? zodiaco = "Leo" : zodiaco = "Virgo";
                    break;
                case (int)Months.SEPTIEMBRE:
                    _ = vm.dDate < 23 ? zodiaco = "Virgo" : zodiaco = "Libra";
                    break;
                case (int)Months.OCTUBRE:
                    _ = vm.dDate < 22 ? zodiaco = "Libra" : zodiaco = "Escorpio";
                    break;
                case (int)Months.NOVIEMBRE:
                    _ = vm.dDate < 22 ? zodiaco = "Escorpio" : zodiaco = "Sagitario";
                    break;
                case (int)Months.DICIEMBRE:
                    _ = vm.dDate < 21 ? zodiaco = "Sagitario" : zodiaco = "Capricornio";
                    break;
                case (int)Months.ENERO:
                    _ = vm.dDate < 20 ? zodiaco = "Capricornio" : zodiaco = "Acuario";
                    break;
                case (int)Months.FEBRERO:
                    _ = vm.dDate < 19 ? zodiaco = "Acuario" : zodiaco = "Piscis";
                    break;
                default:
                    zodiaco = "Mes no encontrado!!!";
                    break;
            }
            return zodiaco;

        }
    }
}
