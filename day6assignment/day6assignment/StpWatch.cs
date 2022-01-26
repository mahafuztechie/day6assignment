using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace day6assignment
{
    internal class StpWatch
    {
        public static void watch()
        {
            Stopwatch stopWatch = new Stopwatch();
            Console.WriteLine("Press S to start time");
            string value = Console.ReadLine();
            if (value == "s")
            {
                stopWatch.Start();

            }
            Console.WriteLine("Press T to stop");
            string val = Console.ReadLine();
            if (val == "t")
            {
                stopWatch.Stop();
            }

            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts = stopWatch.Elapsed;

            // Format and display the TimeSpan value.
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}", ts.Hours, ts.Minutes, ts.Seconds);
            Console.WriteLine("time elapsed " + elapsedTime);
        }
    }
}
