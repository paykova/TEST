using System;
using System.Linq;

namespace _04.GrabAndGo
{
    class GrabAndGo
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int n = int.Parse(Console.ReadLine());
            int index = 0;
            int maxIndex = 0;
            int count = 0;
            long sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if(n == numbers[i])
                {
                    count++;
                    index = i; 
                    if (index >= maxIndex)
                    {
                        maxIndex = index; 
                    }
                }
            }
            if (count == 0)
            {
                Console.WriteLine("No occurrences were found!");
            }
            else
            {
                for (int i = 0; i < maxIndex; i++)
                {
                    sum += numbers[i];
                }
                Console.WriteLine(sum);
            }

        }
    }
}
