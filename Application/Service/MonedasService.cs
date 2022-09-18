using Application.Enums;
using Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Service
{
    public class MonedasService
    {
        public double CoinConvertion(MonedasViewModel vm)
        {

            double USD = 52.42;
            double EUR = 52.50;

            double amount = USD;

            switch(vm.CoinStart)
            {
                case (int)CoinConvert.USD:
                    switch(vm.CoinEnd)
                    {
                        case (int)CoinConvert.DOP:
                            amount = vm.CoinStartAmount * USD;
                            break;
                        case (int)CoinConvert.EUR:
                            amount = Math.Round(vm.CoinStartAmount * USD / EUR, 2);
                            break;
                        case (int)CoinConvert.USD:
                            amount = vm.CoinStartAmount;
                            break;
                    }
                    break;

                case (int)CoinConvert.EUR:
                    switch (vm.CoinEnd)
                    {
                        case (int)CoinConvert.DOP:
                            amount = vm.CoinStartAmount * EUR;
                            break;
                        case (int)CoinConvert.USD:
                            amount = Math.Round(vm.CoinStartAmount * EUR / USD, 2);
                            break;
                        case (int)CoinConvert.EUR:
                            amount = vm.CoinStartAmount;
                            break;
                    }
                    break;

                case (int)CoinConvert.DOP:
                    switch (vm.CoinEnd)
                    {
                        case (int)CoinConvert.USD:
                            amount = Math.Round(vm.CoinStartAmount / USD, 3);
                            break;
                        case (int)CoinConvert.EUR:
                            amount = Math.Round(vm.CoinStartAmount / EUR,3);
                            break;
                        case (int)CoinConvert.DOP:
                            amount = vm.CoinStartAmount;
                            break;
                    }
                    break;

            }

            return amount;
        }
    }
}
