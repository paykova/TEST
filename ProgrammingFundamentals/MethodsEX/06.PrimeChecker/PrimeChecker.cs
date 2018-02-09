using System;

namespace _06.PrimeChecker
{
    public class PrimeChecker
    {
        public static void Main()
        {

            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(IsPrime(n));
        }

        static bool IsPrime(int n)
        {
            if ((n == 0) || (n == 1))
            {
                return false;
            }
            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                {

                    return false;
                }
            }
            return true;
        }
    }
}
