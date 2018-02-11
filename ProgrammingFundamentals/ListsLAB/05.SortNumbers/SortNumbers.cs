using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.SortNumbers
{
    public class SortNumbers
    {
        public static void Main()
        {
            List<decimal> elements = Console.ReadLine()
                .Split(' ')
                .Select(decimal.Parse)
                .ToList();

            elements.Sort();
            Console.WriteLine(string.Join(" <= ", elements));
        }
    }
}
