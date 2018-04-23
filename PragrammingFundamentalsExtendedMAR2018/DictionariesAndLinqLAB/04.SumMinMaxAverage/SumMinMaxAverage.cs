using System;
using System.Collections.Generic;
using System.Linq; 

namespace _04.SumMinMaxAverage
{
    class SumMinMaxAverage
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<double> elements = new List<double>();

            for (int i = 0; i < n; i++)
            {
                double number = double.Parse(Console.ReadLine());
                elements.Add(number); 
            }

            Console.WriteLine($"Sum = {elements.Sum()}");
            Console.WriteLine($"Min = {elements.Min()}");
            Console.WriteLine($"Max = {elements.Max()}");
            Console.WriteLine($"Average = {elements.Average()}");

        }
    }
}
