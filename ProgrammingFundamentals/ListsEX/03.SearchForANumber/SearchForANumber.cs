using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.SearchForANumber
{
    public class SearchForANumber
    {
        public static void Main()
        {
           // Solution1();
            Solution2();   
        }

        private static void Solution2()
        {
            List<int> elements = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToList();

            string[] commands = Console.ReadLine().Split();
            bool isFound = false; 

            for (int i = int.Parse(commands[1]); i < int.Parse(commands[0]); i++)
            {
                if (elements[i] == int.Parse(commands[2]))
                {
                    isFound = true;
                    Console.WriteLine("YES!");
                }
            }
            if(!isFound)
            {
                Console.WriteLine("NO!");
            }
        }

        private static void Solution1()
        {
            List<int> elements = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            bool isFound = false;

            string[] commands = Console.ReadLine().Split(' ');

            int takeCommand = int.Parse(commands[0]);
            int deleteCommand = int.Parse(commands[1]);
            int searchCommand = int.Parse(commands[2]);

            var taken = elements.Take(takeCommand).ToList();
            var afterDeleting = taken.Skip(deleteCommand).Take(taken.Count - deleteCommand).ToList();

            for (int i = 0; i < afterDeleting.Count; i++)
            {
                if (afterDeleting[i] == searchCommand)
                {
                    isFound = true;
                }
            }
            if (isFound)
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
