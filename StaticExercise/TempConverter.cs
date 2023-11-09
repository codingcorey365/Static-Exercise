using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    internal static class TempConverter
    {
        public static double FahrenheitToCelsius(double f) 
        {
            var c = ((f - 32) * 5.0) / 9;

            return c;
        }

        public static double CelsiusToFahrenheit(double c)
        {
            var f = c * (9.0/5) + 32;

            return f;
        }
    }
}
