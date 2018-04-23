using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Trainlands
{
    class Trainlands
    {
        static void Main()
        {
           // Solution1(); // 60/100
            Solution2();
        }
        private static void Solution2()
        {
            string inputLine = Console.ReadLine();
            Dictionary<string, Dictionary<string, int>> dict = new Dictionary<string, Dictionary<string, int>>();

            while (inputLine != "It's Training Men!")
            {
                string[] input = inputLine.Split(new char[]
                {' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (input.Length == 5)
                {
                    string trainName = input[0];
                    string wagonName = input[2];
                    int wagonPower = int.Parse(input[4]);
                    if (!dict.ContainsKey(trainName))
                    {
                        dict.Add(trainName, new Dictionary<string, int>());
                    }
                    if (!dict[trainName].ContainsKey(wagonName))
                    {
                        dict[trainName].Add(wagonName, wagonPower);
                    }
                    dict[trainName][wagonName] = wagonPower;
                }
                if (input.Length == 3 && input[1] == "->")
                {
                    string trainName = input[0];
                    string otherTrainName = input[2];

                    if (dict.ContainsKey(trainName))
                    {
                        foreach (var item in dict[otherTrainName])
                        {
                            dict[trainName].Add(item.Key, item.Value);
                        }                
                        dict.Remove(otherTrainName);
                    }
                    else
                    {
                        dict.Add(trainName, new Dictionary<string, int>());
                        dict.Remove(otherTrainName);
                    }
                }
                if (input.Length == 3 && input[1] == "=")
                {
                    string trainName = input[0];
                    string otherTrainName = input[1];

                    if (!dict.ContainsKey(trainName))
                    {
                        dict.Add(trainName, new Dictionary<string, int>());
                    }
                    dict[trainName].Clear();
                    foreach (var item in dict[otherTrainName])
                    {
                        dict[trainName].Add(item.Key, item.Value);
                    }
                }

                inputLine = Console.ReadLine();
            }
            foreach (var item in dict)
            {
                Console.WriteLine($"Train: {item.Key}");
                foreach (var it in item.Value)
                {
                    Console.WriteLine($"{it.Key} : { it.Value}");
                }
            }

        }



















        private static void Solution1()
        {
            string input = Console.ReadLine();
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();


            while (input != "It's Training Men!")
            {
                string[] inputLine = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (inputLine.Length == 5)
                {
                    string name = inputLine[0];
                    string wagon = inputLine[2] + " - " + inputLine[4];
                    if (!dict.ContainsKey(name))
                    {
                        dict.Add(name, new List<string>());
                    }
                    dict[name].Add(wagon);
                }
                if (inputLine.Length == 3 && inputLine[1] == "->")
                {
                    string trainName = inputLine[0];
                    string otherTrainName = inputLine[2];

                    if (dict.ContainsKey(trainName))
                    {
                        dict[trainName].AddRange(dict[otherTrainName]);
                        dict.Remove(otherTrainName);
                    }
                    else
                    {
                        dict.Add(trainName, dict[otherTrainName]);
                        dict.Remove(otherTrainName);
                    }
                }
                if (inputLine.Length == 3 && inputLine[1] == "=")
                {
                    string trainName = inputLine[0];
                    string otherTrainName = inputLine[2];

                    if (dict.ContainsKey(trainName))
                    {
                        dict[trainName] = dict[otherTrainName];
                    }
                    else
                    {
                        dict.Add(trainName, dict[otherTrainName]);
                    }
                }
                input = Console.ReadLine();
            }

            foreach (var item in dict.OrderByDescending(x => x.Value.Sum((y => int.Parse(y.Split(new char[]
            { ' ', '-'}, StringSplitOptions.RemoveEmptyEntries).Last())))).ThenBy(x => x.Value.Count))
            {
                Console.WriteLine($"Train: {item.Key}");
                foreach (var it in item.Value.OrderByDescending(x => int.Parse(x.Split(new char[]
               { ' ', '-'}, StringSplitOptions.RemoveEmptyEntries).Last())))
                {
                    Console.WriteLine("###" + it);
                }
            }
        }
    }
}

