using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Largest3Numbers
{
    class Largest3Numbers
    {
        static void Main()
        {
            List<int> elements = Console.ReadLine().Split().Select(int.Parse).ToList();

            elements.Sort();
            if (elements.Count <= 3)
            {
                for (int i = elements.Count - 1; i >= 0; i--)
                {
                    Console.Write(elements[i] + " ");
                }
            }
            else
            {
                for (int i = elements.Count - 1; i > elements.Count - 4; i--)
                {
                    Console.Write(elements[i] + " ");
                }
            }
           
        }
    }
}
