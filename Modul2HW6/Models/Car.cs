using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modul2HW6.Enums;

namespace Modul2HW6.Models
{
    public abstract class Car
    {
        public string Name { get; init; }
        public CategoryType CategoryType { get; init; }
        public OriginCountry OriginCountry { get; init; }
        public Price Price { get; init; }
        public FuelFlow FuelFlow { get; init; }
    }
}
