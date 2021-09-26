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
        private int _iterator = 0;

        public CabstandService(int capacity)
        {
            Cars = new Car[capacity];
            Capacity = capacity;
        }

        public Car[] Cars { get; }
        public int Capacity { get; }

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

        public void Add(Car cars)
        {
            if (_iterator < Capacity)
            {
                Cars[_iterator++] = cars;
            }
        }

        public void Remove()
        {
            Cars[_iterator--] = null;
        }
    }
}