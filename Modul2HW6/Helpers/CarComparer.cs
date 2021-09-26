using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modul2HW6.Models;

namespace Modul2HW6.Helpers
{
    public class CarComparer : IComparer
    {
        public int Compare(object firstCar, object secondCar)
        {
            if (((Car)firstCar).FuelFlow.FlowValue < ((Car)secondCar).FuelFlow.FlowValue)
            {
                return -1;
            }
            else if (((Car)firstCar).FuelFlow.FlowValue == ((Car)firstCar).FuelFlow.FlowValue)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }
}
