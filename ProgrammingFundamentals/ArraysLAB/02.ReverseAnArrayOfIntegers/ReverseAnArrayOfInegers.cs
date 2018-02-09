using System;

namespace _02.ReverseAnArrayOfIntegers
{
    public class ReverseAnArrayOfInegers
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arrayOfIntegers = new int[n];

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                arrayOfIntegers[i] = number; 
            }

            for (int i = arrayOfIntegers.Length - 1; i >= 0; i--)
            {
                Console.Write(arrayOfIntegers[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
