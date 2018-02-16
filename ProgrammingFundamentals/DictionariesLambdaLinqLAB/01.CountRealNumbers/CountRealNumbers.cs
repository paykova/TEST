using System;
using System.Linq;
using System.Collections.Generic;

namespace _01.CountRealNumbers
{
    public class CountRealNumbers
    {
        public static void Main()
        {
            List<double> elements = Console.ReadLine()
                 .Split()
                 .Select(double.Parse)
                 .ToList();

            SortedDictionary<double, int> countElements = new SortedDictionary<double, int>();

            for (int i = 0; i < elements.Count; i++)
            {
                if (countElements.ContainsKey(elements[i]))
                {
                    countElements[elements[i]]++;
                }
                else
                {
                    countElements[elements[i]] = 1; 
                }
            }           
            foreach (var item in countElements)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }           
        }
    }
}
