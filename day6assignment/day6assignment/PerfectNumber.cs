﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day6assignment
{
    internal class PerfectNumber
    {
        public static void Number()
        {
            Console.WriteLine("Enter Number to check the number if perfect number or not");
            int number = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine(i);
                    sum += i;
                }
                else
                {
                    Console.WriteLine("remainder is not equal to zero");
                }
            }
            if (sum == number)
            {
                Console.WriteLine(number + " is Perfect Number");
            }
            else
            {
                Console.WriteLine(number + " is not perfect number");
            }

        }
    }
}
