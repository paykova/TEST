using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.MaxSequenceOfEqualElements
{
    public class MaxSequenceOfEqualElements
    {
        public static void Main()
        {
            // 3 4 4 5 5 5 2 2	      5 5 5

            List<int> elements = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int count = 1;
            int maxCount = 0;
            int temp = 0;

            for (int i = 0; i < elements.Count - 1; i++)
            {
                if (elements[i] == elements[i + 1])
                {
                    count++;
                    if (count > maxCount)
                    {
                        maxCount = count;
                        temp = elements[i];
                    }
                }
                else
                {
                    if (count > maxCount)
                    {
                        maxCount = count;
                        temp = elements[i];
                    }
                    count = 1;
                }
            }

            for (int i = 0; i < maxCount; i++)
            {
                Console.Write(temp + " ");
            }
            Console.WriteLine();
        }
    }
}
