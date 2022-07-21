using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticKeywordExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TempConverter.CelsiusToFahrenheit(32));
            Console.WriteLine(TempConverter.FahrenheitToCelsius(80));
            Console.ReadLine();
        }
    }
}
