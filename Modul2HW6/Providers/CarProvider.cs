using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modul2HW6.Providers.Abstractions;
using Modul2HW6.Models;
using Modul2HW6.Enums;
using Modul2HW6.Models.Cars.PassengerCars.Larger;
using Modul2HW6.Models.Cars.PassengerCars.Medium;
using Modul2HW6.Models.Cars.PassengerCars.Mini;
using Modul2HW6.Models.Cars.PassengerCars.MultiPurpose;
using Modul2HW6.Models.Cars.PassengerCars.SportsUtility;

namespace Modul2HW6.Providers
{
    public class CarProvider : ICarProvider
    {
        public CarProvider()
        {
            Cars = new Car[]
            {
                new Ford
                {
                    Name = "Ford Sierra",
                    CategoryType = CategoryType.D,
                    OriginCountry = OriginCountry.Belgium,
                    Price = new Price { Value = 1850 },
                    FuelFlow = new FuelFlow { FlowValue = 9.7 }
                },
                new MercedesBenz
                {
                    Name = "MercedesBenz W124",
                    CategoryType = CategoryType.E,
                    OriginCountry = OriginCountry.Germany,
                    Price = new Price { Value = 3000 },
                    FuelFlow = new FuelFlow { FlowValue = 10.5 }
                },
                new Renault
                {
                    Name = "Renault Juvaquatre",
                    CategoryType = CategoryType.C,
                    OriginCountry = OriginCountry.France,
                    Price = new Price { Value = 10221 },
                    FuelFlow = new FuelFlow { FlowValue = 8.5 }
                },
                new Fiat
                {
                    Name = "Fiat Panda",
                    CategoryType = CategoryType.A,
                    OriginCountry = OriginCountry.Italy,
                    Price = new Price { Value = 4100 },
                    FuelFlow = new FuelFlow { FlowValue = 7.9 }
                },
                new Kia
                {
                    Name = "Kia Carens",
                    CategoryType = CategoryType.M,
                    OriginCountry = OriginCountry.SouthKorea,
                    Price = new Price { Value = 13000 },
                    FuelFlow = new FuelFlow { FlowValue = 9.1 }
                },
                new Nissan
                {
                    Name = "Nissan Magnite",
                    CategoryType = CategoryType.J,
                    OriginCountry = OriginCountry.Japan,
                    Price = new Price { Value = 7549 },
                    FuelFlow = new FuelFlow { FlowValue = 5.6 }
                }
            };
        }

        public Car[] Cars { get; }
    }
}
