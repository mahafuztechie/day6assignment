using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day6assignment
{
    internal class CouponNumber
    {
        static int count = 0;
        public static void GenerateCoupons()
        {
            Console.WriteLine("enter a number of how many coupons u want to generate");
            int num = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[num];
            for (int i = 0; i < num; i++)
            {
                Random r = new Random();
                int coupun = r.Next(100, 115);
                count++;

                foreach (int c in arr)
                {
                    // generate new coupon if it matches in array
                    while (c == coupun)
                    {
                        coupun = r.Next(100, 115);
                        count++;
                    }
                }
                arr[i] = coupun;

            }
            foreach (int value in arr)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine("number of times number generated " + count);

        }
    }
}
