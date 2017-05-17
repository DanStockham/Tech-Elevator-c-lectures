using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimerForAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Diagnostics.Stopwatch watch1 = System.Diagnostics.Stopwatch.StartNew();
            // the code that you want to measure comes here

            int someLargeNumber = 10000;

            for (int i = 0; i < someLargeNumber; i++)
            {
                double value1 = 5.4;
                value1 = value1 / 4.5;
            }

            watch1.Stop();
            long elapsedMs = watch1.ElapsedMilliseconds;
            Console.WriteLine("Linear time: " + elapsedMs);


            System.Diagnostics.Stopwatch watch2 = System.Diagnostics.Stopwatch.StartNew();
            // the code that you want to measure comes here

            for (int i = 0; i < someLargeNumber; i++)
            {
                for (int j = 0; j < someLargeNumber; j++)
                {
                    double value1 = 5.4;
                    value1 = value1 / 4.5;
                }

            }

            watch2.Stop();
            elapsedMs = watch2.ElapsedMilliseconds;
            Console.WriteLine("Squared time: " + elapsedMs);

        }
    }
}
