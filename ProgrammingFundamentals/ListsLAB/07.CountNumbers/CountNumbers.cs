using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.CountNumbers
{
    public class CountNumbers
    {
        public static void Main()
        {
            //Solution1();
            Solution2();
        }

        private static void Solution2()
        {
            List<int> elements = Console.ReadLine()
                 .Split(' ')
                 .Select(int.Parse)
                 .ToList();

            elements.Sort();
            int count = 1;

            List<int> result = new List<int>(1001);
            int[] numbersCounts = new int[1001];

            for (int i = 0; i < elements.Count; i++)
            {
                var currentNumber = elements[i];
                numbersCounts[currentNumber]++;

            }
            for (int i = 0; i < numbersCounts.Length; i++)
            {
                if (numbersCounts[i] != 0)
                {
                    Console.WriteLine($"{i} -> {numbersCounts[i]}");
                }
            }
        }

        private static void Solution1()
        {
            List<int> elements = Console.ReadLine()
                 .Split(' ')
                 .Select(int.Parse)
                 .ToList();

            elements.Sort();
            int count = 1;

            List<int> forCounting = new List<int>(1001);

            int i = 0;
            while (i < elements.Count - 1)
            {
                if (elements[i] == elements[i + 1]) //8 2 2 8 2 2 3 7
                {                                   // 2 2 2 2 3 7 8
                    count++;
                }
                else
                {
                    Console.WriteLine($"{elements[i]} -> {count}");
                    count = 1;
                }
                i++;
            }
            Console.WriteLine($"{elements[i]} -> {count}");
        }
    }
}
