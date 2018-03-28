using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.ArrayContainsElement
{
    class ArrayContainsElement
    {
        static void Main()
        {
            List<int> elements = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToList();

            int n = int.Parse(Console.ReadLine());

            if (elements.Contains(n))
            {
                Console.WriteLine("yes");
                           }
            else
            {
                Console.WriteLine("no");
            }
         
        }
    }
}
