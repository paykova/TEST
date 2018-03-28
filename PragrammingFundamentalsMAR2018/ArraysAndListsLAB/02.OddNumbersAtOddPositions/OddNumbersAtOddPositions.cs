using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.OddNumbersAtOddPositions
{
    class OddNumbersAtOddPositions
    {
        static void Main()
        {
            int[] elements = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            for (int i = 1; i < elements.Length; i+=2)
            { if (elements[i] % 2 != 0)
                {
                    Console.WriteLine($"Index {i} -> {elements[i]}");
                   
                }
            }
  
        }
    }
}
