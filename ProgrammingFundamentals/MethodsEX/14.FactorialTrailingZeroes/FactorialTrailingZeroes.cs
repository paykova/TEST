using System;
using System.Numerics;

namespace _14.FactorialTrailingZeroes
{
    class FactorialTrailingZeroes
    {
        static void Main(string[] args)
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
           // Console.WriteLine(sum);

            string text = sum.ToString();

            var count = 0; 
            for (int i = 0; i < text.Length; i++)
            {
                if (text[text.Length - 1 - i] == 48)
                {
                    count ++;
                }
                else
                {
                    break; 
                }
            }
            Console.WriteLine(count);
        }
    }
}
