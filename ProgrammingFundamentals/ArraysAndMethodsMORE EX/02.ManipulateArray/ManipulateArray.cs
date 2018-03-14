using System;
using System.Linq; 
using System.Collections.Generic; 

namespace _02.ManipulateArray
{
    class ManipulateArray
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(); 
                if(command[0] == "Reverse")
                {
                    Array.Reverse(input);
                }
                if(command[0] == "Distinct")
                {
                    input = input.Distinct().ToArray(); 
                }
                if (command[0] == "Replace")
                {
                    var index = int.Parse(command[1]);
                    var word = command[2];
                    input[index] = word; 
                }
            }
            Console.WriteLine(string.Join(", ", input));  
        }
    }
}
