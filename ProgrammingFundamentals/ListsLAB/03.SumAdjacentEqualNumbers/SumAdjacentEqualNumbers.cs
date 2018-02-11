using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.SumAdjacentEqualNumbers
{
    public class SumAdjacentEqualNumbers
    {
        public static void Main()
        {
            Solution1();
            // Solution2();
        }

        private static void Solution2()
        {
            List<decimal> elements = Console.ReadLine()
                  .Split(' ')
                  .Select(decimal.Parse)
                  .ToList();

            decimal sum = 0;
            int i = 0;

            while (i < elements.Count - 1)  //8 2 2 4 8 16
            {
                if (elements[i] == elements[i + 1])
                {
                    sum = elements[i] + elements[i + 1];
                    elements[i] = sum;
                    elements.Remove(elements[i + 1]);
                    i--;

                }
                i++;
            }
            Console.WriteLine(string.Join(" ", elements));
        }
    
    private static void Solution1()
    {
        List<string> input = Console.ReadLine().Split().ToList();
        List<double> nums = new List<double>();
        foreach (string inputNum in input)
        {
            nums.Add(double.Parse(inputNum));
        }
        for (int i = 0; i < nums.Count - 1; i++) //8 2 2 4 8 16   //3 3 6 1
            {
            if (nums[i] == nums[i + 1])
            {
                nums[i] = nums[i] + nums[i + 1];
                nums.Remove(nums[i + 1]);
                i = -1; // In order the loop to start from the beginning after the modification of the list
            }
        }
        Console.WriteLine(string.Join(" ", nums));
    }
}
}
