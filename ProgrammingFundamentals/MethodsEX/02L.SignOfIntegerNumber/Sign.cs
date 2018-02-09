using System;

namespace _02L.SignOfIntegerNumber
{
    public class Sign
    {
        public static void Main()
        {
            PrintSign();
        }

        private static void PrintSign()
        {
            int n = int.Parse(Console.ReadLine());

            if (n > 0)
            {
                Console.WriteLine($"The number {n} is positive.");
            }
            else if (n < 0)
            {
                Console.WriteLine($"The number {n} is negative.");
            }
            else if (n==0)
            {
                Console.WriteLine($"The number 0 is zero.");
            }
        }
    }
}
