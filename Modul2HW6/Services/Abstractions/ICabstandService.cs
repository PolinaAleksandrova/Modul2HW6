using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modul2HW6.Models;
using Modul2HW6.Services;

namespace Modul2HW6.Services.Abstractions
{
    public interface ICabstandService
    {
        Car[] Cars { get; }
        int TotalPrice { get; }
        bool Add(Car cars);
    }
}
