using System;

namespace _06.ReverseAnArrayOfStrings
{
    public class ReverseAnArrayOfStrings
    {
       public static void Main()
        {
            string[] elements = Console.ReadLine()
                .Split(" ");

            for (int i = elements.Length - 1; i >= 0; i--)
            {
                Console.Write(elements[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
