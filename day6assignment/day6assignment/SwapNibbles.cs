using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day6assignment
{
    internal class SwapNibbles
    {
      
        public static int[] ConvertToBinary()
        {

            Console.Write("Enter the Decimal Number : ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Enter the Decimal Number : ");
            int num = int.Parse(Console.ReadLine());
            int i, j;
            //loop to  check if howmany times its divisible by 2
            for (i = 0; number > 0; i++)
            {
                number = number / 2;
            }
            int[] numberArray = new int[i];
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
            return numberArray;
        }
        public static void swap()
        {
            ConvertToBinary();
            //int[] secArr = new int[num*2];
            //int[] value = (numberArray.Length / 2);
            //int q = value % 2;
            //for (int m=0; m < q; m++)
            //{
            // foreach (int b in value)
            // {
            // Console.WriteLine(b);
            // secArr[i] = b;
            // foreach (int c in secArr)
            // {
            // Console.WriteLine(c);
            // }
            // }
            //}
            //int x = q - numberArray.Length;
            //foreach (int y in numberArray)
            //{
            // Console.WriteLine(y);
            //}
        }
    }
}
