using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day6assignment
{
    internal class ToBinary
    {
        public static void ConvertToBinary()
        {

            Console.Write("Enter the Decimal Number : ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Enter the Decimal Number : ");
            int num = int.Parse(Console.ReadLine());
            int i, j;
            //loop to check the number of times the number is divisble by 2 (lcm)
            for (i = 0; number > 0; i++)
            {
                number = number / 2;
            }
            // store i as size of array
            int[] numberArray = new int[i];

            //store num modulas of 2 into array each time after increment num value
            for (j = 0; num > 0; j++)
            {
                numberArray[j] = num % 2;
                num = num / 2;
            }
            Array.Reverse(numberArray);
            foreach (int bin in numberArray)
            {
                Console.Write(bin);
            }

        }
    }
}
