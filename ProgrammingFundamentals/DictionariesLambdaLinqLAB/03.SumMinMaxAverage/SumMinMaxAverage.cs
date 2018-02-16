using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.SumMinMaxAverage
{
    public class SumMinMaxAverage
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            List<int> consoleNumbers = new List<int>();
            var sum = 0;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                consoleNumbers.Add(num);
                sum += num; 
            }

            var min = consoleNumbers.Min();
            var max = consoleNumbers.Max();
            var average = consoleNumbers.Average();

            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Min = {min}");
            Console.WriteLine($"Max = {max}");
            Console.WriteLine($"Average = {average}");
        }
    }
}
