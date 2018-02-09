using System;

namespace _05.FibonacciNumbers
{
    public class Fib
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            FibonacciNumbers(n);


        }

        private static void FibonacciNumbers(int n)
        {
            int[] array = new int[n + 1];

            for (int i = 0; i <= n; i++)
            {
                if ((i == 0) || (i == 1))
                {
                    array[i] = 1;
                }
                else
                {
                    array[i] = array[i - 1] + array[i - 2];
                }
            }
            Console.WriteLine(array[array.Length - 1]);
        }
    }
}

