using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.FoldAndSum
{
    class FoldAndSum
    {
        static void Main()
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            int k = input.Count;

            List<int> elements = new List<int>(input.Count/2); 
            for (int i = 0; i < elements.Count / 2; i++)
            {
                elements[i] = input[k / 4 - 1 - i] + input[k / 4 + i];
                elements[k / 2 - 1 - i] = input[k / 2 + k / 4 + i] + input[k / 2 + k / 4 - 1 - i];
            }
            Console.WriteLine(string.Join(" ", elements));
        }
    }
}

                   