using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.AnonymousThreat
{
    class AnonymousThreat
    {
        static void Main()
        {
            List<string> elements = Console.ReadLine().Split().ToList();
            string input = Console.ReadLine();

            while (input != "3:1")
            {
                string[] commandArgs = input.Split();
                string command = commandArgs[0];

                switch (command)
                {
                    case "merge":
                        int startIndex = int.Parse(commandArgs[1]);
                        int endIndex = int.Parse(commandArgs[2]);
                        startIndex = validateIndex(startIndex, elements.Count);
                        endIndex = validateIndex(endIndex, elements.Count);
                        elements = MergeAndReturn(startIndex, endIndex, elements);
                        break;



                    case "divide":
                        int index = int.Parse(commandArgs[1]);
                        int partitions = int.Parse(commandArgs[2]);
                        List<string> part = SplittedEqually(elements[index], partitions);
                        elements.RemoveAt(index);
                        elements.InsertRange(index, part);
      
                        break;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", elements));
        }

        private static List<string> SplittedEqually(string word, int partitions)
        {
            List<string> result = new List<string>();
            int part = word.Length / partitions;

            while (word.Length >= part)
            {
                result.Add(word.Substring(0, part));
                word = word.Substring(part);
            }
            if (word.Length != 0)
            {
                result.Add(word);
            }
            if (result.Count == partitions)
            {
                return result; 
            }
            else
            {
                string concatLastTwoElements = result[result.Count - 2] + result[result.Count - 1];
                result.RemoveRange(result.Count - 2, 2);
                result.Add(concatLastTwoElements);
                return result;
            }
        }

        private static List<string> AfterTheDevision(List<string> elements, int index, int partitions)
        {
            string elToDivide = elements.GetRange(index, 1).ToString();
            return elements;
        }
    
        private static int validateIndex(int index, int count)
        {
            if (index < 0)
            {
                index = 0;
            }
            if (index > count - 1)
            {
                index = count - 1;
            }
            return index;
        }
        private static List<string> MergeAndReturn(int startIndex, int endIndex, List<string> elements)
        {
            string merged = "";
            for (int i = startIndex; i <= endIndex; i++)
            {
                merged += elements[i];
            }
            for (int i = startIndex; i <= endIndex; i++)
            {
                elements.RemoveAt(startIndex);
            }
            elements.Insert(startIndex, merged);
            return elements;
        }
    }
}
