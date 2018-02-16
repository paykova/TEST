using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ChangeList
{
    public class ChangeList
    {
        public static void Main()
        {


            // Solution1();
            Solution2();

        }

        private static void Solution2()
        {
            List<int> elements = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                string[] commands = Console.ReadLine().Split();

                if (commands[0] == "Odd")
                {
                    for (int i = 0; i < elements.Count; i++)
                    {
                        if (elements[i] % 2 != 0)
                        {
                            Console.Write(elements[i] + " ");
                        }
                    }
                    break;
                }
                if (commands[0] == "Even")
                {
                    for (int i = 0; i < elements.Count; i++)
                    {
                        if (elements[i] % 2 == 0)
                        {
                            Console.Write(elements[i] + " ");
                        }
                    }
                    break;
                }
                if (commands[0] == "Delete")
                {
                    for (int i = 0; i < elements.Count; i++)
                    {
                        if (elements[i] == int.Parse(commands[1]))
                        {
                            elements.Remove(elements[i]);
                            i--;
                        }
                    }
                }
                if (commands[0] == "Insert")
                {
                    elements.Insert(int.Parse(commands[2]), int.Parse(commands[1]));
                }               
            }
        }

        public static void Solution1()
        {
            List<int> elements = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            string[] commands = Console.ReadLine().Split(' ');

            while (commands[0] != "Odd" && commands[0] != "Even")
            {
                if (commands[0] == "Delete")
                {
                    for (int i = 0; i < elements.Count; i++)
                    {
                        if (elements[i] == int.Parse(commands[1]))
                        {
                            elements.Remove(elements[i]);
                            i--;
                        }
                    }

                }
                else if (commands[0] == "Insert")
                {
                    elements.Insert(int.Parse(commands[2]), int.Parse(commands[1]));
                }

                commands = Console.ReadLine().Split(' ');
            }

            if (commands[0] == "Odd")
            {
                var oddNumbers = elements.Where(n => n % 2 != 0);
                Console.WriteLine(string.Join(" ", oddNumbers));
            }
            else if (commands[0] == "Even")
            {
                var evenNumbers = elements.Where(n => n % 2 == 0);
                Console.WriteLine(string.Join(" ", evenNumbers));
            }
        }
    }
}

