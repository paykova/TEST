using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.LargestNNumber
{
    class LargestNNumber
    {
        static void Main()
        {
            List<int> elements = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int n = int.Parse(Console.ReadLine());

            elements.Sort();
            elements.Reverse();

            for (int i = 0; i < n; i++)
            {
                Console.Write(elements[i] + " ");
            }
            Console.WriteLine();
           
           
        }
    }
}
