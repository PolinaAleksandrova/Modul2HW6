using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Modul2HW6.Services.Abstractions;
using Modul2HW6.Models;

namespace Modul2HW6.Services
{
    public class SortService : ISortService
    {
        public void SortByFuelFlow(Car[] cars, IComparer comparer)
        {
            Array.Sort(cars, comparer);
        }
    }
}
