using System;

namespace _04.Resurrection
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                long length = long.Parse(Console.ReadLine());
                decimal width = decimal.Parse(Console.ReadLine());
                int wingLength = int.Parse(Console.ReadLine());
                decimal totalYears = (decimal)Math.Pow(length, 2) * (width + (2 * wingLength));
                Console.WriteLine($"{totalYears}");
            }
        }
    }
}
