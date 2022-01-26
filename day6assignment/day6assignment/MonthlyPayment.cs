using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day6assignment
{
    internal class MonthlyPayment
    {
        public static void MonPayment()
        {
            Console.WriteLine("enter a principle loan amount");
            double P = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a year");
            double Y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a rate of interest");
            double R = Convert.ToInt32(Console.ReadLine());

            double n = 12 * Y;
            
            double r = R / (12 * 100);

            double MonPayment = P * r / (1 - Math.Pow(1 + r, (-n)));
            Console.WriteLine(MonPayment);
        }
    }
}
