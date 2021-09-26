using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modul2HW6.Models;
using Modul2HW6.Providers;
using Modul2HW6.Enums;

namespace Modul2HW6.Extensions
{
    public static class CabstandExtensions
    {
        public static Car FindByParameters(this Car[] cars, CategoryType categoryType, string name, OriginCountry originCountry)
        {
            foreach (var item in cars)
            {
                if (item.Name == name && item.CategoryType == categoryType && item.OriginCountry == originCountry)
                {
                    return item;
                }
                else
                {
                    return null;
                }
            }

            return null;
        }
    }
}
