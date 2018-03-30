using System;

namespace _02.HornetWings
{
    class HornetWings
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine()); // the wing flaps, the hornet has chosen to do.
            decimal m = decimal.Parse(Console.ReadLine()); // the distance the hornet travels for 1000 wing flaps.
            int p = int.Parse(Console.ReadLine()); // the endurance of the hornet.

            var dictance = (n / 1000) * m;
            var seconds1 = n / 100;
            var seconds2 = n / p * 5;
            var totalSeconds = seconds1 + seconds2; 

            Console.WriteLine($"{dictance:F2} m.");
            Console.WriteLine($"{totalSeconds} s.");
        }
    }
}
