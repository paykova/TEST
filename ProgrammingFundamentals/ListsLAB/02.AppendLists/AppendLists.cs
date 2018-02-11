using System;
using System.Linq;
using System.Collections.Generic;

namespace _02.AppendLists
{
    public class AppendLists
    {
        public static void Main()
        {
            var elements = Console.ReadLine()
                 .Split('|')
                 .ToList();

          var result = new List<string>(); 

            for (int i = elements.Count - 1; i >= 0; i--)
            {
                Console.Write(elements[i] + " ");
            }
        }
    }
}
