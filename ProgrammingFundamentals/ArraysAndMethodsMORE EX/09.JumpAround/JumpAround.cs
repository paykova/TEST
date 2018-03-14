using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.JumpAround
{
    class JumpAround
    {
        static void Main()
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int i = 0;
            int sum = 0;


            while (i >= 0)
            {
                if (i < input.Length)
                {
                    sum += input[i];
                    i = i + input[i] < input.Length ? i + input[i] : i - input[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
