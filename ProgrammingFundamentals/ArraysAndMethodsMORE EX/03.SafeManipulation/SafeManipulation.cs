using System;
using System.Linq;
using System.Collections.Generic;

namespace _03.SafeManipulation
{
    class SafeManipulation
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split();
            string text = Console.ReadLine();

            while (text != "END")
            {
                string[] command = text.Split();

                if (command[0] == "Reverse")
                {
                    Array.Reverse(input);
                }
                else if (command[0] == "Distinct")
                {
                    input = input.Distinct().ToArray();
                }
                else if (command[0] == "Replace")
                {
                    var index = int.Parse(command[1]);
                    var word = command[2];
                    if (index >= 0 && index < input.Length)
                    {
                        input[index] = word;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
                text = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", input));
        }
    }
}

