using System;

namespace _01.HornetWings
{
    class HornetWings
    {
        static void Main()
        {
            long n = long.Parse(Console.ReadLine()); //wing flaps
            double m = double.Parse(Console.ReadLine()); //distance in meters/1000 wing flaps
            long p = long.Parse(Console.ReadLine());

            double distance = (n / 1000) *m;
            double time1 = n / 100;
            double time2 = (n / p) * 5;
            double totalTime = time1 + time2;
            Console.WriteLine($"{distance:F2} m.");
            Console.WriteLine(totalTime + " s.");

        }
    }
}
