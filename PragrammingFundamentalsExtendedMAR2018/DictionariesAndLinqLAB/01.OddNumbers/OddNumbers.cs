using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.OddNumbers
{
    class OddNumbers
    {
        static void Main()
        {
            List<string> words = Console.ReadLine().ToLower().Split().ToList();
            Dictionary<string, int> dict = new Dictionary<string, int>();

            for (int i = 0; i < words.Count; i++)
            {
                if (!dict.ContainsKey(words[i]))
                {
                    dict[words[i]] = 0;
                }
                dict[words[i]]++; 
            }

            List<string> result = new List<string>();

            foreach (var item in dict)
            {
                if (item.Value % 2 != 0)
                {
                    result.Add(item.Key);
                }              
            }
            Console.WriteLine(string.Join(", ", result));


        }
    }
}
