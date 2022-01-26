using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day6assignment
{
    internal class VendingMachine
    {
        public static void Machine()
        {
            Console.Write("Insert your cash ammount: ");
            int cash = Convert.ToInt32(Console.ReadLine());
            int tempCash = cash; //80
            int[] arrayOfNotes = { 1000, 500, 100, 50, 10, 5, 2, 1 };
            for (int i = 0; i < arrayOfNotes.Length; i++)
            {
                if (cash >= arrayOfNotes[i])
                {
                    int noOfNotes = cash / arrayOfNotes[i];
                    cash %= arrayOfNotes[i];
                    Console.WriteLine(arrayOfNotes[i] + " x " + noOfNotes);
                }
                if (cash == 0) break;
            }
            Console.WriteLine("---------------------");
            Console.WriteLine($"total\t= {tempCash}");

        }
    }
}
