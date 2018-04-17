using System;

namespace _01.SinoTheWalker
{
    class SinoTheWalker
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(':');
            int hour = int.Parse(input[0]);
            int minutes = int.Parse(input[1]);
            int seconds = int.Parse(input[2]);
            ulong totalTimeInSeconds = (ulong)seconds + (ulong)minutes * 60 + (ulong)hour * 60 * 60;

            long steps = long.Parse(Console.ReadLine());
            long timePerStep = long.Parse(Console.ReadLine());
            ulong neededTime = (ulong)steps * (ulong)timePerStep;

            ulong result = (ulong)totalTimeInSeconds + neededTime;

            ulong h = result / 3600;
            
            result = result - (h * 3600);
            ulong m = result / 60;
            result = result - (m *60);
            ulong s = result;
            if (h > 23)
            {
                h = h % 24;
            }
            Console.WriteLine($"Time Arrival: {h:D2}:{m:D2}:{s:D2}");

        }
    }
}
