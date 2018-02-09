using System;
using System.Linq;

namespace _08.CondenseArrayToNumber
{
    public class CondenseArrayToNumber
    {
        public static void Main()
        {
            int[] nums = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToArray();

            int i = 0;
            int[] condensed = new int[nums.Length - 1];
            while (condensed.Length >1)
            {
                
                condensed[i] = nums[i] + nums[i + 1];
                i++; 
                nums = condensed; 
            }
            Console.WriteLine(condensed[0]);          
        }
    }
}
