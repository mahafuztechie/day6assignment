using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day6assignment
{
    internal class DayWeek
    {
        static int month, day, year, x, y, m, d;
        public static void DayOfWeek()
        {
            Console.WriteLine("Enter month in numbers");
            month = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter year in numbers");
            year = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Day in numbers");
            day = int.Parse(Console.ReadLine());

            y = year - (14 - month) / 12;
            x = y + y / 4 - y / 100 + y / 400;
            m = month + 12 * ((14 - month) / 12) - 2;
            d = (day + x + 31 * m / 12) % 7;

            switch (d)
            {
                case 0:
                    Console.WriteLine("sunday");
                    break;
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
            }


        }
    }
}
