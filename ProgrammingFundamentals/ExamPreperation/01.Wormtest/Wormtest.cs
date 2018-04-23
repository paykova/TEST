using System;

namespace _01.Wormtest
{
    class Wormtest
    {
        static void Main()
        {
            long lengthInM = long.Parse(Console.ReadLine());
            double widthInCm = double.Parse(Console.ReadLine());
            long lengthInCm = lengthInM * 100;

            double remainder = lengthInCm % widthInCm;

            if(widthInCm == 0)
            {
                var result = lengthInCm * widthInCm;
                Console.WriteLine($"{ result:F2}");
                return;

            }

            if (remainder == 0)
            {
                double sum = lengthInCm * widthInCm;
                Console.WriteLine($"{ sum:F2}");
            }
            else
            {
                double percentage = (lengthInCm / widthInCm) * 100;
                Console.WriteLine($"{percentage:F2}%");
            }

        }
    }
}
