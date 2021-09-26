using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modul2HW6.Enums;

namespace Modul2HW6.Models.Cars.PassengerCars
{
    public abstract class MultiPurposeCategory : PassengerCar
    {
        public abstract MultiPurposeType MultiPurposeType { get; }
    }
}
