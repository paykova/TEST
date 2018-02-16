using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.SumReversedNumbers
{
    public class SumReversedNumbers
    {
        public static void Main()
        {
            // 123 234 12	774

            List<int> elements = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            long sum = 0; 
            for (int i = 0; i < elements.Count; i++)
            {
                var r = 0;
                var number = elements[i];
                while (number != 0)
                {              
                    var digit = number % 10;
                   r = r * 10 + digit; 
                    number = number / 10;
               }
                sum += r;     
            }
            Console.WriteLine(sum);
        }
    }
}
