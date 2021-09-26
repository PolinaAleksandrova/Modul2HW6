using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modul2HW6.Models;

namespace Modul2HW6.Providers.Abstractions
{
    public interface ICarProvider
    {
        Car[] Cars { get; }
    }
}
