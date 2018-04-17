using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Numbers
{
    class Numbers
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToList();

            double average = numbers.Average();
            //Console.WriteLine(average);
            numbers.Sort();

            List<int> biggerThen = new List<int>();

            for (int i = numbers.Count - 1; i > numbers.Count - 6; i--)
            {
                if (numbers[i] > average)
                {
                    biggerThen.Add(numbers[i]); 
                }
                else
                {
                    break; 
                }
            }

            if (biggerThen.Count > 0)
            {
                Console.WriteLine(string.Join(" ", biggerThen));
            }
            else
            {
                Console.WriteLine("No");
            }


        }
    }
}
