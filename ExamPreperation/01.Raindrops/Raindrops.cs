using System;
using System.Numerics;

namespace _01.Raindrops
{
    class Raindrops
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double density = double.Parse(Console.ReadLine());

            double sum = 0;
            double result = 0; 

            for (int i = 0; i < n; i++)
            {
               string[] raindrops = Console.ReadLine().Split();
                long raindropsCount = long.Parse(raindrops[0]);
                long sqrm = long.Parse(raindrops[1]);
                sum += (double)raindropsCount / sqrm;
            }


            //if (density == 0)
            //{
            //    Console.WriteLine($"{sum: F3}");
            //}
            //else
            //{
            //    double result = sum / density;
            //    Console.WriteLine($"{result:F3}");
            //}

            if (density != 0)

            {

                result = sum / density;

            }

            else

            {

                result = sum;

            }



            Console.WriteLine($"{result:f3}");

        }
    }
}
