using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWeatherCL.Extensions
{
    public static class ValuesExtensions
    {
        public static readonly string[] WindRose = new string[] {
            "В", "ВСВ", "СВ", "ССВ", "С", "ССЗ", "СЗ", "ЗСЗ", "З", "ЗЮЗ", "ЮЗ", "ЮЮЗ", "Ю", "ЮЮВ", "ЮВ", "ВЮВ"
        };
        public static readonly double CelciusNull = 273.15;
        public static double KtoC(this double k) => k >= CelciusNull ? k - CelciusNull : -(CelciusNull - k);
        public static long HPAtoMmHg(this long p) => (long)(p * 0.00750062);
        public static string DegToDirection(this long d) => WindRose[d * 16 / 360];
    }
}
