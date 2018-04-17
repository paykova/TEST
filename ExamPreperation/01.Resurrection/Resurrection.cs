using System;
using System.Numerics;

namespace _01.Resurrection
{
    class Resurrection
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            

            for (int i = 0; i < n; i++)
            {
                long totalBodyLength = long.Parse(Console.ReadLine());
              decimal totalBodyWidth = decimal.Parse(Console.ReadLine());
                long windLength = long.Parse(Console.ReadLine());

                decimal year = totalBodyLength * totalBodyLength * (totalBodyWidth + 2 * windLength);
                Console.WriteLine($"{year}");   
            }
        }
    }
}
