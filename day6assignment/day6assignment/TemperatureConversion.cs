using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day6assignment
{
    internal class TemperatureConversion
    {
        public static void CalCelsius()
        {
            Console.WriteLine("enter a Fahranheit Value to calculate value");
            double f = Convert.ToDouble(Console.ReadLine());
            double c = (f - 32) * 5 / 9;
            Console.WriteLine(c);
        }
        public static void CalFaranheit()
        {
            Console.WriteLine("enter a Celsius Value to calculate Fahranheit value");
            double c = Convert.ToDouble(Console.ReadLine());
            double f = (c * 9 / 5) + 32;
            Console.WriteLine(f);
        }
    }
}
