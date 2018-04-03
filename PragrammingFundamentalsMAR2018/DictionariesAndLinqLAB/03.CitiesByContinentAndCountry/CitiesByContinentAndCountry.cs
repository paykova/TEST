using System;
using System.Collections.Generic;

namespace _03.CitiesByContinentAndCountry
{
    class CitiesByContinentAndCountry
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, List<string>>> dict = new Dictionary<string, Dictionary<string, List<string>>>();



            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                string continent = input[0];
                string country = input[1];
                string city = input[2];

                if ((!dict.ContainsKey(continent)))
                {
                    dict.Add(continent, new Dictionary<string, List<string>>());
                }
                if (!dict[continent].ContainsKey(country))
                {
                    dict[continent].Add(country, new List<string> { city });
                }
                else
                {
                    dict[continent][country].Add(city);
                }

                //if ((!dict.ContainsKey(continent)))
                //{
                //    dict.Add(continent, new Dictionary<string, List<string>>());
                //}
                //if (!dict[continent].ContainsKey(country))
                //{
                //    dict[continent].Add(country, new List<string>());
                //}
                //if (!dict[continent][country].Contains(city))
                //{
                //    dict[continent][country].Add(city);
                //}

            }

            foreach (var item in dict)
            {
                Console.WriteLine(item.Key + ":");
                foreach (var it in item.Value)
                {
                    Console.Write("  " + it.Key + " -> ");
                    Console.WriteLine(string.Join(", ", it.Value));
                }
            }
        }
    }
}
