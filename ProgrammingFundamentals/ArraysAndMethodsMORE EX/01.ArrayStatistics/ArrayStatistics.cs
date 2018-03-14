using System;
using System.Linq;

namespace _01.ArrayStatistics
{
    class ArrayStatistics
    {
        static void Main()
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int min = input.Min();
            int max = input.Max();
            int sum = input.Sum();
            var average = input.Average();
     
            Console.WriteLine($"Min = {min}");
            Console.WriteLine($"Max = {max}");
            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Average = {average}");
        }
    }
}
