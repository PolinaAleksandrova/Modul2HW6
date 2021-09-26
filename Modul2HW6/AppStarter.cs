using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Modul2HW6.Services.Abstractions;
using Modul2HW6.Providers.Abstractions;
using Modul2HW6.Extensions;
using Modul2HW6.Enums;
using Modul2HW6.Models;
using Modul2HW6.Helpers;
using Modul2HW6.Services;

namespace Modul2HW6
{
    public class AppStarter
    {
        private readonly ICabstandService _cabstandService;
        private readonly ISortService _sortService;
        private readonly ICarProvider _carProvider;
        private readonly IComparer _comparer;

        public AppStarter(ICabstandService cabstandService, ISortService sortService, ICarProvider carProvider, IComparer comparer)
        {
            _cabstandService = cabstandService;
            _sortService = sortService;
            _carProvider = carProvider;
            _comparer = comparer;
        }

        public void Run()
        {
            var random = new Random();
            for (var i = 0; i < 5; i++)
            {
                _cabstandService.Add(_carProvider.Cars[random.Next(_carProvider.Cars.Length)]);
            }

            var totalPrice = _cabstandService.TotalPrice;
            _sortService.SortByFuelFlow(_cabstandService.Cars, _comparer);
            var findCar = _cabstandService.Cars.FindByParameters(CategoryType.E, "MercedesBenz W124", OriginCountry.Germany);
        }
    }
}