using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.SquareNumbers
{
    public class SquareNumbers
    {
        public static void Main()
        {
            List<int> elements = Console.ReadLine()
                 .Split(' ')
                 .Select(int.Parse)
                 .ToList();
       
            elements.Sort();
            elements.Reverse();

            for (int i = 0; i < elements.Count; i++)
            {
                var temp = Math.Sqrt(elements[i]); 
                if (temp == (int)(temp))
                {
                    Console.Write(elements[i] + " ");
                }
                
            }
            Console.WriteLine();

        }
    }
}
