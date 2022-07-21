using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticKeywordExercise
{
    public static class TempConverter
    {
        public static double FahrenheitToCelsius(double x)
        {
            return (x - 32) * 0.5556;
        }
        public static double CelsiusToFahrenheit(double x)
        {
            return (x * 1.8) + 32;
        }
    }
}
