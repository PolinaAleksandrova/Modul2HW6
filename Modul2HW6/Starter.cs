using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Microsoft.Extensions.DependencyInjection;
using Modul2HW6.Providers.Abstractions;
using Modul2HW6.Providers;
using Modul2HW6.Services;
using Modul2HW6.Services.Abstractions;
using Modul2HW6.Helpers;

namespace Modul2HW6
{
    public class Starter
    {
        public void StartApplication()
        {
            var serviceProvider = new ServiceCollection()
            .AddTransient<ICarProvider, CarProvider>()
            .AddTransient<ICabstandService, CabstandService>()
            .AddSingleton<ISortService, SortService>()
            .AddTransient<AppStarter>()
            .BuildServiceProvider();
            var appStarter = serviceProvider.GetService<AppStarter>();
            appStarter.Run();
        }
    }
}
