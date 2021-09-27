using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modul2HW6.Services.Abstractions;
using Modul2HW6.Models;

namespace Modul2HW6.Services
{
    public class CabstandService : ICabstandService
    {
        public CabstandService()
        {
            Cars = new Car[0];
        }

        public Car[] Cars { get; set; }

        public int TotalPrice
        {
            get
            {
                int priceSum = 0;
                foreach (var item in Cars)
                {
                    priceSum += item.Price.Value;
                }

                return priceSum;
            }
        }

        public bool Add(Car car)
        {
            var cars = Cars;

            Cars = new Car[Cars.Length + 1];

            for (var i = 0; i < Cars.Length - 1; i++)
            {
                Cars[i] = cars[i];
            }

            Cars[Cars.Length - 1] = car;

            return true;
        }
    }
}