using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Ladybugs
{
    class Ladybugs
    {
        static void Main()
        {
            int length = int.Parse(Console.ReadLine());
            List<int> indexes = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .Where(i => i >= 0 && i < length)
                .ToList();
            string input = Console.ReadLine();
            int[] ladybugs = new int[length];

            foreach (var index in indexes)
            {
                ladybugs[index] = 1;
            }


            while (input != "end")
            {
                string[] commandArgs = input.Split();
                int ladybugIndex = int.Parse(commandArgs[0]);
                string direction = commandArgs[1];
                int flyLength = int.Parse(commandArgs[2]);
               
                if (direction == "left")
                {
                    flyLength *= -1; 
                }
                if (ladybugIndex < 0 
                    || ladybugIndex >= length)
                {
                    continue;
                }
                if (ladybugs[ladybugIndex] == 0)
                {
                    continue;
                }
                ladybugs[ladybugIndex] = 0;
                int newIndex = ladybugIndex;
                while (true)
                {
                    newIndex += flyLength; 
                    
                    if (newIndex < 0 || newIndex >= length)
                    {
                        break;
                    }
                    if (ladybugs[newIndex] == 1)
                    {
                        continue;
                    }
                    ladybugs[newIndex] = 1;
                    break;
                }
                input = Console.ReadLine();
                            }
            Console.WriteLine(string.Join(" ", ladybugs));
        }
    }
}
