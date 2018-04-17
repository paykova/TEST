using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.CODE
{
    class CODE
    {
        static void Main()
        {
            string inputLine = Console.ReadLine();
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

            while (inputLine != "Blaze it!")
            {
                string[] input = inputLine.Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string creature = input[0];
                string squadMate = input[1];

                if (!dict.ContainsKey(creature))
                {
                    dict.Add(creature, new List<string>());
                    dict[creature].Add(squadMate);
                }
                else
                {
                    if (!dict[creature].Contains(squadMate) && squadMate != creature)
                    {
                        dict[creature].Add(squadMate);
                    }
                }
                inputLine = Console.ReadLine();
            }
            foreach (var item in dict)
            {
                for (int i = 0; i < item.Value.Count; i++)
                {
                    if (dict.ContainsKey(item.Value[i]))
                    {
                        if (dict[item.Value[i]].Contains(item.Key))
                        {
                            dict[item.Value[i]].Remove(item.Key);
                            dict[item.Key].Remove(item.Value[i]);
                            i--;
                        }
                    }
                }
            }
            foreach (var item in dict.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine(item.Key + " : " + item.Value.Count);
            }
        }
    }
}
