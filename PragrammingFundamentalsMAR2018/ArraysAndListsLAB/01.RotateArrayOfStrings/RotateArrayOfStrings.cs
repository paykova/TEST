using System;

namespace _01.RotateArrayOfStrings
{
    class RotateArrayOfStrings
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split();

            string lastElements = input[input.Length - 1];

            for (int i = 1; i < input.Length; i++)
            {
                input[input.Length - i] = input[input.Length-1-i]; 
            }
            input[0] = lastElements;
            Console.WriteLine(string.Join(" ", input));
        }
    }
}
