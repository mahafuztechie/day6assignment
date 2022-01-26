using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day6assignment
{
    internal class Fibonacci
    {
        public static int firstNum = 0, secondNum = 1, result = 1;

        public static void findFibonacciSeries()
        {
            Console.WriteLine("Please enter number to generate series");
            
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("User number is: " + num);
            result = firstNum + secondNum;
            Console.Write("Series are : " + firstNum + " " + secondNum);
            for (int i = 2; i < num; i++)
            {
                //swapping values
                firstNum = secondNum;
                secondNum = result;
                Console.Write("\t" + result);
                //reasign result ading first and second
                result = firstNum + secondNum;

            }
        }
    } 
}
