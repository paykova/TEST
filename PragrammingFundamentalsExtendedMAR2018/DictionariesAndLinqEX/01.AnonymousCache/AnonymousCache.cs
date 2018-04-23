using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.AnonymousCache
{
    class AnonymousCache
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Dictionary<string, Dictionary<string, long>> dict = new Dictionary<string, Dictionary<string, long>>(); 

            while (input != "thetinggoesskrra")
            {
                string[] infoInput = input.Split(new char[] { ' ', '-', '>', '|'}, StringSplitOptions.RemoveEmptyEntries).ToArray(); 

                if (infoInput.Length == 1)
                {
                    string dataSet = infoInput[0];
                    if (!dict.ContainsKey(dataSet))
                    {
                        dict.Add(dataSet, new Dictionary<string, long>()); 
                    }
                }
                if (infoInput.Length == 3)
                {
                    string dataKey = infoInput[0];
                    long dataSize = long.Parse(infoInput[1]);
                    string dataSet = infoInput[2]; 

                    if (!dict.ContainsKey(dataSet))
                    {
                        dict.Add(dataSet, new Dictionary<string, long>()); 
                    }
                    if (!dict.ContainsKey(dataKey))
                    {
                        dict[dataSet].Add(dataKey, dataSize);
                    }
                    dict[dataSet][dataKey] = dataSize; 
                }
                input = Console.ReadLine(); 
            }

            if (dict.Count > 1)
            {
                foreach (var item in dict.OrderByDescending(x => x.Value.Values.Sum()))
                {
                    long count = item.Value.Values.Sum();
                    Console.WriteLine($"Data Set: {item.Key}, Total Size: {count}");

                    foreach (var it in item.Value)
                    {
                        Console.Write("$." + it.Key + "\n");
                    }
                    break;
                }
            }            
        }
    }
}
