using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.RemoveNegativesAndReverse
{
    public class RemoveNegativesAndReverse
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine()
                  .Split()
                  .Select(int.Parse)
                  .ToList();

            numbers.Reverse();
            numbers.RemoveAll(n => n < 0);

            if (numbers.Count <= 0)
            {
                Console.WriteLine("empty");
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
