using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.ArrayMnipulator
{
    public class ArrayManipulator
    {
        public static void Main()
        {
            List<long> elements = Console.ReadLine()
                .Split(' ')
                .Select(long.Parse)
                .ToList();
            List<long> input = new List<long>();


            bool doesContain = false;
            var index = 0;

            while (true)
            {
                string[] commands = Console.ReadLine().Split(' ');

                if (commands[0] == "print")
                {
                    Console.Write("[");
                    Console.Write(string.Join(", ", elements));
                    Console.WriteLine("]");
                    break;
                }

                if (commands[0] == "add")
                {
                    elements.Insert(int.Parse(commands[1]), int.Parse(commands[2]));
                }
                else if (commands[0] == "addMany")
                {
                    for (int i = 2; i < commands.Length; i++)
                    {
                        var currentNumber = int.Parse(commands[i]);
                        input.Add(currentNumber);
                    }
                    elements.InsertRange(int.Parse(commands[1]), input);
                }
                else if (commands[0] == "contains")
                {
                    for (int i = 0; i < elements.Count; i++)
                    {
                        if (int.Parse(commands[1]) == elements[i])
                        {
                            doesContain = true;
                            index = i;
                            break;
                        }
                    }
                    if (doesContain)
                    {
                        Console.WriteLine(index);
                    }
                    else
                    {
                        Console.WriteLine("-1");
                    }
                    doesContain = false;
                }
                else if (commands[0] == "remove")
                {
                    elements.RemoveAt(int.Parse(commands[1]));
                }
                else if (commands[0] == "shift")
                {
                    for (int j = 0; j < int.Parse(commands[1]); j++)
                    {
                        var temp = elements[0];
                        for (int i = 0; i < elements.Count - 1; i++)
                        {
                            elements[i] = elements[i + 1];
                        }
                        elements[elements.Count - 1] = temp;
                    }
                }
                else if (commands[0] == "sumPairs")
                {

                    List<long> sumList = new List<long>();
                    for (int i = 0; i < elements.Count - 1; i += 2)
                    {
                        sumList.Add(elements[i] + elements[i + 1]);
                    }
                    if (elements.Count % 2 == 1)
                    {
                        sumList.Add(elements[elements.Count - 1]);
                    }

                    elements = sumList;
                }

            }
        }
    }
}