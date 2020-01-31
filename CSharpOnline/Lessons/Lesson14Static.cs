using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOnline.Lessons
{ 
    /*This class goes over Lesson 14 static content */
    public static class Lesson14Static
    {
        static readonly int baseTemp;

        static Lesson14Static()
        {
            baseTemp = 32;
        }

        public static void CelsiusToFahrenheit(string temperature)
        {
            double celsius = Double.Parse(temperature);
            double fahrenheit = (celsius * 9 / 5) + baseTemp;
            Console.WriteLine(fahrenheit);
        }

        public static double FahrenheitToCelsius(string temperature)
        {
            double fahrenheit = Double.Parse(temperature);
            double celsius = (fahrenheit - baseTemp) * 5 / 9;
            return celsius;
        }

    } // end class
} // end namespace
