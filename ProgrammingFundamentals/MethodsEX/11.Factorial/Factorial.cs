using System;
using System.Numerics;

namespace _11.Factorial
{
    public class Factorial
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Factor(n);

        }

        private static void Factor(int n)
        {
            BigInteger sum = 1;
            for (int i = 1; i <= n; i++)
            {

                sum = sum * i;
            }
            Console.WriteLine(sum);
        }
    }
}
