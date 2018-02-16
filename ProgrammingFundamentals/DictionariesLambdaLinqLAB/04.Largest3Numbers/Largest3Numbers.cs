using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Largest3Numbers
{
    public class Largest3Numbers
    {
        public static void Main()
        {
            List<double> realNumbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList();

            var selected = realNumbers.OrderBy(n => n).ToList();
            selected.Reverse();

            if (selected.Count > 2)
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(selected[i] + " ");
                }
            }
            else
            {
                Console.WriteLine(string.Join(" ", selected));
            }   
        }
    }
}
